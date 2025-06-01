namespace Partas.Solid.Sonner

open Partas.Solid
open Fable.Core

[<Erase>]
module Spec =
    let [<Literal; Erase>] path = "solid-sonner"
    let [<Literal; Erase>] version = "0.2.8"

[<Erase; AutoOpen>]
module Enums =
    [<StringEnum; RequireQualifiedAccess>]
    type SonnerType =
        | Normal
        | Action
        | Success
        | Info
        | Warning
        | Error
        | Loading
        | Default
    
    [<StringEnum(CaseRules.KebabCase); RequireQualifiedAccess>]
    type SonnerPosition =
        | TopLeft
        | TopRight
        | BottomLeft
        | BottomRight
        | TopCenter
        | BottomCenter
    
    [<Erase>]
    module Toast =
        type Type = SonnerType
        type Position = SonnerPosition

[<System.Obsolete("Use the qualified access enums through `Partas.Solid.Sonner.Enums`"); Erase>]
module sonner =
    type Type = SonnerType
    type Position = SonnerPosition
