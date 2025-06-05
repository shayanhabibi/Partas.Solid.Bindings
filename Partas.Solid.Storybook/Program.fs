namespace Partas.Solid.Storybook

open System.Text.RegularExpressions
open Fable.Core.JsInterop
open Fable.Core
open Partas.Solid
open Partas.Solid.Experimental.U

[<Fable.Core.Erase>]
module ArgType =
    [<Fable.Core.Erase>]
    module Table =
        [<JS.Pojo>]
        type Value
            (
                ?summary: string,
                ?detail: string
            ) =
            member val summary : string = nativeOnly with get, set
            member val detail : string = nativeOnly with get, set
    [<JS.Pojo>]
    type Table
        (
            ?category: string,
            ?defaultValue: Table.Value,
            ?disable: bool,
            ?subcategory: string,
            ?``type``: Table.Value
        ) =
        /// Display the argType under a category heading, with the label specified by category.
        [<DefaultValue>] val mutable category: string
        /// The documented default value of the argType. summary is typically used for the value itself,
        /// while detail is used for additional information.
        [<DefaultValue>] val mutable defaultValue: Table.Value
        /// Set to true to remove the argType's row from the table.
        [<DefaultValue>] val mutable disable: bool
        /// Set to true to indicate that the argType is read-only.
        [<DefaultValue>] val mutable readonly: bool
        /// Display the argType under a subcategory heading (which displays under the [category] heading),
        /// with the label specified by subcategory.
        [<DefaultValue>] val mutable subcategory: string
        /// <summary>
        /// The documented type of the argType. summary is typically used for the type itself, while detail
        /// is used for additional information.<br/>
        /// If you need to specify the actual, semantic type, you should use type, instead.
        /// </summary>
        [<DefaultValue>] val mutable ``type``: Table.Value

[<Erase>]
module SBScalarType =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type Name =
        | Boolean
        | String
        | Number
        | Function
        | Symbol
[<Erase>]
type Storybook =
    [<Import("fn", "storybook/test")>]
    static member eventHandler: (obj -> unit) = jsNative
    [<Import("fn", "storybook/test")>]
    static member fn: (obj -> unit) = jsNative
    [<Import("action", "storybook/actions")>]
    static member action(value: string): ('T -> unit) = jsNative
    
[<StringEnum>]
type StorybookLayout =
    | Centered
    | Fullscreen
    | Padded
 
type Meta<'T> =
    member inline _.make (value: Story<'T> list): Story<'T> = createObj !!value |> unbox
and Meta =
    static member inline make<'T>(values: Meta<'T> list): Meta<'T> = unbox <| createObj !!values 
    /// <summary>
    /// Create Arg key value pairs by using the <c>&lt;==</c> operator.<br/>
    /// The Key value is a mapping of the component to the attribute/argument.
    /// </summary>
    /// <example><code>
    /// [&lt;ExportDefault&gt;]
    /// let private meta: Meta&lt;button&gt; = Meta.make [
    ///     Meta.arg = [
    ///         _.class' &lt;== "some-class"
    ///     ]
    /// ]
    /// </code></example>
    static member inline args<'T>(values: Args<'T> list): Meta<'T> = "args" ==>  (createObj !!values) |> unbox
    static member inline parameters<'T>(values: Parameters<'T> list): Meta<'T> = "parameters" ==> (createObj !!values) |> unbox
    static member inline decorators<'T>(values: Decorator<'T> list): Meta<'T> = "decorators" ==> (createObj !!values) |> unbox
    static member inline loaders<'T>(values: Loader<'T> list): Meta<'T> = "loaders" ==> (createObj !!values) |> unbox
    static member inline render<'T>(value: obj -> HtmlElement): Meta<'T> = "render" ==> value |> unbox
    static member inline tags<'T>(value: string array): Meta<'T> = "tags" ==> value |> unbox
    static member inline mount<'T>(value: obj -> HtmlElement): Meta<'T> = "mount" ==> value |> unbox
    /// <summary>
    /// Create ArgType key value pairs by using the <c>&lt;==&gt;</c> operator.<br/>
    /// The Key value is a mapping of the component to the attribute/argument.
    /// </summary>
    /// <example><code>
    /// [&lt;ExportDefault&gt;]
    /// let private meta: Meta&lt;button&gt; = Meta.make [
    ///     Meta.argTypes = [
    ///         _.class' &lt;==> ArgType()
    ///     ]
    /// ]
    /// </code></example>
    static member inline argTypes<'T>(values: ArgTypes<'T> list): Meta<'T> = "argTypes" ==> (createObj !!values) |> unbox
    static member inline title<'T>(value: string): Meta<'T> = "title" ==> value |> unbox
    static member inline id<'T>(value: string): Meta<'T> = "id" ==> value |> unbox
    static member inline includeStories<'T>(value: string array): Meta<'T> = "includeStories" ==> value |> unbox
    static member inline includeStories<'T>(value: Regex): Meta<'T> = "includeStories" ==> value |> unbox
    static member inline includeStories<'T>(value: Regex array): Meta<'T> = "includeStories" ==> value |> unbox
    static member inline excludeStories<'T>(value: string array): Meta<'T> = "excludeStories" ==> value |> unbox
    static member inline excludeStories<'T>(value: Regex): Meta<'T> = "excludeStories" ==> value |> unbox
    static member inline excludeStories<'T>(value: Regex array): Meta<'T> = "excludeStories" ==> value |> unbox
    static member inline component'<'T>(value: unit -> 'T): Meta<'T> = "component" ==> !@value |> unbox
    static member inline component'<'T>(value: TagValue): Meta<'T> = "component" ==> value |> unbox
    static member inline subcomponents<'T>(value: (string * TagValue) list): Meta<'T> = "subcomponents" ==> createObj !!value |> unbox
    static member inline play<'T>(value: unit -> unit): Meta<'T> = "play" ==> value |> unbox
    static member inline globals<'T>(value: (string * obj) list): Meta<'T> = "globals" ==> createObj value |> unbox
and Decorator<'T> = interface end
and Loader<'T> = interface end
and Story<'T> = interface end
and Story =
    static member inline decorators<'T>(values: Decorator<'T> list): Story<'T> = "decorators" ==> createObj !!values |> unbox
    static member inline parameters<'T>(values: Parameters<'T> list): Story<'T> = "parameters" ==> createObj !!values |> unbox
    static member inline args<'T>(values: Args<'T> list): Story<'T> = "args" ==> createObj !!values |> unbox
    static member inline argTypes<'T>(values: ArgTypes<'T> list): Story<'T> = "argTypes" ==> createObj !!values |> unbox
    static member inline loaders<'T>(values: Loader<'T> list): Story<'T> = "loaders" ==> createObj !!values |> unbox
    static member inline render<'T>(value: obj -> HtmlElement): Story<'T> = "render" ==> createObj !!value |> unbox
    static member inline tags<'T>(values: string[]): Story<'T> = "tags" ==> values |> unbox
    static member inline mount<'T>(value: obj -> obj): Story<'T> = "mount" ==> value |> unbox
