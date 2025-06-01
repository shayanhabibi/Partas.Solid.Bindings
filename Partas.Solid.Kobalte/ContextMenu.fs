namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.contextMenu)>]
type ContextMenu() =
    interface RegularNode
    interface Polymorph
    member val onOpenChange : bool -> unit = jsNative with get,set // v0.13.9
    member val id : string = jsNative with get,set // v0.13.9
    member val modal : bool = jsNative with get,set // v0.13.9
    member val preventScroll : bool = jsNative with get,set // v0.13.9
    member val forceMount : bool = jsNative with get,set // v0.13.9

    member val placement : KobaltePlacement = jsNative with get,set // v0.13.9
    member val gutter : int = jsNative with get,set // v0.13.9
    member val shift : int = jsNative with get,set // v0.13.9
    member val flip : bool = jsNative with get,set // v0.13.9
    member val slide : bool = jsNative with get,set // v0.13.9
    member val overlap : bool = jsNative with get,set // v0.13.9
    member val sameWidth : bool = jsNative with get,set // v0.13.9
    member val fitViewport : bool = jsNative with get,set // v0.13.9
    member val hideWhenDetached : bool = jsNative with get,set // v0.13.9
    member val detachedPadding : int = jsNative with get,set // v0.13.9
    member val arrowPadding : int = jsNative with get,set // v0.13.9
    member val overflowPadding : int = jsNative with get,set // v0.13.9

[<RequireQualifiedAccess; Erase>]
module ContextMenu =
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    /// <param name="data-closed">Present when the trigger is closed</param>
    /// <param name="data-disabled">Present when the trigger is disabled</param>
    [<Erase ; Import("Trigger", Spec.contextMenu)>]
    type Trigger() = // v0.13.9
        inherit Button()
        interface Polymorph
        member val disabled : bool = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase ; Import("Content", Spec.contextMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set // v0.13.9
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set // v0.13.9
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set // v0.13.9
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
    [<Erase ; Import("Arrow", Spec.contextMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase ; Import("Item", Spec.contextMenu)>]    
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
        member val closeOnSelect : bool = jsNative with get,set // v0.13.9
        member val onSelect : unit -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemIndicator", Spec.contextMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set // v0.13.9
    [<Erase; Import("RadioGroup", Spec.contextMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set // v0.13.9
        member val defaultValue : string = jsNative with get,set // v0.13.9
        member val onChange : string -> unit = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-checked">Present when the item is checked</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("RadioItem", Spec.contextMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set // v0.13.9
        member val textValue : string = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
        member val closeOnSelect : bool = jsNative with get,set // v0.13.9
        member val onSelect : unit -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-indeterminate">Present when the item is indeterminate</param>
    /// <param name="data-checked">Present when the item is checked</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("CheckboxItem", Spec.contextMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set // v0.13.9
        member val defaultChecked : bool = jsNative with get,set // v0.13.9
        member val onChange : bool -> unit = jsNative with get,set // v0.13.9
        member val textValue : string = jsNative with get,set // v0.13.9
        member val indeterminate : bool = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
        member val closeOnSelect : bool = jsNative with get,set // v0.13.9
        member val onSelect : unit -> unit = jsNative with get,set // v0.13.9
    [<Erase; Import("Sub", Spec.contextMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set // v0.13.9
        member val defaultOpen : bool = jsNative with get,set // v0.13.9
        member val onOpenChange : (bool -> unit) = jsNative with get,set // v0.13.9

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set // v0.13.9
        member val gutter : int = jsNative with get,set // v0.13.9
        member val shift : int = jsNative with get,set // v0.13.9
        member val slide : bool = jsNative with get,set // v0.13.9
        member val overlap : bool = jsNative with get,set // v0.13.9
        member val fitViewport : bool = jsNative with get,set // v0.13.9
        member val hideWhenDetached : bool = jsNative with get,set // v0.13.9
        member val detachedPadding : int = jsNative with get,set // v0.13.9
        member val arrowPadding : int = jsNative with get,set // v0.13.9
        member val overflowPadding : int = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("SubTrigger", Spec.contextMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set // v0.13.9
        member val disabled : bool = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("SubContent", Spec.contextMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set // v0.13.9
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set // v0.13.9
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set // v0.13.9
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set // v0.13.9
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("Icon", Spec.contextMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.contextMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.contextMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.contextMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.contextMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemLabel", Spec.contextMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemDescription", Spec.contextMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

