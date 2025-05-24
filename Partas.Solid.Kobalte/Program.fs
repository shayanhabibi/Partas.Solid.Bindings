namespace Partas.Solid.Kobalte

// Kobalte v0.13.9

open Partas.Solid.Polymorphism
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop

#nowarn 64

// ================================================== Interfaces
[<JS.Pojo>]
type CollectionItem(?``type``: CollectionType, ?key: string, ?textValue: string, ?disabled: bool) =
    [<DefaultValue>]
    val mutable ``type``: CollectionType
    [<DefaultValue>]
    val mutable key: string
    [<DefaultValue>]
    val mutable textValue: string
    [<DefaultValue>]
    val mutable disabled: bool

[<Interface; AllowNullLiteral>]
type CollectionNode<'T> =
    abstract ``type``: CollectionType
    abstract key: string
    abstract rawValue: 'T
    abstract textValue: string
    abstract disabled: bool
    abstract level: int
    abstract index: int
    abstract prevKey: string option
    abstract nextKey: string option

[<Interface; AllowNullLiteral>]
type ItemComponentProps<'T> =
    abstract item: CollectionNode<'T>
[<Interface; AllowNullLiteral>]
type SectionComponentProps<'T> =
    abstract section: CollectionNode<'T>

/// This interface provides the interfacer a yield function for a state object
[<Interface; AllowNullLiteral>]
type KobalteStateProvider<'T> = interface end

[<AutoOpen>]
module Bindings =
    type KobalteStateProvider<'T> with
        [<Erase>]
        member inline _.Yield(PARTAS_VALUE: 'T -> #HtmlElement): HtmlContainerFun = fun PARTAS_CONT -> ignore PARTAS_VALUE

// =================================================== Button
/// <summary>
/// data-disabled: present when the button is disabled
/// </summary>
[<Erase; Import("Root", Spec.button)>]
type Button() =
    inherit button()
    interface Polymorph
    member val disabled : bool = jsNative with get,set

// ========================================================== Collapsible
/// <summary></summary>
/// <param name="data-expanded">Present when the collapsible is expanded</param>
/// <param name="data-closed">Present when the collapsible is closed</param>
/// <param name="data-disabled">Present when the collapsible is disabled</param>
[<Erase; Import("Root", Spec.collapsible)>]
type Collapsible() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set // v0.13.9
    member val defaultOpen : bool = jsNative with get,set // v0.13.9
    member val onOpenChange : bool -> unit = jsNative with get,set // v0.13.9
    member val disabled : bool = jsNative with get,set // v0.13.9
    member val forceMount : bool = jsNative with get,set // v0.13.9

[<RequireQualifiedAccess; Erase>]
module Collapsible =
    /// <summary></summary>
    /// <param name="data-expanded">Present when the collapsible is expanded</param>
    /// <param name="data-closed">Present when the collapsible is closed</param>
    /// <param name="data-disabled">Present when the collapsible is disabled</param>
    [<Erase; Import("Trigger", Spec.collapsible)>]
    type Trigger() = // v0.13.9
        inherit button()
        interface Polymorph
    /// <summary></summary>
    /// <param name="data-expanded">Present when the collapsible is expanded</param>
    /// <param name="data-closed">Present when the collapsible is closed</param>
    /// <param name="data-disabled">Present when the collapsible is disabled</param>
    [<Erase; Import("Content", Spec.collapsible)>]
    type Content() = // v0.13.9
        inherit RegularNode()
        interface Polymorph
// ===================================================== Link

// We wrap this in a module due to other items named Link inheriting this
[<AutoOpen; Erase>]
module Kobalte =
    /// <summary>
    /// data-disabled: Present when the link is disabled
    /// </summary>
    [<Erase; Import("Root", Spec.link)>]
    type Link() =
        inherit a()
        interface Polymorph
        member val disabled : bool = jsNative with get,set
    
//============================================================== Accordion
[<Erase; Import("Root", Spec.accordion)>]
type Accordion() =
    inherit div()
    interface Polymorph
    member val value : string[] = jsNative with get,set //v0.13.9
    member val defaultValue : string[] = jsNative with get,set //v0.13.9
    member val onChange : string[] -> unit = jsNative with get,set //v0.13.9
    member val multiple : bool = jsNative with get,set //v0.13.9
    member val collapsible : bool = jsNative with get,set //v0.13.9
    member val shouldFocusWrap : bool = jsNative with get,set //v0.13.9

[<Erase>]
module Accordion =
    /// <summary>
    /// data-expanded: present when accordion item is expanded<br/>
    /// data-closed: present when accordion item is collapsed<br/>
    /// data-disabled: present when accordion item is disabled
    /// </summary>
    [<Erase; Import("Item", Spec.accordion)>]
    type Item() =
        inherit Collapsible()  //v0.13.9
        interface Polymorph //v0.13.9
        member val open' : bool = jsNative with get,set //v0.13.9
        member val defaultOpen : bool = jsNative with get,set //v0.13.9
        member val onOpenChange : bool -> unit = jsNative with get,set //v0.13.9
        member val disabled : bool = jsNative with get,set //v0.13.9
        member val forceMount : bool = jsNative with get,set //v0.13.9
        member val value : string = jsNative with get,set //v0.13.9
    [<Erase; Import("Trigger", Spec.accordion)>]
    type Trigger() =
        inherit Collapsible.Trigger() //v0.13.9
        // inherit button()
        interface Polymorph //v0.13.9
    [<Erase; Import("Content", Spec.accordion)>]
    type Content() =
        inherit Collapsible.Content() //v0.13.9
        // inherit div()
        interface Polymorph  //v0.13.9
    [<Erase; Import("Header", Spec.accordion)>]
    type Header() =
        inherit h3() //v0.13.9
        interface Polymorph //v0.13.9

// ============================================================ Alert
[<Erase; Import("Root", Spec.alert)>]
type Alert() =
    inherit div() //v0.13.9
    interface Polymorph //v0.13.9



// ========================================================== AlertDialog
[<Erase; Import("Root", Spec.alertDialog)>]
type AlertDialog() =
    inherit RegularNode()
    interface Polymorph
    member val open' : bool = jsNative with get,set //v0.13.9
    member val defaultOpen : bool = jsNative with get,set //v0.13.9
    member val onOpenChange : bool -> unit = jsNative with get,set //v0.13.9
    member val id : string = jsNative with get,set //v0.13.9
    member val modal : bool = jsNative with get,set //v0.13.9
    member val preventScroll : bool = jsNative with get,set //v0.13.9
    member val forceMount : bool = jsNative with get,set //v0.13.9

[<Erase; RequireQualifiedAccess>]
module AlertDialog =
    /// <summary>
    /// data-expanded: Present when the dialog is open<br/>
    /// data-closed: Present when the dialog is closed
    /// </summary>
    [<Erase; Import("Trigger", Spec.alertDialog)>]
    type Trigger() =
        inherit Button() //v0.13.9
        interface Polymorph
    /// <summary>
    /// data-expanded: Present when the dialog is open<br/>
    /// data-closed: Present when the dialog is closed
    /// </summary>
    [<Erase; Import("Content", Spec.alertDialog)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set //v0.13.9
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set //v0.13.9
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set //v0.13.9
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set //v0.13.9
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set //v0.13.9
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set //v0.13.9
    [<Erase; Import("Portal", Spec.alertDialog)>]
    type Portal() = //v0.13.9
        inherit div()
        interface Polymorph
    /// <summary>
    /// data-expanded: Present when the dialog is open<br/>
    /// data-closed: Present when the dialog is closed
    /// </summary>
    [<Erase; Import("Overlay", Spec.alertDialog)>]
    type Overlay() = //v0.13.9
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.alertDialog)>]
    type CloseButton() = //v0.13.9
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.alertDialog)>]
    type Title() = //v0.13.9
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.alertDialog)>]
    type Description() = //v0.13.9
        inherit p()
        interface Polymorph

