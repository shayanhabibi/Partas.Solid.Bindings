namespace Partas.Solid.ArkUI

open System.Runtime.CompilerServices
open Partas.Solid
open Fable.Core
open System
open Partas.Solid.Polymorphism
open Glutinum.Internationalised
open Glutinum.ZagJs

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

[<Erase; RequireQualifiedAccess>]
module DatePicker =
    /// data-scope<br/>
    /// data-part<br/>
    /// data-state<br/>
    /// data-disabled<br/>
    /// data-readonly<br/>
    [<Import("DatePicker.Root", datePicker)>]
    type Root() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlTag
        [<DefaultValue>] val mutable closeOnSelect: bool
        [<DefaultValue>] val mutable defaultFocusedValue: DateValue
        [<DefaultValue>] val mutable defaultOpen: bool
        [<DefaultValue>] val mutable defaultValue: DateValue[]
        [<DefaultValue>] val mutable defaultView: DateView
        [<DefaultValue>] val mutable disabled: bool
        [<DefaultValue>] val mutable fixedWeeks: bool
        [<DefaultValue>] val mutable focusedValue: DateValue
        [<DefaultValue>] val mutable format: DateValue * LocaleDetails -> string
        [<DefaultValue>] val mutable ids: obj //todo
        [<DefaultValue>] val mutable immediate: bool
        [<DefaultValue>] val mutable isDateUnavailable: DateValue * string -> bool
        [<DefaultValue>] val mutable lazyMount: bool
        [<DefaultValue>] val mutable locale: string
        [<DefaultValue>] val mutable max: DateValue
        [<DefaultValue>] val mutable maxView: DateView
        [<DefaultValue>] val mutable min: DateValue
        [<DefaultValue>] val mutable minView: DateView
        [<DefaultValue>] val mutable name: string
        [<DefaultValue>] val mutable numOfMonths: int
        [<DefaultValue>] val mutable onExitComplete: unit -> unit
        [<DefaultValue>] val mutable onFocusChange: Browser.Types.FocusEvent -> unit
        [<DefaultValue>] val mutable onOpenChange: Browser.Types.Event -> unit
        [<DefaultValue>] val mutable onValueChange: Browser.Types.Event -> unit
        [<DefaultValue>] val mutable onViewChange: Browser.Types.Event -> unit
        [<DefaultValue>] val mutable open': bool
        [<DefaultValue>] val mutable parse: string * obj -> DateValue option
        [<DefaultValue>] val mutable placeholder: string
        [<DefaultValue>] val mutable positioning: PositioningOptions
        [<DefaultValue>] val mutable present: bool
        [<DefaultValue>] val mutable readOnly: bool
        [<DefaultValue>] val mutable selectionMode: SelectionMode
        [<DefaultValue>] val mutable startOfWeek: int
        [<DefaultValue>] val mutable timeZone: string
        [<DefaultValue>] val mutable translations: obj
        [<DefaultValue>] val mutable unmountOnExit: bool
        [<DefaultValue>] val mutable value: DateValue[]
        [<DefaultValue>] val mutable view: DateView
    [<Import("DatePicker.ClearTrigger", datePicker)>]
    type ClearTrigger() =
        inherit button()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: button -> HtmlElement
    [<Import("DatePicker.Content", datePicker)>]
    type Content() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.Control", datePicker)>]
    type Control() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.Input", datePicker)>]
    type Input() =
        inherit input()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: input -> HtmlElement        
        [<DefaultValue>] val mutable fixOnBlur: bool        
        [<DefaultValue>] val mutable index: int        
    [<Import("DatePicker.Label", datePicker)>]
    type Label() =
        inherit label()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: label -> HtmlElement        
    [<Import("DatePicker.MonthSelect", datePicker)>]
    type MonthSelect() =
        inherit select()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: select -> HtmlElement        
    [<Import("DatePicker.NextTrigger", datePicker)>]
    type NextTrigger() =
        inherit button()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: button -> HtmlElement        
    [<Import("DatePicker.Positioner", datePicker)>]
    type Positioner() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.PresetTrigger", datePicker)>]
    type PresetTrigger() =
        inherit button()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: button -> HtmlElement
        [<DefaultValue>] val mutable value: PresetTriggerValue
    [<Import("DatePicker.PrevTrigger", datePicker)>]
    type PrevTrigger() =
        inherit button()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: button -> HtmlElement        
    [<Import("DatePicker.RangeText", datePicker)>]
    type RangeText() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.RootProvider", datePicker)>]
    type RootProvider() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement
        [<DefaultValue>] val mutable value: DatePickerApi
        [<DefaultValue>] val mutable immediate: bool
        [<DefaultValue>] val mutable lazyMount: bool
        [<DefaultValue>] val mutable onExitComplete: unit -> unit
        [<DefaultValue>] val mutable present: bool
        [<DefaultValue>] val mutable unmountOnExit: bool
    [<Import("DatePicker.TableBody", datePicker)>]
    type TableBody() =
        inherit tbody()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: tbody -> HtmlElement        
    [<Import("DatePicker.TableCell", datePicker)>]
    type TableCell() =
        inherit td()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: td -> HtmlElement        
        [<DefaultValue>] val mutable value: DateValue        
        [<DefaultValue>] val mutable columns: int        
        [<DefaultValue>] val mutable disabled: bool        
        [<DefaultValue>] val mutable visibleRange: VisibleRange        
    [<Import("DatePicker.TableCellTrigger", datePicker)>]
    type TableCellTrigger() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.TableHead", datePicker)>]
    type TableHead() =
        inherit thead()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: thead -> HtmlElement        
    [<Import("DatePicker.TableHeader", datePicker)>]
    type TableHeader() =
        inherit th()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: th -> HtmlElement        
    [<Import("DatePicker.Table", datePicker)>]
    type Table() =
        inherit table()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: table -> HtmlElement
        [<DefaultValue>] val mutable columns: int
    [<Import("DatePicker.TableRow", datePicker)>]
    type TableRow() =
        inherit tr()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: tr -> HtmlElement        
    [<Import("DatePicker.Trigger", datePicker)>]
    type Trigger() =
        inherit button()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: button -> HtmlElement        
    [<Import("DatePicker.ViewControl", datePicker)>]
    type ViewControl() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.View", datePicker)>]
    type View() =
        inherit div()
        interface Polymorph
        [<DefaultValue>] val mutable view: DateView
        [<DefaultValue>] val mutable asChild: div -> HtmlElement        
    [<Import("DatePicker.ViewTrigger", datePicker)>]
    type ViewTrigger() =
        inherit button()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: button -> HtmlElement        
    [<Import("DatePicker.YearSelect", datePicker)>]
    type YearSelect() =
        inherit select()
        interface Polymorph
        [<DefaultValue>] val mutable asChild: select -> HtmlElement
        
    type DatePickerApi = Glutinum.ZagJs.DatePickerApi
    [<Import("DatePicker.Context", datePicker)>]
    type Context() =
        interface RegularNode
        interface ArkUIContext<DatePickerApi>
        
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
