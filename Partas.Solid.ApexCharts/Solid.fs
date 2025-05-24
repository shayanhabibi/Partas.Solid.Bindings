namespace Partas.Solid.ApexCharts

open Partas.Solid
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types
open Partas.Solid.Experimental.U

[<Import("SolidApexCharts", "solid-apexcharts")>]
type SolidApexCharts() =
    inherit VoidNode()

    [<Erase>]
    member val type': ApexChartType = jsNative with get, set

    [<Erase>]
    member val options: ApexCharts.Options = jsNative with get, set

    [<Erase>]
    member val series: U3<AxisChartSeries, float array, AxisChartSeries array> = jsNative with get, set

    [<Erase>]
    member val width: U2<int, string> = jsNative with get, set

    [<Erase>]
    member val height: U2<int, string> = jsNative with get, set

    [<Erase>]
    member _.onAnimationEnd
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onBeforeMount
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onMounted
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onUpdated
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onMouseMove
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onMouseLeave
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onClick
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onXAxisLabelClick
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onLegendClick
        with set (chart: ApexCharts, ?seriesIndex: int, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onMarkerClick
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onSelection
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onDataPointSelection
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onDataPointMouseEnter
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onDataPointMouseLeave
        with set (e: MouseEvent, ?chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onBeforeZoom
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onBeforeResetZoom
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onZoomed
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onScrolled
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()

    [<Erase>]
    member _.onBrushScrolled
        with set (chart: ApexCharts, ?options: ApexCharts.Options): unit = ()