// ======================================================== Badge
[<Erase; Import("Root", Spec.badge)>]
type Badge() =
    inherit span()
    interface Polymorph
    /// Accessible text description of the badge if child is not text
    member val textValue : string = jsNative with get,set //v0.13.9

// ========================================================= Breadcrumbs
[<Erase; Import("Root", Spec.breadcrumbs)>]
type Breadcrumbs() =
    inherit nav()
    interface Polymorph // the custom is that if a property takes an element or string, then the apostrophised version takes the element
    member val separator' : #HtmlElement = jsNative with get,set //v0.13.9
    member val separator : string = jsNative with get,set  //v0.13.9
    // member val translations : string = jsNative with get,set // todo- support  //v0.13.9

[<Erase; RequireQualifiedAccess>]
module Breadcrumbs =
    /// <summary>
    /// data-current: whether the breadcrumb link represents the current page
    /// </summary>
    [<Erase; Import("Link", Spec.breadcrumbs)>]
    type Link() =
        inherit Kobalte.Link()
        interface Polymorph
        member val currrent : bool = jsNative with get,set //v0.13.9
        member val disabled : bool = jsNative with get,set //v0.13.9
    [<Erase; Import("Separator", Spec.breadcrumbs)>]
    type Separator() = //v0.13.9
        inherit span()
        interface Polymorph

// ========================================================================== Checkbox
[<Erase>]
type CheckboxRenderProp =
    abstract checked': Accessor<bool> //v0.13.9
    abstract indeterminate: Accessor<bool> //v0.13.9
