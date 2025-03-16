namespace Partas.Solid.ArkUI

open System.Runtime.CompilerServices
open Partas.Solid
open Fable.Core
open System
open Partas.Solid.Polymorphism

/// <summary>
/// Ark UI
/// </summary>
/// <value>v5.0.1</value>
[<Erase; AutoOpen>]
module private Helpers =
    let [<Literal>] path = "@ark-ui/solid"
    
    // Selectors
    let [<Literal>] datePicker = path + "/date-picker"

[<AutoOpen; Erase>]
module Enums =
    [<StringEnum>]
    type DateView =
        | Day
        | Week
        | Month
        | Year
    [<StringEnum>]
    type SelectionMode =
        | Single

type PositionOptions = interface end // todo
type PresetTriggerValue = interface end // todo
type UseDatePickerReturn = interface end // todo
type VisibleRange = interface end // todo
[<Erase; RequireQualifiedAccess>]
module DatePicker =
    /// data-scope<br/>
    /// data-part<br/>
    /// data-state<br/>
    /// data-disabled<br/>
    /// data-readonly<br/>
    [<Import("Root", datePicker)>]
    type Root() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlTag = unbox null with get,set
        [<Erase>] member val closeOnSelect: bool = unbox null with get,set
        [<Erase>] member val defaultFocusedValue: DateOnly = unbox null with get,set
        [<Erase>] member val defaultOpen: bool = unbox null with get,set
        [<Erase>] member val defaultValue: DateOnly[] = unbox null with get,set
        [<Erase>] member val defaultView: DateView = unbox null with get,set
        [<Erase>] member val disabled: bool = unbox null with get,set
        [<Erase>] member val fixedWeeks: bool = unbox null with get,set
        [<Erase>] member val focusedValue: DateOnly = unbox null with get,set
        [<Erase>] member val format: DateOnly * obj -> string = unbox null with get,set
        [<Erase>] member val ids: obj = unbox null with get,set // todo
        [<Erase>] member val immediate: bool = unbox null with get,set
        [<Erase>] member val isDateUnavailable: DateOnly * string -> bool = unbox null with get,set
        [<Erase>] member val lazyMount: bool = unbox null with get,set
        [<Erase>] member val locale: string = unbox null with get,set
        [<Erase>] member val max: DateOnly = unbox null with get,set
        [<Erase>] member val maxView: DateView = unbox null with get,set
        [<Erase>] member val min: DateOnly = unbox null with get,set
        [<Erase>] member val minView: DateView = unbox null with get,set
        [<Erase>] member val name: string = unbox null with get,set
        [<Erase>] member val numOfMonths: int = unbox null with get,set
        [<Erase>] member val onExitComplete: unit -> unit = unbox null with get,set
        [<Erase>] member val onFocusChange: Browser.Types.FocusEvent -> unit = unbox null with get,set
        [<Erase>] member val onOpenChange: Browser.Types.Event -> unit = unbox null with get,set
        [<Erase>] member val onValueChange: Browser.Types.Event -> unit = unbox null with get,set
        [<Erase>] member val onViewChange: Browser.Types.Event -> unit = unbox null with get,set
        [<Erase>] member val open': bool = unbox null with get,set
        [<Erase>] member val parse: string * obj -> DateOnly option = unbox null with get,set
        [<Erase>] member val placeholder: string = unbox null with get,set
        [<Erase>] member val positioning: PositionOptions = unbox null with get,set
        [<Erase>] member val present: bool = unbox null with get,set
        [<Erase>] member val readOnly: bool = unbox null with get,set
        [<Erase>] member val selectionMode: SelectionMode = unbox null with get,set
        [<Erase>] member val startOfWeek: int = unbox null with get,set
        [<Erase>] member val timeZone: string = unbox null with get,set
        [<Erase>] member val translations: obj = unbox null with get,set
        [<Erase>] member val unmountOnExit: bool = unbox null with get,set
        [<Erase>] member val value: DateOnly[] = unbox null with get,set
        [<Erase>] member val view: DateView = unbox null with get,set
    [<Import("ClearTrigger", datePicker)>]
    type ClearTrigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: button -> HtmlElement = unbox null with get,set
    [<Import("Content", datePicker)>]
    type Content() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("Control", datePicker)>]
    type Control() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("Input", datePicker)>]
    type Input() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: input -> HtmlElement = unbox null with get,set        
        [<Erase>] member val fixOnBlur: bool = unbox null with get,set        
        [<Erase>] member val index: int = unbox null with get,set        
    [<Import("Label", datePicker)>]
    type Label() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: label -> HtmlElement = unbox null with get,set        
    [<Import("MonthSelect", datePicker)>]
    type MonthSelect() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: select -> HtmlElement = unbox null with get,set        
    [<Import("NextTrigger", datePicker)>]
    type NextTrigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: button -> HtmlElement = unbox null with get,set        
    [<Import("Positioner", datePicker)>]
    type Positioner() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("PresetTrigger", datePicker)>]
    type PresetTrigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: button -> HtmlElement = unbox null with get,set
        [<Erase>] member val value: PresetTriggerValue = unbox null with get,set
    [<Import("PrevTrigger", datePicker)>]
    type PrevTrigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: button -> HtmlElement = unbox null with get,set        
    [<Import("RangeText", datePicker)>]
    type RangeText() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("RootProvider", datePicker)>]
    type RootProvider() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set
        [<Erase>] member val value: UseDatePickerReturn = unbox null with get,set
        [<Erase>] member val immediate: bool = unbox null with get,set
        [<Erase>] member val lazyMount: bool = unbox null with get,set
        [<Erase>] member val onExitComplete: unit -> unit = unbox null with get,set
        [<Erase>] member val present: bool = unbox null with get,set
        [<Erase>] member val unmountOnExit: bool = unbox null with get,set
    [<Import("TableBody", datePicker)>]
    type TableBody() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: tbody -> HtmlElement = unbox null with get,set        
    [<Import("TableCell", datePicker)>]
    type TableCell() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: td -> HtmlElement = unbox null with get,set        
        [<Erase>] member val value: DateOnly = unbox null with get,set        
        [<Erase>] member val columns: int = unbox null with get,set        
        [<Erase>] member val disabled: bool = unbox null with get,set        
        [<Erase>] member val visibleRange: VisibleRange = unbox null with get,set        
    [<Import("TableCellTrigger", datePicker)>]
    type TableCellTrigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("TableHead", datePicker)>]
    type TableHead() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: thead -> HtmlElement = unbox null with get,set        
    [<Import("TableHeader", datePicker)>]
    type TableHeader() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: th -> HtmlElement = unbox null with get,set        
    [<Import("Table", datePicker)>]
    type Table() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: table -> HtmlElement = unbox null with get,set
        [<Erase>] member val columns: int = unbox null with get,set
    [<Import("TableRow", datePicker)>]
    type TableRow() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: tr -> HtmlElement = unbox null with get,set        
    [<Import("Trigger", datePicker)>]
    type Trigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: button -> HtmlElement = unbox null with get,set        
    [<Import("ViewControl", datePicker)>]
    type ViewControl() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("View", datePicker)>]
    type View() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val view: DateView = unbox null with get,set
        [<Erase>] member val asChild: div -> HtmlElement = unbox null with get,set        
    [<Import("ViewTrigger", datePicker)>]
    type ViewTrigger() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: button -> HtmlElement = unbox null with get,set        
    [<Import("YearSelect", datePicker)>]
    type YearSelect() =
        inherit RegularNode()
        interface Polymorph
        [<Erase>] member val asChild: select -> HtmlElement = unbox null with get,set           
    [<Import("Context", datePicker)>]
    type Context() =
        inherit RegularNode()
        
[<AutoOpen>]
module Polymorphism =
    type PolymorphicExtensions with
        /// For ArkUI or other supporting libraries
        [<Erase; Extension>]
        static member asChild<'Base when 'Base :> Polymorph> (
                this: 'Base,
                morph: #HtmlTag
            ): 'Base = this
        /// For ArkUI or other supporting libraries
        [<Erase; Extension>]
        static member asChild<'Base when 'Base :> Polymorph > (
                this: 'Base,
                morph: TagValue
            ): 'Base = this