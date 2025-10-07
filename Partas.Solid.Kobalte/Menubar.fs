namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid



[<Erase; Import("Root", Spec.menubar)>]
type Menubar() =
    interface RegularNode
    interface Polymorph
    [<Erase>] member val defaultValue : string  = JS.undefined with get,set
    [<Erase>] member val value : string  = JS.undefined with get,set
    [<Erase>] member val onValueChange : string -> unit  = JS.undefined with get,set
    [<Erase>] member val loop : bool  = JS.undefined with get,set
    [<Erase>] member val focusOnAlt : bool  = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module Menubar =
    [<Erase; Import("Menu", Spec.menubar)>]
    type Menu() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onOpenChange : (bool -> unit) = JS.undefined with get,set
        [<Erase>] member val id : string = JS.undefined with get,set
        [<Erase>] member val modal : bool = JS.undefined with get,set
        [<Erase>] member val preventScroll : bool = JS.undefined with get,set
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
        [<Erase>] member val value : string = JS.undefined with get,set
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
    [<Erase; Import("Trigger", Spec.menubar)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.menubar)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Arrow", Spec.menubar)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    [<Erase; Import("Item", Spec.menubar)>]
    type Item() =
        inherit div()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    [<Erase; Import("ItemIndicator", Spec.menubar)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("RadioGroup", Spec.menubar)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val defaultValue : string = JS.undefined with get,set
        [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("RadioItem", Spec.menubar)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    [<Erase; Import("CheckboxItem", Spec.menubar)>]
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
    [<Erase; Import("Sub", Spec.menubar)>]
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
    [<Erase; Import("SubTrigger", Spec.menubar)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("SubContent", Spec.menubar)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Icon", Spec.menubar)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.menubar)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.menubar)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.menubar)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.menubar)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.menubar)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.menubar)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

[<Erase; AutoOpen>]
module MenubarContext =
    [<AllowNullLiteral; Interface>]
    type MenubarDataSet =
        abstract ``data-expanded``: string option with get,set
        abstract ``data-closed``: string option with get,set
    
    [<AllowNullLiteral; Interface>]
    type MenubarContext =
        abstract dataset: Accessor<MenubarDataSet>
        abstract value: Accessor<string option>
        abstract setValue: (string option -> string option) -> unit
        abstract menus: Accessor<Set<string>>
        abstract menuRefs: Accessor<Browser.Types.HTMLElement array>
        abstract menuRefMap: Accessor<Map<string, Browser.Types.HTMLElement[]>>
        abstract lastValue: Accessor<string option>
        abstract setLastValue: (string option -> string option) -> unit
        abstract registerMenu: (string * HtmlElement[]) -> unit
        abstract unregisterMenu: string -> unit
        abstract nextMenu: unit -> unit
        abstract previousMenu: unit -> unit
        abstract closeMenu: unit -> unit
        abstract setAutoFocusMenu: Setter<bool>
        abstract autoFocusMenu: Accessor<bool>
        abstract generateId: string -> string
        abstract orientation: Accessor<Orientation>
    [<ImportMember(Spec.menubar)>]
    let useMenubarContext(): MenubarContext = jsNative
