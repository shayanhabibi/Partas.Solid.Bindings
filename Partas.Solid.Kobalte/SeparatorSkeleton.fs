namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.separator)>]
type Separator() =
    inherit hr()
    interface Polymorph
    [<Erase>] member val orientation : Orientation = JS.undefined with get,set

[<Erase; Import("Root", Spec.skeleton)>]
type Skeleton() =
    inherit div()
    interface Polymorph
    [<Erase>] member val visible : bool = JS.undefined with get,set
    [<Erase>] member val animate : bool = JS.undefined with get,set
    [<Erase>] member val width : int = JS.undefined with get,set
    [<Erase>] member val height : int = JS.undefined with get,set
    [<Erase>] member val radius : int = JS.undefined with get,set
    [<Erase>] member val circle : bool = JS.undefined with get,set
