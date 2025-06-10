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
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("Content", disclosure)>]
    type Content() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable forceMount : bool
        [<DefaultValue>] val mutable contextId : string

[<Erase; Import("Root", disclosure)>]
type Disclosure() =
    interface RegularNode
    [<DefaultValue>] val mutable expanded : bool
    [<DefaultValue>] val mutable onExpandedChange : bool -> unit
    [<DefaultValue>] val mutable intialExpanded : bool
    [<DefaultValue>] val mutable collapseBehavior : CollapseBehavior
    [<DefaultValue>] val mutable onContentPresentChange : bool -> unit
    [<DefaultValue>] val mutable disclosureId : string
    [<DefaultValue>] val mutable contextId : string

[<RequireQualifiedAccess>]
module [<Erase>] Accordion =
    [<Erase; Import("Item", accordion)>]
    type Item() =
        inherit Disclosure()
        [<DefaultValue>] val mutable value : string
        [<DefaultValue>] val mutable disabled : bool
        [<DefaultValue>] val mutable triggerId : string
        [<DefaultValue>] val mutable as' : JSX.Element

    [<Erase; Import("Trigger", accordion)>]
    type Trigger() =
        inherit Disclosure.Trigger()
    [<Erase; Import("Content", accordion)>]
    type Content() =
        inherit Disclosure.Content()

[<Erase; Import("Root", accordion)>]
type Accordion() =
    interface RegularNode
    [<DefaultValue>] val mutable multiple : bool
    [<DefaultValue>] val mutable value : U2<string, string[]>
    [<DefaultValue>] val mutable onValueChange : U2<string, string[]> -> unit
    [<DefaultValue>] val mutable initialValue : U2<string, string[]> -> unit
    [<DefaultValue>] val mutable collapsible : bool
    [<DefaultValue>] val mutable disabled : bool
    [<DefaultValue>] val mutable orientation : Orientation
    [<DefaultValue>] val mutable loop : bool
    [<DefaultValue>] val mutable textDirection : TextDirection
    [<DefaultValue>] val mutable collapseBehavior : CollapseBehavior
    [<DefaultValue>] val mutable contextId : string

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
    [<DefaultValue>] val mutable mode : CalendarMode
    [<DefaultValue>] val mutable value : U3<DateTime, DateTime[], {| from:DateTime; ``to``:DateTime |}>
    [<DefaultValue>] val mutable onValueChange : U3<DateTime, DateTime[], {|from:DateTime;``to``:DateTime|}> -> unit
    [<DefaultValue>] val mutable initialValue : U3<DateTime, DateTime[], {| from:DateTime;``to``:DateTime |}>
    [<DefaultValue>] val
    [<DefaultValue>] val mutable onMonthChange : DateTime -> unit
    [<DefaultValue>] val mutable initialMonth : DateTime
    [<DefaultValue>] val mutable focusedDay : DateTime
    [<DefaultValue>] val mutable onFocusedDayChange : DateTime -> unit
    [<DefaultValue>] val mutable initialFocusedDay : DateTime
    [<DefaultValue>] val mutable startOfWeek : day
    [<DefaultValue>] val mutable required : bool
    [<DefaultValue>] val mutable disabled : DateTime -> bool
    [<DefaultValue>] val mutable numberOfMonths : int
    [<DefaultValue>] val mutable disableOutsideDays : bool
    [<DefaultValue>] val mutable fixedWeeks : bool
    [<DefaultValue>] val mutable textDirection : TextDirection
    [<DefaultValue>] val mutable min : int
    [<DefaultValue>] val mutable max : int
    [<DefaultValue>] val mutable excludeDisabled : bool
    [<DefaultValue>] val mutable labelIds : string[]
    [<DefaultValue>] val mutable contextId : string


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
        [<DefaultValue>] val mutable index : int
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("Nav", calendar)>]
    type Nav() =
        interface RegularNode
        [<DefaultValue>] val mutable action : Action
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("Table", calendar)>]
    type Table() =
        interface RegularNode
        [<DefaultValue>] val mutable index : int
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("HeadCell", calendar)>]
    type HeadCell() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
    [<Erase; Import("Cell", calendar)>]
    type Cell() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
    [<Erase; Import("CellTrigger", calendar)>]
    type CellTrigger() =
        interface RegularNode
        [<DefaultValue>] val mutable day : DateTime
        [<DefaultValue>] val mutable month : DateTime
        [<DefaultValue>] val mutable contextId : string
        [<DefaultValue>] val mutable as' : JSX.Element

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
    [<DefaultValue>] val mutable role : DialogRole
    [<DefaultValue>] val mutable open' : bool
    [<DefaultValue>] val mutable onOpenChange : bool -> unit
    [<DefaultValue>] val mutable initialOpen : bool
    [<DefaultValue>] val mutable modal : bool
    [<DefaultValue>] val mutable closeOnEscapeKeyDown : bool
    [<DefaultValue>] val mutable onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit
    [<DefaultValue>] val mutable closeOnOutsideFocus : bool
    [<DefaultValue>] val mutable closeOnOutsidePointerStrategy : PointerStrategy
    [<DefaultValue>] val mutable onOutsideFocus : Browser.Types.CustomEvent -> unit
    [<DefaultValue>] val mutable onOutsidePointer : Browser.Types.PointerEvent -> unit
    [<DefaultValue>] val mutable noOutsidePointerEvents : bool
    [<DefaultValue>] val mutable preventScroll : bool
    [<DefaultValue>] val mutable hideScrollbar : bool
    [<DefaultValue>] val mutable preventScrollbarShift : bool
    [<DefaultValue>] val mutable preventScrollbarShiftMode : ScrollbarShiftMode
    [<DefaultValue>] val mutable restoreScrollPosition : bool
    [<DefaultValue>] val mutable allowPinchZoom : bool
    [<DefaultValue>] val mutable trapFocus : bool
    [<DefaultValue>] val mutable restoreFocus : bool
    [<DefaultValue>] val mutable initialFocusEl : JSX.Element
    [<DefaultValue>] val mutable onInitialFocus : Browser.Types.Event -> unit
    [<DefaultValue>] val mutable finalFocusEl : JSX.Element
    [<DefaultValue>] val mutable onFinalFocus : Browser.Types.Event -> unit
    [<DefaultValue>] val mutable onContentPresentChange : bool -> unit
    [<DefaultValue>] val mutable onOverlayPresentChange : bool -> unit
    [<DefaultValue>] val mutable dialogId : string
    [<DefaultValue>] val mutable labelId : string
    [<DefaultValue>] val mutable descriptionId : string
    [<DefaultValue>] val mutable contextId : string
    
