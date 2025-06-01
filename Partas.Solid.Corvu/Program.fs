namespace Partas.Solid.Corvu

open Fable.Core.JsInterop
open Partas.Solid
open Fable.Core
open System

#nowarn 64

[<Erase; AutoOpen>]
module private Helpers =
    let [<Erase; Literal>] accordion = "@corvu/accordion"
    let [<Erase; Literal>] disclosure = "@corvu/disclosure"
    let [<Erase; Literal>] calendar = "@corvu/calendar"
    let [<Erase; Literal>] dialog = "@corvu/dialog"
    let [<Erase; Literal>] drawer = "@corvu/drawer"
    let [<Erase; Literal>] otpField = "@corvu/otp-field"
    let [<Erase; Literal>] popover = "@corvu/popover"
    let [<Erase; Literal>] resizable = "@corvu/resizable"
    let [<Erase; Literal>] tooltip = "@corvu/tooltip"

type [<StringEnum>] Orientation =
    | Vertical
    | Horizontal

type [<StringEnum>] TextDirection =
    | Ltr
    | Rtl

type [<StringEnum>] CollapseBehavior =
    | Remove
    | Hide

[<RequireQualifiedAccess; Erase>]
module Disclosure =
    [<Erase; Import("Trigger", disclosure)>]
    type Trigger() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Content", disclosure)>]
    type Content() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val contextId : string = jsNative with get,set

[<Erase; Import("Root", disclosure)>]
type Disclosure() =
    interface RegularNode
    member val expanded : bool = jsNative with get,set
    member val onExpandedChange : bool -> unit = jsNative with get,set
    member val intialExpanded : bool = jsNative with get,set
    member val collapseBehavior : CollapseBehavior = jsNative with get,set
    member val onContentPresentChange : bool -> unit = jsNative with get,set
    member val disclosureId : string = jsNative with get,set
    member val contextId : string = jsNative with get,set

[<RequireQualifiedAccess>]
module [<Erase>] Accordion =
    [<Erase; Import("Item", accordion)>]
    type Item() =
        inherit Disclosure()
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val triggerId : string = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set

    [<Erase; Import("Trigger", accordion)>]
    type Trigger() =
        inherit Disclosure.Trigger()
    [<Erase; Import("Content", accordion)>]
    type Content() =
        inherit Disclosure.Content()

[<Erase; Import("Root", accordion)>]
type Accordion() =
    interface RegularNode
    member val multiple : bool = jsNative with get,set
    member val value : U2<string, string[]> = jsNative with get,set
    member val onValueChange : U2<string, string[]> -> unit = jsNative with get,set
    member val initialValue : U2<string, string[]> -> unit = jsNative with get,set
    member val collapsible : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val loop : bool = jsNative with get,set
    member val textDirection : TextDirection = jsNative with get,set
    member val collapseBehavior : CollapseBehavior = jsNative with get,set
    member val contextId : string = jsNative with get,set

[<StringEnum>]
type CalendarMode =
    | Single
    | Multiple
    | Range

type [<Erase>] day =
    static member inline sunday : day = unbox 0
    static member inline monday : day = unbox 1
    static member inline tuesday : day = unbox 2
    static member inline wednesday : day = unbox 3
    static member inline thursday : day = unbox 4
    static member inline friday : day = unbox 5
    static member inline saturday : day = unbox 6

