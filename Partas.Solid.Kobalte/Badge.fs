namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid

[<Erase; Import("Root", Spec.badge)>]
type Badge() =
    inherit span()
    interface Polymorph
    /// <summary>
    /// Accessible text description of the badge if child is not text
    /// </summary>
    [<Erase>] member val textValue : string = JS.undefined with get,set
