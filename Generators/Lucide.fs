module Generators.Lucide

open System
open XParsec
open EasyBuild.FileSystemProvider
open Spec
type LucideFiles = VirtualFileSystem<".", """
temp
    node_modules
        @lucide
            lab
                dist
                    lucide-lab.d.ts
        lucide-solid
            dist
                types
                    aliases
                        prefixed.d.ts
            
""">

[<AutoOpen>]
module Helpers =
    // Attributable to Shmew - taken from Feliz.Generator.MaterialUI/Common.fs
    let appendApostropheToReservedKeywords =
      let reserved =
        [
          "checked"; "static"; "fixed"; "inline"; "default"; "component";
          "inherit"; "open"; "type"; "true"; "false"; "in"; "end"; "global"
        ]
        |> Set.ofList
      fun s -> if reserved.Contains s then s + "'" else s
      
module Spec =
    [<Literal>]
    let labPath = LucideFiles.temp.node_modules.``@lucide``.lab.dist.``lucide-lab.d.ts``
    [<Literal>]
    let solidPath = LucideFiles.temp.node_modules.``lucide-solid``.dist.types.aliases.``prefixed.d.ts``
    [<Literal>]
    let outLabPath = Files.Root.``Partas.Solid.Lucide``.``LucideLab.fs``
    [<Literal>]
    let outSolidPath = Files.Root.``Partas.Solid.Lucide``.``Lucide.fs``

module Parsers =
    open XParsec.CharParsers
    open XParsec.Combinators
    open XParsec.Parsers
    open XParsec.Reader
    open System.IO
    let ws = skipMany (anyOf [ ' '; '\n'; '\r'; '\r' ])
    // For lab-icons, the exports as found in a line at the end. Some of the exports as aliased such as 'hatChef as chefHat'.
    module Lab =
        let private consumeIdentifier =
            let normalExport = manyChars (asciiLetter <|> digit) .>> notFollowedBy (pstring " as ")
            let aliasedExport = manyChars (asciiLetter <|> digit) >>. pstring " as " >>. manyChars (asciiLetter <|> digit)
            normalExport <|> aliasedExport
        let private findExports = skipManyTill anyChar (pstring "export") >>. skipManyTill anyChar (pchar '{')
        let private consumeExports =
            ws >>.
            (
                sepBy1 consumeIdentifier (pstring ", ")
            ) .>> pstring " }"
        let private parseExports =
            findExports >>. consumeExports |>> fun struct(result,_) -> result
        let getLabExports path =
            let input = File.ReadAllText path
            let reader =
                (input, false)
                ||> ofString
            parseExports reader
            |> function
                | Ok { Parsed = exports } -> exports
                | Error e ->
                    Console.WriteLine(ErrorFormatting.formatStringError input e)
                    failwith ""
    // For the normal lucide icons, we can find all the icons contained in a single file via one of the
    // alias type files. We can use the prefixed file, and remove the prefix as required.
    // Some of the icons are deprecated, this should be detected and then skipped.
    module Lucide =
        let private findExport = skipManyTill anyChar (pstring "export {") >>. ws
        let private skipDeprecated = opt (pstring "/** @deprecated" >>. findExport) >>. preturn ()
        let private consumeExportIdentifier =
            ws >>. pstring "default as Lucide" >>. manyChars (asciiLetter <|> digit)
        let private consumePath =
            skipManyTill anyChar (pstring "../icons/") >>. manyCharsTill anyChar (pchar ''') |>> fst
        let private consumeExport = parser {
            do! findExport
            do! skipDeprecated
            let! ident = consumeExportIdentifier
            let! path = consumePath
            return (ident, path)
        }
        let private parseExports =
            many consumeExport
        let getExports path =
            let text = File.ReadAllText(path)
            let reader = ofString text false
            parseExports reader
            |> function
                | Ok { Parsed = exports } -> exports
                | Error e ->
                    Console.WriteLine(ErrorFormatting.formatStringError text e)
                    failwith ""
module LabGenerator =
    let renderIdentifierMember identifier =
        $"""
    [<Import("{identifier}", "@lucide/lab")>]
    static member {identifier |> appendApostropheToReservedKeywords} : LucideLab = jsNative"""
    
    let renderDocument parsedIdentifiers =
        [
            """
namespace Partas.Solid.Lucide

// THIS FILE IS AUTO-GENERATED

open Partas.Solid
open Fable.Core

[<Erase>]
type LucideLab ="""
            for identifier : string in parsedIdentifiers do
                renderIdentifierMember identifier
            """
[<Erase;Import("Icon","lucide-solid")>]
type Icon() =
    inherit IconNode()
    [<DefaultValue>]
    val mutable iconNode: LucideLab
"""
        ] |> String.concat ""

module LucideGenerator =
    let renderIdentifierMember (identifier: string, path: string) =
        $"""
    [<Erase; Import("default as {identifier}", "lucide-solid/icons/{path}")>]
    type {identifier |> appendApostropheToReservedKeywords}() =
        inherit IconNode()"""
    let renderDocument parsedIdentifiers =
        [
            """
namespace Partas.Solid.Lucide

// THIS FILE IS AUTO GENERATED

open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IconNode() =
    interface VoidNode
    [<Erase>]
    member inline this.className with get (value : string) = this.class' <- value
    /// <summary>
    /// Size of icon (px)
    /// </summary>
    [<Erase>]
    member val size : int = unbox null with get,set
    /// <summary>
    /// Colour of the icon
    /// </summary>
    [<Erase>]
    member val color : string = unbox null with get,set
    [<Erase>]
    member val strokeWidth : int = unbox null with get,set
    [<Erase>]
    member val absoluteStrokeWidth : bool = unbox null with get,set

[<Erase; AutoOpen>]
module Lucide ="""
            for identifierPair: string * string  in parsedIdentifiers do
                if fst identifierPair <> "Icon" then
                    renderIdentifierMember identifierPair 
        ] |> String.concat ""
    

open System.IO
let generateLucideFiles () =
    Parsers.Lab.getLabExports Spec.labPath
    |> LabGenerator.renderDocument
    |> fun render -> File.WriteAllText(Spec.outLabPath, render)
    
    Parsers.Lucide.getExports Spec.solidPath
    |> LucideGenerator.renderDocument
    |> fun render -> File.WriteAllText(Spec.outSolidPath, render)
