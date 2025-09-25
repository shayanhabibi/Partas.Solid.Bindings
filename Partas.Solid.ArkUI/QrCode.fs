module Partas.Solid.ArkUI.QrCode
open Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS
open Browser.Types

[<Literal>]
let private import = "@ark-ui/solid/qr-code"
[<Literal>]
let private prefix = "QrCode."

[<Import(prefix + "Context", import)>]
type Context() =
    interface HtmlElement
    interface ChildLambdaProvider<Accessor<QrCodeApi>>

[<Import(prefix + "Root", import)>]
type Root
    /// <summary>
    /// <code>
    /// --qrcode-pixel-size
    /// --qrcode-width
    /// --qrcode-height
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    interface DirectionProperty
    interface CommonProperties
    
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

    /// <summary>
    /// The controlled value to encode.
    /// </summary>
    [<Erase>]
    member val value: string = JS.undefined with get , set

    /// <summary>
    /// The initial value to encode when rendered.
    /// Use when you don't need to control the value of the qr code.
    /// </summary>
    [<Erase>]
    member val defaultValue: string = JS.undefined with get , set

    /// <summary>
    /// The element ids.
    /// </summary>
    [<Erase>]
    member val ids: QrCode.ElementIds = JS.undefined with get , set

    /// <summary>
    /// The qr code encoding options.
    /// </summary>
    [<Erase>]
    member val encoding: QrCode.GenerateOptions = JS.undefined with get , set

    /// <summary>
    /// Callback fired when the value changes.
    /// </summary>
    [<Erase>]
    member val onValueChange: (QrCode.ValueChangeDetails -> unit) option = JS.undefined with get , set

    /// <summary>
    /// The pixel size of the qr code.
    /// </summary>
    [<Erase>]
    member val pixelSize: float = JS.undefined with get , set

[<Import(prefix + "DownloadTrigger", import)>]
type DownloadTrigger() =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val fileName: string = undefined with get,set
    [<Erase>]
    member val mimeType: QrCode.DataUrlType = undefined with get,set
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
    [<Erase>]
    member val quality: float = undefined with get,set
[<Import(prefix + "Frame", import)>]
type Frame() =
    inherit Svg.svg()
    interface Polymorph
    [<Erase>]
    member val asChild: Svg.svg -> HtmlElement = undefined with get,set
[<Import(prefix + "Overlay", import)>]
type Overlay() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "Pattern", import)>]
type Pattern() =
    inherit Svg.path()
    interface Polymorph
    [<Erase>]
    member val asChild: Svg.path -> HtmlElement = undefined with get,set
[<Import(prefix + "RootProvider", import)>]
type RootProvider() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val value: Accessor<QrCodeApi> = undefined with get,set
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
