namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.progress)>]
type Progress() =
    inherit div()
    interface Polymorph
    member val value : int = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val getValueLabel : {| value: int ; min : int ; max : int |} -> string = jsNative with get,set
    member val indeterminate : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Progress =
    [<Erase; Import("Label", Spec.progress)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.progress)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", Spec.progress)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.progress)>]
    type Fill() =
        inherit div()
        interface Polymorph

