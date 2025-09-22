namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.accordion)>]
type Accordion() =
    inherit div()
    interface Polymorph
    /// <summary>
    /// The controlled value of the accordion item(s) to expand.
    /// </summary>
    [<Erase>]
    member val value: string[] = JS.undefined with get,set //0.13.9
    /// <summary>
    /// The value of the accordion item(s) to expand when initially rendered.
    /// Useful when you do not need to control the state.
    /// </summary>
    [<Erase>]
    member val defaultValue: string[] = JS.undefined with get,set
    /// <summary>
    /// Event handler called when the value changes.
    /// </summary>
    /// <storybook type="string[] -> unit" spy="true"/>
    [<Erase>]
    member val onChange: string[] -> unit = JS.undefined with get,set
    /// <summary>
    /// Whether multiple items can be opened at the same time.
    /// </summary>
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val multiple: bool = JS.undefined with get,set
    /// <summary>
    /// Allows closing content when clicking trigger for an open item when `multiple` is `false`.
    /// </summary>
    /// <defaultValue>false</defaultValue>
    [<Erase>]
    member val collapsible: bool = JS.undefined with get,set
    /// <summary>
    /// Whether focus should wrap around when the end/start is reached.
    /// </summary>
    [<Erase>]
    member val shouldFocusWrap: bool = JS.undefined with get,set

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
        /// <summary>
        /// </summary>
        [<Erase>]
        member val open': bool = JS.undefined with get,set
        /// <defaultValue>false</defaultValue>
        [<Erase>]
        member val defaultOpen: bool = JS.undefined with get,set
        /// <storybook type="bool -> unit" spy="true" />
        [<Erase>]
        member val onOpenChange: bool -> unit = JS.undefined with get,set
        /// <summary>
        /// Whether the item is disabled.
        /// </summary>
        [<Erase>]
        member val disabled: bool = JS.undefined with get,set
        /// <summary>
        /// Used to force mounting the item content when more control is needed. Useful when controlling
        /// animation with SolidJS animation libraries.
        /// </summary>
        [<Erase>]
        member val forceMount: bool = JS.undefined with get,set
        /// <summary>
        /// A unique value for the item.
        /// </summary>
        [<Erase>]
        member val value: string = JS.undefined with get,set
    [<Erase; Import("Trigger", Spec.accordion)>]
    type Trigger() =
        inherit Collapsible.Trigger() //v0.13.9
        interface Polymorph //v0.13.9
    [<Erase; Import("Content", Spec.accordion)>]
    type Content() =
        inherit Collapsible.Content() //v0.13.9
        interface Polymorph  //v0.13.9
    /// <summary>
    /// Wraps an accordion trigger
    /// </summary>
    [<Erase; Import("Header", Spec.accordion)>]
    type Header() =
        inherit h3() //v0.13.9
        interface Polymorph //v0.13.9

[<Erase; AutoOpen>]
module AccordionContext =
    [<AllowNullLiteral; Interface>]
    type AccordionContext =
        abstract listState: Accessor<ListState<obj>> with get,set
        abstract generateId: (string -> string) with get,set
    [<ImportMember(Spec.accordion)>]
    let useAccordionContext(): AccordionContext = jsNative
