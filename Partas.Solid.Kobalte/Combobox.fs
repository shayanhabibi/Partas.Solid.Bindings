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
        interface RegularNode
        interface Polymorph
        interface ChildLambdaProvider<ControlState<'T>>
    [<Erase; Import("Control", Spec.combobox)>]
    type Control() =
        inherit Control<obj>()
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
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
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
        [<Erase>]
        member val onCloseAutoFocus: (Event -> unit) option = JS.undefined with get,set

        /// <summary>
        /// Event handler called when a pointer event occurs outside the bounds of the component.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<Erase>]
        member val onPointerDownOutside: (CustomEvent<EventDetails<PointerEvent>> -> unit) option = JS.undefined with get,set

        /// <summary>
        /// Event handler called when the focus moves outside the bounds of the component.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<Erase>]
        member val onFocusOutside: (CustomEvent<EventDetails<FocusEvent>> -> unit) option = JS.undefined with get,set

        /// <summary>
        /// Event handler called when an interaction (pointer or focus event) happens outside the bounds of the component.
        /// It can be prevented by calling <c>event.preventDefault</c>.
        /// </summary>
        [<Erase>]
        member val onInteractOutside: (CustomEvent<EventDetails<PointerEvent>> -> unit) option = JS.undefined with get,set
    [<Erase; Import("Arrow", Spec.combobox)>]
    type Arrow() = // v0.13.9
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    [<Erase; Import("Listbox", Spec.combobox)>]
    type Listbox<'T>() =
        interface HtmlTag
        interface Polymorph
        interface ChildLambdaProvider<Accessor<Collection<CollectionNode<'T>>>>
        [<Erase>] member val scrollRef : Accessor<HtmlElement> = JS.undefined with get,set
        [<Erase>] member val scrollToItem : string -> unit = JS.undefined with get,set
    [<Erase; Import("Listbox", Spec.combobox)>]
    type Listbox() =
        inherit Listbox<obj>()
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("Item", Spec.combobox)>]
    type Item<'Value>() = // v0.13.9
        inherit li()
        interface Polymorph
        [<Erase>] member val item : CollectionNode<'Value> = JS.undefined with get,set
    [<Erase; Import("Item", Spec.combobox)>]
    type Item() =
        inherit Item<obj>()
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-selected">Present when the item is selected</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemIndicator", Spec.combobox)>]
    type ItemIndicator() = // v0.13.9
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
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
    [<Erase>] member val defaultFilter : ComboboxFilter = JS.undefined with get,set
    [<Erase>] member val options : 'Value[] = JS.undefined with get,set
    [<Erase>] member val optionValue : 'Value -> string = JS.undefined with get,set
    [<Erase>] member val optionTextValue : 'Value -> string = JS.undefined with get,set
    [<Erase>] member val optionLabel : 'Value -> string = JS.undefined with get,set
    [<Erase>] member val optionDisabled : 'Value -> bool = JS.undefined with get,set
    /// <summary>
    /// Key property that refers to children of the option group.
    /// </summary>
    [<Erase>] member val optionGroupChildren : string  = JS.undefined with get,set
    [<Erase>] member val itemComponent : ItemComponentProps<'Value> -> HtmlElement  = JS.undefined with get,set
    [<Erase>] member val sectionComponent : SectionComponentProps<'Value> -> HtmlElement  = JS.undefined with get,set
    [<Erase>] member val multiple : bool  = JS.undefined with get,set
    [<Erase>] member val placeholder : string  = JS.undefined with get,set
    member this.placeholder' // v0.13.9
        with set(value: HtmlElement) = () // v0.13.9
        and get(): HtmlElement = unbox null // v0.13.9
    [<Erase>] member val value : 'Value = JS.undefined with get,set
    member this.values // v0.13.9
        with inline set(values: 'Value[]) = this.value <- !!values // v0.13.9
        and inline get(): 'Value[] = !!this.value // v0.13.9
    [<Erase>] member val defaultValue : 'Value  = JS.undefined with get,set
    member this.defaultValues // v0.13.9
        with inline set(values: 'Value[]) = this.defaultValue <- !!values // v0.13.9
        and inline get(): 'Value[] = !!this.defaultValue // v0.13.9
    [<Erase>] member val onChange : 'Value -> unit = JS.undefined with get,set
    member this.onChanges // v0.13.9
        with inline set(values: 'Value[] -> unit) = this.onChange <- !!values // v0.13.9
        and inline get(): 'Value[] -> unit = !!this.onChange // v0.13.9
    [<Erase>] member val open' : bool  = JS.undefined with get,set
    [<Erase>] member val defaultOpen : bool  = JS.undefined with get,set
    [<Erase>] member val onOpenChange : bool * TriggerMode -> unit  = JS.undefined with get,set
    [<Erase>] member val onInputChange : string -> unit  = JS.undefined with get,set
    [<Erase>] member val triggerMode : TriggerMode  = JS.undefined with get,set
    [<Erase>] member val removeOnBackspace : bool  = JS.undefined with get,set
    [<Erase>] member val allowDuplicateSelectionEvents : bool  = JS.undefined with get,set
    [<Erase>] member val disallowEmptySelection : bool  = JS.undefined with get,set
    [<Erase>] member val allowsEmptyCollection : bool  = JS.undefined with get,set
    [<Erase>] member val closeOnSelection : bool  = JS.undefined with get,set
    [<Erase>] member val selectionBehavior : SelectionBehavior  = JS.undefined with get,set
    [<Erase>] member val virtualized : bool  = JS.undefined with get,set
    [<Erase>] member val modal : bool  = JS.undefined with get,set
    [<Erase>] member val preventScroll : bool  = JS.undefined with get,set
    [<Erase>] member val forceMount : bool  = JS.undefined with get,set
    [<Erase>] member val name : string  = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState  = JS.undefined with get,set
    [<Erase>] member val required : bool  = JS.undefined with get,set
    [<Erase>] member val disabled : bool  = JS.undefined with get,set
    [<Erase>] member val readOnly : bool  = JS.undefined with get,set
    [<Erase>] member val translations : string  = JS.undefined with get,set
    [<Erase>] member val autoComplete : string  = JS.undefined with get,set
    [<Erase>] member val noResetInputOnBlur : bool  = JS.undefined with get,set

    [<Erase>] member val placement : KobaltePlacement = JS.undefined with get,set
    [<Erase>] member val gutter : int = JS.undefined with get,set
    [<Erase>] member val shift : int = JS.undefined with get,set
    [<Erase>] member val flip : bool = JS.undefined with get,set
    [<Erase>] member val slide : bool = JS.undefined with get,set
    [<Erase>] member val overlap : bool = JS.undefined with get,set
    [<Erase>] member val sameWidth : bool = JS.undefined with get,set
    [<Erase>] member val fitViewport : bool = JS.undefined with get,set
    [<Erase>] member val hideWhenDetached : bool = JS.undefined with get,set
    [<Erase>] member val detachedPadding : int = JS.undefined with get,set
    [<Erase>] member val arrowPadding : int = JS.undefined with get,set
    [<Erase>] member val overflowPadding : int = JS.undefined with get,set
[<Erase; Import("Root", Spec.combobox)>]
type Combobox() = inherit Combobox<obj>()

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
