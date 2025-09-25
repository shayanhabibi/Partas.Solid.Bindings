module Partas.Solid.ArkUI.FloatingPanel
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Partas.Solid.ZagJs
open Browser.Types

[<Literal>]
let private import = "@ark-ui/solid/floating-panel"
[<Literal>]
let private prefix = "FloatingPanel."

[<Import(prefix + "Root", import)>]
type Root
    () =
    interface RegularNode
    interface DirectionProperty
    interface CommonProperties

    /// <summary>
    /// The ids of the elements in the floating panel. Useful for composition.
    /// </summary>
    [<Erase>]
    member val ids: FloatingPanel.ElementIds = JS.undefined with get , set

    /// <summary>
    /// The translations for the floating panel.
    /// </summary>
    [<Erase>]
    member val translations: FloatingPanel.IntlTranslations = JS.undefined with get , set

    /// <summary>
    /// The strategy to use for positioning
    /// </summary>
    [<Erase>]
    member val strategy: FloatingPanel.Strategy = JS.undefined with get , set

    /// <summary>
    /// Whether the panel should be strictly contained within the boundary when dragging
    /// </summary>
    [<Erase>]
    member val allowOverflow: bool = JS.undefined with get , set

    /// <summary>
    /// The controlled open state of the panel
    /// </summary>
    [<Erase>]
    member val open': bool = JS.undefined with get , set

    /// <summary>
    /// The initial open state of the panel when rendered.
    /// Use when you don't need to control the open state of the panel.
    /// </summary>
    [<Erase>]
    member val defaultOpen: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the panel is draggable
    /// </summary>
    [<Erase>]
    member val draggable: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the panel is resizable
    /// </summary>
    [<Erase>]
    member val resizable: bool = JS.undefined with get , set

    /// <summary>
    /// The size of the panel
    /// </summary>
    [<Erase>]
    member val size: Size = JS.undefined with get , set

    /// <summary>
    /// The default size of the panel
    /// </summary>
    [<Erase>]
    member val defaultSize: Size = JS.undefined with get , set

    /// <summary>
    /// The minimum size of the panel
    /// </summary>
    [<Erase>]
    member val minSize: Size option = JS.undefined with get , set

    /// <summary>
    /// The maximum size of the panel
    /// </summary>
    [<Erase>]
    member val maxSize: Size option = JS.undefined with get , set

    /// <summary>
    /// The controlled position of the panel
    /// </summary>
    [<Erase>]
    member val position: obj = JS.undefined with get , set

    /// <summary>
    /// The initial position of the panel when rendered.
    /// Use when you don't need to control the position of the panel.
    /// </summary>
    [<Erase>]
    member val defaultPosition: obj = JS.undefined with get , set

    /// <summary>
    /// Function that returns the initial position of the panel when it is opened.
    /// If provided, will be used instead of the default position.
    /// </summary>
    [<Erase>]
    member val getAnchorPosition: (FloatingPanel.AnchorPositionDetails -> Point) = JS.undefined with get , set

    /// <summary>
    /// Whether the panel is locked to its aspect ratio
    /// </summary>
    [<Erase>]
    member val lockAspectRatio: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the panel should close when the escape key is pressed
    /// </summary>
    [<Erase>]
    member val closeOnEscape: bool = JS.undefined with get , set

    /// <summary>
    /// The boundary of the panel. Useful for recalculating the boundary rect when
    /// the it is resized.
    /// </summary>
    [<Erase>]
    member val getBoundaryEl: (unit -> HTMLElement option) option = JS.undefined with get , set

    /// <summary>
    /// Whether the panel is disabled
    /// </summary>
    [<Erase>]
    member val disabled: bool = JS.undefined with get , set

    /// <summary>
    /// Function called when the position of the panel changes via dragging
    /// </summary>
    [<Erase>]
    member val onPositionChange: (FloatingPanel.PositionChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Function called when the position of the panel changes via dragging ends
    /// </summary>
    [<Erase>]
    member val onPositionChangeEnd: (FloatingPanel.PositionChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Function called when the panel is opened or closed
    /// </summary>
    [<Erase>]
    member val onOpenChange: (FloatingPanel.OpenChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Function called when the size of the panel changes via resizing
    /// </summary>
    [<Erase>]
    member val onSizeChange: (FloatingPanel.SizeChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Function called when the size of the panel changes via resizing ends
    /// </summary>
    [<Erase>]
    member val onSizeChangeEnd: (FloatingPanel.SizeChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Whether the panel size and position should be preserved when it is closed
    /// </summary>
    [<Erase>]
    member val persistRect: bool = JS.undefined with get , set

    /// <summary>
    /// The snap grid for the panel
    /// </summary>
    [<Erase>]
    member val gridSize: float = JS.undefined with get , set

    /// <summary>
    /// Function called when the stage of the panel changes
    /// </summary>
    [<Erase>]
    member val onStageChange: (FloatingPanel.StageChangeDetails -> unit) = JS.undefined with get , set
    [<Erase>]
    member val lazyMount: bool = undefined with get,set
    [<Erase>]
    member val immediate: bool = undefined with get,set
    [<Erase>]
    member val present: bool = undefined with get,set
    [<Erase>]
    member val skipAnimationOnMount: bool = undefined with get,set
    [<Erase>]
    member val unmountOnExit: bool = undefined with get,set
    
[<Import(prefix + "Context", import)>]
type Context() =
    interface HtmlElement
    interface ChildLambdaProvider<Accessor<FloatingPanelApi>>

[<Import(prefix + "Body", import)>]
type Body
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] body
    /// [data-dragging]
    /// [data-minimized]
    /// [data-maximized]
    /// [data-staged]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "CloseTrigger", import)>]
type CloseTrigger () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set

[<Import(prefix + "Content", import)>]
type Content
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] content
    /// [data-state] open | closed
    /// [data-dragging]
    /// [data-topmost]
    /// [data-behind]
    /// [data-minimized]
    /// [data-maximized]
    /// [data-staged]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "Control", import)>]
type Control
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] control
    /// [data-disabled]
    /// [data-stage]
    /// [data-minimized]
    /// [data-maximized]
    /// [data-staged]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "DragTrigger", import)>]
type DragTrigger
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] drag-trigger
    /// [data-disabled]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "Header", import)>]
type Header
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] header
    /// [data-dragging]
    /// [data-topmost]
    /// [data-behind]
    /// [data-minimized]
    /// [data-maximized]
    /// [data-staged]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "Positioner", import)>]
