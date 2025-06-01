namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop

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


