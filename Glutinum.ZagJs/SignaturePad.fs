module rec Glutinum.ZagJs.SignaturePad


open Fable.Core
open Fable.Core.JsInterop
open System

[<AllowNullLiteral>]
[<Interface>]
type StrokeOptions =
    abstract member size: float option with get, set
    abstract member thinning: float option with get, set
    abstract member smoothing: float option with get, set
    abstract member streamline: float option with get, set
    abstract member easing: (float -> float) option with get, set
    abstract member simulatePressure: bool option with get, set
    abstract member start: StrokeOptions.start option with get, set
    abstract member ``end``: StrokeOptions.``end`` option with get, set
    abstract member last: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type StrokePoint =
    abstract member point: ResizeArray<float> with get, set
    abstract member pressure: float with get, set
    abstract member distance: float with get, set
    abstract member vector: ResizeArray<float> with get, set
    abstract member runningLength: float with get, set

module StrokeOptions =

    [<Global>]
    [<AllowNullLiteral>]
    type start
        [<ParamObject; Emit("$0")>]
        (
            ?cap: bool,
            ?taper: U2<float, bool>,
            ?easing: (float -> float)
        ) =

        member val cap : bool option = nativeOnly with get, set
        member val taper : U2<float, bool> option = nativeOnly with get, set
        member val easing : (float -> float) option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type ``end``
        [<ParamObject; Emit("$0")>]
        (
            ?cap: bool,
            ?taper: U2<float, bool>,
            ?easing: (float -> float)
        ) =

        member val cap : bool option = nativeOnly with get, set
        member val taper : U2<float, bool> option = nativeOnly with get, set
        member val easing : (float -> float) option = nativeOnly with get, set
[<AllowNullLiteral>]
[<Interface>]
type Point =
    abstract member x: float with get, set
    abstract member y: float with get, set
    abstract member pressure: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type DrawDetails =
    abstract member paths: ResizeArray<string> with get, set

[<AllowNullLiteral>]
[<Interface>]
type DrawingOptions =
    inherit StrokeOptions
    /// <summary>
    /// The color of the stroke.
    /// Note: Must be a valid CSS color string, not a css variable.
    /// </summary>
    abstract member fill: string option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DataUrlType =
    | [<CompiledName("image/png")>] imagepng
    | [<CompiledName("image/jpeg")>] imagejpeg
    | [<CompiledName("image/svg+xml")>] imagesvgxml

[<AllowNullLiteral>]
[<Interface>]
type DrawEndDetails =
    abstract member paths: ResizeArray<string> with get, set
    abstract member getDataUrl: DrawEndDetails.getDataUrl with get, set

[<AllowNullLiteral>]
[<Interface>]
type ElementIds =
    abstract member root: string option with get, set
    abstract member control: string option with get, set
    abstract member hiddenInput: string option with get, set
    abstract member label: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type IntlTranslations =
    abstract member clearTrigger: string with get, set
    abstract member control: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type SignaturePadProps =
    inherit DirectionProperty
    inherit CommonProperties
    /// <summary>
    /// The ids of the signature pad elements. Useful for composition.
    /// </summary>
    abstract member ids: ElementIds option with get, set
    /// <summary>
    /// The translations of the signature pad. Useful for internationalization.
    /// </summary>
    abstract member translations: IntlTranslations option with get, set
    /// <summary>
    /// Callback when the signature pad is drawing.
    /// </summary>
    abstract member onDraw: (DrawDetails -> unit) option with get, set
    /// <summary>
    /// Callback when the signature pad is done drawing.
    /// </summary>
    abstract member onDrawEnd: (DrawEndDetails -> unit) option with get, set
    /// <summary>
    /// The drawing options.
    /// </summary>
    abstract member drawing: DrawingOptions option with get, set
    /// <summary>
    /// Whether the signature pad is disabled.
    /// </summary>
    abstract member disabled: bool option with get, set
    /// <summary>
    /// Whether the signature pad is required.
    /// </summary>
    abstract member required: bool option with get, set
    /// <summary>
    /// Whether the signature pad is read-only.
    /// </summary>
    abstract member readOnly: bool option with get, set
    /// <summary>
    /// The name of the signature pad. Useful for form submission.
    /// </summary>
    abstract member name: string option with get, set
    /// <summary>
    /// The default paths of the signature pad.
    /// Use when you don't need to control the paths of the signature pad.
    /// </summary>
    abstract member defaultPaths: ResizeArray<string> option with get, set
    /// <summary>
    /// The controlled paths of the signature pad.
    /// </summary>
    abstract member paths: ResizeArray<string> option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PropsWithDefault =
    | drawing
    | translations

[<AllowNullLiteral>]
[<Interface>]
type PrivateContext =
    /// <summary>
    /// The layers of the signature pad. A layer is a snapshot of a single stroke interaction.
    /// </summary>
    abstract member paths: ResizeArray<string> with get, set
    /// <summary>
    /// The current layer points.
    /// </summary>
    abstract member currentPoints: ResizeArray<Point> with get, set
    /// <summary>
    /// The current stroke path
    /// </summary>
    abstract member currentPath: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ComputedContext =
    abstract member isInteractive: bool with get
    abstract member isEmpty: bool with get

[<AllowNullLiteral>]
[<Interface>]
type SignaturePadSchema =
    abstract member state: SignaturePadSchema.state with get, set
    abstract member props: SignaturePadProps with get, set
    abstract member context: PrivateContext with get, set
    abstract member computed: ComputedContext with get, set
    abstract member action: string with get, set
    abstract member event: obj with get, set
    abstract member effect: string with get, set
    abstract member guard: string with get, set

type SignaturePadService = interface end

type SignaturePadMachine = interface end

[<AllowNullLiteral>]
[<Interface>]
type SegmentPathProps =
    abstract member path: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type HiddenInputProps =
    abstract member value: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type SignaturePadApi<'T> =
    /// <summary>
    /// Whether the signature pad is empty.
    /// </summary>
    abstract member empty: bool with get, set
    /// <summary>
    /// Whether the user is currently drawing.
    /// </summary>
    abstract member drawing: bool with get, set
    /// <summary>
    /// The current path being drawn.
    /// </summary>
    abstract member currentPath: string option with get, set
    /// <summary>
    /// The paths of the signature pad.
    /// </summary>
    abstract member paths: ResizeArray<string> with get, set
    /// <summary>
    /// Returns the data URL of the signature pad.
    /// </summary>
    abstract member getDataUrl: SignaturePadApi.getDataUrl with get, set
    /// <summary>
    /// Clears the signature pad.
    /// </summary>
    abstract member clear: (unit -> unit) with get, set
    abstract member getLabelProps: (unit -> 'T) with get, set
    abstract member getRootProps: (unit -> 'T) with get, set
    abstract member getControlProps: (unit -> 'T) with get, set
    abstract member getSegmentProps: (unit -> 'T) with get, set
    abstract member getSegmentPathProps: (SegmentPathProps -> 'T) with get, set
    abstract member getHiddenInputProps: (HiddenInputProps -> 'T) with get, set
    abstract member getGuideProps: (unit -> 'T) with get, set
    abstract member getClearTriggerProps: (unit -> 'T) with get, set





module DrawEndDetails =

    type getDataUrl =
        delegate of ``type``: DataUrlType * ?quality: float -> JS.Promise<string>

module SignaturePadSchema =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type state =
        | idle
        | drawing

module SignaturePadApi =

    type getDataUrl =
        delegate of ``type``: DataUrlType * ?quality: float -> JS.Promise<string>
