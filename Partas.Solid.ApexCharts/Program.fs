namespace rec Partas.Solid.ApexCharts

open Fable.Core
open Fable.Core.JsInterop
open System

[<AbstractClass>]
[<Erase>]
type Exports =
    [<Import("ApexCharts", "apexcharts"); EmitConstructor>]
    static member ApexCharts (el: obj, options: obj) : ApexCharts = nativeOnly

[<AllowNullLiteral>]
[<Interface>]
type ApexCharts =
    abstract member render: unit -> JS.Promise<unit>
    abstract member updateOptions: options: obj * ?redrawPaths: bool * ?animate: bool * ?updateSyncedCharts: bool -> JS.Promise<unit>
    abstract member updateSeries: newSeries: U2<ApexAxisChartSeries, ApexNonAxisChartSeries> * ?animate: bool -> JS.Promise<unit>
    abstract member appendSeries: newSeries: U2<ApexAxisChartSeries, ApexNonAxisChartSeries> * ?animate: bool -> JS.Promise<unit>
    abstract member appendData: data: array<obj> * ?overwriteInitialSeries: bool -> unit
    abstract member toggleSeries: seriesName: string -> obj
    abstract member highlightSeries: seriesName: string -> obj
    abstract member showSeries: seriesName: string -> unit
    abstract member hideSeries: seriesName: string -> unit
    abstract member resetSeries: unit -> unit
    abstract member zoomX: min: float * max: float -> unit
    abstract member toggleDataPointSelection: seriesIndex: float * ?dataPointIndex: float -> obj
    abstract member destroy: unit -> unit
    abstract member setLocale: localeName: string -> unit
    abstract member paper: unit -> unit
    abstract member addXaxisAnnotation: options: obj * ?pushToMemory: bool * ?context: obj -> unit
    abstract member addYaxisAnnotation: options: obj * ?pushToMemory: bool * ?context: obj -> unit
    abstract member addPointAnnotation: options: obj * ?pushToMemory: bool * ?context: obj -> unit
    abstract member removeAnnotation: id: string * ?options: obj -> unit
    abstract member clearAnnotations: ?options: obj -> unit
    abstract member dataURI: ?options: ApexCharts.dataURI.options -> JS.Promise<ApexCharts.dataURI>
    static member inline exec (chartID: string, fn: string, [<ParamArray>] args: array<obj> []): obj =
        emitJsExpr (chartID, fn, args) $$"""
import { ApexCharts } from "apexcharts";
ApexCharts.exec($0, $1, $2)"""
    static member inline getChartByID (chartID: string): ApexCharts  =
        emitJsExpr (chartID) $$"""
import { ApexCharts } from "apexcharts";
ApexCharts.getChartByID($0)"""
    static member inline initOnLoad () : unit =
        emitJsExpr () $$"""
import { ApexCharts } from "apexcharts";
ApexCharts.initOnLoad()"""
    abstract member exports: ApexCharts.exports with get, set

module ApexCharts =

    [<AllowNullLiteral>]
    [<Interface>]
    type ApexOptions =
        abstract member annotations: ApexAnnotations  with get, set
        abstract member chart: ApexChart  with get, set
        abstract member colors: array<obj>  with get, set
        abstract member dataLabels: ApexDataLabels  with get, set
        abstract member fill: ApexFill  with get, set
        abstract member forecastDataPoints: ApexForecastDataPoints  with get, set
        abstract member grid: ApexGrid  with get, set
        abstract member labels: array<string>  with get, set
        abstract member legend: ApexLegend  with get, set
        abstract member markers: ApexMarkers  with get, set
        abstract member noData: ApexNoData  with get, set
        abstract member plotOptions: ApexPlotOptions  with get, set
        abstract member responsive: array<ApexResponsive>  with get, set
        abstract member series: U2<ApexAxisChartSeries, ApexNonAxisChartSeries>  with get, set
        abstract member states: ApexStates  with get, set
        abstract member stroke: ApexStroke  with get, set
        abstract member subtitle: ApexTitleSubtitle  with get, set
        abstract member theme: ApexTheme  with get, set
        abstract member title: ApexTitleSubtitle  with get, set
        abstract member tooltip: ApexTooltip  with get, set
        abstract member xaxis: ApexXAxis  with get, set
        abstract member yaxis: U2<ApexYAxis, array<ApexYAxis>>  with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type dataURI =
        abstract member imgURI: string with get, set
        abstract member blob: obj with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type exports
        [<ParamObject; Emit("$0")>]
        (
            cleanup: string,
            svgUrl: string,
            dataURI: JS.Promise<ApexCharts.exports.dataURI>,
            exportToSVG: unit,
            exportToPng: unit,
            exportToCSV: unit,
            getSvgString: unit,
            triggerDownload: unit
        ) =

        member val cleanup : string = nativeOnly with get, set
        member val svgUrl : string = nativeOnly with get, set
        member val dataURI : JS.Promise<ApexCharts.exports.dataURI> = nativeOnly with get, set
        member val exportToSVG : unit = nativeOnly with get, set
        member val exportToPng : unit = nativeOnly with get, set
        member val exportToCSV : unit = nativeOnly with get, set
        member val getSvgString : unit = nativeOnly with get, set
        member val triggerDownload : unit = nativeOnly with get, set

    module dataURI =

        [<Global>]
        [<AllowNullLiteral>]
        type options
            [<ParamObject; Emit("$0")>]
            (
                ?scale: float,
                ?width: float
            ) =

            member val scale : float  = nativeOnly with get, set
            member val width : float  = nativeOnly with get, set

    module exports =

        [<AllowNullLiteral>]
        [<Interface>]
        type dataURI =
            abstract member imgURI: string with get, set
            abstract member blob: obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexDropShadow =
    abstract member enabled: bool  with get, set
    abstract member top: float  with get, set
    abstract member left: float  with get, set
    abstract member blur: float  with get, set
    abstract member opacity: float  with get, set
    abstract member color: string  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexChart =
    abstract member width: U2<string, float>  with get, set
    abstract member height: U2<string, float>  with get, set
    abstract member ``type``: ApexChart.``type``  with get, set
    abstract member foreColor: string  with get, set
    abstract member fontFamily: string  with get, set
    abstract member background: string  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member dropShadow: obj  with get, set
    abstract member events: ApexChart.events  with get, set
    abstract member brush: ApexChart.brush  with get, set
    abstract member id: string  with get, set
    abstract member group: string  with get, set
    abstract member locales: array<ApexLocale>  with get, set
    abstract member defaultLocale: string  with get, set
    abstract member parentHeightOffset: float  with get, set
    abstract member redrawOnParentResize: bool  with get, set
    abstract member redrawOnWindowResize: U2<bool, Action>  with get, set
    abstract member sparkline: ApexChart.sparkline  with get, set
    abstract member stacked: bool  with get, set
    abstract member stackType: ApexChart.stackType  with get, set
    abstract member stackOnlyBar: bool  with get, set
    abstract member toolbar: ApexChart.toolbar  with get, set
    abstract member zoom: ApexChart.zoom  with get, set
    abstract member selection: ApexChart.selection  with get, set
    abstract member animations: ApexChart.animations  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexStates =
    abstract member hover: ApexStates.hover  with get, set
    abstract member active: ApexStates.active  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexTitleSubtitle =
    abstract member text: string  with get, set
    abstract member align: ApexTitleSubtitle.align  with get, set
    abstract member margin: float  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member floating: bool  with get, set
    abstract member style: ApexTitleSubtitle.style  with get, set

/// <summary>
/// Chart Series options.
/// Use ApexNonAxisChartSeries for Pie and Donut charts.
/// See https://apexcharts.com/docs/options/series/
///
/// According to the documentation at
/// https://apexcharts.com/docs/series/
/// Section 1: data can be a list of single numbers
/// Sections 2.1 and 3.1: data can be a list of tuples of two numbers
/// Sections 2.2 and 3.2: data can be a list of objects where x is a string
/// and y is a number
/// And according to the demos, data can contain null.
/// https://apexcharts.com/javascript-chart-demos/line-charts/null-values/
/// </summary>

type ApexNonAxisChartSeries =
    array<float>

[<AllowNullLiteral>]
[<Interface>]
type ApexStroke =
    abstract member show: bool  with get, set
    abstract member curve: ApexStroke.curve  with get, set
    abstract member lineCap: ApexStroke.lineCap  with get, set
    abstract member colors: U2<array<obj>, array<string>>  with get, set
    abstract member width: U2<float, array<float>>  with get, set
    abstract member dashArray: U2<float, array<float>>  with get, set
    abstract member fill: ApexFill  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexAnnotations =
    abstract member yaxis: array<YAxisAnnotations>  with get, set
    abstract member xaxis: array<XAxisAnnotations>  with get, set
    abstract member points: array<PointAnnotations>  with get, set
    abstract member texts: array<TextAnnotations>  with get, set
    abstract member images: array<ImageAnnotations>  with get, set

[<AllowNullLiteral>]
[<Interface>]
type AnnotationLabel =
    abstract member borderColor: string  with get, set
    abstract member borderWidth: float  with get, set
    abstract member borderRadius: float  with get, set
    abstract member text: string  with get, set
    abstract member textAnchor: string  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member style: AnnotationStyle  with get, set
    abstract member position: string  with get, set
    abstract member orientation: string  with get, set
    abstract member mouseEnter: Action  with get, set
    abstract member mouseLeave: Action  with get, set
    abstract member click: Action  with get, set

[<AllowNullLiteral>]
[<Interface>]
type AnnotationStyle =
    abstract member background: string  with get, set
    abstract member color: string  with get, set
    abstract member fontFamily: string  with get, set
    abstract member fontWeight: U2<string, float>  with get, set
    abstract member fontSize: string  with get, set
    abstract member cssClass: string  with get, set
    abstract member padding: AnnotationStyle.padding  with get, set

[<AllowNullLiteral>]
[<Interface>]
type XAxisAnnotations =
    abstract member id: U2<float, string>  with get, set
    abstract member x: U2<float, string>   with get, set
    abstract member x2: U2<float, string>   with get, set
    abstract member strokeDashArray: float  with get, set
    abstract member fillColor: string  with get, set
    abstract member borderColor: string  with get, set
    abstract member borderWidth: float  with get, set
    abstract member opacity: float  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member label: AnnotationLabel  with get, set

[<AllowNullLiteral>]
[<Interface>]
type YAxisAnnotations =
    abstract member id: U2<float, string>  with get, set
    abstract member y: U2<float, string>   with get, set
    abstract member y2: U2<float, string>   with get, set
    abstract member strokeDashArray: float  with get, set
    abstract member fillColor: string  with get, set
    abstract member borderColor: string  with get, set
    abstract member borderWidth: float  with get, set
    abstract member opacity: float  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member width: U2<float, string>  with get, set
    abstract member yAxisIndex: float  with get, set
    abstract member label: AnnotationLabel  with get, set