[<Erase; Import("Root", calendar)>]
type Calendar() =
    interface RegularNode
    member val mode : CalendarMode = jsNative with get,set
    member val value : U3<DateTime, DateTime[], {| from:DateTime; ``to``:DateTime |}> = jsNative with get,set
    member val onValueChange : U3<DateTime, DateTime[], {|from:DateTime;``to``:DateTime|}> -> unit = jsNative with get,set
    member val initialValue : U3<DateTime, DateTime[], {| from:DateTime;``to``:DateTime |}> = jsNative with get,set
    member val month : DateTime = jsNative
    member val onMonthChange : DateTime -> unit = jsNative with get,set
    member val initialMonth : DateTime = jsNative with get,set
    member val focusedDay : DateTime = jsNative with get,set
    member val onFocusedDayChange : DateTime -> unit = jsNative with get,set
    member val initialFocusedDay : DateTime = jsNative with get,set
    member val startOfWeek : day = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : DateTime -> bool = jsNative with get,set
    member val numberOfMonths : int = jsNative with get,set
    member val disableOutsideDays : bool = jsNative with get,set
    member val fixedWeeks : bool = jsNative with get,set
    member val textDirection : TextDirection = jsNative with get,set
    member val min : int = jsNative with get,set
    member val max : int = jsNative with get,set
    member val excludeDisabled : bool = jsNative with get,set
    member val labelIds : string[] = jsNative with get,set
    member val contextId : string = jsNative with get,set


[<Erase; RequireQualifiedAccess>]
module Calendar =
    type [<StringEnum(CaseRules.KebabCase)>] Action =
        | PrevMonth
        | PrevYear
        | NextMonth
        | NextYear
    [<Erase; Import("Label", calendar)>]
    type Label() =
        interface RegularNode
        member val index : int = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Nav", calendar)>]
    type Nav() =
        interface RegularNode
        member val action : Action = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Table", calendar)>]
    type Table() =
        interface RegularNode
        member val index : int = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("HeadCell", calendar)>]
    type HeadCell() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
    [<Erase; Import("Cell", calendar)>]
    type Cell() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
    [<Erase; Import("CellTrigger", calendar)>]
    type CellTrigger() =
        interface RegularNode
        member val day : DateTime = jsNative with get,set
        member val month : DateTime = jsNative with get,set
        member val contextId : string = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set

type [<StringEnum>] DialogRole =
    | Dialog
    | Alertdialog

type [<StringEnum>] PointerStrategy =
    | Pointerdown
    | Pointerup

type [<StringEnum>] ScrollbarShiftMode =
    | Padding
    | Margin

[<Erase; Import("Root", dialog)>]
type Dialog() =
    interface RegularNode
    member val role : DialogRole = jsNative with get,set
    member val open' : bool = jsNative with get,set
    member val onOpenChange : bool -> unit = jsNative with get,set
    member val initialOpen : bool = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val closeOnEscapeKeyDown : bool = jsNative with get,set
    member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
    member val closeOnOutsideFocus : bool = jsNative with get,set
    member val closeOnOutsidePointerStrategy : PointerStrategy = jsNative with get,set
    member val onOutsideFocus : Browser.Types.CustomEvent -> unit = jsNative with get,set
    member val onOutsidePointer : Browser.Types.PointerEvent -> unit = jsNative with get,set
    member val noOutsidePointerEvents : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val hideScrollbar : bool = jsNative with get,set
    member val preventScrollbarShift : bool = jsNative with get,set
    member val preventScrollbarShiftMode : ScrollbarShiftMode = jsNative with get,set
    member val restoreScrollPosition : bool = jsNative with get,set
    member val allowPinchZoom : bool = jsNative with get,set
    member val trapFocus : bool = jsNative with get,set
    member val restoreFocus : bool = jsNative with get,set
    member val initialFocusEl : JSX.Element = jsNative with get,set
    member val onInitialFocus : Browser.Types.Event -> unit = jsNative with get,set
    member val finalFocusEl : JSX.Element = jsNative with get,set
    member val onFinalFocus : Browser.Types.Event -> unit= jsNative with get,set
    member val onContentPresentChange : bool -> unit = jsNative with get,set
    member val onOverlayPresentChange : bool -> unit = jsNative with get,set
    member val dialogId : string = jsNative with get,set
    member val labelId : string = jsNative with get,set
    member val descriptionId : string = jsNative with get,set
    member val contextId : string = jsNative with get,set
    
