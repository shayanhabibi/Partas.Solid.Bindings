namespace rec Partas.Solid.DndKit

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Partas.Solid
open Browser.Types
open DragDropEvents

type Effect = unit -> (unit -> unit) option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Align =
    | center
    | start
    | ``end``

[<AllowNullLiteral>]
[<Interface>]
type Alignment =
    abstract member x: Align with get, set
    abstract member y: Align with get, set

[<AllowNullLiteral>]
[<Interface>]
type Input2<'T> =
    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    abstract member id: string with get, set
    /// <summary>
    /// Optional data associated with the entity.
    /// </summary>
    abstract member data: 'T option with get, set
    /// <summary>
    /// Whether the entity should initially be disabled.
    /// </summary>
    abstract member disabled: bool option with get, set
    /// <summary>
    /// Whether the entity should be automatically registered with the manager when it is created.
    /// </summary>
    abstract member register: bool option with get, set
    /// <summary>
    /// An array of effects that are set up when the entity is registered and cleaned up when it is unregistered.
    /// </summary>
    abstract member effects: unit -> ResizeArray<Effect>

// type Sensors = obj[]
// type Modifiers = obj[]


[<AllowNullLiteral>]
[<Interface>]
type Input1<'T> =
    inherit Input2<'T>
    // abstract member sensors: Sensors option with get, set
    // abstract member modifiers: Modifiers option with get, set
    abstract member ``type``: string option with get, set
    abstract member sensors: obj[] option with get, set
    abstract member modifiers: obj[] option with get, set
    abstract member alignment: Alignment option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Entity<'T> =
    /// <summary>
    /// The manager that controls the drag and drop operations.
    /// </summary>
    abstract member manager: DragDropManager option with get, set
    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    abstract member id: string with get, set
    /// <summary>
    /// The data associated with the entity.
    /// </summary>
    abstract member data: 'T with get, set
    /// <summary>
    /// A boolean indicating whether the entity is disabled.
    /// </summary>
    abstract member disabled: bool with get, set
    /// <summary>
    /// An array of effects that are applied to the entity.
    /// </summary>
    abstract member effects: (unit -> ResizeArray<Effect>) with get, set
    abstract member register: unit -> U2<obj, unit>
    abstract member unregister: unit -> unit
    abstract member destroy: unit -> unit

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DraggableStatus =
    | idle
    | dragging
    | dropping

[<AllowNullLiteral>]
[<Interface>]
type Draggable =
    inherit Entity<Draggable>
    abstract member ``type``: obj option with get, set
    abstract member sensors: obj option with get, set
    abstract member modifiers: obj option with get, set
    abstract member alignment: obj option with get, set
    abstract member status: DraggableStatus with get, set
    /// <summary>
    /// A boolean indicating whether the draggable item is being dropped.
    /// </summary>
    abstract member isDropping: bool with get
    /// <summary>
    /// A boolean indicating whether the draggable item is being dropped.
    /// </summary>
    abstract member isDragging: bool with get
    /// <summary>
    /// A boolean indicating whether the draggable item is the source of a drag operation.
    /// </summary>
    abstract member isDragSource: bool with get
[<AllowNullLiteral>]
[<Interface>]
type Droppable =
    inherit Entity<Droppable>
    /// <summary>
    /// An array of types that are compatible with the droppable.
    /// </summary>
    abstract member accept: U3<obj, ResizeArray<obj>, (Draggable -> bool)> option with get, set
    /// <summary>
    /// The type of the droppable.
    /// </summary>
    abstract member ``type``: obj option with get, set
    abstract member accepts: draggable: Draggable -> bool
    abstract member collisionDetector: obj with get, set
    abstract member collisionPriority: U2<obj, float> option with get, set
    abstract member shape: obj option with get, set
    abstract member isDropTarget: bool with get
    abstract member proxy: HtmlElement option with get, set
    abstract member element: HtmlElement option with get, set
    abstract member refreshShape: (unit -> obj option) with get, set

