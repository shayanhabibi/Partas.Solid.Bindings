namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.toggleGroup)>]
type ToggleGroup() =
    inherit div()
    interface Polymorph
    member val value : string = jsNative with get,set
    member val defaultValue : string = jsNative with get,set
    member val onChange : string -> unit = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val multiple : bool = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module ToggleGroup =
    [<Erase; Import("Item", Spec.toggleGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val children : Fragment = jsNative with get,set

        member val pressed : unit -> bool = jsNative with get,set

