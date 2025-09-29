module Spec

open EasyBuild.FileSystemProvider
open Fake.Core

module Files =
    type Root = AbsoluteFileSystem<__SOURCE_DIRECTORY__>

module Ops =
    [<Literal>]
    let Setup = "Setup"
    [<Literal>]
    let Clean = "Clean"
    [<Literal>]
    let GitNet = "GitNet"
    [<Literal>]
    let Build = "Build"
    [<Literal>]
    let Pack = "Pack"
    [<Literal>]
    let GitPush = "GitPush"
    [<Literal>]
    let Publish = "Publish"
    [<Literal>]
    let GenerateLucide = "GenerateLucide"
    [<Literal>]
    let GenerateTabler = "GenerateTabler"

module Args =
    let mutable local: bool = false
    let mutable apiKey: string option = None
    let mutable parallelise: bool = false
    let setArgs args =
        let containsArgs arg =
            args |> Array.contains arg
        let getArgValue arg =
            args
            |> Array.tryFindIndex ((=) arg)
            |> Option.map ((+) 1)
            |> Option.bind(fun idx ->
                Array.tryItem idx args)
        parallelise <- containsArgs "--parallel"
        apiKey <- getArgValue "--nuget-api-key"
        local <- containsArgs "--local"
open Fake.IO.Globbing.Operators
let sourceFiles =
    !! "**/*.fs"
    -- "**/obj/**/*.*"
    -- "**/AssemblyInfo.fs"
[<Literal>]
let githubUsername = "GitHub Action"
[<Literal>]
let githubEmail = "41898282+github-actions[bot]@users.noreply.github.com"

// Credit SAFE STACK
let initializeContext () =
    let execContext = Context.FakeExecutionContext.Create false "build.fsx" []
    Context.setExecutionContext (Context.RuntimeContext.Fake execContext)

let createProcess exe args dir =
    CreateProcess.fromRawCommand exe args
    |> CreateProcess.withWorkingDirectory dir
    |> CreateProcess.ensureExitCode
    
let dotnet args dir = createProcess "dotnet" args dir

module Parser =
    type GitStatus =
        | Added of string
        | Modified of string
    open XParsec
    open XParsec.CharParsers
    let parseGitStatus (arr: string list) =
        let statusChars = tuple4 anyChar anyChar anyChar (manyChars anyChar)
        let getGitStatusFrom (input: string) =
            let reader = Reader.ofString input false
            statusChars reader
            |> function
                | Ok { Parsed = value } -> Some value
                | Error e ->
                    ErrorFormatting.formatStringError input e
                    |> printfn "%s"
                    None
            |> Option.bind (fun struct (c1,c2,c3,path) ->
                match c1,c2 with
                
                | 'M', _
                | _, 'M' ->
                    GitStatus.Modified path
                    |> Some
                | 'A', _ ->
                    GitStatus.Added path
                    |> Some
                | _ -> None
                )
        arr
        |> List.map getGitStatusFrom
        |> List.choose id
        
            