/// <summary>
/// 
/// </summary>
/// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
/// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
/// <param name="data-required">Present when the checkbox is required</param>
/// <param name="data-disabled">Present when the checkbox is disabled</param>
/// <param name="data-readonly">Present when the checkbox is readonly</param>
/// <param name="data-checked">Present when the checkbox is checked</param>
/// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
[<Erase; Import("Root", Spec.checkbox)>]
type Checkbox() =
    inherit div()
    interface Polymorph
    member val checked' : bool = jsNative with get,set //v0.13.9
    member val defaultChecked : bool = jsNative with get,set //v0.13.9
    member val onChange : bool -> unit = jsNative with get,set //v0.13.9
    member val indeterminate : bool = unbox null with get,set //v0.13.9
    member val name : string = jsNative with get,set //v0.13.9
    member val value : string = jsNative with get,set //v0.13.9
    member val validationState : ValidationState = jsNative with get,set //v0.13.9
    member val required : bool = jsNative with get,set //v0.13.9
    member val disabled : bool = jsNative with get,set //v0.13.9
    member val readOnly : bool = jsNative with get,set //v0.13.9
    member val children : CheckboxRenderProp -> #HtmlElement = jsNative with get,set  //v0.13.9

[<Erase; RequireQualifiedAccess>]
module Checkbox = //v0.13.9
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
    /// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
    /// <param name="data-required">Present when the checkbox is required</param>
    /// <param name="data-disabled">Present when the checkbox is disabled</param>
    /// <param name="data-readonly">Present when the checkbox is readonly</param>
    /// <param name="data-checked">Present when the checkbox is checked</param>
    /// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
    [<Erase; Import("Indicator", Spec.checkbox)>]
    type Indicator() = //v0.13.9
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set //v0.13.9
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
    /// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
    /// <param name="data-required">Present when the checkbox is required</param>
    /// <param name="data-disabled">Present when the checkbox is disabled</param>
    /// <param name="data-readonly">Present when the checkbox is readonly</param>
    /// <param name="data-checked">Present when the checkbox is checked</param>
    /// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
    [<Erase; Import("ErrorMessage", Spec.checkbox)>]
    type ErrorMessage() = //v0.13.9
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set //v0.13.9
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
    /// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
    /// <param name="data-required">Present when the checkbox is required</param>
    /// <param name="data-disabled">Present when the checkbox is disabled</param>
    /// <param name="data-readonly">Present when the checkbox is readonly</param>
    /// <param name="data-checked">Present when the checkbox is checked</param>
    /// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
    [<Erase; Import("Label", Spec.checkbox)>]
    type Label() = //v0.13.9
        inherit label()
        interface Polymorph
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
    /// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
    /// <param name="data-required">Present when the checkbox is required</param>
    /// <param name="data-disabled">Present when the checkbox is disabled</param>
    /// <param name="data-readonly">Present when the checkbox is readonly</param>
    /// <param name="data-checked">Present when the checkbox is checked</param>
    /// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
    [<Erase; Import("Description", Spec.checkbox)>]
    type Description() =
        inherit div() //v0.13.9
        interface Polymorph
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
    /// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
    /// <param name="data-required">Present when the checkbox is required</param>
    /// <param name="data-disabled">Present when the checkbox is disabled</param>
    /// <param name="data-readonly">Present when the checkbox is readonly</param>
    /// <param name="data-checked">Present when the checkbox is checked</param>
    /// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
    [<Erase; Import("Control", Spec.checkbox)>]
    type Control() = //v0.13.9
        inherit div()
        interface Polymorph
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data-valid">Present when the checkbox is valid according to validation rules</param>
    /// <param name="data-invalid">Present when the checkbox is invalid according to the validation rules</param>
    /// <param name="data-required">Present when the checkbox is required</param>
    /// <param name="data-disabled">Present when the checkbox is disabled</param>
    /// <param name="data-readonly">Present when the checkbox is readonly</param>
    /// <param name="data-checked">Present when the checkbox is checked</param>
    /// <param name="data-indeterminate">Present when the checkbox is indeterminate</param>
    [<Erase; Import("Input", Spec.checkbox)>]
    type Input() = //v0.13.9
        inherit input()
        interface Polymorph


