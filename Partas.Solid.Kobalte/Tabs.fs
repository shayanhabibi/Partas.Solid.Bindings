namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.tabs)>]
type Tabs() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val activationMode : ActivationMode = jsNative with get,set
    member val disabled : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module Tabs =
    [<Erase; Import("Trigger", Spec.tabs)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("Content", Spec.tabs)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("List", Spec.tabs)>]
    type List() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Indicator", Spec.tabs)>]
    type Indicator() =
        inherit div()
        interface Polymorph

