namespace Partas.Solid.ZagJs

open Fable.Core
open Fable.Core.JsInterop
open System
// These utils are mostly unnecessary with F#

[<JS.Pojo>]
type IndexOptions(
    ?step: int,
    ?loop: bool
    ) =
    [<DefaultValue>] val mutable step: int option
    [<DefaultValue>] val mutable loop: bool option

[<AllowNullLiteral>]
type RangeContext =
    abstract min: float
    abstract max: float
    abstract step: float
    abstract values: float[]

type MaybeFunction<'T> = U2<'T, unit -> 'T>
type StoreListener = unit -> unit
type StoreCompareFn<'T> = delegate of a: 'T * b: 'T -> bool
type Store<'T> =
    abstract subscribe: StoreListener -> (unit -> unit)
    abstract get<'V>: string -> 'V
    abstract set<'V>: string * 'V -> unit
    abstract update: 'T -> unit
    abstract snapshot: unit -> 'T
[<JS.Pojo>]
type RafIntervalOptions(
    ?startMs: float,
    ?deltaMs: float
    ) =
    [<DefaultValue>]
    val mutable startMs: float
    [<DefaultValue>]
    val mutable deltaMs: float
[<Import("utils", Spec.path)>]
type Utils =
    static member toArray<'T>(v: 'T): 'T[] = jsNative
    static member fromLength(length: int): int[] = jsNative
    static member fromLength(length: float): float[] = jsNative
    static member first<'T>(v: 'T[]): 'T option = jsNative
    static member last<'T>(v: 'T[]): 'T option = jsNative
    static member isEmpty<'T>(v: 'T[]): bool = jsNative
    static member has<'T>(v: 'T[], t: 'T): bool = jsNative
    static member add<'T>(v: 'T[], [<ParamArray>] items: 'T[]): 'T[] = jsNative
    static member remove<'T>(v: 'T[], [<ParamArray>] items: 'T[]): 'T = jsNative
    static member removeAt<'T>(v: 'T[], i: int): 'T[] = jsNative
    static member insertAt<'T>(v: 'T[], i: int, [<ParamArray>] items: 'T[]): 'T[] = jsNative
    static member uniq<'T>(v: 'T[]): 'T[] = jsNative
    static member diff<'T>(a: 'T[], b: 'T[]): 'T[] = jsNative
    static member addOrRemove<'T>(v: 'T[], item: 'T): 'T[] = jsNative
    static member clear<'T>(v: 'T[]): 'T[] = jsNative
    [<ParamObject(2)>]
    static member nextIndex<'T>(v: 'T[], idx: int, ?step: int, ?loop: bool): int = jsNative
    [<ParamObject(2)>]
    static member next<'T>(v: 'T[], idx: int, ?step: int, ?loop: bool): 'T option = jsNative
    [<ParamObject(2)>]
    static member prevIndex<'T>(v: 'T[], idx: int, ?step: int, ?loop: bool): int = jsNative
    [<ParamObject(2)>]
    static member prev<'T>(v: 'T[], idx: int, ?step: int, ?loop: bool): 'T option = jsNative
    static member chunk<'T>(v: 'T[], size: int): 'T[,] = jsNative
    static member flatArray<'T>(arr: 'T[]): 'T[] = jsNative
    static member partition<'T>(arr: 'T[], fn: 'T -> bool): 'T[] * 'T[] = jsNative
    static member isEqual(a: obj, b: obj): bool = jsNative
    static member runIfFn<'T>(v: MaybeFunction<'T>): 'T = jsNative
    static member identity(v: unit -> unit): unit = jsNative
    static member noop(): unit = jsNative
    // static member callAll
    static member uuid(): string = jsNative
    // static member match
    // static member tryCatch
    static member throttle(fn: FSharpFunc<'T, unit>, ?wait: int): FSharpFunc<'T, unit> = jsNative
    static member debounce(fn: FSharpFunc<'T, unit>, ?wait: int): FSharpFunc<'T, unit> = jsNative
    static member isDev(): bool = jsNative
    static member isArray(v: obj): bool = jsNative
    static member isBoolean(v: obj): bool = jsNative
    static member isObjectLike(v: obj): bool = jsNative
    static member isObject(v: obj): bool = jsNative
    static member isNumber(v: obj): bool = jsNative
    static member isString(v: obj): bool = jsNative
    static member isFunction(v: obj): bool = jsNative
    static member isNull(v: obj): bool = jsNative
    static member hasProp(obj: obj, prop: string): bool = jsNative
    static member isPlainObject(v: obj): bool = jsNative
    static member isNaN(v: float): bool = jsNative
    static member isNaN(v: int): bool = jsNative
    static member nan(v: float): float = jsNative
    static member nan(v: int): int = jsNative
    // static member mod
    static member wrap(v: float, vmax: float): float = jsNative
    static member wrap(v: int, vmax: int): int = jsNative
    static member getMinValueAtIndex(i: int, v: float[], vmin: float): float = jsNative
    static member getMinValueAtIndex(i: int, v: int[], vmin: int): int = jsNative
    static member getMaxValueAtIndex(i: int, v: float[], vmax: float): float = jsNative
    static member getMaxValueAtIndex(i: int, v: int[], vmax: int): int = jsNative
    static member isValueAtMax(v: float, vmax: float): bool = jsNative
    static member isValueAtMin(v: float, vmin: float): bool = jsNative
    static member isValueAtMax(v: int, vmax: float): bool = jsNative
    static member isValueAtMin(v: int, vmin: float): bool = jsNative
    static member isValueWithinRange(v: float, vmin: float option, vmax: float option): bool = jsNative
    static member isValueWithinRange(v: int, vmin: int option, vmax: int option): bool = jsNative
    static member roundValue(v: float, vmin: float, step: float): float = jsNative
    static member roundValue(v: int, vmin: int, step: int): int = jsNative
    static member clampValue(v: float, vmin: float, vmax: float): float = jsNative
    static member clampValue(v: int, vmin: int, vmax: int): int = jsNative
    static member clampPercent(v: float): float = jsNative
    static member clampPercent(v: int): int = jsNative
    static member getValuePercent(v: float, vmin: float, vmax: float): float = jsNative
    static member getValuePercent(v: int, vmin: int, vmax: int): int = jsNative
    static member getPercentValue(p: float, vmin: float, vmax: float, step: float): float = jsNative
    static member getPercentValue(p: int, vmin: int, vmax: int, step: int): int = jsNative
    static member roundToStepPrecision(v: float, step: float): float = jsNative
    static member roundToStepPrecision(v: int, step: int): int = jsNative
    static member roundToDpr(v: float, dpr: obj): float = jsNative
    static member roundToDpr(v: int, dpr: obj): int = jsNative
    static member snapValueToStep(v: float, vmin: float option, vmax: float option, step: float): float = jsNative
    static member snapValueToStep(v: int, vmin: int option, vmax: int option, step: int): int = jsNative
    static member setValueAtIndex<'T>(vs: 'T[], i: int, v: 'T): 'T[] = jsNative
    static member getValueSetterAtIndex(index: int, ctx: #RangeContext): float -> float = jsNative
    static member getNextStepValue(index: int, ctx: #RangeContext): float[] = jsNative
    static member getPreviousStepValue(index: int, ctx: #RangeContext): float[] = jsNative
    static member getClosestValueIndex(vs: float[], t: float): int = jsNative
    static member getClosestValueIndex(vs: int[], t: int): int = jsNative
    static member getClosestValue(vs: float[], t: float): float = jsNative
    static member getClosestValue(vs: int[], t: int): int = jsNative
    static member getValueRanges(vs: float[], vmin: float, vmax: float, gap: float): {| min: float; max: float; value: float |}[] = jsNative
    static member getValueTransformer(va: float[], vb: float[]): float -> float = jsNative
    static member getValueTransformer(va: int[], vb: int[]): int -> int = jsNative
    static member toFixedNumber(v: float, ?d: float, ?b: float): float = jsNative
    static member incrementValue(v: float, s: float): float = jsNative
    static member decrementValue(v: float, s: float): float = jsNative
    static member toPx(v: float): string option = jsNative
    static member compact(obj: 'T): 'T = jsNative
    static member json(v: 'T): obj = jsNative
    // static member pick
    // static member splitProps
    // static member createSplitProps
    // static member omit
    static member createStore<'T>(initialState: 'T, ?compare: StoreCompareFn<'T>): Store<'T> = jsNative
    static member setRafInterval(callback: RafIntervalOptions -> unit, interval: float): (unit -> unit) = jsNative
    static member setRafTimeout(callback: unit -> unit, delay: float): (unit -> unit) = jsNative
    static member warn(m: string): unit = jsNative
    static member warn(c: bool, m: string): unit = jsNative
    static member invariant(m: string): unit = jsNative
    static member invariant(c: bool, m: string): unit = jsNative
    static member ensure<'T>(c: 'T option, m: unit -> string): obj = jsNative
    // static member ensureProps
