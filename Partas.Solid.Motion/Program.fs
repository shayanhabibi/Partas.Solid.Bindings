namespace Partas.Solid.Motion

open Fable.Core.JS
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type OptionKeys = interface end
[<Erase>]
type AttrKey = interface end

[<Erase; AutoOpen>]
module Enums =
    [<StringEnum(CaseRules.LowerAll)>]
    type MotionEventNames =
        | MotionStart
        | MotionComplete
        | HoverStart
        | HoverEnd
        | PressStart
        | PressEnd
        | ViewEnter
        | ViewLeave

[<Erase; AutoOpen>]
module Context =
    [<AllowNullLiteral; Pojo>]
    type MotionStateContext
        (
            ?initial: string,
            ?animate: string,
            ?inView: string,
            ?hover: string,
            ?press: string,
            ?exit: string
        )=
        member val initial: string = initial |> _.Value with get, set
        member val animate: string = animate |> _.Value with get, set
        member val inView: string = inView |> _.Value with get, set
        member val hover: string = hover |> _.Value with get, set
        member val press: string = press |> _.Value with get, set
        member val exit: string = exit |> _.Value with get, set


[<Erase; AutoOpen>]
module Extensions =
    type AttrKey with
        member _.tag
            with set(value: TagValue) = ()
    
    type OptionKeys with
        member _.initial' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.initial
            with inline set(value: IMotionStyle list) = this.initial' <- createObj !!value
        member _.animate' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.animate
            with inline set(value: IMotionStyle list) = this.animate' <- createObj !!value
        member _.inView' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.inView
            with inline set(value: IMotionStyle list) = this.inView' <- createObj !!value
        member _.inViewOptions' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>InViewOption.</c>. Feliz style.
        /// </summary>
        member this.inViewOptions
            with inline set(value: IInViewOption list) = this.inViewOptions' <- createObj !!value 
        member _.hover' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.hover
            with inline set(value: IMotionStyle list) = this.hover' <- createObj !!value
        member _.press' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.press
            with inline set(value: IMotionStyle list) = this.press' <- createObj !!value
        member _.variants' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.variants
            with inline set(value: IMotionStyle list) = this.variants' <- createObj !!value
        member _.transition' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>IStyleAnimation.</c>. Feliz style.
        /// </summary>
        member this.transition
            with inline set(value: IStyleAnimation list) = this.transition' <- createObj !!value
        member _.exit' with set(value: obj) = ()
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.exit
            with inline set(value: IMotionStyle list) = this.exit' <- createObj !!value

[<Import("Presence", "solid-motionone")>]
type Presence() =
    interface HtmlContainer
    [<Erase>] member val exitBeforeEnter: bool = unbox null with get,set
    [<Erase>] member val initial: bool = unbox null with get,set
    
[<AbstractClass>]
[<Erase; AutoOpen>]
type Exports =
    /// <summary>
    /// createMotion provides MotionOne as a compact Solid primitive.
    /// </summary>
    /// <param name="target">
    /// Target Element to animate.
    /// </param>
    /// <param name="options">
    /// Options to effect the animation.
    /// </param>
    /// <param name="presenceState">
    /// Optional PresenceContext override, defaults to current parent.
    /// </param>
    /// <returns>
    /// Object to access MotionState
    /// </returns>
    [<Import("createMotion", "solid-motionone")>]
    static member createMotion (target: HtmlElement, options: U2<Accessor<Options>, Options>, ?presenceState: obj) : MotionState = nativeOnly
    // /// <summary>
    // /// motion is a Solid directive that makes binding to elements easier.
    // /// </summary>
    // /// <param name="el">
    // /// Target Element to bind to.
    // /// </param>
    // /// <param name="props">
    // /// Options to effect the animation.
    // /// </param>
    // [<Import("motion", "solid-motionone")>]
    // static member motion (el: Element, props: Accessor<Options>) : unit = nativeOnly