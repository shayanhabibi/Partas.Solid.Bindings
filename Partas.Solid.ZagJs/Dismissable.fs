namespace Partas.Solid.ZagJs

open Browser.Types
open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

[<Erase>]
module Dismissable =
    [<StringEnum>]
    type LayerType =
        | Dialog
        | Popover
        | Menu
        | Listbox
    type LayerDismissEventDetail =
        abstract originalLayer: HTMLElement
        abstract targetLayer: HTMLElement
        abstract originalIndex: int
        abstract targetIndex: int
    
    type LayerDismissEvent = CustomEvent<LayerDismissEventDetail>

type DismissableElementOptions =
    inherit DismissableElementHandlers
    inherit PersistentElementOptions

[<AutoOpen; Erase>]
module DismissableElementOptionsExtensions =
    type DismissableElementOptions with
        member _.debug
            with [<Erase>] set(value: bool) = ()
            and [<Erase>] get(): bool = undefined
        member _.pointerBlocking
            with [<Erase>] set(value: bool) = ()
            and [<Erase>] get(): bool = undefined
        member _.onDismiss
            with [<Erase>] set(value: unit -> unit) = ()
            and [<Erase>] get(): unit -> unit = undefined
        member _.exclude
            with [<Erase>] set(value: obj) = ()
            and [<Erase>] get(): obj = undefined
        member _.defer
            with [<Erase>] set(value: bool) = ()
            and [<Erase>] get(): bool = undefined
        member _.warnOnMissingNode
            with [<Erase>] set(value: bool) = ()
            and [<Erase>] get(): bool = undefined
        member _.``type``
            with [<Erase>] set(value: Dismissable.LayerType) = ()
            and [<Erase>] get(): Dismissable.LayerType = undefined
            
            
