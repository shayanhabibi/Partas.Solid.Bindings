module Partas.Solid.ArkUI.Carousel
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Partas.Solid.ZagJs

[<Literal>]
let private carouselPath = "@ark-ui/solid/carousel"


[<Import("Carousel.Root", carouselPath)>]
type Root
    /// <summary>
    /// <code>
    /// --slides-per-page : The number of slides visible per page
    /// --slide-spacing : The spacing between slides
    /// --slide-item-size : The calculated size of each slide item
    /// [data-scope] : carousel
    /// [data-part] : root
    /// [data-orientation]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface DirectionProperty
    interface CommonProperties
    interface OrientationProperty
    interface Polymorph
    /// <summary>
    /// The ids of the elements in the carousel. Useful for composition
    /// </summary>
    [<Erase>]
    member val ids: Carousel.ElementIds = JS.undefined with get , set
    /// <summary>
    /// The localized messages to use.
    /// </summary>
    [<Erase>]
    member val translations: obj = JS.undefined with get , set
    /// <summary>
    /// The number of slides to show at a time.
    /// </summary>
    /// <defaultValue>1</defaultValue>
    [<Erase>]
    member val slidesPerPage: int = JS.undefined with get , set
    /// <summary>
    /// The number of slides to scroll at a time. When set to `auto`,
    /// the number of slides to scroll is determined by the `slidesPerPage` property
    /// </summary>
    /// <defaultValue>Carousel.SlidesPerPage.Auto</defaultValue>
    [<Erase>]
    member val slidesPerMove: U2<int, Carousel.SlidesPerMove> = JS.undefined with get , set
    /// <summary>
    /// Whether to scroll automatically. The default delay is 4000ms.
    /// </summary>
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val autoplay: U2<bool, {| delay: float |}> = JS.undefined with get , set
    /// <summary>
    /// Whether to allow scrolling via dragging with mouse.
    /// </summary>
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val allowMouseDrag: bool = JS.undefined with get , set
    /// <summary>
    /// Whether the carousel should loop around.
    /// </summary>
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val loop: bool = JS.undefined with get , set
    /// <summary>
    /// The controlled page of the carousel.
    /// </summary>
    [<Erase>]
    member val page: int = JS.undefined with get , set
    /// <summary>
    /// The initial page to scroll to when rendered.
    /// </summary>
    /// <defaultValue>0</defaultValue>
    [<Erase>]
    member val defaultPage: int = JS.undefined with get , set
    /// <summary>
    /// The amount of space between items.
    /// </summary>
    /// <defaultValue>"0px"</defaultValue>
    [<Erase>]
    member val spacing: string = JS.undefined with get , set
    /// <summary>
    /// Defines the extra space added around the scrollable area, enabling nearby
    /// items to remain partially in view.
    /// </summary>
    [<Erase>]
    member val padding: string = JS.undefined with get , set
    /// <summary>
    /// Function called when the page changes.
    /// </summary>
    [<Erase>]
    member val onPageChange: Carousel.PageChangeDetails -> unit = JS.undefined with get , set
    /// <summary>
    /// The threshold for determining if an item is in view.
    /// </summary>
    /// <defaultValue>0.6</defaultValue>
    [<Erase>]
    member val inViewThreshold: U2<float, float[]> = JS.undefined with get , set
    /// <summary>
    /// The snap type of the item
    /// </summary>
    /// <defaultValue>Carousel.SnapType.Mandatory</defaultValue>
    [<Erase>]
    member val snapType: Carousel.SnapType = JS.undefined with get , set
    /// <summary>
    /// The total number of slides. Useful for SSR to render the initial ating the snap points.
    /// </summary>
    [<Erase>]
    member val slideCount: int = JS.undefined with get , set

    [<Erase>]
    member val onDragStatusChange: Carousel.DragStatusDetails -> unit = JS.undefined with get , set

    [<Erase>]
    member val onAutoplayStatusChange: Carousel.AutoplayStatusDetails -> unit = JS.undefined with get , set

[<Import("Carousel.AutoplayTrigger", carouselPath)>]
type AutoplayTrigger
    /// <summary>
    /// <code>
    /// [data-scope] : carousel
    /// [data-part] : autoplay-trigger
    /// [data-orientation]
    /// [data-pressed]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set

[<Import("Carousel.Control", carouselPath)>]
type Control
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] control
    /// [data-orientation]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import("Carousel.IndicatorGroup", carouselPath)>]
type IndicatorGroup
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] indicator-group
    /// [data-orientation]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import("Carousel.Indicator", carouselPath)>]
type Indicator
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] indicator
    /// [data-orientation]
    /// [data-index]
    /// [data-readonly]
    /// [data-current]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val index: int = undefined with get,set
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val readOnly: bool = undefined with get,set
[<Import("Carousel.ItemGroup", carouselPath)>]
type ItemGroup
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] item-group
    /// [data-orientation]
    /// [data-dragging]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import("Carousel.Item", carouselPath)>]
type Item
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] item
    /// [data-index]
    /// [data-inview]
    /// [data-orientation]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val index: int = undefined with get,set
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
    /// <defaultValue>Carousel.SnapAlign.Start</defaultValue>
    [<Erase>]
    member val snapAlign: Carousel.SnapAlign = undefined with get,set

[<Import("Carousel.NextTrigger", carouselPath)>]
type NextTrigger
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] next-trigger
    /// [data-orientation]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
[<Import("Carousel.PrevTrigger", carouselPath)>]
type PrevTrigger
    /// <summary>
    /// <code>
    /// [data-scope] carousel
    /// [data-part] prev-trigger
    /// [data-orientation]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set

[<Import("Carousel.RootProvider", carouselPath)>]
type RootProvider() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val value: Accessor<CarouselApi> = undefined with get,set
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import("Carousel.Context", carouselPath)>]
type Context() =
    interface HtmlElement
    interface ChildLambdaProvider<Accessor<CarouselApi>>
