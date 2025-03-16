namespace rec Glutinum.Internationalised

open Fable.Core
open Fable.Core.JsInterop
open System

module Intl =
    [<AllowNullLiteral>]
    [<Interface>]
    type ResolvedDateTimeFormatOptions =
        abstract member locale: string with get, set
        abstract member calendar: string with get, set
        abstract member numberingSystem: string with get, set
        abstract member timeZone: string with get, set
        abstract member hour12: bool option with get, set
        abstract member weekday: string option with get, set
        abstract member era: string option with get, set
        abstract member year: string option with get, set
        abstract member month: string option with get, set
        abstract member day: string option with get, set
        abstract member hour: string option with get, set
        abstract member minute: string option with get, set
        abstract member second: string option with get, set
        abstract member timeZoneName: string option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DateTimeFormat =
        abstract member format: ?date: U2<JS.Date, float> -> string
        abstract member resolvedOptions: unit -> ResolvedDateTimeFormatOptions

    [<AllowNullLiteral>]
    [<Interface>]
    type DateTimeFormatOptions =
        abstract member localeMatcher: DateTimeFormatOptions.localeMatcher option with get, set
        abstract member weekday: DateTimeFormatOptions.weekday option with get, set
        abstract member era: DateTimeFormatOptions.era option with get, set
        abstract member year: DateTimeFormatOptions.year option with get, set
        abstract member month: DateTimeFormatOptions.month option with get, set
        abstract member day: DateTimeFormatOptions.day option with get, set
        abstract member hour: DateTimeFormatOptions.hour option with get, set
        abstract member minute: DateTimeFormatOptions.minute option with get, set
        abstract member second: DateTimeFormatOptions.second option with get, set
        abstract member timeZoneName: DateTimeFormatOptions.timeZoneName option with get, set
        abstract member formatMatcher: DateTimeFormatOptions.formatMatcher option with get, set
        abstract member hour12: bool option with get, set
        abstract member timeZone: string option with get, set

    module DateTimeFormatOptions =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type localeMatcher =
            | ``best fit``
            | lookup

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type weekday =
            | long
            | short
            | narrow

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type era =
            | long
            | short
            | narrow

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type year =
            | numeric
            | ``2-digit``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type month =
            | numeric
            | ``2-digit``
            | long
            | short
            | narrow

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type day =
            | numeric
            | ``2-digit``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type hour =
            | numeric
            | ``2-digit``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type minute =
            | numeric
            | ``2-digit``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type second =
            | numeric
            | ``2-digit``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type timeZoneName =
            | short
            | long
            | shortOffset
            | longOffset
            | shortGeneric
            | longGeneric

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type formatMatcher =
            | ``best fit``
            | basic

    [<AllowNullLiteral>]
    [<Interface>]
    type ResolvedNumberFormatOptions =
        abstract member locale: string with get, set
        abstract member numberingSystem: string with get, set
        abstract member style: string with get, set
        abstract member currency: string option with get, set
        abstract member minimumIntegerDigits: float with get, set
        abstract member minimumFractionDigits: float with get, set
        abstract member maximumFractionDigits: float with get, set
        abstract member minimumSignificantDigits: float option with get, set
        abstract member maximumSignificantDigits: float option with get, set
        abstract member useGrouping: bool with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type NumberFormat =
        abstract member format: value: float -> string
        abstract member resolvedOptions: unit -> ResolvedNumberFormatOptions

    [<AllowNullLiteral>]
    [<Interface>]
    type NumberFormatOptions =
        abstract member localeMatcher: string option with get, set
        abstract member style: string option with get, set
        abstract member currency: string option with get, set
        abstract member currencySign: string option with get, set
        abstract member useGrouping: bool option with get, set
        abstract member minimumIntegerDigits: float option with get, set
        abstract member minimumFractionDigits: float option with get, set
        abstract member maximumFractionDigits: float option with get, set
        abstract member minimumSignificantDigits: float option with get, set
        abstract member maximumSignificantDigits: float option with get, set


