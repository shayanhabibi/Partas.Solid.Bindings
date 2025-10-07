namespace Partas.Solid.Kobalte

open Browser.Types
open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.tabs)>]
type Tabs() =
    inherit div()
    interface Polymorph
    [<Erase>] member val value : string = JS.undefined with get,set
    [<Erase>] member val defaultValue : string = JS.undefined with get,set
    [<Erase>] member val onChange : string -> unit = JS.undefined with get,set
    [<Erase>] member val orientation : Orientation = JS.undefined with get,set
    [<Erase>] member val activationMode : ActivationMode = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set

[<RequireQualifiedAccess; Erase>]
module Tabs =
    [<Erase; Import("Trigger", Spec.tabs)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("Content", Spec.tabs)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<Erase>] member val value : string = JS.undefined with get,set
        [<Erase>] member val forceMount : bool = JS.undefined with get,set
    [<Erase; Import("List", Spec.tabs)>]
    type List() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Indicator", Spec.tabs)>]
    type Indicator() =
        inherit div()
        interface Polymorph


[<Erase; AutoOpen>]
module TabsContext =
    [<AllowNullLiteral; Interface>]
    type SingleSelectListState =
        inherit ListState<obj>
        abstract selectedItem: Accessor<CollectionNode<obj> option>
        abstract selectedKey: Accessor<string option>
        abstract setSelectedKey: key: string -> unit
    [<AllowNullLiteral; Interface>]
    type TabsContext =
        abstract isDisabled: Accessor<bool>
        abstract orientation: Accessor<Orientation>
        abstract activationMode: Accessor<ActivationMode>
        abstract triggerIdsMap: Accessor<Map<string, string>>
        abstract contentIdsMap: Accessor<Map<string, string>>
        abstract listState: Accessor<SingleSelectListState>
        abstract selectedTab: Accessor<HTMLElement option>
        abstract setSelectedTab: Setter<HTMLElement option>
        abstract generateTriggerId: value: string -> string
        abstract generateContentId: value: string -> string
    [<ImportMember(Spec.tabs)>]
    let useTabsContext(): TabsContext = jsNative
