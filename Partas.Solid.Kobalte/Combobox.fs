namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Browser.Types
open Partas.Solid.Experimental.U

[<RequireQualifiedAccess; Erase>]
module Combobox =
    [<AllowNullLiteral>]
    [<Interface>]
    type DataSet =
        abstract member ``data-expanded``: string with get,set
        abstract member ``data-closed``: string with get,set
    [<AllowNullLiteral>]
    [<Interface>]
    type ControlState<'T> =
        inherit FormControlDataSet
        inherit DataSet
        abstract member selectedOptions : Accessor<'T[]> with get
        abstract member remove : ('T -> unit) with get
        abstract member clear : (unit -> unit) with get 

    /// <summary>
    /// </summary>
    /// <param name="data-valid">Present when the combobox is valid</param>
    /// <param name="data-invalid">Present when the combobox is invalid</param>
    /// <param name="data-required">Present when the combobox is required</param>
    /// <param name="data-disabled">Present when the combobox is disabled</param>
    /// <param name="data-readonly">Present when the combobox is readonly</param>
    [<Erase; Import("Control", Spec.combobox)>]
    type Control<'T>() = // v0.13.9
        inherit div()
        interface Polymorph
        interface ChildLambdaProvider<ControlState<'T>>
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
        [<Erase>] member val forceMount : bool = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when combobox is open</param>
    /// <param name="data-closed">Present when combobox is closed</param>
    [<Erase; Import("Content", Spec.combobox)>]
    type Content() = // v0.13.9
        inherit div()
        interface Polymorph
        /// <summary>
        /// Event handler called when focus moves to the trigger after closing.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<DefaultValue>]
        val mutable onCloseAutoFocus: (Event -> unit) option

        /// <summary>
        /// Event handler called when a pointer event occurs outside the bounds of the component.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<DefaultValue>]
        val mutable onPointerDownOutside: (CustomEvent<EventDetails<PointerEvent>> -> unit) option

        /// <summary>
        /// Event handler called when the focus moves outside the bounds of the component.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<DefaultValue>]
        val mutable onFocusOutside: (CustomEvent<EventDetails<FocusEvent>> -> unit) option

        /// <summary>
        /// Event handler called when an interaction (pointer or focus event) happens outside the bounds of the component.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<DefaultValue>]
        val mutable onInteractOutside: (CustomEvent<EventDetails<PointerEvent>> -> unit) option
    [<Erase; Import("Arrow", Spec.combobox)>]
    type Arrow() = // v0.13.9
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = jsNative with get,set // v0.13.9
    [<Erase; Import("Listbox", Spec.combobox)>]
    type Listbox<'T>() = // v0.13.9
        inherit div()
        interface Polymorph
        interface ChildLambdaProvider<'T[]>
        [<Erase>] member val scrollRef : Accessor<HtmlElement> = jsNative with get,set // v0.13.9
        [<Erase>] member val scrollToItem : string -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("Item", Spec.combobox)>]
    type Item<'Value>() = // v0.13.9
        inherit li()
        interface Polymorph
        [<Erase>] member val item : 'Value = jsNative with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemIndicator", Spec.combobox)>]
    type ItemIndicator() = // v0.13.9
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = jsNative with get,set
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
        interface RegularNode
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
type Combobox<'Value>() =
    inherit div()
    interface Polymorph
    [<Erase>] member val defaultFilter : ComboboxFilter = jsNative with get,set // v0.13.9
    [<Erase>] member val options : 'Value[] = jsNative with get,set // v0.13.9
    [<Erase>] member val optionValue : 'Value -> string = jsNative with get,set // v0.13.9
    [<Erase>] member val optionTextValue : 'Value -> string = jsNative with get,set // v0.13.9
    [<Erase>] member val optionLabel : 'Value -> string = jsNative with get,set // v0.13.9
    [<Erase>] member val optionDisabled : 'Value -> bool = jsNative with get,set // v0.13.9
    /// <summary>
    /// Key property that refers to children of the option group.
    /// </summary>
    [<Erase>] member val optionGroupChildren : string = jsNative with get,set // v0.13.9
    [<Erase>] member val itemComponent : ItemComponentProps<'Value> -> HtmlElement = jsNative with get,set // v0.13.9
    [<Erase>] member val sectionComponent : SectionComponentProps<'Value> -> HtmlElement = jsNative with get,set // v0.13.9
    [<Erase>] member val multiple : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val placeholder : string = jsNative with get,set // v0.13.9
    member this.placeholder' // v0.13.9
        with set(value: HtmlElement) = () // v0.13.9
        and get(): HtmlElement = unbox null // v0.13.9
    [<Erase>] member val value : 'Value = jsNative with get,set // will add an s when it is an array and reroute it to value
    member this.values // v0.13.9
        with inline set(values: 'Value[]) = this.value <- !!values // v0.13.9
        and inline get(): 'Value[] = !!this.value // v0.13.9
    [<Erase>] member val defaultValue : 'Value = jsNative with get,set // v0.13.9
    member this.defaultValues // v0.13.9
        with inline set(values: 'Value[]) = this.defaultValue <- !!values // v0.13.9
        and inline get(): 'Value[] = !!this.defaultValue // v0.13.9
    [<Erase>] member val onChange : 'Value -> unit = jsNative with get,set // v0.13.9
    member this.onChanges // v0.13.9
        with inline set(values: 'Value[] -> unit) = this.onChange <- !!values // v0.13.9
        and inline get(): 'Value[] -> unit = !!this.onChange // v0.13.9
    [<Erase>] member val open' : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val defaultOpen : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val onOpenChange : bool * TriggerMode -> unit = jsNative with get,set // v0.13.9
    [<Erase>] member val onInputChange : string -> unit = jsNative with get,set // v0.13.9
    [<Erase>] member val triggerMode : TriggerMode = jsNative with get,set // v0.13.9
    [<Erase>] member val removeOnBackspace : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val allowDuplicateSelectionEvents : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val disallowEmptySelection : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val allowsEmptyCollection : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val closeOnSelection : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val selectionBehavior : SelectionBehavior = jsNative with get,set // v0.13.9
    [<Erase>] member val virtualized : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val modal : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val preventScroll : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val forceMount : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val name : string = jsNative with get,set // v0.13.9
    [<Erase>] member val validationState : ValidationState = jsNative with get,set // v0.13.9
    [<Erase>] member val required : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val disabled : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val readOnly : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val translations : string = jsNative with get,set // v0.13.9
    [<Erase>] member val autoComplete : string = jsNative with get,set // v0.13.9
    [<Erase>] member val noResetInputOnBlur : bool = jsNative with get,set // v0.13.9

    [<Erase>] member val placement : KobaltePlacement = jsNative with get,set // v0.13.9
    [<Erase>] member val gutter : int = jsNative with get,set // v0.13.9
    [<Erase>] member val shift : int = jsNative with get,set // v0.13.9
    [<Erase>] member val flip : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val slide : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val overlap : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val sameWidth : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val fitViewport : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val hideWhenDetached : bool = jsNative with get,set // v0.13.9
    [<Erase>] member val detachedPadding : int = jsNative with get,set // v0.13.9
    [<Erase>] member val arrowPadding : int = jsNative with get,set // v0.13.9
    [<Erase>] member val overflowPadding : int = jsNative with get,set // v0.13.9

[<AutoOpen; Erase>]
module ComboboxContext =
    [<RequireQualifiedAccess; Erase>]
    module ComboboxContext =
        type open' =
            delegate of focusStrategy: U2<obj, bool> * ?triggerMode: TriggerMode -> unit

        type toggle =
            delegate of focusStrategy: U2<obj, bool> * ?triggerMode: TriggerMode -> unit


    [<AllowNullLiteral>]
    [<Interface>]
    type ComboboxContext<'Value> =
        abstract member dataset: Accessor<Combobox.DataSet> with get, set
        abstract member isOpen: Accessor<bool> with get, set
        abstract member isDisabled: Accessor<bool> with get, set
        abstract member isMultiple: Accessor<bool> with get, set
        abstract member isVirtualized: Accessor<bool> with get, set
        abstract member isModal: Accessor<bool> with get, set
        abstract member preventScroll: Accessor<bool> with get, set
        abstract member isInputFocused: Accessor<bool> with get, set
        abstract member allowsEmptyCollection: Accessor<bool> with get, set
        abstract member shouldFocusWrap: Accessor<bool> with get, set
        abstract member removeOnBackspace: Accessor<bool> with get, set
        abstract member selectedOptions: Accessor<'Value[]> with get, set
        abstract member contentPresent: Accessor<bool> with get, set
        abstract member autoFocus: Accessor<U2<obj, bool>> with get, set
        abstract member activeDescendant: Accessor<string option> with get, set
        abstract member inputValue: Accessor<string option> with get, set
        abstract member triggerMode: Accessor<TriggerMode> with get, set
        abstract member controlRef: Accessor<HTMLElement option> with get, set
        abstract member inputRef: Accessor<HTMLInputElement option> with get, set
        abstract member triggerRef: Accessor<HTMLElement option> with get, set
        abstract member contentRef: Accessor<HTMLElement option> with get, set
        abstract member listboxId: Accessor<string option> with get, set
        abstract member triggerAriaLabel: Accessor<string option> with get, set
        abstract member listboxAriaLabel: Accessor<string option> with get, set
        abstract member listState: Accessor<ListState<'Value>> with get, set
        abstract member keyboardDelegate: Accessor<KeyboardDelegate> with get, set
        abstract member resetInputValue: (Set<string> -> unit) with get, set
        abstract member setIsInputFocused: (bool -> unit) with get, set
        abstract member setInputValue: (string -> unit) with get, set
        abstract member setControlRef: (HTMLElement -> unit) with get, set
        abstract member setInputRef: (HTMLInputElement -> unit) with get, set
        abstract member setTriggerRef: (HTMLElement -> unit) with get, set
        abstract member setContentRef: (HTMLElement -> unit) with get, set
        abstract member setListboxRef: (HTMLElement -> unit) with get, set
        abstract member ``open``: ComboboxContext.open' with get, set
        abstract member close: (unit -> unit) with get, set
        abstract member toggle: ComboboxContext.toggle with get, set
        abstract member placeholder: Accessor<HtmlElement> with get, set
        abstract member renderItem: (CollectionNode<'Value> -> HtmlElement) with get, set
        abstract member renderSection: (CollectionNode<'Value> -> HtmlElement) with get, set
        abstract member removeOptionFromSelection: (obj -> unit) with get, set
        abstract member onInputKeyDown: (KeyboardEvent -> unit) with get, set
        abstract member generateId: (string -> string) with get, set
        abstract member registerListboxId: (string -> (unit -> unit)) with get, set

    [<Import("useComboboxContext", Spec.combobox)>]
    let useComboboxContext<'Value>(): ComboboxContext<'Value> = jsNative