[<RequireQualifiedAccess; Erase>]
module Dialog =
    [<Erase; Import("Trigger", dialog)>]
    type Trigger() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
        
    [<Erase ; Import("Portal", dialog)>]
    type Portal() =
        interface RegularNode
        [<DefaultValue>] val mutable forceMount : bool
        [<DefaultValue>] val mutable contextId : string
    
    [<Erase; Import("Overlay", dialog)>]
    type Overlay() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable forceMount : bool
        [<DefaultValue>] val mutable contextId : string
    
    [<Erase; Import("Content", dialog)>]
    type Content() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable forceMount : bool
        [<DefaultValue>] val mutable contextId : string
    
    [<Erase; Import("Close", dialog)>]
    type Close() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId: string
    
    [<Erase; Import("Label", dialog)>]
    type Label() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    
    [<Erase; Import("Description", dialog)>]
    type Description() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string

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
    [<DefaultValue>] val mutable snapPoints : float[]
    [<DefaultValue>] val mutable breakPoints : float[]
    [<DefaultValue>] val mutable defaultSnapPoint : float
    [<DefaultValue>] val mutable activeSnapPoint : float
    [<DefaultValue>] val mutable onActiveSnapPointChange : float -> unit
    [<DefaultValue>] val mutable side : Side
    [<DefaultValue>] val mutable dampFunction : int -> int
    [<DefaultValue>] val mutable velocityFunction : int * int -> int
    [<DefaultValue>] val mutable velocityCacheReset : int
    [<DefaultValue>] val mutable allowSkippingSnapPoints : bool
    [<DefaultValue>] val mutable handleScrollableElements : bool
    [<DefaultValue>] val mutable transitionResize : bool

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
    [<DefaultValue>] val mutable
    [<DefaultValue>] val mutable
    [<DefaultValue>] val mutable
    [<DefaultValue>] val mutable
    [<DefaultValue>] val mutable
    [<DefaultValue>] val mutable activeSlots:
    [<DefaultValue>] val mutable

[<Erase; Import("Root", otpField)>]
type OtpField() =
    interface RegularNode
    [<DefaultValue>] val mutable maxLength : int
    [<DefaultValue>] val mutable value : string
    [<DefaultValue>] val mutable onValueChange : string -> unit
    [<DefaultValue>] val mutable onComplete : string -> unit
    [<DefaultValue>] val mutable shiftPWManagers : bool
    [<DefaultValue>] val mutable contextId: string
    [<DefaultValue>] val mutable as' : string
    [<ImportMember(otpField)>]
    static member useContext (): OtpFieldContext = jsNative
    