[<AllowNullLiteral>]
[<Interface>]
type PointAnnotations =
    abstract member id: U2<float, string>  with get, set
    abstract member x: U2<float, string>  with get, set
    abstract member y: float  with get, set
    abstract member yAxisIndex: float  with get, set
    abstract member seriesIndex: float  with get, set
    abstract member mouseEnter: Action  with get, set
    abstract member mouseLeave: Action  with get, set
    abstract member click: Action  with get, set
    abstract member marker: PointAnnotations.marker  with get, set
    abstract member label: AnnotationLabel  with get, set
    abstract member image: PointAnnotations.image  with get, set

[<AllowNullLiteral>]
[<Interface>]
type TextAnnotations =
    abstract member x: float  with get, set
    abstract member y: float  with get, set
    abstract member text: string  with get, set
    abstract member textAnchor: string  with get, set
    abstract member foreColor: string  with get, set
    abstract member fontSize: U2<string, float>  with get, set
    abstract member fontFamily: string  with get, set
    abstract member fontWeight: U2<string, float>  with get, set
    abstract member backgroundColor: string  with get, set
    abstract member borderColor: string  with get, set
    abstract member borderRadius: float  with get, set
    abstract member borderWidth: float  with get, set
    abstract member paddingLeft: float  with get, set
    abstract member paddingRight: float  with get, set
    abstract member paddingTop: float  with get, set
    abstract member paddingBottom: float  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageAnnotations =
    abstract member path: string  with get, set
    abstract member x: float  with get, set
    abstract member y: float  with get, set
    abstract member width: float  with get, set
    abstract member height: float  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexLocale =
    abstract member name: string  with get, set
    abstract member options: ApexLocale.options  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexPlotOptions =
    abstract member line: ApexPlotOptions.line  with get, set
    abstract member area: ApexPlotOptions.area  with get, set
    abstract member bar: ApexPlotOptions.bar  with get, set
    abstract member bubble: ApexPlotOptions.bubble  with get, set
    abstract member candlestick: ApexPlotOptions.candlestick  with get, set
    abstract member boxPlot: ApexPlotOptions.boxPlot  with get, set
    abstract member heatmap: ApexPlotOptions.heatmap  with get, set
    abstract member treemap: ApexPlotOptions.treemap  with get, set
    abstract member pie: ApexPlotOptions.pie  with get, set
    abstract member polarArea: ApexPlotOptions.polarArea  with get, set
    abstract member radar: ApexPlotOptions.radar  with get, set
    abstract member radialBar: ApexPlotOptions.radialBar  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexColorStop =
    abstract member offset: float with get, set
    abstract member color: string with get, set
    abstract member opacity: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexFill =
    abstract member colors: array<obj>  with get, set
    abstract member opacity: U2<float, array<float>>  with get, set
    abstract member ``type``: U2<string, array<string>>  with get, set
    abstract member gradient: ApexFill.gradient  with get, set
    abstract member image: ApexFill.image  with get, set
    abstract member pattern: ApexFill.pattern  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexLegend =
    abstract member show: bool  with get, set
    abstract member showForSingleSeries: bool  with get, set
    abstract member showForNullSeries: bool  with get, set
    abstract member showForZeroSeries: bool  with get, set
    abstract member floating: bool  with get, set
    abstract member inverseOrder: bool  with get, set
    abstract member position: ApexLegend.position  with get, set
    abstract member horizontalAlign: ApexLegend.horizontalAlign  with get, set
    abstract member fontSize: string  with get, set
    abstract member fontFamily: string  with get, set
    abstract member fontWeight: U2<string, float>  with get, set
    abstract member width: float  with get, set
    abstract member height: float  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member formatter: legendName: string * ?opts: obj -> string
    abstract member tooltipHoverFormatter: legendName: string * ?opts: obj -> string
    abstract member customLegendItems: array<string>  with get, set
    abstract member clusterGroupedSeries: bool  with get, set
    abstract member clusterGroupedSeriesOrientation: string  with get, set
    abstract member labels: ApexLegend.labels  with get, set
    abstract member markers: ApexLegend.markers  with get, set
    abstract member itemMargin: ApexLegend.itemMargin  with get, set
    abstract member onItemClick: ApexLegend.onItemClick  with get, set
    abstract member onItemHover: ApexLegend.onItemHover  with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MarkerShapeOptions =
    | circle
    | square
    | rect
    | line
    | cross
    | plus
    | star
    | sparkle
    | diamond
    | triangle

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ApexMarkerShape =
    | circle
    | square
    | rect
    | line
    | cross
    | plus
    | star
    | sparkle
    | diamond
    | triangle

[<AllowNullLiteral>]
[<Interface>]
type ApexDiscretePoint =
    abstract member seriesIndex: float  with get, set
    abstract member dataPointIndex: float  with get, set
    abstract member fillColor: string  with get, set
    abstract member strokeColor: string  with get, set
    abstract member size: float  with get, set
    abstract member shape: ApexMarkerShape  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexMarkers =
    abstract member size: U2<float, array<float>>  with get, set
    abstract member colors: U2<string, array<string>>  with get, set
    abstract member strokeColors: U2<string, array<string>>  with get, set
    abstract member strokeWidth: U2<float, array<float>>  with get, set
    abstract member strokeOpacity: U2<float, array<float>>  with get, set
    abstract member strokeDashArray: U2<float, array<float>>  with get, set
    abstract member fillOpacity: U2<float, array<float>>  with get, set
    abstract member discrete: array<ApexDiscretePoint>  with get, set
    abstract member shape: ApexMarkerShape  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member showNullDataPoints: bool  with get, set
    abstract member onClick: ?e: obj -> unit
    abstract member onDblClick: ?e: obj -> unit
    abstract member hover: ApexMarkers.hover  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexNoData =
    abstract member text: string  with get, set
    abstract member align: ApexNoData.align  with get, set
    abstract member verticalAlign: ApexNoData.verticalAlign  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member style: ApexNoData.style  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexDataLabels =
    abstract member enabled: bool  with get, set
    abstract member enabledOnSeries: array<float>  with get, set
    abstract member textAnchor: ApexDataLabels.textAnchor  with get, set
    abstract member distributed: bool  with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member style: ApexDataLabels.style  with get, set
    abstract member background: ApexDataLabels.background  with get, set
    abstract member dropShadow: ApexDropShadow  with get, set
    abstract member formatter: ``val``: U3<string, float, array<float>> * ?opts: obj -> U3<string, float, array<U2<string, string>>>

[<AllowNullLiteral>]
[<Interface>]
type ApexResponsive =
    abstract member breakpoint: float  with get, set
    abstract member options: obj  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexTooltipY =
    abstract member title: ApexTooltipY.title  with get, set
    abstract member formatter: ``val``: float * ?opts: obj -> string

[<AllowNullLiteral>]
[<Interface>]
type ApexTooltip =
    abstract member enabled: bool  with get, set
    abstract member enabledOnSeries: array<float>  with get, set
    abstract member shared: bool  with get, set
    abstract member followCursor: bool  with get, set
    abstract member intersect: bool  with get, set
    abstract member inverseOrder: bool  with get, set
    abstract member custom: U2<(obj -> obj), array<(obj -> obj)>>  with get, set
    abstract member fillSeriesColor: bool  with get, set
    abstract member theme: string  with get, set
    abstract member cssClass: string  with get, set
    abstract member hideEmptySeries: bool  with get, set
    abstract member style: ApexTooltip.style  with get, set
    abstract member onDatasetHover: ApexTooltip.onDatasetHover  with get, set
    abstract member x: ApexTooltip.x  with get, set
    abstract member y: U2<ApexTooltipY, array<ApexTooltipY>>  with get, set
    abstract member z: ApexTooltip.z  with get, set
    abstract member marker: ApexTooltip.marker  with get, set
    abstract member items: ApexTooltip.items  with get, set
    abstract member ``fixed``: ApexTooltip.``fixed``  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexXAxis =
    abstract member ``type``: ApexXAxis.``type``  with get, set
    abstract member categories: obj  with get, set
    abstract member overwriteCategories: U2<array<float>, array<string>>   with get, set
    abstract member offsetX: float  with get, set
    abstract member offsetY: float  with get, set
    abstract member sorted: bool  with get, set
    abstract member labels: ApexXAxis.labels  with get, set
    abstract member group: ApexXAxis.group  with get, set
    abstract member axisBorder: ApexXAxis.axisBorder  with get, set
    abstract member axisTicks: ApexXAxis.axisTicks  with get, set
    abstract member tickPlacement: string  with get, set
    abstract member tickAmount: ApexXAxis.tickAmount  with get, set
    abstract member stepSize: float  with get, set
    abstract member min: float  with get, set
    abstract member max: float  with get, set
    abstract member range: float  with get, set
    abstract member floating: bool  with get, set
    abstract member decimalsInFloat: float  with get, set
    abstract member position: string  with get, set
    abstract member title: ApexXAxis.title  with get, set
    abstract member crosshairs: ApexXAxis.crosshairs  with get, set
    abstract member tooltip: ApexXAxis.tooltip  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexYAxis =
    abstract member show: bool  with get, set
    abstract member showAlways: bool  with get, set
    abstract member showForNullSeries: bool  with get, set
    abstract member seriesName: U2<string, array<string>>  with get, set
    abstract member opposite: bool  with get, set
    abstract member reversed: bool  with get, set
    abstract member logarithmic: bool  with get, set
    abstract member logBase: float  with get, set
    abstract member tickAmount: float  with get, set
    abstract member stepSize: float  with get, set
    abstract member forceNiceScale: bool  with get, set
    abstract member min: U2<float, (float -> float)>  with get, set
    abstract member max: U2<float, (float -> float)>  with get, set
    abstract member floating: bool  with get, set
    abstract member decimalsInFloat: float  with get, set
    abstract member labels: ApexYAxis.labels  with get, set
    abstract member axisBorder: ApexYAxis.axisBorder  with get, set
    abstract member axisTicks: ApexYAxis.axisTicks  with get, set
    abstract member title: ApexYAxis.title  with get, set
    abstract member crosshairs: ApexYAxis.crosshairs  with get, set
    abstract member tooltip: ApexYAxis.tooltip  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexForecastDataPoints =
    abstract member count: float  with get, set
    abstract member fillOpacity: float  with get, set
    abstract member strokeWidth: float  with get, set
    abstract member dashArray: float  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexGrid =
    abstract member show: bool  with get, set
    abstract member borderColor: string  with get, set
    abstract member strokeDashArray: float  with get, set
    abstract member position: ApexGrid.position  with get, set
    abstract member xaxis: ApexGrid.xaxis  with get, set
    abstract member yaxis: ApexGrid.yaxis  with get, set
    abstract member row: ApexGrid.row  with get, set
    abstract member column: ApexGrid.column  with get, set
    abstract member padding: ApexGrid.padding  with get, set

[<AllowNullLiteral>]
[<Interface>]
type ApexTheme =
    abstract member mode: ApexTheme.mode  with get, set
    abstract member palette: string  with get, set
    abstract member monochrome: ApexTheme.monochrome  with get, set

// module apexcharts =


