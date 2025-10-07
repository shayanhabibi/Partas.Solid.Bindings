namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.navigationMenu)>]
type NavigationMenu() =
    inherit div()
    interface Polymorph
    [<Erase>] member val defaultValue : string  = JS.undefined with get,set
    [<Erase>] member val value : string  = JS.undefined with get,set
    [<Erase>] member val onValueChange : string -> unit  = JS.undefined with get,set
    [<Erase>] member val loop : bool  = JS.undefined with get,set
    [<Erase>] member val delayDuration : int  = JS.undefined with get,set
    [<Erase>] member val skipDelayDuration : bool  = JS.undefined with get,set
    [<Erase>] member val focusOnAlt : bool  = JS.undefined with get,set
    [<Erase>] member val forceMount : bool  = JS.undefined with get,set
    [<Erase>] member val gutter: int  = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module NavigationMenu =
    [<Erase; Import("Viewport", Spec.navigationMenu)>]
    type Viewport() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Arrow", Spec.navigationMenu)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    [<Erase; Import("Menu", Spec.navigationMenu)>]
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
    [<Erase; Import("Trigger", Spec.navigationMenu)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Content", Spec.navigationMenu)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onOpenAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onCloseAutoFocus : Browser.Types.Event -> unit = JS.undefined with get,set
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
    [<Erase; Import("Item", Spec.navigationMenu)>]
    type Item() =
        inherit div()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    [<Erase; Import("ItemIndicator", Spec.navigationMenu)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("RadioGroup", Spec.navigationMenu)>]
    type RadioGroup() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val defaultValue : string = JS.undefined with get,set
        [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("RadioItem", Spec.navigationMenu)>]
    type RadioItem() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
        [<Erase>] member val closeOnSelect : bool = JS.undefined with get,set
        [<Erase>] member val onSelect : unit -> unit = JS.undefined with get,set
    [<Erase; Import("CheckboxItem", Spec.navigationMenu)>]
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
    [<Erase; Import("Sub", Spec.navigationMenu)>]
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
    [<Erase; Import("SubTrigger", Spec.navigationMenu)>]
    type SubTrigger() =
        inherit Button()
        interface Polymorph
        [<Erase>] member val textValue : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("SubContent", Spec.navigationMenu)>]
    type SubContent() =
        inherit div()
        interface Polymorph
        [<Erase>] member val onEscapeKeyDown : Browser.Types.KeyboardEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onPointerDownOutside : Browser.Types.PointerEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onFocusOutside : Browser.Types.FocusEvent -> unit = JS.undefined with get,set
        [<Erase>] member val onInteractOutside : Browser.Types.Event -> unit = JS.undefined with get,set
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


[<Erase; AutoOpen>]
module NavigationMenuContext =
    [<AllowNullLiteral; Interface>]
    type NavigationMenuDataSet =
        abstract ``data-expanded``: string option
        abstract ``data-closed``: string option
    [<AllowNullLiteral; Interface>]
    type NavigationMenuContext =
        abstract dataset: Accessor<NavigationMenuDataSet>
        abstract delayDuration: Accessor<float>
        abstract skipDelayDuration: Accessor<float>
        abstract autoFocusMenu: Accessor<bool>
        abstract setAutoFocusMenu: Setter<bool>
        abstract startLeaveTimer: unit -> unit
        abstract cancelLeaveTimer: unit -> unit
        abstract rootRef: Accessor<Browser.Types.HTMLElement option>
        abstract setRootRef: Setter<Browser.Types.HTMLElement>
        abstract viewportRef: Accessor<Browser.Types.HTMLElement option>
        abstract setViewportRef: Setter<Browser.Types.HTMLElement>
        abstract viewportPresent: Accessor<bool>
        abstract currentPlacement: Accessor<KobaltePlacement>
        abstract previousMenu: Accessor<string option>
        abstract setPreviousMenu: Setter<string option>
    [<ImportMember(Spec.navigationMenu)>]
    let useNavigationMenuContext(): NavigationMenuContext = jsNative
        