[<AllowNullLiteral>]
[<Interface>]
type DragDropManager =
    // abstract member actions: DragActions<'T, 'U, DragDropManager> with get, set
    // abstract member collisionObserver: CollisionObserver with get, set
    // abstract member dragOperation: DragOperation with get, set
    // abstract member monitor: DragDropMonitor<'T, 'U, DragDropManager> with get, set
    // abstract member registry: DragDropRegistry<'T, 'U, DragDropManager> with get, set
    // abstract member renderer: Renderer with get, set
    // abstract member plugins: ResizeArray<Plugin<obj>> with get, set
    // abstract member modifiers: ResizeArray<Modifier<obj>> with get, set
    // abstract member sensors: ResizeArray<Sensor<obj>> with get, set
    abstract member destroy: (unit -> unit) with get, set

[<AllowNullLiteral>]
[<Interface>]
type DragDropEvents =
    abstract member collision: event: Preventable<DragDropEvents.collision.event> * manager: 'V -> unit
    abstract member beforedragstart: event: Preventable<DragDropEvents.beforedragstart.event> * manager: 'V -> unit
    abstract member dragstart: event: DragDropEvents.dragstart.event * manager: 'V -> unit
    abstract member dragmove: event: Preventable<DragDropEvents.dragmove.event> * manager: 'V -> unit
    abstract member dragover: event: Preventable<DragDropEvents.dragover.event> * manager: 'V -> unit
    abstract member dragend: event: DragDropEvents.dragend.event * manager: 'V -> unit

[<AllowNullLiteral>]
[<Interface>]
type Preventable<'T> =
    [<Emit("$0")>]
    abstract member data: 'T with get
    abstract member cancelable: bool with get, set
    abstract member defaultPrevented: bool with get, set
    abstract member preventDefault: unit -> unit

module DragDropEvents =

    module collision =

        [<Interface>]
        [<AllowNullLiteral>]
        type event =
            abstract member collisions : Collisions with get, set

    module beforedragstart =

        [<Interface>]
        [<AllowNullLiteral>]
        type event =
            abstract member operation : DragOperation with get, set
            abstract member nativeEvent : Event option with get, set

    module dragstart =

        [<Global>]
        [<AllowNullLiteral>]
        type event =
            abstract member cancelable : bool with get, set
            abstract member operation : DragOperation with get, set
            abstract member nativeEvent : Event option with get, set

    module dragmove =

        [<Interface>]
        [<AllowNullLiteral>]
        type event =
            abstract member operation : DragOperation with get, set
            abstract member ``to`` : Coordinates option with get, set
            abstract member by : Coordinates option with get, set
            abstract member nativeEvent : Event option with get, set

    module dragover =

        [<Interface>]
        [<AllowNullLiteral>]
        type event =
            abstract member operation : DragOperation with get, set

    module dragend =
        [<Interface>]
        [<AllowNullLiteral>]
        type event  =
            abstract member operation : DragOperation with get, set
            abstract member canceled : bool with get, set
            abstract suspend: unit -> DragDropEvents.dragend.event.suspend
            abstract member nativeEvent : Event option with get, set

        module event =

            [<Interface>]
            [<AllowNullLiteral>]
            type suspend =
                abstract member resume : unit -> unit
                abstract member abort : unit -> unit


[<AllowNullLiteral>]
[<Interface>]
type DragOperation =
    abstract member activatorEvent: Event option with get, set
    abstract member canceled: bool with get, set
    abstract member position: Position with get, set
    abstract member transform: Coordinates with get, set
    abstract member status: DragOperation.status with get, set
    abstract member shape: DragOperation.shape option with get, set
    abstract member source: Draggable option with get, set
    abstract member target: Droppable option with get, set
    abstract member data: obj option with get, set

