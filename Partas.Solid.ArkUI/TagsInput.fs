module Partas.Solid.ArkUI.TagsInput
open Partas.Solid
open Partas.Solid.ZagJs
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types

[<Literal>]
let private import = "@ark-ui/solid/tags-input"
[<Literal>]
let private prefix = "TagsInput."

[<Import(prefix + "Context", import)>]
type Context() =
    interface HtmlElement
    interface ChildLambdaProvider<Accessor<TagsInputApi>>

[<Import(prefix + "Root", import)>]
type Root
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] root
    /// [data-invalid]
    /// [data-readonly]
    /// [data-disabled]
    /// [data-focus]
    /// [data-empty]
    /// </code>
    /// </summary>
    () =
    interface RegularNode
    interface DirectionProperty
    interface CommonProperties
    interface InteractionOutsideHandler
    interface Polymorph
    
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

    /// <summary>
    /// The ids of the elements in the tags input. Useful for composition.
    /// </summary>
    [<Erase>]
    member val ids: TagsInput.ElementIds = JS.undefined with get , set

    /// <summary>
    /// Specifies the localized strings that identifies the accessibility elements and their states
    /// </summary>
    [<Erase>]
    member val translations: TagsInput.IntlTranslations = JS.undefined with get , set

    /// <summary>
    /// The max length of the input.
    /// </summary>
    [<Erase>]
    member val maxLength: int = JS.undefined with get , set

    /// <summary>
    /// The character that serves has:
    /// - event key to trigger the addition of a new tag
    /// - character used to split tags when pasting into the input
    /// </summary>
    /// <defaultValue>','</defaultValue>
    [<Erase>]
    member val delimiter: U2<string, System.Text.RegularExpressions.Regex> option = JS.undefined with get , set

    /// <summary>
    /// Whether the input should be auto-focused
    /// </summary>
    [<Erase>]
    member val autoFocus: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the tags input should be disabled
    /// </summary>
    [<Erase>]
    member val disabled: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the tags input should be read-only
    /// </summary>
    [<Erase>]
    member val readOnly: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the tags input is invalid
    /// </summary>
    [<Erase>]
    member val invalid: bool = JS.undefined with get , set

    /// <summary>
    /// Whether the tags input is required
    /// </summary>
    [<Erase>]
    member val required: bool = JS.undefined with get , set

    /// <summary>
    /// Whether a tag can be edited after creation, by pressing <c>Enter</c> or double clicking.
    /// </summary>
    [<Erase>]
    member val editable: bool = JS.undefined with get , set

    /// <summary>
    /// The controlled tag input's value
    /// </summary>
    [<Erase>]
    member val inputValue: string = JS.undefined with get , set

    /// <summary>
    /// The initial tag input value when rendered.
    /// Use when you don't need to control the tag input value.
    /// </summary>
    [<Erase>]
    member val defaultInputValue: string = JS.undefined with get , set

    /// <summary>
    /// The controlled tag value
    /// </summary>
    [<Erase>]
    member val value: string[] = JS.undefined with get , set

    /// <summary>
    /// The initial tag value when rendered.
    /// Use when you don't need to control the tag value.
    /// </summary>
    [<Erase>]
    member val defaultValue: string[] = JS.undefined with get , set

    /// <summary>
    /// Callback fired when the tag values is updated
    /// </summary>
    [<Erase>]
    member val onValueChange: (TagsInput.ValueChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Callback fired when the input value is updated
    /// </summary>
    [<Erase>]
    member val onInputValueChange: (TagsInput.InputValueChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Callback fired when a tag is highlighted by pointer or keyboard navigation
    /// </summary>
    [<Erase>]
    member val onHighlightChange: (TagsInput.HighlightChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Callback fired when the max tag count is reached or the <c>validateTag</c> function returns <c>false</c>
    /// </summary>
    [<Erase>]
    member val onValueInvalid: (TagsInput.ValidityChangeDetails -> unit) = JS.undefined with get , set

    /// <summary>
    /// Returns a boolean that determines whether a tag can be added.
    /// Useful for preventing duplicates or invalid tag values.
    /// </summary>
    [<Erase>]
    member val validate: (TagsInput.ValidateArgs -> bool) = JS.undefined with get , set

    /// <summary>
    /// The behavior of the tags input when the input is blurred
    /// - <c>"add"</c>: add the input value as a new tag
    /// - <c>"clear"</c>: clear the input value
    /// </summary>
    [<Erase>]
    member val blurBehavior: TagsInput.BlurBehavior = JS.undefined with get , set

    /// <summary>
    /// Whether to add a tag when you paste values into the tag input
    /// </summary>
    [<Erase>]
    member val addOnPaste: bool = JS.undefined with get , set

    /// <summary>
    /// The max number of tags
    /// </summary>
    [<Erase>]
    member val max: float = JS.undefined with get , set

    /// <summary>
    /// Whether to allow tags to exceed max. In this case,
    /// we'll attach <c>data-invalid</c> to the root
    /// </summary>
    [<Erase>]
    member val allowOverflow: bool = JS.undefined with get , set

    /// <summary>
    /// The name attribute for the input. Useful for form submissions
    /// </summary>
    [<Erase>]
    member val name: string = JS.undefined with get , set

    /// <summary>
    /// The associate form of the underlying input element.
    /// </summary>
    [<Erase>]
    member val form: string = JS.undefined with get , set

[<Import(prefix + "ClearTrigger", import)>]
type ClearTrigger
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] clear-trigger
    /// [data-readonly]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
    
[<Import(prefix + "Control", import)>]
type Control
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] control
    /// [data-disabled]
    /// [data-readonly]
    /// [data-invalid]
    /// [data-focus]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "HiddenInput", import)>]
type HiddenInput() =
    inherit input()
    interface Polymorph
    [<Erase>]
    member val asChild: input -> HtmlElement = undefined with get,set
[<Import(prefix + "Input", import)>]
type Input
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] input
    /// [data-invalid]
    /// [data-readonly]
    /// </code>
    /// </summary>
    () =
    inherit input()
    interface Polymorph
    [<Erase>]
    member val asChild: input -> HtmlElement = undefined with get,set
