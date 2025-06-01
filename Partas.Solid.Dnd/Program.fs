module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System
open Partas.Solid
open Browser.Types
//
// [<AbstractClass>]
// [<Erase>]
// type Exports =
//     [<Import("Layout", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
//     static member Layout (rect: Exports.Layout.rect) : Layout = nativeOnly
//
//
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type CollisionDetector =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: draggable: Draggable1 * droppables: ResizeArray<Droppable1> * context: CollisionDetector.context -> Droppable1 option
//
//
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Point =
//     abstract member x: float with get, set
//     abstract member y: float with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Transform =
//     abstract member x: float with get, set
//     abstract member y: float with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Layout =
//     abstract member x: float with get, set
//     abstract member y: float with get, set
//     abstract member width: float with get, set
//     abstract member height: float with get, set
//     abstract member rect: Layout.rect with get
//     abstract member left: float with get
//     abstract member top: float with get
//     abstract member right: float with get
//     abstract member bottom: float with get
//     abstract member center: Point with get
//     abstract member corners: Layout.corners with get
//
// type Id =
//     U2<string, float>
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Coordinates =
//     abstract member x: float with get, set
//     abstract member y: float with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type SensorActivator<'K> =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: event: 'K * draggableId: Id -> unit
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Sensor =
//     abstract member id: Id with get, set
//     abstract member activators: Sensor.activators with get, set
//     abstract member coordinates: Sensor.coordinates with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type TransformerCallback =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: transform: Transform -> Transform
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Transformer =
//     abstract member id: Id with get, set
//     abstract member order: float with get, set
//     abstract member callback: TransformerCallback with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Item =
//     abstract member id: Id with get, set
//     abstract member node: HTMLElement with get, set
//     abstract member layout: Layout with get, set
//     abstract member data: Item.data with get, set
//     abstract member transformers: Item.transformers with get, set
//     abstract member transform: Transform with get
//     abstract member transformed: Layout with get
//     abstract member _pendingCleanup: bool option with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Draggable1 =
//     inherit Item
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Droppable1 =
//     inherit Item
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Overlay =
//     inherit Item
//
// [<AllowNullLiteral>]
// [<Interface>]
// type DragEvent =
//     abstract member draggable: Draggable1 with get, set
//     abstract member droppable: Droppable1 option with get, set
//     abstract member overlay: Overlay option with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type DragDropState =
//     abstract member draggables: DragDropState.draggables with get, set
//     abstract member droppables: DragDropState.droppables with get, set
//     abstract member sensors: DragDropState.sensors with get, set
//     abstract member active: DragDropState.active with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type DragDropActions =
//     abstract member addTransformer: ``type``: DragDropActions.addTransformer.``type`` * id: Id * transformer: Transformer -> unit
//     abstract member removeTransformer: ``type``: DragDropActions.removeTransformer.``type`` * id: Id * transformerId: Id -> unit
//     abstract member addDraggable: draggable: DragDropActions.addDraggable.draggable -> unit
//     abstract member removeDraggable: id: Id -> unit
//     abstract member addDroppable: droppable: DragDropActions.addDroppable.droppable -> unit
//     abstract member removeDroppable: id: Id -> unit
//     abstract member addSensor: sensor: DragDropActions.addSensor.sensor -> unit
//     abstract member removeSensor: id: Id -> unit
//     abstract member setOverlay: overlay: Pick<Overlay, DragDropActions.setOverlay.overlay> -> unit
//     abstract member clearOverlay: unit -> unit
//     abstract member recomputeLayouts: unit -> bool
//     abstract member detectCollisions: unit -> unit
//     abstract member draggableActivators: draggableId: Id * ?asHandlers: bool -> Listeners
//     abstract member sensorStart: id: Id * coordinates: Coordinates -> unit
//     abstract member sensorMove: coordinates: Coordinates -> unit
//     abstract member sensorEnd: unit -> unit
//     abstract member dragStart: draggableId: Id -> unit
//     abstract member dragEnd: unit -> unit
//     abstract member onDragStart: handler: DragEventHandler -> unit
//     abstract member onDragMove: handler: DragEventHandler -> unit
//     abstract member onDragOver: handler: DragEventHandler -> unit
//     abstract member onDragEnd: handler: DragEventHandler -> unit
//
// [<AllowNullLiteral>]
// [<Interface>]
// type DragDropContextProps =
//     abstract member onDragStart: DragEventHandler option with get, set
//     abstract member onDragMove: DragEventHandler option with get, set
//     abstract member onDragOver: DragEventHandler option with get, set
//     abstract member onDragEnd: DragEventHandler option with get, set
//     abstract member collisionDetector: CollisionDetector option with get, set
//
// type DragDropContext =
//     Store<DragDropState> * DragDropActions
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Listeners =
//     [<EmitIndexer>]
//     abstract member Item: key: string -> (Event -> unit) with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type DragEventHandler =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: event: DragEvent -> unit
//
//
//
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Draggable =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: element: HTMLElement * ?accessor: (unit -> Draggable.Invoke.accessor) -> unit
//     abstract member ref: Setter<HTMLElement option> with get, set
//     abstract member isActiveDraggable: bool with get
//     abstract member dragActivators: Listeners with get
//     abstract member transform: Transform with get
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Droppable =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: element: HTMLElement * ?accessor: (unit -> Droppable.Invoke.accessor) -> unit
//     abstract member ref: Setter<HTMLElement option> with get, set
//     abstract member isActiveDroppable: bool with get
//     abstract member transform: Transform with get
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type DragOverlayProps =
//     abstract member children: U2<obj, (Draggable1 option -> JSX.Element)> with get, set
//     abstract member ``class``: string option with get, set
//     abstract member style: string option with get, set
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type SortableContextState =
//     abstract member initialIds: ResizeArray<Id> with get, set
//     abstract member sortedIds: ResizeArray<Id> with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type SortableContextProps =
//     abstract member ids: ResizeArray<Id> with get, set
//
// type SortableContext =
//     Store<SortableContextState> * SortableContext
//
//
//
// [<AllowNullLiteral>]
// [<Interface>]
// type RefSetter<'V> =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: value: 'V -> unit
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Sortable =
//     [<Emit("$0($1...)")>]
//     abstract member Invoke: element: HTMLElement -> unit
//     abstract member ref: RefSetter<HTMLElement option> with get, set
//     abstract member transform: Transform with get
//     abstract member dragActivators: Listeners with get
//     abstract member isActiveDraggable: bool with get
//     abstract member isActiveDroppable: bool with get
//
//
//
//
//
//
// //
// // [<Global>]
// // [<AllowNullLiteral>]
// // type SortableContext
// //     [<ParamObject; Emit("$0")>]
// //     (
// //     ) =
// //
// //     class end
//
// module CollisionDetector =
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type context
//         [<ParamObject; Emit("$0")>]
//         (
//             ?activeDroppableId: Id
//         ) =
//
//         member val activeDroppableId : Id option = nativeOnly with get, set
//
// module Layout =
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type rect
//         [<ParamObject; Emit("$0")>]
//         (
//             x: float,
//             y: float,
//             width: float,
//             height: float
//         ) =
//
//         member val x : float = nativeOnly with get, set
//         member val y : float = nativeOnly with get, set
//         member val width : float = nativeOnly with get, set
//         member val height : float = nativeOnly with get, set
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type corners
//         [<ParamObject; Emit("$0")>]
//         (
//             topLeft: Point,
//             topRight: Point,
//             bottomRight: Point,
//             bottomLeft: Point
//         ) =
//
//         member val topLeft : Point = nativeOnly with get, set
//         member val topRight : Point = nativeOnly with get, set
//         member val bottomRight : Point = nativeOnly with get, set
//         member val bottomLeft : Point = nativeOnly with get, set
//
// module Sensor =
//     [<Global>]
//     [<AllowNullLiteral>]
//     type activators =
//         [<EmitIndexer>]
//         abstract Item: string -> SensorActivator<Event> option with get,set
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type coordinates
//         [<ParamObject; Emit("$0")>]
//         (
//             origin: Coordinates,
//             current: Coordinates,
//             delta: Coordinates
//         ) =
//
//         member val origin : Coordinates = nativeOnly with get, set
//         member val current : Coordinates = nativeOnly with get, set
//         member val delta : Coordinates = nativeOnly with get
//
// module Item =
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type data =
//         [<EmitIndexer>]
//         abstract member Item: key: string -> obj with get, set
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type transformers =
//         [<EmitIndexer>]
//         abstract member Item: key: Id -> Transformer with get, set
//
// module DragDropState =
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type draggables =
//         [<EmitIndexer>]
//         abstract member Item: key: Id -> Draggable$1 with get, set
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type droppables =
//         [<EmitIndexer>]
//         abstract member Item: key: Id -> Droppable$1 with get, set
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type sensors =
//         [<EmitIndexer>]
//         abstract member Item: key: Id -> Sensor with get, set
//
//     [<Global>]
//     [<AllowNullLiteral>]
//     type active
//         [<ParamObject; Emit("$0")>]
//         (
//             ?draggableId: Id,
//             ?draggable: Draggable$1,
//             ?droppableId: Id,
//             ?droppable: Droppable$1,
//             ?sensorId: Id,
//             ?sensor: Sensor,
//             ?overlay: Overlay
//         ) =
//
//         member val draggableId : Id option = nativeOnly with get, set
//         member val draggable : Draggable$1 option = nativeOnly with get, set
//         member val droppableId : Id option = nativeOnly with get, set
//         member val droppable : Droppable$1 option = nativeOnly with get, set
//         member val sensorId : Id option = nativeOnly with get, set
//         member val sensor : Sensor option = nativeOnly with get, set
//         member val overlay : Overlay option = nativeOnly with get, set
//
// module DragDropActions =
//
//     module addTransformer =
//
//         [<RequireQualifiedAccess>]
//         [<StringEnum(CaseRules.None)>]
//         type ``type`` =
//             | draggables
//             | droppables
//
//     module removeTransformer =
//
//         [<RequireQualifiedAccess>]
//         [<StringEnum(CaseRules.None)>]
//         type ``type`` =
//             | draggables
//             | droppables
//
//     module addDraggable =
//
//         [<AllowNullLiteral>]
//         [<Interface>]
//         type draggable =
//             abstract member id: Id with get, set
//             abstract member node: HTMLElement with get, set
//             abstract member layout: Layout with get, set
//             abstract member data: DragDropActions.addDraggable.draggable.data with get, set
//             abstract member _pendingCleanup: bool option with get, set
//
//         module draggable =
//
//             [<AllowNullLiteral>]
//             [<Interface>]
//             type data =
//                 [<EmitIndexer>]
//                 abstract member Item: key: string -> obj with get, set
//
//     module addDroppable =
//
//         [<AllowNullLiteral>]
//         [<Interface>]
//         type droppable =
//             abstract member id: Id with get, set
//             abstract member node: HTMLElement with get, set
//             abstract member layout: Layout with get, set
//             abstract member data: DragDropActions.addDroppable.droppable.data with get, set
//             abstract member _pendingCleanup: bool option with get, set
//
//         module droppable =
//
//             [<AllowNullLiteral>]
//             [<Interface>]
//             type data =
//                 [<EmitIndexer>]
//                 abstract member Item: key: string -> obj with get, set
//
//     module addSensor =
//
//         [<AllowNullLiteral>]
//         [<Interface>]
//         type sensor =
//             abstract member id: Id with get, set
//             abstract member activators: DragDropActions.addSensor.sensor.activators with get, set
//
//         module sensor =
//
//             [<Global>]
//             [<AllowNullLiteral>]
//             type activators
//                 [<ParamObject; Emit("$0")>]
//                 (
//                     ?Event: SensorActivator<K>
//                 ) =
//
//                 member val Event : SensorActivator<K> option = nativeOnly with get, set
//
//     module setOverlay =
//
//         [<RequireQualifiedAccess>]
//         [<StringEnum(CaseRules.None)>]
//         type overlay =
//             | node
//             | layout
//
// module Draggable =
//
//     module Invoke =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type accessor
//             [<ParamObject; Emit("$0")>]
//             (
//                 ?skipTransform: bool
//             ) =
//
//             member val skipTransform : bool option = nativeOnly with get, set
//
// module Droppable =
//
//     module Invoke =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type accessor
//             [<ParamObject; Emit("$0")>]
//             (
//                 ?skipTransform: bool
//             ) =
//
//             member val skipTransform : bool option = nativeOnly with get, set
//
// module Exports =
//
//     module Layout =
//
//         [<Global>]
//         [<AllowNullLiteral>]
//         type rect
//             [<ParamObject; Emit("$0")>]
//             (
//                 x: float,
//                 y: float,
//                 width: float,
//                 height: float
//             ) =
//
//             member val x : float = nativeOnly with get, set
//             member val y : float = nativeOnly with get, set
//             member val width : float = nativeOnly with get, set
//             member val height : float = nativeOnly with get, set