// =============================================================== Combobox

    
[<RequireQualifiedAccess; Erase>]
module Combobox =
    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    [<Erase; Import("Control", Spec.combobox)>]
    type Control() = // v0.13.9
        inherit div()
        interface Polymorph
        member val selectedOptions : Accessor<'T[]> = jsNative with get,set // v0.13.9
        member val remove : 'T -> unit = jsNative with get,set // v0.13.9
        member val clear : unit -> unit = jsNative with get,set // v0.13.9
    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    /// <param name="data-expanded">Present when combobox is open</param>
    /// <param name="data-closed">Present when combobox is closed</param>
    [<Erase; Import("Trigger", Spec.combobox)>]
    type Trigger() = // v0.13.9
        inherit Button()
        interface Polymorph
    /// <param name="data-expanded">Present when combobox is open</param>
    /// <param name="data-closed">Present when combobox is closed</param>
    [<Erase; Import("Icon", Spec.combobox)>]
    type Icon() = // v0.13.9
        inherit div()
        interface Polymorph
    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    [<Erase; Import("ErrorMessage", Spec.combobox)>]
    type ErrorMessage() = // v0.13.9
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when combobox is open</param>
    /// <param name="data-closed">Present when combobox is closed</param>
    [<Erase; Import("Content", Spec.combobox)>]
    type Content() = // v0.13.9
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", Spec.combobox)>]
    type Arrow() = // v0.13.9
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set // v0.13.9
    [<Erase; Import("Listbox", Spec.combobox)>]
    type Listbox() = // v0.13.9
        inherit div()
        interface Polymorph
        member val scrollRef : Accessor<#HtmlElement> = jsNative with get,set // v0.13.9
        member val scrollToItem : string -> unit = jsNative with get,set // v0.13.9
        // member val children //TODO
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("Item", Spec.combobox)>]
    type Item() = // v0.13.9
        inherit li()
        interface Polymorph
        member val item : 'Value = jsNative with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemIndicator", Spec.combobox)>]
    type ItemIndicator() = // v0.13.9
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemLabel", Spec.combobox)>]
    type ItemLabel() = // v0.13.9
        inherit div()
        interface Polymorph
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemDescription", Spec.combobox)>]
    type ItemDescription() = // v0.13.9
        inherit div()
        interface Polymorph
    [<Erase; Import("Section", Spec.combobox)>]
    type Section() = // v0.13.9
        inherit li()
        interface Polymorph
    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    [<Erase; Import("Label", Spec.combobox)>]
    type Label() = // v0.13.9
        inherit label()
        interface Polymorph
    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    [<Erase; Import("Description", Spec.combobox)>]
    type Description() = // v0.13.9
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.combobox)>]
    type Portal() = // v0.13.9
        inherit div()
        interface Polymorph
    [<Erase; Import("HiddenSelect", Spec.combobox)>]
    type HiddenSelect() = // v0.13.9
        inherit RegularNode()
        interface Polymorph
    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    [<Erase; Import("Input",  Spec.combobox)>]
    type Input() = // v0.13.9
        inherit input()
        interface Polymorph

