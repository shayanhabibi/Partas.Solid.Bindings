namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core
open Browser.Types
    
[<Erase; Import("Root", Spec.dialog)>]
type Dialog() =
    interface RegularNode
    interface Polymorph
    [<Erase>] member val open' : bool = JS.undefined with get,set
    [<Erase>] member val defaultOpen : bool = JS.undefined with get,set
    [<Erase>] member val onOpenChange : (bool -> unit) = JS.undefined with get,set
    [<Erase>] member val id : string = JS.undefined with get,set
    [<Erase>] member val modal : bool = JS.undefined with get,set
    [<Erase>] member val preventScroll : bool = JS.undefined with get,set
    [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase>] member val translations : string = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module Dialog =
    [<Erase; Import("Trigger", Spec.dialog)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.dialog)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onEscapeKeyDown : KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Overlay", Spec.dialog)>]
    type Overlay() =
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.dialog)>]
    type CloseButton() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.dialog)>]
    type Title() =
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.dialog)>]
    type Description() =
        inherit p()
        interface Polymorph
    [<Erase; Import("Portal", Spec.dialog)>]
    type Portal() =
        inherit div()
        interface Polymorph

[<Erase; AutoOpen>]
module DialogContext =
    [<AllowNullLiteral; Erase>]
    type DialogContext =
        abstract member translations: Accessor<obj> with get
        abstract member isOpen: bool Accessor with get
        abstract member modal: bool Accessor with get
        abstract member preventScroll: bool Accessor with get
        abstract member contentId: string option Accessor with get
        abstract member titleId: string option Accessor with get
        abstract member descriptionId: string option Accessor with get
        abstract member triggerRef: HTMLElement option Accessor with get
        abstract member overlayRef: HTMLElement option Accessor with get
        abstract member setOverlayRef: HTMLElement Setter with get
        abstract member contentRef: HTMLElement option Accessor with get
        abstract member setContentRef: HTMLElement Setter with get
        abstract member overlayPresent: bool Accessor with get
        abstract member contentPresent: bool Accessor with get
        abstract member close: (unit -> unit) with get
        abstract member toggle: (unit -> unit) with get
        abstract member setTriggerRef: HTMLElement Setter with get
        abstract member generateId: string -> string with get
        abstract member registerContentId: string -> (unit -> unit)
        abstract member registerTitleId: string -> (unit -> unit)
        abstract member registerDescriptionId: string -> (unit -> unit)
    
    [<Import("useDialogContext", Spec.dialog)>]
    let useDialogContext (): DialogContext = jsNative


