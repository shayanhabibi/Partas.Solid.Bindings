namespace Partas.Solid.TanStack.Virtual
//
// open System.Runtime.CompilerServices
// open Fable.Core
// open Fable.Core.JS
// open Fable.Core.JsInterop
// open Partas.Solid
//
// [<AbstractClass>]
// [<Erase>]
// type Exports =
//     [<Import("createVirtualizer", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member createVirtualizer<'TScrollElement, 'TItemElement when 'TScrollElement :> Element and 'TItemElement :> Element> (options: PartialKeys<VirtualizerOptions<'TScrollElement, 'TItemElement>, Exports.createVirtualizer.options>) : Virtualizer<'TScrollElement, 'TItemElement> = nativeOnly
//     [<Import("createWindowVirtualizer", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member createWindowVirtualizer<'TItemElement when 'TItemElement :> Element> (options: PartialKeys<VirtualizerOptions<Window, 'TItemElement>, Exports.createWindowVirtualizer.options>) : Virtualizer<Window, 'TItemElement> = nativeOnly
//
//
//
// module Exports =
//
//     module createVirtualizer =
//
//         [<RequireQualifiedAccess>]
//         [<StringEnum(CaseRules.None)>]
//         type options =
//             | observeElementRect
//             | observeElementOffset
//             | scrollToFn
//
//     module createWindowVirtualizer =
//
//         [<RequireQualifiedAccess>]
//         [<StringEnum(CaseRules.None)>]
//         type options =
//             | getScrollElement
//             | observeElementRect
//             | observeElementOffset
//             | scrollToFn
//
// module rec Glutinum
//
// open Fable.Core
// open Fable.Core.JsInterop
// open System
//
// [<AbstractClass>]
// [<Erase>]
// type Exports =
//     [<Import("defaultKeyExtractor", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline defaultKeyExtractor: (float -> float) = nativeOnly
//     [<Import("defaultRangeExtractor", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline defaultRangeExtractor: (Range -> ResizeArray<float>) = nativeOnly
//     [<Import("observeElementRect", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline observeElementRect: Exports.observeElementRect = nativeOnly
//     [<Import("observeWindowRect", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline observeWindowRect: Exports.observeWindowRect = nativeOnly
//     [<Import("observeElementOffset", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline observeElementOffset: Exports.observeElementOffset = nativeOnly
//     [<Import("observeWindowOffset", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline observeWindowOffset: Exports.observeWindowOffset = nativeOnly
//     [<Import("measureElement", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline measureElement: Exports.measureElement = nativeOnly
//     [<Import("windowScroll", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline windowScroll: Exports.windowScroll = nativeOnly
//     [<Import("elementScroll", "REPLACE_ME_WITH_MODULE_NAME")>]
//     static member inline elementScroll: Exports.elementScroll = nativeOnly
//     [<Import("Virtualizer", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
//     static member Virtualizer<'TScrollElement, 'TItemElement when 'TScrollElement :> U2<Element, Window> and 'TItemElement :> Element> (opts: VirtualizerOptions<'TScrollElement, 'TItemElement>) : Virtualizer<'TScrollElement, 'TItemElement> = nativeOnly
//
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type ScrollDirection =
//     | forward
//     | backward
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type ScrollAlignment =
//     | start
//     | center
//     | ``end``
//     | auto
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type ScrollBehavior =
//     | auto
//     | smooth
//
// [<AllowNullLiteral>]
// [<Interface>]
// type ScrollToOptions =
//     abstract member align: ScrollAlignment option with get, set
//     abstract member behavior: ScrollBehavior option with get, set
//
// type ScrollToOffsetOptions =
//     ScrollToOptions
//
// type ScrollToIndexOptions =
//     ScrollToOptions
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Range =
//     abstract member startIndex: float with get, set
//     abstract member endIndex: float with get, set
//     abstract member overscan: float with get, set
//     abstract member count: float with get, set
//
// type Key =
//     U2<float, string>
//
// [<AllowNullLiteral>]
// [<Interface>]
// type VirtualItem =
//     abstract member key: Key with get, set
//     abstract member index: float with get, set
//     abstract member start: float with get, set
//     abstract member ``end``: float with get, set
//     abstract member size: float with get, set
//     abstract member lane: float with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Rect =
//     abstract member width: float with get, set
//     abstract member height: float with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type ObserveOffsetCallBack =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: offset: float * isScrolling: bool -> unit
//
// [<AllowNullLiteral>]
// [<Interface>]
// type VirtualizerOptions<'TScrollElement, 'TItemElement when 'TScrollElement :> U2<Element, Window> and 'TItemElement :> Element> =
//     abstract member count: float with get, set
//     abstract member getScrollElement: (unit -> 'TScrollElement option) with get, set
//     abstract member estimateSize: (float -> float) with get, set
//     abstract member scrollToFn: VirtualizerOptions.scrollToFn with get, set
//     abstract member observeElementRect: VirtualizerOptions.observeElementRect with get, set
//     abstract member observeElementOffset: VirtualizerOptions.observeElementOffset with get, set
//     abstract member debug: bool option with get, set
//     abstract member initialRect: Rect option with get, set
//     abstract member onChange: VirtualizerOptions.onChange option with get, set
//     abstract member measureElement: VirtualizerOptions.measureElement<'TItemElement> option with get, set
//     abstract member overscan: float option with get, set
//     abstract member horizontal: bool option with get, set
//     abstract member paddingStart: float option with get, set
//     abstract member paddingEnd: float option with get, set
//     abstract member scrollPaddingStart: float option with get, set
//     abstract member scrollPaddingEnd: float option with get, set
//     abstract member initialOffset: U2<float, (unit -> float)> option with get, set
//     abstract member getItemKey: (float -> Key) option with get, set
//     abstract member rangeExtractor: (Range -> ResizeArray<float>) option with get, set
//     abstract member scrollMargin: float option with get, set
//     abstract member gap: float option with get, set
//     abstract member indexAttribute: string option with get, set
//     abstract member initialMeasurementsCache: ResizeArray<VirtualItem> option with get, set
//     abstract member lanes: float option with get, set
//     abstract member isScrollingResetDelay: float option with get, set
//     abstract member useScrollendEvent: bool option with get, set
//     abstract member enabled: bool option with get, set
//     abstract member isRtl: bool option with get, set
//     abstract member useAnimationFrameWithResizeObserver: bool option with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Virtualizer<'TScrollElement, 'TItemElement when 'TScrollElement :> U2<Element, Window> and 'TItemElement :> Element> =
//     abstract member options: Required<VirtualizerOptions<'TScrollElement, 'TItemElement>> with get, set
//     abstract member scrollElement: 'TScrollElement option with get, set
//     abstract member targetWindow: obj option with get, set
//     abstract member isScrolling: bool with get, set
//     abstract member measurementsCache: ResizeArray<VirtualItem> with get, set
//     abstract member scrollRect: Rect option with get, set
//     abstract member scrollOffset: float option with get, set
//     abstract member scrollDirection: ScrollDirection option with get, set
//     abstract member shouldAdjustScrollPositionOnItemSizeChange: Virtualizer.shouldAdjustScrollPositionOnItemSizeChange option with get, set
//     abstract member elementsCache: Map<Key, 'TItemElement> with get, set
//     abstract member range: Virtualizer.range option with get, set
//     abstract member setOptions: (VirtualizerOptions<'TScrollElement, 'TItemElement> -> unit) with get, set
//     abstract member _didMount: (unit -> (unit -> unit)) with get, set
//     abstract member _willUpdate: (unit -> unit) with get, set
//     abstract member calculateRange: Virtualizer.calculateRange with get, set
//     abstract member getVirtualIndexes: Virtualizer.getVirtualIndexes with get, set
//     abstract member indexFromElement: ('TItemElement -> float) with get, set
//     abstract member resizeItem: Virtualizer.resizeItem with get, set
//     abstract member measureElement: ('TItemElement option -> unit) with get, set
//     abstract member getVirtualItems: Virtualizer.getVirtualItems with get, set
//     abstract member getVirtualItemForOffset: (float -> VirtualItem option) with get, set
//     abstract member getOffsetForAlignment: Virtualizer.getOffsetForAlignment with get, set
//     abstract member getOffsetForIndex: Virtualizer.getOffsetForIndex with get, set
//     abstract member scrollToOffset: Virtualizer.scrollToOffset with get, set
//     abstract member scrollToIndex: Virtualizer.scrollToIndex with get, set
//     abstract member scrollBy: Virtualizer.scrollBy with get, set
//     abstract member getTotalSize: (unit -> float) with get, set
//     abstract member ``measure``: (unit -> unit) with get, set
//
// module VirtualizerOptions =
//
//     type scrollToFn =
//         delegate of offset: float * options: VirtualizerOptions.scrollToFn.options * instance: Virtualizer<'TScrollElement, 'TItemElement> -> unit
//
//     type observeElementRect =
//         delegate of instance: Virtualizer<'TScrollElement, 'TItemElement> * cb: (Rect -> unit) -> U2<unit, (unit -> unit)>
//
//     type observeElementOffset =
//         delegate of instance: Virtualizer<'TScrollElement, 'TItemElement> * cb: ObserveOffsetCallBack -> U2<unit, (unit -> unit)>
//
//     type onChange =
//         delegate of instance: Virtualizer<'TScrollElement, 'TItemElement> * sync: bool -> unit
//
//     type measureElement<'TItemElement when 'TItemElement :> Element> =
//         delegate of element: 'TItemElement * entry: ResizeObserverEntry option * instance: Virtualizer<'TScrollElement, 'TItemElement> -> float
//
//     module scrollToFn =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type options
//             [<ParamObject; Emit("$0")>]
//             (
//                 ?adjustments: float,
//                 ?behavior: ScrollBehavior
//             ) =
//
//             member val adjustments : float option = nativeOnly with get, set
//             member val behavior : ScrollBehavior option = nativeOnly with get, set
//
// module Virtualizer =
//
//     type shouldAdjustScrollPositionOnItemSizeChange =
//         delegate of item: VirtualItem * delta: float * instance: Virtualizer<'TScrollElement, 'TItemElement> -> bool
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type range
//         [<ParamObject; Emit("$0")>]
//         (
//             startIndex: float,
//             endIndex: float
//         ) =
//
//         member val startIndex : float = nativeOnly with get, set
//         member val endIndex : float = nativeOnly with get, set
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type calculateRange
//         [<ParamObject; Emit("$0")>]
//         (
//             updateDeps: unit,
//             ?Invoke: Virtualizer.calculateRange.Invoke
//         ) =
//
//         member val updateDeps : unit = nativeOnly with get, set
//         member val Invoke : Virtualizer.calculateRange.Invoke option = nativeOnly with get, set
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type getVirtualIndexes
//         [<ParamObject; Emit("$0")>]
//         (
//             Invoke: ResizeArray<float>,
//             updateDeps: unit
//         ) =
//
//         member val Invoke : ResizeArray<float> = nativeOnly with get, set
//         member val updateDeps : unit = nativeOnly with get, set
//
//     type resizeItem =
//         delegate of index: float * size: float -> unit
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type getVirtualItems
//         [<ParamObject; Emit("$0")>]
//         (
//             Invoke: ResizeArray<VirtualItem>,
//             updateDeps: unit
//         ) =
//
//         member val Invoke : ResizeArray<VirtualItem> = nativeOnly with get, set
//         member val updateDeps : unit = nativeOnly with get, set
//
//     type getOffsetForAlignment =
//         delegate of toOffset: float * align: ScrollAlignment * ?itemSize: float -> float
//
//     type getOffsetForIndex =
//         delegate of index: float * ?align: ScrollAlignment -> U2<float * string, float * Virtualizer.getOffsetForIndex.U2.Case2> option
//
//     type scrollToOffset =
//         delegate of toOffset: float * ?arg1: ScrollToOffsetOptions -> unit
//
//     type scrollToIndex =
//         delegate of index: float * ?arg1: ScrollToIndexOptions -> unit
//
//     type scrollBy =
//         delegate of delta: float * ?arg1: ScrollToOffsetOptions -> unit
//
//     module calculateRange =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type Invoke
//             [<ParamObject; Emit("$0")>]
//             (
//                 startIndex: float,
//                 endIndex: float
//             ) =
//
//             member val startIndex : float = nativeOnly with get, set
//             member val endIndex : float = nativeOnly with get, set
//
//     module getOffsetForIndex =
//
//         module U2 =
//
//             [<RequireQualifiedAccess>]
//             [<StringEnum(CaseRules.None)>]
//             type Case2 =
//                 | start
//                 | center
//                 | ``end``
//
// module Exports =
//
//     type observeElementRect =
//         delegate of instance: Virtualizer<'T, obj> * cb: (Rect -> unit) -> (unit -> unit) option
//
//     type observeWindowRect =
//         delegate of instance: Virtualizer<Window, obj> * cb: (Rect -> unit) -> (unit -> unit) option
//
//     type observeElementOffset =
//         delegate of instance: Virtualizer<'T, obj> * cb: ObserveOffsetCallBack -> (unit -> unit) option
//
//     type observeWindowOffset =
//         delegate of instance: Virtualizer<Window, obj> * cb: ObserveOffsetCallBack -> (unit -> unit) option
//
//     type measureElement =
//         delegate of element: 'TItemElement * entry: ResizeObserverEntry option * instance: Virtualizer<obj, 'TItemElement> -> float
//
//     type windowScroll =
//         delegate of offset: float * arg1: Exports.windowScroll.arg1 * instance: Virtualizer<'T, obj> -> unit
//
//     type elementScroll =
//         delegate of offset: float * arg1: Exports.elementScroll.arg1 * instance: Virtualizer<'T, obj> -> unit
//
//     module windowScroll =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type arg1
//             [<ParamObject; Emit("$0")>]
//             (
//                 ?adjustments: float,
//                 ?behavior: ScrollBehavior
//             ) =
//
//             member val adjustments : float option = nativeOnly with get, set
//             member val behavior : ScrollBehavior option = nativeOnly with get, set
//
//     module elementScroll =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type arg1
//             [<ParamObject; Emit("$0")>]
//             (
//                 ?adjustments: float,
//                 ?behavior: ScrollBehavior
//             ) =
//
//             member val adjustments : float option = nativeOnly with get, set
//             member val behavior : ScrollBehavior option = nativeOnly with get, set
