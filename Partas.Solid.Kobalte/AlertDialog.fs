namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.alertDialog)>]
type AlertDialog() =
    interface RegularNode
    interface Polymorph
    member val open' : bool = jsNative with get,set //v0.13.9
    member val defaultOpen : bool = jsNative with get,set //v0.13.9
    member val onOpenChange : bool -> unit = jsNative with get,set //v0.13.9
    member val id : string = jsNative with get,set //v0.13.9
    member val modal : bool = jsNative with get,set //v0.13.9
    member val preventScroll : bool = jsNative with get,set //v0.13.9
    member val forceMount : bool = jsNative with get,set //v0.13.9

[<Erase; RequireQualifiedAccess>]
module AlertDialog =
    /// <summary>
    /// data-expanded: Present when the dialog is open<br/>
    /// data-closed: Present when the dialog is closed
    /// </summary>
    [<Erase; Import("Trigger", Spec.alertDialog)>]
    type Trigger() =
        inherit Button() //v0.13.9
        interface Polymorph
    /// <summary>
    /// data-expanded: Present when the dialog is open<br/>
    /// data-closed: Present when the dialog is closed
    /// </summary>
    [<Erase; Import("Content", Spec.alertDialog)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set //v0.13.9
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set //v0.13.9
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set //v0.13.9
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set //v0.13.9
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set //v0.13.9
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set //v0.13.9
    [<Erase; Import("Portal", Spec.alertDialog)>]
    type Portal() = //v0.13.9
        inherit div()
        interface Polymorph
    /// <summary>
    /// data-expanded: Present when the dialog is open<br/>
    /// data-closed: Present when the dialog is closed
    /// </summary>
    [<Erase; Import("Overlay", Spec.alertDialog)>]
    type Overlay() = //v0.13.9
        inherit div()
        interface Polymorph
    [<Erase; Import("CloseButton", Spec.alertDialog)>]
    type CloseButton() = //v0.13.9
        inherit Button()
        interface Polymorph
    [<Erase; Import("Title", Spec.alertDialog)>]
    type Title() = //v0.13.9
        inherit h2()
        interface Polymorph
    [<Erase; Import("Description", Spec.alertDialog)>]
    type Description() = //v0.13.9
        inherit p()
        interface Polymorph
