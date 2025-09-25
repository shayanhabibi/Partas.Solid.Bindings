namespace Partas.Solid.ZagJs
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS

[<Erase>]
module Collapsible =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Root
            | Trigger
            | Content
            | Indicator
    type OpenChangeDetails =
        abstract ``open``: bool with get,set
    type ElementIds =
        abstract root: string
        abstract content: string
        abstract trigger: string

type CollapsibleProps =
    inherit CommonProperties
    inherit DirectionProperty
    abstract ids: Collapsible.ElementIds with get,set
    abstract ``open``: bool with get,set
    abstract defaultOpen: bool with get,set
    abstract onOpenChange: Collapsible.OpenChangeDetails -> unit with get,set
    abstract onExitComplete: (unit -> unit) with get,set
    abstract disabled: bool with get,set

type CollapsibleApi =
    abstract ``open``: bool
    abstract visible: bool
    abstract disabled: bool
    abstract setOpen: bool -> unit
    abstract measureSize: unit -> unit
    abstract getRootProps: unit -> HtmlTag
    abstract getTriggerProps: unit -> button
    abstract getContentProps: unit -> HtmlTag
    abstract getIndicatorProps: unit -> HtmlTag