/// <summary>
/// </summary>
/// <param name="data-valid">Present when the combobox is valid</param>
/// <param name="data-invalid">Present when the combobox is invalid</param>
/// <param name="data-required">Present when the combobox is required</param>
/// <param name="data-disabled">Present when the combobox is disabled</param>
/// <param name="data-readonly">Present when the combobox is readonly</param>
[<Erase; Import("Root", Spec.combobox)>]
type Combobox() =
    inherit div()
    interface Polymorph
    member val defaultFilter : ComboboxFilter = jsNative with get,set // v0.13.9
    member val options : 'Value[] = jsNative with get,set // v0.13.9
    member val optionValue : 'Value -> string = jsNative with get,set // v0.13.9
    member val optionTextValue : 'Value -> string = jsNative with get,set // v0.13.9
    member val optionLabel : 'Value -> string = jsNative with get,set // v0.13.9
    member val optionDisabled : 'Value -> bool = jsNative with get,set // v0.13.9
    /// <summary>
    /// Key property that refers to children of the option group.
    /// </summary>
    member val optionGroupChildren : string = jsNative with get,set // v0.13.9
    member val itemComponent : Combobox.Item -> #HtmlElement = jsNative with get,set // v0.13.9
    member val sectionComponent : Combobox.Item -> #HtmlElement = jsNative with get,set // v0.13.9
    member val multiple : bool = jsNative with get,set // v0.13.9
    member val placeholder : string = jsNative with get,set // v0.13.9
    member this.placeholder' // v0.13.9
        with set(value: #HtmlElement) = () // v0.13.9
        and get(): #HtmlElement = unbox null // v0.13.9
    member val value : 'Value = jsNative with get,set // will add an s when it is an array and reroute it to value
    member this.values // v0.13.9
        with inline set(values: 'Value[]) = this.value <- !!values // v0.13.9
        and inline get(): 'Value[] = !!this.value // v0.13.9
    member val defaultValue : 'Value = jsNative with get,set // v0.13.9
    member this.defaultValues // v0.13.9
        with inline set(values: 'Value[]) = this.defaultValue <- !!values // v0.13.9
        and inline get(): 'Value[] = !!this.defaultValue // v0.13.9
    member val onChange : 'Value -> unit = jsNative with get,set // v0.13.9
    member this.onChanges // v0.13.9
        with inline set(values: 'Value[] -> unit) = this.onChange <- !!values // v0.13.9
        and inline get(): 'Value[] -> unit = !!this.onChange // v0.13.9
    member val open' : bool = jsNative with get,set // v0.13.9
    member val defaultOpen : bool = jsNative with get,set // v0.13.9
    member val onOpenChange : bool * TriggerMode -> unit = jsNative with get,set // v0.13.9
    member val onInputChange : string -> unit = jsNative with get,set // v0.13.9
    member val triggerMode : TriggerMode = jsNative with get,set // v0.13.9
    member val removeOnBackspace : bool = jsNative with get,set // v0.13.9
    member val allowDuplicateSelectionEvents : bool = jsNative with get,set // v0.13.9
    member val disallowEmptySelection : bool = jsNative with get,set // v0.13.9
    member val allowsEmptyCollection : bool = jsNative with get,set // v0.13.9
    member val closeOnSelection : bool = jsNative with get,set // v0.13.9
    member val selectionBehavior : SelectionBehavior = jsNative with get,set // v0.13.9
    member val virtualized : bool = jsNative with get,set // v0.13.9
    member val modal : bool = jsNative with get,set // v0.13.9
    member val preventScroll : bool = jsNative with get,set // v0.13.9
    member val forceMount : bool = jsNative with get,set // v0.13.9
    member val name : string = jsNative with get,set // v0.13.9
    member val validationState : ValidationState = jsNative with get,set // v0.13.9
    member val required : bool = jsNative with get,set // v0.13.9
    member val disabled : bool = jsNative with get,set // v0.13.9
    member val readOnly : bool = jsNative with get,set // v0.13.9
    member val translations : string = jsNative with get,set // v0.13.9
    member val autoComplete : string = jsNative with get,set // v0.13.9
    member val noResetInputOnBlur : bool = jsNative with get,set // v0.13.9

    member val placement : KobaltePlacement = jsNative with get,set // v0.13.9
    member val gutter : int = jsNative with get,set // v0.13.9
    member val shift : int = jsNative with get,set // v0.13.9
    member val flip : bool = jsNative with get,set // v0.13.9
    member val slide : bool = jsNative with get,set // v0.13.9
    member val overlap : bool = jsNative with get,set // v0.13.9
    member val sameWidth : bool = jsNative with get,set // v0.13.9
    member val fitViewport : bool = jsNative with get,set // v0.13.9
    member val hideWhenDetached : bool = jsNative with get,set // v0.13.9
    member val detachedPadding : int = jsNative with get,set // v0.13.9
    member val arrowPadding : int = jsNative with get,set // v0.13.9
    member val overflowPadding : int = jsNative with get,set // v0.13.9


        
// ====================================================================== ContextMenu
[<Erase; Import("Root", Spec.contextMenu)>]
type ContextMenu() =
    inherit RegularNode()
    interface Polymorph
    member val onOpenChange : bool -> unit = jsNative with get,set // v0.13.9
    member val id : string = jsNative with get,set // v0.13.9
    member val modal : bool = jsNative with get,set // v0.13.9
    member val preventScroll : bool = jsNative with get,set // v0.13.9
    member val forceMount : bool = jsNative with get,set // v0.13.9

    member val placement : KobaltePlacement = jsNative with get,set // v0.13.9
    member val gutter : int = jsNative with get,set // v0.13.9
    member val shift : int = jsNative with get,set // v0.13.9
    member val flip : bool = jsNative with get,set // v0.13.9
    member val slide : bool = jsNative with get,set // v0.13.9
    member val overlap : bool = jsNative with get,set // v0.13.9
    member val sameWidth : bool = jsNative with get,set // v0.13.9
    member val fitViewport : bool = jsNative with get,set // v0.13.9
    member val hideWhenDetached : bool = jsNative with get,set // v0.13.9
    member val detachedPadding : int = jsNative with get,set // v0.13.9
    member val arrowPadding : int = jsNative with get,set // v0.13.9
    member val overflowPadding : int = jsNative with get,set // v0.13.9

[<RequireQualifiedAccess; Erase>]
module ContextMenu =
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    /// <param name="data-closed">Present when the trigger is closed</param>
    /// <param name="data-disabled">Present when the trigger is disabled</param>
    [<Erase ; Import("Trigger", Spec.contextMenu)>]
    type Trigger() = // v0.13.9
        inherit Button()
        interface Polymorph
        member val disabled : bool = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase ; Import("Content", Spec.contextMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set // v0.13.9
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set // v0.13.9
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set // v0.13.9
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
    [<Erase ; Import("Arrow", Spec.contextMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase ; Import("Item", Spec.contextMenu)>]    
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
        member val closeOnSelect : bool = jsNative with get,set // v0.13.9
        member val onSelect : unit -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemIndicator", Spec.contextMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set // v0.13.9
    [<Erase; Import("RadioGroup", Spec.contextMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set // v0.13.9
        member val defaultValue : string = jsNative with get,set // v0.13.9
        member val onChange : string -> unit = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-checked">Present when the item is checked</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("RadioItem", Spec.contextMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set // v0.13.9
        member val textValue : string = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
        member val closeOnSelect : bool = jsNative with get,set // v0.13.9
        member val onSelect : unit -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-indeterminate">Present when the item is indeterminate</param>
    /// <param name="data-checked">Present when the item is checked</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("CheckboxItem", Spec.contextMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set // v0.13.9
        member val defaultChecked : bool = jsNative with get,set // v0.13.9
        member val onChange : bool -> unit = jsNative with get,set // v0.13.9
        member val textValue : string = jsNative with get,set // v0.13.9
        member val indeterminate : bool = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
        member val closeOnSelect : bool = jsNative with get,set // v0.13.9
        member val onSelect : unit -> unit = jsNative with get,set // v0.13.9
    [<Erase; Import("Sub", Spec.contextMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set // v0.13.9
        member val defaultOpen : bool = jsNative with get,set // v0.13.9
        member val onOpenChange : (bool -> unit) = jsNative with get,set // v0.13.9

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set // v0.13.9
        member val gutter : int = jsNative with get,set // v0.13.9
        member val shift : int = jsNative with get,set // v0.13.9
        member val slide : bool = jsNative with get,set // v0.13.9
        member val overlap : bool = jsNative with get,set // v0.13.9
        member val fitViewport : bool = jsNative with get,set // v0.13.9
        member val hideWhenDetached : bool = jsNative with get,set // v0.13.9
        member val detachedPadding : int = jsNative with get,set // v0.13.9
        member val arrowPadding : int = jsNative with get,set // v0.13.9
        member val overflowPadding : int = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("SubTrigger", Spec.contextMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("SubContent", Spec.contextMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set // v0.13.9
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set // v0.13.9
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set // v0.13.9
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("Icon", Spec.contextMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.contextMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.contextMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.contextMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.contextMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemLabel", Spec.contextMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemDescription", Spec.contextMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    
[<Erase; Import("Root", Spec.dialog)>]
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
    [<Erase; Import("Trigger", Spec.dialog)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.dialog)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Overlay", Spec.dialog)>]
    type Overlay() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.dialog)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.dialog)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.dialog)>]
    type Description() =
        inherit p()
        interface Polymorph
    [<Erase; Import("Portal", Spec.dialog)>]
    type Portal() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.dropdownMenu)>]
type DropdownMenu() =
    inherit RegularNode()
    interface Polymorph
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val id : string = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set

    member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
    member val placement : KobaltePlacement = jsNative with get,set
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
    [<Erase; Import("Trigger", Spec.dropdownMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.dropdownMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.dropdownMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Item", Spec.dropdownMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", Spec.dropdownMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", Spec.dropdownMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", Spec.dropdownMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", Spec.dropdownMenu)>]
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
    [<Erase; Import("Sub", Spec.dropdownMenu)>]
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

    [<Erase; Import("SubTrigger", Spec.dropdownMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", Spec.dropdownMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", Spec.dropdownMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.dropdownMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.dropdownMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.dropdownMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.dropdownMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.dropdownMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.dropdownMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    
[<Erase; Import("Root", Spec.fileField)>]
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
    [<Erase; Import("Item", Spec.fileField)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val file : obj = jsNative with get,set
    [<Erase; Import("ItemSize", Spec.fileField)>]
    type ItemSize() =
        inherit VoidNode()
        interface Polymorph
        member val precision : int = jsNative with get,set
    [<Erase; Import("ItemPreview", Spec.fileField)>]
    type ItemPreview() =
        inherit VoidNode()
        interface Polymorph
        member val type' : string = jsNative with get,set
    [<Erase; Import("Dropzone", Spec.fileField)>]
    type Dropzone() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Trigger", Spec.fileField)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Label", Spec.fileField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("HiddenInput", Spec.fileField)>]
    type HiddenInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ItemList", Spec.fileField)>]
    type ItemList() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemPreviewImage", Spec.fileField)>]
    type ItemPreviewImage() =
        inherit img()
        interface Polymorph
    [<Erase; Import("ItemName", Spec.fileField)>]
    type ItemName() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemDeleteTrigger", Spec.fileField)>]
    type ItemDeleteTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Description", Spec.fileField)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.fileField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set

[<Erase; Import("Root", Spec.hoverCard)>]
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
    member val placement : KobaltePlacement = jsNative with get,set
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
    [<Erase; Import("Trigger", Spec.hoverCard)>]
    type Trigger() =
        inherit Link()
        interface Polymorph
    [<Erase; Import("Portal", Spec.hoverCard)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Content", Spec.hoverCard)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", Spec.hoverCard)>]
    type Arrow() =
        inherit div()
        interface Polymorph



[<Erase; Import("Root", Spec.image)>]
type Image() =
    inherit RegularNode()
    interface Polymorph
    member val fallbackDelay : int = jsNative with get,set
    member val onLoadingStatusChange : LoadingStatus -> unit = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Image =
    [<Erase; Import("Fallback", Spec.image)>]
    type Fallback() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Img", Spec.image)>]
    type Img() =
        inherit img()
        interface Polymorph

[<Erase; Import("Root", Spec.menubar)>]
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
    [<Erase; Import("Menu", Spec.menubar)>]
    type Menu() =
        inherit div()
        interface Polymorph
        member val onOpenChange : (bool -> unit) = jsNative with get,set
        member val id : string = jsNative with get,set
        member val modal : bool = jsNative with get,set
        member val preventScroll : bool = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val value : string = jsNative with get,set

        member val placement : KobaltePlacement = jsNative with get,set
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
    [<Erase; Import("Trigger", Spec.menubar)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.menubar)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.menubar)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Item", Spec.menubar)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", Spec.menubar)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", Spec.menubar)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", Spec.menubar)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", Spec.menubar)>]
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
    [<Erase; Import("Sub", Spec.menubar)>]
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
    [<Erase; Import("SubTrigger", Spec.menubar)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", Spec.menubar)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", Spec.menubar)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.menubar)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.menubar)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.menubar)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.menubar)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.menubar)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.menubar)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.meter)>]
