namespace Partas.Solid.EmblaCarousel

open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Erase; AutoOpen>]
module private Path =
    let [<Literal>] path = "embla-carousel-solid"
    
[<AllowNullLiteral; Interface>]
type EmblaCarouselOptions = interface end
[<AllowNullLiteral; Interface>]
type EmblaCarouselPlugin = interface end
[<StringEnum; RequireQualifiedAccess>]
type EmblaCarouselEvent =
    | Init
    | ReInit
    | Destroy
    | Select
    | Scroll
    | Settle
    | Resize
    | SlidesInView
    | SlidesChanged
    | SlideFocus
    | PointerDown
    | PointerUp

[<AllowNullLiteral; Interface>]
type EmblaCarouselApi =
    abstract member rootNode: unit -> HtmlElement
    abstract member containerNode: unit -> HtmlElement
    abstract member slideNodes: unit ->  HtmlElement list
    abstract member scrollNext: ?jump: bool -> unit
    abstract member scrollPrev: ?jump: bool -> unit
    abstract member scrollTo: index: int * ?jump: bool -> unit
    abstract member canScrollNext: unit -> bool
    abstract member canScrollPrev: unit -> bool
    abstract member selectedScrollSnap: unit -> int
    abstract member previousScrollSnap: unit -> int
    abstract member scrollSnapList: unit -> int list
    abstract member scrollProgress: unit -> int
    abstract member slidesInView: unit -> int list
    abstract member slidesNotInView: unit -> int list
    abstract member reInit: ?options: EmblaCarouselOptions * ?plugins: EmblaCarouselPlugin[] -> unit
    abstract member plugins: unit -> Map<string, EmblaCarouselPlugin>
    abstract member destroy: unit -> unit
    abstract member on: event: EmblaCarouselEvent * (EmblaCarouselApi * EmblaCarouselEvent -> unit) -> unit
    abstract member off: event: EmblaCarouselEvent * (EmblaCarouselApi * EmblaCarouselEvent -> unit) -> unit
    abstract member emit: EmblaCarouselEvent -> unit
    
[<AllowNullLiteral; Interface>]
type EmblaCarouselRef = interface end

[<Import("createEmblaCarousel", path)>]
type createEmblaCarousel =
    static member globalOptions (options: EmblaCarouselOptions): unit = jsNative

[<Erase; AutoOpen>]
type Exports =
    /// <example><code>
    /// import { onMount } from 'solid-js'
    /// import createEmblaCarousel from 'embla-carousel-solid'
    /// 
    /// export function EmblaCarousel() {
    ///   const [emblaRef, emblaApi] = createEmblaCarousel()
    /// 
    ///   onMount(() => {
    ///     const api = emblaApi()
    ///     if (api) console.log(api.slideNodes())
    ///   })
    /// 
    ///   // ...
    /// }
    /// </code></example>
    [<ImportMember(path)>]
    static member createEmblaCarousel(constructor: unit -> EmblaCarouselOptions, ?plugins: unit -> EmblaCarouselPlugin[]): Accessor<EmblaCarouselRef> * Accessor<EmblaCarouselApi> = jsNative