[<Erase; RequireQualifiedAccess>]
module OtpField =
    [<Erase; Import("Input", otpField)>]
    type Input() =
        interface RegularNode
        [<DefaultValue>] val mutable pattern : string
        [<DefaultValue>] val mutable noScriptCSSFallback : string
        [<DefaultValue>] val mutable contextId : string
        [<DefaultValue>] val mutable as' : string

[<StringEnum>]
type PositionStrategy =
    | Absolute
    | Sticky

[<Erase; Import("Root", popover)>]
type Popover() =
    inherit Dialog()
    [<DefaultValue>] val mutable placement : Side
    [<DefaultValue>] val mutable strategy : PositionStrategy
    [<DefaultValue>] val mutable floatingOptions : {| flip : bool ; shift : bool |}

[<Erase; RequireQualifiedAccess>]
module Popover =
    [<Erase; Import("Anchor", popover)>]
    type Anchor() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
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
        [<DefaultValue>] val mutable size : int
        [<DefaultValue>] val mutable as' : JSX.ElementType
        [<DefaultValue>] val mutable contextId : string
    
[<Erase; Import("Root", resizable)>]
type Resizable() =
    interface RegularNode
    [<DefaultValue>] val mutable orientation : Orientation
    [<DefaultValue>] val mutable sizes : float[]
    [<DefaultValue>] val mutable onSizesChange : float[] -> unit
    [<DefaultValue>] val mutable initialSizes : float[]
    [<DefaultValue>] val mutable keyboardDelta : float
    [<DefaultValue>] val mutable handleCursorStyle : bool
    [<DefaultValue>] val mutable as' : JSX.Element
    [<DefaultValue>] val mutable contextId : string

type [<Erase>] DefaultTruth =
    static member inline true' : DefaultTruth = unbox true
    static member inline false' : DefaultTruth = unbox false
    static member inline only : DefaultTruth = unbox "only"

[<Erase; RequireQualifiedAccess>]
module Resizable =
    [<Erase; Import("Panel", resizable)>]
    type Panel() =
        interface RegularNode
        [<DefaultValue>] val mutable initialSize : float
        [<DefaultValue>] val mutable minSize : float
        [<DefaultValue>] val mutable maxSize : float
        [<DefaultValue>] val mutable collapsible : bool
        [<DefaultValue>] val mutable collapsedSize : float
        [<DefaultValue>] val mutable collapseThreshold : float
        [<DefaultValue>] val mutable onResize : float -> unit
        [<DefaultValue>] val mutable onCollapse : float -> unit
        [<DefaultValue>] val mutable onExpand : float -> unit
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
        [<DefaultValue>] val mutable panelId : string
    
    [<Erase; Import("Handle", resizable)>]
    type Handle() =
        interface RegularNode
        [<DefaultValue>] val mutable startIntersection : bool
        [<DefaultValue>] val mutable endIntersection : bool
        [<DefaultValue>] val mutable altKey : DefaultTruth
        [<DefaultValue>] val mutable onHandleDragStart : Browser.Types.PointerEvent -> unit
        [<DefaultValue>] val mutable onHandleDrag : Browser.Types.CustomEvent -> unit
        [<DefaultValue>] val mutable onHandleDragEnd : Browser.Types.PointerEvent -> unit
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string

