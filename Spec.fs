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
let githubUsername = "GitHub Action"
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
