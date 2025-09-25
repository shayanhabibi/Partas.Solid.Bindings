namespace Partas.Solid.ZagJs

open Browser.Types
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Erase>]
module Combobox =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Content
            | List
            | Label
            | Input
            | Root
            | Item
            | ClearTrigger
            | Control
            | ItemGroup
            | ItemGroupLabel
            | ItemIndicator
            | ItemText
            | Positioner
            | Trigger
    type ValueChangeDetails<'T> =
        abstract value: string[]
        abstract items: 'T[]
    type HighlightChangeDetails<'T> =
        abstract highlightedValue: string option
        abstract highlightedItem: 'T option
    [<StringEnum(CaseRules.KebabCase)>]
    type InputValueChangeReason =
        | InputChange
        | ItemSelect
        | ClearTrigger
        | Script
        | InteractOutside
    type InputValueChangeDetails =
        abstract inputValue: string
        abstract reason: InputValueChangeReason option
    
    [<StringEnum(CaseRules.KebabCase)>]
    type OpenChangeReason =
        | InputClick
        | TriggerClick
        | Script
        | ArrowKey
        | InputChange
        | InteractOutside
        | EscapeKey
        | ItemSelect
        | ClearTrigger
    type OpenChangeDetails =
        abstract ``open``: bool
        abstract reason: OpenChangeReason option
    type ScrollToIndexDetails =
        abstract index: int with get,set
        abstract immediate: bool option with get,set
        abstract getElement: (unit -> HTMLElement option) with get,set
    type NavigateDetails =
        abstract value: string
        abstract node: HTMLAnchorElement
        abstract href: string
    type SelectionDetails =
        abstract value: string[]
        abstract itemValue: string
    type IntlTranslations =
        abstract triggerLabel: string option
        abstract clearTriggerLabel: string option
    
    type ElementIds =
        abstract root: string
        abstract label: string
        abstract control: string
        abstract input: string
        abstract content: string
        abstract trigger: string
        abstract clearTrigger: string
        abstract item: id: string * ?index: int -> string
        abstract positioner: string
        abstract itemGroup: id: U2<string, int> -> string
        abstract itemGroupLabel: id: U2<string, int> -> string
    [<StringEnum(CaseRules.LowerAll)>]
    type InputBehavior =
        | AutoHighlight
        | AutoComplete
        | None
    [<StringEnum>]
    type SelectionBehaviour =
        | Clear
        | Replace
        | Preserve

    [<Pojo>]
    type TriggerProps(
        focusable: bool
        ) =
        member val focusable = focusable with get,set

    [<Pojo>]
    type ItemProps(
        item: obj,
        ?persistFocus: bool
        ) =
        member val item = item with get,set
        member val persistFocus = persistFocus with get,set

    [<Pojo>]
    type ItemState(
        value: string,
        disabled: bool,
        selected: bool,
        highlighted: bool
        ) =
        member val value = value with get,set
        member val disabled = disabled with get,set
        member val selected = selected with get,set
        member val highlighted = highlighted with get,set

    [<Pojo>]
    type ItemGroupProps(
        id: string
        ) =
        member val id = id with get,set

    [<Pojo>]
    type ItemGroupLabelProps(
        htmlFor: string
        ) =
        member val htmlFor = htmlFor with get,set

type ComboboxProps<'T> =
    inherit DirectionProperty
    inherit CommonProperties
    inherit InteractionOutsideHandler
    abstract ``open``: bool with get,set
    abstract defaultOpen: bool with get,set
    abstract ids: Combobox.ElementIds with get,set
    abstract inputValue: string with get,set
    abstract defaultInputValue: string with get,set
    abstract name: string with get,set
    abstract form: string with get,set
    abstract disabled: bool with get,set
    abstract readOnly: bool with get,set
    abstract invalid: bool with get,set
    abstract required: bool with get,set
    abstract placeholder: string with get,set
    abstract defaultHighlightedValue: string option with get,set
    abstract highlightedValue: string option with get,set
    abstract value: string[] with get,set
    abstract defaultValue: string[] with get,set
    abstract inputBehaviour: Combobox.InputBehavior with get,set
    abstract selectionBehaviour: Combobox.SelectionBehaviour with get,set
    abstract autoFocus: bool with get,set
    abstract openOnClick: bool with get,set
    abstract openOnChange: U2<bool, Combobox.InputValueChangeDetails -> bool> with get,set
    abstract allowCustomValue: bool with get,set
    abstract alwaysSubmitOnEnter: bool with get,set
    abstract loopFocus: bool with get,set
    abstract positioning: obj with get,set
    abstract onInputValueChange: Combobox.InputValueChangeDetails -> unit with get,set
    abstract onValueChange: Combobox.ValueChangeDetails<'T> -> unit with get,set
    abstract onHighlightChange: Combobox.HighlightChangeDetails<'T> -> unit with get,set
    abstract onSelect: Combobox.SelectionDetails -> unit with get,set
    abstract onOpenChange: Combobox.OpenChangeDetails -> unit with get,set
    abstract translations: Combobox.IntlTranslations with get,set
    abstract collection: 'T[] with get,set
    abstract multiple: bool with get,set
    abstract closeOnSelect: bool with get,set
    abstract openOnKeyPress: bool with get,set
    abstract scrollToIndexFn: Combobox.ScrollToIndexDetails -> unit with get,set
    abstract composite: bool with get,set
    abstract disableLayer: bool with get,set
    abstract navigate: (Combobox.NavigateDetails -> unit) option with get,set

type ComboboxApi<'T> =
    abstract focused: bool
    abstract ``open``: bool
    abstract inputValue: string
    abstract highlightedValue: string option
    abstract highlightedItem: 'T option
    abstract setHighlightValue: string -> unit
    abstract clearHighlightValue: unit -> unit
    abstract syncSelectedItems: unit -> unit
    abstract selectedItems: 'T[]
    abstract hasSelectedItems: bool
    abstract value: string[]
    abstract valueAsString: string
    abstract selectValue: value: string -> unit
    abstract setValue: value: string[] -> unit
    abstract clearValue: ?value: string -> unit
    abstract focus: unit -> unit
    abstract setInputValue: value: string * ?reason: Combobox.InputValueChangeReason -> unit
    abstract getItemState: props: Combobox.ItemProps -> Combobox.ItemState
    abstract setOpen: ``open``: bool * ?reason: Combobox.OpenChangeReason -> unit
    abstract collection: 'T[]
    abstract reposition: ?options: obj -> unit
    abstract multiple: bool
    abstract disabled: bool
    abstract getRootProps: unit -> HtmlTag
    abstract getLabelProps: unit -> label
    abstract getControlProps: unit -> HtmlTag
    abstract getPositionerProps: unit -> HtmlTag
    abstract getInputProps: unit -> input
    abstract getContentProps: unit -> HtmlTag
    abstract getTriggerProps: ?props: Combobox.TriggerProps -> button
    abstract getClearTriggerProps: unit -> button
    abstract getListProps: unit -> HtmlTag
    abstract getItemProps: Combobox.ItemProps -> HtmlTag
    abstract getItemTextProps: Combobox.ItemProps -> HtmlTag
    abstract getItemIndicatorProps: Combobox.ItemProps -> HtmlTag
    abstract getItemGroupProps: Combobox.ItemGroupProps -> HtmlTag
    abstract getItemGroupLabelProps: Combobox.ItemGroupLabelProps -> HtmlTag
    
        
