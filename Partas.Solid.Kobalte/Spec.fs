﻿namespace Partas.Solid.Kobalte

open Fable.Core

[<RequireQualifiedAccess; Erase>]
module internal Spec =
    let [<Erase; Literal>] version = "v0.13.9"
    let [<Erase; Literal>] kobalte = "@kobalte/core"
    let [<Erase; Literal>] collapsible = kobalte + "/collapsible"
    let [<Erase; Literal>] accordion = kobalte + "/accordion"
    let [<Erase; Literal>] alert = kobalte + "/alert"
    let [<Erase; Literal>] alertDialog = kobalte + "/alert-dialog"
    let [<Erase; Literal>] button = kobalte + "/button"
    let [<Erase; Literal>] badge = kobalte + "/badge"
    let [<Erase; Literal>] breadcrumbs = kobalte + "/breadcrumbs"
    let [<Erase; Literal>] link = kobalte + "/link"
    let [<Erase; Literal>] checkbox = kobalte + "/checkbox"
    let [<Erase; Literal>] colorArea = kobalte + "/color-area"
    let [<Erase; Literal>] colorChannelField = kobalte + "/color-channel-field"
    let [<Erase; Literal>] combobox = kobalte + "/combobox"
    let [<Erase; Literal>] contextMenu = kobalte + "/context-menu"
    let [<Erase; Literal>] dialog = kobalte + "/dialog"
    let [<Erase; Literal>] dropdownMenu = kobalte + "/dropdown-menu"
    let [<Erase; Literal>] fileField = kobalte + "/file-field"
    let [<Erase; Literal>] hoverCard = kobalte + "/hover-card"
    let [<Erase; Literal>] image = kobalte + "/image"
    let [<Erase; Literal>] menubar = kobalte + "/menubar"
    let [<Erase; Literal>] meter = kobalte + "/meter"
    let [<Erase; Literal>] navigationMenu = kobalte + "/navigation-menu"
    let [<Erase; Literal>] numberField = kobalte + "/number-field"
    let [<Erase; Literal>] pagination = kobalte + "/pagination"
    let [<Erase; Literal>] popover = kobalte + "/popover"
    let [<Erase; Literal>] progress = kobalte + "/progress"
    let [<Erase; Literal>] radioGroup = kobalte + "/radio-group"
    let [<Erase; Literal>] select = kobalte + "/select"
    let [<Erase; Literal>] separator = kobalte + "/separator"
    let [<Erase; Literal>] skeleton = kobalte + "/skeleton"
    let [<Erase; Literal>] slider = kobalte + "/slider"
    let [<Erase; Literal>] switch = kobalte + "/switch"
    let [<Erase; Literal>] tabs = kobalte + "/tabs"
    let [<Erase; Literal>] textField = kobalte + "/text-field"
    let [<Erase; Literal>] toast = kobalte + "/toast"
    let [<Erase; Literal>] tooltip = kobalte + "/tooltip"
    let [<Erase; Literal>] toggleButton = kobalte + "/toggle-button"
    let [<Erase; Literal>] toggleGroup = kobalte + "/toggle-group"
    let [<Erase; Literal>] I18nProvider = kobalte + "/i18n-provider"

[<Erase; AutoOpen>]
module Enums =
    [<StringEnum>]
    type Orientation =
        | Horizontal
        | Vertical
    
    [<StringEnum>]
    type ValidationState =
        | Valid
        | Invalid
    
    [<StringEnum>]
    type TriggerMode =
        | Input
        | Focus
        | Manual

    [<StringEnum>]
    type SelectionBehavior  =
        | Toggle
        | Replace
    
    [<StringEnum; RequireQualifiedAccess>]
    type LoadingStatus =
        | Idle
        | Loading
        | Loaded
        | Error
    
    [<StringEnum>]
    type ActivationMode =
        | Automatic
        | Manual

    [<StringEnum>]
    type CollectionType =
        | Item
        | Section
        
    /// <summary>
    /// Values for the <c>defaultFilter</c> prop of the Combobox
    /// </summary>
    [<Erase>]
    type ComboboxFilter =
        static member inline StartsWith : ComboboxFilter = unbox "startsWith"
        static member inline Contains : ComboboxFilter = unbox "contains"
        static member inline EndsWith : ComboboxFilter = unbox "endsWith"
        static member inline Func<'T> (filter : 'T * string -> bool ) : ComboboxFilter = unbox filter

    [<StringEnum(CaseRules.LowerAll)>]
    type KobaltePlacement =
        | Top
        | [<CompiledName("top left")>] TopLeft
        | [<CompiledName("top right")>] TopRight
        | Bottom
        | [<CompiledName("bottom left")>] BottomLeft
        | [<CompiledName("bottom right")>] BottomRight
        | Left
        | Right
    
    [<StringEnum(CaseRules.KebabCase); RequireQualifiedAccess>]
    type KobaltePopperPlacement =
        | Top
        | Bottom
        | Left
        | Right        
        | TopStart
        | BottomStart
        | LeftStart
        | RightStart
        | TopEnd
        | BottomEnd
        | LeftEnd
        | RightEnd        
    
    [<Erase>]
    module Popover =
        type Placement = KobaltePopperPlacement
    