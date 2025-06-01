namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid




[<Erase; Import("Root", Spec.slider)>]
type Slider() =
    inherit div()
    interface Polymorph
    member val value : int[] = jsNative with get,set
    member val defaultValue : int[] = jsNative with get,set
    member val onChange : int[] -> unit = jsNative with get,set
    member val onChangeEnd : int[] -> unit = jsNative with get,set
    member val inverted : bool = jsNative with get,set
    member val minValue : int = jsNative with get,set
    member val maxValue : int = jsNative with get,set
    member val step : int = jsNative with get,set
    member val minStepsBetweenThumbs : int = jsNative with get,set
    member val getValueLabel : {| values: int[] ; min : int ; max : int |} -> string = jsNative with get,set
    member val orientation : Orientation = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Slider =
    [<Erase; Import("Track", Spec.slider)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.slider)>]
    type Fill() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Thumb", Spec.slider)>]
    type Thumb() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Input", Spec.slider)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.slider)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Label", Spec.slider)>]
    type Label() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Description", Spec.slider)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.slider)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph

