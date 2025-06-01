namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core



[<Erase; Import("Root", Spec.textField)>]
type TextField() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    [<Erase>] member val onBlur: Browser.Types.FocusEvent -> unit = JS.undefined with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module TextField =
    [<Erase; Import("TextArea", Spec.textField)>]
    type TextArea() =
        inherit textarea()
        interface Polymorph
        member val autoResize : bool = jsNative with get,set
        member val submitOnEnter : bool = jsNative with get,set
    [<Erase; Import("ErrorMessage", Spec.textField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Label", Spec.textField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("Input", Spec.textField)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("Description", Spec.textField)>]
    type Description() =
        inherit div()
        interface Polymorph

