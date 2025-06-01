namespace Partas.Solid.Kobalte

open Fable.Core
open Fable.Core.JsInterop
open Partas.Solid


[<Erase; Import("Root", Spec.select)>]
type Select<'T>() =
    inherit div()
    interface Polymorph
    member val options : 'T[] = jsNative with get,set
    member val optionValue : 'T -> U3<string, float, int> = jsNative with get,set
    member val optionTextValue : 'T -> string = jsNative with get,set
    member val optionDisabled : 'T -> bool = jsNative with get,set
    member val optionGroupChildren : string = jsNative with get,set
    member val itemComponent : ItemComponentProps<'T> -> HtmlElement = jsNative with get,set
    member val sectionComponent : SectionComponentProps<'T> -> HtmlElement = jsNative with get,set
    member val multiple : bool = jsNative with get,set
    member val placeholder : HtmlElement = jsNative with get,set
    member val value : 'T = jsNative with get,set
    member this.values
        with inline set(values: 'T[]) = this.value <- !!values 
    member val defaultValue : 'T = jsNative with get,set
    member this.defaultValues
        with inline set(values: 'T[]) = this.defaultValue <- !!values
    member val onChange : 'T -> unit = jsNative with get,set
    member this.onChanges
        with inline set(handler: 'T[] -> unit) = this.onChange <- !!handler
    member val open' : bool = jsNative with get,set
    member val defaultOpen : bool = jsNative with get,set
    member val onOpenChange : (bool -> unit) = jsNative with get,set
    member val allowDuplicateSelectionEvents : bool = jsNative with get,set
    member val disallowEmptySelection : bool = jsNative with get,set
    member val closeOnSelection : bool = jsNative with get,set
    member val selectionBehavior : SelectionBehavior = jsNative with get,set
    member val virtualized : bool = jsNative with get,set
    member val modal : bool = jsNative with get,set
    member val preventScroll : bool = jsNative with get,set
    member val forceMount : bool = jsNative with get,set
    member val name : string = jsNative with get,set
    member val validationState : ValidationState = jsNative with get,set
    member val required : bool = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val readOnly : bool = jsNative with get,set
    member val autoComplete : string = jsNative with get,set

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
        inherit div()
        interface Polymorph
        interface ChildLambdaProvider<ValueState<'T>>
        member val selectedOption : 'T Accessor = jsNative with get,set
        member val selectedOptions : 'T[] Accessor = jsNative with get,set
        member val remove : 'T -> unit = jsNative with get,set
        member val clear : unit -> unit = jsNative with get,set
    [<Erase; Import("Icon", Spec.select)>]
    type Icon() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.select)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
    [<Erase; Import("Content", Spec.select)>]
    type Content() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Arrow", Spec.select)>]
    type Arrow() =
        inherit div()
        interface Polymorph
        member val size : int = jsNative with get,set
    [<Erase; Import("Listbox", Spec.select)>]
    type Listbox() =
        inherit div()
        interface Polymorph
        member val scrollRef : unit -> HtmlElement = jsNative with get,set
        member val scrollToItem : string -> unit = jsNative with get,set
        member val children : obj[] -> HtmlElement = jsNative with get,set
    [<Erase; Import("Item", Spec.select)>]
    type Item'<'T>() =
        inherit div()
        interface Polymorph
        member val item : 'T = jsNative with get,set
    type Item = Item'<obj>
    [<Erase; Import("ItemIndicator", Spec.select)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set
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