[<Erase; Import("Root", tooltip)>]
type Tooltip() =
    interface RegularNode
    [<DefaultValue>] val mutable open' : bool
    [<DefaultValue>] val mutable onOpenChange : bool -> unit
    [<DefaultValue>] val mutable initialOpen : bool
    [<DefaultValue>] val mutable placement : Side
    [<DefaultValue>] val mutable strategy : PositionStrategy
    [<DefaultValue>] val mutable floatingOptions : {| flip : bool ; shift : bool |}
    [<DefaultValue>] val mutable openDelay : int
    [<DefaultValue>] val mutable closeDelay : int
    [<DefaultValue>] val mutable skipDelayDuration : int
    [<DefaultValue>] val mutable hoverableContent : bool
    [<DefaultValue>] val mutable group : string
    [<DefaultValue>] val mutable openOnFocus : bool
    [<DefaultValue>] val mutable onFocus : Browser.Types.FocusEvent -> unit
    [<DefaultValue>] val mutable onBlue : Browser.Types.FocusEvent -> unit
    [<DefaultValue>] val mutable openOnHover : bool
    [<DefaultValue>] val mutable onHover : Browser.Types.MouseEvent -> unit
    [<DefaultValue>] val mutable onLeave : Browser.Types.MouseEvent -> unit
    [<DefaultValue>] val mutable closeOnEscapeKeyDown : bool
    [<DefaultValue>] val mutable onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit
    [<DefaultValue>] val mutable closeOnPointerDown : bool
    [<DefaultValue>] val mutable onPointerDown : Browser.Types.MouseEvent -> unit
    [<DefaultValue>] val mutable closeOnScroll : bool
    [<DefaultValue>] val mutable onScroll : Browser.Types.Event -> unit
    [<DefaultValue>] val mutable onContentPresentChange : bool -> unit
    [<DefaultValue>] val mutable tooltipId : string
    [<DefaultValue>] val mutable contextId : string

[<RequireQualifiedAccess; Erase>]
module Tooltip =
    [<Erase; Import("Anchor", tooltip)>]
    type Anchor() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("Trigger", tooltip)>]
    type Trigger() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("Portal", tooltip)>]
    type Portal() =
        interface RegularNode
        [<DefaultValue>] val mutable forceMount: bool
        [<DefaultValue>] val mutable contextId : string
    [<Erase; Import("Content", tooltip)>]
    type Content() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
        [<DefaultValue>] val mutable forceMount: bool
    [<Erase; Import("Arrow", tooltip)>]
    type Arrow() =
        interface RegularNode
        [<DefaultValue>] val mutable as' : JSX.Element
        [<DefaultValue>] val mutable contextId : string
        [<DefaultValue>] val mutable size: int
    
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
        [<DefaultValue>] val mutable enabled : bool
        [<DefaultValue>] val mutable dismissibleId : string
        [<DefaultValue>] val mutable element : HtmlElement
        [<DefaultValue>] val mutable onDismiss : DismissReason -> unit
        [<DefaultValue>] val mutable dismissOnEscapeKeyDown : bool
        [<DefaultValue>] val mutable dismissOnOutsideFocus : bool
        [<DefaultValue>] val mutable dismissOnOutsidePointer : bool
        [<DefaultValue>] val mutable outsidePointerStrategy : PointerStrategy
        [<DefaultValue>] val mutable outsidePointerIgnore : HtmlElement
        [<DefaultValue>] val mutable noOutsidePointerEvents : bool
        [<DefaultValue>] val mutable onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit
        [<DefaultValue>] val mutable onOutsidePointer : Browser.Types.PointerEvent -> unit
        [<DefaultValue>] val mutable onOutsideFocus : Browser.Types.CustomEvent -> unit
    
    [<Global; AllowNullLiteral>]
    type CreateListResult [<ParamObject; Emit("$0")>]
        (
            active : unit -> 'T,
            setActive : 'T -> unit,
            onKeyDown : Browser.Types.KeyboardEvent -> unit
        ) =
        [<DefaultValue>] val mutable active : unit -> 'T
        [<DefaultValue>] val mutable setActive : 'T -> unit
        [<DefaultValue>] val mutable onKeyDown : Browser.Types.KeyboardEvent -> unit
    
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
        [<DefaultValue>] val mutable cursor : unit -> 'T
        [<DefaultValue>] val mutable setCursor : 'T -> unit
        [<DefaultValue>] val mutable active : unit -> 'T[]
        [<DefaultValue>] val mutable setActive : 'T[] -> unit
        [<DefaultValue>] val mutable selected : unit -> 'T[]
        [<DefaultValue>] val mutable setSelected : 'T[] -> unit
        [<DefaultValue>] val mutable onKeyDown : Browser.Types.KeyboardEvent -> unit
        [<DefaultValue>] val mutable setCursorActive : 'T -> unit
        [<DefaultValue>] val mutable toggleSelected : 'T -> unit
    [<Global; AllowNullLiteral>]
    type CreatePersistentComponentResult [<ParamObject; Emit("$0")>]
        (
            persistedComponent : JSX.Element
        ) =
        [<DefaultValue>] val mutable persistedComponent : JSX.Element
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
        [<DefaultValue>] val mutable present : unit -> bool
        [<DefaultValue>] val mutable state : unit -> PresenceState

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
        [<DefaultValue>] val mutable transitionSize : unit -> float[]
        [<DefaultValue>] val mutable transitioning : unit -> bool

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
