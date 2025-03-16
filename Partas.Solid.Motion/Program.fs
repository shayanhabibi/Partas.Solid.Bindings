namespace Partas.Solid.Motion

open Partas.Solid
open Fable.Core

[<Erase>]
type OptionKeys = interface end
[<Erase>]
type AttrKey = interface end

[<Erase>]
module Extensions =
    type AttrKey with
        member _.tag
            with set(value: TagValue) = ()
    type OptionKeys with
        member _.initial
            with set(value: string) = ()
        member _.animate
            with set(value: string) = ()
        member _.inView
            with set(value: string) = ()
        member _.inViewOptions
            with set(value: string) = ()
        member _.hover
            with set(value: string) = ()
        member _.press
            with set(value: string) = ()
        member _.variants
            with set(value: string) = ()
        member _.transition
            with set(value: string) = ()
        member _.exit
            with set(value: string) = ()