namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid
open Browser.Types
open Partas.Solid.Experimental.U

[<Erase; Import("Root", Spec.hoverCard)>]
type HoverCard() =
    interface RegularNode
    interface Polymorph
    /// <summary>
    /// The controlled open state of the hovercard.
    /// </summary>
    [<Erase>]
    member val open': bool = JS.undefined with get,set
    /// <summary>
    /// The default open state when initially rendered.
    /// Useful when you do not need to control the open state.
    /// </summary>
    [<Erase>]
    member val defaultOpen: bool = JS.undefined with get,set
    /// <summary>
    /// Event handler called when the open state of the hovercard changes.
    /// </summary>
    [<Erase>]
    member val onOpenChange: (bool -> unit) = JS.undefined with get,set
    /// <summary>
    /// The duration from when the mouse enters the trigger until the hovercard opens.
    /// </summary>
    [<Erase>]
    member val openDelay: float = JS.undefined with get,set
    /// <summary>
    /// The duration from when the mouse leaves the trigger or content until the hovercard closes.
    /// </summary>
    [<Erase>]
    member val closeDelay: float = JS.undefined with get,set
    /// <summary>
    /// Whether to close the hovercard even if the user cursor is inside the safe area between the trigger and hovercard.
    /// </summary>
    [<Erase>]
    member val ignoreSafeArea: bool = JS.undefined with get,set
    /// <summary>
    /// Used to force mounting the hovercard (portal and content) when more control is needed.
    /// Useful when controlling animation with SolidJS animation libraries.
    /// </summary>
    [<Erase>]
    member val forceMount: bool = JS.undefined with get,set
    /// <summary>
    /// A unique identifier for the component.
    /// The id is used to generate id attributes for nested components.
    /// If no id prop is provided, a generated id will be used.
    /// </summary>
    [<Erase>]
    member val id: string  =JS.undefined with get,set

    /// <summary>
    /// Function that returns the anchor element's DOMRect. If this is explicitly
    /// passed, it will override the anchor <c>getBoundingClientRect</c> method.
    /// </summary>
    [<Erase>]
    member val getAnchorRect: (HTMLElement -> obj) = JS.undefined with get,set
    /// <summary>
    /// The placement of the popper.
    /// </summary>
    [<Erase>]
    member val placement: KobaltePlacement = JS.undefined with get,set
    /// <summary>
    /// The distance between the popper and the anchor element.
    /// By default, it's 0 plus half of the arrow offset, if it exists.
    /// </summary>
    [<Erase>]
    member val gutter: float = JS.undefined with get,set
    /// <summary>
    /// The skidding of the popper along the anchor element.
    /// </summary>
    [<Erase>]
    member val shift: float = JS.undefined with get,set
    /// <summary>
    /// Controls the behavior of the popper when it overflows the viewport:
    ///   - If a <c>boolean</c>, specifies whether the popper should flip to the
    ///     opposite side when it overflows.
    ///   - If a <c>string</c>, indicates the preferred fallback placements when it
    ///     overflows. The placements must be spaced-delimited, e.g. "top left".
    /// </summary>
    [<Erase>]
    member val flip: U2<bool, string> = JS.undefined with get,set
    /// <summary>
    /// Whether the popper should slide when it overflows.
    /// </summary>
    [<Erase>]
    member val slide: bool = JS.undefined with get,set
    /// <summary>
    /// Whether the popper can overlap the anchor element when it overflows.
    /// </summary>
    [<Erase>]
    member val overlap: bool = JS.undefined with get,set
    /// <summary>
    /// Whether the popper should have the same width as the anchor element.
    /// This will be exposed to CSS as <c>--kb-popper-anchor-width</c>.
    /// </summary>
    [<Erase>]
    member val sameWidth: bool = JS.undefined with get,set
    /// <summary>
    /// Whether the popper should fit the viewport. If this is set to true, the
    /// popper positioner will have <c>maxWidth</c> and <c>maxHeight</c> set to the viewport size.
    /// This will be exposed to CSS as <c>--kb-popper-content-available-width</c> and <c>--kb-popper-content-available-height</c>.
    /// </summary>
    [<Erase>]
    member val fitViewport: bool = JS.undefined with get,set
    /// <summary>
    /// Whether to hide the popper when the anchor element becomes occluded.
    /// </summary>
    [<Erase>]
    member val hideWhenDetached: bool = JS.undefined with get,set
    /// <summary>
    /// The minimum padding in order to consider the anchor element occluded.
    /// </summary>
    [<Erase>]
    member val detachedPadding: float = JS.undefined with get,set
    /// <summary>
    /// The minimum padding between the arrow and the popper corner.
    /// </summary>
    [<Erase>]
    member val arrowPadding: float = JS.undefined with get,set
    /// <summary>
    /// The minimum padding between the popper and the viewport edge.
    /// This will be exposed to CSS as <c>--kb-popper-content-overflow-padding</c>.
    /// </summary>
    [<Erase>]
    member val overflowPadding: float = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module HoverCard =
    [<AllowNullLiteral>]
    [<Interface>]
    type DataSet =
        abstract member ``data-expanded``: string option with get
        abstract member ``data-closed``: string option with get
        
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

[<AutoOpen; Erase>]
module HoverCardContext =
    [<AllowNullLiteral>]
    [<Interface>]
    type HoverCardContext =
        abstract member dataset: Accessor<HoverCard.DataSet> with get
        abstract member isOpen: Accessor<bool> with get
        abstract member contentPresent: Accessor<bool> with get
        abstract member openWithDelay: (unit -> unit) with get
        abstract member closeWithDelay: (unit -> unit) with get
        abstract member cancelOpening: (unit -> unit) with get
        abstract member cancelClosing: (unit -> unit) with get
        abstract member close: (unit -> unit) with get
        abstract member isTargetOnHoverCard: (Node option -> bool) with get
        abstract member setTriggerRef: (HTMLElement -> unit) with get
        abstract member setContentRef: (HTMLElement -> unit) with get

    [<ImportMember(Spec.hoverCard)>]
    let useHoverCardContext (): HoverCardContext = nativeOnly
