namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.toggleButton)>]
type ToggleButton() =
    inherit button()
    interface Polymorph
    member val pressed : bool = jsNative with get,set
    member val defaultPressed : bool = jsNative with get,set
    member val onChange : bool -> unit = jsNative with get,set
    member val children : ToggleButton -> #HtmlElement = jsNative with get,set

    member inline this.Pressed : unit -> bool = fun _ -> this.pressed


