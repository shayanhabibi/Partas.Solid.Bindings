namespace Partas.Solid.Kobalte

open Browser.Types
open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.numberField)>]
type NumberField() =
    inherit div()
    interface Polymorph
    [<Erase>] member val value : string = JS.undefined with get,set
    [<Erase>] member val defaultValue : string = JS.undefined with get,set
    [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
    [<Erase>] member val rawValue : float = JS.undefined with get,set
    [<Erase>] member val onRawValueChange : float -> unit = JS.undefined with get,set
    [<Erase>] member val minValue : float = JS.undefined with get,set
    [<Erase>] member val maxValue : float = JS.undefined with get,set
    [<Erase>] member val step : float = JS.undefined with get,set
    [<Erase>] member val largeStep : float = JS.undefined with get,set
    [<Erase>] member val changeOnWheel : bool = JS.undefined with get,set
    [<Erase>] member val format : bool = JS.undefined with get,set
    [<Erase>] member val formatOptions : obj = JS.undefined with get,set
    [<Erase>] member val allowedInput : string = JS.undefined with get,set
    [<Erase>] member val name : string = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState = JS.undefined with get,set
    [<Erase>] member val required : bool = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase>] member val readOnly : bool = JS.undefined with get,set

[<Erase; RequireQualifiedAccess>]
module NumberField =
    [<Erase; Import("ErrorMessage", Spec.numberField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
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


[<Erase; AutoOpen>]
module NumberFieldContext =
    [<AllowNullLiteral; Interface>]
    type NumberFieldContext =
        abstract value: Accessor<U2<float option, string option>>
        abstract setValue: U2<float, string> -> unit
        abstract rawValue: Accessor<float>
        abstract generateId: string -> string
        abstract formatNumber: float -> string
        abstract format: unit -> unit
        abstract onInput: InputEvent -> unit
        abstract textValue: Accessor<string option>
        abstract minValue: Accessor<float>
        abstract maxValue: Accessor<float>
        abstract step: Accessor<float>
        abstract largeStep: Accessor<float>
        abstract changeOnWheel: Accessor<bool>
        abstract translations: Accessor<obj option>
        abstract inputRef: Accessor<HTMLInputElement option>
        abstract setInputRef: HTMLInputElement option -> unit
        abstract hiddenInputRef: Accessor<HTMLInputElement option>
        abstract setHiddenInputRef: HTMLInputElement option -> unit
        abstract varyValue: float -> unit
    [<ImportMember(Spec.numberField)>]
    let useNumberFieldContext(): NumberFieldContext = jsNative
