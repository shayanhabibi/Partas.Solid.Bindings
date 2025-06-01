namespace Partas.Solid.NeoDrag

open Fable.Core
open Partas.Solid
open Browser.Types
open Fable.Core.JsInterop
open Fable.Core.JS
open Partas.Solid.Experimental.U

[<Interface; AllowNullLiteral>]
type DragEventData =
    /// How much the element moved from its original position horizontally
    abstract member offsetX: int with get
    /// How much the element moved from its original position vertically
    abstract member offsetY: int with get
    /// The node on which the draggable is applied
    abstract member rootNode: HTMLElement with get
    /// The element being dragged
    abstract member currentNode: HTMLElement with get
    /// The pointer event that triggered the drag
    abstract member event: PointerEvent with get

[<JS.Pojo>]
type DragBoundsCoords(
        ?left: int,
        ?right: int,
        ?top: int,
        ?bottom: int
    ) =
    member val left: int = undefined with get,set
    member val right: int = undefined with get,set
    member val top: int = undefined with get,set
    member val bottom: int = undefined with get,set

[<JS.Pojo>]
type RecomputeBounds(
        ?dragStart: bool,
        ?drag: bool,
        ?dragEnd: bool
    ) =
    member val dragStart: bool = undefined with get,set
    member val drag: bool = undefined with get,set
    member val dragEnd: bool = undefined with get,set

[<JS.Pojo>]
type Threshold(?distance: int, ?delay: int) =
    member val distance: int = undefined with get,set
    member val delay: int = undefined with get,set

[<JS.Pojo>]
type Position(?x: int, ?y: int) =
    member val x: int = undefined with get,set
    member val y: int = undefined with get,set

[<Interface; AllowNullLiteral>]
type TransformData =
    abstract member offsetX: int with get
    abstract member offsetY: int with get
    abstract member rootNode: HTMLElement with get

[<JS.Pojo>]
type DraggableOptions(
        ?axis: NeoDragAxis,
        ?bounds: U4<Element, NeoDragBounds, string, DragBoundsCoords>,
        ?recomputeBounds: RecomputeBounds
        ,?grid: int[]
        ,?threshold: Threshold
        ,?defaultPosition: Position
        ,?position: Position
        ,?transform: TransformData -> obj
        ,?applyUserSelectHack: bool
        ,?ignoreMultiTouch: bool
        ,?disabled: bool
        ,?handle: U3<string, HTMLElement, HTMLElement[]>
        ,?cancel: U3<string, HTMLElement, HTMLElement[]>
        ,?defaultClass: string
        ,?defaultClassDragging: string
        ,?defaultClassDragged: string
        ,?onDragStart: DragEventData -> unit
        ,?onDragEnd: DragEventData -> unit
        ,?onDrag: DragEventData -> unit
    ) =
    member val axis: NeoDragAxis = undefined with get,set
    member val bounds: U4<Element, NeoDragBounds, string, DragBoundsCoords> = undefined with get,set
    member val recomputeBounds: RecomputeBounds = undefined with get,set
    /// int * int
    member val grid: int[] = undefined with get,set
    member val threshold: Threshold = undefined with get,set
    member val defaultPosition: Position = undefined with get,set
    member val position: Position = undefined with get,set
    member val transform: TransformData -> obj = undefined with get,set
    member val applyUserSelectHack: bool = undefined with get,set
    member val ignoreMultiTouch: bool = undefined with get,set
    member val disabled: bool = undefined with get,set
    member val handle: U3<string, HTMLElement, HTMLElement[]> = undefined with get,set
    member val cancel: U3<string, HTMLElement, HTMLElement[]> = undefined with get,set
    member val defaultClass: string = undefined with get,set
    member val defaultClassDragging: string = undefined with get,set
    member val defaultClassDragged: string = undefined with get,set
    member val onDragStart: DragEventData -> unit = undefined with get,set
    member val onDragEnd: DragEventData -> unit = undefined with get,set
    member val onDrag: DragEventData -> unit = undefined with get,set

[<Interface; AllowNullLiteral>]
type Draggable =
    abstract member draggable: string with get

[<Erase; AutoOpen>]
type Exports =
    [<ImportMember(path)>]
    static member createDraggable(?options: DraggableOptions): Draggable = jsNative