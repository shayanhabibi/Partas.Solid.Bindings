namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types

[<Erase>]
module QrCode =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Root
            | Frame
            | Pattern
            | Overlay
            | DownloadTrigger
    type ValueChangeDetails =
        abstract value: string
    type ElementIds =
        abstract root: string
        abstract frame: string
    [<StringEnum(CaseRules.None)>]
    type Ecc =
        | L
        | M
        | Q
        | H
    type DataType =
        | Border = -1
        | Data = 0
        | Function = 1
        | Position = 2
        | Timing = 3
        | Alignment = 4
    type GenerateResult =
        abstract version: float
        abstract size: float
        abstract maskPattern: float
        abstract data: bool[,]
        abstract types: DataType[,]
    [<Pojo>]
    type GenerateOptions(
        ?ecc: Ecc,
        ?maskPattern: float,
        ?boostEcc: bool,
        ?minVersion: float,
        ?maxVersion: float,
        ?border: float,
        ?invert: bool,
        ?onEncoded: GenerateResult -> unit
        ) =
        [<DefaultValue>]
        val mutable ecc: Ecc
        [<DefaultValue>]
        val mutable maskPattern: float
        [<DefaultValue>]
        val mutable boostEcc: bool
        [<DefaultValue>]
        val mutable minVersion: float
        [<DefaultValue>]
        val mutable maxVersion: float
        [<DefaultValue>]
        val mutable border: float
        [<DefaultValue>]
        val mutable invert: float
        [<DefaultValue>]
        val mutable onEncoded: GenerateResult -> unit
    [<StringEnum>]
    type DataUrlType =
        | [<CompiledName("image/png")>] Png
        | [<CompiledName("image/jpeg")>] Jpeg
        | [<CompiledName("image/svg+xml")>] SvgXml
    [<Pojo>]
    type DownloadTriggerProps(
        mimeType: DataUrlType,
        fileName: string,
        ?quality: float
        ) =
        member val mimeType = mimeType with get,set
        member val fileName = fileName with get,set
        member val quality = quality with get,set
type QrCodeProps =
    inherit DirectionProperty
    inherit CommonProperties
    /// <summary>
    /// The controlled value to encode.
    /// </summary>
    abstract member value: string with get, set
    /// <summary>
    /// The initial value to encode when rendered.
    /// Use when you don't need to control the value of the qr code.
    /// </summary>
    abstract member defaultValue: string with get, set
    /// <summary>
    /// The element ids.
    /// </summary>
    abstract member ids: QrCode.ElementIds with get, set
    /// <summary>
    /// The qr code encoding options.
    /// </summary>
    abstract member encoding: QrCode.GenerateOptions with get, set
    /// <summary>
    /// Callback fired when the value changes.
    /// </summary>
    abstract member onValueChange: (QrCode.ValueChangeDetails -> unit) option with get, set
    /// <summary>
    /// The pixel size of the qr code.
    /// </summary>
    abstract member pixelSize: float with get, set

type QrCodeApi =
    abstract value: string
    abstract setValue: value: string -> unit
    abstract getDataUrl: ``type``: QrCode.DataUrlType * ?quality: float -> Promise<string>
    abstract getRootProps: unit -> HtmlTag
    abstract getFrameProps: unit -> Svg.svg
    abstract getPatternProps: unit -> Svg.path
    abstract getOverlayProps: unit -> HtmlTag
    abstract getDownloadTriggerProps: QrCode.DownloadTriggerProps -> button
