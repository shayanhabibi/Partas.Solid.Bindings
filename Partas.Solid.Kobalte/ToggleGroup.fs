namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid
open Partas.Solid.Experimental.U


[<Erase; Import("Root", Spec.toggleGroup)>]
type ToggleGroup() =
    inherit div()
    interface Polymorph
    /// <summary>
    /// The controlled value of the toggle group.
    /// </summary>
    [<Erase>] member val value: U2<string, string[]> = JS.undefined with get,set

    /// <summary>
    /// The value of the select when initially rendered.
    /// Useful when you do not need to control the value.
    /// </summary>
    [<Erase>] member val defaultValue: U2<string, string[]> = JS.undefined with get,set

    /// <summary>
    /// Event handler called when the value changes.
    /// </summary>
    [<Erase>] member val onChange: (U2<string, string[]> -> unit) = JS.undefined with get,set

    /// <summary>
    /// The type of selection that is allowed in the toggle group.
    /// </summary>
    [<Erase>] member val selectionMode: SelectionMode = JS.undefined with get,set

    /// <summary>
    /// Whether the toggle group is disabled.
    /// </summary>
    [<Erase>] member val disabled: bool = JS.undefined with get,set

    /// <summary>
    /// The axis the toggle group items should align with.
    /// </summary>
    [<Erase>] member val orientation: Orientation = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module ToggleGroup =
    [<Erase; Import("Item", Spec.toggleGroup)>]
    type Item() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string  = JS.undefined with get,set
        [<Erase>] member val disabled : bool  = JS.undefined with get,set
        [<Erase>] member val children : Fragment  = JS.undefined with get,set
        [<Erase>] member val pressed : unit -> bool  = JS.undefined with get,set

[<Erase; AutoOpen>]
module ToggleGroupContext =
    [<AllowNullLiteral>]
    [<Interface>]
    type ToggleGroupContext =
        abstract member isMultiple: Accessor<bool> with get, set
        abstract member isDisabled: Accessor<bool> with get, set
        abstract member listState: Accessor<ListState<string>> with get, set
        abstract member generateId: (string -> string) with get, set
        abstract member orientation: Accessor<Orientation> with get, set
    
    [<ImportMember(Spec.toggleGroup)>]
    let useToggleGroupContext(): ToggleGroupContext = jsNative