type Meter() =
    inherit div()
    interface Polymorph
    member val value : int = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val getValueLabel : {| value: int ; min : int ; max : int |} -> string = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Meter =
    [<Erase; Import("Label", Spec.meter)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.meter)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", Spec.meter)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.meter)>]
    type Fill() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.navigationMenu)>]
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
    [<Erase; Import("Viewport", Spec.navigationMenu)>]
    type Viewport() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.navigationMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Menu", Spec.navigationMenu)>]
    type Menu() =
        inherit div()
        interface Polymorph
        member val onOpenChange : (bool -> unit) = jsNative with get,set
        member val id : string = jsNative with get,set
        member val modal : bool = jsNative with get,set
        member val preventScroll : bool = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val value : string = jsNative with get,set

        member val placement : KobaltePlacement = jsNative with get,set
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
    [<Erase; Import("Trigger", Spec.navigationMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.navigationMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Item", Spec.navigationMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", Spec.navigationMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", Spec.navigationMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", Spec.navigationMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", Spec.navigationMenu)>]
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
    [<Erase; Import("Sub", Spec.navigationMenu)>]
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
    [<Erase; Import("SubTrigger", Spec.navigationMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", Spec.navigationMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", Spec.navigationMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.navigationMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.navigationMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.navigationMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.navigationMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.navigationMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.navigationMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.numberField)>]
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
    [<Erase; Import("ErrorMessage", Spec.numberField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", Spec.numberField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Input", Spec.numberField)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("HiddenInput", Spec.numberField)>]
    type HiddenInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("IncrementTrigger", Spec.numberField)>]
    type IncrementTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("DecrementTrigger", Spec.numberField)>]
    type DecrementTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Description", Spec.numberField)>]
    type Description() =
        inherit div()
        interface Polymorph

