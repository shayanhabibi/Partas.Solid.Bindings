namespace Partas.Solid.Kobalte

open Browser.Types
open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.popover)>]
type Popover() =
    inherit div()
    interface Polymorph
    [<Erase>] member val open' : bool = JS.undefined with get,set
    [<Erase>] member val defaultOpen : bool = JS.undefined with get,set
    [<Erase>] member val onOpenChange : (bool -> unit) = JS.undefined with get,set
    [<Erase>] member val id : string = JS.undefined with get,set
    [<Erase>] member val modal : bool = JS.undefined with get,set
    [<Erase>] member val preventScroll : bool = JS.undefined with get,set
    [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase>] member val translations : string = JS.undefined with get,set
    [<Erase>] member val getAnchorRect : HtmlElement -> obj = JS.undefined with get,set
    [<Erase>] member val anchorRef : unit -> HtmlElement = JS.undefined with get,set
    [<Erase>] member val placement : Popover.Placement = JS.undefined with get,set
    [<Erase>] member val gutter : int = JS.undefined with get,set
    [<Erase>] member val shift : int = JS.undefined with get,set
    [<Erase>] member val flip : bool = JS.undefined with get,set
    [<Erase>] member val slide : bool = JS.undefined with get,set
    [<Erase>] member val overlap : bool = JS.undefined with get,set
    [<Erase>] member val sameWidth : bool = JS.undefined with get,set
    [<Erase>] member val fitViewport : bool = JS.undefined with get,set
    [<Erase>] member val hideWhenDetached : bool = JS.undefined with get,set
    [<Erase>] member val detachedPadding : int = JS.undefined with get,set
    [<Erase>] member val arrowPadding : int = JS.undefined with get,set
    [<Erase>] member val overflowPadding : int = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module Popover =
    [<Erase; Import("Trigger", Spec.popover)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.popover)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val gutter : int = JS.undefined with get,set
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Arrow", Spec.popover)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    [<Erase; Import("Portal", Spec.popover)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Anchor", Spec.popover)>]
    type Anchor() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.popover)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.popover)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.popover)>]
    type Description() =
        inherit p()
        interface Polymorph


[<Erase; AutoOpen>]
module PopoverContext =
    [<AllowNullLiteral; Interface>]
    type PopoverDataSet =
        abstract ``data-expanded``: string option
        abstract ``data-closed``: string option
    [<AllowNullLiteral; Interface>]
    type PopoverContext =
        abstract translations: Accessor<obj>
        abstract dataset: Accessor<PopoverDataSet>
        abstract isOpen: Accessor<bool>
        abstract isModal: Accessor<bool>
        abstract preventScroll: Accessor<bool>
        abstract contentPresent: Accessor<bool>
        abstract triggerRef: Accessor<HTMLElement option>
        abstract contentId: Accessor<string option>
        abstract titleId: Accessor<string option>
        abstract descriptionId: Accessor<string option>
        abstract setDefaultAnchorRef: HTMLElement -> unit
        abstract setTriggerRef: HTMLElement -> unit
        abstract setContentRef: HTMLElement -> unit
        abstract close: unit -> unit
        abstract toggle: unit -> unit
        abstract generateId: string -> string
        abstract registerContentId: string -> (unit -> unit)
        abstract registerTitleId: string -> (unit -> unit)
        abstract registerDescriptionId: string -> (unit -> unit)
    [<ImportMember(Spec.popover)>]
    let usePopoverContext(): PopoverContext = jsNative