[<Global>]
[<AllowNullLiteral>]
type ApexAxisChartSeries
    [<ParamObject; Emit("$0")>]
    (
        data: U5<array<float >, array<ApexAxisChartSeries.data.U5.Case2>, array<float * float >, array<float * array<float >>, array<array<float>>>,
        ?name: string,
        ?``type``: string,
        ?color: string,
        ?group: string,
        ?hidden: bool,
        ?zIndex: float
    ) =

    member val data : U5<array<float >, array<ApexAxisChartSeries.data.U5.Case2>, array<float * float >, array<float * array<float >>, array<array<float>>> = nativeOnly with get, set
    member val name : string  = nativeOnly with get, set
    member val ``type`` : string  = nativeOnly with get, set
    member val color : string  = nativeOnly with get, set
    member val group : string  = nativeOnly with get, set
    member val hidden : bool  = nativeOnly with get, set
    member val zIndex : float  = nativeOnly with get, set

module ApexChart =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | line
        | area
        | bar
        | pie
        | donut
        | radialBar
        | scatter
        | bubble
        | heatmap
        | candlestick
        | boxPlot
        | radar
        | polarArea
        | rangeBar
        | rangeArea
        | treemap

    [<Global>]
    [<AllowNullLiteral>]
    type events
        [<ParamObject; Emit("$0")>]
        (
            animationEnd: unit,
            beforeMount: unit,
            mounted: unit,
            updated: unit,
            mouseMove: unit,
            mouseLeave: unit,
            click: unit,
            xAxisLabelClick: unit,
            legendClick: unit,
            markerClick: unit,
            selection: unit,
            dataPointSelection: unit,
            dataPointMouseEnter: unit,
            dataPointMouseLeave: unit,
            beforeZoom: unit,
            beforeResetZoom: unit,
            zoomed: unit,
            scrolled: unit,
            brushScrolled: unit
        ) =

        member val animationEnd : unit = nativeOnly with get, set
        member val beforeMount : unit = nativeOnly with get, set
        member val mounted : unit = nativeOnly with get, set
        member val updated : unit = nativeOnly with get, set
        member val mouseMove : unit = nativeOnly with get, set
        member val mouseLeave : unit = nativeOnly with get, set
        member val click : unit = nativeOnly with get, set
        member val xAxisLabelClick : unit = nativeOnly with get, set
        member val legendClick : unit = nativeOnly with get, set
        member val markerClick : unit = nativeOnly with get, set
        member val selection : unit = nativeOnly with get, set
        member val dataPointSelection : unit = nativeOnly with get, set
        member val dataPointMouseEnter : unit = nativeOnly with get, set
        member val dataPointMouseLeave : unit = nativeOnly with get, set
        member val beforeZoom : unit = nativeOnly with get, set
        member val beforeResetZoom : unit = nativeOnly with get, set
        member val zoomed : unit = nativeOnly with get, set
        member val scrolled : unit = nativeOnly with get, set
        member val brushScrolled : unit = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type brush
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?autoScaleYaxis: bool,
            ?target: string,
            ?targets: array<string>
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val autoScaleYaxis : bool  = nativeOnly with get, set
        member val target : string  = nativeOnly with get, set
        member val targets : array<string>  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type sparkline
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool
        ) =

        member val enabled : bool  = nativeOnly with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type stackType =
        | normal
        | ``100%``

    [<Global>]
    [<AllowNullLiteral>]
    type toolbar
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?offsetX: float,
            ?offsetY: float,
            ?tools: ApexChart.toolbar.tools,
            ?export: ApexChart.toolbar.export,
            ?autoSelected: ApexChart.toolbar.autoSelected
        ) =

        member val show : bool  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val tools : ApexChart.toolbar.tools  = nativeOnly with get, set
        member val export : ApexChart.toolbar.export  = nativeOnly with get, set
        member val autoSelected : ApexChart.toolbar.autoSelected  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type zoom
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?``type``: ApexChart.zoom.``type``,
            ?autoScaleYaxis: bool,
            ?allowMouseWheelZoom: bool,
            ?zoomedArea: ApexChart.zoom.zoomedArea
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val ``type`` : ApexChart.zoom.``type``  = nativeOnly with get, set
        member val autoScaleYaxis : bool  = nativeOnly with get, set
        member val allowMouseWheelZoom : bool  = nativeOnly with get, set
        member val zoomedArea : ApexChart.zoom.zoomedArea  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type selection
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?``type``: string,
            ?fill: ApexChart.selection.fill,
            ?stroke: ApexChart.selection.stroke,
            ?xaxis: ApexChart.selection.xaxis,
            ?yaxis: ApexChart.selection.yaxis
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val ``type`` : string  = nativeOnly with get, set
        member val fill : ApexChart.selection.fill  = nativeOnly with get, set
        member val stroke : ApexChart.selection.stroke  = nativeOnly with get, set
        member val xaxis : ApexChart.selection.xaxis  = nativeOnly with get, set
        member val yaxis : ApexChart.selection.yaxis  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type animations
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?speed: float,
            ?animateGradually: ApexChart.animations.animateGradually,
            ?dynamicAnimation: ApexChart.animations.dynamicAnimation
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val speed : float  = nativeOnly with get, set
        member val animateGradually : ApexChart.animations.animateGradually  = nativeOnly with get, set
        member val dynamicAnimation : ApexChart.animations.dynamicAnimation  = nativeOnly with get, set

    module toolbar =

        [<Global>]
        [<AllowNullLiteral>]
        type tools
            [<ParamObject; Emit("$0")>]
            (
                ?download: U2<bool, string>,
                ?selection: U2<bool, string>,
                ?zoom: U2<bool, string>,
                ?zoomin: U2<bool, string>,
                ?zoomout: U2<bool, string>,
                ?pan: U2<bool, string>,
                ?reset: U2<bool, string>,
                ?customIcons: array<ApexChart.toolbar.tools.customIcons>
            ) =

            member val download : U2<bool, string>  = nativeOnly with get, set
            member val selection : U2<bool, string>  = nativeOnly with get, set
            member val zoom : U2<bool, string>  = nativeOnly with get, set
            member val zoomin : U2<bool, string>  = nativeOnly with get, set
            member val zoomout : U2<bool, string>  = nativeOnly with get, set
            member val pan : U2<bool, string>  = nativeOnly with get, set
            member val reset : U2<bool, string>  = nativeOnly with get, set
            member val customIcons : array<ApexChart.toolbar.tools.customIcons>  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type export
            [<ParamObject; Emit("$0")>]
            (
                ?csv: ApexChart.toolbar.export.csv,
                ?svg: ApexChart.toolbar.export.svg,
                ?png: ApexChart.toolbar.export.png,
                ?width: float,
                ?scale: float
            ) =

            member val csv : ApexChart.toolbar.export.csv  = nativeOnly with get, set
            member val svg : ApexChart.toolbar.export.svg  = nativeOnly with get, set
            member val png : ApexChart.toolbar.export.png  = nativeOnly with get, set
            member val width : float  = nativeOnly with get, set
            member val scale : float  = nativeOnly with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type autoSelected =
            | zoom
            | selection
            | pan

        module tools =

            [<Global>]
            [<AllowNullLiteral>]
            type customIcons
                [<ParamObject; Emit("$0")>]
                (
                    click: obj,
                    ?icon: string,
                    ?title: string,
                    ?index: float,
                    ?``class``: string
                ) =

                member val click : obj = nativeOnly with get, set
                member val icon : string  = nativeOnly with get, set
                member val title : string  = nativeOnly with get, set
                member val index : float  = nativeOnly with get, set
                member val ``class`` : string  = nativeOnly with get, set

        module export =

            [<Global>]
            [<AllowNullLiteral>]
            type csv
                [<ParamObject; Emit("$0")>]
                (
                    categoryFormatter: obj,
                    valueFormatter: obj,
                    ?filename: string,
                    ?columnDelimiter: string,
                    ?headerCategory: string,
                    ?headerValue: string
                ) =

                member val categoryFormatter : obj = nativeOnly with get, set
                member val valueFormatter : obj = nativeOnly with get, set
                member val filename : string  = nativeOnly with get, set
                member val columnDelimiter : string  = nativeOnly with get, set
                member val headerCategory : string  = nativeOnly with get, set
                member val headerValue : string  = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type svg
                [<ParamObject; Emit("$0")>]
                (
                    ?filename: string
                ) =

                member val filename : string  = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type png
                [<ParamObject; Emit("$0")>]
                (
                    ?filename: string
                ) =

                member val filename : string  = nativeOnly with get, set

    module zoom =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | x
            | y
            | xy

        [<Global>]
        [<AllowNullLiteral>]
        type zoomedArea
            [<ParamObject; Emit("$0")>]
            (
                ?fill: ApexChart.zoom.zoomedArea.fill,
                ?stroke: ApexChart.zoom.zoomedArea.stroke
            ) =

            member val fill : ApexChart.zoom.zoomedArea.fill  = nativeOnly with get, set
            member val stroke : ApexChart.zoom.zoomedArea.stroke  = nativeOnly with get, set

        module zoomedArea =

            [<Global>]
            [<AllowNullLiteral>]
            type fill
                [<ParamObject; Emit("$0")>]
                (
                    ?color: string,
                    ?opacity: float
                ) =

                member val color : string  = nativeOnly with get, set
                member val opacity : float  = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type stroke
                [<ParamObject; Emit("$0")>]
                (
                    ?color: string,
                    ?opacity: float,
                    ?width: float
                ) =

                member val color : string  = nativeOnly with get, set
                member val opacity : float  = nativeOnly with get, set
                member val width : float  = nativeOnly with get, set

    module selection =

        [<Global>]
        [<AllowNullLiteral>]
        type fill
            [<ParamObject; Emit("$0")>]
            (
                ?color: string,
                ?opacity: float
            ) =

            member val color : string  = nativeOnly with get, set
            member val opacity : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type stroke
            [<ParamObject; Emit("$0")>]
            (
                ?width: float,
                ?color: string,
                ?opacity: float,
                ?dashArray: float
            ) =

            member val width : float  = nativeOnly with get, set
            member val color : string  = nativeOnly with get, set
            member val opacity : float  = nativeOnly with get, set
            member val dashArray : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type xaxis
            [<ParamObject; Emit("$0")>]
            (
                ?min: float,
                ?max: float
            ) =

            member val min : float  = nativeOnly with get, set
            member val max : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type yaxis
            [<ParamObject; Emit("$0")>]
            (
                ?min: float,
                ?max: float
            ) =

            member val min : float  = nativeOnly with get, set
            member val max : float  = nativeOnly with get, set

    module animations =

        [<Global>]
        [<AllowNullLiteral>]
        type animateGradually
            [<ParamObject; Emit("$0")>]
            (
                ?enabled: bool,
                ?delay: float
            ) =

            member val enabled : bool  = nativeOnly with get, set
            member val delay : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type dynamicAnimation
            [<ParamObject; Emit("$0")>]
            (
                ?enabled: bool,
                ?speed: float
            ) =

            member val enabled : bool  = nativeOnly with get, set
            member val speed : float  = nativeOnly with get, set

