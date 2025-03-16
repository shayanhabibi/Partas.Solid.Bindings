namespace rec Partas.Solid.TanStack.Table

open Partas.Solid
open Fable.Core
open System


[<AllowNullLiteral; Interface>]
type HeaderRenderProp<'Data> =
    abstract member header: Header<'Data> with get

[<AllowNullLiteral; Interface>]
type TableRenderProp<'Data> =
    abstract member table: Table<'Data> with get
    
[<AllowNullLiteral; Interface>]
type ColumnRenderProp<'Data> =
    abstract member column: Column<'Data> with get

[<AllowNullLiteral; Interface>]
type RowRenderProp<'Data> =
    abstract member row: Row<'Data> with get


[<AllowNullLiteral; Interface>]
type CellRenderProp<'Data> =
    abstract member cell: Cell<'Data> with get


[<AllowNullLiteral; Interface>]
type HeaderRenderProps<'Data> =
    inherit HeaderRenderProp<'Data>
    inherit TableRenderProp<'Data>
    inherit ColumnRenderProp<'Data>

[<AllowNullLiteral; Interface>]
type FooterRenderProps<'Data> =
    inherit HeaderRenderProp<'Data>
    inherit TableRenderProp<'Data>
    inherit ColumnRenderProp<'Data>

[<AllowNullLiteral; Interface>]
type CellRenderProps<'Data> =
    inherit TableRenderProp<'Data>
    inherit RowRenderProp<'Data>
    inherit ColumnRenderProp<'Data>
    inherit CellRenderProp<'Data>
    abstract member getValue: unit -> obj with get
    abstract member renderValue: unit -> obj with get
    
