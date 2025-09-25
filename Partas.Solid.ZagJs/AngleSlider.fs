namespace Partas.Solid.ZagJs
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS
open Partas.Solid

[<Erase>]
module AngleSlider =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Root
            | Label
            | Thumb
            | ValueText
            | Control
            | Track
            | MarkerGroup
            | Marker
    type ValueChangeDetails =
        abstract value: float
        abstract valueAsDegree: string
        
    type ElementIds =
        abstract root: string with get,set
        abstract thumb: string with get,set
        abstract hiddenInput: string with get,set
        abstract control: string with get,set
        abstract valueText: string with get,set

    type MarkerProps =
        abstract value: float with get,set
        
type AngleSliderProps =
    inherit DirectionProperty
    inherit CommonProperties
    abstract ids: AngleSlider.ElementIds with get,set
    abstract step: float with get,set
    abstract value: float with get,set
    abstract defaultValue: float with get,set
    abstract onValueChange: AngleSlider.ValueChangeDetails -> unit with get,set
    abstract onValueChangeEnd: AngleSlider.ValueChangeDetails -> unit with get,set
    abstract disabled: bool with get,set
    abstract readOnly: bool with get,set
    abstract invalid: bool with get,set
    abstract name: string with get,set


type AngleSliderApi =
    abstract value: float
    abstract valueAsDegree: string
    abstract setValue: float -> unit with get
    abstract dragging: bool
    abstract getRootProps: unit -> HtmlTag with get
    abstract getLabelProps: unit -> label with get
    abstract getHiddenInputProps: unit -> HtmlTag with get
    abstract getControlProps: unit -> HtmlTag with get
    abstract getThumbProps: unit -> HtmlTag with get
    abstract getValueTextProps: unit -> HtmlTag  with get
    abstract getMarkerGroupProps: unit -> HtmlTag with get
    abstract getMarkerProps: props: AngleSlider.MarkerProps -> HtmlTag with get