[<RequireQualifiedAccess; Erase>]
module Dialog =
    [<Erase; Import("Trigger", dialog)>]
    type Trigger() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
        
    [<Erase ; Import("Portal", dialog)>]
    type Portal() =
        interface RegularNode
        member val forceMount : bool = jsNative with get,set
        member val contextId : string = jsNative with get,set
    
    [<Erase; Import("Overlay", dialog)>]
    type Overlay() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val contextId : string = jsNative with get,set
    
    [<Erase; Import("Content", dialog)>]
    type Content() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val contextId : string = jsNative with get,set
    
    [<Erase; Import("Close", dialog)>]
    type Close() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId: string = jsNative with get,set
    
    [<Erase; Import("Label", dialog)>]
    type Label() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    
    [<Erase; Import("Description", dialog)>]
    type Description() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set

[<StringEnum>]
type Side =
    | Bottom
    | Top
    | Left
    | Right

// Type Size = `${number}px` | number

[<Erase; Import("Root", drawer)>]
type Drawer() =
    interface RegularNode
    member val snapPoints : float[] = jsNative with get,set
    member val breakPoints : float[] = jsNative with get,set
    member val defaultSnapPoint : float = jsNative with get,set
    member val activeSnapPoint : float = jsNative with get,set
    member val onActiveSnapPointChange : float -> unit = jsNative with get,set
    member val side : Side = jsNative with get,set
    member val dampFunction : int -> int = jsNative with get,set
    member val velocityFunction : int * int -> int = jsNative with get,set
    member val velocityCacheReset : int = jsNative with get,set
    member val allowSkippingSnapPoints : bool = jsNative with get,set
    member val handleScrollableElements : bool = jsNative with get,set
    member val transitionResize : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Drawer =
    [<Erase; Import("Trigger", drawer)>]
    type Trigger() =
        inherit Dialog.Trigger()
    [<Erase; Import("Overlay", drawer)>]
    type Overlay() =
        inherit Dialog.Overlay()
    [<Erase; Import("Content", drawer)>]
    type Content() =
        inherit Dialog.Content()
    [<Erase; Import("Close", drawer)>]
    type Close() =
        inherit Dialog.Close()
    [<Erase; Import("Label", drawer)>]
    type Label() =
        inherit Dialog.Label()
    [<Erase; Import("Description", drawer)>]
    type Description() =
        inherit Dialog.Description()
    [<Erase; Import("Portal", drawer)>]
    type Portal() =
        inherit Dialog.Portal()

[<JS.Pojo>]
type OtpFieldContext
    (
        value: Accessor<string>,
        isFocused: Accessor<bool>,
        isHovered: Accessor<bool>,
        isInserting: Accessor<bool>,
        maxLength: Accessor<int>,
        activeSlots: Accessor<int[]>,
        shiftPWManagers: Accessor<bool>
    ) =
    member val value: Accessor<string>
    member val isFocused: Accessor<bool>
    member val isHovered: Accessor<bool>
    member val isInserting: Accessor<bool>
    member val maxLength: Accessor<int>
    member val activeSlots: Accessor<int[]>
    member val shiftPWManagers: Accessor<bool>

[<Erase; Import("Root", otpField)>]
type OtpField() =
    interface RegularNode
    member val maxLength : int = jsNative with get,set
    member val value : string = jsNative with get,set
    member val onValueChange : string -> unit = jsNative with get,set
    member val onComplete : string -> unit = jsNative with get,set
    member val shiftPWManagers : bool = jsNative with get,set
    member val contextId: string = jsNative with get,set
    member val as' : string = jsNative with get,set
    [<ImportMember(otpField)>]
    static member useContext (): OtpFieldContext = jsNative
    
[<Erase; RequireQualifiedAccess>]
module OtpField =
    [<Erase; Import("Input", otpField)>]
    type Input() =
        interface RegularNode
        member val pattern : string = jsNative with get,set
        member val noScriptCSSFallback : string = jsNative with get,set
        member val contextId : string = jsNative with get,set
        member val as' : string = jsNative with get,set

[<StringEnum>]
type PositionStrategy =
    | Absolute
    | Sticky

