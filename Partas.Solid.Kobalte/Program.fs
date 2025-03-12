namespace Partas.Solid.Kobalte

// Kobalte v0.13.8

open Partas.Solid.Polymorphism
open Partas.Solid
open Fable.Core

#nowarn 64

[<Erase; AutoOpen>]
module private Helper =
    let [<Erase; Literal>] collapsible = "@kobalte/core/collapsible"
    let [<Erase; Literal>] accordion = "@kobalte/core/accordion"
    let [<Erase; Literal>] alert = "@kobalte/core/alert"
    let [<Erase; Literal>] alertDialog = "@kobalte/core/alert-dialog"
    let [<Erase; Literal>] button = "@kobalte/core/button"
    let [<Erase; Literal>] badge = "@kobalte/core/badge"
    let [<Erase; Literal>] breadcrumbs = "@kobalte/core/breadcrumbs"
    let [<Erase; Literal>] link = "@kobalte/core/link"
    let [<Erase; Literal>] checkbox = "@kobalte/core/checkbox"
    // let [<Erase; Literal>] colorArea = "@kobalte/core/color-area"
    // let [<Erase; Literal>] colorChannelField = "@kobalte/core/color-channel-field"
    let [<Erase; Literal>] combobox = "@kobalte/core/combobox"
    let [<Erase; Literal>] contextMenu = "@kobalte/core/context-menu"
    let [<Erase; Literal>] dialog = "@kobalte/core/dialog"
    let [<Erase; Literal>] dropdownMenu = "@kobalte/core/dropdown-menu"
    let [<Erase; Literal>] fileField = "@kobalte/core/file-field"
    let [<Erase; Literal>] hoverCard = "@kobalte/core/hover-card"
    let [<Erase; Literal>] image = "@kobalte/core/image"
    let [<Erase; Literal>] menubar = "@kobalte/core/menubar"
    let [<Erase; Literal>] meter = "@kobalte/core/meter"
    let [<Erase; Literal>] navigationMenu = "@kobalte/core/navigation-menu"
    let [<Erase; Literal>] numberField = "@kobalte/core/number-field"
    let [<Erase; Literal>] pagination = "@kobalte/core/pagination"
    let [<Erase; Literal>] popover = "@kobalte/core/popover"
    let [<Erase; Literal>] progress = "@kobalte/core/progress"
    let [<Erase; Literal>] radioGroup = "@kobalte/core/radio-group"
    let [<Erase; Literal>] select = "@kobalte/core/select"
    let [<Erase; Literal>] separator = "@kobalte/core/separator"
    let [<Erase; Literal>] skeleton = "@kobalte/core/skeleton"
    let [<Erase; Literal>] slider = "@kobalte/core/slider"
    let [<Erase; Literal>] switch = "@kobalte/core/switch"
    let [<Erase; Literal>] tabs = "@kobalte/core/tabs"
    let [<Erase; Literal>] textField = "@kobalte/core/text-field"
    let [<Erase; Literal>] toast = "@kobalte/core/toast"
    let [<Erase; Literal>] tooltip = "@kobalte/core/tooltip"
    let [<Erase; Literal>] toggleButton = "@kobalte/core/toggle-button"
    let [<Erase; Literal>] toggleGroup = "@kobalte/core/toggle-group"
    let [<Erase; Literal>] I18nProvider = "@kobalte/core/i18n-provider"

[<StringEnum>]
type Orientation =
    | Horizontal
    | Vertical

[<Erase; Import("Root", button)>]
type Button() =
    inherit button()
    interface Polymorph
    member val disabled : bool = jsNative with get,set

[<Erase; Import("Root", collapsible)>]
type Collapsible() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : bool -> unit = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Collapsible =
    [<Erase; Import("Trigger", collapsible)>]
    type Trigger() =
        inherit button()
        interface Polymorph
    [<Erase; Import("Content", collapsible)>]
    type Content() =
        inherit RegularNode()
        interface Polymorph

[<Erase; Import("Root", accordion)>]
type Accordion() =
    inherit div()
    interface Polymorph
    member val value : string[] = jsNative with get,set
    member val defaultValue : string[] = jsNative with get,set
    member val onChange : string[] -> unit = jsNative with get,set
    member val multiple : bool = jsNative with get,set
    member val collapsible : bool = jsNative with get,set
    member val shouldFocusWrap : bool = jsNative with get,set
    member val class' : string = jsNative with get,set

