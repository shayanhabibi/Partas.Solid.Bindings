namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid

[<Erase; Import("Root", Spec.badge)>]
type Badge() =
    inherit span()
    interface Polymorph
    /// Accessible text description of the badge if child is not text
    member val textValue : string = jsNative with get,set //v0.13.9