module ApexStates =

    [<Global>]
    [<AllowNullLiteral>]
    type hover
        [<ParamObject; Emit("$0")>]
        (
            ?filter: ApexStates.hover.filter
        ) =

        member val filter : ApexStates.hover.filter  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type active
        [<ParamObject; Emit("$0")>]
        (
            ?allowMultipleDataPointsSelection: bool,
            ?filter: ApexStates.active.filter
        ) =

        member val allowMultipleDataPointsSelection : bool  = nativeOnly with get, set
        member val filter : ApexStates.active.filter  = nativeOnly with get, set

    module hover =

        [<Global>]
        [<AllowNullLiteral>]
        type filter
            [<ParamObject; Emit("$0")>]
            (
                ?``type``: string
            ) =

            member val ``type`` : string  = nativeOnly with get, set

    module active =

        [<Global>]
        [<AllowNullLiteral>]
        type filter
            [<ParamObject; Emit("$0")>]
            (
                ?``type``: string
            ) =

            member val ``type`` : string  = nativeOnly with get, set

module ApexTitleSubtitle =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type align =
        | left
        | center
        | right

    [<Global>]
    [<AllowNullLiteral>]
    type style
        [<ParamObject; Emit("$0")>]
        (
            ?fontSize: string,
            ?fontFamily: string,
            ?fontWeight: U2<string, float>,
            ?color: string
        ) =

        member val fontSize : string  = nativeOnly with get, set
        member val fontFamily : string  = nativeOnly with get, set
        member val fontWeight : U2<string, float>  = nativeOnly with get, set
        member val color : string  = nativeOnly with get, set

module ApexAxisChartSeries =

    module data =

        module U5 =

            [<Global>]
            [<AllowNullLiteral>]
            type Case2
                [<ParamObject; Emit("$0")>]
                (
                    x: obj,
                    y: obj,
                    ?fill: ApexFill,
                    ?fillColor: string,
                    ?strokeColor: string,
                    ?meta: obj,
                    ?goals: array<ApexAxisChartSeries.data.U5.Case2.goals>,
                    ?barHeightOffset: float,
                    ?columnWidthOffset: float
                ) =

                member val x : obj = nativeOnly with get, set
                member val y : obj = nativeOnly with get, set
                member val fill : ApexFill  = nativeOnly with get, set
                member val fillColor : string  = nativeOnly with get, set
                member val strokeColor : string  = nativeOnly with get, set
                member val meta : obj  = nativeOnly with get, set
                member val goals : array<ApexAxisChartSeries.data.U5.Case2.goals>  = nativeOnly with get, set
                member val barHeightOffset : float  = nativeOnly with get, set
                member val columnWidthOffset : float  = nativeOnly with get, set

            module Case2 =

                [<Global>]
                [<AllowNullLiteral>]
                type goals
                    [<ParamObject; Emit("$0")>]
                    (
                        value: float,
                        ?name: string,
                        ?strokeHeight: float,
                        ?strokeWidth: float,
                        ?strokeColor: string,
                        ?strokeDashArray: float,
                        ?strokeLineCap: ApexAxisChartSeries.data.U5.Case2.goals.strokeLineCap
                    ) =

                    member val value : float = nativeOnly with get, set
                    member val name : string  = nativeOnly with get, set
                    member val strokeHeight : float  = nativeOnly with get, set
                    member val strokeWidth : float  = nativeOnly with get, set
                    member val strokeColor : string  = nativeOnly with get, set
                    member val strokeDashArray : float  = nativeOnly with get, set
                    member val strokeLineCap : ApexAxisChartSeries.data.U5.Case2.goals.strokeLineCap  = nativeOnly with get, set

                module goals =

                    [<RequireQualifiedAccess>]
                    [<StringEnum(CaseRules.None)>]
                    type strokeLineCap =
                        | butt
                        | square
                        | round

module ApexStroke =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type curve =
        | smooth
        | straight
        | stepline
        | linestep
        | monotoneCubic

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type lineCap =
        | butt
        | square
        | round

module AnnotationStyle =

    [<Global>]
    [<AllowNullLiteral>]
    type padding
        [<ParamObject; Emit("$0")>]
        (
            ?left: float,
            ?right: float,
            ?top: float,
            ?bottom: float
        ) =

        member val left : float  = nativeOnly with get, set
        member val right : float  = nativeOnly with get, set
        member val top : float  = nativeOnly with get, set
        member val bottom : float  = nativeOnly with get, set

module PointAnnotations =

    [<Global>]
    [<AllowNullLiteral>]
    type marker
        [<ParamObject; Emit("$0")>]
        (
            ?size: float,
            ?fillColor: string,
            ?strokeColor: string,
            ?strokeWidth: float,
            ?shape: string,
            ?offsetX: float,
            ?offsetY: float,
            ?cssClass: string
        ) =

        member val size : float  = nativeOnly with get, set
        member val fillColor : string  = nativeOnly with get, set
        member val strokeColor : string  = nativeOnly with get, set
        member val strokeWidth : float  = nativeOnly with get, set
        member val shape : string  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val cssClass : string  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type image
        [<ParamObject; Emit("$0")>]
        (
            ?path: string,
            ?width: float,
            ?height: float,
            ?offsetX: float,
            ?offsetY: float
        ) =

        member val path : string  = nativeOnly with get, set
        member val width : float  = nativeOnly with get, set
        member val height : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set

module ApexLocale =

    [<Global>]
    [<AllowNullLiteral>]
    type options
        [<ParamObject; Emit("$0")>]
        (
            ?months: array<string>,
            ?shortMonths: array<string>,
            ?days: array<string>,
            ?shortDays: array<string>,
            ?toolbar: ApexLocale.options.toolbar
        ) =

        member val months : array<string>  = nativeOnly with get, set
        member val shortMonths : array<string>  = nativeOnly with get, set
        member val days : array<string>  = nativeOnly with get, set
        member val shortDays : array<string>  = nativeOnly with get, set
        member val toolbar : ApexLocale.options.toolbar  = nativeOnly with get, set

    module options =

        [<Global>]
        [<AllowNullLiteral>]
        type toolbar
            [<ParamObject; Emit("$0")>]
            (
                ?download: string,
                ?selection: string,
                ?selectionZoom: string,
                ?zoomIn: string,
                ?zoomOut: string,
                ?pan: string,
                ?reset: string,
                ?exportToSVG: string,
                ?exportToPNG: string,
                ?exportToCSV: string
            ) =

            member val download : string  = nativeOnly with get, set
            member val selection : string  = nativeOnly with get, set
            member val selectionZoom : string  = nativeOnly with get, set
            member val zoomIn : string  = nativeOnly with get, set
            member val zoomOut : string  = nativeOnly with get, set
            member val pan : string  = nativeOnly with get, set
            member val reset : string  = nativeOnly with get, set
            member val exportToSVG : string  = nativeOnly with get, set
            member val exportToPNG : string  = nativeOnly with get, set
            member val exportToCSV : string  = nativeOnly with get, set