[<Erase>]
module Accordion =
    [<Erase; Import("Item", accordion)>]
    type Item() =
        inherit RegularNode()
        interface Polymorph
        member val open' : bool = jsNative with get,set
        member val defaultOpen : bool = jsNative with get,set
        member val onOpenChange : bool -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val value : string = jsNative with get,set
    [<Erase; Import("Trigger", accordion)>]
    type Trigger() =
        // inherit Collapsible.Trigger()
        inherit button()
        interface Polymorph
    [<Erase; Import("Content", accordion)>]
    type Content() =
        // inherit Collapsible.Content()
        inherit div()
        interface Polymorph
    [<Erase; Import("Header", accordion)>]
    type Header() =
        inherit h3()
        interface Polymorph

[<Erase; Import("Root", alert)>]
type Alert() =
    inherit div()
    interface Polymorph

[<Erase; Import("Root", alertDialog)>]
type AlertDialog() =
    inherit RegularNode()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : bool -> unit = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module AlertDialog =
    [<Erase; Import("Trigger", alertDialog)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", alertDialog)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set

    [<Erase; Import("Portal", alertDialog)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Overlay", alertDialog)>]
    type Overlay() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", alertDialog)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", alertDialog)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", alertDialog)>]
    type Description() =
        inherit p()
        interface Polymorph

[<Erase; Import("Root", badge)>]
type Badge() =
    inherit span()
    interface Polymorph
    member val textValue : string = jsNative with get,set

[<Erase; AutoOpen>]
module Kobalte =
    [<Erase; Import("Root", link)>]
    type Link() =
        inherit a()
        interface Polymorph
        member val disabled : bool = jsNative with get,set

[<Erase; Import("Root", breadcrumbs)>]
type Breadcrumbs() =
    inherit nav()
    interface Polymorph
    member val separator : JSX.Element = jsNative with get,set
    member val translations : string = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Breadcrumbs =
    [<Erase; Import("Link", breadcrumbs)>]
    type Link() =
        inherit Kobalte.Link()
        interface Polymorph
        member val currrent : bool = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("Separator", breadcrumbs)>]
    type Separator() =
        inherit span()
        interface Polymorph
    
[<StringEnum>]
type ValidationState =
    | Valid
    | Invalid

[<Erase; Import("Root", checkbox)>]
type Checkbox() =
    inherit div()
    interface Polymorph
    member val checked' : bool = jsNative with get,set
    member val defaultChecked : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set
    member val indeterminate : bool = unbox null with get,set
    member val name : string = jsNative with get,set
    member val value : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set
    member val children : Fragment = jsNative with get,set
    member inline this.Checked : unit -> bool = fun _ -> this.checked'
    member inline this.Indeterminate : unit -> bool = fun _ -> this.indeterminate

[<Erase; RequireQualifiedAccess>]
module Checkbox =
    [<Erase; Import("Indicator", checkbox)>]
    type Indicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("ErrorMessage", checkbox)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", checkbox)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Description", checkbox)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Control", checkbox)>]
    type Control() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Input", checkbox)>]
    type Input() =
        inherit input()
        interface Polymorph

// UNRELEASED vvv
// [<Erase; Import("Root", colorArea)>]
// type ColorArea() =
//     inherit div()
//     member val value : string = jsNative with get,set
//     member val defaultValue : string = jsNative with get,set
//     member val colorSpace : string = jsNative with get,set
//     member val onChange : (string -> unit) = jsNative with get,set
//     member val onChangeEnd : (string -> unit) = jsNative with get,set
//     member val xChannel : string = jsNative with get,set
//     member val yChannel : string = jsNative with get,set
//     member val xName : string = jsNative with get,set
//     member val yName : string = jsNative with get,set
//     member val name : string = jsNative with get,set
//     member val validationState : ValidationState = jsNative with get,set
//     member val required : bool = jsNative with get,set
//     member val disabled : bool = jsNative with get,set
//     member val readOnly : bool = jsNative with get,set
//     member val translations : string = jsNative with get,set

