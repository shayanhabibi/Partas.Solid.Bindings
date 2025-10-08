namespace rec Partas.Solid.TanStack.Virtual

open System.Runtime.CompilerServices
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open System
open Partas.Solid

[<Fable.Core.Erase>]
module Spec =
    [<Literal>]
    let path = "@tanstack/solid-virtual"

[<Fable.Core.Erase; AutoOpen>]
module Enums =
    [<RequireQualifiedAccess>]
    [<StringEnum>]
    type ScrollDirection =
        | Forward
        | Backward

    [<RequireQualifiedAccess>]
    [<StringEnum>]
    type ScrollAlignment =
        | Start
        | Center
        | End
        | Auto

    [<RequireQualifiedAccess>]
    [<StringEnum>]
    type ScrollBehavior =
        | Auto
        | Smooth
    [<Fable.Core.Erase; RequireQualifiedAccess>]
    module Scroll =
        type Behavior = ScrollBehavior
        type Alignment = ScrollAlignment
        type Direction = ScrollDirection

[<AutoOpen; Erase>]
type Exports =
    [<Import("defaultKeyExtractor", "@tanstack/solid-virtual")>]
    static member inline defaultKeyExtractor: (float -> float) = nativeOnly
    [<Import("defaultRangeExtractor", "@tanstack/solid-virtual")>]
    static member inline defaultRangeExtractor: (Range -> ResizeArray<float>) = nativeOnly
    [<Import("observeElementRect", "@tanstack/solid-virtual")>]
    static member inline observeElementRect: ObserveElementRect = nativeOnly
    [<Import("observeWindowRect", "@tanstack/solid-virtual")>]
    static member inline observeWindowRect: ObserveWindowRect = nativeOnly
    [<Import("observeElementOffset", "@tanstack/solid-virtual")>]
    static member inline observeElementOffset: ObserveElementOffset = nativeOnly
    [<Import("observeWindowOffset", "@tanstack/solid-virtual")>]
    static member inline observeWindowOffset: ObserveWindowOffset = nativeOnly
    [<Import("measureElement", "@tanstack/solid-virtual")>]
    static member inline measureElement: MeasureElement<'TItemElement> = nativeOnly
    [<Import("windowScroll", "@tanstack/solid-virtual")>]
    static member inline windowScroll: WindowScroll = nativeOnly
    [<Import("elementScroll", "@tanstack/solid-virtual")>]
    static member inline elementScroll: ElementScroll = nativeOnly

[<JS.Pojo>]
type ScrollToOptions(?align: ScrollAlignment option, ?behavior: ScrollBehavior option) =
    [<Erase>]
    member val align: ScrollAlignment option = JS.undefined with get , set

    [<Erase>]
    member val behavior: ScrollBehavior option = JS.undefined with get , set


type ScrollToOffsetOptions =
    ScrollToOptions

type ScrollToIndexOptions =
    ScrollToOptions

[<JS.Pojo>]
type Range(?startIndex: float, ?endIndex: float, ?overscan: float, ?count: float) =
    [<Erase>]
    member val startIndex: float = JS.undefined with get , set

    [<Erase>]
    member val endIndex: float = JS.undefined with get , set

    [<Erase>]
    member val overscan: float = JS.undefined with get , set

    [<Erase>]
    member val count: float = JS.undefined with get , set


type Key = U3<int, float, string>

[<JS.Pojo>]
type VirtualItem(?key: Key, ?index: float, ?start: float, ?``end``: float, ?size: float, ?lane: float) =
    [<Erase>]
    member val key: Key = JS.undefined with get , set

    [<Erase>]
    member val index: float = JS.undefined with get , set

    [<Erase>]
    member val start: float = JS.undefined with get , set

    [<Erase>]
    member val ``end``: float = JS.undefined with get , set

    [<Erase>]
    member val size: float = JS.undefined with get , set

    [<Erase>]
    member val lane: float = JS.undefined with get , set

[<JS.Pojo>]
type Rect(?width: float, ?height: float) =
    [<Erase>]
    member val width: float = JS.undefined with get , set

    [<Erase>]
    member val height: float = JS.undefined with get , set


type ObserveOffsetCallback =
    delegate of offset: float * isScrolling: bool -> unit

