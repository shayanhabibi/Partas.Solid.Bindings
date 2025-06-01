[<AutoOpen>]
module Partas.Solid.NeoDrag.Spec

open Fable.Core

[<Erase>]
let [<Literal>] path = "@neodrag/solid"
[<Erase>]
let [<Literal>] version = "2.3.0"

[<AutoOpen; Erase>]
module Enums =
    [<RequireQualifiedAccess; StringEnum>]
    type NeoDragAxis =
        | Both
        | X
        | Y
        | None
    
    [<RequireQualifiedAccess; StringEnum>]
    type NeoDragBounds =
        | Parent
