namespace rec Glutinum.ZagJs

open Fable.Core
open Fable.Core.JsInterop
open System
open Glutinum.Internationalised

// [<AbstractClass>]
// [<Erase>]
// type Exports =
//     [<Import("connect", "@zag-js/date-picker")>]
//     static member connect<'T when 'T :> PropTypes> (service: DatePickerService, normalize: NormalizeProps<'T>) : DatePickerApi<'T> = nativeOnly
//     [<Import("parse", "@zag-js/date-picker")>]
//     static member parse (value: U2<string, JS.Date>) : DateValue = nativeOnly
//     [<Import("parse", "@zag-js/date-picker")>]
//     static member parse (value: U2<array<string>, array<JS.Date>>) : array<DateValue> = nativeOnly

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DateRangePreset =
    | thisWeek
    | lastWeek
    | thisMonth
    | lastMonth
    | thisQuarter
    | lastQuarter
    | thisYear
    | lastYear
    | last3Days
    | last7Days
    | last14Days
    | last30Days
    | last90Days

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DateView =
    | day
    | month
    | year

[<AllowNullLiteral>]
[<Interface>]
type ValueChangeDetails =
    abstract member value: array<DateValue> with get, set
    abstract member valueAsString: array<string> with get, set
    abstract member view: DateView with get, set

[<AllowNullLiteral>]
[<Interface>]
type FocusChangeDetails =
    inherit ValueChangeDetails
    abstract member focusedValue: DateValue with get, set
    abstract member view: DateView with get, set

[<AllowNullLiteral>]
[<Interface>]
type ViewChangeDetails =
    abstract member view: DateView with get, set

[<AllowNullLiteral>]
[<Interface>]
type OpenChangeDetails =
    abstract member ``open``: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type LocaleDetails =
    abstract member locale: string with get, set
    abstract member timeZone: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SelectionMode =
    | single
    | multiple
    | range

[<AllowNullLiteral>]
[<Interface>]
type IntlTranslations =
    abstract member dayCell: state: DayTableCellState -> string
    abstract member nextTrigger: view: DateView -> string
    abstract member monthSelect: string with get, set
    abstract member yearSelect: string with get, set
    abstract member viewTrigger: view: DateView -> string
    abstract member prevTrigger: view: DateView -> string
    abstract member presetTrigger: value: array<string> -> string
    abstract member clearTrigger: string with get, set
    abstract member trigger: ``open``: bool -> string
    abstract member content: string with get, set
    abstract member placeholder: (string -> IntlTranslations.placeholder) with get, set

[<AllowNullLiteral>]
[<Interface>]
type ElementIds =
    abstract member root: string with get, set
    abstract member label: index: float -> string
    abstract member table: id: string -> string
    abstract member tableHeader: id: string -> string
    abstract member tableBody: id: string -> string
    abstract member tableRow: id: string -> string
    abstract member content: string with get, set
    abstract member cellTrigger: id: string -> string
    abstract member prevTrigger: view: DateView -> string
    abstract member nextTrigger: view: DateView -> string
    abstract member viewTrigger: view: DateView -> string
    abstract member clearTrigger: string with get, set
    abstract member control: string with get, set
    abstract member input: index: float -> string
    abstract member trigger: string with get, set
    abstract member monthSelect: string with get, set
    abstract member yearSelect: string with get, set
    abstract member positioner: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type DirectionProperty =
    /// <summary>
    /// The document's text/writing direction.
    /// </summary>
    abstract member dir: DirectionProperty.dir with get, set

module DirectionProperty =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type dir =
        | ltr
        | rtl
        
[<AllowNullLiteral>]
[<Interface>]
type CommonProperties =
    /// <summary>
    /// The unique identifier of the machine.
    /// </summary>
    abstract member id: string with get, set
    /// <summary>
    /// A root node to correctly resolve document in custom environments. E.x.: Iframes, Electron.
    /// </summary>
    abstract member getRootNode: (unit -> obj) with get, set

