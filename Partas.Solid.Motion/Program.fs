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


[<Erase>]
module Extensions =
    type AttrKey with
        member _.tag
            with set(value: TagValue) = ()
    type OptionKeys with
        member _.initial
            with set(value: string) = ()
        member _.animate
            with set(value: string) = ()
        member _.inView
            with set(value: string) = ()
        member _.inViewOptions
            with set(value: string) = ()
        member _.hover
            with set(value: string) = ()
        member _.press
            with set(value: string) = ()
        member _.variants
            with set(value: string) = ()
        member _.transition
            with set(value: string) = ()
        member _.exit
            with set(value: string) = ()

// open Partas.Solid.Polymorphism
//
// [<Import("Motion", "solid-motionone")>]
// type Motion() =
//     inherit RegularNode()
//     interface OptionKeys
//     interface AttrKey
//     // Enable polymorphism with the tag attribute name
//     interface Polymorph
//     [<Erase>] member val ``__PARTAS_POLYMORPHIC__tag``: TagValue = unbox null with get,set
//     [<Erase>]
//     member this.tag
//         with inline set(value: TagValue) = this.``__PARTAS_POLYMORPHIC__tag`` <- value
//         and inline get(): TagValue = this.``__PARTAS_POLYMORPHIC__tag``
//
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
//
//
//
//
//
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MotionEventHandlers =
//     abstract member onMotionStart: (MotionEvent -> unit) option with get, set
//     abstract member onMotionComplete: (motionone.MotionEvent -> unit) option with get, set
//     abstract member onHoverStart: (motionone.CustomPointerEvent -> unit) option with get, set
//     abstract member onHoverEnd: (motionone.CustomPointerEvent -> unit) option with get, set
//     abstract member onPressStart: (motionone.CustomPointerEvent -> unit) option with get, set
//     abstract member onPressEnd: (motionone.CustomPointerEvent -> unit) option with get, set
//     abstract member onViewEnter: (motionone.ViewEvent -> unit) option with get, set
//     abstract member onViewLeave: (motionone.ViewEvent -> unit) option with get, set
//
// module _AT_motionone/dom =
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type CSSStyleDeclarationWithTransform =
//         inherit Omit<PropertiesHyphen, CSSStyleDeclarationWithTransform>
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type Options =
//         abstract member exit: motionone.VariantDefinition option with get, set
//
//     [<RequireQualifiedAccess>]
//     [<StringEnum(CaseRules.None)>]
//     type CSSStyleDeclarationWithTransform =
//         | direction
//         | transition
//
// type MotionComponentProps =
//     ParentProps<MotionComponentProps.ParentProps.ReturnType>
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MotionComponent =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: props: obj -> JSX.Element
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: props: obj -> JSX.Element
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MotionProxyComponent<'T> =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: props: obj -> JSX.Element
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MotionProxy =
//     interface end
//
// module ``solid-js`` =
//
//     module JSX =
//
//         [<AllowNullLiteral>]
//         [<Interface>]
//         type Directives =
//             abstract member motion: motionone.Options with get, set
//
// type E =
//     JSX.Element
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type PresenceContextState =
//     abstract member initial: bool with get, set
//     abstract member mount: Accessor<bool> with get, set
//
//
//
//
// module MotionComponentProps =
//
//     module ParentProps =
//
//         [<AllowNullLiteral>]
//         [<Interface>]
//         type ReturnType =
//             interface end
