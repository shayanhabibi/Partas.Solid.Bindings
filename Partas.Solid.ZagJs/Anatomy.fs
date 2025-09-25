namespace Partas.Solid.ZagJs

open System.Collections.Generic
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open System

[<Erase>]
module AnatomyPart =
    [<Pojo>]
    type Attrs(
        ?``data-scope``: string,
        ?``data-part``: string
        ) =
        member val ``data-scope`` = ``data-scope`` with get,set
        member val ``data-part`` = ``data-part`` with get,set
type AnatomyPart =
    abstract selector: string with get,set
    abstract attrs: AnatomyPart.Attrs with get,set

type AnatomyInstance<'T> =
    abstract extendWith<'V>: [<ParamArray>] parts: 'V[] -> AnatomyInstance<U2<'T, 'V>>
    abstract build: unit -> IDictionary<string, AnatomyPart>
    abstract rename: newName: string -> Anatomy<'T>
    abstract keys: unit -> 'T[]
    abstract omit: obj -> obj
and AnatomyPartName<'T> = inherit AnatomyInstance<'T>
and Anatomy<'T> =
    inherit AnatomyInstance<'T>
    abstract parts<'V>: [<ParamArray>] parts: 'V[] -> AnatomyInstance<U2<'T, 'V>>