module ApexPlotOptions =

    [<Global>]
    [<AllowNullLiteral>]
    type line
        [<ParamObject; Emit("$0")>]
        (
            ?isSlopeChart: bool,
            ?colors: ApexPlotOptions.line.colors
        ) =

        member val isSlopeChart : bool  = nativeOnly with get, set
        member val colors : ApexPlotOptions.line.colors  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type area
        [<ParamObject; Emit("$0")>]
        (
            ?fillTo: ApexPlotOptions.area.fillTo
        ) =

        member val fillTo : ApexPlotOptions.area.fillTo  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type bar
        [<ParamObject; Emit("$0")>]
        (
            ?horizontal: bool,
            ?columnWidth: U2<string, float>,
            ?barHeight: U2<string, float>,
            ?distributed: bool,
            ?borderRadius: float,
            ?borderRadiusApplication: ApexPlotOptions.bar.borderRadiusApplication,
            ?borderRadiusWhenStacked: ApexPlotOptions.bar.borderRadiusWhenStacked,
            ?hideZeroBarsWhenGrouped: bool,
            ?rangeBarOverlap: bool,
            ?rangeBarGroupRows: bool,
            ?isDumbbell: bool,
            ?dumbbellColors: array<array<string>>,
            ?isFunnel: bool,
            ?isFunnel3d: bool,
            ?colors: ApexPlotOptions.bar.colors,
            ?dataLabels: ApexPlotOptions.bar.dataLabels
        ) =

        member val horizontal : bool  = nativeOnly with get, set
        member val columnWidth : U2<string, float>  = nativeOnly with get, set
        member val barHeight : U2<string, float>  = nativeOnly with get, set
        member val distributed : bool  = nativeOnly with get, set
        member val borderRadius : float  = nativeOnly with get, set
        member val borderRadiusApplication : ApexPlotOptions.bar.borderRadiusApplication  = nativeOnly with get, set
        member val borderRadiusWhenStacked : ApexPlotOptions.bar.borderRadiusWhenStacked  = nativeOnly with get, set
        member val hideZeroBarsWhenGrouped : bool  = nativeOnly with get, set
        member val rangeBarOverlap : bool  = nativeOnly with get, set
        member val rangeBarGroupRows : bool  = nativeOnly with get, set
        member val isDumbbell : bool  = nativeOnly with get, set
        member val dumbbellColors : array<array<string>>  = nativeOnly with get, set
        member val isFunnel : bool  = nativeOnly with get, set
        member val isFunnel3d : bool  = nativeOnly with get, set
        member val colors : ApexPlotOptions.bar.colors  = nativeOnly with get, set
        member val dataLabels : ApexPlotOptions.bar.dataLabels  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type bubble
        [<ParamObject; Emit("$0")>]
        (
            ?zScaling: bool,
            ?minBubbleRadius: float,
            ?maxBubbleRadius: float
        ) =

        member val zScaling : bool  = nativeOnly with get, set
        member val minBubbleRadius : float  = nativeOnly with get, set
        member val maxBubbleRadius : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type candlestick
        [<ParamObject; Emit("$0")>]
        (
            ?colors: ApexPlotOptions.candlestick.colors,
            ?wick: ApexPlotOptions.candlestick.wick
        ) =

        member val colors : ApexPlotOptions.candlestick.colors  = nativeOnly with get, set
        member val wick : ApexPlotOptions.candlestick.wick  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type boxPlot
        [<ParamObject; Emit("$0")>]
        (
            ?colors: ApexPlotOptions.boxPlot.colors
        ) =

        member val colors : ApexPlotOptions.boxPlot.colors  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type heatmap
        [<ParamObject; Emit("$0")>]
        (
            ?radius: float,
            ?enableShades: bool,
            ?shadeIntensity: float,
            ?reverseNegativeShade: bool,
            ?distributed: bool,
            ?useFillColorAsStroke: bool,
            ?colorScale: ApexPlotOptions.heatmap.colorScale
        ) =

        member val radius : float  = nativeOnly with get, set
        member val enableShades : bool  = nativeOnly with get, set
        member val shadeIntensity : float  = nativeOnly with get, set
        member val reverseNegativeShade : bool  = nativeOnly with get, set
        member val distributed : bool  = nativeOnly with get, set
        member val useFillColorAsStroke : bool  = nativeOnly with get, set
        member val colorScale : ApexPlotOptions.heatmap.colorScale  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type treemap
        [<ParamObject; Emit("$0")>]
        (
            ?enableShades: bool,
            ?shadeIntensity: float,
            ?distributed: bool,
            ?reverseNegativeShade: bool,
            ?useFillColorAsStroke: bool,
            ?dataLabels: ApexPlotOptions.treemap.dataLabels,
            ?borderRadius: float,
            ?colorScale: ApexPlotOptions.treemap.colorScale,
            ?seriesTitle: ApexPlotOptions.treemap.seriesTitle
        ) =

        member val enableShades : bool  = nativeOnly with get, set
        member val shadeIntensity : float  = nativeOnly with get, set
        member val distributed : bool  = nativeOnly with get, set
        member val reverseNegativeShade : bool  = nativeOnly with get, set
        member val useFillColorAsStroke : bool  = nativeOnly with get, set
        member val dataLabels : ApexPlotOptions.treemap.dataLabels  = nativeOnly with get, set
        member val borderRadius : float  = nativeOnly with get, set
        member val colorScale : ApexPlotOptions.treemap.colorScale  = nativeOnly with get, set
        member val seriesTitle : ApexPlotOptions.treemap.seriesTitle  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type pie
        [<ParamObject; Emit("$0")>]
        (
            ?startAngle: float,
            ?endAngle: float,
            ?customScale: float,
            ?offsetX: float,
            ?offsetY: float,
            ?expandOnClick: bool,
            ?dataLabels: ApexPlotOptions.pie.dataLabels,
            ?donut: ApexPlotOptions.pie.donut
        ) =

        member val startAngle : float  = nativeOnly with get, set
        member val endAngle : float  = nativeOnly with get, set
        member val customScale : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val expandOnClick : bool  = nativeOnly with get, set
        member val dataLabels : ApexPlotOptions.pie.dataLabels  = nativeOnly with get, set
        member val donut : ApexPlotOptions.pie.donut  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type polarArea
        [<ParamObject; Emit("$0")>]
        (
            ?rings: ApexPlotOptions.polarArea.rings,
            ?spokes: ApexPlotOptions.polarArea.spokes
        ) =

        member val rings : ApexPlotOptions.polarArea.rings  = nativeOnly with get, set
        member val spokes : ApexPlotOptions.polarArea.spokes  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type radar
        [<ParamObject; Emit("$0")>]
        (
            ?size: float,
            ?offsetX: float,
            ?offsetY: float,
            ?polygons: ApexPlotOptions.radar.polygons
        ) =

        member val size : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val polygons : ApexPlotOptions.radar.polygons  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type radialBar
        [<ParamObject; Emit("$0")>]
        (
            ?inverseOrder: bool,
            ?startAngle: float,
            ?endAngle: float,
            ?offsetX: float,
            ?offsetY: float,
            ?hollow: ApexPlotOptions.radialBar.hollow,
            ?track: ApexPlotOptions.radialBar.track,
            ?dataLabels: ApexPlotOptions.radialBar.dataLabels,
            ?barLabels: ApexPlotOptions.radialBar.barLabels
        ) =

        member val inverseOrder : bool  = nativeOnly with get, set
        member val startAngle : float  = nativeOnly with get, set
        member val endAngle : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val hollow : ApexPlotOptions.radialBar.hollow  = nativeOnly with get, set
        member val track : ApexPlotOptions.radialBar.track  = nativeOnly with get, set
        member val dataLabels : ApexPlotOptions.radialBar.dataLabels  = nativeOnly with get, set
        member val barLabels : ApexPlotOptions.radialBar.barLabels  = nativeOnly with get, set

    module line =

        [<Global>]
        [<AllowNullLiteral>]
        type colors
            [<ParamObject; Emit("$0")>]
            (
                ?threshold: float,
                ?colorAboveThreshold: string,
                ?colorBelowThreshold: string
            ) =

            member val threshold : float  = nativeOnly with get, set
            member val colorAboveThreshold : string  = nativeOnly with get, set
            member val colorBelowThreshold : string  = nativeOnly with get, set

    module area =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type fillTo =
            | origin
            | ``end``

    module bar =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type borderRadiusApplication =
            | around
            | ``end``

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type borderRadiusWhenStacked =
            | all
            | last

        [<Global>]
        [<AllowNullLiteral>]
        type colors
            [<ParamObject; Emit("$0")>]
            (
                ?ranges: array<ApexPlotOptions.bar.colors.ranges>,
                ?backgroundBarColors: array<string>,
                ?backgroundBarOpacity: float,
                ?backgroundBarRadius: float
            ) =

            member val ranges : array<ApexPlotOptions.bar.colors.ranges>  = nativeOnly with get, set
            member val backgroundBarColors : array<string>  = nativeOnly with get, set
            member val backgroundBarOpacity : float  = nativeOnly with get, set
            member val backgroundBarRadius : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type dataLabels
            [<ParamObject; Emit("$0")>]
            (
                ?maxItems: float,
                ?hideOverflowingLabels: bool,
                ?position: string,
                ?orientation: ApexPlotOptions.bar.dataLabels.orientation,
                ?total: ApexPlotOptions.bar.dataLabels.total
            ) =

            member val maxItems : float  = nativeOnly with get, set
            member val hideOverflowingLabels : bool  = nativeOnly with get, set
            member val position : string  = nativeOnly with get, set
            member val orientation : ApexPlotOptions.bar.dataLabels.orientation  = nativeOnly with get, set
            member val total : ApexPlotOptions.bar.dataLabels.total  = nativeOnly with get, set

        module colors =

            [<Global>]
            [<AllowNullLiteral>]
            type ranges
                [<ParamObject; Emit("$0")>]
                (
                    ?from: float,
                    ?``to``: float,
                    ?color: string
                ) =

                member val from : float  = nativeOnly with get, set
                member val ``to`` : float  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set

        module dataLabels =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type orientation =
                | horizontal
                | vertical

            [<Global>]
            [<AllowNullLiteral>]
            type total
                [<ParamObject; Emit("$0")>]
                (
                    formatter: string,
                    ?enabled: bool,
                    ?offsetX: float,
                    ?offsetY: float,
                    ?style: ApexPlotOptions.bar.dataLabels.total.style
                ) =

                member val formatter : string = nativeOnly with get, set
                member val enabled : bool  = nativeOnly with get, set
                member val offsetX : float  = nativeOnly with get, set
                member val offsetY : float  = nativeOnly with get, set
                member val style : ApexPlotOptions.bar.dataLabels.total.style  = nativeOnly with get, set

            module total =

                [<Global>]
                [<AllowNullLiteral>]
                type style
                    [<ParamObject; Emit("$0")>]
                    (
                        ?color: string,
                        ?fontSize: string,
                        ?fontFamily: string,
                        ?fontWeight: U2<float, string>
                    ) =

                    member val color : string  = nativeOnly with get, set
                    member val fontSize : string  = nativeOnly with get, set
                    member val fontFamily : string  = nativeOnly with get, set
                    member val fontWeight : U2<float, string>  = nativeOnly with get, set

    module candlestick =

        [<Global>]
        [<AllowNullLiteral>]
        type colors
            [<ParamObject; Emit("$0")>]
            (
                ?upward: U2<string, array<string>>,
                ?downward: U2<string, array<string>>
            ) =

            member val upward : U2<string, array<string>>  = nativeOnly with get, set
            member val downward : U2<string, array<string>>  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type wick
            [<ParamObject; Emit("$0")>]
            (
                ?useFillColor: bool
            ) =

            member val useFillColor : bool  = nativeOnly with get, set

    module boxPlot =

        [<Global>]
        [<AllowNullLiteral>]
        type colors
            [<ParamObject; Emit("$0")>]
            (
                ?upper: U2<string, array<string>>,
                ?lower: U2<string, array<string>>
            ) =

            member val upper : U2<string, array<string>>  = nativeOnly with get, set
            member val lower : U2<string, array<string>>  = nativeOnly with get, set

    module heatmap =

        [<Global>]
        [<AllowNullLiteral>]
        type colorScale
            [<ParamObject; Emit("$0")>]
            (
                ?ranges: array<ApexPlotOptions.heatmap.colorScale.ranges>,
                ?inverse: bool,
                ?min: float,
                ?max: float
            ) =

            member val ranges : array<ApexPlotOptions.heatmap.colorScale.ranges>  = nativeOnly with get, set
            member val inverse : bool  = nativeOnly with get, set
            member val min : float  = nativeOnly with get, set
            member val max : float  = nativeOnly with get, set

        module colorScale =

            [<Global>]
            [<AllowNullLiteral>]
            type ranges
                [<ParamObject; Emit("$0")>]
                (
                    ?from: float,
                    ?``to``: float,
                    ?color: string,
                    ?foreColor: string,
                    ?name: string
                ) =

                member val from : float  = nativeOnly with get, set
                member val ``to`` : float  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set
                member val foreColor : string  = nativeOnly with get, set
                member val name : string  = nativeOnly with get, set

    module treemap =

        [<Global>]
        [<AllowNullLiteral>]
        type dataLabels
            [<ParamObject; Emit("$0")>]
            (
                ?format: ApexPlotOptions.treemap.dataLabels.format
            ) =

            member val format : ApexPlotOptions.treemap.dataLabels.format  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type colorScale
            [<ParamObject; Emit("$0")>]
            (
                ?inverse: bool,
                ?ranges: array<ApexPlotOptions.treemap.colorScale.ranges>,
                ?min: float,
                ?max: float
            ) =

            member val inverse : bool  = nativeOnly with get, set
            member val ranges : array<ApexPlotOptions.treemap.colorScale.ranges>  = nativeOnly with get, set
            member val min : float  = nativeOnly with get, set
            member val max : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type seriesTitle
            [<ParamObject; Emit("$0")>]
            (
                ?show: bool,
                ?offsetY: float,
                ?offsetX: float,
                ?borderColor: string,
                ?borderWidth: float,
                ?borderRadius: float,
                ?style: ApexPlotOptions.treemap.seriesTitle.style
            ) =

            member val show : bool  = nativeOnly with get, set
            member val offsetY : float  = nativeOnly with get, set
            member val offsetX : float  = nativeOnly with get, set
            member val borderColor : string  = nativeOnly with get, set
            member val borderWidth : float  = nativeOnly with get, set
            member val borderRadius : float  = nativeOnly with get, set
            member val style : ApexPlotOptions.treemap.seriesTitle.style  = nativeOnly with get, set

        module dataLabels =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type format =
                | scale
                | truncate

        module colorScale =

            [<Global>]
            [<AllowNullLiteral>]
            type ranges
                [<ParamObject; Emit("$0")>]
                (
                    ?from: float,
                    ?``to``: float,
                    ?color: string,
                    ?foreColor: string,
                    ?name: string
                ) =

                member val from : float  = nativeOnly with get, set
                member val ``to`` : float  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set
                member val foreColor : string  = nativeOnly with get, set
                member val name : string  = nativeOnly with get, set

        module seriesTitle =

            [<Global>]
            [<AllowNullLiteral>]
            type style
                [<ParamObject; Emit("$0")>]
                (
                    ?background: string,
                    ?color: string,
                    ?fontSize: string,
                    ?fontFamily: string,
                    ?fontWeight: U2<float, string>,
                    ?cssClass: string,
                    ?padding: ApexPlotOptions.treemap.seriesTitle.style.padding
                ) =

                member val background : string  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set
                member val fontSize : string  = nativeOnly with get, set
                member val fontFamily : string  = nativeOnly with get, set
                member val fontWeight : U2<float, string>  = nativeOnly with get, set
                member val cssClass : string  = nativeOnly with get, set
                member val padding : ApexPlotOptions.treemap.seriesTitle.style.padding  = nativeOnly with get, set

            module style =

                [<Global>]
                [<AllowNullLiteral>]
                type padding
                    [<ParamObject; Emit("$0")>]
                    (
                        ?left: float,
                        ?right: float,
                        ?top: float,
                        ?bottom: float
                    ) =

                    member val left : float  = nativeOnly with get, set
                    member val right : float  = nativeOnly with get, set
                    member val top : float  = nativeOnly with get, set
                    member val bottom : float  = nativeOnly with get, set

    module pie =

        [<Global>]
        [<AllowNullLiteral>]
        type dataLabels
            [<ParamObject; Emit("$0")>]
            (
                ?offset: float,
                ?minAngleToShowLabel: float
            ) =

            member val offset : float  = nativeOnly with get, set
            member val minAngleToShowLabel : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type donut
            [<ParamObject; Emit("$0")>]
            (
                ?size: string,
                ?background: string,
                ?labels: ApexPlotOptions.pie.donut.labels
            ) =

            member val size : string  = nativeOnly with get, set
            member val background : string  = nativeOnly with get, set
            member val labels : ApexPlotOptions.pie.donut.labels  = nativeOnly with get, set

        module donut =

            [<Global>]
            [<AllowNullLiteral>]
            type labels
                [<ParamObject; Emit("$0")>]
                (
                    ?show: bool,
                    ?name: ApexPlotOptions.pie.donut.labels.name,
                    ?value: ApexPlotOptions.pie.donut.labels.value,
                    ?total: ApexPlotOptions.pie.donut.labels.total
                ) =

                member val show : bool  = nativeOnly with get, set
                member val name : ApexPlotOptions.pie.donut.labels.name  = nativeOnly with get, set
                member val value : ApexPlotOptions.pie.donut.labels.value  = nativeOnly with get, set
                member val total : ApexPlotOptions.pie.donut.labels.total  = nativeOnly with get, set

            module labels =

                [<Global>]
                [<AllowNullLiteral>]
                type name
                    [<ParamObject; Emit("$0")>]
                    (
                        formatter: string,
                        ?show: bool,
                        ?fontSize: string,
                        ?fontFamily: string,
                        ?fontWeight: U2<string, float>,
                        ?color: string,
                        ?offsetY: float
                    ) =

                    member val formatter : string = nativeOnly with get, set
                    member val show : bool  = nativeOnly with get, set
                    member val fontSize : string  = nativeOnly with get, set
                    member val fontFamily : string  = nativeOnly with get, set
                    member val fontWeight : U2<string, float>  = nativeOnly with get, set
                    member val color : string  = nativeOnly with get, set
                    member val offsetY : float  = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type value
                    [<ParamObject; Emit("$0")>]
                    (
                        formatter: string,
                        ?show: bool,
                        ?fontSize: string,
                        ?fontFamily: string,
                        ?fontWeight: U2<string, float>,
                        ?color: string,
                        ?offsetY: float
                    ) =

                    member val formatter : string = nativeOnly with get, set
                    member val show : bool  = nativeOnly with get, set
                    member val fontSize : string  = nativeOnly with get, set
                    member val fontFamily : string  = nativeOnly with get, set
                    member val fontWeight : U2<string, float>  = nativeOnly with get, set
                    member val color : string  = nativeOnly with get, set
                    member val offsetY : float  = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type total
                    [<ParamObject; Emit("$0")>]
                    (
                        formatter: string,
                        ?show: bool,
                        ?showAlways: bool,
                        ?fontFamily: string,
                        ?fontWeight: U2<string, float>,
                        ?fontSize: string,
                        ?label: string,
                        ?color: string
                    ) =

                    member val formatter : string = nativeOnly with get, set
                    member val show : bool  = nativeOnly with get, set
                    member val showAlways : bool  = nativeOnly with get, set
                    member val fontFamily : string  = nativeOnly with get, set
                    member val fontWeight : U2<string, float>  = nativeOnly with get, set
                    member val fontSize : string  = nativeOnly with get, set
                    member val label : string  = nativeOnly with get, set
                    member val color : string  = nativeOnly with get, set

    module polarArea =

        [<Global>]
        [<AllowNullLiteral>]
        type rings
            [<ParamObject; Emit("$0")>]
            (
                ?strokeWidth: float,
                ?strokeColor: string
            ) =

            member val strokeWidth : float  = nativeOnly with get, set
            member val strokeColor : string  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type spokes
            [<ParamObject; Emit("$0")>]
            (
                ?strokeWidth: float,
                ?connectorColors: U2<string, array<string>>
            ) =

            member val strokeWidth : float  = nativeOnly with get, set
            member val connectorColors : U2<string, array<string>>  = nativeOnly with get, set

    module radar =

        [<Global>]
        [<AllowNullLiteral>]
        type polygons
            [<ParamObject; Emit("$0")>]
            (
                ?strokeColors: U2<string, array<string>>,
                ?strokeWidth: U2<string, array<string>>,
                ?connectorColors: U2<string, array<string>>,
                ?fill: ApexPlotOptions.radar.polygons.fill
            ) =

            member val strokeColors : U2<string, array<string>>  = nativeOnly with get, set
            member val strokeWidth : U2<string, array<string>>  = nativeOnly with get, set
            member val connectorColors : U2<string, array<string>>  = nativeOnly with get, set
            member val fill : ApexPlotOptions.radar.polygons.fill  = nativeOnly with get, set

        module polygons =

            [<Global>]
            [<AllowNullLiteral>]
            type fill
                [<ParamObject; Emit("$0")>]
                (
                    ?colors: array<string>
                ) =

                member val colors : array<string>  = nativeOnly with get, set

    module radialBar =

        [<Global>]
        [<AllowNullLiteral>]
        type hollow
            [<ParamObject; Emit("$0")>]
            (
                ?margin: float,
                ?size: string,
                ?background: string,
                ?image: string,
                ?imageWidth: float,
                ?imageHeight: float,
                ?imageOffsetX: float,
                ?imageOffsetY: float,
                ?imageClipped: bool,
                ?position: ApexPlotOptions.radialBar.hollow.position,
                ?dropShadow: ApexDropShadow
            ) =

            member val margin : float  = nativeOnly with get, set
            member val size : string  = nativeOnly with get, set
            member val background : string  = nativeOnly with get, set
            member val image : string  = nativeOnly with get, set
            member val imageWidth : float  = nativeOnly with get, set
            member val imageHeight : float  = nativeOnly with get, set
            member val imageOffsetX : float  = nativeOnly with get, set
            member val imageOffsetY : float  = nativeOnly with get, set
            member val imageClipped : bool  = nativeOnly with get, set
            member val position : ApexPlotOptions.radialBar.hollow.position  = nativeOnly with get, set
            member val dropShadow : ApexDropShadow  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type track
            [<ParamObject; Emit("$0")>]
            (
                ?show: bool,
                ?startAngle: float,
                ?endAngle: float,
                ?background: U2<string, array<string>>,
                ?strokeWidth: string,
                ?opacity: float,
                ?margin: float,
                ?dropShadow: ApexDropShadow
            ) =

            member val show : bool  = nativeOnly with get, set
            member val startAngle : float  = nativeOnly with get, set
            member val endAngle : float  = nativeOnly with get, set
            member val background : U2<string, array<string>>  = nativeOnly with get, set
            member val strokeWidth : string  = nativeOnly with get, set
            member val opacity : float  = nativeOnly with get, set
            member val margin : float  = nativeOnly with get, set
            member val dropShadow : ApexDropShadow  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type dataLabels
            [<ParamObject; Emit("$0")>]
            (
                ?show: bool,
                ?name: ApexPlotOptions.radialBar.dataLabels.name,
                ?value: ApexPlotOptions.radialBar.dataLabels.value,
                ?total: ApexPlotOptions.radialBar.dataLabels.total
            ) =

            member val show : bool  = nativeOnly with get, set
            member val name : ApexPlotOptions.radialBar.dataLabels.name  = nativeOnly with get, set
            member val value : ApexPlotOptions.radialBar.dataLabels.value  = nativeOnly with get, set
            member val total : ApexPlotOptions.radialBar.dataLabels.total  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type barLabels
            [<ParamObject; Emit("$0")>]
            (
                ?enabled: bool,
                ?offsetX: float,
                ?offsetY: float,
                ?useSeriesColors: bool,
                ?fontFamily: string,
                ?fontWeight: U2<string, float>,
                ?fontSize: string,
                ?formatter: ApexPlotOptions.radialBar.barLabels.formatter,
                ?onClick: ApexPlotOptions.radialBar.barLabels.onClick
            ) =

            member val enabled : bool  = nativeOnly with get, set
            member val offsetX : float  = nativeOnly with get, set
            member val offsetY : float  = nativeOnly with get, set
            member val useSeriesColors : bool  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set
            member val fontWeight : U2<string, float>  = nativeOnly with get, set
            member val fontSize : string  = nativeOnly with get, set
            member val formatter : ApexPlotOptions.radialBar.barLabels.formatter  = nativeOnly with get, set
            member val onClick : ApexPlotOptions.radialBar.barLabels.onClick  = nativeOnly with get, set

        module hollow =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type position =
                | front
                | back

        module dataLabels =

            [<Global>]
            [<AllowNullLiteral>]
            type name
                [<ParamObject; Emit("$0")>]
                (
                    ?show: bool,
                    ?fontFamily: string,
                    ?fontWeight: U2<string, float>,
                    ?fontSize: string,
                    ?color: string,
                    ?offsetY: float
                ) =

                member val show : bool  = nativeOnly with get, set
                member val fontFamily : string  = nativeOnly with get, set
                member val fontWeight : U2<string, float>  = nativeOnly with get, set
                member val fontSize : string  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set
                member val offsetY : float  = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type value
                [<ParamObject; Emit("$0")>]
                (
                    formatter: string,
                    ?show: bool,
                    ?fontFamily: string,
                    ?fontSize: string,
                    ?fontWeight: U2<string, float>,
                    ?color: string,
                    ?offsetY: float
                ) =

                member val formatter : string = nativeOnly with get, set
                member val show : bool  = nativeOnly with get, set
                member val fontFamily : string  = nativeOnly with get, set
                member val fontSize : string  = nativeOnly with get, set
                member val fontWeight : U2<string, float>  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set
                member val offsetY : float  = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type total
                [<ParamObject; Emit("$0")>]
                (
                    formatter: string,
                    ?show: bool,
                    ?label: string,
                    ?color: string,
                    ?fontFamily: string,
                    ?fontWeight: U2<string, float>,
                    ?fontSize: string
                ) =

                member val formatter : string = nativeOnly with get, set
                member val show : bool  = nativeOnly with get, set
                member val label : string  = nativeOnly with get, set
                member val color : string  = nativeOnly with get, set
                member val fontFamily : string  = nativeOnly with get, set
                member val fontWeight : U2<string, float>  = nativeOnly with get, set
                member val fontSize : string  = nativeOnly with get, set

        module barLabels =

            type formatter =
                delegate of barName: string * ?opts: obj -> string

            type onClick =
                delegate of barName: string * ?opts: obj -> unit

