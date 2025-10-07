namespace rec Partas.Solid.TanStack.Virtual

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
    static member inline observeElementRect: Exports.observeElementRect = nativeOnly
    [<Import("observeWindowRect", "@tanstack/solid-virtual")>]
    static member inline observeWindowRect: Exports.observeWindowRect = nativeOnly
    [<Import("observeElementOffset", "@tanstack/solid-virtual")>]
    static member inline observeElementOffset: Exports.observeElementOffset = nativeOnly
    [<Import("observeWindowOffset", "@tanstack/solid-virtual")>]
    static member inline observeWindowOffset: Exports.observeWindowOffset = nativeOnly
    [<Import("measureElement", "@tanstack/solid-virtual")>]
    static member inline measureElement: Exports.measureElement<'TItemElement> = nativeOnly
    [<Import("windowScroll", "@tanstack/solid-virtual")>]
    static member inline windowScroll: Exports.windowScroll = nativeOnly
    [<Import("elementScroll", "@tanstack/solid-virtual")>]
    static member inline elementScroll: Exports.elementScroll = nativeOnly

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
        ?scrollToFn: VirtualizerOptions.scrollToFn<'TItemElement>,
        ?observeElementRect: VirtualizerOptions.observeElementRect<'TItemElement>,
        ?observeElementOffset: VirtualizerOptions.observeElementOffset<'TItemElement>,
        ?debug: bool,
        ?initialRect: Rect,
        ?onChange: VirtualizerOptions.onChange<'TItemElement>,
        ?measureElement: VirtualizerOptions.measureElement<'TItemElement>,
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
    member val scrollToFn: VirtualizerOptions.scrollToFn<'TItemElement> = JS.undefined with get , set

    [<Erase>]
    member val observeElementRect: VirtualizerOptions.observeElementRect<'TItemElement> = JS.undefined with get , set

    [<Erase>]
    member val observeElementOffset: VirtualizerOptions.observeElementOffset<'TItemElement> = JS.undefined with get , set

    [<Erase>]
    member val debug: bool option = JS.undefined with get , set

    [<Erase>]
    member val initialRect: Rect option = JS.undefined with get , set

    [<Erase>]
    member val onChange: VirtualizerOptions.onChange<'TItemElement> option = JS.undefined with get , set

    [<Erase>]
    member val measureElement: VirtualizerOptions.measureElement<'TItemElement> option = JS.undefined with get , set

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
    abstract member shouldAdjustScrollPositionOnItemSizeChange: Virtualizer.shouldAdjustScrollPositionOnItemSizeChange<'TItemElement> option with get, set
    abstract member elementsCache: Map<Key, 'TItemElement> with get, set
    abstract member range: Virtualizer.range option with get, set
    abstract member setOptions: (VirtualizerOptions<'TItemElement> -> unit) with get, set
    abstract member _didMount: (unit -> (unit -> unit)) with get, set
    abstract member _willUpdate: (unit -> unit) with get, set
    abstract member calculateRange: Virtualizer.calculateRange with get, set
    abstract member getVirtualIndexes: Virtualizer.getVirtualIndexes with get, set
    abstract member indexFromElement: ('TItemElement -> float) with get, set
    abstract member resizeItem: Virtualizer.resizeItem with get, set
    abstract member measureElement: ('TItemElement option -> unit) with get, set
    abstract member getVirtualItems: Virtualizer.getVirtualItems with get, set
    abstract member getVirtualItemForOffset: (float -> VirtualItem option) with get, set
    abstract member getOffsetForAlignment: Virtualizer.getOffsetForAlignment with get, set
    abstract member getOffsetForIndex: Virtualizer.getOffsetForIndex with get, set
    abstract member scrollToOffset: Virtualizer.scrollToOffset with get, set
    abstract member scrollToIndex: Virtualizer.scrollToIndex with get, set
    abstract member scrollBy: Virtualizer.scrollBy with get, set
    abstract member getTotalSize: (unit -> float) with get, set
    abstract member ``measure``: (unit -> unit) with get, set
    
type Exports with
    [<ImportMember("@tanstack/solid-virtual")>]
    static member createVirtualizer<'TItemElement>(
            ?count: float,
            ?getScrollElement: (unit -> HtmlElement option),
            ?estimateSize: (float -> float),
            ?scrollToFn: VirtualizerOptions.scrollToFn<'TItemElement>,
            ?observeElementRect: VirtualizerOptions.observeElementRect<'TItemElement>,
            ?observeElementOffset: VirtualizerOptions.observeElementOffset<'TItemElement>,
            ?debug: bool,
            ?initialRect: Rect,
            ?onChange: VirtualizerOptions.onChange<'TItemElement>,
            ?measureElement: VirtualizerOptions.measureElement<'TItemElement>,
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
    static member createWindowVirtualizer<'TItemElement>(
            ?count: float,
            ?getScrollElement: unit -> HtmlElement option,
            ?estimateSize: float -> float,
            ?scrollToFn: VirtualizerOptions.scrollToFn<'TItemElement>,
            ?observeElementRect: VirtualizerOptions.observeElementRect<'TItemElement>,
            ?observeElementOffset: VirtualizerOptions.observeElementOffset<'TItemElement>,
            ?debug: bool,
            ?initialRect: Rect,
            ?onChange: VirtualizerOptions.onChange<'TItemElement>,
            ?measureElement: VirtualizerOptions.measureElement<'TItemElement>,
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

[<JS.Pojo>]
type ScrollToFnOptions(
    ?adjustments: float,
    ?behavior: ScrollBehavior
    ) =
    member val adjustments : float option = nativeOnly with get, set
    member val behavior : ScrollBehavior option = nativeOnly with get, set
    
module VirtualizerOptions =

    type scrollToFn<'TItemElement> =
        delegate of offset: float * options: ScrollToFnOptions * instance: Virtualizer<'TItemElement> -> unit

    type observeElementRect<'TItemElement> =
        delegate of instance: Virtualizer<'TItemElement> * cb: (Rect -> unit) -> U2<(unit -> unit), unit>

    type observeElementOffset<'TItemElement> =
        delegate of instance: Virtualizer<'TItemElement> * cb: ObserveOffsetCallback -> U2<unit,(unit -> unit)>

    type onChange<'TItemElement> =
        delegate of instance: Virtualizer<'TItemElement> * sync: bool -> unit

    type measureElement<'TItemElement> =
        delegate of element: 'TItemElement * entry: ResizeObserverEntry option * instance: Virtualizer<'TItemElement> -> float

module Virtualizer =

    type shouldAdjustScrollPositionOnItemSizeChange<'TItemElement> =
        delegate of item: VirtualItem * delta: float * instance: Virtualizer<'TItemElement> -> bool

    [<Global>]
    [<AllowNullLiteral>]
    type range
        [<ParamObject; Emit("$0")>]
        (
            startIndex: float,
            endIndex: float
        ) =

        member val startIndex : float = nativeOnly with get, set
        member val endIndex : float = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type calculateRange
        [<ParamObject; Emit("$0")>]
        (
            updateDeps: unit,
            ?Invoke: Virtualizer.calculateRange.Invoke
        ) =

        member val updateDeps : unit = nativeOnly
        member val Invoke : Virtualizer.calculateRange.Invoke option = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type getVirtualIndexes
        [<ParamObject; Emit("$0")>]
        (
            Invoke: ResizeArray<float>,
            updateDeps: unit
        ) =

        member val Invoke : ResizeArray<float> = nativeOnly
        member val updateDeps : unit = nativeOnly

    type resizeItem =
        delegate of index: float * size: float -> unit

    [<Global>]
    [<AllowNullLiteral>]
    type getVirtualItems
        [<ParamObject; Emit("$0")>]
        (
            Invoke: ResizeArray<VirtualItem>,
            updateDeps: unit
        ) =

        member val Invoke : ResizeArray<VirtualItem> = nativeOnly
        member val updateDeps : unit = nativeOnly

    type getOffsetForAlignment =
        delegate of toOffset: float * align: ScrollAlignment * ?itemSize: float -> float

    type getOffsetForIndex =
        delegate of index: float * ?align: ScrollAlignment -> U2<float * string, float * Virtualizer.getOffsetForIndex.U2.Case2> option

    type scrollToOffset =
        delegate of toOffset: float * ?arg1: ScrollToOffsetOptions -> unit

    type scrollToIndex =
        delegate of index: float * ?arg1: ScrollToIndexOptions -> unit

    type scrollBy =
        delegate of delta: float * ?arg1: ScrollToOffsetOptions -> unit

    module calculateRange =

        [<Global>]
        [<AllowNullLiteral>]
        type Invoke
            [<ParamObject; Emit("$0")>]
            (
                startIndex: float,
                endIndex: float
            ) =

            member val startIndex : float = nativeOnly with get, set
            member val endIndex : float = nativeOnly with get, set

    module getOffsetForIndex =

        module U2 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type Case2 =
                | start
                | center
                | ``end``

module Exports =

    type observeElementRect =
        delegate of instance: Virtualizer<obj> * cb: (Rect -> unit) -> (unit -> unit) option

    type observeWindowRect =
        delegate of instance: Virtualizer<obj> * cb: (Rect -> unit) -> (unit -> unit) option

    type observeElementOffset =
        delegate of instance: Virtualizer<obj> * cb: ObserveOffsetCallback -> (unit -> unit) option

    type observeWindowOffset =
        delegate of instance: Virtualizer<obj> * cb: ObserveOffsetCallback -> (unit -> unit) option

    type measureElement<'TItemElement> =
        delegate of element: 'TItemElement * entry: ResizeObserverEntry option * instance: Virtualizer<'TItemElement> -> float

    type windowScroll =
        delegate of offset: float * arg1: Exports.windowScroll.arg1 * instance: Virtualizer<obj> -> unit

    type elementScroll =
        delegate of offset: float * arg1: Exports.elementScroll.arg1 * instance: Virtualizer<obj> -> unit

    module windowScroll =

        [<Global>]
        [<AllowNullLiteral>]
        type arg1
            [<ParamObject; Emit("$0")>]
            (
                ?adjustments: float,
                ?behavior: ScrollBehavior
            ) =

            member val adjustments : float option = nativeOnly with get, set
            member val behavior : ScrollBehavior option = nativeOnly with get, set

    module elementScroll =

        [<Global>]
        [<AllowNullLiteral>]
        type arg1
            [<ParamObject; Emit("$0")>]
            (
                ?adjustments: float,
                ?behavior: ScrollBehavior
            ) =

            member val adjustments : float option = nativeOnly with get, set
            member val behavior : ScrollBehavior option = nativeOnly with get, set
