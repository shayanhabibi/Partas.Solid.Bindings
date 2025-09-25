namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types

[<Pojo>]
type Point(x: float, y: float) =
    member val x = x with get,set
    member val y = y with get,set
[<Pojo>]
type Size(height: float, width: float) =
    member val height = height with get,set
    member val width = width with get,set
[<Pojo>]
type DOMRect(x: float, y: float, height: float, width: float) =
    member val height = height with get,set
    member val width = width with get,set
    member val x = x with get,set
    member val y = y with get,set

[<Erase>]
module FloatingPanel =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Trigger
            | Positioner
            | Content
            | Header
            | Body
            | Title
            | ResizeTrigger
            | DragTrigger
            | StageTrigger
            | CloseTrigger
            | Control
    type PositionChangeDetails =
        abstract position: Point

    type SizeChangeDetails =
        abstract size: Size
    type OpenChangeDetails =
        abstract ``open``: bool
    [<StringEnum>]
    type Stage =
        | Minimized
        | Maximized
        | Default
    type StageChangeDetails =
        abstract stage: Stage
    type AnchorPositionDetails =
        abstract triggerRect: DOMRect option
        abstract boundaryRect: DOMRect option
    type ElementIds =
        abstract trigger: string
        abstract positioner: string
        abstract content: string
        abstract title: string
        abstract header: string
    type IntlTranslations =
        abstract minimize: string with get,set
        abstract maximize: string with get,set
        abstract restore: string with get,set
    [<StringEnum>]
    type Strategy =
        | Absolute
        | Fixed
    [<StringEnum(CaseRules.LowerAll)>]
    type ResizeTriggerAxis =
        | S
        | W
        | E
        | N
        | SW
        | NW
        | SE
        | NE

    [<Pojo>]
    type ResizeTriggerProps(
        axis: ResizeTriggerAxis
        ) =
        member val axis = axis with get,set

    [<Pojo>]
    type StageTriggerProps(
        stage: Stage
        ) =
        member val stage = stage with get,set
        
