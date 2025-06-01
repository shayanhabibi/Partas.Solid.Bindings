namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.popover)>]
type Popover() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val translations : string = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val anchorRef : unit -> HtmlElement = jsNative with get,set
    member val placement : Popover.Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Popover =
    [<Erase; Import("Trigger", Spec.popover)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.popover)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val gutter : int = jsNative with get,set
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.popover)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Portal", Spec.popover)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Anchor", Spec.popover)>]
    type Anchor() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.popover)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.popover)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.popover)>]
    type Description() =
        inherit p()
        interface Polymorph