module DragOperation =

    [<Global>]
    [<AllowNullLiteral>]
    type status
        [<ParamObject; Emit("$0")>]
        (
            current: Status,
            initialized: bool,
            initializing: bool,
            dragging: bool,
            dragended: bool,
            dropped: bool,
            idle: bool
        ) =

        member val current : Status = nativeOnly with get, set
        member val initialized : bool = nativeOnly with get, set
        member val initializing : bool = nativeOnly with get, set
        member val dragging : bool = nativeOnly with get, set
        member val dragended : bool = nativeOnly with get, set
        member val dropped : bool = nativeOnly with get, set
        member val idle : bool = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type shape
        [<ParamObject; Emit("$0")>]
        (
            initial: Shape,
            current: Shape
        ) =

        member val initial : Shape = nativeOnly with get, set
        member val current : Shape = nativeOnly with get, set


type CollisionPriority =
    | Lowest = 0
    | Low = 1
    | Normal = 2
    | High = 3
    | Highest = 4

type CollisionType =
    | Collision = 0
    | ShapeIntersection = 1
    | PointerIntersection = 2

[<AllowNullLiteral>]
[<Interface>]
type Collision =
    abstract member id: string with get, set
    abstract member priority: U2<CollisionPriority, float> with get, set
    abstract member ``type``: CollisionType with get, set
    abstract member value: float with get, set

type Collisions =
    ResizeArray<Collision>
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Status =
    | [<CompiledName("idle")>] Idle
    | [<CompiledName("initializing")>] Initializing
    | [<CompiledName("dragging")>] Dragging
    | [<CompiledName("dropped")>] Dropped

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Axis =
    | [<CompiledName("x")>] Horizontal
    | [<CompiledName("y")>] Vertical

[<AllowNullLiteral>]
[<Interface>]
type Coordinates =
    [<EmitIndexer>]
    abstract member Item: key: Axis -> float with get, set

[<AllowNullLiteral>]
[<Interface>]
type BoundingRectangle =
    abstract member width: float with get, set
    abstract member height: float with get, set
    abstract member left: float with get, set
    abstract member right: float with get, set
    abstract member top: float with get, set
    abstract member bottom: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type Point =
    inherit Coordinates
    abstract member x: float with get, set
    abstract member y: float with get, set
    static member inline delta (a: Point, b: Point): Point =
        emitJsExpr (a, b) $$"""
import { Point } from "REPLACE_ME_WITH_MODULE_NAME";
Point.delta($0, $1)"""
    static member inline distance (a: Point, b: Point): float =
        emitJsExpr (a, b) $$"""
import { Point } from "REPLACE_ME_WITH_MODULE_NAME";
Point.distance($0, $1)"""
    static member inline equals (a: Point, b: Point): bool =
        emitJsExpr (a, b) $$"""
import { Point } from "REPLACE_ME_WITH_MODULE_NAME";
Point.equals($0, $1)"""
    static member inline from (arg0: Coordinates): Point =
        emitJsExpr (arg0) $$"""
import { Point } from "REPLACE_ME_WITH_MODULE_NAME";
Point.from($0)"""

[<AllowNullLiteral>]
[<Interface>]
type Shape =
    /// <summary>
    /// Get the bounding rectangle of the 2D shape.
    /// </summary>
    /// <returns>
    /// The bounding rectangle of the shape.
    /// </returns>
    abstract member boundingRectangle: BoundingRectangle with get
    /// <summary>
    /// Get the center point of the 2D shape.
    /// </summary>
    /// <returns>
    /// The center point of the shape.
    /// </returns>
    abstract member center: Point with get
    /// <summary>
    /// Get the total space taken up by the 2D shape.
    /// </summary>
    /// <returns>
    /// The area of the shape.
    /// </returns>
    abstract member area: float with get
    /// <summary>
    /// Get the scale transformation of the shape on the 2D plane.
    /// </summary>
    /// <returns>
    /// The scale of the shape.
    /// </returns>
    abstract member scale: Shape.scale with get
    /// <summary>
    /// Get the inverse scale transformation of the shape on the 2D plane.
    /// </summary>
    /// <returns>
    /// The inverse scale of the shape.
    /// </returns>
    abstract member inverseScale: Shape.inverseScale with get
    /// <summary>
    /// Get the aspect ratio of the 2D shape.
    /// </summary>
    /// <returns>
    /// The aspect ratio of the shape.
    /// </returns>
    abstract member aspectRatio: float with get
    abstract member equals: shape: Shape -> bool
    abstract member intersectionArea: shape: Shape -> float
    abstract member containsPoint: point: Point -> bool

