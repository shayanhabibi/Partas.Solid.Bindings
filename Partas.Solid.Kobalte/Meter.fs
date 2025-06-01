namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.meter)>]
type Meter() =
    inherit div()
    interface Polymorph
    member val value : int = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val getValueLabel : {| value: int ; min : int ; max : int |} -> string = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Meter =
    [<Erase; Import("Label", Spec.meter)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.meter)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", Spec.meter)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.meter)>]
    type Fill() =
        inherit div()
        interface Polymorph


