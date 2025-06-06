namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; AllowNullLiteral; Interface>]
type ToggleButtonState =
    abstract member pressed: Accessor<bool> with get

[<Erase; Import("Root", Spec.toggleButton)>]
type ToggleButton() =
    inherit button()
    interface Polymorph
    interface ChildLambdaProvider<ToggleButtonState>
    member val pressed : bool = jsNative with get,set
    member val defaultPressed : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set

