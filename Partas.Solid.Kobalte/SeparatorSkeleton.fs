namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.separator)>]
type Separator() =
    inherit hr()
    interface Polymorph
    member val orientation : Orientation = jsNative with get,set

[<Erase; Import("Root", Spec.skeleton)>]
type Skeleton() =
    inherit div()
    interface Polymorph
    member val visible : bool = jsNative with get,set
    member val animate : bool = jsNative with get,set
    member val width : int = jsNative with get,set
    member val height : int = jsNative with get,set
    member val radius : int = jsNative with get,set
    member val circle : bool = jsNative with get,set
    member val children : Fragment = jsNative with get,set