[<Interface>]
type FloatingPanelProps =
    inherit DirectionProperty
    inherit CommonProperties
    /// <summary>
    /// The ids of the elements in the floating panel. Useful for composition.
    /// </summary>
    abstract member ids: FloatingPanel.ElementIds with get, set
    /// <summary>
    /// The translations for the floating panel.
    /// </summary>
    abstract member translations: FloatingPanel.IntlTranslations with get, set
    /// <summary>
    /// The strategy to use for positioning
    /// </summary>
    abstract member strategy: FloatingPanel.Strategy with get, set
    /// <summary>
    /// Whether the panel should be strictly contained within the boundary when dragging
    /// </summary>
    abstract member allowOverflow: bool with get, set
    /// <summary>
    /// The controlled open state of the panel
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// The initial open state of the panel when rendered.
    /// Use when you don't need to control the open state of the panel.
    /// </summary>
    abstract member defaultOpen: bool with get, set
    /// <summary>
    /// Whether the panel is draggable
    /// </summary>
    abstract member draggable: bool with get, set
    /// <summary>
    /// Whether the panel is resizable
    /// </summary>
    abstract member resizable: bool with get, set
    /// <summary>
    /// The size of the panel
    /// </summary>
    abstract member size: Size with get, set
    /// <summary>
    /// The default size of the panel
    /// </summary>
    abstract member defaultSize: Size with get, set
    /// <summary>
    /// The minimum size of the panel
    /// </summary>
    abstract member minSize: Size option with get, set
    /// <summary>
    /// The maximum size of the panel
    /// </summary>
    abstract member maxSize: Size option with get, set
    /// <summary>
    /// The controlled position of the panel
    /// </summary>
    abstract member position: obj with get, set
    /// <summary>
    /// The initial position of the panel when rendered.
    /// Use when you don't need to control the position of the panel.
    /// </summary>
    abstract member defaultPosition: obj with get, set
    /// <summary>
    /// Function that returns the initial position of the panel when it is opened.
    /// If provided, will be used instead of the default position.
    /// </summary>
    abstract member getAnchorPosition: (FloatingPanel.AnchorPositionDetails -> Point) with get, set
    /// <summary>
    /// Whether the panel is locked to its aspect ratio
    /// </summary>
    abstract member lockAspectRatio: bool with get, set
    /// <summary>
    /// Whether the panel should close when the escape key is pressed
    /// </summary>
    abstract member closeOnEscape: bool with get, set
    /// <summary>
    /// The boundary of the panel. Useful for recalculating the boundary rect when
    /// the it is resized.
    /// </summary>
    abstract member getBoundaryEl: (unit -> HTMLElement option) option with get, set
    /// <summary>
    /// Whether the panel is disabled
    /// </summary>
    abstract member disabled: bool with get, set
    /// <summary>
    /// Function called when the position of the panel changes via dragging
    /// </summary>
    abstract member onPositionChange: (FloatingPanel.PositionChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the position of the panel changes via dragging ends
    /// </summary>
    abstract member onPositionChangeEnd: (FloatingPanel.PositionChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the panel is opened or closed
    /// </summary>
    abstract member onOpenChange: (FloatingPanel.OpenChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the size of the panel changes via resizing
    /// </summary>
    abstract member onSizeChange: (FloatingPanel.SizeChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the size of the panel changes via resizing ends
    /// </summary>
    abstract member onSizeChangeEnd: (FloatingPanel.SizeChangeDetails -> unit) with get, set
    /// <summary>
    /// Whether the panel size and position should be preserved when it is closed
    /// </summary>
    abstract member persistRect: bool with get, set
    /// <summary>
    /// The snap grid for the panel
    /// </summary>
    abstract member gridSize: float with get, set
    /// <summary>
    /// Function called when the stage of the panel changes
    /// </summary>
    abstract member onStageChange: (FloatingPanel.StageChangeDetails -> unit) with get, set

[<Interface>]
type FloatingPanelApi =
    /// <summary>
    /// Whether the panel is open
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// Function to open or close the panel
    /// </summary>
    abstract member setOpen: (bool -> unit) with get, set
    /// <summary>
    /// Whether the panel is being dragged
    /// </summary>
    abstract member dragging: bool with get, set
    /// <summary>
    /// Whether the panel is being resized
    /// </summary>
    abstract member resizing: bool with get, set
    /// <summary>
    /// The position of the panel
    /// </summary>
    abstract member position: Point with get, set
    /// <summary>
    /// Function to set the position of the panel
    /// </summary>
    abstract member setPosition: (Point -> unit) with get, set
    /// <summary>
    /// The size of the panel
    /// </summary>
    abstract member size: Size with get, set
    /// <summary>
    /// Function to set the size of the panel
    /// </summary>
    abstract member setSize: (Size -> unit) with get, set
    /// <summary>
    /// Function to minimize the panel
    /// </summary>
    abstract member minimize: (unit -> unit) with get, set
    /// <summary>
    /// Function to maximize the panel
    /// </summary>
    abstract member maximize: (unit -> unit) with get, set
    /// <summary>
    /// Function to restore the panel before it was minimized or maximized
    /// </summary>
    abstract member restore: (unit -> unit) with get, set
    /// <summary>
    /// Whether the panel is resizable
    /// </summary>
    abstract member resizable: bool with get, set
    /// <summary>
    /// Whether the panel is draggable
    /// </summary>
    abstract member draggable: bool with get, set
    abstract member getDragTriggerProps: (unit -> HtmlTag) with get, set
    abstract member getResizeTriggerProps: (FloatingPanel.ResizeTriggerProps -> HtmlTag) with get, set
    abstract member getTriggerProps: (unit -> button) with get, set
    abstract member getPositionerProps: (unit -> HtmlTag) with get, set
    abstract member getContentProps: (unit -> HtmlTag) with get, set
    abstract member getTitleProps: (unit -> HtmlTag) with get, set
    abstract member getHeaderProps: (unit -> HtmlTag) with get, set
    abstract member getBodyProps: (unit -> HtmlTag) with get, set
    abstract member getCloseTriggerProps: (unit -> button) with get, set
    abstract member getControlProps: (unit -> HtmlTag) with get, set
    abstract member getStageTriggerProps: (FloatingPanel.StageTriggerProps -> button) with get, set