// [<Erase; RequireQualifiedAccess>]
// module ColorArea =
//     [<Erase; Import("Background", colorArea)>]
//     type Background() =
//         inherit div()
//     [<Erase; Import("Thumb", colorArea)>]
//     type Thumb() =
//         inherit span()
//     [<Erase; Import("HiddenInputX", colorArea)>]
//     type HiddenInputX() =
//         inherit input()
//     [<Erase; Import("HiddenInputY", colorArea)>]
//     type HiddenInputY() =
//         inherit input()
//     [<Erase; Import("Label", colorArea)>]
//     type Label() =
//         inherit label()

// [<Erase; Import("Root", colorChannelField)>]
// type ColorChannelField() =
//     inherit div()
//     member val value : string = jsNative with get,set
//     member val defaultValue : string = jsNative with get,set
//     member val colorSpace : string = jsNative with get,set
//     member val onChange : (string -> unit) = jsNative with get,set
//     member val minValue : int = jsNative with get,set
//     member val maxValue : int = jsNative with get,set
//     member val step : int = jsNative with get,set
//     member val largeStep : int = jsNative with get,set
//     member val changeOnWheel : bool = jsNative with get,set
//     member val format : bool = jsNative with get,set
//     member val name : string = jsNative with get,set
//     member val validationState : ValidationState = jsNative with get,set
//     member val required : bool = jsNative with get,set
//     member val disabled : bool = jsNative with get,set
//     member val readOnly : bool = jsNative with get,set

// [<Erase; RequireQualifiedAccess>]
// module ColorChannelField =
//     [<Erase; Import("ErrorMessage", colorChannelField)>]
//     type ErrorMessage() =
//         inherit div()
//         member val forceMount : bool = jsNative with get,set
//     [<Erase; Import("Label", colorChannelField)>]
//     type Label() =
//         inherit label()
//     [<Erase; Import("Input", colorChannelField)>]
//     type Input() =
//         inherit input()
//     [<Erase; Import("HiddenInput", colorChannelField)>]
//     type HiddenInput() =
//         inherit input()
//     [<Erase; Import("IncrementTrigger", colorChannelField)>]
//     type IncrementTrigger() =
//         inherit Button()
//     [<Erase; Import("DecrementTrigger", colorChannelField)>]
//     type DecrementTrigger() =
//         inherit Button()
//     [<Erase; Import("Description", colorChannelField)>]
//     type Description() =
//         inherit div()
// UNRELEASED ^^^

[<Erase>]
type ComboboxFilter =
    static member inline startsWith : ComboboxFilter = unbox "startsWith"
    static member inline contains : ComboboxFilter = unbox "contains"
    static member inline endsWith : ComboboxFilter = unbox "endsWith"
    static member inline func<'T> (filter : 'T * string -> bool ) : ComboboxFilter = unbox filter

[<StringEnum>]
type TriggerMode =
    | Input
    | Focus
    | Manual

[<StringEnum>]
type SelectionBehavior  =
    | Toggle
    | Replace

[<Erase>]
type Placement =
    static member inline top : Placement = unbox "top"
    static member inline topLeft : Placement = unbox "top left"
    static member inline topRight : Placement = unbox "top right"
    static member inline bottom : Placement = unbox "bottom"
    static member inline bottomLeft : Placement = unbox "bottom left"
    static member inline bottomRight : Placement = unbox "bottom right"
    static member inline left : Placement = unbox "left"
    static member inline right : Placement = unbox "right"