[<Erase>]
module pagination =
    type [<Erase>] fixedItems =
        static member inline true' : fixedItems = unbox true
        static member inline false' : fixedItems = unbox false
        static member inline noEllipsis : fixedItems = unbox "no-ellipsis"

[<Erase; Import("Root", Spec.pagination)>]
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
    [<Erase; Import("Item", Spec.pagination)>]
    type Item() =
        inherit Button()
        interface Polymorph
        member val page : int = jsNative with get,set
    [<Erase; Import("Ellipsis", Spec.pagination)>]
    type Ellipsis() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Previous", Spec.pagination)>]
    type Previous() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Next", Spec.pagination)>]
    type Next() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Items", Spec.pagination)>]
    type Items() =
        inherit div()
        interface Polymorph
    
[<Erase; Import("Root", Spec.popover)>]
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
    member val placement : Popover.Placement = jsNative with get,set
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
    [<Erase; Import("Trigger", Spec.popover)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.popover)>]
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
    [<Erase; Import("Arrow", Spec.popover)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Portal", Spec.popover)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Anchor", Spec.popover)>]
    type Anchor() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.popover)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.popover)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.popover)>]
    type Description() =
        inherit p()
        interface Polymorph

[<Erase; Import("Root", Spec.progress)>]
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
    [<Erase; Import("Label", Spec.progress)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.progress)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", Spec.progress)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.progress)>]
    type Fill() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.radioGroup)>]
type RadioGroup() =
    inherit div()
    interface Polymorph
    member val ref: HtmlElement = jsNative with get,set
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
    [<Erase; Import("Label", Spec.radioGroup)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Description", Spec.radioGroup)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.radioGroup)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Item", Spec.radioGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val ref : HtmlElement = jsNative with get,set
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("ItemInput", Spec.radioGroup)>]
    type ItemInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ItemControl", Spec.radioGroup)>]
    type ItemControl() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemIndicator", Spec.radioGroup)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.radioGroup)>]
    type ItemLabel() =
        inherit label()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.radioGroup)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.select)>]
