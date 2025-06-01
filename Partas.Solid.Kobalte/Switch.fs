namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.switch)>]
type Switch() =
    inherit div()
    interface Polymorph
    member val checked' : bool = jsNative with get,set
    member val defaultChecked : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set
    member val value : string = jsNative with get,set
    
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
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Thumb", Spec.switch)>]
    type Thumb() =
        inherit div()
        interface Polymorph


