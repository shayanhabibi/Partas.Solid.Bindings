namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; AllowNullLiteral; Interface>]
type ToggleButtonState =
    abstract member pressed: Accessor<bool> with get

[<Erase; Import("Root", Spec.toggleButton)>]
type ToggleButton() =
    interface RegularNode
    interface Polymorph
    interface ChildLambdaProvider<ToggleButtonState>
    [<Erase>] member val pressed : bool = JS.undefined with get,set
    [<Erase>] member val defaultPressed : bool = JS.undefined with get,set
    [<Erase>] member val onChange : bool -> unit = JS.undefined with get,set

