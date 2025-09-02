namespace Partas.Solid.Kobalte

open Browser.Types
open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.numberField)>]
type NumberField() =
    inherit div()
    interface Polymorph
    [<DefaultValue>] val mutable value : string 
    [<DefaultValue>] val mutable defaultValue : string 
    [<DefaultValue>] val mutable onChange : string -> unit 
    [<DefaultValue>] val mutable rawValue : float 
    [<DefaultValue>] val mutable onRawValueChange : float -> unit 
    [<DefaultValue>] val mutable minValue : float 
    [<DefaultValue>] val mutable maxValue : float 
    [<DefaultValue>] val mutable step : float 
    [<DefaultValue>] val mutable largeStep : float 
    [<DefaultValue>] val mutable changeOnWheel : bool 
    [<DefaultValue>] val mutable format : bool 
    [<DefaultValue>] val mutable formatOptions : obj 
    [<DefaultValue>] val mutable allowedInput : string  // regex
    [<DefaultValue>] val mutable name : string 
    [<DefaultValue>] val mutable validationState : ValidationState 
    [<DefaultValue>] val mutable required : bool 
    [<DefaultValue>] val mutable disabled : bool 
    [<DefaultValue>] val mutable readOnly : bool 

[<Erase; RequireQualifiedAccess>]
module NumberField =
    [<Erase; Import("ErrorMessage", Spec.numberField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable forceMount : bool 
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