[<JS.Pojo>]
type VirtualizerOptions<'TItemElement>
    (
        ?count: float,
        ?getScrollElement: (unit -> HtmlElement option),
        ?estimateSize: (float -> float),
        ?scrollToFn: ScrollToFn<'TItemElement>,
        ?observeElementRect: ObserveElementRect,
        ?observeElementOffset: ObserveElementOffset,
        ?debug: bool,
        ?initialRect: Rect,
        ?onChange: OnChangeFn<'TItemElement>,
        ?measureElement: MeasureElement<'TItemElement>,
        ?overscan: float,
        ?horizontal: bool,
        ?paddingStart: float,
        ?paddingEnd: float,
        ?scrollPaddingStart: float,
        ?scrollPaddingEnd: float,
        ?initialOffset: U2<float, (unit -> float)>,
        ?getItemKey: (float -> Key),
        ?rangeExtractor: (Range -> ResizeArray<float>),
        ?scrollMargin: float,
        ?gap: float,
        ?indexAttribute: string,
        ?initialMeasurementsCache: ResizeArray<VirtualItem>,
        ?lanes: float,
        ?isScrollingResetDelay: float,
        ?useScrollendEvent: bool,
        ?enabled: bool,
        ?isRtl: bool,
        ?useAnimationFrameWithResizeObserver: bool
    ) =
    [<Erase>]
    member val count: float = JS.undefined with get , set

    [<Erase>]
    member val getScrollElement: (unit -> HtmlElement option) = JS.undefined with get , set

    [<Erase>]
    member val estimateSize: (float -> float) = JS.undefined with get , set

    [<Erase>]
    member val scrollToFn: ScrollToFn<'TItemElement> = JS.undefined with get , set

    [<Erase>]
    member val observeElementRect: ObserveElementRect = JS.undefined with get , set

    [<Erase>]
    member val observeElementOffset: ObserveElementOffset = JS.undefined with get , set

    [<Erase>]
    member val debug: bool option = JS.undefined with get , set

    [<Erase>]
    member val initialRect: Rect option = JS.undefined with get , set

    [<Erase>]
    member val onChange: OnChangeFn<'TItemElement> option = JS.undefined with get , set

    [<Erase>]
    member val measureElement: MeasureElement<'TItemElement> option = JS.undefined with get , set

    [<Erase>]
    member val overscan: float option = JS.undefined with get , set

    [<Erase>]
    member val horizontal: bool option = JS.undefined with get , set

    [<Erase>]
    member val paddingStart: float option = JS.undefined with get , set

    [<Erase>]
    member val paddingEnd: float option = JS.undefined with get , set

    [<Erase>]
    member val scrollPaddingStart: float option = JS.undefined with get , set

    [<Erase>]
    member val scrollPaddingEnd: float option = JS.undefined with get , set

    [<Erase>]
    member val initialOffset: U2<float, (unit -> float)> option = JS.undefined with get , set

    [<Erase>]
    member val getItemKey: (float -> Key) option = JS.undefined with get , set

    [<Erase>]
    member val rangeExtractor: (Range -> ResizeArray<float>) option = JS.undefined with get , set

    [<Erase>]
    member val scrollMargin: float option = JS.undefined with get , set

    [<Erase>]
    member val gap: float option = JS.undefined with get , set

    [<Erase>]
    member val indexAttribute: string option = JS.undefined with get , set

    [<Erase>]
    member val initialMeasurementsCache: ResizeArray<VirtualItem> option = JS.undefined with get , set

    [<Erase>]
    member val lanes: float option = JS.undefined with get , set

    [<Erase>]
    member val isScrollingResetDelay: float option = JS.undefined with get , set

    [<Erase>]
    member val useScrollendEvent: bool option = JS.undefined with get , set

    [<Erase>]
    member val enabled: bool option = JS.undefined with get , set

    [<Erase>]
    member val isRtl: bool option = JS.undefined with get , set

    [<Erase>]
    member val useAnimationFrameWithResizeObserver: bool option = JS.undefined with get , set