[<Erase; Import("Root", popover)>]
type Popover() =
    inherit Dialog()
    member val placement : Side = jsNative with get,set
    member val strategy : PositionStrategy = jsNative with get,set
    member val floatingOptions : {| flip : bool ; shift : bool |} = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Popover =
    [<Erase; Import("Anchor", popover)>]
    type Anchor() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Trigger", popover)>]
    type Trigger() =
        inherit Dialog.Trigger()
    [<Erase; Import("Portal", popover)>]
    type Portal() =
        inherit Dialog.Portal()
    [<Erase; Import("Overlay", popover)>]
    type Overlay() =
        inherit Dialog.Overlay()
    [<Erase; Import("Content", popover)>]
    type Content() =
        inherit Dialog.Content()
    [<Erase; Import("Close", popover)>]
    type Close() =
        inherit Dialog.Close()
    [<Erase; Import("Label", popover)>]
    type Label() =
        inherit Dialog.Label()
    [<Erase; Import("Description", popover)>]
    type Description() =
        inherit Dialog.Description()
    
    [<Erase; Import("Arrow", popover)>]
    type Arrow() =
        interface RegularNode
        member val size : int = jsNative with get,set
        member val as' : JSX.ElementType = jsNative with get,set
        member val contextId : string = jsNative with get,set
    
[<Erase; Import("Root", resizable)>]
type Resizable() =
    interface RegularNode
    member val orientation : Orientation = jsNative with get,set
    member val sizes : float[] = jsNative with get,set
    member val onSizesChange : float[] -> unit = jsNative with get,set
    member val initialSizes : float[] = jsNative with get,set
    member val keyboardDelta : float = jsNative with get,set
    member val handleCursorStyle : bool = jsNative with get,set
    member val as' : JSX.Element = jsNative with get,set
    member val contextId : string = jsNative with get,set

type [<Erase>] DefaultTruth =
    static member inline true' : DefaultTruth = unbox true
    static member inline false' : DefaultTruth = unbox false
    static member inline only : DefaultTruth = unbox "only"

[<Erase; RequireQualifiedAccess>]
module Resizable =
    [<Erase; Import("Panel", resizable)>]
    type Panel() =
        interface RegularNode
        member val initialSize : float = jsNative with get,set
        member val minSize : float = jsNative with get,set
        member val maxSize : float = jsNative with get,set
        member val collapsible : bool = jsNative with get,set
        member val collapsedSize : float = jsNative with get,set
        member val collapseThreshold : float = jsNative with get,set
        member val onResize : float -> unit = jsNative with get,set
        member val onCollapse : float -> unit = jsNative with get,set
        member val onExpand : float -> unit = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
        member val panelId : string = jsNative with get,set
    
    [<Erase; Import("Handle", resizable)>]
    type Handle() =
        interface RegularNode
        member val startIntersection : bool = jsNative with get,set
        member val endIntersection : bool = jsNative with get,set
        member val altKey : DefaultTruth = jsNative with get,set
        member val onHandleDragStart : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onHandleDrag : Browser.Types.CustomEvent -> unit = jsNative with get,set
        member val onHandleDragEnd : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set

