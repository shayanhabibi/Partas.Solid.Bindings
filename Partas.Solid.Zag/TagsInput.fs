namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types

[<Erase>]
module TagsInput =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Label
            | Input
            | Root
            | Item
            | Control
            | ClearTrigger
            | ItemPreview
            | ItemInput
            | ItemText
            | ItemDeleteTrigger
    type ValueChangeDetails =
        abstract value: string[]
    type InputValueChangeDetails =
        abstract inputValue: string
    type HighlightChangeDetails =
        abstract highlightedValue: string option
    [<StringEnum>]
    type ValidityState =
        | RangeOverflow
        | InvalidTag
    type ValidityChangeDetails =
        abstract reason: ValidityState
    type ValidateArgs =
        abstract inputValue: string with get,set
        abstract value: string[] with get,set
    type IntlTranslations =
        abstract clearTriggerLabel: string
        abstract deleteTagTriggerLabel: value: string -> string
        abstract tagSelected: value: string -> string
        abstract tagAdded: value: string -> string
        abstract tagsPasted: value: string[] -> string
        abstract tagEdited: value: string -> string
        abstract tagUpdated: value: string -> string
        abstract tagDeleted: value: string -> string
        abstract noTagsSelected: string option
        abstract inputLabel: count: int -> string
    [<TypeScriptTaggedUnion("type")>]
    type Log =
        | Add of value: string
        | Update of value: string
        | Delete of value: string
        | Select of value: string
        | Clear
        | Paste of values: string[]
        | Set of values: string[]
    [<Pojo>]
    type ItemProps(
        index: U2<string, int>,
        value: string,
        ?disabled: bool
        ) =
        member val index = index with get,set
        member val value = value with get,set
        member val disabled = disabled with get,set
    type ItemState =
        abstract id: string
        abstract editing: bool
        abstract highlighted: bool
        abstract disabled: bool
    type ElementIds =
        abstract root: string
        abstract input: string
        abstract hiddenInput: string
        abstract clearBtn: string
        abstract label: string
        abstract control: string
        abstract item: opts: ItemProps -> string
        abstract itemDeleteTrigger: opts: ItemProps -> string
        abstract itemInput: opts: ItemProps -> string
    [<StringEnum>]
    type BlurBehavior =
        | Clear
        | Add

