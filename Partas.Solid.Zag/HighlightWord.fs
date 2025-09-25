namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Pojo>]
type HighlightRegexOptions(
    ?ignoreCase: bool,
    ?matchAll: bool,
    ?exactMatch: bool
    ) =
    [<DefaultValue>]
    val mutable ignoreCase: bool
    [<DefaultValue>]
    val mutable matchAll: bool
    [<DefaultValue>]
    val mutable exactMatch: bool

[<Pojo>]
type HighlightWordProps(
    text: string,
    query: U2<string, string[]>,
    ?ignoreCase: bool,
    ?matchAll: bool,
    ?exactMatch: bool
    ) =
    [<DefaultValue>]
    val mutable ignoreCase: bool
    [<DefaultValue>]
    val mutable matchAll: bool
    [<DefaultValue>]
    val mutable exactMatch: bool
    [<DefaultValue>]
    val mutable text: string
    [<DefaultValue>]
    val mutable query: U2<string, string[]>

type HighlightChunk =
    abstract text: string
    abstract ``match``: bool

type HighlightSpan =
    abstract start: int
    abstract ``end``: int
    abstract ``match``: bool option

module HighlightWord =
    [<Import("highlightWord", Spec.pathExt + "highlight-word")>]
    let highlightWord (props: HighlightWordProps): HighlightChunk[] = jsNative
    
