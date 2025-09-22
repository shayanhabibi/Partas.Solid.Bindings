namespace Partas.Solid.Kobalte

open Fable.Core
open Browser.Types
open Partas.Solid

[<Erase; Import("Root", Spec.breadcrumbs)>]
type Breadcrumbs() =
    inherit nav()
    interface Polymorph // the custom is that if a property takes an element or string, then the apostrophised version takes the element
    /// <summary>
    /// The visual separator between each breadcrumb item. It will be used as the default children of
    /// `Kobalte.Breadcrumbs.Separator`.
    /// </summary>
    /// <remarks>
    /// You can also override each `Breadcrumbs.Separator` content by providing your own `children`.
    /// </remarks>
    [<Erase>] member val separator' : HtmlElement = JS.undefined with get,set
    /// <summary>
    /// The visual separator between each breadcrumb item. It will be used as the default children of
    /// `Kobalte.Breadcrumbs.Separator`.
    /// </summary>
    /// <remarks>
    /// You can also override each `Breadcrumbs.Separator` content by providing your own `children`.
    /// </remarks>
    [<Erase>] member val separator : string = JS.undefined with get,set
    // [<DefaultValue>] val mutable translations : string  // todo- support  //v0.13.9

[<Erase; RequireQualifiedAccess>]
module Breadcrumbs =
    /// <summary>
    /// data-current: whether the breadcrumb link represents the current page
    /// </summary>
    [<Erase; Import("Link", Spec.breadcrumbs)>]
    type Link() =
        inherit Kobalte.Link()
        interface Polymorph
        /// <summary>
        /// Whether the breadcrumb link represents the current page.
        /// </summary>
        [<Erase>] member val current : bool = JS.undefined with get,set
        /// <summary>
        /// Whether the breadcrumb link is disabled.
        /// </summary>
        [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase; Import("Separator", Spec.breadcrumbs)>]
    type Separator() = //v0.13.9
        inherit span()
        interface Polymorph

[<Erase; AutoOpen>]
module BreadcrumbContext =
    [<AllowNullLiteral>]
    [<Interface>]
    type BreadcrumbsContext =
        abstract member separator: (unit -> U2<string, Element>) with get, set
        
    [<Import("useBreadcrumbsContext", Spec.breadcrumbs)>]
    let useBreadcrumbsContext () : BreadcrumbsContext = nativeOnly


