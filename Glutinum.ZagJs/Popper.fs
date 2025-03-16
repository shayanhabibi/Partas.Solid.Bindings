namespace rec Glutinum.ZagJs

open Fable.Core
open Fable.Core.JsInterop
open System

[<AllowNullLiteral>]
[<Interface>]
type PositioningOptions =
    /// <summary>
    /// Whether the popover should be hidden when the reference element is detached
    /// </summary>
    abstract member hideWhenDetached: bool option with get, set
    /// <summary>
    /// The strategy to use for positioning
    /// </summary>
    abstract member strategy: PositioningOptions.strategy option with get, set
    /// <summary>
    /// The initial placement of the floating element
    /// </summary>
    abstract member placement: obj option with get, set
    /// <summary>
    /// The offset of the floating element
    /// </summary>
    abstract member offset: PositioningOptions.offset option with get, set
    /// <summary>
    /// The main axis offset or gap between the reference and floating elements
    /// </summary>
    abstract member gutter: float option with get, set
    /// <summary>
    /// The secondary axis offset or gap between the reference and floating elements
    /// </summary>
    abstract member shift: float option with get, set
    /// <summary>
    /// The virtual padding around the viewport edges to check for overflow
    /// </summary>
    abstract member overflowPadding: float option with get, set
    /// <summary>
    /// The minimum padding between the arrow and the floating element's corner.
    /// </summary>
    abstract member arrowPadding: float option with get, set
    /// <summary>
    /// Whether to flip the placement
    /// </summary>
    // abstract member flip: U2<bool, ResizeArray<Placement>> option option with get, set
    /// <summary>
    /// Whether the popover should slide when it overflows.
    /// </summary>
    abstract member slide: bool option with get, set
    /// <summary>
    /// Whether the floating element can overlap the reference element
    /// </summary>
    abstract member overlap: bool option with get, set
    /// <summary>
    /// Whether to make the floating element same width as the reference element
    /// </summary>
    abstract member sameWidth: bool option with get, set
    /// <summary>
    /// Whether the popover should fit the viewport.
    /// </summary>
    abstract member fitViewport: bool option with get, set
    /// <summary>
    /// The overflow boundary of the reference element
    /// </summary>
    // abstract member boundary: (unit -> Boundary) option with get, set
    /// <summary>
    /// Options to activate auto-update listeners
    /// </summary>
    abstract member listeners: U2<bool, obj> option option with get, set
    /// <summary>
    /// Function called when the placement is computed
    /// </summary>
    // abstract member onComplete: (ComputePositionReturn -> unit) option with get, set
    /// <summary>
    /// Function called when the floating element is positioned or not
    /// </summary>
    abstract member onPositioned: (PositioningOptions.onPositioned.data -> unit) option with get, set
    /// <summary>
    /// Function that returns the anchor rect
    /// </summary>
    abstract member getAnchorRect: (obj option -> obj option) option with get, set
    /// <summary>
    /// A callback that will be called when the popover needs to calculate its
    /// position.
    /// </summary>
    abstract member updatePosition: (PositioningOptions.updatePosition.data -> U2<unit, JS.Promise<unit>>) option with get, set

module PositioningOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type strategy =
        | absolute
        | ``fixed``

    [<Global>]
    [<AllowNullLiteral>]
    type offset
        [<ParamObject; Emit("$0")>]
        (
            ?mainAxis: float,
            ?crossAxis: float
        ) =

        member val mainAxis : float option = nativeOnly with get, set
        member val crossAxis : float option = nativeOnly with get, set

    module onPositioned =

        [<Global>]
        [<AllowNullLiteral>]
        type data
            [<ParamObject; Emit("$0")>]
            (
                placed: bool
            ) =

            member val placed : bool = nativeOnly with get, set

    module updatePosition =

        [<Global>]
        [<AllowNullLiteral>]
        type data
            [<ParamObject; Emit("$0")>]
            (
                updatePosition: (unit -> JS.Promise<unit>)
            ) =

            member val updatePosition : (unit -> JS.Promise<unit>) = nativeOnly with get, set