[<AllowNullLiteral>]
[<Interface>]
type Rectangle =
    inherit Shape
    abstract member left: float with get, set
    abstract member top: float with get, set
    abstract member width: float with get, set
    abstract member height: float with get, set
    /// <summary>
    /// Get the scale transformation of the shape on the 2D plane.
    /// </summary>
    abstract member scale: Rectangle.scale with get, set
    /// <summary>
    /// Get the inverse scale transformation of the shape on the 2D plane.
    /// </summary>
    abstract member inverseScale: Rectangle.inverseScale with get
    abstract member translate: x: float * y: float -> Rectangle
    /// <summary>
    /// Get the bounding rectangle of the 2D shape.
    /// </summary>
    abstract member boundingRectangle: BoundingRectangle with get
    /// <summary>
    /// Get the center point of the 2D shape.
    /// </summary>
    abstract member center: Point with get
    /// <summary>
    /// Get the total space taken up by the 2D shape.
    /// </summary>
    abstract member area: float with get
    abstract member equals: shape: Shape -> bool
    abstract member containsPoint: point: Point -> bool
    abstract member intersectionArea: shape: Shape -> float
    abstract member intersectionRatio: shape: Shape -> float
    abstract member bottom: float with get
    abstract member right: float with get
    /// <summary>
    /// Get the aspect ratio of the 2D shape.
    /// </summary>
    abstract member aspectRatio: float with get
    abstract member corners: ResizeArray<Rectangle.corners> with get
    static member inline from (arg0: BoundingRectangle): Rectangle =
        emitJsExpr (arg0) $$"""
import { Rectangle } from "REPLACE_ME_WITH_MODULE_NAME";
Rectangle.from($0)"""
    static member inline delta (a: BoundingRectangle, b: BoundingRectangle, ?alignment: Alignment): Point =
        emitJsExpr (a, b, alignment) $$"""
import { Rectangle } from "REPLACE_ME_WITH_MODULE_NAME";
Rectangle.delta($0, $1, $2)"""
    static member inline intersectionRatio (a: BoundingRectangle, b: BoundingRectangle): float =
        emitJsExpr (a, b) $$"""
import { Rectangle } from "REPLACE_ME_WITH_MODULE_NAME";
Rectangle.intersectionRatio($0, $1)"""

[<AllowNullLiteral>]
[<Interface>]
type Position =
    abstract member velocity: Point with get, set
    abstract member initial: Point with get, set
    abstract member previous: Point with get, set
    abstract member current: Point with get, set
    abstract member delta: Point with get
    abstract member direction: Position.direction with get
    abstract member reset: coordinates: Coordinates -> unit
    abstract member update: coordinates: Coordinates -> unit


module Shape =

    [<Global>]
    [<AllowNullLiteral>]
    type scale
        [<ParamObject; Emit("$0")>]
        (
            x: float,
            y: float
        ) =

        member val x : float = nativeOnly with get, set
        member val y : float = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type inverseScale
        [<ParamObject; Emit("$0")>]
        (
            x: float,
            y: float
        ) =

        member val x : float = nativeOnly with get, set
        member val y : float = nativeOnly with get, set

module Rectangle =

    [<Global>]
    [<AllowNullLiteral>]
    type scale
        [<ParamObject; Emit("$0")>]
        (
            x: float,
            y: float
        ) =

        member val x : float = nativeOnly with get, set
        member val y : float = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type inverseScale
        [<ParamObject; Emit("$0")>]
        (
            x: float,
            y: float
        ) =

        member val x : float = nativeOnly with get, set
        member val y : float = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type corners
        [<ParamObject; Emit("$0")>]
        (
            x: float,
            y: float
        ) =

        member val x : float = nativeOnly with get, set
        member val y : float = nativeOnly with get, set

