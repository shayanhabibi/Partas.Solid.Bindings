namespace Partas.Solid.Kobalte

open Browser.Types
open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.switch)>]
type Switch() =
    inherit div()
    interface Polymorph
    [<Erase>] member val checked' : bool = JS.undefined with get,set
    [<Erase>] member val defaultChecked : bool = JS.undefined with get,set
    [<Erase>] member val onChange : bool -> unit = JS.undefined with get,set
    [<Erase>] member val name : string = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState = JS.undefined with get,set
    [<Erase>] member val required : bool = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase>] member val readOnly : bool = JS.undefined with get,set
    [<Erase>] member val value : string = JS.undefined with get,set
    
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
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("Thumb", Spec.switch)>]
    type Thumb() =
        inherit div()
        interface Polymorph

[<Erase; AutoOpen>]
module SwitchContext =
    [<AllowNullLiteral; Interface>]
    type SwitchDataSet =
        abstract ``data-checked``: string option
    [<AllowNullLiteral; Interface>]
    type SwitchContext =
        abstract value: Accessor<string>
        abstract dataset: Accessor<SwitchDataSet>
        abstract checked': Accessor<bool>
        abstract inputRef: Accessor<HTMLInputElement option>
        abstract generateId: part: string -> string
        abstract toggle: unit -> unit
        abstract setIsChecked: isChecked: bool -> unit
        abstract setIsFocused: isFocused: bool -> unit
        abstract setInputRef: el: HTMLInputElement -> unit
    [<ImportMember(Spec.switch)>]
    let useSwitchContext(): SwitchContext = jsNative

