namespace rec Partas.Solid.Motion

open Partas.Solid.Motion.LibDom
open Fable.Core
open Partas.Solid.Experimental.U
open Browser.Types
open Partas.Solid

type IInViewOption = interface end
type IMotionStyle = interface end

[<StringEnum; RequireQualifiedAccess>]
type InViewOptionAmount =
    | Any
    | All
type InViewOption =
    static member inline root(value: U2<HtmlElement, Document>): IInViewOption = unbox("root", value)
    static member inline margin(value: string): IInViewOption = unbox("margin", value)
    static member inline amount(value: U3<int, float, InViewOptionAmount>): IInViewOption = unbox("amount", value)
    static member inline once(value: bool): IInViewOption = unbox("once", value)


[<AutoOpen>]
module StyleExtensions =
    type CssStyle<'T, 'U> with
        static member inline x (value: 'T): 'U = "x" ==>! value 
        static member inline y (value: 'T): 'U = "y" ==>! value 
        static member inline z (value: 'T): 'U = "z" ==>! value 
        static member inline rotateX (value: 'T): 'U = "rotateX" ==>! value 
        static member inline rotateY (value: 'T): 'U = "rotateY" ==>! value 
        static member inline rotateZ (value: 'T): 'U = "rotateZ" ==>! value 
        static member inline scaleX (value: 'T): 'U = "scaleX" ==>! value 
        static member inline scaleY (value: 'T): 'U = "scaleY" ==>! value 
        static member inline scaleZ (value: 'T): 'U = "scaleZ" ==>! value 
        static member inline skewX (value: 'T): 'U = "skewX" ==>! value 
        static member inline skewY (value: 'T): 'U = "skewY" ==>! value 

[<Interface; Erase>]
type MotionStyle =
    inherit CssStyle<U6<string, string[], int, int[], float, float[]>, IMotionStyle>
    static member inline transition (value: IStyleAnimation list): IMotionStyle = "transition" ==>! value

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

[<Fable.Core.Erase; AutoOpen>]
module MotionValue =
    [<Import("MotionValue", "@motionone/types"); EmitConstructor>]
    let MotionValue () : MotionValue = nativeOnly

[<AllowNullLiteral>]
[<Interface>]
type MotionValue =
    abstract member animation: BasicAnimationControls option with get, set
    abstract member generatorStartTime: float option with get, set
    abstract member generator: AnimationGenerator option with get, set
    abstract member setAnimation: ?animation: BasicAnimationControls -> unit
    abstract member clearAnimation: VoidFunction

[<AllowNullLiteral>]
[<Interface>]
type AnimationGeneratorState =
    abstract member ``done``: bool with get, set
    abstract member hasReachedTarget: bool with get, set
    abstract member current: float with get, set
    abstract member target: float with get, set


type ProgressFunction = float -> unit

type AnimationGeneratorFactory<'Options> = 'Options -> AnimationGenerator

type AnimationGenerator = float -> AnimationGeneratorState

type BezierDefinition =
    float * float * float * float

type VoidFunction = (unit -> unit)

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PlayState =
    | idle
    | running
    | paused
    | finished

[<AllowNullLiteral>]
[<Interface>]
type BasicAnimationControls =
    /// <summary>
    /// Play the animation.
    ///
    /// <code lang="javascript">
    /// animation.play()
    /// </code>
    /// </summary>
    abstract member play: VoidFunction with get, set
    // /// <summary>
    // /// Pause the animation.
    // ///
    // /// <code lang="javascript">
    // /// animation.pause()
    // /// </code>
    // /// </summary>
    abstract member pause: VoidFunction with get, set
    abstract member commitStyles: VoidFunction with get, set
    // /// <summary>
    // /// Cancels the animation and reverts the element to its underlying styles.
    // ///
    // /// <code lang="javascript">
    // /// animation.cancel()
    // /// </code>
    // /// </summary>
    abstract member cancel: VoidFunction with get, set
    abstract member stop: VoidFunction with get, set
    abstract member playState: PlayState with get, set
    abstract member finished: JS.Promise<obj> with get, set
    abstract member startTime: float option with get, set
    /// <summary>
    /// Get/set the current play time of the animation in seconds. This can be used to scrub through the animation.
    ///
    /// <code lang="javascript">
    /// const currentTime = animation.currentTime
    /// animation.currentTime = 1
    /// </code>
    /// </summary>
    abstract member currentTime: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AnimationControls =
    inherit BasicAnimationControls
    /// <summary>
    /// Stop the animation and set the current value to the element style.
    ///
    /// <code lang="javascript">
    /// animation.stop()
    /// </code>
    /// </summary>
    abstract member stop: VoidFunction with get, set
    /// <summary>
    /// Immediately completes the animation and commits the final keyframe to the element's styles.
    ///
    /// <code lang="javascript">
    /// animation.finish()
    /// </code>
    /// </summary>
    abstract member finish: VoidFunction with get, set
    /// <summary>
    /// Reverses the playback of the animation.
    ///
    /// <code lang="javascript">
    /// animation.reverse()
    /// </code>
    /// </summary>
    /// <remarks>
    /// Currently non-functional.
    /// </remarks>
    abstract member reverse: VoidFunction with get, set
    /// <summary>
    /// A <c>Promise</c> that resolves when the animation has finished.
    ///
    /// <code lang="javascript">
    /// await animation.finished
    /// </code>
    /// </summary>
    abstract member finished: JS.Promise<obj> with get, set
    /// <summary>
    /// Get the current play time of the animation in seconds. This can be especially useful
    /// when an animation has used the default duration, or when a timeline has dynamically
    /// generated a duration from the provided sequence.
    ///
    /// This prop is currently **read-only**.
    /// </summary>
    abstract member duration: float with get, set
    /// <summary>
    /// Get/set the current playback rate of the animation.
    ///
    /// - <c>1</c> is normal time.
    /// - <c>2</c> doubles the playback rate.
    /// - <c>-1</c> reverses playback.
    ///
    /// <code lang="javascript">
    /// animation.playbackRate = animation.playbackRate * 2
    /// </code>
    /// </summary>
    abstract member playbackRate: float with get, set
    /// <summary>
    /// Returns the current state of the animation. Can be <c>idle</c>, <c>running</c>, <c>paused</c> or <c>finished</c>.
    /// </summary>
    abstract member playState: AnimationPlayState with get, set

[<JS.Pojo>]
type CustomAnimationSettings
    (?easing: Easing, ?keyframes: ResizeArray<U2<float, string>>, ?duration: float) =
    member val easing: Easing = JS.undefined with get, set
    member val keyframes: ResizeArray<U2<float, string>> option = JS.undefined with get, set
    member val duration: float option = JS.undefined with get, set

type ValueKeyframe = U2<string, float>

type UnresolvedValueKeyframe =
    ValueKeyframe option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Easing =
    | linear
    | ease
    | ``ease-in``
    | ``ease-out``
    | ``ease-in-out``
    | ``step-start``
    | ``step-end``

[<JS.Pojo>]
type EasingGenerator(?createAnimation: EasingGenerator.createAnimation) =
    member val createAnimation: EasingGenerator.createAnimation = JS.undefined with get, set

[<JS.Pojo>]
type KeyframeOptions
    (?duration: float option, ?easing: KeyframeOptions.easing option, ?offset: ResizeArray<float> option) =
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    member val duration: float option = JS.undefined with get, set
    /// <summary>
    /// An easing to use for the whole animation, or list of easings to use between individual keyframes.
    ///
    /// Accepted <c>easing</c> options are:
    ///
    /// - **Basic easings:** <c>"linear"</c>, <c>"ease"</c>, <c>"ease-in"</c>, <c>"ease-out"</c>, <c>"ease-in-out"</c>
    /// - **[Cubic bezier curve](https://cubic-bezier.com/):** e.g. <c>[.17,.67,.83,.67]</c>
    /// - **Stepped easing:** e.g. <c>"steps(2, start)"</c>
    /// - **Custom easing:** A JavaScript easing function, for example [this bounce easing function](https://easings.net/#easeOutBounce).
    ///
    /// <c>"ease"</c>
    /// </summary>
    member val easing: KeyframeOptions.easing option = JS.undefined with get, set
    /// <summary>
    /// The offset of each keyframe, as a number between 0 and 1.
    ///
    /// The number of <c>offset</c> entries must match the number of <c>keyframes</c> entries.
    ///
    /// <c>[0, 1]</c>
    /// </summary>
    member val offset: ResizeArray<float> option = JS.undefined with get, set

[<AllowNullLiteral>]
[<Interface>]
type OptionResolver<'T> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: i: float * total: float -> 'T

[<JS.Pojo>]
type PlaybackOptions
    (
        ?delay: float,
        ?endDelay: float,
        ?repeat: float,
        ?direction: PlaybackDirection,
        ?persist: bool,
        ?autoplay: bool
    ) =
    /// <summary>
    /// A duration, in seconds, that the animation will be delayed before starting.
    ///
    /// <c>0</c>
    /// </summary>
    member val delay: float option = delay with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will wait at the end before ending.
    ///
    /// <c>0</c>
    /// </summary>
    member val endDelay: float option = endDelay with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    member val repeat: float option = repeat with get, set
    /// <summary>
    /// The direction of animation playback. <c>"normal"</c>, <c>"reverse"</c>, <c>"alternate"</c>, or <c>"alternate-reverse"</c>.
    ///
    /// <c>"normal"</c>
    /// </summary>
    member val direction: PlaybackDirection option = direction with get, set
    member val persist: bool option = persist with get, set
    /// <summary>
    /// Whether the animation should start automatically.
    ///
    /// <c>true</c>
    /// </summary>
    member val autoplay: bool option = autoplay with get, set

[<AllowNullLiteral>]
[<Interface>]
type DevToolsOptions =
    abstract member record: bool option with get, set

[<JS.Pojo>]
type AnimationOptions
    (
        ?duration: float,
        ?easing: AnimationOptions.easing,
        ?offset: ResizeArray<float>,
        ?delay: float,
        ?endDelay: float,
        ?repeat: float,
        ?direction: PlaybackDirection,
        ?persist: bool,
        ?autoplay: bool,
        ?record: bool,
        ?allowWebkitAcceleration: bool
    ) =
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    member val duration: float option = duration with get, set
    /// <summary>
    /// An easing to use for the whole animation, or list of easings to use between individual keyframes.
    ///
    /// Accepted <c>easing</c> options are:
    ///
    /// - **Basic easings:** <c>"linear"</c>, <c>"ease"</c>, <c>"ease-in"</c>, <c>"ease-out"</c>, <c>"ease-in-out"</c>
    /// - **[Cubic bezier curve](https://cubic-bezier.com/):** e.g. <c>[.17,.67,.83,.67]</c>
    /// - **Stepped easing:** e.g. <c>"steps(2, start)"</c>
    /// - **Custom easing:** A JavaScript easing function, for example [this bounce easing function](https://easings.net/#easeOutBounce).
    ///
    /// <c>"ease"</c>
    /// </summary>
    member val easing: AnimationOptions.easing option = easing with get, set
    /// <summary>
    /// The offset of each keyframe, as a number between 0 and 1.
    ///
    /// The number of <c>offset</c> entries must match the number of <c>keyframes</c> entries.
    ///
    /// <c>[0, 1]</c>
    /// </summary>
    member val offset: ResizeArray<float> option = offset with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will be delayed before starting.
    ///
    /// <c>0</c>
    /// </summary>
    member val delay: float option = delay with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will wait at the end before ending.
    ///
    /// <c>0</c>
    /// </summary>
    member val endDelay: float option = endDelay with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    member val repeat: float option = repeat with get, set
    /// <summary>
    /// The direction of animation playback. <c>"normal"</c>, <c>"reverse"</c>, <c>"alternate"</c>, or <c>"alternate-reverse"</c>.
    ///
    /// <c>"normal"</c>
    /// </summary>
    member val direction: PlaybackDirection option = direction with get, set
    member val persist: bool option = persist with get, set
    /// <summary>
    /// Whether the animation should start automatically.
    ///
    /// <c>true</c>
    /// </summary>
    member val autoplay: bool option = autoplay with get, set
    member val record: bool option = record with get, set
    /// <summary>
    /// Because of numerous timing bugs in Webkit's accelerated animations, these are disabled by default in Webkit-powered browsers.
    ///
    /// However, if the your animation is being disrupted by heavy processing, you can allow acceleration with this setting.
    /// It's advised you test these animations thoroughly in both Safari and iOS Chrome.
    ///
    /// <c>false</c>
    /// </summary>
    member val allowWebkitAcceleration: bool option = allowWebkitAcceleration with get, set

type IStyleAnimation = interface end

[<Interface>]
type StyleAnimation =
    inherit CssStyle<AnimationOptions, IStyleAnimation>
    static member inline duration (value: float): IStyleAnimation = "duration" ==>! value
    /// <summary>
    /// An easing to use for the whole animation, or list of easings to use between individual keyframes.
    ///
    /// Accepted <c>easing</c> options are:
    ///
    /// - **Basic easings:** <c>"linear"</c>, <c>"ease"</c>, <c>"ease-in"</c>, <c>"ease-out"</c>, <c>"ease-in-out"</c>
    /// - **[Cubic bezier curve](https://cubic-bezier.com/):** e.g. <c>[.17,.67,.83,.67]</c>
    /// - **Stepped easing:** e.g. <c>"steps(2, start)"</c>
    /// - **Custom easing:** A JavaScript easing function, for example [this bounce easing function](https://easings.net/#easeOutBounce).
    ///
    /// <c>"ease"</c>
    /// </summary>
    static member inline easing (value: AnimationOptions.easing): IStyleAnimation = "easing" ==>! value
    /// <summary>
    /// The offset of each keyframe, as a number between 0 and 1.
    ///
    /// The number of <c>offset</c> entries must match the number of <c>keyframes</c> entries.
    ///
    /// <c>[0, 1]</c>
    /// </summary>
    static member inline offset (value: ResizeArray<float>): IStyleAnimation = "offset" ==>! value
    /// <summary>
    /// A duration, in seconds, that the animation will be delayed before starting.
    ///
    /// <c>0</c>
    /// </summary>
    static member inline delay (value: float): IStyleAnimation = "delay" ==>! value
    /// <summary>
    /// A duration, in seconds, that the animation will wait at the end before ending.
    ///
    /// <c>0</c>
    /// </summary>
    static member inline endDelay (value: float): IStyleAnimation = "endDelay" ==>! value
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    static member inline repeat (value: float): IStyleAnimation = "repeat" ==>! value
    /// <summary>
    /// The direction of animation playback. <c>"normal"</c>, <c>"reverse"</c>, <c>"alternate"</c>, or <c>"alternate-reverse"</c>.
    ///
    /// <c>"normal"</c>
    /// </summary>
    static member inline direction (value: PlaybackDirection): IStyleAnimation = "direction" ==>! value
    static member inline persist (value: bool): IStyleAnimation = "persist" ==>! value
    /// <summary>
    /// Whether the animation should start automatically.
    ///
    /// <c>true</c>
    /// </summary>
    static member inline autoplay (value: bool): IStyleAnimation = "autoplay" ==>! value
    static member inline record (value: bool): IStyleAnimation = "record" ==>! value
    /// <summary>
    /// Because of numerous timing bugs in Webkit's accelerated animations, these are disabled by default in Webkit-powered browsers.
    ///
    /// However, if the your animation is being disrupted by heavy processing, you can allow acceleration with this setting.
    /// It's advised you test these animations thoroughly in both Safari and iOS Chrome.
    ///
    /// <c>false</c>
    /// </summary>
    static member inline allowWebkitAcceleration (value: bool): IStyleAnimation = "allowWebkitAcceleration" ==>! value


[<AllowNullLiteral>]
[<Interface>]
type DevTools =
    abstract member record: DevTools.record with get, set
    abstract member isRecording: bool with get, set


type EasingFunction = float -> float

module EasingGenerator =
    type createAnimation =
        delegate of keyframes: ResizeArray<UnresolvedValueKeyframe> * ?shouldGenerate: bool * ?readInitialKeyframe: (unit -> U2<float, string>) * ?name: string * ?value: MotionValue -> CustomAnimationSettings

module KeyframeOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type easing =
        | linear
        | ease
        | ``ease-in``
        | ``ease-out``
        | ``ease-in-out``
        | ``step-start``
        | ``step-end``

module AnimationOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type easing =
        | linear
        | ease
        | ``ease-in``
        | ``ease-out``
        | ``ease-in-out``
        | ``step-start``
        | ``step-end``

module DevTools =

    type record =
        delegate of element: HTMLElement * valueName: string * keyframes: obj * options: AnimationOptions -> unit