[<Erase; Import("Root", tooltip)>]
type Tooltip() =
    interface RegularNode
    member val open' : bool = jsNative with get,set
    member val onOpenChange : bool -> unit = jsNative with get,set
    member val initialOpen : bool = jsNative with get,set
    member val placement : Side = jsNative with get,set
    member val strategy : PositionStrategy = jsNative with get,set
    member val floatingOptions : {| flip : bool ; shift : bool |} = jsNative with get,set
    member val openDelay : int = jsNative with get,set
    member val closeDelay : int = jsNative with get,set
    member val skipDelayDuration : int = jsNative with get,set
    member val hoverableContent : bool = jsNative with get,set
    member val group : string = jsNative with get,set
    member val openOnFocus : bool = jsNative with get,set
    member val onFocus : Browser.Types.FocusEvent -> unit = jsNative with get,set
    member val onBlue : Browser.Types.FocusEvent -> unit = jsNative with get,set
    member val openOnHover : bool = jsNative with get,set
    member val onHover : Browser.Types.MouseEvent -> unit = jsNative with get,set
    member val onLeave : Browser.Types.MouseEvent -> unit = jsNative with get,set
    member val closeOnEscapeKeyDown : bool = jsNative with get,set
    member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
    member val closeOnPointerDown : bool = jsNative with get,set
    member val onPointerDown : Browser.Types.MouseEvent -> unit = jsNative with get,set
    member val closeOnScroll : bool = jsNative with get,set
    member val onScroll : Browser.Types.Event -> unit = jsNative with get,set
    member val onContentPresentChange : bool -> unit = jsNative with get,set
    member val tooltipId : string = jsNative with get,set
    member val contextId : string = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Tooltip =
    [<Erase; Import("Anchor", tooltip)>]
    type Anchor() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Trigger", tooltip)>]
    type Trigger() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Portal", tooltip)>]
    type Portal() =
        interface RegularNode
        member val forceMount: bool = jsNative with get,set
        member val contextId : string = jsNative with get,set
    [<Erase; Import("Content", tooltip)>]
    type Content() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
        member val forceMount: bool = jsNative with get,set
    [<Erase; Import("Arrow", tooltip)>]
    type Arrow() =
        interface RegularNode
        member val as' : JSX.Element = jsNative with get,set
        member val contextId : string = jsNative with get,set
        member val size: int = jsNative with get,set
    
