namespace Partas.Solid.Motion

open Partas.Solid.Motion.LibDom
open Fable.Core
open Partas.Solid.Experimental.U
open Browser.Types

[<AutoOpen>]
module StyleExtensions =
    type MotionStyle with
        static member inline x (value: U6<string, string[], int, int[], float, float[]>) = "x" ==>! value 
        static member inline y (value: U6<string, string[], int, int[], float, float[]>) = "y" ==>! value 
        static member inline z (value: U6<string, string[], int, int[], float, float[]>) = "z" ==>! value 
        static member inline rotateX (value: U6<string, string[], int, int[], float, float[]>) = "rotateX" ==>! value 
        static member inline rotateY (value: U6<string, string[], int, int[], float, float[]>) = "rotateY" ==>! value 
        static member inline rotateZ (value: U6<string, string[], int, int[], float, float[]>) = "rotateZ" ==>! value 
        static member inline scaleX (value: U6<string, string[], int, int[], float, float[]>) = "scaleX" ==>! value 
        static member inline scaleY (value: U6<string, string[], int, int[], float, float[]>) = "scaleY" ==>! value 
        static member inline scaleZ (value: U6<string, string[], int, int[], float, float[]>) = "scaleZ" ==>! value 
        static member inline skewX (value: U6<string, string[], int, int[], float, float[]>) = "skewX" ==>! value 
        static member inline skewY (value: U6<string, string[], int, int[], float, float[]>) = "skewY" ==>! value 

[<AllowNullLiteral>]
[<Interface>]
type Target =
    [<EmitIndexer>]
    abstract member Item: key: string -> U2<string, float> with get, set

[<AllowNullLiteral>]
[<Interface>]
type MotionState =
    abstract member update: (Options -> unit) with get, set
    abstract member getDepth: (unit -> float) with get, set
    // abstract member getTarget: (unit -> MotionKeyframes) with get, set
    abstract member getOptions: (unit -> Options) with get, set
    abstract member getContext: (unit -> MotionStateContext) with get, set
    abstract member setActive: MotionState.setActive with get, set
    abstract member mount: (Element -> (unit -> unit)) with get, set
    abstract member isMounted: (unit -> bool) with get, set
    // abstract member animateUpdates: (unit -> Generator<unit>) with get, set

[<AllowNullLiteral>]
[<Interface>]
type Options =
    abstract member initial: VariantDefinition option with get, set
    abstract member animate: VariantDefinition option with get, set
    abstract member inView: VariantDefinition option with get, set
    abstract member hover: VariantDefinition option with get, set
    abstract member press: VariantDefinition option with get, set
    abstract member variants: Variants option with get, set
    // abstract member transition: AnimationOptionsWithOverrides option with get, set
    abstract member inViewOptions: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type MotionStateContext =
    abstract member initial: string option with get, set
    abstract member animate: string option with get, set
    abstract member inView: string option with get, set
    abstract member hover: string option with get, set
    abstract member press: string option with get, set
    abstract member exit: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Variant =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type Variants =
    [<EmitIndexer>]
    abstract member Item: key: string -> Variant with get, set

type VariantDefinition =
    U2<Variant, string>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MotionEventNames =
    | motionstart
    | motioncomplete
    | hoverstart
    | hoverend
    | pressstart
    | pressend
    | viewenter
    | viewleave

type MotionEvent =
    CustomEvent<MotionEvent.CustomEvent>

type CustomPointerEvent =
    CustomEvent<CustomPointerEvent.CustomEvent>

type ViewEvent =
    CustomEvent<ViewEvent.CustomEvent>

module ``global`` =

    [<AllowNullLiteral>]
    [<Interface>]
    type GlobalEventHandlersEventMap =
        abstract member motionstart: MotionEvent with get, set
        abstract member motioncomplete: MotionEvent with get, set
        abstract member hoverstart: CustomPointerEvent with get, set
        abstract member hoverend: CustomPointerEvent with get, set
        abstract member pressstart: CustomPointerEvent with get, set
        abstract member pressend: CustomPointerEvent with get, set
        abstract member viewenter: ViewEvent with get, set
        abstract member viewleave: ViewEvent with get, set

module MotionState =

    type setActive =
        delegate of ``type``: MotionState.setActive.``type`` * isActive: bool -> unit

    module setActive =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | initial
            | animate
            | inView
            | hover
            | press
            | exit

module MotionEvent =

    [<Global>]
    [<AllowNullLiteral>]
    type CustomEvent
        [<ParamObject; Emit("$0")>]
        (
            target: Variant
        ) =

        member val target : Variant = nativeOnly with get, set

module CustomPointerEvent =

    [<Global>]
    [<AllowNullLiteral>]
    type CustomEvent
        [<ParamObject; Emit("$0")>]
        (
            originalEvent: PointerEvent
        ) =

        member val originalEvent : PointerEvent = nativeOnly with get, set

module ViewEvent =

    [<Global>]
    [<AllowNullLiteral>]
    type CustomEvent
        [<ParamObject; Emit("$0")>]
        (
            originalEntry: IntersectionObserverEntry
        ) =

        member val originalEntry : IntersectionObserverEntry = nativeOnly with get, set