[<Erase; Import("Root", combobox)>]
type Combobox() =
    inherit div()
    interface Polymorph
    member val defaultFilter : ComboboxFilter = jsNative with get,set
    member val options : 'T[] = jsNative with get,set
    member val optionValue : 'T -> string = jsNative with get,set
    member val optionTextValue : 'T -> string = jsNative with get,set
    member val optionLabel : 'T -> string = jsNative with get,set
    member val optionDisabled : 'T -> bool = jsNative with get,set
    /// <summary>
    /// Key property that refers to children of the option group.
    /// </summary>
    member val optionGroupChildren : string = jsNative with get,set
    member val itemComponent : 'T -> JSX.Element = jsNative with get,set
    member val sectionComponent : 'T -> JSX.Element = jsNative with get,set
    member val multiple : bool = jsNative with get,set
    member val placeholder : JSX.Element = jsNative with get,set
    member val value : U2<'T, 'T[]> = jsNative with get,set
    member val defaultValue : U2<'T, 'T[]> = jsNative with get,set
    member val onChange : U2<'T, 'T[]> -> unit = jsNative with get,set
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : bool * TriggerMode -> unit = jsNative with get,set
    member val onInputChange : string -> unit = jsNative with get,set
    member val triggerMode : TriggerMode = jsNative with get,set
    member val removeOnBackspace : bool = jsNative with get,set
    member val allowDuplicateSelectionEvents : bool = jsNative with get,set
    member val disallowEmptySelection : bool = jsNative with get,set
    member val allowsEmptyCollection : bool = jsNative with get,set
    member val closeOnSelection : bool = jsNative with get,set
    member val selectionBehavior : SelectionBehavior = jsNative with get,set
    member val virtualized : bool = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set
    member val translations : string = jsNative with get,set
    member val autoComplete : string = jsNative with get,set
    member val noResetInputOnBlue : bool = jsNative with get,set

    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Combobox =
    [<Erase; Import("Control", combobox)>]
    type Control() =
        inherit div()
        interface Polymorph
        member val selectedOptions : unit -> 'T[] = jsNative with get,set
        member val remove : 'T -> unit = jsNative with get,set
        member val clear : unit -> unit = jsNative with get,set
    [<Erase; Import("Trigger", combobox)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Icon", combobox)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", combobox)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Content", combobox)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", combobox)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Listbox", combobox)>]
    type Listbox() =
        inherit div()
        interface Polymorph
        member val scrollRef : unit -> HtmlElement = jsNative with get,set
        member val scrollToItem : string -> unit = jsNative with get,set
    [<Erase; Import("Item", combobox)>]
    type Item() =
        inherit li()
        interface Polymorph
        member val item : 'T = jsNative with get,set
    [<Erase; Import("ItemIndicator", combobox)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("ItemLabel", combobox)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", combobox)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Section", combobox)>]
    type Section() =
        inherit li()
        interface Polymorph
    [<Erase; Import("Label", combobox)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Description", combobox)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", combobox)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("HiddenSelect", combobox)>]
    type HiddenSelect() =
        inherit RegularNode()
        interface Polymorph
    [<Erase; Import("Input",  combobox)>]
    type Input() =
        inherit input()
        interface Polymorph
        
    
