namespace Partas.Solid.ChartJs

open Fable.Core
open System

module private Helpers =
    let [<Literal>] path = "chart.js"

module rec Interfaces =
    [<AllowNullLiteral; Interface>]
    type ChartComponent =
        abstract member defaultRoutes: obj with get,set
        abstract member defaults: obj with get,set
        abstract member id: string with get,set
        abstract member afterRegister: (unit -> unit) with get,set
        abstract member afterUnregister: (unit -> unit) with get,set
        abstract member beforeRegister: (unit -> unit) with get,set
        abstract member beforeUnregister: (unit -> unit) with get,set
    [<AllowNullLiteral; Interface>]
    type ChartData<'Type, 'Data, 'Label when 'Type :> ChartType and 'Data :> DefaultDataPoint<'Type>> =
        abstract member datasets: ChartDataset<'Type, 'Data>[] with get,set
        abstract member labels: 'Label[] with get,set
        abstract member xLabels: 'Label[] with get,set
        abstract member yLabels: 'Label[] with get,set
    [<AllowNullLiteral; Interface>]
    type ChartItem = interface end
    
    [<AllowNullLiteral; Interface>]
    type DefaultDataPoint<'T> = interface end
    
    [<AllowNullLiteral; Interface>]
    type ChartDataset<'Type, 'Data when 'Type :> ChartType and 'Data :> DefaultDataPoint<'Type>> =
        abstract member data: 'Data with get,set
        abstract member ``type``: 'Type with get,set
    
    [<AllowNullLiteral; Interface>]
    type ChartOptions<'Type when 'Type :> ChartType> =
        // inherit ParsingOptions
        // inherit AnimationOptions<'Type>
        abstract member animation: (obj -> unit) with get,set
        // abstract member animations: AnimationsSpec<'Type> with get,set
        abstract member aspectRatio: int with get,set
        abstract member backgroundColor: obj with get,set
        abstract member borderColor: obj with get,set
    [<AllowNullLiteral; Interface>]
    type Plugin = interface end
    [<AllowNullLiteral; Interface>]
    type ChartType = interface end
    [<AllowNullLiteral; Interface>]
    type ChartTypeRegistry = interface end
    [<AllowNullLiteral; Interface>]
    type TooltipModel = interface end
    
    [<AllowNullLiteral; Interface>]
    type ArcElement = interface end
    [<AllowNullLiteral; Interface>]
    type BarController = interface end
    [<AllowNullLiteral; Interface>]
    type BarElement = interface end
    [<AllowNullLiteral; Interface>]
    type BubbleController = interface end
    [<AllowNullLiteral; Interface>]
    type CategoryScale = interface end
    [<AllowNullLiteral; Interface>]
    type Chart = interface end
    [<AllowNullLiteral; Interface>]
    type Colors = interface end
    [<AllowNullLiteral; Interface>]
    type DoughnutController = interface end
    [<AllowNullLiteral; Interface>]
    type Filler = interface end
    [<AllowNullLiteral; Interface>]
    type Legend = interface end
    [<AllowNullLiteral; Interface>]
    type LinearScale = interface end
    [<AllowNullLiteral; Interface>]
    type LineController = interface end
    [<AllowNullLiteral; Interface>]
    type LineElement = interface end
    [<AllowNullLiteral; Interface>]
    type PieController = interface end
    [<AllowNullLiteral; Interface>]
    type PointElement = interface end
    [<AllowNullLiteral; Interface>]
    type PolarAreaController = interface end
    [<AllowNullLiteral; Interface>]
    type RadarController = interface end
    [<AllowNullLiteral; Interface>]
    type RadialLinearScale = interface end
    [<AllowNullLiteral; Interface>]
    type ScatterController = interface end
    [<AllowNullLiteral; Interface>]
    type Tooltip = interface end




