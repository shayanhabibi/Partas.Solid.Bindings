module Partas.Solid.Motion.Utils

open Fable.Core

[<AutoOpen; Erase>]
module private Paths =
    let [<Literal>] utils = "@motionone/utils" 

[<Erase>]
module Utils =
    [<AllowNullLiteral; Interface>]
    type time =
        abstract member ms: seconds: float -> float with get
        abstract member s: milliseconds: float -> float with get

[<Erase>]
type Utils =
    [<ImportMember(utils)>]
    static member wrap(min: int, max: int, v: int): int = jsNative 
    [<ImportMember(utils)>]
    static member velocityPerSecond(velocity: int, frameDuration: int): int = jsNative
    [<ImportMember(utils)>]
    static member time: Utils.time = jsNative
    [<ImportMember(utils)>]
    static member progress(min: int, max: int, value: int): int = jsNative
    [<ImportMember(utils)>]
    static member fillOffset(offset: int[], remaining: int): unit = jsNative
    [<ImportMember(utils)>]
    static member defaultOffset(length: int): int[] = jsNative
    [<ImportMember(utils)>]
    static member mix(min: int, max: int, progress: int): int = jsNative
    [<ImportMember(utils)>]
    static member isString(value: 'T): bool = jsNative    
    [<ImportMember(utils)>]
    static member isNumber(value: 'T): bool = jsNative
    [<ImportMember(utils)>]
    static member isFunction(value: 'T): bool = jsNative
    [<ImportMember(utils)>]
    static member isEasingList(value: 'T): bool = jsNative
    [<ImportMember(utils)>]
    static member isEasingGenerator(value: 'T): bool = jsNative
    [<ImportMember(utils)>]
    static member isCubicBezier(value: 'T): bool = jsNative
    
    