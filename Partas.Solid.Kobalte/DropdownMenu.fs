namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.dropdownMenu)>]
type DropdownMenu() =
    interface RegularNode
    interface Polymorph
    [<Erase>] member val onOpenChange : (bool -> unit) = JS.undefined with get,set
    [<Erase>] member val id : string = JS.undefined with get,set
    [<Erase>] member val modal : bool = JS.undefined with get,set
    [<Erase>] member val preventScroll : bool = JS.undefined with get,set
    [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase>] member val getAnchorRect: HtmlElement -> obj = JS.undefined with get,set
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
module DropdownMenu =
    [<Erase; Import("Trigger", Spec.dropdownMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.dropdownMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit  = JS.undefined with get,set
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit  = JS.undefined with get,set
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit  = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit  = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit  = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit  = JS.undefined with get,set
    [<Erase; Import("Arrow", Spec.dropdownMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    [<Erase; Import("Item", Spec.dropdownMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        [<Erase>] member val textValue : string  = JS.undefined with get,set
        [<Erase>] member val disabled : bool  = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool  = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit  = JS.undefined with get,set
    [<Erase; Import("ItemIndicator", Spec.dropdownMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("RadioGroup", Spec.dropdownMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val defaultValue : string = JS.undefined with get,set
        [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("RadioItem", Spec.dropdownMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    [<Erase; Import("CheckboxItem", Spec.dropdownMenu)>]
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
    [<Erase; Import("Sub", Spec.dropdownMenu)>]
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

    [<Erase; Import("SubTrigger", Spec.dropdownMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("SubContent", Spec.dropdownMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Icon", Spec.dropdownMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.dropdownMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.dropdownMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.dropdownMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.dropdownMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.dropdownMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.dropdownMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