type Select<'T>() =
    inherit div()
    interface Polymorph
    member val options : 'T[] = jsNative with get,set
    member val optionValue : 'T -> U3<string, float, int> = jsNative with get,set
    member val optionTextValue : 'T -> string = jsNative with get,set
    member val optionDisabled : 'T -> bool = jsNative with get,set
    member val optionGroupChildren : string = jsNative with get,set
    member val itemComponent : ItemComponentProps<'T> -> HtmlElement = jsNative with get,set
    member val sectionComponent : SectionComponentProps<'T> -> HtmlElement = jsNative with get,set
    member val multiple : bool = jsNative with get,set
    member val placeholder : HtmlElement = jsNative with get,set
    member val value : 'T = jsNative with get,set
    member this.values
        with inline set(values: 'T[]) = this.value <- !!values 
    member val defaultValue : 'T = jsNative with get,set
    member this.defaultValues
        with inline set(values: 'T[]) = this.defaultValue <- !!values
    member val onChange : 'T -> unit = jsNative with get,set
    member this.onChanges
        with inline set(handler: 'T[] -> unit) = this.onChange <- !!handler
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

    member val placement : KobaltePlacement = jsNative with get,set
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
    [<Interface; Erase>]
    type ValueState<'T> =
        abstract selectedOption: Accessor<'T>
        abstract selectedOptions: Accessor<'T[]>
        abstract remove: ('T -> unit)
        abstract clear: (unit -> unit)
    [<Erase; Import("Trigger", Spec.select)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Value", Spec.select)>]
    type Value<'T>() =
        inherit div()
        interface Polymorph
        interface KobalteStateProvider<ValueState<'T>>
        member val selectedOption : 'T Accessor = jsNative with get,set
        member val selectedOptions : 'T[] Accessor = jsNative with get,set
        member val remove : 'T -> unit = jsNative with get,set
        member val clear : unit -> unit = jsNative with get,set
    [<Erase; Import("Icon", Spec.select)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.select)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Content", Spec.select)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", Spec.select)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Listbox", Spec.select)>]
    type Listbox() =
        inherit div()
        interface Polymorph
        member val scrollRef : unit -> HtmlElement = jsNative with get,set
        member val scrollToItem : string -> unit = jsNative with get,set
        member val children : obj[] -> HtmlElement = jsNative with get,set
    [<Erase; Import("Item", Spec.select)>]
    type Item'<'T>() =
        inherit div()
        interface Polymorph
        member val item : 'T = jsNative with get,set
    type Item = Item'<obj>
    [<Erase; Import("ItemIndicator", Spec.select)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", Spec.select)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Description", Spec.select)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.select)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Section", Spec.select)>]
    type Section() =
        inherit li()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.select)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.select)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    [<Erase; Import("HiddenSelect", Spec.select)>]
    type HiddenSelect() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.separator)>]
type Separator() =
    inherit hr()
    interface Polymorph
    member val orientation : Orientation = jsNative with get,set

[<Erase; Import("Root", Spec.skeleton)>]
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

[<Erase; Import("Root", Spec.slider)>]
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
    member val getValueLabel : {| values: int[] ; min : int ; max : int |} -> string = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Slider =
    [<Erase; Import("Track", Spec.slider)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.slider)>]
    type Fill() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Thumb", Spec.slider)>]
    type Thumb() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Input", Spec.slider)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.slider)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Label", Spec.slider)>]
    type Label() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Description", Spec.slider)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.slider)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.switch)>]
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
    [<Erase; Import("Input", Spec.switch)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("Control", Spec.switch)>]
    type Control() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Indicator", Spec.switch)>]
    type Indicator() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Label", Spec.switch)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Description", Spec.switch)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.switch)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Thumb", Spec.switch)>]
    type Thumb() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.tabs)>]
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
    [<Erase; Import("Trigger", Spec.tabs)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("Content", Spec.tabs)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("List", Spec.tabs)>]
    type List() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Indicator", Spec.tabs)>]
    type Indicator() =
        inherit div()
        interface Polymorph

[<Erase; Import("Root", Spec.textField)>]
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
    [<Erase; Import("TextArea", Spec.textField)>]
    type TextArea() =
        inherit textarea()
        interface Polymorph
        member val autoResize : bool = jsNative with get,set
        member val submitOnEnter : bool = jsNative with get,set
    [<Erase; Import("ErrorMessage", Spec.textField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", Spec.textField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Input", Spec.textField)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("Description", Spec.textField)>]
    type Description() =
        inherit div()
        interface Polymorph

// [<Erase; Import("RootSpec.", toast)>]
// type Toast() =
//     inherit div()

// [<Erase; Import("toasterSpec.", toast)>]
// type toaster =
//     static member show : HtmlElement -> int = jsNative
//     static member update : int -> HtmlElement -> unit = jsNative
//     // static member promise : Promise<'T>

[<Erase; Import("Root", Spec.toggleButton)>]
type ToggleButton() =
    inherit button()
    interface Polymorph
    member val pressed : bool = jsNative with get,set
    member val defaultPressed : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set
    member val children : ToggleButton -> #HtmlElement = jsNative with get,set

    member inline this.Pressed : unit -> bool = fun _ -> this.pressed

[<Erase; Import("Root", Spec.toggleGroup)>]
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
    [<Erase; Import("Item", Spec.toggleGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val children : Fragment = jsNative with get,set

        member val pressed : unit -> bool = jsNative with get,set

[<Erase; Import("Root", Spec.tooltip)>]
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
    member val placement : KobaltePlacement = jsNative with get,set
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
    [<Erase; Import("Trigger", Spec.tooltip)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.tooltip)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.tooltip)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Portal", Spec.tooltip)>]
    type Portal() =
        inherit div()
        interface Polymorph
