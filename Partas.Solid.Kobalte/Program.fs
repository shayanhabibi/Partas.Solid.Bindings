namespace Partas.Solid.Kobalte

open Fable.Core

// ================================================== Interfaces
[<JS.Pojo>]
type CollectionItem(?``type``: CollectionType, ?key: string, ?textValue: string, ?disabled: bool) =
    [<DefaultValue>]
    val mutable ``type``: CollectionType
    [<DefaultValue>]
    val mutable key: string
    [<DefaultValue>]
    val mutable textValue: string
    [<DefaultValue>]
    val mutable disabled: bool

[<Interface; AllowNullLiteral>]
type CollectionNode<'T> =
    abstract ``type``: CollectionType
    abstract key: string
    abstract rawValue: 'T
    abstract textValue: string
    abstract disabled: bool
    abstract level: int
    abstract index: int
    abstract prevKey: string option
    abstract nextKey: string option

[<Interface; AllowNullLiteral>]
type ItemComponentProps<'T> =
    abstract item: CollectionNode<'T>
[<Interface; AllowNullLiteral>]
type SectionComponentProps<'T> =
    abstract section: CollectionNode<'T>

[<JS.Pojo>]
type PosXY(?x: float, ?y: float) =
    member val x = x with get,set
    member val y = y with get,set

[<AllowNullLiteral>]
[<Interface>]
type ColorAxes =
    abstract member xChannel: ColorChannel with get, set
    abstract member yChannel: ColorChannel with get, set
    abstract member zChannel: ColorChannel with get, set

[<AllowNullLiteral>]
[<Interface>]
type ColorChannelRange =
    /// <summary>
    /// The minimum value of the color channel.
    /// </summary>
    abstract member minValue: float with get, set
    /// <summary>
    /// The maximum value of the color channel.
    /// </summary>
    abstract member maxValue: float with get, set
    /// <summary>
    /// The step value of the color channel, used when incrementing and decrementing.
    /// </summary>
    abstract member step: float with get, set
    /// <summary>
    /// The page step value of the color channel, used when incrementing and decrementing.
    /// </summary>
    abstract member pageSize: float with get, set

[<Global>]
[<AllowNullLiteral>]
type XyChannels
    [<ParamObject; Emit("$0")>]
    (
        ?xChannel: ColorChannel,
        ?yChannel: ColorChannel
    ) =

    member val xChannel : ColorChannel option = nativeOnly with get, set
    member val yChannel : ColorChannel option = nativeOnly with get, set
[<Global>]
[<AllowNullLiteral>]
type XyzChannels
    [<ParamObject; Emit("$0")>]
    (
        xChannel: ColorChannel,
        yChannel: ColorChannel,
        zChannel: ColorChannel
    ) =

    member val xChannel : ColorChannel = nativeOnly with get, set
    member val yChannel : ColorChannel = nativeOnly with get, set
    member val zChannel : ColorChannel = nativeOnly with get, set
/// <summary>
/// You can create a Color object using <c>Color.parseColor</c>
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Color =
    /// <summary>
    /// Parses a color from a string value. Throws an error if the string could not be parsed.
    /// </summary>
    [<Import("parseColor", "@kobalte/utils")>]
    static member parseColor(value: string): Color = jsNative
    [<Import("normalizeColor", "@kobalte/utils")>]
    static member normalizeColor(value: string): Color = jsNative
    [<Import("normalizeColor", "@kobalte/utils")>]
    static member normalizeColor(value: Color): Color = jsNative
    /// <summary>
    /// Returns a list of color channels for a given color space.
    /// </summary>
    [<Import("getColorChannels", "@kobalte/utils")>]
    static member getColorChannels(colorSpace: ColorSpace): ColorChannel * ColorChannel * ColorChannel = jsNative
    /// <summary>
    /// Returns the hue value normalized to the range of 0 to 360.
    /// </summary>
    [<Import("normalizeHue", "@kobalte/utils")>]
    static member normalizeHue(value: int): Color = jsNative
    /// <summary>
    /// Converts the color to the given color format, and returns a new Color object.
    /// </summary>
    abstract member toFormat: format: Color.Format -> Color
    /// <summary>
    /// Converts the color to a string in the given format.
    /// </summary>
    abstract member toString: ?format: Color.ToString.Format -> string
    /// <summary>
    /// Returns a duplicate of the color value.
    /// </summary>
    abstract member clone: unit -> Color
    /// <summary>
    /// Converts the color to hex, and returns an integer representation.
    /// </summary>
    abstract member toHexInt: unit -> float
    /// <summary>
    /// Returns the numeric value for a given channel.
    /// Throws an error if the channel is unsupported in the current color format.
    /// </summary>
    abstract member getChannelValue: channel: Color.Channel -> float
    /// <summary>
    /// Sets the numeric value for a given channel, and returns a new Color object.
    /// Throws an error if the channel is unsupported in the current color format.
    /// </summary>
    abstract member withChannelValue: channel: Color.Channel * value: float -> Color
    /// <summary>
    /// Returns the minimum, maximum, and step values for a given channel.
    /// </summary>
    abstract member getChannelRange: channel: Color.Channel -> ColorChannelRange
    /// <summary>
    /// Returns a localized color channel name for a given channel and locale,
    /// for use in visual or accessibility labels.
    /// </summary>
    abstract member getChannelName: channel: Color.Channel * translations: obj -> string
    /// <summary>
    /// Returns the number formatting options for the given channel.
    /// </summary>
    abstract member getChannelFormatOptions: channel: Color.Channel -> obj
    /// <summary>
    /// Formats the numeric value for a given channel for display according to the provided locale.
    /// </summary>
    abstract member formatChannelValue: channel: Color.Channel -> string
    /// <summary>
    /// Returns the color space, 'rgb', 'hsb' or 'hsl', for the current color.
    /// </summary>
    abstract member getColorSpace: unit -> ColorSpace
    /// <summary>
    /// Returns the color space axes, xChannel, yChannel, zChannel.
    /// </summary>
    abstract member getColorSpaceAxes: xyChannels: XyChannels -> ColorAxes
    /// <summary>
    /// Returns an array of the color channels within the current color space space.
    /// </summary>
    abstract member getColorChannels: unit -> Color.Channel * Color.Channel * ColorChannel
    /// <summary>
    /// Returns a localized name for the color, for use in visual or accessibility labels.
    /// </summary>
    abstract member getColorName: translations: obj -> string
    /// <summary>
    /// Returns a localized name for the hue, for use in visual or accessibility labels.
    /// </summary>
    abstract member getHueName: translations: obj -> string

