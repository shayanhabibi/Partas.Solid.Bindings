/// <summary>
/// Functional wrapper to make stories. It makes the process of making stories far more enjoyable, but it requires
/// the SolidTypeComponents to have their properties defined as properties. It is imperative to understand that
/// the only true property definition under the hood seems to be using
/// <c>[&lt;DefaultValue>] val mutable foo: obj</c>.
/// </summary>
module Partas.Solid.Storybook.Wrapper

open Fable.Core.DynamicExtensions
open System.Runtime.CompilerServices
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open FsToolkit.ErrorHandling


module _Helpers =
    let inline getPath map = Experimental.nameofLambda map
open _Helpers

module Test =
    [<ImportMember("storybook/test")>]
    let fn () = jsNative
    [<ImportMember("storybook/actions")>]
    let action(value: string): ('T -> unit) = jsNative

type TableInfo =
    | Summary of string
    | Detail of string
    | SummaryDetail of summary: string * detail: string
    member this.build() =
        match this with
        | Summary value -> createObj [ "summary" ==> value ]
        | Detail value -> createObj [ "detail" ==> value ]
        | SummaryDetail(summary,detail) -> createObj [ "summary" ==> summary; "detail" ==> detail ]
type Table = {
    Category: string
    DefaultValue: TableInfo option
    Disable: bool
    SubCategory: string
    Type: TableInfo option
} with
    static member inline init = {
        Category = ""
        DefaultValue = None
        Disable = false
        SubCategory = ""
        Type = None
    }
    [<SolidComponent>]
    member this.build() =
        createObj [
            "category" ==> this.Category
            if this.DefaultValue.IsSome then
                "defaultValue" ==> this.DefaultValue.Value.build()
            "disable" ==> this.Disable
            "subcategory" ==> this.SubCategory
            if this.Type.IsSome then
                "type" ==> this.Type.Value.build()
        ]
type ControlType<'Value> = {
    Type: ControlType
    Accept: string
    LabelsFn: ('Value -> obj)
    Labels: ('Value * obj) list
    Max: 'Value
    Min: 'Value
    PresetColors: string list
    Step: 'Value
} with
    static member inline init: ControlType<'Value> = {
        Type = JS.undefined
        Accept = ""
        LabelsFn = JS.undefined
        Labels = []
        Max = JS.undefined
        Min = JS.undefined
        PresetColors = []
        Step = JS.undefined
    }
    static member inline create controlType: ControlType<'Value> =
        { ControlType.init with Type = controlType }
    member inline this.build() =
        let builder = createEmpty<obj>
        let typ = this.Type |> Option.ofNull
        let accept = this.Accept |> Option.ofNull
        let labelsFn = this.LabelsFn |> Option.ofNull
        let labels = if this.Labels.IsEmpty then None else Some this.Labels
        let max,min = this.Max |> Option.ofNull, this.Min |> Option.ofNull
        let presetColors = if this.PresetColors.IsEmpty then None else Some this.PresetColors
        let step = this.Step |> Option.ofNull
        for key,value in [
            "type",unbox<obj option> typ
            nameof accept,!!accept
            nameof max,!!max
            nameof min,!!min
            nameof presetColors,!!presetColors
            nameof step, !!step
        ] do
            if value.IsSome then builder[key] <- value
        if labels.IsSome then
            builder["labels"] <- labels
            builder, None
        else
            builder, labelsFn
            
        

type ArgType<'Value> = {
    Control: ControlType<'Value>
    Description: string
    Conditional: obj
    Mapping: ('Value -> obj) list
    Name: string
    Options: 'Value list
    Table: Table
    Type: obj
} with
    [<SolidComponent>]
    static member init() = {
        Control = JS.undefined
        Description = ""
        Conditional = JS.undefined
        Mapping = []
        Name = ""
        Options = []
        Table = JS.undefined
        Type = JS.undefined
    }
    [<SolidComponent>]
    member this.build() =
        createObj [
            "control" ==> (this.Control.build() |> fun (o,fn) ->
                    if fn.IsSome && this.Options.Length > 0 then
                        o["labels"] <- this.Options |> List.map fn.Value |> List.toArray
                    o
                )
            "description" ==> this.Description
            "conditional" ==> this.Conditional
            "mapping" ==> this.Mapping
            "options" ==> (this.Options |> List.toArray)
            "table" ==> if !!this.Table then this.Table.build() else JS.undefined
            "type" ==> this.Type
        ]
and [<Erase>] PropertyKeyArgType<'T> = private PropertyKeyArgType of string * ArgType<obj> with
    member inline this.Key = unbox<string * obj>(this) |> fst
    member inline this.Matches (key: 'T -> 'Value): bool = getPath key = this.Key
    member inline this.Matches(key: PropertyKey<'T, 'Value>): bool = !!key = this.Key
    member inline this.Matches(keyValue: PropertyKeyValue<'T>): bool = keyValue.Key = this.Key
    member inline this.Value (key: 'T -> 'Value) =
        if this.Matches key then
            unbox<string * ArgType<'Value>>(this) |> snd |> Some
        else None
    member inline this.Value(key: PropertyKey<'T, 'Value>) =
        if this.Matches key then
            unbox<string * ArgType<'Value>>(this) |> snd |> Some
        else None
and [<Erase>] PropertyKey<'T, 'Value> = private PropertyKey of string with
    static member inline op_Equals(x: PropertyKey<'T, 'Value>, y: string) = !!x = y
    static member inline op_Equals(x: PropertyKey<'T, 'Value>, y: 'T -> 'Value) = getPath y = !!x
    static member inline op_MinusMinusGreater(x: PropertyKey<'T, 'Value>, y: 'Value) = (!!x ==> y) |> unbox<PropertyKeyValue<'T>>
    static member inline op_MinusMinusGreater(x: PropertyKey<'T, 'Value>, y: ArgType<'Value>) = unbox<PropertyKeyArgType<'T>>(x,y.build())
/// <summary>
/// Erased union for an objects key value pair. 
/// </summary>
and [<Erase>] PropertyKeyValue<'T> = private PropertyKeyValue of string * obj with
    /// <summary>
    /// Retrieves the property name/key
    /// </summary>
    member inline this.Key = unbox<string * obj>(this) |> fst
    /// <summary>
    /// Tests if this key value pair matches the property defined by the access path provided
    /// </summary>
    /// <param name="key">Property key represented by the access path of the object to the property</param>
    member inline this.Matches (key: 'T -> 'Value): bool = getPath key = this.Key
    /// <summary>
    /// Retrieves the value of the property if it matches the key mapping provided (as it infers the type of the
    /// value and simultaneously tests if it's the requested property)
    /// </summary>
    /// <param name="key"></param>
    member inline this.Value (key: 'T -> 'Value) =
        if this.Matches(key)
        then Some (this |> unbox<string * 'Value> |> snd)
        else None
    static member inline makeKey(handler: 'T -> 'Value): PropertyKey<'T, 'Value> = getPath handler |> unbox

module ArgType =
    [<SolidComponent>]
    let setName name argType = { argType with Name = name }
    [<SolidComponent>]
    let setControl control argType = { argType with Control = control }
    [<SolidComponent>]
    let setDescription description argType = { argType with Description = description }
    [<SolidComponent>]
    let setConditional conditional argType = { argType with Conditional = conditional }
    [<SolidComponent>]
    let setMapping mapping argType = { argType with Mapping = mapping }
    [<SolidComponent>]
    let setOptions options argType = { argType with Options = options }
    [<SolidComponent>]
    let setTable table argType = { argType with Table = table }
    [<SolidComponent>]
    let setType typ argType: ArgType<_> = { argType with Type = typ }

type Storybook<'T when 'T :> HtmlElement> =
    {
        Component: TagValue
        SubComponents: TagValue list
        Args: PropertyKeyValue<'T> list
        ArgTypes: PropertyKeyArgType<'T> list
        Render: ('T -> obj) option
        Stories: string list
        Parameters: obj list
        Tags: string list
    }
    
    static member init with get() = {
        Component = JS.undefined
        SubComponents = []
        Args = []
        ArgTypes = []
        Render = None
        Stories = []
        Parameters = []
        Tags = []
    }
    member inline _.property(handler: 'T -> 'Value): PropertyKey<'T, 'Value> = getPath handler |> unbox
    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
    member inline this.buildArgs=
        createObj <| unbox<(string*obj)list>(this.Args)
    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
    member inline this.buildArgTypes =
        unbox<(string * obj)[]> (this.ArgTypes) |> createObj
    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
    member inline this.buildParameters =
        unbox<(string * obj) list> this.Parameters |> createObj
    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
    member inline this.buildSubComponents =
        emitJsExpr (this.SubComponents|> List.toArray) "{...$0}"
    [<SolidComponent>]
    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
    member this._build() =
        let (build:obj) = createEmpty
        build["component"] <- this.Component
        build["args"] <- this.buildArgs
        build["argTypes"] <- this.buildArgTypes
        if this.Render.IsSome then
            build["render"] <- this.Render.Value
        if this.Stories.Length > 0 then
            build["includeStories"] <- this.Stories |> List.toArray
        build["parameters"] <- this.buildParameters
        build["tags"] <- this.Tags |> List.toArray
        build["subcomponents"] <- this.buildSubComponents
        build
    member inline this.build =
        emitJsExpr (this._build()) "{...$0}"
    [<SolidComponent>]
    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
    member this._buildStory() =
        let (build: obj) = createEmpty
        build["args"] <- this.buildArgs
        build["parameters"] <- this.buildParameters
        build["tags"] <- this.Tags |> List.toArray
        build
    member inline this.buildStory =
        emitJsExpr (this._buildStory()) "{...$0}"
        

module Storybook =
    /// <summary>
    /// Creates a Storybook builder for the provided component
    /// </summary>
    /// <param name="tag">A HtmlElement constructor</param>
    /// <example><code>
    /// // Storybook&lt;button>
    /// let storyBuilder = Storybook.create button
    /// </code></example>
    let inline create<'T when 'T :> HtmlElement> ([<InlineIfLambda>] tag: unit -> 'T): Storybook<'T> =
        { unbox<Storybook<'T>>(Storybook<'T>.init) with Component = !@tag }


let inline getTypeName<'T when 'T :> HtmlElement> (value: 'T) = Experimental.nameof typeof<'T>
