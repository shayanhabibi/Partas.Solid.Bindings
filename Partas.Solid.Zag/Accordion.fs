namespace Partas.Solid.ZagJs
open Fable.Core.JsInterop
open Fable.Core
open Fable.Core.JS


[<Erase>]
module Accordion =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Root
            | Item
            | ItemTrigger
            | ItemContent
            | ItemIndicator

    [<AllowNullLiteral>]
    type ValueChangeDetails =
        abstract value: string[] with get,set
    [<AllowNullLiteral>]
    type FocusChangeDetails =
        abstract value: string option with get,set
    [<AllowNullLiteral>]
    type ElementIds =
        abstract root: string with get,set
        abstract item: value: string -> string with get,set
        abstract itemContent: value: string -> string with get,set
        abstract itemTrigger: value: string -> string with get,set
    [<StringEnum>]
    type Orientation =
        | Horizontal
        | Vertical

    type ItemProps =
        abstract value: string
        abstract disabled: bool option

    [<JS.Pojo>]
    type ItemState(
        expanded: bool,
        focused: bool,
        disabled: bool
        ) =
        member val expanded = expanded with get,set
        member val focused = focused with get,set
        member val disabled = disabled with get,set

type AccordionProps =
    inherit DirectionProperty
    inherit CommonProperties
    abstract ids: Accordion.ElementIds option
    abstract multiple: bool 
    abstract collapsible: bool 
    abstract value: string[] option
    abstract defaultValue: string[] option
    abstract disabled: bool option
    abstract onValueChange: (Accordion.ValueChangeDetails -> unit) option
    abstract onFocusChange: (Accordion.FocusChangeDetails -> unit) option
    abstract orientation: Accordion.Orientation



type AccordionApi<'T> =
    abstract focusedValue: string option
    abstract value: string[]
    abstract setValue: string[] -> unit
    [<ParamObject>]
    abstract getItemState: value: string * ?disabled: bool -> Accordion.ItemState
    abstract getRootProps: unit -> 'T
    [<ParamObject>]
    abstract getItemProps: value: string * ?disabled: bool -> 'T
    [<ParamObject>]
    abstract getItemContentProps: value: string * ?disabled: bool -> 'T
    [<ParamObject>]
    abstract getItemTriggerProps: value: string * ?disabled: bool -> 'T
    [<ParamObject>]
    abstract getItemIndicatorProps: value: string * ?disabled: bool -> 'T
