namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.pagination)>]
type Pagination() =
    inherit div()
    interface Polymorph
    member val page : int = jsNative with get,set
    member val defaultPage : int = jsNative with get,set
    member val onPageChange : int -> unit = jsNative with get,set
    member val count : int = jsNative with get,set
    member val siblingCount : int = jsNative with get,set
    member val showFirst : bool = jsNative with get,set
    member val showLast : bool = jsNative with get,set
    member val fixedItems : Pagination.FixedItems = jsNative with get,set
    member val itemComponent : obj = jsNative with get,set
    member val ellipsisComponent : obj = jsNative with get,set
    member val disabled : bool = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Pagination =
    [<Erase; Import("Item", Spec.pagination)>]
    type Item() =
        inherit Button()
        interface Polymorph
        member val page : int = jsNative with get,set
    [<Erase; Import("Ellipsis", Spec.pagination)>]
    type Ellipsis() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Previous", Spec.pagination)>]
    type Previous() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Next", Spec.pagination)>]
    type Next() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Items", Spec.pagination)>]
    type Items() =
        inherit div()
        interface Polymorph
    

