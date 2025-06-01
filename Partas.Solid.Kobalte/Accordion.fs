namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.accordion)>]
type Accordion() =
    inherit div()
    interface Polymorph
    member val value : string[] = jsNative with get,set //v0.13.9
    member val defaultValue : string[] = jsNative with get,set //v0.13.9
    member val onChange : string[] -> unit = jsNative with get,set //v0.13.9
    member val multiple : bool = jsNative with get,set //v0.13.9
    member val collapsible : bool = jsNative with get,set //v0.13.9
    member val shouldFocusWrap : bool = jsNative with get,set //v0.13.9

[<Erase>]
module Accordion =
    /// <summary>
    /// data-expanded: present when accordion item is expanded<br/>
    /// data-closed: present when accordion item is collapsed<br/>
    /// data-disabled: present when accordion item is disabled
    /// </summary>
    [<Erase; Import("Item", Spec.accordion)>]
    type Item() =
        inherit Collapsible()  //v0.13.9
        interface Polymorph //v0.13.9
        member val open' : bool = jsNative with get,set //v0.13.9
        member val defaultOpen : bool = jsNative with get,set //v0.13.9
        member val onOpenChange : bool -> unit = jsNative with get,set //v0.13.9
        member val disabled : bool = jsNative with get,set //v0.13.9
        member val forceMount : bool = jsNative with get,set //v0.13.9
        member val value : string = jsNative with get,set //v0.13.9
    [<Erase; Import("Trigger", Spec.accordion)>]
    type Trigger() =
        inherit Collapsible.Trigger() //v0.13.9
        // inherit button()
        interface Polymorph //v0.13.9
    [<Erase; Import("Content", Spec.accordion)>]
    type Content() =
        inherit Collapsible.Content() //v0.13.9
        // inherit div()
        interface Polymorph  //v0.13.9
    [<Erase; Import("Header", Spec.accordion)>]
    type Header() =
        inherit h3() //v0.13.9
        interface Polymorph //v0.13.9
