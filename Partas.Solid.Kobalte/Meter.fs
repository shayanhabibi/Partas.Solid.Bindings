namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; Import("Root", Spec.meter)>]
type Meter() =
    inherit div()
    interface Polymorph
    [<Erase>] member val value : int = JS.undefined with get,set
    [<Erase>] member val minValue : int = JS.undefined with get,set
    [<Erase>] member val maxValue : int = JS.undefined with get,set
    [<Erase>] member val getValueLabel : {| value: int ; min : int ; max : int |} -> string = JS.undefined with get,set

[<Erase; RequireQualifiedAccess>]
module Meter =
    [<Erase; Import("Label", Spec.meter)>]
    type Label() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.meter)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Track", Spec.meter)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.meter)>]
    type Fill() =
        inherit div()
        interface Polymorph


[<Erase; AutoOpen>]
module MeterContext =
    [<Interface; AllowNullLiteral>]
    type MeterDataSet = interface end
    
    [<AllowNullLiteral; Interface>]
    type MeterContext =
        abstract dataset: Accessor<MeterDataSet>
        abstract value: Accessor<float>
        abstract valuePercent: Accessor<float>
        abstract valueLabel: Accessor<string option>
        abstract meterFillWidth: Accessor<string option>
        abstract labelId: Accessor<string option>
        abstract generateId: (string -> string)
        abstract registerLabelId: (string -> (unit -> unit))
    [<ImportMember(Spec.meter)>]
    let useMeterContext(): MeterContext = jsNative
