namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.alertDialog)>]
type AlertDialog() =
    interface RegularNode
    interface Polymorph
    /// <summary>
    /// The controlled open state of the dialog
    /// </summary>
    [<Erase>] member val open': bool = JS.undefined with get,set
    /// <summary>
    /// The default open state when initially rendered. Useful when you do not need to control the open state.
    /// </summary>
    [<Erase>] member val defaultOpen : bool = JS.undefined with get,set
    /// <summary>
    /// Event handler called when the open state of the dialog changes.
    /// </summary>
    [<Erase>] member val onOpenChange : bool -> unit = JS.undefined with get,set
    /// <summary>
    /// A unique identifier for the component. The id is used to generate id attributes for nested components.
    /// If no id prop is provided, a generated id will be used.
    /// </summary>
    [<Erase>] member val id : string = JS.undefined with get,set
    /// <summary>
    /// Whether the dialog should be the only visible content for screen readers.<br/>
    /// When `true`:<br/>
    /// * interaction with outside elements will be disabled.<br/>
    /// * scroll will be locked<br/>
    /// * focus will be locked inside the dialog content<br/>
    /// * elements outside the dialog content will not be visible for screen readers<br/>
    /// </summary>
    [<Erase>] member val modal : bool = JS.undefined with get,set
    /// <summary>
    /// Whether the scroll should be locked even if the alert dialog is not modal.
    /// </summary>
    [<Erase>] member val preventScroll : bool = JS.undefined with get,set
    /// <summary>
    /// Used to force mounting the dialog (portal, overlay and content) when more control is needed. Useful when
    /// controlling animation with SolidJS animation libraries.
    /// </summary>
    [<Erase>] member val forceMount : bool = JS.undefined with get,set

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
        /// <summary>
        /// Event handler called when focus moves into the component after opening. It can be prevent by calling
        /// `event.preventDefault`
        /// </summary>
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        /// <summary>
        /// Event handler called when focus moves to the trigger after closing. It can be prevented by calling
        /// `event.preventDefault`.
        /// </summary>
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        /// <summary>
        /// Event handler cal;led when the escape key is down. It can be prevented by calling `event.preventDefault`
        /// </summary>
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        /// <summary>
        /// Event handler called when a pointer event occurs outside the bounds of the component. It can be prevented
        /// by calling `event.preventDefault`.
        /// </summary>
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        /// <summary>
        /// Event handler called when the focus moves outside the bounds of the component. It can be prevented by
        /// calling `event.preventDefault`.
        /// </summary>
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        /// <summary>
        /// Event handler called when an interaction (pointer or focus event) happens outside the bounds of the component.
        /// It can be prevented by calling `event.preventDefault`.
        /// </summary>
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
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