[<AllowNullLiteral>]
[<Interface>]
type Virtualizer<'TItemElement> =
    abstract member options: VirtualizerOptions<'TItemElement> with get, set
    abstract member scrollElement: U2<Window, HTMLElement> option with get, set
    abstract member targetWindow: obj option with get, set
    abstract member isScrolling: bool with get, set
    abstract member measurementsCache: ResizeArray<VirtualItem> with get, set
    abstract member scrollRect: Rect option with get, set
    abstract member scrollOffset: float option with get, set
    abstract member scrollDirection: ScrollDirection option with get, set
    abstract member shouldAdjustScrollPositionOnItemSizeChange: ShouldAdjustScrollPositionOnItemSizeChangeFn<'TItemElement> option with get, set
    abstract member elementsCache: Map<Key, 'TItemElement> with get, set
    abstract member range: Range option with get, set
    abstract member setOptions: (VirtualizerOptions<'TItemElement> -> unit) with get, set
    abstract member _didMount: (unit -> (unit -> unit)) with get, set
    abstract member _willUpdate: (unit -> unit) with get, set
    abstract member calculateRange: CalculateRangeFn with get, set
    abstract member getVirtualIndexes: GetVirtualIndexesFn with get, set
    abstract member indexFromElement: ('TItemElement -> float) with get, set
    abstract member resizeItem: ResizeItemFn with get, set
    abstract member measureElement: ('TItemElement option -> unit) with get, set
    abstract member getVirtualItems: GetVirtualItemsFn with get, set
    abstract member getVirtualItemForOffset: (float -> VirtualItem option) with get, set
    abstract member getOffsetForAlignment: GetOffsetForAlignmentFn with get, set
    abstract member getOffsetForIndex: GetOffsetForIndexFn with get, set
    abstract member scrollToOffset: ScrollToOffsetFn with get, set
    abstract member scrollToIndex: ScrollToIndexFn with get, set
    abstract member scrollBy: ScrollByFn with get, set
    abstract member getTotalSize: (unit -> float) with get, set
    abstract member ``measure``: (unit -> unit) with get, set
    
type Exports with
    [<ImportMember("@tanstack/solid-virtual"); ParamObject>]
    static member createVirtualizer<'TItemElement>(
            ?count: float,
            ?getScrollElement: (unit -> HtmlElement option),
            ?estimateSize: (float -> float),
            ?scrollToFn: ScrollToFn<'TItemElement>,
            ?observeElementRect: ObserveElementRect,
            ?observeElementOffset: ObserveElementOffset,
            ?debug: bool,
            ?initialRect: Rect,
            ?onChange: OnChangeFn<'TItemElement>,
            ?measureElement: MeasureElement<'TItemElement>,
            ?overscan: float,
            ?horizontal: bool,
            ?paddingStart: float,
            ?paddingEnd: float,
            ?scrollPaddingStart: float,
            ?scrollPaddingEnd: float,
            ?initialOffset: U2<float, (unit -> float)>,
            ?getItemKey: (float -> Key),
            ?rangeExtractor: (Range -> ResizeArray<float>),
            ?scrollMargin: float,
            ?gap: float,
            ?indexAttribute: string,
            ?initialMeasurementsCache: ResizeArray<VirtualItem>,
            ?lanes: float,
            ?isScrollingResetDelay: float,
            ?useScrollendEvent: bool,
            ?enabled: bool,
            ?isRtl: bool,
            ?useAnimationFrameWithResizeObserver: bool      
        ): Virtualizer<'TItemElement> = jsNative
    [<ImportMember("@tanstack/solid-virtual")>]
    static member createVirtualizer<'TItemElement>(options: VirtualizerOptions<'TItemElement>) = jsNative

    [<ImportMember("@tanstack/solid-virtual"); ParamObject>]
    static member createWindowVirtualizer<'TItemElement>(
            ?count: float,
            ?getScrollElement: unit -> HtmlElement option,
            ?estimateSize: float -> float,
            ?scrollToFn: ScrollToFn<'TItemElement>,
            ?observeElementRect: ObserveElementRect,
            ?observeElementOffset: ObserveElementOffset,
            ?debug: bool,
            ?initialRect: Rect,
            ?onChange: OnChangeFn<'TItemElement>,
            ?measureElement: MeasureElement<'TItemElement>,
            ?overscan: float,
            ?horizontal: bool,
            ?paddingStart: float,
            ?paddingEnd: float,
            ?scrollPaddingStart: float,
            ?scrollPaddingEnd: float,
            ?initialOffset: U2<float, (unit -> float)>,
            ?getItemKey: (float -> Key),
            ?rangeExtractor: (Range -> ResizeArray<float>),
            ?scrollMargin: float,
            ?gap: float,
            ?indexAttribute: string,
            ?initialMeasurementsCache: ResizeArray<VirtualItem>,
            ?lanes: float,
            ?isScrollingResetDelay: float,
            ?useScrollendEvent: bool,
            ?enabled: bool,
            ?isRtl: bool,
            ?useAnimationFrameWithResizeObserver: bool      
        ): Virtualizer<'TItemElement> = jsNative
    [<ImportMember("@tanstack/solid-virtual")>]
    static member createWindowVirtualizer<'TItemElement>(options: VirtualizerOptions<'TItemElement>) = jsNative