module ApexFill =

    [<Global>]
    [<AllowNullLiteral>]
    type gradient
        [<ParamObject; Emit("$0")>]
        (
            ?shade: string,
            ?``type``: string,
            ?shadeIntensity: float,
            ?gradientToColors: array<string>,
            ?inverseColors: bool,
            ?opacityFrom: U2<float, array<float>>,
            ?opacityTo: U2<float, array<float>>,
            ?stops: array<float>,
            ?colorStops: U2<array<array<ApexColorStop>>, array<ApexColorStop>>
        ) =

        member val shade : string  = nativeOnly with get, set
        member val ``type`` : string  = nativeOnly with get, set
        member val shadeIntensity : float  = nativeOnly with get, set
        member val gradientToColors : array<string>  = nativeOnly with get, set
        member val inverseColors : bool  = nativeOnly with get, set
        member val opacityFrom : U2<float, array<float>>  = nativeOnly with get, set
        member val opacityTo : U2<float, array<float>>  = nativeOnly with get, set
        member val stops : array<float>  = nativeOnly with get, set
        member val colorStops : U2<array<array<ApexColorStop>>, array<ApexColorStop>>  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type image
        [<ParamObject; Emit("$0")>]
        (
            ?src: U2<string, array<string>>,
            ?width: float,
            ?height: float
        ) =

        member val src : U2<string, array<string>>  = nativeOnly with get, set
        member val width : float  = nativeOnly with get, set
        member val height : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type pattern
        [<ParamObject; Emit("$0")>]
        (
            ?style: U2<string, array<string>>,
            ?width: float,
            ?height: float,
            ?strokeWidth: float
        ) =

        member val style : U2<string, array<string>>  = nativeOnly with get, set
        member val width : float  = nativeOnly with get, set
        member val height : float  = nativeOnly with get, set
        member val strokeWidth : float  = nativeOnly with get, set

