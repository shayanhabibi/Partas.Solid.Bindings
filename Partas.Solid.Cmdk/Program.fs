namespace Partas.Solid.Cmdk

open Fable.Core
open Partas.Solid

#nowarn 64

[<Erase; AutoOpen>]
module private Helper =
    let [<Erase; Literal>] cmdk = "cmdk-solid"

[<Erase; Import("CommandRoot", cmdk)>]
type Command() =
    inherit div()
    member val label : string = jsNative with get,set
    member val shouldFilter : bool = jsNative with set,get
    member _.filter
        with set(value: string, search: string, ?keywords: string array) = ()
    member val defaultValue : string = jsNative with get,set
    member val value : string = jsNative with get,set
    member val onValueChange: string -> unit = jsNative with get,set
    member val loop: bool = jsNative with get,set
    member val disablePointerSelection:bool = jsNative with get,set
[<Erase; RequireQualifiedAccess>]
module Command =
    [<Erase; Import("CommandSeparator", cmdk)>]
    type Separator() =
        inherit VoidNode()
        member val alwaysRender:bool = jsNative with get,set
    [<Erase; Import("CommandDialog", cmdk)>]
    type Dialog() =
        inherit Kobalte.Dialog()
        member val vimBindings:bool = jsNative with get,set    member val label : string = jsNative with get,set
        member val shouldFilter : bool = jsNative with set,get
        member _.filter
            with set(value: string, search: string, ?keywords: string array) = ()
        member val defaultValue : string = jsNative with get,set
        member val value : string = jsNative with get,set
        member val onValueChange: string -> unit = jsNative with get,set
        member val loop: bool = jsNative with get,set
        member val disablePointerSelection:bool = jsNative with get,set
        member val overlayClassName : string = jsNative with get,set
        member val contentClassName : string = jsNative with get,set
        member val container: #HtmlElement = jsNative with get,set
    [<Erase; Import("CommandEmpty", cmdk)>]
    type Empty() =
        inherit RegularNode()
    [<Erase; Import("CommandGroup", cmdk)>]
    type Group() =
        inherit div()
        member val heading: #HtmlElement = jsNative with get,set
        member val value: string = jsNative with get,set
        member val forceMount: bool = jsNative with get,set
    [<Erase; Import("CommandInput", cmdk)>]
    type Input() =
        inherit input()
        member val value : string = jsNative with get,set
        member val onValueChange : string -> unit = jsNative with get,set
    [<Erase; Import("CommandItem", cmdk)>]
    type Item() =
        inherit div()
        member val disabled: bool = jsNative with get,set
        member val onSelect : string -> unit = jsNative with get,set
        member val value: string = jsNative with get,set
        member val keyWords: string array = jsNative with get,set
        member val forceMount: bool = jsNative with get,set
    [<Erase; Import("CommandList", cmdk)>]
    type List() =
        inherit div()
        member val label: string = jsNative with get,set
    [<Erase; Import("CommandLoading", cmdk)>]
    type Loading() =
        inherit div()
        member val progress: int = jsNative with get,set
        member val label: string = jsNative with get,set
    [<Erase; Import("defaultFilter", cmdk)>]
    let defaultFilter () = jsNative
    [<Erase; Import("useCommandState", cmdk)>]
    let useCommandState () = jsNative
