namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core
open Browser.Types


[<Erase; Import("Root", Spec.tooltip)>]
type Tooltip() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val triggerOnFocusOnly : bool = jsNative with get,set
    member val openDelay : int = jsNative with get,set
    member val skipDelayDuration : bool = jsNative with get,set
    member val closeDelay : int = jsNative with get,set
    member val ignoreSafeArea : bool = jsNative with get,set
    member val id : string = jsNative with get,set
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
module Tooltip =
    [<AllowNullLiteral>]
    [<Interface>]
    type DataSet =
        abstract member ``data-expanded``: string option with get, set
        abstract member ``data-closed``: string option with get, set
        
    [<Erase; Import("Trigger", Spec.tooltip)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.tooltip)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.tooltip)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Portal", Spec.tooltip)>]
    type Portal() =
        inherit div()
        interface Polymorph

[<AutoOpen; Erase>]
module TooltipContext =

    [<AllowNullLiteral>]
    [<Interface>]
    type TooltipContext =
        abstract member dataset: Accessor<Tooltip.DataSet> with get
        abstract member isOpen: Accessor<bool> with get
        abstract member isDisabled: Accessor<bool> with get
        abstract member triggerOnFocusOnly: Accessor<bool> with get
        abstract member contentId: Accessor<string option> with get
        abstract member contentPresent: Accessor<bool> with get
        /// Can pass a boolean as to whether to immediately
        /// open/hide the tooltip
        abstract member openTooltip: (bool -> unit) with get
        /// Can pass a boolean as to whether to immediately
        /// open/hide the tooltip
        abstract member hideTooltip: (bool -> unit) with get
        abstract member cancelOpening: (unit -> unit) with get
        abstract member generateId: (string -> string) with get
        abstract member registerContentId: (string -> (unit -> unit)) with get
        abstract member isTargetOnTooltip: (Node option -> bool) with get
        abstract member setTriggerRef: (HTMLElement -> unit) with get
        abstract member setContentRef: (HTMLElement -> unit) with get

    [<ImportMember(Spec.tooltip)>]
    let useTooltipContext(): TooltipContext = jsNative