[<AllowNullLiteral; Interface>]
type ColumnDef<'Data> =
    abstract member id: string with get,set
    abstract member accessorKey: string with get,set
    abstract member accessorFn: ('Data * int -> obj) with get,set
    abstract member columns: 'Data[] with get,set
    abstract member header: HeaderRenderProps<'Data> -> obj with get,set
    abstract member footer: FooterRenderProps<'Data> -> obj with get,set
    abstract member cell: CellRenderProps<'Data> -> obj with get,set
    abstract member meta: obj with get,set

[<AllowNullLiteral;Interface>]
type TableState =
    inherit VisibilityTableState
    inherit ColumnOrderTableState
    inherit ColumnPinningTableState
    inherit FiltersTableState
    inherit SortingTableState
    inherit ExpandedTableState
    inherit GroupingTableState
    inherit ColumnSizingTableState
    inherit PaginationTableState
    inherit RowSelectionTableState
    
type Updater<'T> = U2<('T -> 'T), 'T> // TODO? what is this // its either a oldState -> newState or just a state object

[<AllowNullLiteral;Interface>]
type TableFeature = interface end
    
[<AllowNullLiteral;Interface>]
type Table<'Data> =
    abstract member data: 'Data[] with get,set
    abstract member columns: ColumnDef<'Data>[] with get,set
    abstract member defaultColumn: ColumnDef<'Data> with get,set
    abstract member initialState: TableState with get,set
    abstract member autoResetAll: bool with get,set
    abstract member meta: obj with get,set
    abstract member state: TableState with get,set
    // TODO - Updater<TableState>
    abstract member onStateChange: Updater<'Data> -> unit with get,set
    abstract member debugAll: bool with get,set
    abstract member debugTable: bool with get,set
    abstract member debugHeaders: bool with get,set
    abstract member debugColumns: bool with get,set
    abstract member debugRows: bool with get,set
    abstract member _features: TableFeature[] with get,set
    // abstract member render
    abstract member getCoreRowModel: ((Table<'Data> -> unit) -> RowModel<'Data>) with get,set 
    abstract member getSubRows: 'Data * int -> 'Data[] with get,set
    abstract member getRowId: 'Data * int * Row<'Data> -> string with get,set

[<AllowNullLiteral; Interface>]
type RowModel<'Data> =
    abstract member rows: Row<'Data>[] with get,set
    abstract member flatRows: Row<'Data>[] with get,set
    abstract member rowsById: System.Collections.Generic.IDictionary<string, Row<'Data>> with get,set
    
[<AllowNullLiteral; Interface>]
type TableObj<'Data> =
    abstract member initialState: TableState with get
    abstract member reset: unit -> unit with get
    abstract member getState: unit -> TableState with get
    abstract member setState: Updater<TableState> -> unit with get
    abstract member options: Table<'Data> with get
    abstract member setOptions: Updater<Table<'Data>> -> unit with get
    abstract member getCoreRowModel: unit -> RowModel<'Data> with get
    abstract member getRowModel: unit -> RowModel<'Data> with get
    abstract member getAllColumns: unit -> Column<'Data>[] with get
    abstract member getAllFlatColumns: unit -> Column<'Data>[] with get
    abstract member getAllLeafColumns: unit -> Column<'Data>[] with get
    abstract member getColumn: string -> Column<'Data> option with get
    abstract member getHeaderGroups: unit -> HeaderGroup<'Data>[] with get
    abstract member getFooterGroups: unit -> FooterGroup<'Data>[] with get
    abstract member getFlatHeaders: unit -> Header<'Data>[] with get
    abstract member getLeafHeaders: unit -> Header<'Data>[] with get
    
    abstract member getLeftHeaderGroups: unit -> HeaderGroup<'Data>[] with get
    abstract member getCenterHeaderGroups: unit -> HeaderGroup<'Data>[] with get
    abstract member getRightHeaderGroups: unit -> HeaderGroup<'Data>[] with get
    
    abstract member getLeftFooterGroups: unit -> FooterGroup<'Data>[] with get
    abstract member getCenterFooterGroups: unit -> FooterGroup<'Data>[] with get
    abstract member getRightFooterGroups: unit -> FooterGroup<'Data>[] with get
    
    abstract member getLeftFlatHeaders: unit -> Header<'Data, obj>[] with get
    abstract member getCenterFlatHeaders: unit -> Header<'Data, obj>[] with get
    abstract member getRightFlatHeaders: unit -> Header<'Data, obj>[] with get
    
    abstract member  getLeftLeafHeaders: unit -> Header<'Data, obj>[] with get
    abstract member getCenterLeafHeaders: unit -> Header<'Data, obj>[] with get
    abstract member getRightLeafHeaders: unit -> Header<'Data, obj>[] with get
 
[<AllowNullLiteral;Interface>]
type Column<'Data> =
    abstract member id: string with get
    abstract member depth: int with get
    abstract member accessorFn: 'Data -> obj with get
    abstract member columnDef: ColumnDef<'Data> with get
    abstract member columns: ColumnDef<'Data>[] with get
    abstract member parent: Column<'Data> with get
    abstract member getFlatColumns: unit -> Column<'Data>[] with get
    abstract member getLeafColumns: unit -> Column<'Data>[] with get
    
[<AllowNullLiteral;Interface>]
type HeaderGroup<'Data> =
    abstract member id: string with get,set
    abstract member depth: int with get,set
    abstract member headers: Header<'Data>[] with get,set
 
[<AllowNullLiteral;Interface>]
type Header<'Data, 'Value> =
    inherit Header<'Data>

[<AllowNullLiteral;Interface>]
type Column<'Data, 'Value> =
    inherit Column<'Data>

[<AllowNullLiteral;Interface>]
type HeaderContext<'Data, 'Value> =
    abstract member table: Table<'Data> with get,set
    abstract member header: Header<'Data, 'Value> with get,set
    abstract member column: Column<'Data, 'Value> with get,set

[<AllowNullLiteral;Interface>]
type Header<'Data> =
    abstract member id: string with get,set
    abstract member index: int with get,set
    abstract member depth: int with get,set
    abstract member column: Column<'Data> with get,set
    abstract member headerGroup: HeaderGroup<'Data> with get,set
    abstract member subHeaders: Header<'Data>[] with get,set
    abstract member colSpan: int with get,set
    abstract member rowSpan: int with get,set
    abstract member getLeafHeaders: (unit -> Header<'Data>[]) with get,set
    abstract member isPlaceholder: bool with get,set
    abstract member placeholderId: string with get,set
    abstract member getContext: HeaderContext<'Data, obj> with get,set

[<AllowNullLiteral;Interface>]
type Row<'Data> =
    abstract member id: string with get,set
    abstract member depth: int with get,set
    abstract member index: int with get,set
    abstract member original: 'Data with get,set
    abstract member parentId: string with get,set
    abstract member getValue: string -> obj with get,set
    abstract member renderValue: string -> obj with get,set
    abstract member getUniqueValues: string -> obj[] with get,set
    abstract member subRows: Row<'Data>[] with get,set
    abstract member getParentRow: (unit -> Row<'Data> option) with get,set
    abstract member getParentRows: (unit -> Row<'Data>[] option) with get,set
    abstract member getLeafRows: (unit -> Row<'Data>[]) with get,set
    abstract member originalSubRows: Row<'Data>[] with get,set
    abstract member getAllCells: (unit -> Cell<'Data>[]) with get,set

[<AllowNullLiteral;Interface>]
type CellContext<'Data, 'Value> =
    inherit TableRenderProp<'Data>
    inherit RowRenderProp<'Data>
    abstract member column: Column<'Data, 'Value> with get,set
    abstract member cell: Cell<'Data, 'Value> with get,set
    abstract member getValue: (unit -> 'Value) with get,set
    abstract member renderValue: (unit -> 'Value option) with get,set
    
[<AllowNullLiteral;Interface>]
type Cell<'Data, 'Value> =
    inherit Cell<'Data>


[<AllowNullLiteral;Interface>]
type Cell<'Data> =
    abstract member id: string with get,set
    abstract member getValue: (unit -> obj) with get,set
    abstract member renderValue: (unit -> obj) with get,set
    abstract member row: Row<'Data> with get,set
    abstract member column: Column<'Data> with get,set
    abstract member getContext: CellContext<'Data, obj> with get,set

[<AllowNullLiteral;Interface>]
type VisibilityTableState = interface end
[<AllowNullLiteral;Interface>]
type FooterGroup<'Data> = interface end
[<AllowNullLiteral;Interface>]
type ColumnOrderTableState = interface end
[<AllowNullLiteral;Interface>]
type ColumnPinningTableState = interface end
[<AllowNullLiteral;Interface>]
type FiltersTableState = interface end
[<AllowNullLiteral;Interface>]
type SortingTableState = interface end
[<AllowNullLiteral;Interface>]
type ExpandedTableState = interface end
[<AllowNullLiteral;Interface>]
type GroupingTableState = interface end
[<AllowNullLiteral;Interface>]
type ColumnSizingTableState = interface end
[<AllowNullLiteral;Interface>]
type PaginationTableState = interface end
[<AllowNullLiteral;Interface>]
type RowSelectionTableState = interface end

[<AllowNullLiteral; Interface>]
type FilterFnProps<'Data> =
    abstract member row: Row<'Data> with get
    abstract member columnId: string with get
    abstract member filterValue: obj with get
    abstract member addMeta: (obj -> unit) with get

[<AutoOpen>]
module TanStack =
    [<Import("createSolidTable", "@tanstack/solid-table")>]
    let createTable<'Data>(options: Table<'Data>): Table<'Data> = jsNative