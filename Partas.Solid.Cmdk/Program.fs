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
    [<DefaultValue>] val mutable label : string
    [<DefaultValue>] val mutable shouldFilter : bool
    member _.filter
        with set(value: string, search: string, ?keywords: string array) = ()
    [<DefaultValue>] val mutable defaultValue : string
    [<DefaultValue>] val mutable value : string
    [<DefaultValue>] val mutable onValueChange: string -> unit
    [<DefaultValue>] val mutable loop: bool
    [<DefaultValue>] val mutable disablePointerSelection:bool
[<Erase; RequireQualifiedAccess>]
module Command =
    [<Erase; Import("CommandSeparator", cmdk)>]
    type Separator() =
        interface VoidNode
        [<DefaultValue>] val mutable alwaysRender:bool
    [<Erase; Import("CommandDialog", cmdk)>]
    type Dialog() =
        inherit Kobalte.Dialog()
        [<DefaultValue>] val mutable vimBindings:bool
        [<DefaultValue>] val mutable label : string
        [<DefaultValue>] val mutable shouldFilter : bool
        member _.filter
            with set(value: string, search: string, ?keywords: string array) = ()
        [<DefaultValue>] val mutable defaultValue : string
        [<DefaultValue>] val mutable value : string
        [<DefaultValue>] val mutable onValueChange: string -> unit
        [<DefaultValue>] val mutable loop: bool
        [<DefaultValue>] val mutable disablePointerSelection:bool
        [<DefaultValue>] val mutable overlayClassName : string
        [<DefaultValue>] val mutable contentClassName : string
        [<DefaultValue>] val mutable container: HtmlElement
    [<Erase; Import("CommandEmpty", cmdk)>]
    type Empty() =
        interface RegularNode
    [<Erase; Import("CommandGroup", cmdk)>]
    type Group() =
        inherit div()
        [<DefaultValue>] val mutable heading: HtmlElement
        [<DefaultValue>] val mutable value: string
        [<DefaultValue>] val mutable forceMount: bool
    [<Erase; Import("CommandInput", cmdk)>]
    type Input() =
        inherit input()
        [<DefaultValue>] val mutable value : string
        [<DefaultValue>] val mutable onValueChange : string -> unit
    [<Erase; Import("CommandItem", cmdk)>]
    type Item() =
        inherit div()
        [<DefaultValue>] val mutable disabled: bool
        [<DefaultValue>] val mutable onSelect : string -> unit
        [<DefaultValue>] val mutable value: string
        [<DefaultValue>] val mutable keyWords: string array
        [<DefaultValue>] val mutable forceMount: bool
    [<Erase; Import("CommandList", cmdk)>]
    type List() =
        inherit div()
        [<DefaultValue>] val mutable label: string
    [<Erase; Import("CommandLoading", cmdk)>]
    type Loading() =
        inherit div()
        [<DefaultValue>] val mutable progress: int
        [<DefaultValue>] val mutable label: string
    [<Erase; Import("defaultFilter", cmdk)>]
    let defaultFilter () = jsNative
    [<Erase; Import("useCommandState", cmdk)>]
    let useCommandState () = jsNative