[<Import(prefix + "ItemDeleteTrigger", import)>]
type ItemDeleteTrigger() =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
[<Import(prefix + "ItemInput", import)>]
type ItemInput() =
    inherit input()
    interface Polymorph
    [<Erase>]
    member val asChild: input -> HtmlElement = undefined with get,set
[<Import(prefix + "ItemPreview", import)>]
type ItemPreview
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] item-preview
    /// [data-value]
    /// [data-disabled]
    /// [data-highlighted]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "Item", import)>]
type Item
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] item
    /// [data-value]
    /// [data-disabled]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val index: U2<string, int> = undefined with get,set
    [<Erase>]
    member val value: string = undefined with get,set
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
    [<Erase>]
    member val disabled: bool = undefined with get,set

[<Import(prefix + "ItemText", import)>]
type ItemText
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] item-text
    /// [data-disabled]
    /// [data-highlighted]
    /// </code>
    /// </summary>
    () =
    inherit span()
    interface Polymorph
    [<Erase>]
    member val asChild: span -> HtmlElement = undefined with get,set

[<Import(prefix + "Label", import)>]
type Label
    /// <summary>
    /// <code>
    /// [data-scope] tags-input
    /// [data-part] label
    /// [data-disabled]
    /// [data-invalid]
    /// [data-readonly]
    /// </code>
    /// </summary>
    () =
    inherit label()
    interface Polymorph
    [<Erase>]
    member val asChild: label -> HtmlElement = undefined with get,set

[<Import(prefix + "RootProvider", import)>]
type RootProvider() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val value: Accessor<TagsInputApi> = undefined with get,set
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
