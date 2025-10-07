namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core
open Browser.Types


[<Erase; Import("Root", Spec.tooltip)>]
type Tooltip() =
    inherit div()
    interface Polymorph
    [<Erase>] member val open' : bool  = JS.undefined with get,set
    [<Erase>] member val defaultOpen : bool  = JS.undefined with get,set
    [<Erase>] member val onOpenChange : (bool -> unit)  = JS.undefined with get,set
    [<Erase>] member val triggerOnFocusOnly : bool  = JS.undefined with get,set
    [<Erase>] member val openDelay : int  = JS.undefined with get,set
    [<Erase>] member val skipDelayDuration : bool  = JS.undefined with get,set
    [<Erase>] member val closeDelay : int  = JS.undefined with get,set
    [<Erase>] member val ignoreSafeArea : bool  = JS.undefined with get,set
    [<Erase>] member val id : string  = JS.undefined with get,set
    [<Erase>] member val forceMount : bool  = JS.undefined with get,set
    [<Erase>] member val getAnchorRect : HtmlElement -> obj  = JS.undefined with get,set
    [<Erase>] member val placement : KobaltePlacement  = JS.undefined with get,set
    [<Erase>] member val gutter : int  = JS.undefined with get,set
    [<Erase>] member val shift : int  = JS.undefined with get,set
    [<Erase>] member val flip : bool  = JS.undefined with get,set
    [<Erase>] member val slide : bool  = JS.undefined with get,set
    [<Erase>] member val overlap : bool  = JS.undefined with get,set
    [<Erase>] member val sameWidth : bool  = JS.undefined with get,set
    [<Erase>] member val fitViewport : bool  = JS.undefined with get,set
    [<Erase>] member val hideWhenDetached : bool  = JS.undefined with get,set
    [<Erase>] member val detachedPadding : int  = JS.undefined with get,set
    [<Erase>] member val arrowPadding : int  = JS.undefined with get,set
    [<Erase>] member val overflowPadding : int  = JS.undefined with get,set

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
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
    [<Erase; Import("Arrow", Spec.tooltip)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
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