[<Erase; Import("Root", contextMenu)>]
type ContextMenu() =
    inherit RegularNode()
    interface Polymorph
    member val onOpenChange : bool -> unit = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module ContextMenu =
    [<Erase ; Import("Trigger", contextMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
        member val disabled : bool = jsNative with get,set
    [<Erase ; Import("Content", contextMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase ; Import("Arrow", contextMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase ; Import("Item", contextMenu)>]    
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", contextMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", contextMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", contextMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", contextMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set
        member val defaultChecked : bool = jsNative with get,set
        member val onChange : bool -> unit = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val indeterminate : bool = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("Sub", contextMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set
        member val defaultOpen : bool = jsNative with get,set
        member val onOpenChange : (bool -> unit) = jsNative with get,set

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("SubTrigger", contextMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", contextMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", contextMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", contextMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", contextMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", contextMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", contextMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", contextMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", contextMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    
[<Erase; Import("Root", dialog)>]
type Dialog() =
    inherit RegularNode()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val translations : string = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Dialog =
    [<Erase; Import("Trigger", dialog)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", dialog)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Overlay", dialog)>]
    type Overlay() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", dialog)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", dialog)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", dialog)>]
    type Description() =
        inherit p()
        interface Polymorph
    [<Erase; Import("Portal", dialog)>]
    type Portal() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", dropdownMenu)>]
type DropdownMenu() =
    inherit RegularNode()
    interface Polymorph
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module DropdownMenu =
    [<Erase; Import("Trigger", dropdownMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", dropdownMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", dropdownMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Item", dropdownMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", dropdownMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", dropdownMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", dropdownMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", dropdownMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set
        member val defaultChecked : bool = jsNative with get,set
        member val onChange : bool -> unit = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val indeterminate : bool = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("Sub", dropdownMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set
        member val defaultOpen : bool = jsNative with get,set
        member val onOpenChange : (bool -> unit) = jsNative with get,set

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set

    [<Erase; Import("SubTrigger", dropdownMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", dropdownMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", dropdownMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", dropdownMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", dropdownMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", dropdownMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", dropdownMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", dropdownMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", dropdownMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    
[<Erase; Import("Root", fileField)>]
type FileField() =
    inherit div()
    interface Polymorph
    member val multiple : bool = jsNative with get,set
    member val maxFiles : int = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val accept : U2<string, string[]> = jsNative with get,set
    member val allowDragAndDrop : bool = jsNative with get,set
    member val maxFileSize : int = jsNative with get,set
    member val minFileSize : int = jsNative with get,set
    member val onFileAccept : obj[] -> unit = jsNative with get,set
    member val onFileReject : obj[] -> unit = jsNative with get,set
    member val onFileChange : obj -> unit = jsNative with get,set
    member val validateFile : obj -> obj[] = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module FileField =
    [<Erase; Import("Item", fileField)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val file : obj = jsNative with get,set
    [<Erase; Import("ItemSize", fileField)>]
    type ItemSize() =
        inherit VoidNode()
        interface Polymorph
        member val precision : int = jsNative with get,set
    [<Erase; Import("ItemPreview", fileField)>]
    type ItemPreview() =
        inherit VoidNode()
        interface Polymorph
        member val type' : string = jsNative with get,set
    [<Erase; Import("Dropzone", fileField)>]
    type Dropzone() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Trigger", fileField)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Label", fileField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("HiddenInput", fileField)>]
    type HiddenInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ItemList", fileField)>]
    type ItemList() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemPreviewImage", fileField)>]
    type ItemPreviewImage() =
        inherit img()
        interface Polymorph
    [<Erase; Import("ItemName", fileField)>]
    type ItemName() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemDeleteTrigger", fileField)>]
    type ItemDeleteTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Description", fileField)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", fileField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set

[<Erase; Import("Root", hoverCard)>]
type HoverCard() =
    inherit RegularNode()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module HoverCard =
    [<Erase; Import("Trigger", hoverCard)>]
    type Trigger() =
        inherit Link()
        interface Polymorph
    [<Erase; Import("Portal", hoverCard)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Content", hoverCard)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", hoverCard)>]
    type Arrow() =
        inherit div()
        interface Polymorph

[<StringEnum>]
type LoadingStatus =
    | Idle
    | Loading
    | Loaded
    | Error

[<Erase; Import("Root", image)>]
type Image() =
    inherit RegularNode()
    interface Polymorph
    member val fallbackDelay : int = jsNative with get,set
    member val onLoadingStatusChange : LoadingStatus -> unit = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Image =
    [<Erase; Import("Fallback", image)>]
    type Fallback() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Img", image)>]
    type Img() =
        inherit img()
        interface Polymorph

[<Erase; Import("Root", menubar)>]
type Menubar() =
    inherit RegularNode()
    interface Polymorph
    member val defaultValue : string = jsNative with get,set
    member val value : string = jsNative with get,set
    member val onValueChange : string -> unit = jsNative with get,set
    member val loop : bool = jsNative with get,set
    member val focusOnAlt : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Menubar =
    [<Erase; Import("Menu", menubar)>]
    type Menu() =
        inherit div()
        interface Polymorph
        member val onOpenChange : (bool -> unit) = jsNative with get,set
        member val id : string = jsNative with get,set
        member val modal : bool = jsNative with get,set
        member val preventScroll : bool = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val value : string = jsNative with get,set

        member val placement : Placement = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val flip : bool = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val sameWidth : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("Trigger", menubar)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", menubar)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", menubar)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Item", menubar)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", menubar)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", menubar)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", menubar)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", menubar)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set
        member val defaultChecked : bool = jsNative with get,set
        member val onChange : bool -> unit = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val indeterminate : bool = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("Sub", menubar)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set
        member val defaultOpen : bool = jsNative with get,set
        member val onOpenChange : (bool -> unit) = jsNative with get,set

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("SubTrigger", menubar)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", menubar)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", menubar)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", menubar)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", menubar)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", menubar)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", menubar)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", menubar)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", menubar)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", meter)>]
type Meter() =
    inherit div()
    interface Polymorph
    member val value : int = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val getValueLabel : {| value: int ; min : int ; max : int |} -> string = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Meter =
    [<Erase; Import("Label", meter)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", meter)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", meter)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", meter)>]
    type Fill() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", navigationMenu)>]
type NavigationMenu() =
    inherit div()
    interface Polymorph
    member val defaultValue : string = jsNative with get,set
    member val value : string = jsNative with get,set
    member val onValueChange : string -> unit = jsNative with get,set
    member val loop : bool = jsNative with get,set
    member val delayDuration : int = jsNative with get,set
    member val skipDelayDuration : bool = jsNative with get,set
    member val focusOnAlt : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val gutter: int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module NavigationMenu =
    [<Erase; Import("Viewport", navigationMenu)>]
    type Viewport() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", navigationMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Menu", navigationMenu)>]
    type Menu() =
        inherit div()
        interface Polymorph
        member val onOpenChange : (bool -> unit) = jsNative with get,set
        member val id : string = jsNative with get,set
        member val modal : bool = jsNative with get,set
        member val preventScroll : bool = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val value : string = jsNative with get,set

        member val placement : Placement = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val flip : bool = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val sameWidth : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("Trigger", navigationMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", navigationMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Item", navigationMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", navigationMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", navigationMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", navigationMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", navigationMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set
        member val defaultChecked : bool = jsNative with get,set
        member val onChange : bool -> unit = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val indeterminate : bool = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("Sub", navigationMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set
        member val defaultOpen : bool = jsNative with get,set
        member val onOpenChange : (bool -> unit) = jsNative with get,set

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("SubTrigger", navigationMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", navigationMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", navigationMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", navigationMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", navigationMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", navigationMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", navigationMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", navigationMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", navigationMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", numberField)>]
type NumberField() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val rawValue : float = jsNative with get,set
    member val onRawValueChange : float -> unit = jsNative with get,set
    member val minValue : float = jsNative with get,set
    member val maxValue : float = jsNative with get,set
    member val step : float = jsNative with get,set
    member val largeStep : float = jsNative with get,set
    member val changeOnWheel : bool = jsNative with get,set
    member val format : bool = jsNative with get,set
    member val formatOptions : obj = jsNative with get,set
    member val allowedInput : string = jsNative with get,set // regex
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module NumberField =
    [<Erase; Import("ErrorMessage", numberField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", numberField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Input", numberField)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("HiddenInput", numberField)>]
    type HiddenInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("IncrementTrigger", numberField)>]
    type IncrementTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("DecrementTrigger", numberField)>]
    type DecrementTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Description", numberField)>]
    type Description() =
        inherit div()
        interface Polymorph

[<Erase>]
module pagination =
    type [<Erase>] fixedItems =
        static member inline true' : fixedItems = unbox true
        static member inline false' : fixedItems = unbox false
        static member inline noEllipsis : fixedItems = unbox "no-ellipsis"

[<Erase; Import("Root", pagination)>]
type Pagination() =
    inherit div()
    interface Polymorph
    member val page : int = jsNative with get,set
    member val defaultPage : int = jsNative with get,set
    member val onPageChange : int -> unit = jsNative with get,set
    member val count : int = jsNative with get,set
    member val siblingCount : int = jsNative with get,set
    member val showFirst : bool = jsNative with get,set
    member val showLast : bool = jsNative with get,set
    member val fixedItems : pagination.fixedItems = jsNative with get,set
    member val itemComponent : obj = jsNative with get,set
    member val ellipsisComponent : obj = jsNative with get,set
    member val disabled : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Pagination =
    [<Erase; Import("Item", pagination)>]
    type Item() =
        inherit Button()
        interface Polymorph
        member val page : int = jsNative with get,set
    [<Erase; Import("Ellipsis", pagination)>]
    type Ellipsis() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Previous", pagination)>]
    type Previous() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Next", pagination)>]
    type Next() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Items", pagination)>]
    type Items() =
        inherit div()
        interface Polymorph
    
[<Erase; Import("Root", popover)>]
type Popover() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val translations : string = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val anchorRef : unit -> HtmlElement = jsNative with get,set
    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Popover =
    [<Erase; Import("Trigger", popover)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", popover)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val gutter : int = jsNative with get,set
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", popover)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Portal", popover)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Anchor", popover)>]
    type Anchor() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", popover)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", popover)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", popover)>]
    type Description() =
        inherit p()
        interface Polymorph

