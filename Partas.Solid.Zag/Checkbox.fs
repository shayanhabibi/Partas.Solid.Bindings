namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Erase>]
module Checkbox =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Root
            | Label
            | Control
            | Indicator
    [<StringEnum>]
    type CheckedState =
        | Indeterminate
    type CheckedChangeDetails =
        abstract ``checked``: U2<bool, CheckedState>
    type ElementIds =
        abstract root: string
        abstract hiddenInput: string
        abstract control: string
        abstract label: string

type CheckboxProps =
    inherit DirectionProperty
    inherit CommonProperties
    abstract ids: Checkbox.ElementIds with get,set
    abstract disabled: bool with get,set
    abstract invalid: bool with get,set
    abstract required: bool with get,set
    abstract ``checked``: U2<bool,Checkbox.CheckedState> with get,set
    abstract defaultChecked: U2<bool, Checkbox.CheckedState> with get,set
    abstract readOnly: bool with get,set
    abstract onCheckedChange: Checkbox.CheckedChangeDetails -> unit with get,set
    abstract name: string with get,set
    abstract form: string with get,set
    abstract value: string with get,set

type CheckboxApi =
    abstract ``checked``: bool
    abstract disabled: bool
    abstract indeterminate: bool
    abstract focused: bool
    abstract checkedState: U2<Checkbox.CheckedState, bool>
    abstract setChecked: U2<bool, Checkbox.CheckedState> -> unit
    abstract toggleChecked: unit -> unit
    abstract getRootProps: unit -> label
    abstract getLabelProps: unit -> HtmlTag
    abstract getControlProps: unit -> HtmlTag
    abstract getHiddenInputProps: unit -> input
    abstract getIndicatorProps: unit -> HtmlTag
    
