namespace Partas.Solid.Kobalte

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Partas.Solid


[<Erase; Import("Root", Spec.select)>]
type Select<'T>() =
    inherit div()
    interface Polymorph
    [<Erase>] member val options : 'T[] = JS.undefined with get,set
    [<Erase>] member val optionValue : 'T -> U3<string, float, int> = JS.undefined with get,set
    [<Erase>] member val optionTextValue : 'T -> string = JS.undefined with get,set
    [<Erase>] member val optionDisabled : 'T -> bool = JS.undefined with get,set
    [<Erase>] member val optionGroupChildren : string = JS.undefined with get,set
    [<Erase>] member val itemComponent : ItemComponentProps<'T> -> HtmlElement = JS.undefined with get,set
    [<Erase>] member val sectionComponent : SectionComponentProps<'T> -> HtmlElement = JS.undefined with get,set
    [<Erase>] member val multiple : bool = JS.undefined with get,set
    [<Erase>] member val placeholder : HtmlElement = JS.undefined with get,set
    [<Erase>] member val value : 'T = JS.undefined with get,set
    member this.values
        with inline set(values: 'T[]) = this.value <- !!values 
    [<Erase>] member val defaultValue : 'T = JS.undefined with get,set
    member this.defaultValues
        with inline set(values: 'T[]) = this.defaultValue <- !!values
    [<Erase>] member val onChange : 'T -> unit = JS.undefined with get,set
    member this.onChanges
        with inline set(handler: 'T[] -> unit) = this.onChange <- !!handler
    [<Erase>] member val open' : bool = JS.undefined with get,set
    [<Erase>] member val defaultOpen : bool = JS.undefined with get,set
    [<Erase>] member val onOpenChange : (bool -> unit) = JS.undefined with get,set
    [<Erase>] member val allowDuplicateSelectionEvents : bool = JS.undefined with get,set
    [<Erase>] member val disallowEmptySelection : bool = JS.undefined with get,set
    [<Erase>] member val closeOnSelection : bool = JS.undefined with get,set
    [<Erase>] member val selectionBehavior : SelectionBehavior = JS.undefined with get,set
    [<Erase>] member val virtualized : bool = JS.undefined with get,set
    [<Erase>] member val modal : bool = JS.undefined with get,set
    [<Erase>] member val preventScroll : bool = JS.undefined with get,set
    [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase>] member val name : string = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState = JS.undefined with get,set
    [<Erase>] member val required : bool = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase>] member val readOnly : bool = JS.undefined with get,set
    [<Erase>] member val autoComplete : string = JS.undefined with get,set
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
    [<Erase>] member val overflowPadding : int= JS.undefined with get,set
[<Erase; Import("Root", Spec.select)>]
type Select() =
    inherit Select<obj>()
[<RequireQualifiedAccess; Erase>]
module Select =
    [<Interface; Erase>]
    type ValueState<'T> =
        abstract selectedOption: Accessor<'T>
        abstract selectedOptions: Accessor<'T[]>
        abstract remove: ('T -> unit)
        abstract clear: (unit -> unit)
    [<Erase; Import("Trigger", Spec.select)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Value", Spec.select)>]
    type Value<'T>() =
        interface HtmlTag
        interface Polymorph
        interface ChildLambdaProvider<ValueState<'T>>
        [<Erase>] member val selectedOption : 'T Accessor = JS.undefined with get,set
        [<Erase>] member val selectedOptions : 'T[] Accessor = JS.undefined with get,set
        [<Erase>] member val remove : 'T -> unit = JS.undefined with get,set
        [<Erase>] member val clear : unit -> unit = JS.undefined with get,set
    [<Erase; Import("Value", Spec.select)>]
    type Value() =
        inherit Value<obj>()
    [<Erase; Import("Icon", Spec.select)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.select)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("Content", Spec.select)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", Spec.select)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        [<Erase>] member val size : int = JS.undefined with get,set
    [<Erase; Import("Listbox", Spec.select)>]
    type Listbox() =
        inherit div()
        interface Polymorph
        [<Erase>] member val scrollRef : unit -> HtmlElement = JS.undefined with get,set
        [<Erase>] member val scrollToItem : string -> unit = JS.undefined with get,set
        [<Erase>] member val children : obj[] -> HtmlElement = JS.undefined with get,set
    [<Erase; Import("Item", Spec.select)>]
    type Item<'T>() =
        inherit div()
        interface Polymorph
        [<Erase>] member val item : 'T = JS.undefined with get,set
    type Item = Item<obj>
    [<Erase; Import("ItemIndicator", Spec.select)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("Label", Spec.select)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Description", Spec.select)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Portal", Spec.select)>]
    type Portal() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Section", Spec.select)>]
    type Section() =
        inherit li()
        interface Polymorph
    [<Erase; Import("ItemLabel", Spec.select)>]
    type ItemLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemDescription", Spec.select)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph
    [<Erase; Import("HiddenSelect", Spec.select)>]
    type HiddenSelect() =
        inherit div()
        interface Polymorph


[<Erase; AutoOpen>]
module SelectContext =
    [<StringEnum; RequireQualifiedAccess>]
    type FocusStrategy =
        | First
        | Last
    [<AllowNullLiteral; Interface>]
    type SelectDataSet =
        abstract ``data-expanded``: string option
        abstract ``data-closed``: string option
    
    [<AllowNullLiteral; Interface>]
    type SelectContext =
        abstract dataset: Accessor<SelectDataSet>
        abstract isOpen: Accessor<bool>
        abstract isDisabled: Accessor<bool>
        abstract isMultiple: Accessor<bool>
        abstract isVirtualized: Accessor<bool>
        abstract isModal: Accessor<bool>
        abstract preventScroll: Accessor<bool>
        abstract disallowTypeAhead: Accessor<bool>
        abstract shouldFocusWrap: Accessor<bool>
        abstract selectedOptions: Accessor<obj[]>
        abstract contentPresent: Accessor<bool>
        abstract autoFocus: Accessor<U2<FocusStrategy, bool>>
        abstract triggerRef: Accessor<HTMLElement option>
        abstract triggerId: Accessor<string option>
        abstract valueId: Accessor<string option>
        abstract listboxId: Accessor<string option>
        abstract listboxAriaLabelledBy: Accessor<string option>
        abstract listState: Accessor<ListState<string>>
        abstract keyboardDelegate: Accessor<KeyboardDelegate>
        abstract setListboxAriaLabelledBy: Setter<string option>
        abstract setTriggerRef: HTMLElement -> unit
        abstract setContentRef: HTMLElement -> unit
        abstract setListboxRef: HTMLElement -> Unit
        abstract open': U2<FocusStrategy, bool> -> unit
        abstract close: unit -> unit
        abstract toggle: U2<FocusStrategy, bool> -> unit
        abstract placeholder: Accessor<HtmlElement>
        abstract renderItem: CollectionNode<obj> -> HtmlElement
        abstract renderSection: CollectionNode<obj> -> HtmlElement
        abstract removeOptionFromSelection: obj -> unit
        abstract generateId: string -> string
        abstract registerTriggerId: string -> (unit -> unit)
        abstract registerValueId: string -> (unit -> unit)
        abstract registerListboxId: string -> (unit -> unit)
    [<ImportMember(Spec.select)>]
    let useSelectContext(): SelectContext = jsNative
        
