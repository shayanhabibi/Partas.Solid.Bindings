namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS
open Color
open Browser.Types

[<Erase>]
module ColorPicker =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Content
            | Label
            | Area
            | Root
            | Control
            | Trigger
            | Positioner
            | AreaThumb
            | ValueText
            | AreaBackground
            | ChannelSlider
            | ChannelSliderLabel
            | ChannelSliderTrack
            | ChannelSliderThumb
            | ChannelSliderValueText
            | ChannelInput
            | TransparencyGrid
            | SwatchGroup
            | SwatchTrigger
            | SwatchIndicator
            | Swatch
            | EyeDropperTrigger
            | FormatTrigger
            | FormatSelect
        
    [<StringEnum>]
    type ExtendedChannel =
        | Hue
        | Saturation
        | Brightness
        | Lightness
        | Red
        | Green
        | Blue
        | Alpha
        | Hex
        | Css
    
    type ValueChangeDetails =
        abstract value: Color with get,set
        abstract valueAsString: string with get,set
    type OpenChangeDetails =
        abstract ``open``: bool with get,set
    type FormatChangeDetails =
        abstract format: Color.Format with get,set
    type ElementIds =
        abstract root: string
        abstract control: string
        abstract trigger: string
        abstract label: string
        abstract input: string
        abstract hiddenInput: string
        abstract content: string
        abstract area: string
        abstract areaGradient: string
        abstract positioner: string
        abstract formatSelect: string
        abstract areaThumb: string
        abstract channelInput: id: string -> string
        abstract channelSliderTrack: id: Color.Channel -> string
        abstract channelSliderThumb: id: Color.Channel -> string
    
type EyeDropper() =
    member this.``open``(?signal: obj): Promise<{| sRGBHex: string |}> = jsNative

[<AutoOpen; Erase>]
module AutoOpenWindowExtension =
    type Window with
        member this.EyeDropper(): EyeDropper = jsNative

type ColorPickerProps =
    inherit CommonProperties
    inherit DirectionProperty
    inherit InteractionOutsideHandler
    abstract ids: ColorPicker.ElementIds with get,set
    abstract value: Color with get,set
    abstract defaultValue: Color with get,set
    abstract disabled: bool with get,set
    abstract readOnly: bool with get,set
    abstract required: bool with get,set
    abstract invalid: bool with get,set
    abstract onValueChange: details: ColorPicker.ValueChangeDetails -> unit with get,set
    abstract onValueChangeEnd: details: ColorPicker.ValueChangeDetails -> unit with get,set
    abstract onOpenChange: details: ColorPicker.OpenChangeDetails -> unit with get,set
    abstract name: string with get,set
    // abstract positioning: Popper.PositioningOptions with get,set
    abstract positioning: obj with get,set
    abstract initialFocusEl: (unit -> HtmlElement option) with get,set
    abstract ``open``: bool with get,set
    abstract defaultOpen: bool with get,set
    abstract format: Color.Format with get,set
    abstract defaultFormat: Color.Format
    abstract onFormatChange: details: ColorPicker.FormatChangeDetails -> unit with get,set
    abstract closeOnSelect: bool with get,set
    abstract openAutoFocus: bool with get,set
    abstract ``inline``: bool with get,set

[<Pojo>]
type ChannelProps(
    channel: Color.Channel,
    ?orientation: Enums.Orientation
    ) =
    member val channel = channel with get,set
    member val orientation = orientation with get,set

[<Pojo>]
type ChannelSliderProps(
    channel: Color.Channel,
    ?orientation: Enums.Orientation,
    ?format: Color.Format
    ) =
    member val channel = channel with get,set
    member val orientation = orientation with get,set
    member val format = format with get,set
[<Pojo>]
type ChannelInputProps(
    channel: ColorPicker.ExtendedChannel,
    ?orientation: Enums.Orientation
    ) =
    member val channel = channel with get,set
    member val orientation = orientation with get,set
[<Pojo>]
type AreaProps(
    ?xChannel: Color.Channel,
    ?yChannel: Color.Channel
    ) =
    member val xChannel = xChannel with get,set
    member val yChannel = yChannel with get,set
[<Pojo>]
type SwatchTriggerProps(
    value: U2<string, Color>,
    ?disabled: bool
    ) =
    member val value = value with get,set
    member val disabled = disabled with get,set

type SwatchTriggerState =
    abstract value: Color
    abstract valueAsString: string
    abstract ``checked``: bool
    abstract disabled: bool

type SwatchProps =
    abstract value: U2<string, Color> with get,set
    abstract respectAlpha: bool with get,set

type TransparencyGridProps =
    abstract size: string with get,set

type ColorPickerApi =
    abstract dragging: bool
    abstract ``open``: bool
    abstract ``inline``: bool
    abstract value: Color
    abstract valueAsString: string
    abstract setValue: U2<string, Color> -> unit
    abstract getChannelValue: channel: Color.Channel -> string
    abstract getChannelValueText: channel: Color.Channel * locale: string -> string
    abstract setChannelValue: channel: Color.Channel * value: float -> unit
    abstract format: Color.Format
    abstract setFormat: format: Color.Format -> unit
    abstract alpha: float
    abstract setAlpha: value: float -> unit
    abstract setOpen: ``open``: bool -> unit
    abstract getRootProps: unit -> HtmlTag
    abstract getLabelProps: unit -> HtmlTag
    abstract getControlProps: unit -> HtmlTag
    abstract getTriggerProps: unit -> button
    abstract getPositionerProps: unit -> HtmlTag
    abstract getContentProps: unit -> HtmlTag
    abstract getHiddenInputProps: unit -> input
    abstract getValueTextProps: unit -> HtmlTag
    abstract getAreaProps: ?props: AreaProps -> HtmlTag
    abstract getAreaBackgroundProps: ?props: AreaProps -> HtmlTag
    abstract getAreaThumbProps: ?props: AreaProps -> HtmlTag
    abstract getChannelInputProps: props: ChannelInputProps -> input
    abstract getChannelSliderProps: props: ChannelSliderProps -> HtmlTag
    abstract getChannelSliderTrackProps: props: ChannelSliderProps -> HtmlTag
    abstract getChannelSliderThumbProps: props: ChannelSliderProps -> HtmlTag
    abstract getChannelSliderLabelProps: props: ChannelProps -> HtmlTag
    abstract getChannelSliderValueTextProps: props: ChannelProps -> HtmlTag
    abstract getTransparencyGridProps: ?props: TransparencyGridProps -> HtmlTag
    abstract getEyeDropperTriggerProps: unit -> button
    abstract getSwatchGroupProps: unit -> HtmlTag
    abstract getSwatchTriggerProps: props: SwatchTriggerProps -> button
    abstract getSwatchTriggerState: props: SwatchTriggerProps -> SwatchTriggerState
    abstract getSwatchProps: props: SwatchProps -> HtmlTag
    abstract getSwatchIndicatorProps: props: SwatchProps -> HtmlTag
    abstract getFormatSelectProps: unit -> select
    abstract getFormatTriggerProps: unit -> button
