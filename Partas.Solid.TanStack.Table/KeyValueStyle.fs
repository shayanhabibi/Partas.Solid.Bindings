module Partas.Solid.TanStack.Table.KeyValueStyle

open Fable.Core
open Fable.Core.JsInterop


type ColumnSizingInfoStateKey =
    | StartOffset of int
    | StartSize of int
    | DeltaOffset of int
    | IsResizingColumn of string
    | ColumnSizingStart of (string * int)[]

[<Erase>]
type ColumnSizingInfoStateBuilder() =
    member inline _.Return(x) = fun () -> x
    member inline _.Bind(m,f) = fun () -> f (m()) ()
    member inline _.Delay(f) = f
    member inline _.Combine([<InlineIfLambda>] PARTAS_FIRST: 'T -> unit,[<InlineIfLambda>] PARTAS_SECOND) = ignore PARTAS_FIRST; PARTAS_SECOND()
    member inline _.Yield(PARTAS_VALUE: ColumnSizingInfoStateKey) = PARTAS_VALUE
    member inline _.Run(code: unit -> 'T): ColumnSizingInfoState =
        unbox keyValueList CaseRules.LowerFirst [ code() ]

let columnSizingInfoState = ColumnSizingInfoStateBuilder()