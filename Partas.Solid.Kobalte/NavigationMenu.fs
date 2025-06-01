namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.navigationMenu)>]
type NavigationMenu() =
    inherit div()
    interface Polymorph
    member val defaultValue : string = jsNative with get,set
    member val value : string = jsNative with get,set
    member val onValueChange : string -> unit = jsNative with get,set
    member val loop : bool = jsNative with get,set
    member val delayDuration : int = jsNative with get,set
    member val skipDelayDuration : bool = jsNative with get,set
    member val focusOnAlt : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val gutter: int = jsNative with get,set

[<RequireQualifiedAccess; Erase>]
module NavigationMenu =
    [<Erase; Import("Viewport", Spec.navigationMenu)>]
    type Viewport() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Arrow", Spec.navigationMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Menu", Spec.navigationMenu)>]
    type Menu() =
        inherit div()
        interface Polymorph
        member val onOpenChange : (bool -> unit) = jsNative with get,set
        member val id : string = jsNative with get,set
        member val modal : bool = jsNative with get,set
        member val preventScroll : bool = jsNative with get,set
        member val forceMount : bool = jsNative with get,set
        member val value : string = jsNative with get,set

        member val placement : KobaltePlacement = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val flip : bool = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val sameWidth : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("Trigger", Spec.navigationMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.navigationMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        member val onOpenAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onCloseAutoFocus : Browser.Types.Event -> unit = jsNative with get,set
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Item", Spec.navigationMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("ItemIndicator", Spec.navigationMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("RadioGroup", Spec.navigationMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val defaultValue : string = jsNative with get,set
        member val onChange : string -> unit = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("RadioItem", Spec.navigationMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        member val value : string = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("CheckboxItem", Spec.navigationMenu)>]
    type CheckboxItem() =
        inherit div()
        interface Polymorph
        member val checked' : bool = jsNative with get,set
        member val defaultChecked : bool = jsNative with get,set
        member val onChange : bool -> unit = jsNative with get,set
        member val textValue : string = jsNative with get,set
        member val indeterminate : bool = jsNative with get,set
        member val disabled : bool = jsNative with get,set
        member val closeOnSelect : bool = jsNative with get,set
        member val onSelect : unit -> unit = jsNative with get,set
    [<Erase; Import("Sub", Spec.navigationMenu)>]
    type Sub() =
        inherit div()
        interface Polymorph
        member val open' : bool = jsNative with get,set
        member val defaultOpen : bool = jsNative with get,set
        member val onOpenChange : (bool -> unit) = jsNative with get,set

        member val getAnchorRect : HtmlElement -> obj = jsNative with get,set
        member val gutter : int = jsNative with get,set
        member val shift : int = jsNative with get,set
        member val slide : bool = jsNative with get,set
        member val overlap : bool = jsNative with get,set
        member val fitViewport : bool = jsNative with get,set
        member val hideWhenDetached : bool = jsNative with get,set
        member val detachedPadding : int = jsNative with get,set
        member val arrowPadding : int = jsNative with get,set
        member val overflowPadding : int = jsNative with get,set
    [<Erase; Import("SubTrigger", Spec.navigationMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        member val textValue : string = jsNative with get,set
        member val disabled : bool = jsNative with get,set
    [<Erase; Import("SubContent", Spec.navigationMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = jsNative with get,set
        member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = jsNative with get,set
        member val onFocusOutside : Browser.Types.FocusEvent -> unit = jsNative with get,set
        member val onInteractOutside : Browser.Types.Event -> unit = jsNative with get,set
    [<Erase; Import("Icon", Spec.navigationMenu)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.navigationMenu)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Separator", Spec.navigationMenu)>]
    type Separator() =
        inherit hr()
        interface Polymorph
    [<Erase; Import("Group", Spec.navigationMenu)>]
    type Group() =
        inherit div()
        interface Polymorph
    [<Erase; Import("GroupLabel", Spec.navigationMenu)>]
    type GroupLabel() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.navigationMenu)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.navigationMenu)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph


