namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

/// <summary></summary>
/// <param name="data-expanded">Present when the collapsible is expanded</param>
/// <param name="data-closed">Present when the collapsible is closed</param>
/// <param name="data-disabled">Present when the collapsible is disabled</param>
[<Erase; Import("Root", Spec.collapsible)>]
type Collapsible() =
    inherit div()
    interface Polymorph
    member val open' : bool = jsNative with get,set // v0.13.9
    member val defaultOpen : bool = jsNative with get,set // v0.13.9
    member val onOpenChange : bool -> unit = jsNative with get,set // v0.13.9
    member val disabled : bool = jsNative with get,set // v0.13.9
    member val forceMount : bool = jsNative with get,set // v0.13.9

[<RequireQualifiedAccess; Erase>]
module Collapsible =
    /// <summary></summary>
    /// <param name="data-expanded">Present when the collapsible is expanded</param>
    /// <param name="data-closed">Present when the collapsible is closed</param>
    /// <param name="data-disabled">Present when the collapsible is disabled</param>
    [<Erase; Import("Trigger", Spec.collapsible)>]
    type Trigger() = // v0.13.9
        inherit button()
        interface Polymorph
    /// <summary></summary>
    /// <param name="data-expanded">Present when the collapsible is expanded</param>
    /// <param name="data-closed">Present when the collapsible is closed</param>
    /// <param name="data-disabled">Present when the collapsible is disabled</param>
    [<Erase; Import("Content", Spec.collapsible)>]
    type Content() = // v0.13.9
        interface RegularNode
        interface Polymorph

[<Erase; AutoOpen>]
module CollapsibleContext =
    [<AllowNullLiteral>]
    [<Interface>]
    type CollapsibleDataSet =
        abstract member ``data-expanded``: string option with get, set
        abstract member ``data-closed``: string option with get, set
        abstract member ``data-disabled``: string option with get, set
    [<AllowNullLiteral; Interface>]
    type CollapsibleContext =
        abstract member dataset: Accessor<CollapsibleDataSet> with get, set
        abstract member isOpen: Accessor<bool> with get, set
        abstract member disabled: Accessor<bool> with get, set
        abstract member shouldMount: Accessor<bool> with get, set
        abstract member contentId: Accessor<string option> with get, set
        abstract member toggle: (unit -> unit) with get, set
        abstract member generateId: (string -> string) with get, set
        abstract member registerContentId: (string -> (unit -> unit)) with get, set
        
    [<Import("useCollapsibleContext", Spec.collapsible)>]
    let useCollapsibleContext (): CollapsibleContext = jsNative
