namespace Partas.Solid.Motion

open Fable.Core.JS
open Partas.Solid
open Fable.Core

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
        member _.initial
            with set(value: obj) = ()
        member _.animate
            with set(value: obj) = ()
        member _.inView
            with set(value: obj) = ()
        member _.inViewOptions
            with set(value: obj) = ()
        member _.hover
            with set(value: obj) = ()
        member _.press
            with set(value: obj) = ()
        member _.variants
            with set(value: obj) = ()
        member _.transition
            with set(value: obj) = ()
        member _.exit
            with set(value: obj) = ()

open Partas.Solid.Polymorphism

[<Import("Motion", "solid-motionone")>]
type Motion() =
    inherit RegularNode()
    interface OptionKeys
    interface AttrKey
    // Enable polymorphism with the tag attribute name
    interface Polymorph
    [<Erase>] member val ``__PARTAS_POLYMORPHIC__tag``: string = unbox null with get,set
    [<Erase>]
    member this.tag
        with inline set(value: string) = this.``__PARTAS_POLYMORPHIC__tag`` <- value
        and inline get(): string = this.``__PARTAS_POLYMORPHIC__tag``

[<Import("Presence", "solid-motionone")>]
type Presence() =
    interface HtmlContainer
    [<Erase>] member val exitBeforeEnter: bool = unbox null with get,set
    [<Erase>] member val initial: bool = unbox null with get,set
    

// [<AbstractClass>]
// [<Erase>]
// type Exports =
//     /// <summary>
//     /// createMotion provides MotionOne as a compact Solid primitive.
//     /// </summary>
//     /// <param name="target">
//     /// Target Element to animate.
//     /// </param>
//     /// <param name="options">
//     /// Options to effect the animation.
//     /// </param>
//     /// <param name="presenceState">
//     /// Optional PresenceContext override, defaults to current parent.
//     /// </param>
//     /// <returns>
//     /// Object to access MotionState
//     /// </returns>
//     [<Import("createMotion", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member createMotion (target: Element, options: U2<Accessor<Options>, Options>, ?presenceState: PresenceContextState) : MotionState = nativeOnly
//     /// <summary>
//     /// motion is a Solid directive that makes binding to elements easier.
//     /// </summary>
//     /// <param name="el">
//     /// Target Element to bind to.
//     /// </param>
//     /// <param name="props">
//     /// Options to effect the animation.
//     /// </param>
//     [<Import("motion", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member motion (el: Element, props: Accessor<Options>) : unit = nativeOnly