module Utilities =
    [<Erase; AutoOpen>]
    module private Helpers =
        let [<Erase; Literal>] dismissible = "solid-dismissible"
        let [<Erase; Literal>] createFocusTrap = "solid-focus-trap"
        let [<Erase; Literal>] list' = "solid-list"
        let [<Erase; Literal>] createPersistent = "solid-persistent"
        let [<Erase; Literal>] createPresence = "solid-presence"
        let [<Erase; Literal>] createPreventScroll = "solid-prevent-scroll"
        let [<Erase; Literal>] createTransitionSize = "solid-transition-size"
    
    [<StringEnum>]
    type DismissReason =
        | EscapeKey
        | OutsidePointer
        | OutsideFocus
    
    [<Erase; Import("Dismissible", dismissible)>]
    type Dismissible() =
        interface RegularNode
        member val enabled : bool = jsNative with get,set
        member val dismissibleId : string = jsNative with get,set
        member val element : HtmlElement = jsNative with get,set
        member val onDismiss : DismissReason -> unit = jsNative with get,set
        member val dismissOnEscapeKeyDown : bool = jsNative with get,set
        member val dismissOnOutsideFocus : bool = jsNative with get,set
        member val dismissOnOutsidePointer : bool = jsNative with get,set
        member val outsidePointerStrategy : PointerStrategy = jsNative with get,set
        member val outsidePointerIgnore : HtmlElement = jsNative with get,set
        member val noOutsidePointerEvents : bool = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onOutsidePointer : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onOutsideFocus : Browser.Types.CustomEvent -> unit = jsNative with get,set
    
    [<Global; AllowNullLiteral>]
    type CreateListResult [<ParamObject; Emit("$0")>]
        (
            active : unit -> 'T,
            setActive : 'T -> unit,
            onKeyDown : Browser.Types.KeyboardEvent -> unit
        ) =
        member val active : unit -> 'T = jsNative with get,set
        member val setActive : 'T -> unit = jsNative with get,set
        member val onKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
    
    [<Global; AllowNullLiteral>]
    type CreateMultiListResult [<ParamObject; Emit("$0")>]
        (
            cursor : unit -> 'T,
            setCursor : 'T -> unit,
            active : unit -> 'T[],
            setActive : 'T[] -> unit,
            setCursorActive : 'T -> unit,
            selected : unit -> 'T[],
            setSelected : 'T[] -> unit,
            toggleSelected : 'T -> unit,
            onKeyDown : Browser.Types.KeyboardEvent -> unit
        ) =
        member val cursor : unit -> 'T = jsNative with get,set
        member val setCursor : 'T -> unit = jsNative with get,set
        member val active : unit -> 'T[] = jsNative with get,set
        member val setActive : 'T[] -> unit = jsNative with get,set
        member val selected : unit -> 'T[] = jsNative with get,set
        member val setSelected : 'T[] -> unit = jsNative with get,set
        member val onKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val setCursorActive : 'T -> unit = jsNative with get,set
        member val toggleSelected : 'T -> unit = jsNative with get,set
    [<Global; AllowNullLiteral>]
    type CreatePersistentComponentResult [<ParamObject; Emit("$0")>]
        (
            persistedComponent : JSX.Element
        ) =
        member val persistedComponent : JSX.Element = jsNative with get,set
    [<StringEnum>]
    type PresenceState =
        | Present
        | Hidden
        | Hiding

    [<Global; AllowNullLiteral>]
    type CreatePresenceResult [<ParamObject; Emit("$0")>]
        (
            present : unit -> bool,
            state : unit -> PresenceState
        ) =
        member val present : unit -> bool = jsNative with get,set
        member val state : unit -> PresenceState = jsNative with get,set

    [<StringEnum>]
    type ScollbarShiftMode =
        | Padding
        | Margin

    [<StringEnum>]
    type TransitionDimension =
        | Both
        | Width
        | Height

    [<Global; AllowNullLiteral>]
    type CreateTransitionSize [<ParamObject; Emit("$0")>]
        (
            transitionSize : unit -> float[],
            transitioning : unit -> bool
        ) =
        member val transitionSize : unit -> float[] = jsNative with get,set
        member val transitioning : unit -> bool = jsNative with get,set

    [<Erase>]
    type Corvu =
        static member inline createFocusTrap(?element : HtmlElement, ?enabled : bool, ?observeChanges : bool, ?initialFocusElement : HtmlElement, ?onInitialFocus : Browser.Types.Event -> unit, ?restoreFocus : bool, ?finalFocusElement : HtmlElement, ?onFinalFocus : Browser.Types.Event -> unit) =
            [
                if element.IsSome then yield "element" ==> unbox element.Value
                if enabled.IsSome then yield "enabled" ==> unbox enabled.Value
                if observeChanges.IsSome then yield "observeChanges" ==> unbox observeChanges.Value
                if initialFocusElement.IsSome then yield "initialFocusElement" ==> unbox initialFocusElement.Value
                if onInitialFocus.IsSome then yield "onInitialFocus" ==> unbox onInitialFocus.Value
                if restoreFocus.IsSome then yield "restoreFocus" ==> unbox restoreFocus.Value
                if finalFocusElement.IsSome then yield "finalFocusElement" ==> unbox finalFocusElement.Value
                if onFinalFocus.IsSome then yield "onFinalFocus" ==> unbox onFinalFocus.Value
            ] |> createObj
            |> import "createFocusTrap" createFocusTrap
        static member inline createList(?items : 'T[], ?initialFocus: 'T, ?orientation : Orientation, ?loop : bool, ?textDirection : TextDirection, ?handleTab : bool, ?vimMode : bool, ?vimKeys : {| up : string; down : string; left : string; right : string |}, ?onActiveChange : 'T -> unit) : CreateListResult =
            [
                if items.IsSome then yield "items" ==> unbox items.Value
                if initialFocus.IsSome then yield "initialFocus" ==> unbox initialFocus.Value
                if orientation.IsSome then yield "orientation" ==> unbox orientation.Value
                if loop.IsSome then yield "loop" ==> unbox loop.Value
                if textDirection.IsSome then yield "textDirection" ==> unbox textDirection.Value
                if handleTab.IsSome then yield "handleTab" ==> unbox handleTab.Value
                if vimMode.IsSome then yield "vimMode" ==> unbox vimMode.Value
                if vimKeys.IsSome then yield "vimKeys" ==> unbox vimKeys.Value
                if onActiveChange.IsSome then yield "onActiveChange" ==> unbox onActiveChange.Value
            ] |> createObj
            |> import "createList" list'
        static member inline createMultiList(?items: 'T[], ?initialCursor: 'T, ?initialActive: 'T[], ?initialSelected: 'T[], ?orientation:Orientation, ?loop:bool, ?textDirection:TextDirection, ?handleTab:bool, ?vimMode : bool, ?vimKeys:{|up:string;down:string;right:string;left:string|}, ?onCursorChange : 'T -> unit, ?onActiveChange : 'T[] -> unit, ?onSelectedChange : 'T[] -> unit) : CreateMultiListResult =
            [
                if items.IsSome then yield "items" ==> unbox items.Value
                if initialCursor.IsSome then yield "initialCursor" ==> unbox initialCursor.Value
                if initialActive.IsSome then yield "initialActive" ==> unbox initialActive.Value
                if initialSelected.IsSome then yield "initialSelected" ==> unbox initialSelected.Value
                if orientation.IsSome then yield "orientation" ==> unbox orientation.Value
                if loop.IsSome then yield "loop" ==> unbox loop.Value
                if textDirection.IsSome then yield "textDirection" ==> unbox textDirection.Value
                if handleTab.IsSome then yield "handleTab" ==> unbox handleTab.Value
                if vimMode.IsSome then yield "vimMode" ==> unbox vimMode.Value
                if vimKeys.IsSome then yield "vimKeys" ==> unbox vimKeys.Value
                if onCursorChange.IsSome then yield "onCursorChange" ==> unbox onCursorChange.Value
                if onActiveChange.IsSome then yield "onActiveChange" ==> unbox onActiveChange.Value
                if onSelectedChange.IsSome then yield "onSelectedChange" ==> unbox onSelectedChange.Value
            ] |> createObj
            |> import "createMultiList" list'
        [<Import("createPersistent", createPersistent)>]
        static member inline createPersistent(comp: unit -> JSX.Element) : CreatePersistentComponentResult = jsNative
        
        static member inline createPresence(?show : unit -> bool, ?element : unit -> HtmlElement, ?onStateChange : PresenceState -> unit) : CreatePresenceResult =
            [
                if show.IsSome then yield "show" ==> unbox show.Value
                if element.IsSome then yield "element" ==> unbox element.Value
                if onStateChange.IsSome then yield "onStateChange" ==> unbox onStateChange.Value
            ] |> createObj
            |> import "createPresence" createPresence
        
        static member inline createPreventScroll(?element : unit -> HtmlElement, ?enabled : unit -> bool, ?hideScrollbar : unit -> bool, ?preventScrollbarShiftMode : unit -> ScrollbarShiftMode, ?restoreScrollPosition : unit -> bool, ?allowPinchZoom: unit -> bool) =
            [
                if element.IsSome then yield "element" ==> unbox element.Value
                if enabled.IsSome then yield "enabled" ==> unbox enabled.Value
                if hideScrollbar.IsSome then yield "hideScrollbar" ==> unbox hideScrollbar.Value
                if preventScrollbarShiftMode.IsSome then yield "preventScrollbarShiftMode" ==> unbox preventScrollbarShiftMode.Value
                if restoreScrollPosition.IsSome then yield "restoreScrollPosition" ==> unbox restoreScrollPosition.Value
                if allowPinchZoom.IsSome then yield "allowPinchZoom" ==> unbox allowPinchZoom.Value
            ] |> createObj
            |> import "createPreventScroll" createPreventScroll
        static member inline createTransitionSize(?element : unit -> HtmlElement, ?enabled : unit -> bool, ?dimension : unit -> TransitionDimension ) : CreateTransitionSize =
            [
                if element.IsSome then yield "element" ==> unbox element.Value
                if enabled.IsSome then yield "enabled" ==> unbox enabled.Value
                if dimension.IsSome then yield "dimension" ==> unbox dimension.Value
            ] |> createObj
            |> import "createTransitionSize" createTransitionSize
