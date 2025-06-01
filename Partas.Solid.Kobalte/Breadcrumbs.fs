namespace Partas.Solid.Kobalte

open Fable.Core
open Browser.Types
open Partas.Solid

[<Erase; Import("Root", Spec.breadcrumbs)>]
type Breadcrumbs() =
    inherit nav()
    interface Polymorph // the custom is that if a property takes an element or string, then the apostrophised version takes the element
    member val separator' : HtmlElement = jsNative with get,set //v0.13.9
    member val separator : string = jsNative with get,set  //v0.13.9
    // member val translations : string = jsNative with get,set // todo- support  //v0.13.9

[<Erase; RequireQualifiedAccess>]
module Breadcrumbs =
    /// <summary>
    /// data-current: whether the breadcrumb link represents the current page
    /// </summary>
    [<Erase; Import("Link", Spec.breadcrumbs)>]
    type Link() =
        inherit Kobalte.Link()
        interface Polymorph
        member val currrent : bool = jsNative with get,set //v0.13.9
        member val disabled : bool = jsNative with get,set //v0.13.9
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


