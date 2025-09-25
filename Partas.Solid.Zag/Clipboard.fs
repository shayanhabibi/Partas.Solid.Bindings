namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Erase>]
module Clipboard =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Root
            | Control
            | Trigger
            | Indicator
            | Input
            | Label
    type CopyStatusDetails =
        abstract copied: bool
    type ValueChangeDetails =
        abstract value: string
    type ElementIds =
        abstract root: string
        abstract input: string
        abstract label: string
    [<Pojo>]
    type IndicatorProps(
        copied: bool
        ) =
        member val copied = copied with get,set
        
type ClipboardProps =
    inherit CommonProperties
    abstract ids: Clipboard.ElementIds with get,set
    abstract value: string with get,set
    abstract defaultValue: string with get,set
    abstract onValueChange: Clipboard.ValueChangeDetails -> unit with get,set
    abstract onStatusChange: Clipboard.CopyStatusDetails -> unit with get,set
    abstract timeout: int with get,set


type ClipboardApi =
    abstract copied: bool
    abstract value: string
    abstract setValue: string -> unit
    abstract copy: unit -> unit
    abstract getRootProps: unit -> HtmlTag
    abstract getLabelProps: unit -> label
    abstract getControlProps: unit -> HtmlTag
    abstract getTriggerProps: unit -> button
    abstract getInputProps: unit -> input
    abstract getIndicatorProps: props: Clipboard.IndicatorProps -> HtmlTag
