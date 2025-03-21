namespace rec Partas.Solid.Motion

open Partas.Solid.Motion.LibDom
open Fable.Core
open Browser.Types
open System
open Fable.Core.JsInterop

[<AbstractClass>]
[<Erase>]
type Exports =
    [<Import("MotionValue", "@motionone/types"); EmitConstructor>]
    static member MotionValue () : MotionValue = nativeOnly

[<AllowNullLiteral>]
[<Interface>]
type MotionValue =
    abstract member animation: BasicAnimationControls option with get, set
    abstract member generatorStartTime: float option with get, set
    abstract member generator: AnimationGenerator option with get, set
    abstract member setAnimation: ?animation: BasicAnimationControls -> unit
    abstract member clearAnimation: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type AnimationGeneratorState =
    abstract member ``done``: bool with get, set
    abstract member hasReachedTarget: bool with get, set
    abstract member current: float with get, set
    abstract member target: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type ProgressFunction =
    [<Emit("$0($1...)")>]
    abstract member Invoke: t: float -> unit

[<AllowNullLiteral>]
[<Interface>]
type AnimationGeneratorFactory<'Options> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: options: 'Options -> AnimationGenerator

[<AllowNullLiteral>]
[<Interface>]
type AnimationGenerator =
    [<Emit("$0($1...)")>]
    abstract member Invoke: t: float -> AnimationGeneratorState

type BezierDefinition =
    float * float * float * float

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
    // abstract member play: unit -> unit with get, set
    // /// <summary>
    // /// Pause the animation.
    // ///
    // /// <code lang="javascript">
    // /// animation.pause()
    // /// </code>
    // /// </summary>
    // abstract member pause: unit -> unit with get, set
    // abstract member commitStyles: unit -> unit with get, set
    // /// <summary>
    // /// Cancels the animation and reverts the element to its underlying styles.
    // ///
    // /// <code lang="javascript">
    // /// animation.cancel()
    // /// </code>
    // /// </summary>
    // abstract member cancel: unit -> unit with get, set
    // abstract member stop: unit -> unit with get, set
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
    // abstract member stop: unit -> unit with get, set
    /// <summary>
    /// Immediately completes the animation and commits the final keyframe to the element's styles.
    ///
    /// <code lang="javascript">
    /// animation.finish()
    /// </code>
    /// </summary>
    // abstract member finish: unit -> unit with get, set
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
    // abstract member reverse: unit -> unit with get, set
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
    // abstract member playState: AnimationPlayState with get, set

[<AllowNullLiteral>]
[<Interface>]
type CustomAnimationSettings =
    abstract member easing: Easing with get, set
    abstract member keyframes: ResizeArray<U2<float, string>> option with get, set
    abstract member duration: float option with get, set

type ValueKeyframe =
    U2<string, float>

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

[<AllowNullLiteral>]
[<Interface>]
type EasingGenerator =
    abstract member createAnimation: EasingGenerator.createAnimation with get, set

[<AllowNullLiteral>]
[<Interface>]
type KeyframeOptions =
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    abstract member duration: float option with get, set
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
    abstract member easing: KeyframeOptions.easing option with get, set
    /// <summary>
    /// The offset of each keyframe, as a number between 0 and 1.
    ///
    /// The number of <c>offset</c> entries must match the number of <c>keyframes</c> entries.
    ///
    /// <c>[0, 1]</c>
    /// </summary>
    abstract member offset: ResizeArray<float> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type OptionResolver<'T> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: i: float * total: float -> 'T

[<AllowNullLiteral>]
[<Interface>]
type PlaybackOptions =
    /// <summary>
    /// A duration, in seconds, that the animation will be delayed before starting.
    ///
    /// <c>0</c>
    /// </summary>
    abstract member delay: float option with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will wait at the end before ending.
    ///
    /// <c>0</c>
    /// </summary>
    abstract member endDelay: float option with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    abstract member repeat: float option with get, set
    /// <summary>
    /// The direction of animation playback. <c>"normal"</c>, <c>"reverse"</c>, <c>"alternate"</c>, or <c>"alternate-reverse"</c>.
    ///
    /// <c>"normal"</c>
    /// </summary>
    abstract member direction: PlaybackDirection option with get, set
    abstract member persist: bool option with get, set
    /// <summary>
    /// Whether the animation should start automatically.
    ///
    /// <c>true</c>
    /// </summary>
    abstract member autoplay: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DevToolsOptions =
    abstract member record: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AnimationOptions =
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    abstract member duration: float option with get, set
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
    abstract member easing: AnimationOptions.easing option with get, set
    /// <summary>
    /// The offset of each keyframe, as a number between 0 and 1.
    ///
    /// The number of <c>offset</c> entries must match the number of <c>keyframes</c> entries.
    ///
    /// <c>[0, 1]</c>
    /// </summary>
    abstract member offset: ResizeArray<float> option with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will be delayed before starting.
    ///
    /// <c>0</c>
    /// </summary>
    abstract member delay: float option with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will wait at the end before ending.
    ///
    /// <c>0</c>
    /// </summary>
    abstract member endDelay: float option with get, set
    /// <summary>
    /// A duration, in seconds, that the animation will take to complete.
    ///
    /// <c>0.3</c>
    /// </summary>
    abstract member repeat: float option with get, set
    /// <summary>
    /// The direction of animation playback. <c>"normal"</c>, <c>"reverse"</c>, <c>"alternate"</c>, or <c>"alternate-reverse"</c>.
    ///
    /// <c>"normal"</c>
    /// </summary>
    abstract member direction: PlaybackDirection option with get, set
    abstract member persist: bool option with get, set
    /// <summary>
    /// Whether the animation should start automatically.
    ///
    /// <c>true</c>
    /// </summary>
    abstract member autoplay: bool option with get, set
    abstract member record: bool option with get, set
    /// <summary>
    /// Because of numerous timing bugs in Webkit's accelerated animations, these are disabled by default in Webkit-powered browsers.
    ///
    /// However, if the your animation is being disrupted by heavy processing, you can allow acceleration with this setting.
    /// It's advised you test these animations thoroughly in both Safari and iOS Chrome.
    ///
    /// <c>false</c>
    /// </summary>
    abstract member allowWebkitAcceleration: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DevTools =
    abstract member record: DevTools.record with get, set
    abstract member isRecording: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type EasingFunction =
    [<Emit("$0($1...)")>]
    abstract member Invoke: t: float -> float

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