[<AllowNullLiteral>]
[<Interface>]
type DatePickerProps =
    inherit DirectionProperty
    inherit CommonProperties
    /// <summary>
    /// The locale (BCP 47 language tag) to use when formatting the date.
    /// </summary>
    abstract member locale: string with get, set
    /// <summary>
    /// The localized messages to use.
    /// </summary>
    abstract member translations: IntlTranslations with get, set
    /// <summary>
    /// The ids of the elements in the date picker. Useful for composition.
    /// </summary>
    abstract member ids: ElementIds with get, set
    /// <summary>
    /// The <c>name</c> attribute of the input element.
    /// </summary>
    abstract member name: string with get, set
    /// <summary>
    /// The time zone to use
    /// </summary>
    abstract member timeZone: string with get, set
    /// <summary>
    /// Whether the calendar is disabled.
    /// </summary>
    abstract member disabled: bool with get, set
    /// <summary>
    /// Whether the calendar is read-only.
    /// </summary>
    abstract member readOnly: bool with get, set
    /// <summary>
    /// The minimum date that can be selected.
    /// </summary>
    abstract member min: DateValue with get, set
    /// <summary>
    /// The maximum date that can be selected.
    /// </summary>
    abstract member max: DateValue with get, set
    /// <summary>
    /// Whether the calendar should close after the date selection is complete.
    /// This is ignored when the selection mode is <c>multiple</c>.
    /// </summary>
    abstract member closeOnSelect: bool with get, set
    /// <summary>
    /// The controlled selected date(s).
    /// </summary>
    abstract member value: array<DateValue> with get, set
    /// <summary>
    /// The initial selected date(s) when rendered.
    /// Use when you don't need to control the selected date(s) of the date picker.
    /// </summary>
    abstract member defaultValue: array<DateValue> with get, set
    /// <summary>
    /// The controlled focused date.
    /// </summary>
    abstract member focusedValue: DateValue with get, set
    /// <summary>
    /// The initial focused date when rendered.
    /// Use when you don't need to control the focused date of the date picker.
    /// </summary>
    abstract member defaultFocusedValue: DateValue with get, set
    /// <summary>
    /// The number of months to display.
    /// </summary>
    abstract member numOfMonths: float with get, set
    /// <summary>
    /// The first day of the week.
    ///  <c>0</c> - Sunday
    ///  <c>1</c> - Monday
    ///  <c>2</c> - Tuesday
    ///  <c>3</c> - Wednesday
    ///  <c>4</c> - Thursday
    ///  <c>5</c> - Friday
    ///  <c>6</c> - Saturday
    /// </summary>
    abstract member startOfWeek: float with get, set
    /// <summary>
    /// Whether the calendar should have a fixed number of weeks.
    /// This renders the calendar with 6 weeks instead of 5 or 6.
    /// </summary>
    abstract member fixedWeeks: bool with get, set
    /// <summary>
    /// Function called when the value changes.
    /// </summary>
    abstract member onValueChange: (ValueChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the focused date changes.
    /// </summary>
    abstract member onFocusChange: (FocusChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the view changes.
    /// </summary>
    abstract member onViewChange: (ViewChangeDetails -> unit) with get, set
    /// <summary>
    /// Function called when the calendar opens or closes.
    /// </summary>
    abstract member onOpenChange: (OpenChangeDetails -> unit) with get, set
    /// <summary>
    /// Returns whether a date of the calendar is available.
    /// </summary>
    abstract member isDateUnavailable: DatePickerProps.isDateUnavailable with get, set
    /// <summary>
    /// The selection mode of the calendar.
    /// - <c>single</c> - only one date can be selected
    /// - <c>multiple</c> - multiple dates can be selected
    /// - <c>range</c> - a range of dates can be selected
    /// </summary>
    abstract member selectionMode: SelectionMode with get, set
    /// <summary>
    /// The format of the date to display in the input.
    /// </summary>
    abstract member format: DatePickerProps.format with get, set
    /// <summary>
    /// Function to parse the date from the input back to a DateValue.
    /// </summary>
    abstract member parse: DatePickerProps.parse with get, set
    /// <summary>
    /// The placeholder text to display in the input.
    /// </summary>
    abstract member placeholder: string with get, set
    /// <summary>
    /// The view of the calendar
    /// </summary>
    abstract member view: DateView with get, set
    /// <summary>
    /// The default view of the calendar
    /// </summary>
    abstract member defaultView: DateView with get, set
    /// <summary>
    /// The minimum view of the calendar
    /// </summary>
    abstract member minView: DateView with get, set
    /// <summary>
    /// The maximum view of the calendar
    /// </summary>
    abstract member maxView: DateView with get, set
    /// <summary>
    /// The user provided used to position the date picker content
    /// </summary>
    abstract member positioning: PositioningOptions with get, set
    /// <summary>
    /// The controlled open state of the date picker
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// The initial open state of the date picker when rendered.
    /// Use when you don't need to control the open state of the date picker.
    /// </summary>
    abstract member defaultOpen: bool with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PropsWithDefault =
    | minView
    | maxView
    | numOfMonths
    | defaultView
    | selectionMode
    | positioning
    | locale
    | timeZone
    | closeOnSelect
    | format
    | parse
    | focusedValue

[<StringEnum(CaseRules.KebabCase)>]
type Placement =
    | Top
    | TopStart
    | TopEnd
    | Right
    | RightStart
    | RightEnd
    | Bottom
    | BottomStart
    | BottomEnd
    | Left
    | LeftStart
    | LeftEnd
    

[<AllowNullLiteral>]
[<Interface>]
type PrivateContext =
    /// <summary>
    /// The active input value (based on the active index)
    /// </summary>
    abstract member inputValue: string with get, set
    /// <summary>
    /// The start date of the current visible duration.
    /// </summary>
    abstract member startValue: DateValue with get, set
    /// <summary>
    /// Whether the calendar has focus
    /// </summary>
    abstract member hasFocus: bool with get, set
    /// <summary>
    /// The current hovered date. Useful for range selection mode.
    /// </summary>
    abstract member hoveredValue: DateValue with get, set
    /// <summary>
    /// The index of the currently active date.
    /// Used in range selection mode.
    /// </summary>
    abstract member activeIndex: float with get, set
    /// <summary>
    /// The computed placement (maybe different from initial placement)
    /// </summary>
    abstract member currentPlacement: Placement with get, set
    /// <summary>
    /// Whether the calendar should restore focus to the input when it closes.
    /// </summary>
    abstract member restoreFocus: bool with get, set
    /// <summary>
    /// The selected date(s).
    /// </summary>
    abstract member value: array<DateValue> with get, set
    /// <summary>
    /// The view of the calendar.
    /// </summary>
    abstract member view: DateView with get, set
    /// <summary>
    /// The focused date.
    /// </summary>
    abstract member focusedValue: DateValue with get, set

[<AllowNullLiteral>]
[<Interface>]
type ComputedContext =
    /// <summary>
    /// The end date of the current visible duration.
    /// </summary>
    abstract member endValue: DateValue with get
    /// <summary>
    /// Whether the calendar is interactive.
    /// </summary>
    abstract member isInteractive: bool with get
    /// <summary>
    /// The duration of the visible range.
    /// </summary>
    abstract member visibleDuration: DateDuration with get
    /// <summary>
    /// The start/end date of the current visible duration.
    /// </summary>
    abstract member visibleRange: ComputedContext.visibleRange with get
    /// <summary>
    /// The text to announce when the visible range changes.
    /// </summary>
    abstract member visibleRangeText: ComputedContext.visibleRangeText with get
    /// <summary>
    /// Whether the next visible range is valid.
    /// </summary>
    abstract member isNextVisibleRangeValid: bool with get
    /// <summary>
    /// Whether the previous visible range is valid.
    /// </summary>
    abstract member isPrevVisibleRangeValid: bool with get
    /// <summary>
    /// The value text to display in the input.
    /// </summary>
    abstract member valueAsString: array<string> with get

[<AllowNullLiteral>]
[<Interface>]
type Refs =
    /// <summary>
    /// The live region to announce changes
    /// </summary>
    abstract member announcer: obj with get, set
    // abstract member announcer: LiveRegion with get, set

[<AllowNullLiteral>]
[<Interface>]
type DatePickerSchema =
    abstract member state: DatePickerSchema.state with get, set
    abstract member tag: DatePickerSchema.tag with get, set
    abstract member props: DatePickerProps with get, set
    abstract member context: PrivateContext with get, set
    abstract member computed: ComputedContext with get, set
    abstract member refs: Refs with get, set
    abstract member guard: string with get, set
    abstract member effect: string with get, set
    abstract member action: string with get, set

type DatePickerService = DatePickerSchema
    // Service<DatePickerSchema>

type DatePickerMachine = DatePickerSchema
    // Machine<DatePickerSchema>

[<AllowNullLiteral>]
[<Interface>]
type Range<'T> =
    abstract member start: 'T with get, set
    abstract member ``end``: 'T with get, set

type VisibleRange =
    Range<DateValue>

[<AllowNullLiteral>]
[<Interface>]
type DateValueOffset =
    abstract member visibleRange: VisibleRange with get, set
    abstract member weeks: array<array<DateValue>> with get, set
    abstract member visibleRangeText: DateValueOffset.visibleRangeText with get, set

[<AllowNullLiteral>]
[<Interface>]
type TableCellProps =
    abstract member disabled: bool with get, set
    abstract member value: float with get, set
    abstract member columns: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type TableCellState =
    abstract member focused: bool with get, set
    abstract member selectable: bool with get, set
    abstract member selected: bool with get, set
    abstract member valueText: string with get, set
    abstract member disabled: bool with get

[<AllowNullLiteral>]
[<Interface>]
type DayTableCellProps =
    abstract member value: DateValue with get, set
    abstract member disabled: bool with get, set
    abstract member visibleRange: VisibleRange with get, set

[<AllowNullLiteral>]
[<Interface>]
type DayTableCellState =
    abstract member invalid: bool with get, set
    abstract member disabled: bool with get, set
    abstract member selected: bool with get, set
    abstract member unavailable: bool with get, set
    abstract member outsideRange: bool with get, set
    abstract member inRange: bool with get, set
    abstract member firstInRange: bool with get, set
    abstract member lastInRange: bool with get, set
    abstract member today: bool with get, set
    abstract member weekend: bool with get, set
    abstract member formattedDate: string with get, set
    abstract member focused: bool with get
    abstract member ariaLabel: string with get
    abstract member selectable: bool with get

[<AllowNullLiteral>]
[<Interface>]
type TableProps =
    abstract member view: DateView with get, set
    abstract member columns: float with get, set
    abstract member id: string with get, set

type PresetTriggerValue =
    U2<array<DateValue>, DateRangePreset>

[<AllowNullLiteral>]
[<Interface>]
type PresetTriggerProps =
    abstract member value: PresetTriggerValue with get, set

[<AllowNullLiteral>]
[<Interface>]
type ViewProps =
    abstract member view: DateView with get, set

[<AllowNullLiteral>]
[<Interface>]
type InputProps =
    /// <summary>
    /// The index of the input to focus.
    /// </summary>
    abstract member index: float with get, set
    /// <summary>
    /// Whether to fix the input value on blur.
    /// </summary>
    abstract member fixOnBlur: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type LabelProps =
    abstract member index: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type MonthGridProps =
    abstract member columns: float with get, set
    abstract member format: MonthGridProps.format with get, set

[<AllowNullLiteral>]
[<Interface>]
type Cell =
    abstract member label: string with get, set
    abstract member value: float with get, set

type MonthGridValue =
    array<array<Cell>>

[<AllowNullLiteral>]
[<Interface>]
type YearGridProps =
    abstract member columns: float with get, set

type YearGridValue =
    array<array<Cell>>

[<AllowNullLiteral>]
[<Interface>]
type WeekDay =
    abstract member value: DateValue with get, set
    abstract member short: string with get, set
    abstract member long: string with get, set
    abstract member narrow: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type MonthFormatOptions =
    abstract member format: MonthFormatOptions.format with get, set

[<AllowNullLiteral>]
[<Interface>]
type VisibleRangeText =
    inherit Range<string>
    abstract member formatted: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type DatePickerApi =
    /// <summary>
    /// Whether the input is focused
    /// </summary>
    abstract member focused: bool with get, set
    /// <summary>
    /// Whether the date picker is open
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// The current view of the date picker
    /// </summary>
    abstract member view: DateView with get, set
    /// <summary>
    /// Returns an array of days in the week index counted from the provided start date, or the first visible date if not given.
    /// </summary>
    abstract member getDaysInWeek: week: float * ?from: DateValue -> array<DateValue>
    /// <summary>
    /// Returns the offset of the month based on the provided number of months.
    /// </summary>
    abstract member getOffset: duration: DateDuration -> DateValueOffset
    /// <summary>
    /// Returns the range of dates based on the provided date range preset.
    /// </summary>
    abstract member getRangePresetValue: value: DateRangePreset -> array<DateValue>
    /// <summary>
    /// Returns the weeks of the month from the provided date. Represented as an array of arrays of dates.
    /// </summary>
    abstract member getMonthWeeks: ?from: DateValue -> array<array<DateValue>>
    /// <summary>
    /// Returns whether the provided date is available (or can be selected)
    /// </summary>
    abstract member isUnavailable: date: DateValue -> bool
    /// <summary>
    /// The weeks of the month. Represented as an array of arrays of dates.
    /// </summary>
    abstract member weeks: array<array<DateValue>> with get, set
    /// <summary>
    /// The days of the week. Represented as an array of strings.
    /// </summary>
    abstract member weekDays: array<WeekDay> with get, set
    /// <summary>
    /// The visible range of dates.
    /// </summary>
    abstract member visibleRange: VisibleRange with get, set
    /// <summary>
    /// The human readable text for the visible range of dates.
    /// </summary>
    abstract member visibleRangeText: VisibleRangeText with get, set
    /// <summary>
    /// The selected date.
    /// </summary>
    abstract member value: array<DateValue> with get, set
    /// <summary>
    /// The selected date as a Date object.
    /// </summary>
    abstract member valueAsDate: array<JS.Date> with get, set
    /// <summary>
    /// The selected date as a string.
    /// </summary>
    abstract member valueAsString: array<string> with get, set
    /// <summary>
    /// The focused date.
    /// </summary>
    abstract member focusedValue: DateValue with get, set
    /// <summary>
    /// The focused date as a Date object.
    /// </summary>
    abstract member focusedValueAsDate: JS.Date with get, set
    /// <summary>
    /// The focused date as a string.
    /// </summary>
    abstract member focusedValueAsString: string with get, set
    /// <summary>
    /// Sets the selected date to today.
    /// </summary>
    abstract member selectToday: unit -> unit
    /// <summary>
    /// Sets the selected date to the given date.
    /// </summary>
    abstract member setValue: values: array<CalendarDate> -> unit
    /// <summary>
    /// Sets the focused date to the given date.
    /// </summary>
    abstract member setFocusedValue: value: CalendarDate -> unit
    /// <summary>
    /// Clears the selected date(s).
    /// </summary>
    abstract member clearValue: unit -> unit
    /// <summary>
    /// Function to open or close the calendar.
    /// </summary>
    abstract member setOpen: ``open``: bool -> unit
    /// <summary>
    /// Function to set the selected month.
    /// </summary>
    abstract member focusMonth: month: float -> unit
    /// <summary>
    /// Function to set the selected year.
    /// </summary>
    abstract member focusYear: year: float -> unit
    /// <summary>
    /// Returns the months of the year
    /// </summary>
    abstract member getYears: unit -> array<Cell>
    /// <summary>
    /// Returns the years of the decade based on the columns.
    /// Represented as an array of arrays of years.
    /// </summary>
    abstract member getYearsGrid: ?props: YearGridProps -> YearGridValue
    /// <summary>
    /// Returns the start and end years of the decade.
    /// </summary>
    abstract member getDecade: unit -> Range<float>
    /// <summary>
    /// Returns the months of the year
    /// </summary>
    abstract member getMonths: ?props: MonthFormatOptions -> array<Cell>
    /// <summary>
    /// Returns the months of the year based on the columns.
    /// Represented as an array of arrays of months.
    /// </summary>
    abstract member getMonthsGrid: ?props: MonthGridProps -> MonthGridValue
    /// <summary>
    /// Formats the given date value based on the provided.
    /// </summary>
    abstract member format: value: CalendarDate * ?opts: Intl.DateTimeFormatOptions -> string
    /// <summary>
    /// Sets the view of the date picker.
    /// </summary>
    abstract member setView: view: DateView -> unit
    /// <summary>
    /// Goes to the next month/year/decade.
    /// </summary>
    abstract member goToNext: unit -> unit
    /// <summary>
    /// Goes to the previous month/year/decade.
    /// </summary>
    abstract member goToPrev: unit -> unit
    /// <summary>
    /// Returns the state details for a given cell.
    /// </summary>
    abstract member getDayTableCellState: props: DayTableCellProps -> DayTableCellState
    /// <summary>
    /// Returns the state details for a given month cell.
    /// </summary>
    abstract member getMonthTableCellState: props: TableCellProps -> TableCellState
    /// <summary>
    /// Returns the state details for a given year cell.
    /// </summary>
    abstract member getYearTableCellState: props: TableCellProps -> TableCellState
    abstract member getRootProps: unit -> obj
    abstract member getLabelProps: ?props: LabelProps -> obj
    abstract member getControlProps: unit -> obj
    abstract member getContentProps: unit -> obj
    abstract member getPositionerProps: unit -> obj
    abstract member getRangeTextProps: unit -> obj
    abstract member getTableProps: ?props: TableProps -> obj
    abstract member getTableHeadProps: ?props: TableProps -> obj
    abstract member getTableHeaderProps: ?props: TableProps -> obj
    abstract member getTableBodyProps: ?props: TableProps -> obj
    abstract member getTableRowProps: ?props: TableProps -> obj
    abstract member getDayTableCellProps: props: DayTableCellProps -> obj
    abstract member getDayTableCellTriggerProps: props: DayTableCellProps -> obj
    abstract member getMonthTableCellProps: props: TableCellProps -> obj
    abstract member getMonthTableCellTriggerProps: props: TableCellProps -> obj
    abstract member getYearTableCellProps: props: TableCellProps -> obj
    abstract member getYearTableCellTriggerProps: props: TableCellProps -> obj
    abstract member getNextTriggerProps: ?props: ViewProps -> obj
    abstract member getPrevTriggerProps: ?props: ViewProps -> obj
    abstract member getClearTriggerProps: unit -> obj
    abstract member getTriggerProps: unit -> obj
    abstract member getPresetTriggerProps: props: PresetTriggerProps -> obj
    abstract member getViewProps: ?props: ViewProps -> obj
    abstract member getViewTriggerProps: ?props: ViewProps -> obj
    abstract member getViewControlProps: ?props: ViewProps -> obj
    abstract member getInputProps: ?props: InputProps -> obj
    abstract member getMonthSelectProps: unit -> obj
    abstract member getYearSelectProps: unit -> obj















module IntlTranslations =

    [<Global>]
    [<AllowNullLiteral>]
    type placeholder
        [<ParamObject; Emit("$0")>]
        (
            year: string,
            month: string,
            day: string
        ) =

        member val year : string = nativeOnly with get, set
        member val month : string = nativeOnly with get, set
        member val day : string = nativeOnly with get, set

module DatePickerProps =

    type isDateUnavailable =
        delegate of date: DateValue * locale: string -> bool

    type format =
        delegate of date: DateValue * details: LocaleDetails -> string

    type parse =
        delegate of value: string * details: LocaleDetails -> DateValue

module ComputedContext =

    [<Global>]
    [<AllowNullLiteral>]
    type visibleRange
        [<ParamObject; Emit("$0")>]
        (
            start: DateValue,
            ``end``: DateValue
        ) =

        member val start : DateValue = nativeOnly with get, set
        member val ``end`` : DateValue = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type visibleRangeText
        [<ParamObject; Emit("$0")>]
        (
            start: string,
            ``end``: string,
            formatted: string
        ) =

        member val start : string = nativeOnly with get, set
        member val ``end`` : string = nativeOnly with get, set
        member val formatted : string = nativeOnly with get, set

module DatePickerSchema =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type state =
        | idle
        | focused
        | ``open``

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type tag =
        | ``open``
        | closed

module DateValueOffset =

    [<Global>]
    [<AllowNullLiteral>]
    type visibleRangeText
        [<ParamObject; Emit("$0")>]
        (
            start: string,
            ``end``: string
        ) =

        member val start : string = nativeOnly with get, set
        member val ``end`` : string = nativeOnly with get, set

module MonthGridProps =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type format =
        | short
        | long

module MonthFormatOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type format =
        | short
        | long