module ApexLegend =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type position =
        | top
        | right
        | bottom
        | left

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type horizontalAlign =
        | left
        | center
        | right

    [<Global>]
    [<AllowNullLiteral>]
    type labels
        [<ParamObject; Emit("$0")>]
        (
            ?colors: U2<string, array<string>>,
            ?useSeriesColors: bool
        ) =

        member val colors : U2<string, array<string>>  = nativeOnly with get, set
        member val useSeriesColors : bool  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type markers
        [<ParamObject; Emit("$0")>]
        (
            customHTML: obj,
            onClick: unit,
            ?size: float,
            ?strokeWidth: float,
            ?fillColors: array<string>,
            ?shape: ApexMarkerShape,
            ?offsetX: float,
            ?offsetY: float
        ) =

        member val customHTML : obj = nativeOnly with get, set
        member val onClick : unit = nativeOnly with get, set
        member val size : float  = nativeOnly with get, set
        member val strokeWidth : float  = nativeOnly with get, set
        member val fillColors : array<string>  = nativeOnly with get, set
        member val shape : ApexMarkerShape  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type itemMargin
        [<ParamObject; Emit("$0")>]
        (
            ?horizontal: float,
            ?vertical: float
        ) =

        member val horizontal : float  = nativeOnly with get, set
        member val vertical : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type onItemClick
        [<ParamObject; Emit("$0")>]
        (
            ?toggleDataSeries: bool
        ) =

        member val toggleDataSeries : bool  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type onItemHover
        [<ParamObject; Emit("$0")>]
        (
            ?highlightDataSeries: bool
        ) =

        member val highlightDataSeries : bool  = nativeOnly with get, set

module ApexMarkers =

    [<Global>]
    [<AllowNullLiteral>]
    type hover
        [<ParamObject; Emit("$0")>]
        (
            ?size: float,
            ?sizeOffset: float
        ) =

        member val size : float  = nativeOnly with get, set
        member val sizeOffset : float  = nativeOnly with get, set

module ApexNoData =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type align =
        | left
        | right
        | center

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type verticalAlign =
        | top
        | middle
        | bottom

    [<Global>]
    [<AllowNullLiteral>]
    type style
        [<ParamObject; Emit("$0")>]
        (
            ?color: string,
            ?fontSize: string,
            ?fontFamily: string
        ) =

        member val color : string  = nativeOnly with get, set
        member val fontSize : string  = nativeOnly with get, set
        member val fontFamily : string  = nativeOnly with get, set

module ApexDataLabels =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type textAnchor =
        | start
        | middle
        | ``end``

    [<Global>]
    [<AllowNullLiteral>]
    type style
        [<ParamObject; Emit("$0")>]
        (
            ?fontSize: string,
            ?fontFamily: string,
            ?fontWeight: U2<string, float>,
            ?colors: array<obj>
        ) =

        member val fontSize : string  = nativeOnly with get, set
        member val fontFamily : string  = nativeOnly with get, set
        member val fontWeight : U2<string, float>  = nativeOnly with get, set
        member val colors : array<obj>  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type background
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?foreColor: string,
            ?borderRadius: float,
            ?padding: float,
            ?opacity: float,
            ?borderWidth: float,
            ?borderColor: string,
            ?dropShadow: ApexDropShadow
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val foreColor : string  = nativeOnly with get, set
        member val borderRadius : float  = nativeOnly with get, set
        member val padding : float  = nativeOnly with get, set
        member val opacity : float  = nativeOnly with get, set
        member val borderWidth : float  = nativeOnly with get, set
        member val borderColor : string  = nativeOnly with get, set
        member val dropShadow : ApexDropShadow  = nativeOnly with get, set

module ApexTooltipY =

    [<Global>]
    [<AllowNullLiteral>]
    type title
        [<ParamObject; Emit("$0")>]
        (
            formatter: string
        ) =

        member val formatter : string = nativeOnly with get, set

module ApexTooltip =

    [<Global>]
    [<AllowNullLiteral>]
    type style
        [<ParamObject; Emit("$0")>]
        (
            ?fontSize: string,
            ?fontFamily: string
        ) =

        member val fontSize : string  = nativeOnly with get, set
        member val fontFamily : string  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type onDatasetHover
        [<ParamObject; Emit("$0")>]
        (
            ?highlightDataSeries: bool
        ) =

        member val highlightDataSeries : bool  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type x
        [<ParamObject; Emit("$0")>]
        (
            formatter: string,
            ?show: bool,
            ?format: string
        ) =

        member val formatter : string = nativeOnly with get, set
        member val show : bool  = nativeOnly with get, set
        member val format : string  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type z
        [<ParamObject; Emit("$0")>]
        (
            formatter: string,
            ?title: string
        ) =

        member val formatter : string = nativeOnly with get, set
        member val title : string  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type marker
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?fillColors: array<string>
        ) =

        member val show : bool  = nativeOnly with get, set
        member val fillColors : array<string>  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type items
        [<ParamObject; Emit("$0")>]
        (
            ?display: string
        ) =

        member val display : string  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type ``fixed``
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?position: string,
            ?offsetX: float,
            ?offsetY: float
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val position : string  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set

