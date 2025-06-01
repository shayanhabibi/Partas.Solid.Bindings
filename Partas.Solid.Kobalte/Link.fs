namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

// We wrap this in a module due to other items named Link inheriting this
[<AutoOpen; Erase>]
module Kobalte =
    /// <summary>
    /// data-disabled: Present when the link is disabled
    /// </summary>
    [<Erase; Import("Root", Spec.link)>]
    type Link() =
        inherit a()
        interface Polymorph
        member val disabled : bool = jsNative with get,set