module Position =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type direction =
        | right
        | left
        | down
        | up

[<Import("DragDropProvider", "REPLACE_ME_WITH_MODULE_NAME")>]
type DragDropProvider() =
    interface HtmlElement
    interface HtmlContainer
    [<DefaultValue>]
    val mutable manager: DragDropManager
    [<DefaultValue>]
    val mutable onBeforeDragStart: beforedragstart.event
    [<DefaultValue>]
    val mutable onCollision: collision.event
    [<DefaultValue>]
    val mutable onDragStart: dragstart.event
    [<DefaultValue>]
    val mutable onDragMove: dragmove.event
    [<DefaultValue>]
    val mutable onDropOver: dragover.event
    [<DefaultValue>]
    val mutable onDragEnd: dragend.event

[<Import("DragOverlay", "REPLACE_ME_WITH_MODULE_NAME")>]
type DragOverlay() =
    interface RegularNode
    interface Polymorph
    [<DefaultValue>]
    val mutable tag: TagValue

[<Global>]
[<AllowNullLiteral>]
type UseDraggable
    [<ParamObject; Emit("$0")>]
    (
        draggable: Draggable,
        isDragging: (unit -> bool),
        isDropping: (unit -> bool),
        isDragSource: (unit -> bool),
        handleRef: obj,
        ref: obj
    ) =
    member val draggable : Draggable = nativeOnly with get, set
    member val isDragging : (unit -> bool) = nativeOnly with get, set
    member val isDropping : (unit -> bool) = nativeOnly with get, set
    member val isDragSource : (unit -> bool) = nativeOnly with get, set
    member val handleRef : Setter<HtmlElement> = nativeOnly with get, set
    member val ref : Setter<HtmlElement> = nativeOnly with get, set
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FeedbackType =
    | ``default``
    | move
    | clone
    | none

[<AllowNullLiteral>]
[<Interface>]
type UseDraggableInput<'T> =
    inherit Input1<'T>
    abstract member handle: Element option with get, set
    abstract member element: Element option with get, set
    abstract member feedback: FeedbackType option with get, set
    abstract member sensors: obj[] option with get, set

[<AbstractClass>]
[<Erase>]
type Exports =
    [<Import("defaultManager", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member inline defaultManager: DragDropManager = nativeOnly
    [<Import("DragDropContext", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member inline DragDropContext: Context<DragDropManager> = nativeOnly
    /// <summary>
    /// Returns true if a set of relative coordinates exceeds a given distance.
    /// </summary>
    [<Import("exceedsDistance", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member exceedsDistance (arg0: Coordinates, distance: obj) : bool = nativeOnly
    /// <param name="Coordinate">
    /// of the point on the horizontal axis
    /// </param>
    /// <param name="Coordinate">
    /// of the point on the vertical axis
    /// </param>
    [<Import("Point", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member Point (x: float, y: float) : Point = nativeOnly
    [<Import("Shape", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member Shape () : Shape = nativeOnly
    [<Import("Rectangle", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member Rectangle (left: float, top: float, width: float, height: float) : Rectangle = nativeOnly
    [<Import("Position", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member Position (initialValue: Coordinates) : Position = nativeOnly
    [<Import("useDragDropManager", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member useDragDropManager () : DragDropManager option = nativeOnly
    /// <summary>
    /// Hook to monitor drag and drop events anywhere within a DragDropProvider
    /// </summary>
    /// <param name="handlers">
    /// Object containing event handlers for drag and drop events
    /// </param>
    [<Import("useDragDropMonitor", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member useDragDropMonitor(handlers: obj) : unit = nativeOnly
    [<Import("useDraggable", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member useDraggable<'T> (input: UseDraggableInput<'T>) : UseDraggable = nativeOnly