[<Erase; AutoOpen>]
module Options =
    type EmblaCarouselOptions with
        /// <summary>
        /// Setting this to <c>false</c> will not activate or deactivate the carousel. Useful when used together with the breakpoints option to toggle the carousel active/inactive depending on media queries. 
        /// </summary>
        /// <remarks>Defaults <c>true</c></remarks>
        member _.active
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
        /// <summary>
        /// Align the slides relative to the carousel viewport. Use one of the predefined alignments <c>start</c>, <c>center</c> or <c>end</c>. Alternatively, provide your own callback to fully customize the alignment.
        /// </summary>
        /// <remarks>Defaults <c>center</c><br/><br/>Use <c>alignCallback</c> to set callback with type signature</remarks>
        member _.align
                    with set(value: string) = ()
                    and get(): (string) = unbox null
        /// <summary>
        /// Align the slides relative to the carousel viewport. Use one of the predefined alignments <c>start</c>, <c>center</c> or <c>end</c>. Alternatively, provide your own callback to fully customize the alignment.
        /// </summary>
        /// <remarks>Defaults <c>center</c><br/><br/>Use <c>align</c> to set with enum signature</remarks>
        member inline this.alignCallback
            with set(value: int * int * int -> int) = this.align <- !!value
            and get(): (int * int * int ->  int) = unbox this.align
        /// <summary>
        /// Choose scroll axis between <c>x</c> and <c>y</c>. Remember to stack your slides horizontally or vertically using CSS to match this option.
        /// </summary>
        /// <remarks>Defaults <c>x</c></remarks>
        member _.axis
                    with set(value: string) = ()
                    and get(): (string) = unbox null
        /// <summary>
        /// An object with options that will be applied for a given breakpoint by overriding the options at the root level. Example: <code>'(min-width: 768px)': { loop: false }</code>
        /// </summary>
        /// <remarks>
        /// If multiple queries match, they will be merged. And when breakpoint options clash, the last one in the list has precedence.
        /// </remarks>
        member _.breakpoints
                    with set(value: obj) = ()
                    and get(): (obj) = unbox null
        /// <summary>
        /// Enables choosing a custom container element which holds the slides. By default, Embla will choose the first direct child element of the root element. Provide either a valid CSS selector string or a HTML element.
        /// </summary>
        member _.container
                    with set(value: string) = ()
                    and get(): (string) = unbox null
        /// <summary>
        /// Clear leading and trailing empty space that causes excessive scrolling. Use trimSnaps to only use snap points that trigger scrolling or keepSnaps to keep them.
        /// </summary>
        /// <remarks>
        /// When this is active, it will override alignments applied by the align option for enough slides at the start and the end of the carousel, in order to cover the leading and trailing space.
        /// <br/><br/>Defaults <c>trimSnaps</c>
        /// </remarks>
        member _.containScroll
                    with set(value: string) = ()
                    and get(): (string) = unbox null
        /// <summary>
        /// Choose content direction between ltr and rtl.
        /// </summary>
        /// <remarks>
        /// Note: When using rtl, the content direction also has to be set to RTL, either by using the HTML dir attribute or the CSS direction property.
        /// </remarks>
        member _.direction
                    with set(value: string) = ()
                    and get(): (string) = unbox null
        /// <summary>
        /// Enables momentum scrolling. The duration of the continued scrolling is proportional to how vigorous the drag gesture is.
        /// </summary>
        member _.dragFree
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
        /// <summary>
        /// Drag threshold in pixels. This only affects when clicks are fired and not. In contrast to other carousel libraries, it will not affect when dragging of the carousel starts.
        /// </summary>
        /// <remarks>
        /// Browsers handle touch events differently than mouse events. Browsers won't fire the click event when a touch event includes an accidental slight swipe gesture. This is why this threshold only works for mouse events.
        /// <br/><br/> Defaults <c>10</c>
        /// </remarks>
        member _.dragThreshold
                    with set(value: int) = ()
                    and get(): (int) = unbox null
        /// <summary>
        /// Set scroll duration when triggered by any of the API methods. Higher numbers enables slower scrolling. Drag interactions are not affected because duration is then determined by the drag force.
        /// </summary>
        /// <remarks>
        /// Note: Duration is not in milliseconds because Embla uses an attraction physics simulation when scrolling instead of easings. Only values between 20-60 are recommended.
        /// <br/><br/>Defaults <c>25</c>
        /// </remarks>
        member _.duration
                    with set(value: int) = ()
                    and get(): (int) = unbox null
        /// <summary>
        /// This is the Intersection Observer threshold option that will be applied to all slides.
        /// </summary>
        member _.inViewThreshold
                    with set(value: int) = ()
                    and get(): (int) = unbox null
        /// <summary>
        /// Enables infinite looping. Embla will apply translateX or translateY to the slides that need to change position in order to create the loop effect.
        /// </summary>
        /// <remarks>
        /// Embla automatically falls back to false if slide content isn't enough to create the loop effect without visible glitches.
        /// <br/><br/>Defaults <c>false</c>
        /// </remarks>
        member _.loop
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
        /// <summary>
        /// Allow the carousel to skip scroll snaps if it's dragged vigorously. Note that this option will be ignored if the dragFree option is set to true.
        /// </summary>
        /// <remarks>Defaults <c>false</c></remarks>
        member _.skipSnaps
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
                    
        /// <summary>
        /// Enables using custom slide elements. By default, Embla will choose all direct child elements of its container. Provide either a valid CSS selector string or a nodeList/array containing HTML elements.
        /// <remarks>
        /// Note: Even though it's possible to provide custom slide elements, they still have to be direct descendants of the carousel container.<br/><br/>
        /// Warning: If you place elements inside the carousel container that aren't slides, they either shouldn't have any size, or should be detached from the document flow with position: absolute or similar.
        /// </remarks>
        /// </summary>
        member _.slides
                    with set(value: string) = ()
                    and get(): (string) = unbox null

        /// <summary>
        /// Group slides together. Drag interactions, dot navigation, and previous/next buttons are mapped to group slides into the given number, which has to be an integer. Set it to auto if you want Embla to group slides automatically.
        /// </summary>
        member _.slidesToScroll
                    with set(value: int) = ()
                    and get(): (int) = unbox null
        
        /// <summary>
        /// Set the initial scroll snap to the given number. First snap index starts at 0. Please note that this is not necessarily equal to the number of slides when used together with the slidesToScroll option.
        /// </summary>
        member _.startIndex
                    with set(value: int) = ()
                    and get(): (int) = unbox null

        /// <summary>
        /// Enables for scrolling the carousel with mouse and touch interactions. Set this to false to disable drag events or pass a custom callback to add your own drag logic.
        /// </summary>
        /// <remarks>
        /// Note: When passing a custom callback it will run before the default Embla drag behaviour. Return true in your callback if you want Embla to run its default drag behaviour after your callback, or return false if you want to skip it.
        /// </remarks>
        member _.watchDrag
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
        
        /// <summary>
        /// Embla automatically watches the slides for focus events. The default callback fires the slideFocus event and scrolls to the focused element. Set this to false to disable this behaviour or pass a custom callback to add your own focus logic.
        /// </summary>
        /// <remarks>
        /// Note: When passing a custom callback it will run before the default Embla focus behaviour. Return true in your callback if you want Embla to run its default focus behaviour after your callback, or return false if you want to skip it.
        /// </remarks>
        member _.watchFocus
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
        
        /// <summary>
        /// Embla automatically watches the container and slides for size changes and runs reInit when any size has changed. Set this to false to disable this behaviour or pass a custom callback to add your own resize logic.
        /// </summary>
        /// <remarks>
        /// Note: When passing a custom callback it will run before the default Embla resize behaviour. Return true in your callback if you want Embla to run its default resize behaviour after your callback, or return false if you want to skip it.
        /// </remarks>
        member _.watchResize
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
        
        /// <summary>
        /// Embla automatically watches the container for added and/or removed slides and runs reInit if needed. Set this to false to disable this behaviour or pass a custom callback to add your own slides changed logic.
        /// </summary>
        /// <remarks>
        /// Note: When passing a custom callback it will run before the default Embla mutation behaviour. Return true in your callback if you want Embla to run its default mutation behaviour after your callback, or return false if you want to skip it.
        /// </remarks>
        member _.watchSlides
                    with set(value: bool) = ()
                    and get(): (bool) = unbox null
                                                                                                                                                                