[<Erase; Import("Root", progress)>]
type Progress() =
    inherit div()
    interface Polymorph
    member val value : int = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val getValueLabel : {| value: int ; min : int ; max : int |} -> string = jsNative with get,set
    member val indeterminate : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Progress =
    [<Erase; Import("Label", progress)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", progress)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", progress)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", progress)>]
    type Fill() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", radioGroup)>]
type RadioGroup() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module RadioGroup =
    [<Erase; Import("Label", radioGroup)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Description", radioGroup)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", radioGroup)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Item", radioGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("ItemInput", radioGroup)>]
    type ItemInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ItemControl", radioGroup)>]
    type ItemControl() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemIndicator", radioGroup)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemLabel", radioGroup)>]
    type ItemLabel() =
        inherit label()
        interface Polymorph
    [<Erase; Import("ItemDescription", radioGroup)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", select)>]
type Select() =
    inherit div()
    interface Polymorph
    member val options : obj[] = jsNative with get,set
    member val optionValue : obj -> int = jsNative with get,set
    member val optionTextValue : obj -> string = jsNative with get,set
    member val optionDisabled : obj -> bool = jsNative with get,set
    member val optionGroupChildren : string = jsNative with get,set
    member val itemComponent : obj = jsNative with get,set
    member val sectionComponent : obj = jsNative with get,set
    member val multiple : bool = jsNative with get,set
    member val placeholder : JSX.Element = jsNative with get,set
    member val value : obj[] = jsNative with get,set
    member val defaultValue : obj[] = jsNative with get,set
    member val onChange : obj[] -> unit = jsNative with get,set
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val allowDuplicateSelectionEvents : bool = jsNative with get,set
    member val disallowEmptySelection : bool = jsNative with get,set
    member val closeOnSelection : bool = jsNative with get,set
    member val selectionBehavior : SelectionBehavior = jsNative with get,set
    member val virtualized : bool = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set
    member val autoComplete : string = jsNative with get,set

    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Select =
    [<Erase; Import("Trigger", select)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Value", select)>]
    type Value() =
        inherit div()
        interface Polymorph
        member val selectedOption : obj = jsNative with get,set
        member val selectedOptions : obj[] = jsNative with get,set
        member val remove : obj -> unit = jsNative with get,set
        member val clear : unit -> unit = jsNative with get,set
    [<Erase; Import("Icon", select)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", select)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Content", select)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", select)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("ListBox", select)>]
    type ListBox() =
        inherit div()
        interface Polymorph
        member val scrollRef : unit -> HtmlElement = jsNative with get,set
        member val scrollToItem : string -> unit = jsNative with get,set
        member val children : obj[] -> JSX.Element = jsNative with get,set
    [<Erase; Import("Item", select)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val item : obj = jsNative with get,set
    [<Erase; Import("ItemIndicator", select)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", select)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Description", select)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", select)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Section", select)>]
    type Section() =
        inherit li()
        interface Polymorph
    [<Erase; Import("ItemLabel", select)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", select)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    [<Erase; Import("HiddenSelect", select)>]
    type HiddenSelect() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", separator)>]
type Separator() =
    inherit hr()
    interface Polymorph
    member val orientation : Orientation = jsNative with get,set

[<Erase; Import("Root", skeleton)>]
type Skeleton() =
    inherit div()
    interface Polymorph
    member val visible : bool = jsNative with get,set
    member val animate : bool = jsNative with get,set
    member val width : int = jsNative with get,set
    member val height : int = jsNative with get,set
    member val radius : int = jsNative with get,set
    member val circle : bool = jsNative with get,set
    member val children : Fragment = jsNative with get,set

[<Erase; Import("Root", slider)>]
type Slider() =
    inherit div()
    interface Polymorph
    member val value : int[] = jsNative with get,set
    member val defaultValue : int[] = jsNative with get,set
    member val onChange : int[] -> unit = jsNative with get,set
    member val onChangeEnd : int[] -> unit = jsNative with get,set
    member val inverted : bool = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val step : int = jsNative with get,set
    member val minStepsBetweenThumbs : int = jsNative with get,set
    member val getValueLabel : {| value: int[] ; min : int ; max : int |} -> string = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Slider =
    [<Erase; Import("Track", slider)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", slider)>]
    type Fill() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Thumb", slider)>]
    type Thumb() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Input", slider)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ValueLabel", slider)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Description", slider)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", slider)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", switch)>]
type Switch() =
    inherit div()
    interface Polymorph
    member val checked' : bool = jsNative with get,set
    member val defaultChecked : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set
    member val value : string = jsNative with get,set
    
    member inline this.Checked : unit -> bool = fun _ -> this.checked'

[<Erase; RequireQualifiedAccess>]
module Switch =
    [<Erase; Import("Input", switch)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("Control", switch)>]
    type Control() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Indicator", switch)>]
    type Indicator() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Label", switch)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Description", switch)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", switch)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Thumb", switch)>]
    type Thumb() =
        inherit div()
        interface Polymorph

