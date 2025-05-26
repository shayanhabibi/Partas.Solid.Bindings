namespace Partas.Solid.Motion

open Fable.Core.JS
open JetBrains.Annotations
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type OptionKeys = interface end
[<Erase>]
type AttrKey = interface end
[<Erase>]
type MotionEventKeys = interface end

[<AllowNullLiteral>]
[<Interface>]
type MotionStateContext =
    abstract member initial: string option with get, set
    abstract member animate: string option with get, set
    abstract member inView: string option with get, set
    abstract member hover: string option with get, set
    abstract member press: string option with get, set
    abstract member exit: string option with get, set


[<Erase; AutoOpen>]
module Extensions =
    open System.ComponentModel
    type AttrKey with
        [<Erase>]
        member _.tag
            with set(value: TagValue) = ()
    
    type OptionKeys with
        [<CompiledName("initial");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_initial with set(value: obj) = ()
        [<CompiledName("animate");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_animate with set(value: obj) = ()
        [<CompiledName("inView");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_inView with set(value: obj) = ()
        [<CompiledName("inViewOptions");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_inViewOptions with set(value: obj) = ()
        [<CompiledName("hover");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_hover with set(value: obj) = ()
        [<CompiledName("press");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_press with set(value: obj) = ()
        [<CompiledName("variants");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_variants with set(value: obj) = ()
        [<CompiledName("transition");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_transition with set(value: obj) = ()
        [<CompiledName("exit");
          Erase;
          EditorBrowsable(EditorBrowsableState.Never)>]
        member _.z_route_exit with set(value: obj) = ()
        /// <summary>
        /// Alias for the <c>initial</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(initial = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.initialCss
            with inline set(value: string) = this.z_route_initial <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.initial
            with inline set(value: IMotionStyle list) = this.z_route_initial <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Alias for the <c>animate</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(animate = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.animateCss
            with inline set(value: string) = this.z_route_animate <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.animate
            with inline set(value: IMotionStyle list) = this.z_route_animate <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Alias for the <c>inView</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(inView = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.inViewCss
            with inline set(value: string) = this.z_route_inView <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.inView
            with inline set(value: IMotionStyle list) = this.z_route_inView <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Provide a list of props via <c>InViewOption.</c>. Feliz style.
        /// </summary>
        member this.inViewOptions
            with inline set(value: IInViewOption list) = this.z_route_inViewOptions <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Alias for the <c>hover</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(hover = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.hoverCss
            with inline set(value: string) = this.z_route_hover <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.hover
            with inline set(value: IMotionStyle list) = this.z_route_hover <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Alias for the <c>press</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(press = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.pressCss
            with inline set(value: string) = this.z_route_press <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.press
            with inline set(value: IMotionStyle list) = this.z_route_press <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Alias for the <c>variants</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(variants = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.variantsCss
            with inline set(value: string) = this.z_route_variants <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.variants
            with inline set(value: IMotionStyle list) = this.z_route_variants <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Provide a list of props via <c>MotionTransition.</c>. Feliz style.
        /// </summary>
        member this.transition
            with inline set(value: IMotionTransition list) = this.z_route_transition <- createObj !!value
            and [<Erase>] get() = undefined
        /// <summary>
        /// Alias for the <c>exit</c> prop, except you provide a string with css completion in supporting IDEs like Rider
        /// </summary>
        /// <example><code>
        /// Motion.div(exit = "{ opacity: 0 }")
        /// </code></example>
        [<LanguageInjection(InjectedLanguage.CSS, Prefix = ".x{", Suffix = "}")>]
        member this.exitCss
            with inline set(value: string) = this.z_route_exit <- JSX.jsx $"{value}"
        /// <summary>
        /// Provide a list of props via <c>MotionStyle.</c>. Feliz style.
        /// </summary>
        member this.exit
            with inline set(value: IMotionStyle list) = this.z_route_exit <- createObj !!value
            and [<Erase>] get() = undefined
    type MotionEventKeys with
        member _.onMotionStart with set(handler: MotionEvent<string> -> unit) = ()
        member _.onMotionComplete with set(handler: MotionEvent<string> -> unit) = ()
        member _.onHoverStart with set(handler: CustomPointerEvent -> unit) = ()
        member _.onHoverEnd with set(handler: CustomPointerEvent -> unit) = ()
        member _.onPressStart with set(handler: CustomPointerEvent -> unit) = ()
        member _.onPressEnd with set(handler: CustomPointerEvent -> unit) = ()
        member _.onViewEnter with set(handler: ViewEvent -> unit) = ()
        member _.onViewLeave with set(handler: ViewEvent -> unit) = ()

[<Import("Presence", "solid-motionone")>]
type Presence() =
    interface HtmlContainer
    [<Erase>] member val exitBeforeEnter: bool = unbox null with get,set
    [<Erase>] member val initial: bool = unbox null with get,set

[<JS.Pojo>]
type Options() =
    interface OptionKeys

[<AllowNullLiteral; Interface>]
type Generator<'T> =
    abstract member next: (unit -> unit) with get

[<AllowNullLiteral>]
[<Interface>]
type MotionState =
    abstract member update: (Options -> unit) with get, set
    abstract member getDepth: (unit -> float) with get, set
    abstract member getTarget: (unit -> string) with get, set
    abstract member getOptions: (unit -> Options) with get, set
    abstract member getContext: (unit -> MotionStateContext) with get, set
    abstract member setActive: MotionState.setActive with get, set
    abstract member mount: (HtmlElement -> (unit -> unit)) with get, set
    abstract member isMounted: (unit -> bool) with get, set
    abstract member animateUpdates: (unit -> Generator<unit>) with get, set
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