namespace Partas.Solid.ZagJs

open Browser.Types
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS

[<Erase>]
module Dialog =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Content
            | Title
            | Trigger
            | Backdrop
            | Positioner
            | Description
            | CloseTrigger

    [<AllowNullLiteral>]
    [<Interface>]
    type OpenChangeDetails =
        abstract member ``open``: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ElementIds =
        abstract member trigger: string with get, set
        abstract member positioner: string with get, set
        abstract member backdrop: string with get, set
        abstract member content: string with get, set
        abstract member closeTrigger: string with get, set
        abstract member title: string with get, set
        abstract member description: string with get, set
    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.LowerAll)>]
    type Role =
        | Dialog
        | AlertDialog

[<Interface>]
type DialogProps =
    inherit DirectionProperty
    inherit CommonProperties
    inherit DismissableElementHandlers
    inherit PersistentElementOptions
    /// <summary>
    /// The ids of the elements in the dialog. Useful for composition.
    /// </summary>
    abstract member ids: Dialog.ElementIds with get, set
    /// <summary>
    /// Whether to trap focus inside the dialog when it's opened
    /// </summary>
    abstract member trapFocus: bool with get, set
    /// <summary>
    /// Whether to prevent scrolling behind the dialog when it's opened
    /// </summary>
    abstract member preventScroll: bool with get, set
    /// <summary>
    /// Whether to prevent pointer interaction outside the element and hide all content below it
    /// </summary>
    abstract member modal: bool with get, set
    /// <summary>
    /// Element to receive focus when the dialog is opened
    /// </summary>
    abstract member initialFocusEl: (unit -> Element option) with get, set
    /// <summary>
    /// Element to receive focus when the dialog is closed
    /// </summary>
    abstract member finalFocusEl: (unit -> Element option) with get, set
    /// <summary>
    /// Whether to restore focus to the element that had focus before the dialog was opened
    /// </summary>
    abstract member restoreFocus: bool with get, set
    /// <summary>
    /// Whether to close the dialog when the outside is clicked
    /// </summary>
    abstract member closeOnInteractOutside: bool with get, set
    /// <summary>
    /// Whether to close the dialog when the escape key is pressed
    /// </summary>
    abstract member closeOnEscape: bool with get, set
    /// <summary>
    /// Human readable label for the dialog, in event the dialog title is not rendered
    /// </summary>
    abstract member ``aria-label``: string option with get, set
    /// <summary>
    /// The dialog's role
    /// </summary>
    abstract member role: Dialog.Role with get, set
    /// <summary>
    /// The controlled open state of the dialog
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// The initial open state of the dialog when rendered.
    /// Use when you don't need to control the open state of the dialog.
    /// </summary>
    abstract member defaultOpen: bool with get, set
    /// <summary>
    /// Function to call when the dialog's open state changes
    /// </summary>
    abstract member onOpenChange: (Dialog.OpenChangeDetails -> unit) with get, set

[<AllowNullLiteral>]
[<Interface>]
type DialogApi =
    /// <summary>
    /// Whether the dialog is open
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// Function to open or close the dialog
    /// </summary>
    abstract member setOpen: (bool -> unit) with get, set
    abstract member getTriggerProps: (unit -> button) with get, set
    abstract member getBackdropProps: (unit -> HtmlTag) with get, set
    abstract member getPositionerProps: (unit -> HtmlTag) with get, set
    abstract member getContentProps: (unit -> HtmlTag) with get, set
    abstract member getTitleProps: (unit -> HtmlTag) with get, set
    abstract member getDescriptionProps: (unit -> HtmlTag) with get, set
    abstract member getCloseTriggerProps: (unit -> button) with get, set