[<StringEnum>]
type ActivationMode =
    | Automatic
    | Manual

[<Erase; Import("Root", tabs)>]
type Tabs() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val activationMode : ActivationMode = jsNative with get,set
    member val disabled : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Tabs =
    [<Erase; Import("Trigger", tabs)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("Content", tabs)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("List", tabs)>]
    type List() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Indicator", tabs)>]
    type Indicator() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", textField)>]
type TextField() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module TextField =
    [<Erase; Import("TextArea", textField)>]
    type TextArea() =
        inherit textarea()
        interface Polymorph
        member val autoResize : bool = jsNative with get,set
        member val submitOnEnter : bool = jsNative with get,set
    [<Erase; Import("ErrorMessage", textField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", textField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Input", textField)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("Description", textField)>]
    type Description() =
        inherit div()
        interface Polymorph

// [<Erase; Import("Root", toast)>]
// type Toast() =
//     inherit div()

// [<Erase; Import("toaster", toast)>]
// type toaster =
//     static member show : JSX.Element -> int = jsNative
//     static member update : int -> JSX.Element -> unit = jsNative
//     // static member promise : Promise<'T>

[<Erase; Import("Root", toggleButton)>]
type ToggleButton() =
    inherit button()
    interface Polymorph
    member val pressed : bool = jsNative with get,set
    member val defaultPressed : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set
    member val children : Fragment = jsNative with get,set

    member inline this.Pressed : unit -> bool = fun _ -> this.pressed