type Positioner
    /// <summary>
    /// <code>
    /// --width
    /// --height
    /// --x
    /// --y
    /// --transform-origin
    /// --reference-width : the width of the reference element
    /// --reference-height
    /// --available-width :avail width in viewport
    /// --available-height
    /// --z-index
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "ResizeTrigger", import)>]
type ResizeTrigger
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] resize-trigger
    /// [data-disabled]
    /// [data-axis]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val axis: FloatingPanel.ResizeTriggerAxis = undefined with get,set
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "RootProvider", import)>]
type RootProvider () =
    interface RegularNode
    [<Erase>]
    member val value: Accessor<FloatingPanelApi> = undefined with get,set
    [<Erase>]
    member val immediate: bool = undefined with get,set
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val lazyMount: bool = undefined with get,set
    [<Erase>]
    member val onExitComplete: unit -> unit = undefined with get,set
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val skipAnimationOnMount: bool = undefined with get,set
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val unmountOnExit: bool = undefined with get,set
[<Import(prefix + "StageTrigger", import)>]
type StageTrigger () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
    [<Erase>]
    member val stage: FloatingPanel.Stage = undefined with get,set
[<Import(prefix + "Title", import)>]
type Title () =
    inherit h2()
    interface Polymorph
    [<Erase>]
    member val asChild: h2 -> HtmlElement = undefined with get,set
[<Import(prefix + "Trigger", import)>]
type Trigger
    /// <summary>
    /// <code>
    /// [data-scope] floating-panel
    /// [data-part] trigger
    /// [data-state] open | closed
    /// [data-dragging]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