[<AbstractClass>]
[<Erase>]
type Exports =
    [<Import("NumberFormatter", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member NumberFormatter (locale: string, ?options: NumberFormatOptions) : NumberFormatter = nativeOnly
    [<Import("NumberParser", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member NumberParser (locale: string, ?options: Intl.NumberFormatOptions) : NumberParser = nativeOnly

[<AllowNullLiteral>]
[<Interface>]
type NumberFormatOptions =
    inherit Intl.NumberFormatOptions
    /// <summary>
    /// Overrides default numbering system for the current locale.
    /// </summary>
    abstract member numberingSystem: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type NumberRangeFormatPart =
    // inherit Intl.NumberFormatPart
    abstract member source: NumberRangeFormatPart.source with get, set

[<AllowNullLiteral>]
[<Interface>]
type NumberFormatter =
    inherit Intl.NumberFormat
    abstract member format: value: float -> string
    // abstract member formatToParts: value: float -> ResizeArray<Intl.NumberFormatPart>
    abstract member formatRange: start: float * ``end``: float -> string
    abstract member formatRangeToParts: start: float * ``end``: float -> ResizeArray<NumberRangeFormatPart>
    abstract member resolvedOptions: unit -> Intl.ResolvedNumberFormatOptions

[<AllowNullLiteral>]
[<Interface>]
type NumberParser =
    abstract member parse: value: string -> float
    abstract member isValidPartialNumber: value: string * ?minValue: float * ?maxValue: float -> bool
    abstract member getNumberingSystem: value: string -> string

module NumberRangeFormatPart =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type source =
        | startRange
        | endRange
        | shared

type Exports with
    /// <summary>
    /// Returns whether the given dates occur on the same day, regardless of the time or calendar system.
    /// </summary>
    [<Import("isSameDay", "@internationalized/date")>]
    static member isSameDay (a: DateValue, b: DateValue) : bool = nativeOnly
    /// <summary>
    /// Returns whether the given dates occur in the same month, using the calendar system of the first date.
    /// </summary>
    [<Import("isSameMonth", "@internationalized/date")>]
    static member isSameMonth (a: DateValue, b: DateValue) : bool = nativeOnly
    /// <summary>
    /// Returns whether the given dates occur in the same year, using the calendar system of the first date.
    /// </summary>
    [<Import("isSameYear", "@internationalized/date")>]
    static member isSameYear (a: DateValue, b: DateValue) : bool = nativeOnly
    /// <summary>
    /// Returns whether the given dates occur on the same day, and are of the same calendar system.
    /// </summary>
    [<Import("isEqualDay", "@internationalized/date")>]
    static member isEqualDay (a: DateValue, b: DateValue) : bool = nativeOnly
    /// <summary>
    /// Returns whether the given dates occur in the same month, and are of the same calendar system.
    /// </summary>
    [<Import("isEqualMonth", "@internationalized/date")>]
    static member isEqualMonth (a: DateValue, b: DateValue) : bool = nativeOnly
    /// <summary>
    /// Returns whether the given dates occur in the same year, and are of the same calendar system.
    /// </summary>
    [<Import("isEqualYear", "@internationalized/date")>]
    static member isEqualYear (a: DateValue, b: DateValue) : bool = nativeOnly
    /// <summary>
    /// Returns whether the date is today in the given time zone.
    /// </summary>
    [<Import("isToday", "@internationalized/date")>]
    static member isToday (date: DateValue, timeZone: string) : bool = nativeOnly
    /// <summary>
    /// Returns the day of week for the given date and locale. Days are numbered from zero to six,
    /// where zero is the first day of the week in the given locale. For example, in the United States,
    /// the first day of the week is Sunday, but in France it is Monday.
    /// </summary>
    [<Import("getDayOfWeek", "@internationalized/date")>]
    static member getDayOfWeek (date: DateValue, locale: string, ?firstDayOfWeek: DayOfWeek) : float = nativeOnly
    /// <summary>
    /// Returns the current time in the given time zone.
    /// </summary>
    [<Import("now", "@internationalized/date")>]
    static member now (timeZone: string) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Returns today's date in the given time zone.
    /// </summary>
    [<Import("today", "@internationalized/date")>]
    static member today (timeZone: string) : CalendarDate = nativeOnly
    /// <summary>
    /// Returns the number of hours in the given date and time zone.
    /// Usually this is 24, but it could be 23 or 25 if the date is on a daylight saving transition.
    /// </summary>
    [<Import("getHoursInDay", "@internationalized/date")>]
    static member getHoursInDay (a: CalendarDate, timeZone: string) : float = nativeOnly
    /// <summary>
    /// Returns the time zone identifier for the current user.
    /// </summary>
    [<Import("getLocalTimeZone", "@internationalized/date")>]
    static member getLocalTimeZone () : string = nativeOnly
    /// <summary>
    /// Returns the first date of the month for the given date.
    /// </summary>
    [<Import("startOfMonth", "@internationalized/date")>]
    static member startOfMonth (date: ZonedDateTime) : ZonedDateTime = nativeOnly
    [<Import("startOfMonth", "@internationalized/date")>]
    static member startOfMonth (date: CalendarDateTime) : CalendarDateTime = nativeOnly
    [<Import("startOfMonth", "@internationalized/date")>]
    static member startOfMonth (date: CalendarDate) : CalendarDate = nativeOnly
    [<Import("startOfMonth", "@internationalized/date")>]
    static member startOfMonth (date: DateValue) : DateValue = nativeOnly
    /// <summary>
    /// Returns the last date of the month for the given date.
    /// </summary>
    [<Import("endOfMonth", "@internationalized/date")>]
    static member endOfMonth (date: ZonedDateTime) : ZonedDateTime = nativeOnly
    [<Import("endOfMonth", "@internationalized/date")>]
    static member endOfMonth (date: CalendarDateTime) : CalendarDateTime = nativeOnly
    [<Import("endOfMonth", "@internationalized/date")>]
    static member endOfMonth (date: CalendarDate) : CalendarDate = nativeOnly
    [<Import("endOfMonth", "@internationalized/date")>]
    static member endOfMonth (date: DateValue) : DateValue = nativeOnly
    /// <summary>
    /// Returns the first day of the year for the given date.
    /// </summary>
    [<Import("startOfYear", "@internationalized/date")>]
    static member startOfYear (date: ZonedDateTime) : ZonedDateTime = nativeOnly
    [<Import("startOfYear", "@internationalized/date")>]
    static member startOfYear (date: CalendarDateTime) : CalendarDateTime = nativeOnly
    [<Import("startOfYear", "@internationalized/date")>]
    static member startOfYear (date: CalendarDate) : CalendarDate = nativeOnly
    [<Import("startOfYear", "@internationalized/date")>]
    static member startOfYear (date: DateValue) : DateValue = nativeOnly
    /// <summary>
    /// Returns the last day of the year for the given date.
    /// </summary>
    [<Import("endOfYear", "@internationalized/date")>]
    static member endOfYear (date: ZonedDateTime) : ZonedDateTime = nativeOnly
    [<Import("endOfYear", "@internationalized/date")>]
    static member endOfYear (date: CalendarDateTime) : CalendarDateTime = nativeOnly
    [<Import("endOfYear", "@internationalized/date")>]
    static member endOfYear (date: CalendarDate) : CalendarDate = nativeOnly
    [<Import("endOfYear", "@internationalized/date")>]
    static member endOfYear (date: DateValue) : DateValue = nativeOnly
    [<Import("getMinimumMonthInYear", "@internationalized/date")>]
    static member getMinimumMonthInYear (date: AnyCalendarDate) : float = nativeOnly
    [<Import("getMinimumDayInMonth", "@internationalized/date")>]
    static member getMinimumDayInMonth (date: AnyCalendarDate) : float = nativeOnly
    /// <summary>
    /// Returns the first date of the week for the given date and locale.
    /// </summary>
    [<Import("startOfWeek", "@internationalized/date")>]
    static member startOfWeek (date: ZonedDateTime, locale: string, ?firstDayOfWeek: DayOfWeek) : ZonedDateTime = nativeOnly
    [<Import("startOfWeek", "@internationalized/date")>]
    static member startOfWeek (date: CalendarDateTime, locale: string, ?firstDayOfWeek: DayOfWeek) : CalendarDateTime = nativeOnly
    [<Import("startOfWeek", "@internationalized/date")>]
    static member startOfWeek (date: CalendarDate, locale: string, ?firstDayOfWeek: DayOfWeek) : CalendarDate = nativeOnly
    [<Import("startOfWeek", "@internationalized/date")>]
    static member startOfWeek (date: DateValue, locale: string, ?firstDayOfWeek: DayOfWeek) : DateValue = nativeOnly
    /// <summary>
    /// Returns the last date of the week for the given date and locale.
    /// </summary>
    [<Import("endOfWeek", "@internationalized/date")>]
    static member endOfWeek (date: ZonedDateTime, locale: string, ?firstDayOfWeek: DayOfWeek) : ZonedDateTime = nativeOnly
    [<Import("endOfWeek", "@internationalized/date")>]
    static member endOfWeek (date: CalendarDateTime, locale: string, ?firstDayOfWeek: DayOfWeek) : CalendarDateTime = nativeOnly
    [<Import("endOfWeek", "@internationalized/date")>]
    static member endOfWeek (date: CalendarDate, locale: string, ?firstDayOfWeek: DayOfWeek) : CalendarDate = nativeOnly
    [<Import("endOfWeek", "@internationalized/date")>]
    static member endOfWeek (date: DateValue, locale: string, ?firstDayOfWeek: DayOfWeek) : DateValue = nativeOnly
    /// <summary>
    /// Returns the number of weeks in the given month and locale.
    /// </summary>
    [<Import("getWeeksInMonth", "@internationalized/date")>]
    static member getWeeksInMonth (date: DateValue, locale: string, ?firstDayOfWeek: DayOfWeek) : float = nativeOnly
    /// <summary>
    /// Returns the lesser of the two provider dates.
    /// </summary>
    [<Import("minDate", "@internationalized/date")>]
    static member minDate (?a: DateValue, ?b: DateValue) : DateValue option = nativeOnly
    /// <summary>
    /// Returns the greater of the two provider dates.
    /// </summary>
    [<Import("maxDate", "@internationalized/date")>]
    static member maxDate (?a: DateValue, ?b: DateValue) : DateValue option = nativeOnly
    /// <summary>
    /// Returns whether the given date is on a weekend in the given locale.
    /// </summary>
    [<Import("isWeekend", "@internationalized/date")>]
    static member isWeekend (date: DateValue, locale: string) : bool = nativeOnly
    /// <summary>
    /// Returns whether the given date is on a weekday in the given locale.
    /// </summary>
    [<Import("isWeekday", "@internationalized/date")>]
    static member isWeekday (date: DateValue, locale: string) : bool = nativeOnly
    /// <summary>
    /// Takes a Unix epoch (milliseconds since 1970) and converts it to the provided time zone.
    /// </summary>
    [<Import("fromAbsolute", "@internationalized/date")>]
    static member fromAbsolute (ms: float, timeZone: string) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Takes a <c>Date</c> object and converts it to the provided time zone.
    /// </summary>
    [<Import("fromDate", "@internationalized/date")>]
    static member fromDate (date: JS.Date, timeZone: string) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Converts a value with date components such as a <c>CalendarDateTime</c> or <c>ZonedDateTime</c> into a <c>CalendarDate</c>.
    /// </summary>
    [<Import("toCalendarDate", "@internationalized/date")>]
    static member toCalendarDate (dateTime: AnyCalendarDate) : CalendarDate = nativeOnly
    /// <summary>
    /// Converts a date value to a <c>CalendarDateTime</c>. An optional <c>Time</c> value can be passed to set the time
    /// of the resulting value, otherwise it will default to midnight.
    /// </summary>
    [<Import("toCalendarDateTime", "@internationalized/date")>]
    static member toCalendarDateTime (date: U3<CalendarDate, CalendarDateTime, ZonedDateTime>, ?time: AnyTime) : CalendarDateTime = nativeOnly
    /// <summary>
    /// Extracts the time components from a value containing a date and time.
    /// </summary>
    [<Import("toTime", "@internationalized/date")>]
    static member toTime (dateTime: U2<CalendarDateTime, ZonedDateTime>) : Time = nativeOnly
    /// <summary>
    /// Converts a date from one calendar system to another.
    /// </summary>
    [<Import("toCalendar", "@internationalized/date")>]
    static member toCalendar<'T when 'T :> AnyCalendarDate> (date: 'T, calendar: Calendar) : 'T = nativeOnly
    /// <summary>
    /// Converts a date value to a <c>ZonedDateTime</c> in the provided time zone. The <c>disambiguation</c> option can be set
    /// to control how values that fall on daylight saving time changes are interpreted.
    /// </summary>
    [<Import("toZoned", "@internationalized/date")>]
    static member toZoned (date: U3<CalendarDate, CalendarDateTime, ZonedDateTime>, timeZone: string, ?disambiguation: Disambiguation) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Converts a <c>ZonedDateTime</c> from one time zone to another.
    /// </summary>
    [<Import("toTimeZone", "@internationalized/date")>]
    static member toTimeZone (date: ZonedDateTime, timeZone: string) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Converts the given <c>ZonedDateTime</c> into the user's local time zone.
    /// </summary>
    [<Import("toLocalTimeZone", "@internationalized/date")>]
    static member toLocalTimeZone (date: ZonedDateTime) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 time string.
    /// </summary>
    [<Import("parseTime", "@internationalized/date")>]
    static member parseTime (value: string) : Time = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 date string, with no time components.
    /// </summary>
    [<Import("parseDate", "@internationalized/date")>]
    static member parseDate (value: string) : CalendarDate = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 date and time string, with no time zone.
    /// </summary>
    [<Import("parseDateTime", "@internationalized/date")>]
    static member parseDateTime (value: string) : CalendarDateTime = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 date and time string with a time zone extension and optional UTC offset
    /// (e.g. "2021-11-07T00:45[America/Los_Angeles]" or "2021-11-07T00:45-07:00[America/Los_Angeles]").
    /// Ambiguous times due to daylight saving time transitions are resolved according to the <c>disambiguation</c>
    /// parameter.
    /// </summary>
    [<Import("parseZonedDateTime", "@internationalized/date")>]
    static member parseZonedDateTime (value: string, ?disambiguation: Disambiguation) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 date and time string with a UTC offset (e.g. "2021-11-07T07:45:00Z"
    /// or "2021-11-07T07:45:00-07:00"). The result is converted to the provided time zone.
    /// </summary>
    [<Import("parseAbsolute", "@internationalized/date")>]
    static member parseAbsolute (value: string, timeZone: string) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 date and time string with a UTC offset (e.g. "2021-11-07T07:45:00Z"
    /// or "2021-11-07T07:45:00-07:00"). The result is converted to the user's local time zone.
    /// </summary>
    [<Import("parseAbsoluteToLocal", "@internationalized/date")>]
    static member parseAbsoluteToLocal (value: string) : ZonedDateTime = nativeOnly
    /// <summary>
    /// Parses an ISO 8601 duration string (e.g. "P3Y6M6W4DT12H30M5S").
    /// </summary>
    /// <param name="value">
    /// An ISO 8601 duration string.
    /// </param>
    /// <returns>
    /// A DateTimeDuration object.
    /// </returns>
    [<Import("parseDuration", "@internationalized/date")>]
    static member parseDuration (value: string) : DateTimeDuration = nativeOnly
    /// <summary>
    /// Creates a <c>Calendar</c> instance from a Unicode calendar identifier string.
    /// </summary>
    [<Import("createCalendar", "@internationalized/date")>]
    static member createCalendar (name: string) : Calendar = nativeOnly
    [<Import("GregorianCalendar", "@internationalized/date"); EmitConstructor>]
    static member GregorianCalendar () : GregorianCalendar = nativeOnly
    [<Import("CalendarDate", "@internationalized/date"); EmitConstructor>]
    static member CalendarDate (year: float, month: float, day: float) : CalendarDate = nativeOnly
    [<Import("CalendarDate", "@internationalized/date"); EmitConstructor>]
    static member CalendarDate (era: string, year: float, month: float, day: float) : CalendarDate = nativeOnly
    [<Import("CalendarDate", "@internationalized/date"); EmitConstructor>]
    static member CalendarDate (calendar: Calendar, year: float, month: float, day: float) : CalendarDate = nativeOnly
    [<Import("CalendarDate", "@internationalized/date"); EmitConstructor>]
    static member CalendarDate (calendar: Calendar, era: string, year: float, month: float, day: float) : CalendarDate = nativeOnly
    [<Import("Time", "@internationalized/date"); EmitConstructor>]
    static member Time (?hour: float, ?minute: float, ?second: float, ?millisecond: float) : Time = nativeOnly
    [<Import("CalendarDateTime", "@internationalized/date"); EmitConstructor>]
    static member CalendarDateTime (year: float, month: float, day: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : CalendarDateTime = nativeOnly
    [<Import("CalendarDateTime", "@internationalized/date"); EmitConstructor>]
    static member CalendarDateTime (era: string, year: float, month: float, day: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : CalendarDateTime = nativeOnly
    [<Import("CalendarDateTime", "@internationalized/date"); EmitConstructor>]
    static member CalendarDateTime (calendar: Calendar, year: float, month: float, day: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : CalendarDateTime = nativeOnly
    [<Import("CalendarDateTime", "@internationalized/date"); EmitConstructor>]
    static member CalendarDateTime (calendar: Calendar, era: string, year: float, month: float, day: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : CalendarDateTime = nativeOnly
    [<Import("ZonedDateTime", "@internationalized/date"); EmitConstructor>]
    static member ZonedDateTime (year: float, month: float, day: float, timeZone: string, offset: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : ZonedDateTime = nativeOnly
    [<Import("ZonedDateTime", "@internationalized/date"); EmitConstructor>]
    static member ZonedDateTime (era: string, year: float, month: float, day: float, timeZone: string, offset: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : ZonedDateTime = nativeOnly
    [<Import("ZonedDateTime", "@internationalized/date"); EmitConstructor>]
    static member ZonedDateTime (calendar: Calendar, year: float, month: float, day: float, timeZone: string, offset: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : ZonedDateTime = nativeOnly
    [<Import("ZonedDateTime", "@internationalized/date"); EmitConstructor>]
    static member ZonedDateTime (calendar: Calendar, era: string, year: float, month: float, day: float, timeZone: string, offset: float, ?hour: float, ?minute: float, ?second: float, ?millisecond: float) : ZonedDateTime = nativeOnly
    [<Import("JapaneseCalendar", "@internationalized/date"); EmitConstructor>]
    static member JapaneseCalendar () : JapaneseCalendar = nativeOnly
    [<Import("BuddhistCalendar", "@internationalized/date"); EmitConstructor>]
    static member BuddhistCalendar () : BuddhistCalendar = nativeOnly
    [<Import("TaiwanCalendar", "@internationalized/date"); EmitConstructor>]
    static member TaiwanCalendar () : TaiwanCalendar = nativeOnly
    [<Import("PersianCalendar", "@internationalized/date"); EmitConstructor>]
    static member PersianCalendar () : PersianCalendar = nativeOnly
    [<Import("IndianCalendar", "@internationalized/date"); EmitConstructor>]
    static member IndianCalendar () : IndianCalendar = nativeOnly
    [<Import("IslamicCivilCalendar", "@internationalized/date"); EmitConstructor>]
    static member IslamicCivilCalendar () : IslamicCivilCalendar = nativeOnly
    [<Import("IslamicTabularCalendar", "@internationalized/date"); EmitConstructor>]
    static member IslamicTabularCalendar () : IslamicTabularCalendar = nativeOnly
    [<Import("IslamicUmalquraCalendar", "@internationalized/date"); EmitConstructor>]
    static member IslamicUmalquraCalendar () : IslamicUmalquraCalendar = nativeOnly
    [<Import("HebrewCalendar", "@internationalized/date"); EmitConstructor>]
    static member HebrewCalendar () : HebrewCalendar = nativeOnly
    [<Import("EthiopicCalendar", "@internationalized/date"); EmitConstructor>]
    static member EthiopicCalendar () : EthiopicCalendar = nativeOnly
    [<Import("EthiopicAmeteAlemCalendar", "@internationalized/date"); EmitConstructor>]
    static member EthiopicAmeteAlemCalendar () : EthiopicAmeteAlemCalendar = nativeOnly
    [<Import("CopticCalendar", "@internationalized/date"); EmitConstructor>]
    static member CopticCalendar () : CopticCalendar = nativeOnly
    [<Import("DateFormatter", "@internationalized/date"); EmitConstructor>]
    static member DateFormatter (locale: string, ?options: Intl.DateTimeFormatOptions) : DateFormatter = nativeOnly

[<AllowNullLiteral>]
[<Interface>]
type Mutable<'T> =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type GregorianCalendar =
    inherit Calendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getMonthsInYear: date: AnyCalendarDate -> float
    abstract member getDaysInYear: date: AnyCalendarDate -> float
    abstract member getYearsInEra: date: AnyCalendarDate -> float
    abstract member getEras: unit -> ResizeArray<string>
    abstract member isInverseEra: date: AnyCalendarDate -> bool
    abstract member balanceDate: date: Mutable<AnyCalendarDate> -> unit

type DateValue =
    U3<CalendarDate, CalendarDateTime, ZonedDateTime>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DayOfWeek =
    | sun
    | mon
    | tue
    | wed
    | thu
    | fri
    | sat

[<AllowNullLiteral>]
[<Interface>]
type CalendarDate =
    /// <summary>
    /// The calendar system associated with this date, e.g. Gregorian.
    /// </summary>
    abstract member calendar: Calendar with get
    /// <summary>
    /// The calendar era for this date, e.g. "BC" or "AD".
    /// </summary>
    abstract member era: string with get
    /// <summary>
    /// The year of this date within the era.
    /// </summary>
    abstract member year: float with get
    /// <summary>
    /// The month number within the year. Note that some calendar systems such as Hebrew
    /// may have a variable number of months per year. Therefore, month numbers may not
    /// always correspond to the same month names in different years.
    /// </summary>
    abstract member month: float with get
    /// <summary>
    /// The day number within the month.
    /// </summary>
    abstract member day: float with get
    abstract member copy: unit -> CalendarDate
    abstract member add: duration: DateDuration -> CalendarDate
    abstract member subtract: duration: DateDuration -> CalendarDate
    abstract member set: fields: DateFields -> CalendarDate
    abstract member cycle: field: DateField * amount: float * ?options: CycleOptions -> CalendarDate
    abstract member toDate: timeZone: string -> JS.Date
    abstract member toString: unit -> string
    abstract member compare: b: AnyCalendarDate -> float

[<AllowNullLiteral>]
[<Interface>]
type Time =
    /// <summary>
    /// The hour, numbered from 0 to 23.
    /// </summary>
    abstract member hour: float with get
    /// <summary>
    /// The minute in the hour.
    /// </summary>
    abstract member minute: float with get
    /// <summary>
    /// The second in the minute.
    /// </summary>
    abstract member second: float with get
    /// <summary>
    /// The millisecond in the second.
    /// </summary>
    abstract member millisecond: float with get
    abstract member copy: unit -> Time
    abstract member add: duration: TimeDuration -> Time
    abstract member subtract: duration: TimeDuration -> Time
    abstract member set: fields: TimeFields -> Time
    abstract member cycle: field: TimeField * amount: float * ?options: CycleTimeOptions -> Time
    abstract member toString: unit -> string
    abstract member compare: b: AnyTime -> float

[<AllowNullLiteral>]
[<Interface>]
type CalendarDateTime =
    /// <summary>
    /// The calendar system associated with this date, e.g. Gregorian.
    /// </summary>
    abstract member calendar: Calendar with get
    /// <summary>
    /// The calendar era for this date, e.g. "BC" or "AD".
    /// </summary>
    abstract member era: string with get
    /// <summary>
    /// The year of this date within the era.
    /// </summary>
    abstract member year: float with get
    /// <summary>
    /// The month number within the year. Note that some calendar systems such as Hebrew
    /// may have a variable number of months per year. Therefore, month numbers may not
    /// always correspond to the same month names in different years.
    /// </summary>
    abstract member month: float with get
    /// <summary>
    /// The day number within the month.
    /// </summary>
    abstract member day: float with get
    /// <summary>
    /// The hour in the day, numbered from 0 to 23.
    /// </summary>
    abstract member hour: float with get
    /// <summary>
    /// The minute in the hour.
    /// </summary>
    abstract member minute: float with get
    /// <summary>
    /// The second in the minute.
    /// </summary>
    abstract member second: float with get
    /// <summary>
    /// The millisecond in the second.
    /// </summary>
    abstract member millisecond: float with get
    abstract member copy: unit -> CalendarDateTime
    abstract member add: duration: DateTimeDuration -> CalendarDateTime
    abstract member subtract: duration: DateTimeDuration -> CalendarDateTime
    abstract member set: fields: CalendarDateTime.set.fields -> CalendarDateTime
    abstract member cycle: field: U2<DateField, TimeField> * amount: float * ?options: CycleTimeOptions -> CalendarDateTime
    abstract member toDate: timeZone: string * ?disambiguation: Disambiguation -> JS.Date
    abstract member toString: unit -> string
    abstract member compare: b: U3<CalendarDate, CalendarDateTime, ZonedDateTime> -> float

[<AllowNullLiteral>]
[<Interface>]
type ZonedDateTime =
    /// <summary>
    /// The calendar system associated with this date, e.g. Gregorian.
    /// </summary>
    abstract member calendar: Calendar with get
    /// <summary>
    /// The calendar era for this date, e.g. "BC" or "AD".
    /// </summary>
    abstract member era: string with get
    /// <summary>
    /// The year of this date within the era.
    /// </summary>
    abstract member year: float with get
    /// <summary>
    /// The month number within the year. Note that some calendar systems such as Hebrew
    /// may have a variable number of months per year. Therefore, month numbers may not
    /// always correspond to the same month names in different years.
    /// </summary>
    abstract member month: float with get
    /// <summary>
    /// The day number within the month.
    /// </summary>
    abstract member day: float with get
    /// <summary>
    /// The hour in the day, numbered from 0 to 23.
    /// </summary>
    abstract member hour: float with get
    /// <summary>
    /// The minute in the hour.
    /// </summary>
    abstract member minute: float with get
    /// <summary>
    /// The second in the minute.
    /// </summary>
    abstract member second: float with get
    /// <summary>
    /// The millisecond in the second.
    /// </summary>
    abstract member millisecond: float with get
    /// <summary>
    /// The IANA time zone identifier that this date and time is represented in.
    /// </summary>
    abstract member timeZone: string with get
    /// <summary>
    /// The UTC offset for this time, in milliseconds.
    /// </summary>
    abstract member offset: float with get
    abstract member copy: unit -> ZonedDateTime
    abstract member add: duration: DateTimeDuration -> ZonedDateTime
    abstract member subtract: duration: DateTimeDuration -> ZonedDateTime
    abstract member set: fields: ZonedDateTime.set.fields * ?disambiguation: Disambiguation -> ZonedDateTime
    abstract member cycle: field: U2<DateField, TimeField> * amount: float * ?options: CycleTimeOptions -> ZonedDateTime
    abstract member toDate: unit -> JS.Date
    abstract member toString: unit -> string
    abstract member toAbsoluteString: unit -> string
    abstract member compare: b: U3<CalendarDate, CalendarDateTime, ZonedDateTime> -> float

[<AllowNullLiteral>]
[<Interface>]
type AnyCalendarDate =
    abstract member calendar: Calendar with get
    abstract member era: string with get
    abstract member year: float with get
    abstract member month: float with get
    abstract member day: float with get
    abstract member copy: unit -> AnyCalendarDate

[<AllowNullLiteral>]
[<Interface>]
type AnyTime =
    abstract member hour: float with get
    abstract member minute: float with get
    abstract member second: float with get
    abstract member millisecond: float with get
    abstract member copy: unit -> AnyTime

[<AllowNullLiteral>]
[<Interface>]
type AnyDateTime =
    inherit AnyCalendarDate
    inherit AnyTime

[<AllowNullLiteral>]
[<Interface>]
type Calendar =
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    /// <summary>
    /// Creates a CalendarDate in this calendar from the given Julian day number.
    /// </summary>
    abstract member fromJulianDay: jd: float -> CalendarDate
    /// <summary>
    /// Converts a date in this calendar to a Julian day number.
    /// </summary>
    abstract member toJulianDay: date: AnyCalendarDate -> float
    /// <summary>
    /// Returns the number of days in the month of the given date.
    /// </summary>
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    /// <summary>
    /// Returns the number of months in the year of the given date.
    /// </summary>
    abstract member getMonthsInYear: date: AnyCalendarDate -> float
    /// <summary>
    /// Returns the number of years in the era of the given date.
    /// </summary>
    abstract member getYearsInEra: date: AnyCalendarDate -> float
    /// <summary>
    /// Returns a list of era identifiers for the calendar.
    /// </summary>
    abstract member getEras: unit -> ResizeArray<string>
    /// <summary>
    /// Returns the minimum month number of the given date's year.
    /// Normally, this is 1, but in some calendars such as the Japanese,
    /// eras may begin in the middle of a year.
    /// </summary>
    abstract member getMinimumMonthInYear: date: AnyCalendarDate -> float
    /// <summary>
    /// Returns the minimum day number of the given date's month.
    /// Normally, this is 1, but in some calendars such as the Japanese,
    /// eras may begin in the middle of a month.
    /// </summary>
    abstract member getMinimumDayInMonth: date: AnyCalendarDate -> float
    abstract member balanceDate: date: AnyCalendarDate -> unit
    abstract member balanceYearMonth: date: AnyCalendarDate * previousDate: AnyCalendarDate -> unit
    abstract member constrainDate: date: AnyCalendarDate -> unit
    abstract member isInverseEra: date: AnyCalendarDate -> bool

[<AllowNullLiteral>]
[<Interface>]
type DateDuration =
    /// <summary>
    /// The number of years to add or subtract.
    /// </summary>
    abstract member years: float option with get, set
    /// <summary>
    /// The number of months to add or subtract.
    /// </summary>
    abstract member months: float option with get, set
    /// <summary>
    /// The number of weeks to add or subtract.
    /// </summary>
    abstract member weeks: float option with get, set
    /// <summary>
    /// The number of days to add or subtract.
    /// </summary>
    abstract member days: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type TimeDuration =
    /// <summary>
    /// The number of hours to add or subtract.
    /// </summary>
    abstract member hours: float option with get, set
    /// <summary>
    /// The number of minutes to add or subtract.
    /// </summary>
    abstract member minutes: float option with get, set
    /// <summary>
    /// The number of seconds to add or subtract.
    /// </summary>
    abstract member seconds: float option with get, set
    /// <summary>
    /// The number of milliseconds to add or subtract.
    /// </summary>
    abstract member milliseconds: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DateTimeDuration =
    inherit DateDuration
    inherit TimeDuration

[<AllowNullLiteral>]
[<Interface>]
type DateFields =
    abstract member era: string option with get, set
    abstract member year: float option with get, set
    abstract member month: float option with get, set
    abstract member day: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type TimeFields =
    abstract member hour: float option with get, set
    abstract member minute: float option with get, set
    abstract member second: float option with get, set
    abstract member millisecond: float option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DateField =
    | era
    | year
    | month
    | day

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TimeField =
    | hour
    | minute
    | second
    | millisecond

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Disambiguation =
    | compatible
    | earlier
    | later
    | reject

[<AllowNullLiteral>]
[<Interface>]
type CycleOptions =
    /// <summary>
    /// Whether to round the field value to the nearest interval of the amount.
    /// </summary>
    abstract member round: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type CycleTimeOptions =
    inherit CycleOptions
    /// <summary>
    /// Whether to use 12 or 24 hour time. If 12 hour time is chosen, the resulting value
    /// will remain in the same day period as the original value (e.g. if the value is AM,
    /// the resulting value also be AM).
    /// </summary>
    abstract member hourCycle: CycleTimeOptions.hourCycle option with get, set

[<AllowNullLiteral>]
[<Interface>]
type JapaneseCalendar =
    inherit GregorianCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member balanceDate: date: Mutable<AnyCalendarDate> -> unit
    abstract member constrainDate: date: Mutable<AnyCalendarDate> -> unit
    abstract member getEras: unit -> ResizeArray<string>
    abstract member getYearsInEra: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getMinimumMonthInYear: date: AnyCalendarDate -> float
    abstract member getMinimumDayInMonth: date: AnyCalendarDate -> float

[<AllowNullLiteral>]
[<Interface>]
type BuddhistCalendar =
    inherit GregorianCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getEras: unit -> ResizeArray<string>
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member balanceDate: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type TaiwanCalendar =
    inherit GregorianCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getEras: unit -> ResizeArray<string>
    abstract member balanceDate: date: Mutable<AnyCalendarDate> -> unit
    abstract member isInverseEra: date: AnyCalendarDate -> bool
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getYearsInEra: date: AnyCalendarDate -> float

[<AllowNullLiteral>]
[<Interface>]
type PersianCalendar =
    inherit Calendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getMonthsInYear: unit -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getEras: unit -> ResizeArray<string>
    abstract member getYearsInEra: unit -> float

[<AllowNullLiteral>]
[<Interface>]
type IndianCalendar =
    inherit GregorianCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getYearsInEra: unit -> float
    abstract member getEras: unit -> ResizeArray<string>
    abstract member balanceDate: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type IslamicCivilCalendar =
    inherit Calendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getMonthsInYear: unit -> float
    abstract member getDaysInYear: date: AnyCalendarDate -> float
    abstract member getYearsInEra: unit -> float
    abstract member getEras: unit -> ResizeArray<string>

[<AllowNullLiteral>]
[<Interface>]
type IslamicTabularCalendar =
    inherit IslamicCivilCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float

[<AllowNullLiteral>]
[<Interface>]
type IslamicUmalquraCalendar =
    inherit IslamicCivilCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getDaysInYear: date: AnyCalendarDate -> float

[<AllowNullLiteral>]
[<Interface>]
type HebrewCalendar =
    inherit Calendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getMonthsInYear: date: AnyCalendarDate -> float
    abstract member getDaysInYear: date: AnyCalendarDate -> float
    abstract member getYearsInEra: unit -> float
    abstract member getEras: unit -> ResizeArray<string>
    abstract member balanceYearMonth: date: Mutable<AnyCalendarDate> * previousDate: AnyCalendarDate -> unit

[<AllowNullLiteral>]
[<Interface>]
type EthiopicCalendar =
    inherit Calendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member getMonthsInYear: unit -> float
    abstract member getDaysInYear: date: AnyCalendarDate -> float
    abstract member getYearsInEra: date: AnyCalendarDate -> float
    abstract member getEras: unit -> ResizeArray<string>

[<AllowNullLiteral>]
[<Interface>]
type EthiopicAmeteAlemCalendar =
    inherit EthiopicCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member getEras: unit -> ResizeArray<string>
    abstract member getYearsInEra: unit -> float

[<AllowNullLiteral>]
[<Interface>]
type CopticCalendar =
    inherit EthiopicCalendar
    /// <summary>
    /// A string identifier for the calendar, as defined by Unicode CLDR.
    /// </summary>
    abstract member identifier: string with get, set
    abstract member fromJulianDay: jd: float -> CalendarDate
    abstract member toJulianDay: date: AnyCalendarDate -> float
    abstract member getDaysInMonth: date: AnyCalendarDate -> float
    abstract member isInverseEra: date: AnyCalendarDate -> bool
    abstract member balanceDate: date: Mutable<AnyCalendarDate> -> unit
    abstract member getEras: unit -> ResizeArray<string>
    abstract member getYearsInEra: date: AnyCalendarDate -> float

[<AllowNullLiteral>]
[<Interface>]
type DateRangeFormatPart =
    // inherit Intl.DateTimeFormatPart
    abstract member source: DateRangeFormatPart.source with get, set

[<AllowNullLiteral>]
[<Interface>]
type DateFormatter =
    inherit Intl.DateTimeFormat
    abstract member format: value: JS.Date -> string
    // abstract member formatToParts: value: JS.Date -> ResizeArray<Intl.DateTimeFormatPart>
    abstract member formatRange: start: JS.Date * ``end``: JS.Date -> string
    abstract member formatRangeToParts: start: JS.Date * ``end``: JS.Date -> ResizeArray<DateRangeFormatPart>
    abstract member resolvedOptions: unit -> Intl.ResolvedDateTimeFormatOptions

module CalendarDateTime =

    module set =

        [<AllowNullLiteral>]
        [<Interface>]
        type fields =
            abstract member era: string option with get, set
            abstract member year: float option with get, set
            abstract member month: float option with get, set
            abstract member day: float option with get, set
            abstract member hour: float option with get, set
            abstract member minute: float option with get, set
            abstract member second: float option with get, set
            abstract member millisecond: float option with get, set

module ZonedDateTime =

    module set =

        [<AllowNullLiteral>]
        [<Interface>]
        type fields =
            abstract member era: string option with get, set
            abstract member year: float option with get, set
            abstract member month: float option with get, set
            abstract member day: float option with get, set
            abstract member hour: float option with get, set
            abstract member minute: float option with get, set
            abstract member second: float option with get, set
            abstract member millisecond: float option with get, set

module CycleTimeOptions =

    [<RequireQualifiedAccess>]
    type hourCycle =
        | ``12`` = 12
        | ``24`` = 24

module DateRangeFormatPart =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type source =
        | startRange
        | endRange
        | shared
