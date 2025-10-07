namespace Partas.Solid.Kobalte

open Browser.Types
open Partas.Solid
open Fable.Core



[<Erase; Import("Root", Spec.textField)>]
type TextField() =
    inherit div()
    interface Polymorph
    [<Erase>] member val value : string = JS.undefined with get,set
    [<Erase>] member val defaultValue : string = JS.undefined with get,set
    [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
    [<Erase>] member val onBlur: Browser.Types.FocusEvent -> unit= JS.undefined with get,set
    [<Erase>] member val name : string = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState = JS.undefined with get,set
    [<Erase>] member val required : bool = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase>] member val readOnly : bool = JS.undefined with get,set

[<Erase; RequireQualifiedAccess>]
module TextField =
    [<Erase; Import("TextArea", Spec.textField)>]
    type TextArea() =
        inherit textarea()
        interface Polymorph
        [<Erase>] member val autoResize : bool = JS.undefined with get,set
        [<Erase>] member val submitOnEnter : bool = JS.undefined with get,set
    [<Erase; Import("ErrorMessage", Spec.textField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
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


[<Erase; AutoOpen>]
module TextFieldContext =
    [<AllowNullLiteral; Interface>]
    type TextFieldContext =
        abstract value: Accessor<string option>
        abstract generateId: part: string -> string
        abstract onInput: (InputEvent -> unit) with get,set
    
    [<ImportMember(Spec.textField)>]
    let useTextFieldContext(): TextFieldContext = jsNative