[<Erase; Import("Root", toggleGroup)>]
type ToggleGroup() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val multiple : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module ToggleGroup =
    [<Erase; Import("Item", toggleGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val children : Fragment = jsNative with get,set

        member val pressed : unit -> bool = jsNative with get,set

[<Erase; Import("Root", tooltip)>]
type Tooltip() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val triggerOnFocusOnly : bool = jsNative with get,set
    member val openDelay : int = jsNative with get,set
    member val skipDelayDuration : bool = jsNative with get,set
    member val closeDelay : int = jsNative with get,set
    member val ignoreSafeArea : bool = jsNative with get,set
    member val id : string = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val placement : Placement = jsNative with get,set
    member val gutter : int = jsNative with get,set
    member val shift : int = jsNative with get,set
    member val flip : bool = jsNative with get,set
    member val slide : bool = jsNative with get,set
    member val overlap : bool = jsNative with get,set
    member val sameWidth : bool = jsNative with get,set
    member val fitViewport : bool = jsNative with get,set
    member val hideWhenDetached : bool = jsNative with get,set
    member val detachedPadding : int = jsNative with get,set
    member val arrowPadding : int = jsNative with get,set
    member val overflowPadding : int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Tooltip =
    [<Erase; Import("Trigger", tooltip)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", tooltip)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
    [<Erase; Import("Arrow", tooltip)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Portal", tooltip)>]
    type Portal() =
        inherit div()
        interface Polymorph
