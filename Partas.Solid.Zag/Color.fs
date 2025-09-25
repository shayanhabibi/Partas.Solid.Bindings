module Partas.Solid.ZagJs.Color

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Erase>]
module Color =
    [<StringEnum(CaseRules.LowerAll)>]
    type HexFormat =
        | HEX
        | HEXA
    [<StringEnum(CaseRules.LowerAll)>]
    type Format =
        | RGBA
        | HSLA
        | HSBA
    [<StringEnum(CaseRules.LowerAll)>]
    type StringFormat =
        | HEXA
        | HEX
        | RGBA
        | HSLA
        | HSBA
        | RGB
        | HSL
        | HSB
        | CSS
        
    [<StringEnum>]
    type Channel =
        | Hue
        | Saturation
        | Brightness
        | Lightness
        | Red
        | Green
        | Blue
        | Alpha

[<Pojo>]
type Color2DAxes(
    xChannel: Color.Channel
    ,yChannel: Color.Channel
    ) =
    member val xChannel = xChannel with get,set
    member val yChannel = yChannel with get,set
    
[<Pojo>]
type ColorAxes(
    xChannel: Color.Channel
    ,yChannel: Color.Channel
    ,zChannel: Color.Channel
    ) =
    member val xChannel = xChannel with get,set
    member val yChannel = yChannel with get,set
    member val zChannel = zChannel with get,set

type ColorChannelRange =
    abstract minValue: float with get,set
    abstract maxValue: float with get,set
    abstract step: float with get,set
    abstract pageSize: float with get,set

type ColorType =
    abstract member toFormat: format: Color.Format -> ColorType
    abstract member toJSON: unit -> obj
    abstract member toString: format: Color.StringFormat -> string
    abstract member toHexInt: unit -> int
    abstract member getChannelValue: channel: Color.Channel -> float
    abstract member withChannelValue: channel: Color.Channel * value: float -> ColorType
    abstract member formatChannelValue: channel: Color.Channel * locale: string -> string
    abstract member getChannelRange: channel: Color.Channel -> ColorChannelRange
    abstract member getFormat: unit -> Color.Format
    abstract member getColorAxes: xyChannels: Color2DAxes -> ColorAxes
    abstract member getChannels: unit -> Color.Channel * Color.Channel * Color.Channel
    abstract member clone: unit -> ColorType
    abstract member isEqual: color: ColorType -> bool
    abstract member incrementChannel: channel: Color.Channel * stepSize: float -> ColorType
    abstract member decrementChannel: channel: Color.Channel * stepSize: float -> ColorType
    abstract member getChannelValuePercent: channel: Color.Channel * ?value: float -> float
    abstract member getChannelPercentValue: channel: Color.Channel * percent: float -> float
    
type Color =
    inherit ColorType

[<Pojo>]
type GradientOptions(
    xChannel: Color.Channel,
    yChannel: Color.Channel,
    ?dir: Enums.Direction
    ) =
    member val xChannel = xChannel with get,set
    member val yChannel = yChannel with get,set
    member val dir = dir with get,set

[<Pojo>]
type GradientStyles(
    areaStyles: obj,
    areaGradientStyles: obj
    ) =
    member val areaStyles = areaStyles with get,set
    member val areaGradientStyles = areaGradientStyles with get,set

type Color with
    [<ImportMember(Spec.pathExt + "color-utils")>]
    static member getColorAreaGradient(color: Color, options: GradientOptions): GradientStyles = jsNative
    [<ImportMember(Spec.pathExt + "color-utils"); ParamObject(1)>]
    static member getColorAreaGradient(color: Color, xChannel: Color.Channel, yChannel: Color.Channel, ?dir: Enums.Direction): GradientStyles = jsNative
    [<ImportMember(Spec.pathExt + "color-utils")>]
    static member parseColor(value: string): ColorType = jsNative
    [<ImportMember(Spec.pathExt + "color-utils")>]
    static member normalizeColor(v: string): ColorType = jsNative
    [<ImportMember(Spec.pathExt + "color-utils")>]
    static member normalizeColor(v: ColorType): ColorType = jsNative
    
    

    
