namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.radioGroup)>]
type RadioGroup() =
    inherit div()
    interface Polymorph
    member val ref: HtmlElement = jsNative with get,set
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

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
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Item", Spec.radioGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val ref : HtmlElement = jsNative with get,set
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
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