and [<Erase>] Args<'T> =
    static member inline make (key: string) (value: obj): Args<'T> = unbox(key ==> value)
and Parameters<'T> = interface end
and Parameters =
    static member inline make<'T>(key: string,value: obj): Parameters<'T> = (key,value) |> unbox
    static member inline layout<'T>(value: StorybookLayout): Parameters<'T> = "layout" ==> value |> unbox
and ArgTypes<'T> =
    static member inline make<'T> (key: string) (value: ArgType<'T>): ArgTypes<'T> = unbox(key, value)


and [<StringEnum(CaseRules.KebabCase)>] ControlType =
    | Object
    | Boolean
    | Check
    | InlineCheck
    | Radio
    | InlineRadio
    | Select
    | MultiSelect
    | Number
    | Range
    | File
    | Color
    | Date
    | Text
    | [<CompiledValue(false)>] DoNotRender

and [<JS.Pojo>] Control(
        ``type``: ControlType,
        ?accept: string,
        ?labels: obj,
        ?max: U2<int,float>,
        ?min: U2<int,float>,
        ?presetColors: string[],
        ?step: U2<int,float>
    ) =
    /// <summary>
    /// Specifies the type of control used to change the arg value with the controls panel.<br/>
    /// <a href="https://storybook.js.org/docs/api/arg-types#controltype">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable ``type``: ControlType
    /// When type is 'file', you can specify the file types that are accepted. The value should be a string of comma-separated MIME types.
    [<DefaultValue>] val mutable accept: string
    /// Map options to labels. labels doesn't have to be exhaustive. If an option is not in the object's keys, it's used verbatim.
    [<DefaultValue>] val mutable labels: obj
    /// When type is 'number' or 'range', sets the maximum allowed value.
    [<DefaultValue>] val mutable max: U2<int,float>
    /// When type is 'number' or 'range', sets the minimum allowed value.
    [<DefaultValue>] val mutable min: U2<int,float>
    /// When type is 'color', defines the set of colors that are available in addition to the general color picker.
    /// The values in the array should be valid CSS color values.
    [<DefaultValue>] val mutable presetColors: string[]
    /// When type is 'number' or 'range', sets the granularity allowed when incrementing/decrementing the value.
    [<DefaultValue>] val mutable step: U2<int,float>
