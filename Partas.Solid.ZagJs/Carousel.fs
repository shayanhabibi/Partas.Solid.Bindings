namespace Partas.Solid.ZagJs
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Partas.Solid

[<Erase>]
module Carousel =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyPart =
            | Root
            | ItemGroup
            | Item
            | Control
            | NextTrigger
            | PrevTrigger
            | IndicatorGroup
            | Indicator
            | AutoplayTrigger
    type PageChangeDetails =
        abstract page: int with get,set
        abstract pageSnapPoint: float with get,set
    [<StringEnum>]
    type DragStatus =
        | [<CompiledName("dragging.start")>] Start
        | Dragging
        | [<CompiledName("dragging.end")>] End
    [<StringEnum>]
    type AutoplayStatus =
        | [<CompiledName("autoplay.start")>] Start
        | Autoplay
        | [<CompiledName("autoplay.stop")>] Stop
        
    type DragStatusDetails =
        abstract ``type``: DragStatus
        abstract page: int
        abstract isDragging: bool
    
    type AutoplayStatusDetails =
        abstract ``type``: AutoplayStatus
        abstract page: int
        abstract isPlaying: bool
    
    type ElementIds =
        abstract root: string with get,set
        abstract item: index: int -> string with get,set
        abstract itemGroup: string with get,set
        abstract nextTrigger: string
        abstract prevTrigger: string
        abstract indicatorGroup: string
        abstract indicator: index: int -> string with get,set
    [<StringEnum>]
    type SlidesPerMove =
        | Auto
    [<StringEnum>]
    type SnapType =
        | Proximity
        | Mandatory
    [<StringEnum>]
    type SnapAlign =
        | Start
        | End
        | Center

    [<Pojo>]
    type ItemProps(
        index: int,
        ?snapAlign: SnapAlign
        ) =
        member val index = index with get,set
        member val snapAlign = snapAlign with get,set

    [<Pojo>]
    type IndicatorProps(
        index: int,
        ?readOnly: bool
        ) =
        member val index = index with get,set
        member val readOnly = readOnly with get,set
        
type CarouselProps =
    inherit DirectionProperty
    inherit CommonProperties
    inherit OrientationProperty
    abstract ids: Carousel.ElementIds with get,set
    abstract translations: obj with get,set
    abstract slidesPerPage: int with get,set
    abstract slidesPerMove: U2<int, Carousel.SlidesPerMove> with get,set
    abstract autoplay: U2<bool, {| delay: float |}> with get,set
    abstract allowMouseDrag: bool with get,set
    abstract loop: bool with get,set
    abstract page: float with get,set
    abstract defaultPage: int with get,set
    abstract spacing: string with get,set
    abstract padding: string with get,set
    abstract onPageChange: Carousel.PageChangeDetails -> unit with get,set
    abstract inViewThreshold: U2<float, float[]> with get,set
    abstract snapType: Carousel.SnapType with get,set
    abstract slideCount: int
    abstract onDragStatusChange: Carousel.DragStatusDetails -> unit with get,set
    abstract onAutoplayStatusChange: Carousel.AutoplayStatusDetails -> unit with get,set


        
type CarouselApi =
    abstract page: int
    abstract pageSnapPoints: float[]
    abstract isPlaying: bool
    abstract isDragging: bool
    abstract canScrollNext: bool
    abstract canScrollPrev: bool
    abstract scrollToIndex: index: int * ?instant: bool -> unit
    abstract scrollTo: page: int * ?instant: bool -> unit
    abstract scrollNext: ?instant: bool -> unit
    abstract scrollPrev: ?instant: bool -> unit
    abstract getProgress: unit -> float
    abstract play: unit -> unit
    abstract pause: unit -> unit
    abstract isInView: index: int -> bool
    abstract refresh: unit -> unit
    abstract getRootProps: unit -> HtmlTag
    abstract getControlProps: unit -> HtmlTag
    abstract getItemGroupProps: unit -> HtmlTag
    abstract getItemProps: props: Carousel.ItemProps -> HtmlTag
    abstract getPrevTriggerProps: unit -> button
    abstract getNextTriggerProps: unit -> button
    abstract getAutoplayTriggerProps: unit -> button
    abstract getIndicatorGroupProps: unit -> HtmlTag
    abstract getIndicatorProps: props: Carousel.IndicatorProps -> button
    
