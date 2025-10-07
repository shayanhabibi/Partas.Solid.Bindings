namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.contextMenu)>]
type ContextMenu() =
    interface RegularNode
    interface Polymorph
    [<Erase>] member val onOpenChange : bool -> unit = JS.undefined with get,set
    [<Erase>] member val id : string = JS.undefined with get,set
    [<Erase>] member val modal : bool = JS.undefined with get,set
    [<Erase>] member val preventScroll : bool = JS.undefined with get,set
    [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase>] member val placement : KobaltePlacement = JS.undefined with get,set
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
module ContextMenu =
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    /// <param name="data-closed">Present when the trigger is closed</param>
    /// <param name="data-disabled">Present when the trigger is disabled</param>
    [<Erase ; Import("Trigger", Spec.contextMenu)>]
    type Trigger() = // v0.13.9
        inherit Button()
        interface Polymorph
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase ; Import("Content", Spec.contextMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase ; Import("Arrow", Spec.contextMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase ; Import("Item", Spec.contextMenu)>]    
    type Item() =
        inherit div()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("ItemIndicator", Spec.contextMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool  = JS.undefined with get,set
    [<Erase; Import("RadioGroup", Spec.contextMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val defaultValue : string = JS.undefined with get,set
        [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-checked">Present when the item is checked</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("RadioItem", Spec.contextMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    /// <param name="data-disabled">Present when the item is disabled</param>
    /// <param name="data-indeterminate">Present when the item is indeterminate</param>
    /// <param name="data-checked">Present when the item is checked</param>
    /// <param name="data-highlighted">Present when the item is highlighted</param>
    [<Erase; Import("CheckboxItem", Spec.contextMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        [<Erase>] member val checked' : bool = JS.undefined with get,set
        [<Erase>] member val defaultChecked : bool = JS.undefined with get,set
        [<Erase>] member val onChange : bool -> unit = JS.undefined with get,set
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val indeterminate : bool = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    [<Erase; Import("Sub", Spec.contextMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        [<Erase>] member val open' : bool = JS.undefined with get,set
        [<Erase>] member val defaultOpen : bool = JS.undefined with get,set
        [<Erase>] member val onOpenChange : (bool -> unit) = JS.undefined with get,set
        [<Erase>] member val getAnchorRect : HtmlElement -> obj = JS.undefined with get,set
        [<Erase>] member val gutter : int = JS.undefined with get,set
        [<Erase>] member val shift : int = JS.undefined with get,set
        [<Erase>] member val slide : bool = JS.undefined with get,set
        [<Erase>] member val overlap : bool = JS.undefined with get,set
        [<Erase>] member val fitViewport : bool = JS.undefined with get,set
        [<Erase>] member val hideWhenDetached : bool = JS.undefined with get,set
        [<Erase>] member val detachedPadding : int = JS.undefined with get,set
        [<Erase>] member val arrowPadding : int = JS.undefined with get,set
        [<Erase>] member val overflowPadding : int = JS.undefined with get,set
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("SubTrigger", Spec.contextMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    /// <param name="data-expanded">Present when the trigger is expanded</param>
    [<Erase; Import("SubContent", Spec.contextMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
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


[<Erase; AutoOpen>]
module ContextMenuContext =
    [<AllowNullLiteral; Interface>]
    type ContextMenuContext =
        abstract setAnchorRect: Setter<{|x: float; y: float|}>
    
    [<ImportMember(Spec.contextMenu)>]
    let useContextMenuContext(): ContextMenuContext = jsNative