[<Interface>]
type TagsInputProps =
    inherit DirectionProperty
    inherit CommonProperties
    inherit InteractionOutsideHandler
    /// <summary>
    /// The ids of the elements in the tags input. Useful for composition.
    /// </summary>
    abstract member ids: TagsInput.ElementIds with get, set
    /// <summary>
    /// Specifies the localized strings that identifies the accessibility elements and their states
    /// </summary>
    abstract member translations: TagsInput.IntlTranslations with get, set
    /// <summary>
    /// The max length of the input.
    /// </summary>
    abstract member maxLength: int with get, set
    /// <summary>
    /// The character that serves has:
    /// - event key to trigger the addition of a new tag
    /// - character used to split tags when pasting into the input
    /// </summary>
    abstract member delimiter: U2<string, System.Text.RegularExpressions.Regex> option with get, set
    /// <summary>
    /// Whether the input should be auto-focused
    /// </summary>
    abstract member autoFocus: bool with get, set
    /// <summary>
    /// Whether the tags input should be disabled
    /// </summary>
    abstract member disabled: bool with get, set
    /// <summary>
    /// Whether the tags input should be read-only
    /// </summary>
    abstract member readOnly: bool with get, set
    /// <summary>
    /// Whether the tags input is invalid
    /// </summary>
    abstract member invalid: bool with get, set
    /// <summary>
    /// Whether the tags input is required
    /// </summary>
    abstract member required: bool with get, set
    /// <summary>
    /// Whether a tag can be edited after creation, by pressing <c>Enter</c> or double clicking.
    /// </summary>
    abstract member editable: bool with get, set
    /// <summary>
    /// The controlled tag input's value
    /// </summary>
    abstract member inputValue: string with get, set
    /// <summary>
    /// The initial tag input value when rendered.
    /// Use when you don't need to control the tag input value.
    /// </summary>
    abstract member defaultInputValue: string with get, set
    /// <summary>
    /// The controlled tag value
    /// </summary>
    abstract member value: string[] with get, set
    /// <summary>
    /// The initial tag value when rendered.
    /// Use when you don't need to control the tag value.
    /// </summary>
    abstract member defaultValue: string[] with get, set
    /// <summary>
    /// Callback fired when the tag values is updated
    /// </summary>
    abstract member onValueChange: (TagsInput.ValueChangeDetails -> unit) with get, set
    /// <summary>
    /// Callback fired when the input value is updated
    /// </summary>
    abstract member onInputValueChange: (TagsInput.InputValueChangeDetails -> unit) with get, set
    /// <summary>
    /// Callback fired when a tag is highlighted by pointer or keyboard navigation
    /// </summary>
    abstract member onHighlightChange: (TagsInput.HighlightChangeDetails -> unit) with get, set
    /// <summary>
    /// Callback fired when the max tag count is reached or the <c>validateTag</c> function returns <c>false</c>
    /// </summary>
    abstract member onValueInvalid: (TagsInput.ValidityChangeDetails -> unit) with get, set
    /// <summary>
    /// Returns a boolean that determines whether a tag can be added.
    /// Useful for preventing duplicates or invalid tag values.
    /// </summary>
    abstract member validate: (TagsInput.ValidateArgs -> bool) with get, set
    /// <summary>
    /// The behavior of the tags input when the input is blurred
    /// - <c>"add"</c>: add the input value as a new tag
    /// - <c>"clear"</c>: clear the input value
    /// </summary>
    abstract member blurBehavior: TagsInput.BlurBehavior with get, set
    /// <summary>
    /// Whether to add a tag when you paste values into the tag input
    /// </summary>
    abstract member addOnPaste: bool with get, set
    /// <summary>
    /// The max number of tags
    /// </summary>
    abstract member max: float with get, set
    /// <summary>
    /// Whether to allow tags to exceed max. In this case,
    /// we'll attach <c>data-invalid</c> to the root
    /// </summary>
    abstract member allowOverflow: bool with get, set
    /// <summary>
    /// The name attribute for the input. Useful for form submissions
    /// </summary>
    abstract member name: string with get, set
    /// <summary>
    /// The associate form of the underlying input element.
    /// </summary>
    abstract member form: string with get, set

[<Interface>]
type TagsInputApi =
    /// <summary>
    /// Whether the tags are empty
    /// </summary>
    abstract member empty: bool with get, set
    /// <summary>
    /// The value of the tags entry input.
    /// </summary>
    abstract member inputValue: string with get, set
    /// <summary>
    /// The value of the tags as an array of strings.
    /// </summary>
    abstract member value: ResizeArray<string> with get, set
    /// <summary>
    /// The value of the tags as a string.
    /// </summary>
    abstract member valueAsString: string with get, set
    /// <summary>
    /// The number of the tags.
    /// </summary>
    abstract member count: float with get, set
    /// <summary>
    /// Whether the tags have reached the max limit.
    /// </summary>
    abstract member atMax: bool with get, set
    /// <summary>
    /// Function to set the value of the tags.
    /// </summary>
    abstract member setValue: (string[] -> unit) with get, set
    /// <summary>
    /// Function to clear the value of the tags.
    /// </summary>
    abstract member clearValue: (string option -> unit) with get, set
    /// <summary>
    /// Function to add a tag to the tags.
    /// </summary>
    abstract member addValue: (string -> unit) with get, set
    /// <summary>
    /// Function to set the value of a tag at the given index.
    /// </summary>
    abstract member setValueAtIndex: index: int * value: string -> unit with get, set
    /// <summary>
    /// Function to set the value of the tags entry input.
    /// </summary>
    abstract member setInputValue: (string -> unit) with get, set
    /// <summary>
    /// Function to clear the value of the tags entry input.
    /// </summary>
    abstract member clearInputValue: (unit -> unit) with get, set
    /// <summary>
    /// Function to focus the tags entry input.
    /// </summary>
    abstract member focus: (unit -> unit) with get, set
    /// <summary>
    /// Returns the state of a tag
    /// </summary>
    abstract member getItemState: (TagsInput.ItemProps -> TagsInput.ItemState) with get, set
