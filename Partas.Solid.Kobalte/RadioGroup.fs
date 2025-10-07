namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.radioGroup)>]
type RadioGroup() =
    inherit div()
    interface Polymorph
    [<Erase>] member val ref: HtmlElement = JS.undefined with get,set
    [<Erase>] member val value : string = JS.undefined with get,set
    [<Erase>] member val defaultValue : string = JS.undefined with get,set
    [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
    [<Erase>] member val orientation : Orientation = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase>] member val name : string = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState = JS.undefined with get,set
    [<Erase>] member val required : bool = JS.undefined with get,set
    [<Erase>] member val readOnly : bool = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module RadioGroup =
    [<Erase; Import("Label", Spec.radioGroup)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Description", Spec.radioGroup)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.radioGroup)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("Item", Spec.radioGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        [<Erase>] member val ref : HtmlElement = JS.undefined with get,set
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("ItemInput", Spec.radioGroup)>]
    type ItemInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ItemControl", Spec.radioGroup)>]
    type ItemControl() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemIndicator", Spec.radioGroup)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.radioGroup)>]
    type ItemLabel() =
        inherit label()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.radioGroup)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; AutoOpen>]
module RadioGroupContext =
    [<AllowNullLiteral; Interface>]
    type RadioGroupContext =
        abstract ariaDescribedBy: Accessor<string option>
        abstract isDefaultValue: string -> bool
        abstract isSelectedValue: string -> bool
        abstract setSelectedValue: string -> unit
    [<ImportMember(Spec.radioGroup)>]
    let useRadioGroupContext(): RadioGroupContext = jsNative