module ApexXAxis =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | category
        | datetime
        | numeric

    [<Global>]
    [<AllowNullLiteral>]
    type labels
        [<ParamObject; Emit("$0")>]
        (
            formatter: U2<string, array<string>>,
            ?show: bool,
            ?rotate: float,
            ?rotateAlways: bool,
            ?hideOverlappingLabels: bool,
            ?showDuplicates: bool,
            ?trim: bool,
            ?minHeight: float,
            ?maxHeight: float,
            ?style: ApexXAxis.labels.style,
            ?offsetX: float,
            ?offsetY: float,
            ?format: string,
            ?datetimeUTC: bool,
            ?datetimeFormatter: ApexXAxis.labels.datetimeFormatter
        ) =

        member val formatter : U2<string, array<string>> = nativeOnly with get, set
        member val show : bool  = nativeOnly with get, set
        member val rotate : float  = nativeOnly with get, set
        member val rotateAlways : bool  = nativeOnly with get, set
        member val hideOverlappingLabels : bool  = nativeOnly with get, set
        member val showDuplicates : bool  = nativeOnly with get, set
        member val trim : bool  = nativeOnly with get, set
        member val minHeight : float  = nativeOnly with get, set
        member val maxHeight : float  = nativeOnly with get, set
        member val style : ApexXAxis.labels.style  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val format : string  = nativeOnly with get, set
        member val datetimeUTC : bool  = nativeOnly with get, set
        member val datetimeFormatter : ApexXAxis.labels.datetimeFormatter  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type group
        [<ParamObject; Emit("$0")>]
        (
            ?groups: array<ApexXAxis.group.groups>,
            ?style: ApexXAxis.group.style
        ) =

        member val groups : array<ApexXAxis.group.groups>  = nativeOnly with get, set
        member val style : ApexXAxis.group.style  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type axisBorder
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?color: string,
            ?offsetX: float,
            ?offsetY: float,
            ?strokeWidth: float
        ) =

        member val show : bool  = nativeOnly with get, set
        member val color : string  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val strokeWidth : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type axisTicks
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?borderType: string,
            ?color: string,
            ?height: float,
            ?offsetX: float,
            ?offsetY: float
        ) =

        member val show : bool  = nativeOnly with get, set
        member val borderType : string  = nativeOnly with get, set
        member val color : string  = nativeOnly with get, set
        member val height : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type tickAmount =
        | dataPoints

    [<Global>]
    [<AllowNullLiteral>]
    type title
        [<ParamObject; Emit("$0")>]
        (
            ?text: string,
            ?offsetX: float,
            ?offsetY: float,
            ?style: ApexXAxis.title.style
        ) =

        member val text : string  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val style : ApexXAxis.title.style  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type crosshairs
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?width: U2<float, string>,
            ?position: string,
            ?opacity: float,
            ?stroke: ApexXAxis.crosshairs.stroke,
            ?fill: ApexXAxis.crosshairs.fill,
            ?dropShadow: ApexDropShadow
        ) =

        member val show : bool  = nativeOnly with get, set
        member val width : U2<float, string>  = nativeOnly with get, set
        member val position : string  = nativeOnly with get, set
        member val opacity : float  = nativeOnly with get, set
        member val stroke : ApexXAxis.crosshairs.stroke  = nativeOnly with get, set
        member val fill : ApexXAxis.crosshairs.fill  = nativeOnly with get, set
        member val dropShadow : ApexDropShadow  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tooltip
        [<ParamObject; Emit("$0")>]
        (
            formatter: string,
            ?enabled: bool,
            ?offsetY: float,
            ?style: ApexXAxis.tooltip.style
        ) =

        member val formatter : string = nativeOnly with get, set
        member val enabled : bool  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val style : ApexXAxis.tooltip.style  = nativeOnly with get, set

    module labels =

        [<Global>]
        [<AllowNullLiteral>]
        type style
            [<ParamObject; Emit("$0")>]
            (
                ?colors: U2<string, array<string>>,
                ?fontSize: string,
                ?fontFamily: string,
                ?fontWeight: U2<string, float>,
                ?cssClass: string
            ) =

            member val colors : U2<string, array<string>>  = nativeOnly with get, set
            member val fontSize : string  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set
            member val fontWeight : U2<string, float>  = nativeOnly with get, set
            member val cssClass : string  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type datetimeFormatter
            [<ParamObject; Emit("$0")>]
            (
                ?year: string,
                ?month: string,
                ?day: string,
                ?hour: string,
                ?minute: string,
                ?second: string
            ) =

            member val year : string  = nativeOnly with get, set
            member val month : string  = nativeOnly with get, set
            member val day : string  = nativeOnly with get, set
            member val hour : string  = nativeOnly with get, set
            member val minute : string  = nativeOnly with get, set
            member val second : string  = nativeOnly with get, set

    module group =

        [<Global>]
        [<AllowNullLiteral>]
        type groups
            [<ParamObject; Emit("$0")>]
            (
                title: string,
                cols: float
            ) =

            member val title : string = nativeOnly with get, set
            member val cols : float = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type style
            [<ParamObject; Emit("$0")>]
            (
                ?colors: U2<string, array<string>>,
                ?fontSize: string,
                ?fontFamily: string,
                ?fontWeight: U2<string, float>,
                ?cssClass: string
            ) =

            member val colors : U2<string, array<string>>  = nativeOnly with get, set
            member val fontSize : string  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set
            member val fontWeight : U2<string, float>  = nativeOnly with get, set
            member val cssClass : string  = nativeOnly with get, set

    module title =

        [<Global>]
        [<AllowNullLiteral>]
        type style
            [<ParamObject; Emit("$0")>]
            (
                ?color: string,
                ?fontFamily: string,
                ?fontWeight: U2<string, float>,
                ?fontSize: string,
                ?cssClass: string
            ) =

            member val color : string  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set
            member val fontWeight : U2<string, float>  = nativeOnly with get, set
            member val fontSize : string  = nativeOnly with get, set
            member val cssClass : string  = nativeOnly with get, set

    module crosshairs =

        [<Global>]
        [<AllowNullLiteral>]
        type stroke
            [<ParamObject; Emit("$0")>]
            (
                ?color: string,
                ?width: float,
                ?dashArray: float
            ) =

            member val color : string  = nativeOnly with get, set
            member val width : float  = nativeOnly with get, set
            member val dashArray : float  = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type fill
            [<ParamObject; Emit("$0")>]
            (
                ?``type``: string,
                ?color: string,
                ?gradient: ApexXAxis.crosshairs.fill.gradient
            ) =

            member val ``type`` : string  = nativeOnly with get, set
            member val color : string  = nativeOnly with get, set
            member val gradient : ApexXAxis.crosshairs.fill.gradient  = nativeOnly with get, set

        module fill =

            [<Global>]
            [<AllowNullLiteral>]
            type gradient
                [<ParamObject; Emit("$0")>]
                (
                    ?colorFrom: string,
                    ?colorTo: string,
                    ?stops: array<float>,
                    ?opacityFrom: float,
                    ?opacityTo: float
                ) =

                member val colorFrom : string  = nativeOnly with get, set
                member val colorTo : string  = nativeOnly with get, set
                member val stops : array<float>  = nativeOnly with get, set
                member val opacityFrom : float  = nativeOnly with get, set
                member val opacityTo : float  = nativeOnly with get, set

    module tooltip =

        [<Global>]
        [<AllowNullLiteral>]
        type style
            [<ParamObject; Emit("$0")>]
            (
                ?fontSize: string,
                ?fontFamily: string
            ) =

            member val fontSize : string  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set

module ApexYAxis =

    [<Global>]
    [<AllowNullLiteral>]
    type labels
        [<ParamObject; Emit("$0")>]
        (
            formatter: U2<string, array<string>>,
            ?show: bool,
            ?showDuplicates: bool,
            ?minWidth: float,
            ?maxWidth: float,
            ?offsetX: float,
            ?offsetY: float,
            ?rotate: float,
            ?align: ApexYAxis.labels.align,
            ?padding: float,
            ?style: ApexYAxis.labels.style
        ) =

        member val formatter : U2<string, array<string>> = nativeOnly with get, set
        member val show : bool  = nativeOnly with get, set
        member val showDuplicates : bool  = nativeOnly with get, set
        member val minWidth : float  = nativeOnly with get, set
        member val maxWidth : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val rotate : float  = nativeOnly with get, set
        member val align : ApexYAxis.labels.align  = nativeOnly with get, set
        member val padding : float  = nativeOnly with get, set
        member val style : ApexYAxis.labels.style  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type axisBorder
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?color: string,
            ?width: float,
            ?offsetX: float,
            ?offsetY: float
        ) =

        member val show : bool  = nativeOnly with get, set
        member val color : string  = nativeOnly with get, set
        member val width : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type axisTicks
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?color: string,
            ?width: float,
            ?offsetX: float,
            ?offsetY: float
        ) =

        member val show : bool  = nativeOnly with get, set
        member val color : string  = nativeOnly with get, set
        member val width : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type title
        [<ParamObject; Emit("$0")>]
        (
            ?text: string,
            ?rotate: float,
            ?offsetX: float,
            ?offsetY: float,
            ?style: ApexYAxis.title.style
        ) =

        member val text : string  = nativeOnly with get, set
        member val rotate : float  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set
        member val offsetY : float  = nativeOnly with get, set
        member val style : ApexYAxis.title.style  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type crosshairs
        [<ParamObject; Emit("$0")>]
        (
            ?show: bool,
            ?position: string,
            ?stroke: ApexYAxis.crosshairs.stroke
        ) =

        member val show : bool  = nativeOnly with get, set
        member val position : string  = nativeOnly with get, set
        member val stroke : ApexYAxis.crosshairs.stroke  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tooltip
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?offsetX: float
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val offsetX : float  = nativeOnly with get, set

    module labels =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type align =
            | left
            | center
            | right

        [<Global>]
        [<AllowNullLiteral>]
        type style
            [<ParamObject; Emit("$0")>]
            (
                ?colors: U2<string, array<string>>,
                ?fontSize: string,
                ?fontWeight: U2<string, float>,
                ?fontFamily: string,
                ?cssClass: string
            ) =

            member val colors : U2<string, array<string>>  = nativeOnly with get, set
            member val fontSize : string  = nativeOnly with get, set
            member val fontWeight : U2<string, float>  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set
            member val cssClass : string  = nativeOnly with get, set

    module title =

        [<Global>]
        [<AllowNullLiteral>]
        type style
            [<ParamObject; Emit("$0")>]
            (
                ?color: string,
                ?fontSize: string,
                ?fontWeight: U2<string, float>,
                ?fontFamily: string,
                ?cssClass: string
            ) =

            member val color : string  = nativeOnly with get, set
            member val fontSize : string  = nativeOnly with get, set
            member val fontWeight : U2<string, float>  = nativeOnly with get, set
            member val fontFamily : string  = nativeOnly with get, set
            member val cssClass : string  = nativeOnly with get, set

    module crosshairs =

        [<Global>]
        [<AllowNullLiteral>]
        type stroke
            [<ParamObject; Emit("$0")>]
            (
                ?color: string,
                ?width: float,
                ?dashArray: float
            ) =

            member val color : string  = nativeOnly with get, set
            member val width : float  = nativeOnly with get, set
            member val dashArray : float  = nativeOnly with get, set

module ApexGrid =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type position =
        | front
        | back

    [<Global>]
    [<AllowNullLiteral>]
    type xaxis
        [<ParamObject; Emit("$0")>]
        (
            ?lines: ApexGrid.xaxis.lines
        ) =

        member val lines : ApexGrid.xaxis.lines  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type yaxis
        [<ParamObject; Emit("$0")>]
        (
            ?lines: ApexGrid.yaxis.lines
        ) =

        member val lines : ApexGrid.yaxis.lines  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type row
        [<ParamObject; Emit("$0")>]
        (
            ?colors: array<string>,
            ?opacity: float
        ) =

        member val colors : array<string>  = nativeOnly with get, set
        member val opacity : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type column
        [<ParamObject; Emit("$0")>]
        (
            ?colors: array<string>,
            ?opacity: float
        ) =

        member val colors : array<string>  = nativeOnly with get, set
        member val opacity : float  = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type padding
        [<ParamObject; Emit("$0")>]
        (
            ?top: float,
            ?right: float,
            ?bottom: float,
            ?left: float
        ) =

        member val top : float  = nativeOnly with get, set
        member val right : float  = nativeOnly with get, set
        member val bottom : float  = nativeOnly with get, set
        member val left : float  = nativeOnly with get, set

    module xaxis =

        [<Global>]
        [<AllowNullLiteral>]
        type lines
            [<ParamObject; Emit("$0")>]
            (
                ?show: bool,
                ?offsetX: float,
                ?offsetY: float
            ) =

            member val show : bool  = nativeOnly with get, set
            member val offsetX : float  = nativeOnly with get, set
            member val offsetY : float  = nativeOnly with get, set

    module yaxis =

        [<Global>]
        [<AllowNullLiteral>]
        type lines
            [<ParamObject; Emit("$0")>]
            (
                ?show: bool,
                ?offsetX: float,
                ?offsetY: float
            ) =

            member val show : bool  = nativeOnly with get, set
            member val offsetX : float  = nativeOnly with get, set
            member val offsetY : float  = nativeOnly with get, set

module ApexTheme =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type mode =
        | light
        | dark

    [<Global>]
    [<AllowNullLiteral>]
    type monochrome
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?color: string,
            ?shadeTo: ApexTheme.monochrome.shadeTo,
            ?shadeIntensity: float
        ) =

        member val enabled : bool  = nativeOnly with get, set
        member val color : string  = nativeOnly with get, set
        member val shadeTo : ApexTheme.monochrome.shadeTo  = nativeOnly with get, set
        member val shadeIntensity : float  = nativeOnly with get, set

    module monochrome =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type shadeTo =
            | light
            | dark