/// <summary>
/// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
/// </summary>
and [<JS.Pojo>] Conditional(?arg: string, ?truthy: bool option, ?exists: bool, ?eq: obj, ?neq: obj, ?``global``: string) =
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable arg: string
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable truthy: bool
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable exists: bool
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable eq: obj
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable neq: obj
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs</a>
    /// </summary>
    [<DefaultValue>] val mutable ``global``: string

and [<JS.Pojo>] ArgType<'T>
    (
        ?control: Control,
        ?description: string,
        ?``if``: Conditional,
        ?mapping: obj,
        ?name: string,
        ?options: obj array,
        ?table: ArgType.Table,
        ?``type``: U2<SBType, obj>
    ) =
    [<DefaultValue>] val mutable control: Control option
    /// Describe the arg. (If you intend to describe the type of the arg, you should use table.type, instead.)
    [<DefaultValue>] val mutable description: string option
    /// <summary>
    /// <a href="https://storybook.js.org/docs/api/arg-types#if">See the docs.</a>
    /// </summary>
    [<DefaultValue>] val mutable ``if``: Conditional option
    /// <summary>
    /// Map options to values.<br/>
    /// When dealing with non-primitive values, you'll notice that you'll run into some limitations. The most obvious issue is that not every value can be represented as part of the args param in the URL, losing the ability to share and deeplink to such a state. Beyond that, complex values such as JSX cannot be synchronized between the manager (e.g., Controls panel) and the preview (your story).
    /// <br/><c>mapping</c> doesn't have to be exhaustive. If the currently selected option is not listed, it's used verbatim. Can be used with control.labels.
    /// </summary>
    /// <remarks><a href="https://storybook.js.org/docs/api/arg-types#mapping">See the docs</a></remarks>
    [<DefaultValue>] val mutable mapping: obj option
    /// The argTypes object uses the name of the arg as the key. By default, that key is used when displaying the
    /// argType in Storybook. You can override the displayed name by specifying a name property.
    [<DefaultValue>] val mutable name: string option
    /// If the arg accepts a finite set of values, you can specify them with options.
    /// If those values are complex, like JSX elements, you can use mapping to map them to string values.
    /// You can use control.labels to provide custom labels for the options.
    [<DefaultValue>] val mutable options: obj array option
    /// Specify how the arg is documented in the ArgTypes doc block, Controls doc block, and Controls panel.
    [<DefaultValue>] val mutable table: ArgType.Table option
    /// <summary>
    /// Specifies the semantic type of the argType. When an argType is inferred, the information from the various tools
    /// is summarized in this property, which is then used to infer other properties, like control and table.type.<br/><br/>
    /// If you only need to specify the documented type, you should use table.type, instead.
    /// </summary>
    [<DefaultValue>] val mutable ``type``: U2<SBType, obj> option

and [<JS.Pojo>] SBBaseType(?required: bool, ?raw: string) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
and [<JS.Pojo>] SBScalarType(?required: bool, ?raw: string, ?name: SBScalarType.Name) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: SBScalarType.Name
and [<JS.Pojo>] SBArrayType(?required: bool, ?raw: string, ?name: string, ?value: SBType) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: string
    [<DefaultValue>]
    val mutable value: SBType
and [<JS.Pojo>] SBObjectType(?required: bool, ?raw: string, ?name: string, ?value: obj) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: string
    [<DefaultValue>]
    val mutable value: obj
and [<JS.Pojo>] SBEnumType(?required: bool, ?raw: string, ?name: string, ?value: ResizeArray<U2<string, float>>) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: string
    [<DefaultValue>]
    val mutable value: string array
and [<JS.Pojo>] SBIntersectionType(?required: bool, ?raw: string, ?name: string, ?value: ResizeArray<SBType>) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: string
    [<DefaultValue>]
    val mutable value: ResizeArray<SBType>

and [<JS.Pojo>] SBUnionType(?required: bool, ?raw: string, ?name: string, ?value: obj array) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: string
    [<DefaultValue>]
    val mutable value: obj array
    
and [<JS.Pojo>] SBOtherType(?required: bool, ?raw: string, ?name: string, ?value: string) =
    [<DefaultValue>]
    val mutable required: bool
    [<DefaultValue>]
    val mutable raw: string
    [<DefaultValue>]
    val mutable name: string
    [<DefaultValue>]
    val mutable value: string
and SBType = U7<SBScalarType, SBEnumType, SBArrayType, SBObjectType, SBIntersectionType, SBUnionType, SBOtherType>

module SBObjectType =

    [<AllowNullLiteral>]
    [<Interface>]
    type value =
        [<EmitIndexer>]
        abstract member Item: key: string -> SBType with get, set