[<JS.Pojo>]
type ScrollToFnOptions(
    ?adjustments: float,
    ?behavior: ScrollBehavior
    ) =
    member val adjustments : float option = nativeOnly with get, set
    member val behavior : ScrollBehavior option = nativeOnly with get, set
    

type ScrollToFn<'TItemElement> =
    delegate of offset: float * options: ScrollToFnOptions * instance: Virtualizer<'TItemElement> -> unit

type ObserveElementRectFn<'TItemElement> =
    delegate of instance: Virtualizer<'TItemElement> * cb: (Rect -> unit) -> U2<(unit -> unit), unit>

type ObserveElementOffsetFn<'TItemElement> =
    delegate of instance: Virtualizer<'TItemElement> * cb: ObserveOffsetCallback -> U2<unit,(unit -> unit)>

type OnChangeFn<'TItemElement> =
    delegate of instance: Virtualizer<'TItemElement> * sync: bool -> unit

type MeasureElementFn<'TItemElement> =
    delegate of element: 'TItemElement * entry: ResizeObserverEntry option * instance: Virtualizer<'TItemElement> -> float

type ShouldAdjustScrollPositionOnItemSizeChangeFn<'TItemElement> =
    delegate of item: VirtualItem * delta: float * instance: Virtualizer<'TItemElement> -> bool
    
type CalculateRangeFn = delegate of unit -> Range option

type GetVirtualIndexesFn = delegate of unit -> int array

type ResizeItemFn =
    delegate of index: float * size: float -> unit


[<AutoOpen>]
module Extensions =
    [<Erase>]
    type DelegateExtension =
        [<Extension; Emit("$0.updateDeps()")>]
        static member inline updateDeps(this: GetVirtualItemsFn): unit = jsNative
        [<Extension; Emit("$0.updateDeps()")>]
        static member inline updateDeps(this: GetVirtualIndexesFn): unit = jsNative
        [<Extension; Emit("$0.updateDeps()")>]
        static member inline updateDeps(this: CalculateRangeFn): unit = jsNative
        
    
type GetVirtualItemsFn = delegate of unit -> VirtualItem array

type GetOffsetForAlignmentFn =
    delegate of toOffset: float * align: ScrollAlignment * ?itemSize: float -> float

type GetOffsetForIndexFn =
    delegate of index: float * ?align: ScrollAlignment -> U2<float * string, float * ScrollAlignment option>

type ScrollToOffsetFn =
    delegate of toOffset: float * ?arg1: ScrollToOffsetOptions -> unit

type ScrollToIndexFn =
    delegate of index: float * ?arg1: ScrollToIndexOptions -> unit

type ScrollByFn =
    delegate of delta: float * ?arg1: ScrollToOffsetOptions -> unit

type ObserveElementRect =
    delegate of instance: Virtualizer<obj> * cb: (Rect -> unit) -> (unit -> unit) option

type ObserveWindowRect =
    delegate of instance: Virtualizer<obj> * cb: (Rect -> unit) -> (unit -> unit) option

type ObserveElementOffset =
    delegate of instance: Virtualizer<obj> * cb: ObserveOffsetCallback -> (unit -> unit) option

type ObserveWindowOffset =
    delegate of instance: Virtualizer<obj> * cb: ObserveOffsetCallback -> (unit -> unit) option

type MeasureElement<'TItemElement> =
    delegate of element: 'TItemElement * entry: ResizeObserverEntry option * instance: Virtualizer<'TItemElement> -> float

type WindowScroll =
    delegate of offset: float * arg1: ScrollToFnOptions * instance: Virtualizer<obj> -> unit

type ElementScroll =
    delegate of offset: float * arg1: ScrollToFnOptions * instance: Virtualizer<obj> -> unit
