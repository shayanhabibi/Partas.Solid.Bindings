module rec Glutinum.ZagJs.Accordion

open Fable.Core
open Fable.Core.JsInterop
open System

[<AllowNullLiteral>]
[<Interface>]
type ValueChangeDetails =
    abstract member value: ResizeArray<string> with get, set

[<AllowNullLiteral>]
[<Interface>]
type FocusChangeDetails =
    abstract member value: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ElementIds =
    abstract member root: string option with get, set
    abstract member item: value: string -> string
    abstract member itemContent: value: string -> string
    abstract member itemTrigger: value: string -> string

[<JS.Pojo>]
type AccordionProps
    (
        ?ids: ElementIds option,
        ?multiple: bool option,
        ?collapsible: bool option,
        ?value: ResizeArray<string> option,
        ?defaultValue: ResizeArray<string> option,
        ?disabled: bool option,
        ?onValueChange: (ValueChangeDetails -> unit) option,
        ?onFocusChange: (FocusChangeDetails -> unit) option,
        ?orientation: AccordionProps.orientation option,
        ?dir: DirectionProperty.dir,
        ?id: string,
        ?getRootNode: (unit -> obj)
    ) =
    /// <summary>
    /// The ids of the elements in the accordion. Useful for composition.
    /// </summary>
    [<DefaultValue>]
    val mutable ids: ElementIds option

    /// <summary>
    /// Whether multiple accordion items can be expanded at the same time.
    /// </summary>
    [<DefaultValue>]
    val mutable multiple: bool option

    /// <summary>
    /// Whether an accordion item can be closed after it has been expanded.
    /// </summary>
    [<DefaultValue>]
    val mutable collapsible: bool option

    /// <summary>
    /// The controlled value of the expanded accordion items.
    /// </summary>
    [<DefaultValue>]
    val mutable value: ResizeArray<string> option

    /// <summary>
    /// The initial value of the expanded accordion items.
    /// Use when you don't need to control the value of the accordion.
    /// </summary>
    [<DefaultValue>]
    val mutable defaultValue: ResizeArray<string> option

    /// <summary>
    /// Whether the accordion items are disabled
    /// </summary>
    [<DefaultValue>]
    val mutable disabled: bool option

    /// <summary>
    /// The callback fired when the state of expanded/collapsed accordion items changes.
    /// </summary>
    [<DefaultValue>]
    val mutable onValueChange: (ValueChangeDetails -> unit) option

    /// <summary>
    /// The callback fired when the focused accordion item changes.
    /// </summary>
    [<DefaultValue>]
    val mutable onFocusChange: (FocusChangeDetails -> unit) option

    /// <summary>
    /// The orientation of the accordion items.
    /// </summary>
    [<DefaultValue>]
    val mutable orientation: AccordionProps.orientation option

    /// <summary>
    /// The document's text/writing direction.
    /// </summary>
    [<DefaultValue>]
    val mutable dir: DirectionProperty.dir

    /// <summary>
    /// The unique identifier of the machine.
    /// </summary>
    [<DefaultValue>]
    val mutable id: string

    /// <summary>
    /// A root node to correctly resolve document in custom environments. E.x.: Iframes, Electron.
    /// </summary>
    [<DefaultValue>]
    val mutable getRootNode: (unit -> obj)

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PropsWithDefault =
    | multiple
    | collapsible
    | orientation

[<AllowNullLiteral>]
[<Interface>]
type AccordionSchema =
    abstract member state: AccordionSchema.state with get, set
    abstract member props: AccordionProps with get, set
    abstract member context: AccordionSchema.context with get, set
    abstract member computed: AccordionSchema.computed with get, set
    abstract member action: string with get, set
    abstract member guard: string with get, set
    abstract member effect: string with get, set
    abstract member event: obj with get, set

type AccordionService = AccordionSchema

type AccordionMachine = AccordionSchema

[<JS.Pojo>]
type ItemProps(?value: string, ?disabled: bool option) =
    /// <summary>
    /// The value of the accordion item.
    /// </summary>
    [<DefaultValue>]
    val mutable value: string

    /// <summary>
    /// Whether the accordion item is disabled.
    /// </summary>
    [<DefaultValue>]
    val mutable disabled: bool option

[<JS.Pojo>]
type ItemState(?expanded: bool, ?focused: bool, ?disabled: bool) =
    /// <summary>
    /// Whether the accordion item is expanded.
    /// </summary>
    [<DefaultValue>]
    val mutable expanded: bool

    /// <summary>
    /// Whether the accordion item is focused.
    /// </summary>
    [<DefaultValue>]
    val mutable focused: bool

    /// <summary>
    /// Whether the accordion item is disabled.
    /// </summary>
    [<DefaultValue>]
    val mutable disabled: bool

[<AllowNullLiteral>]
[<Interface>]
type AccordionApi =
    /// <summary>
    /// The value of the focused accordion item.
    /// </summary>
    abstract member focusedValue: string option with get, set
    /// <summary>
    /// The value of the accordion
    /// </summary>
    abstract member value: ResizeArray<string> with get, set
    /// <summary>
    /// Sets the value of the accordion.
    /// </summary>
    abstract member setValue: (ResizeArray<string> -> unit) with get, set
    /// <summary>
    /// Gets the state of an accordion item.
    /// </summary>
    abstract member getItemState: props: ItemProps -> ItemState
    abstract member getRootProps: unit -> obj
    abstract member getItemProps: props: ItemProps -> obj
    abstract member getItemContentProps: props: ItemProps -> obj
    abstract member getItemTriggerProps: props: ItemProps -> obj
    abstract member getItemIndicatorProps: props: ItemProps -> obj


module AccordionProps =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type orientation =
        | horizontal
        | vertical

module AccordionSchema =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type state =
        | idle
        | focused

    [<Global>]
    [<AllowNullLiteral>]
    type context
        [<ParamObject; Emit("$0")>]
        (
            value: ResizeArray<string>,
            ?focusedValue: string
        ) =

        member val value : ResizeArray<string> = nativeOnly with get, set
        member val focusedValue : string option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type computed
        [<ParamObject; Emit("$0")>]
        (
            isHorizontal: bool
        ) =

        member val isHorizontal : bool = nativeOnly with get, set
