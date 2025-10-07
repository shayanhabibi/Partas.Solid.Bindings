namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core

[<Erase; Import("Root", Spec.pagination)>]
type Pagination() =
    inherit div()
    interface Polymorph
    /// <summary>
    /// The controlled page number of the pagination. (1-indexed)
    /// </summary>
    [<Erase>] member val page: int = JS.undefined with get,set
    /// <summary>
    /// The default page number when initially rendered. (1-indexed)
    /// Useful when you do not need to control the page number.
    /// </summary>
    [<Erase>] member val defaultPage: int = JS.undefined with get,set
    /// <summary>
    /// Event handler called when the page number changes.
    /// </summary>
    [<Erase>] member val onPageChange: (int -> unit) = JS.undefined with get,set
    /// <summary>
    /// The number of pages for the pagination.
    /// </summary>
    [<Erase>] member val count: int = JS.undefined with get,set
    /// <summary>
    /// The number of siblings to show around the current page item.
    /// </summary>
    [<Erase>] member val siblingCount: int = JS.undefined with get,set
    /// <summary>
    /// Whether to always show the first page item.
    /// </summary>
    [<Erase>] member val showFirst: bool = JS.undefined with get,set
    /// <summary>
    /// Whether to always show the last page item.
    /// </summary>
    [<Erase>] member val showLast: bool = JS.undefined with get,set
    /// <summary>
    /// Whether to always show the same number of items (to avoid content shift).
    /// Special value: "no-ellipsis" does not count the ellipsis as an item (used when ellipsis are disabled).
    /// </summary>
    [<Erase>] member val fixedItems: PaginationFixedItems = JS.undefined with get,set
    /// <summary>
    /// The component to render as an item in the <c>Pagination.List</c>.
    /// </summary>
    [<Erase>] member val itemComponent: ({| page: int |} -> HtmlElement) = JS.undefined with get,set
    /// <summary>
    /// The component to render as an ellipsis item in the <c>Pagination.List</c>.
    /// </summary>
    [<Erase>] member val ellipsisComponent: (unit -> HtmlElement) = JS.undefined with get,set
    /// <summary>
    /// Whether the pagination is disabled.
    /// </summary>
    [<Erase>] member val disabled: bool = JS.undefined with get,set

[<Erase; RequireQualifiedAccess>]
module Pagination =
    [<Erase; Import("Item", Spec.pagination)>]
    type Item() =
        inherit Button()
        interface Polymorph
        [<Erase>] member val page : int = JS.undefined with get,set
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
    

[<AutoOpen;Erase>]
module PaginationContext =
    [<AllowNullLiteral>]
    [<Interface>]
    type PaginationContext =
        abstract member count: Accessor<int> with get
        abstract member siblingCount: Accessor<int> with get
        abstract member showFirst: Accessor<bool> with get
        abstract member showLast: Accessor<bool> with get
        abstract member fixedItems: Accessor<PaginationFixedItems> with get
        abstract member isDisabled: Accessor<bool> with get
        abstract member renderItem: (int -> JSX.Element) with get
        abstract member renderEllipsis: (unit -> JSX.Element) with get
        abstract member page: Accessor<int> with get
        abstract member setPage: Setter<int> with get

    [<ImportMember(Spec.pagination)>]
    let usePaginationContext () : PaginationContext = nativeOnly
