namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.hoverCard)>]
type HoverCard() =
    interface RegularNode
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val placement : KobaltePlacement = jsNative with get,set
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
module HoverCard =
    [<Erase; Import("Trigger", Spec.hoverCard)>]
    type Trigger() =
        inherit Link()
        interface Polymorph
    [<Erase; Import("Portal", Spec.hoverCard)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Content", Spec.hoverCard)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", Spec.hoverCard)>]
    type Arrow() =
        inherit div()
        interface Polymorph



