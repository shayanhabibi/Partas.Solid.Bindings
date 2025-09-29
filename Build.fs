module Build
open Partas.GitNet
open Spec.Ops

Spec.initializeContext()

let gitnetConfig =
    {
        GitNetConfig.initFSharp with
            RepositoryPath = __SOURCE_DIRECTORY__
            Output.Ignore = Defaults.ignoreCommits @ [
                IgnoreCommit.SkipCi
            ]
            Bump.DefaultBumpStrategy = ForceBumpStrategy.All
            ProjectType =
                {
                    ProjectFSharpConfig.init with
                        IgnoredProjects = Projects.ignored
                }
                |> Some
                |> ProjectType.FSharp
    }

open Partas.GitNet.RepoCracker
let runtime = lazy new GitNetRuntime(gitnetConfig)
let crackedProjects =
    lazy
    runtime.Value
    |> _.CrackRepo
    |> Seq.choose(
        function
            | CrackedProject.FSharp { GitNetOptions = { Scope = Some _ } } as proj ->
                Some proj
            | _ -> None
        )

open Fake.Core
open Fake.Tools
open Spec

Target.create Ops.Setup <| fun args ->
    task {
        crackedProjects.Value
        |> ignore
    } |> ignore
    if not Args.local then
        [ $"config --local user.email \"{githubEmail}\""
          $"config --local user.name \"{githubUsername}\"" ]
        |> List.iter (Git.CommandHelper.directRunGitCommandAndFail Files.Root.``.``)
    
Target.create Ops.GitNet <| fun args ->
    let runtime = runtime.Value
    if Args.local then
        let bumps,content = runtime.DryRun()
        bumps
        |> Seq.map (fun keyval ->
            (keyval.Key, keyval.Value.SemVer.ToString(), keyval.Value.ToString())
            |||> sprintf "Scope: %s | Next: %s | SepochSemver: %s")
        |> Trace.logItems "GitNet"
        runtime.WriteToOutput content
        |> ignore
    else
        runtime.Run(githubUsername, githubEmail)
        |> ignore

open Fake.IO.Globbing.Operators
open Fake.IO
Target.create Ops.Clean <| fun args ->
    !! "**/**/bin"
    -- "bin"
    ++ "temp/"
    |> Shell.cleanDirs
    
open Fake.DotNet
open Projects
Target.create Ops.Build <| fun args ->
    Projects.projects
    |> List.toArray
    |> (if Args.parallelise
        then Array.Parallel.iter
        else Array.iter) (
        _.Path
        >> FsProjPath.value
        >> DotNet.build
            (fun p ->
                {
                    p with
                        Configuration = DotNet.BuildConfiguration.Release
                        // for me :')
                        DotNet.BuildOptions.MSBuildParams.DisableInternalBinLog = true
                })
        )

Target.create Ops.Pack <| fun args ->
    projects
    |> List.toArray
    |> (if Args.parallelise
        then Array.Parallel.iter
        else Array.iter) (
        _.Path >> FsProjPath.value
        >> DotNet.pack (fun p ->
            {
                p with
                    NoRestore = true
                    OutputPath = Some "bin"
                    // for me :')
                    DotNet.PackOptions.MSBuildParams.DisableInternalBinLog = true
            })
        )

Target.create Ops.GitPush <| fun _ ->
    Git.Branches.push Files.Root.``.``
    Git.CommandHelper.directRunGitCommandAndFail Files.Root.``.`` "push --tags origin"

Target.create Ops.Publish <| fun args ->
    !!"bin/*.nupkg"
    |> Seq.toArray
    |> (if Args.parallelise
        then Array.Parallel.iter
        else Array.iter) (fun path ->
        path
        |> DotNet.nugetPush (fun p ->
            {
                p with
                    DotNet
                        .NuGetPushOptions
                        .PushParams
                        .Source = Some "https://api.nuget.org/v3/index.json"
                    DotNet
                        .NuGetPushOptions
                        .Common
                        .CustomParams = Some "--skip-duplicate"
                    DotNet
                        .NuGetPushOptions
                        .PushParams
                        .ApiKey = Args.apiKey
            }))

open Generators
open Fake.JavaScript
Target.create Ops.GenerateLucide <| fun args ->
    Directory.create "temp"
    Npm.exec "install lucide-solid @lucide/lab" (fun p ->
        {
            p with
                WorkingDirectory = Path.combine Files.Root.``.`` "temp"
        }
        )
    Lucide.generateLucideFiles()
    Git.CommandHelper.getGitResult Files.Root.``.`` "status -s --untracked-files=no"
    |> Parser.parseGitStatus
    |> List.choose (function
        | Parser.GitStatus.Modified path
            when path.EndsWith("LucideLab.fs") || path.EndsWith("Lucide.fs") -> Some path
        | _ -> None
        )
    |> function
        | [] -> ()
        | values ->
            values
            |> List.map (sprintf "add %s")
            |> List.iter (Git.CommandHelper.directRunGitCommandAndFail Files.Root.``.``)
            Git.CommandHelper.directRunGitCommandAndFail Files.Root.``.`` "commit Partas.Solid.Lucide -m \"add(lucide): autoupdate lucide package\""
            ()
    
    Shell.cleanDir "temp"
    ()
open Fake.Core.TargetOperators

let dependenciesMapping = [
    Setup
    ==> Clean
    ==> GenerateLucide
    ==> GitNet
    ==> Build
    ==> Pack
    ==> GitPush
    ==> Publish
]

[<EntryPoint>]
let main args =
    args |> Args.setArgs
    args[0] |> Target.runOrDefaultWithArguments
    0
