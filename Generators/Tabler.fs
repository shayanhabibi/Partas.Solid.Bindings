module Generators.Tabler
open EasyBuild.FileSystemProvider

type TablerFiles = VirtualFileSystem<".", """
temp
    node_modules
        @tabler
            icons-solidjs
                dist
                    esm
                        icons/
""">


module Spec =
    [<Literal>]
    let tablerPath =
        TablerFiles
            .temp
            .node_modules
            .``@tabler``
            .``icons-solidjs``
            .dist
            .esm
            .icons
            .``.``
    [<Literal>]
    let outPath =
        Spec.Files.Root.``Partas.Solid.Tabler``.``Tabler.fs``

module TablerGenerator =
    let renderIdentifierMember (identifier: string) =
        $"""
    [<Erase; Import("{identifier}", "@tabler/icons-solidjs")>]
    type {identifier |> Lucide.Helpers.appendApostropheToReservedKeywords}() =
        inherit IconNode()"""
    let renderDocument (parsedIdentifiers: string array) =
        [
            """namespace Partas.Solid.Tabler
// THIS FILE IS AUTO GENERATED
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IconNode() =
    interface VoidNode
    interface SvgSVGAttributes
    [<DefaultValue>]
    val mutable key: U2<string, int>
    [<DefaultValue>]
    val mutable color: string
    [<DefaultValue>]
    val mutable strokeWidth: float
    [<DefaultValue>]
    val mutable title: string
    [<DefaultValue>]
    val mutable displayName: string
[<Erase>]
module Tabler ="""
            for identifier: string in parsedIdentifiers do
                renderIdentifierMember identifier
        ] |> String.concat ""

open System.IO
open Fake.IO
let generateTablerFile () =
    Directory.GetFiles(Spec.tablerPath)
    |> Array.choose (
        Path.GetFileNameWithoutExtension
        >> function
            | name when name.StartsWith("Icon") ->
                name.Substring(4)
                |> _.Replace(".js", "")
                |> Some
            | _ -> None
        )
    |> Array.distinct
    |> TablerGenerator.renderDocument
    |> fun render -> File.WriteAllText(Spec.outPath, render)
    
