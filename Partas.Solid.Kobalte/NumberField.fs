namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


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


