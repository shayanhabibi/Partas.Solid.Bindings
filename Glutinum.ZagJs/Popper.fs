namespace rec Glutinum.ZagJs

open Fable.Core
open Fable.Core.JsInterop
open System

[<JS.Pojo>]
type PositioningOptions
    (
        ?hideWhenDetached: bool,
        ?strategy: PositioningOptions.strategy,
        ?placement: obj,
        ?offset: PositioningOptions.offset,
        ?gutter: float,
        ?shift: float,
        ?overflowPadding: float,
        ?arrowPadding: float,
        ?slide: bool,
        ?overlap: bool,
        ?sameWidth: bool,
        ?fitViewport: bool,
        ?listeners: U2<bool, obj>,
        ?onPositioned: (PositioningOptions.onPositioned.data -> unit),
        ?getAnchorRect: (obj -> obj),
        ?updatePosition: (PositioningOptions.updatePosition.data -> U2<unit, JS.Promise<unit>>)
    ) =
    /// <summary>
    /// Whether the popover should be hidden when the reference element is detached
    /// </summary>
    [<DefaultValue>]
    val mutable hideWhenDetached: bool option

    /// <summary>
    /// The strategy to use for positioning
    /// </summary>
    [<DefaultValue>]
    val mutable strategy: PositioningOptions.strategy option

    /// <summary>
    /// The initial placement of the floating element
    /// </summary>
    [<DefaultValue>]
    val mutable placement: obj option

    /// <summary>
    /// The offset of the floating element
    /// </summary>
    [<DefaultValue>]
    val mutable offset: PositioningOptions.offset option

    /// <summary>
    /// The main axis offset or gap between the reference and floating elements
    /// </summary>
    [<DefaultValue>]
    val mutable gutter: float option

    /// <summary>
    /// The secondary axis offset or gap between the reference and floating elements
    /// </summary>
    [<DefaultValue>]
    val mutable shift: float option

    /// <summary>
    /// The virtual padding around the viewport edges to check for overflow
    /// </summary>
    [<DefaultValue>]
    val mutable overflowPadding: float option

    /// <summary>
    /// The minimum padding between the arrow and the floating element's corner.
    /// </summary>
    [<DefaultValue>]
    val mutable arrowPadding: float option

    /// <summary>
    /// Whether the popover should slide when it overflows.
    /// </summary>
    [<DefaultValue>]
    val mutable slide: bool option

    /// <summary>
    /// Whether the floating element can overlap the reference element
    /// </summary>
    [<DefaultValue>]
    val mutable overlap: bool option

    /// <summary>
    /// Whether to make the floating element same width as the reference element
    /// </summary>
    [<DefaultValue>]
    val mutable sameWidth: bool option

    /// <summary>
    /// Whether the popover should fit the viewport.
    /// </summary>
    [<DefaultValue>]
    val mutable fitViewport: bool option

    /// <summary>
    /// Options to activate auto-update listeners
    /// </summary>
    [<DefaultValue>]
    val mutable listeners: U2<bool, obj> option

    /// <summary>
    /// Function called when the floating element is positioned or not
    /// </summary>
    [<DefaultValue>]
    val mutable onPositioned: (PositioningOptions.onPositioned.data -> unit) option

    /// <summary>
    /// Function that returns the anchor rect
    /// </summary>
    [<DefaultValue>]
    val mutable getAnchorRect: (obj option -> obj option) option

    /// <summary>
    /// A callback that will be called when the popover needs to calculate its
    /// position.
    /// </summary>
    [<DefaultValue>]
    val mutable updatePosition: (PositioningOptions.updatePosition.data -> U2<unit, JS.Promise<unit>>) option
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
