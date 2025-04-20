module rec Glutinum.ZagJs.Avatar

open Fable.Core
open Fable.Core.JsInterop
open System

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LoadStatus =
    | error
    | loaded

[<AllowNullLiteral>]
[<Interface>]
type StatusChangeDetails =
    abstract member status: LoadStatus with get, set

[<AllowNullLiteral>]
[<Interface>]
type ElementIds =
    abstract member root: string option with get, set
    abstract member image: string option with get, set
    abstract member fallback: string option with get, set

[<JS.Pojo>]
type AvatarProps
    (
        ?onStatusChange: (StatusChangeDetails -> unit) option,
        ?ids: ElementIds option,
        ?id: string,
        ?getRootNode: (unit -> obj),
        ?dir: DirectionProperty.dir
    ) =
    /// <summary>
    /// Functional called when the image loading status changes.
    /// </summary>
    [<DefaultValue>]
    val mutable onStatusChange: (StatusChangeDetails -> unit) option

    /// <summary>
    /// The ids of the elements in the avatar. Useful for composition.
    /// </summary>
    [<DefaultValue>]
    val mutable ids: ElementIds option

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

    /// <summary>
    /// The document's text/writing direction.
    /// </summary>
    [<DefaultValue>]
    val mutable dir: DirectionProperty.dir

[<AllowNullLiteral>]
[<Interface>]
type AvatarSchema =
    abstract member props: AvatarProps with get, set
    abstract member context: obj with get, set
    abstract member initial: string with get, set
    abstract member effect: AvatarSchema.effect with get, set
    abstract member action: AvatarSchema.action with get, set
    abstract member event: AvatarSchema.event with get, set
    abstract member state: AvatarSchema.state with get, set

type AvatarService = AvatarSchema

type AvatarMachine = AvatarSchema

[<AllowNullLiteral>]
[<Interface>]
type AvatarApi =
    /// <summary>
    /// Whether the image is loaded.
    /// </summary>
    abstract member loaded: bool with get, set
    /// <summary>
    /// Function to set new src.
    /// </summary>
    abstract member setSrc: src: string -> unit
    /// <summary>
    /// Function to set loaded state.
    /// </summary>
    abstract member setLoaded: unit -> unit
    /// <summary>
    /// Function to set error state.
    /// </summary>
    abstract member setError: unit -> unit
    abstract member getRootProps: unit -> obj
    abstract member getImageProps: unit -> obj
    abstract member getFallbackProps: unit -> obj

module AvatarSchema =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type effect =
        | trackImageRemoval
        | trackSrcChange

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type action =
        | invokeOnLoad
        | invokeOnError
        | checkImageStatus

    [<AllowNullLiteral>]
    [<Interface>]
    type event =
        abstract member ``type``: string with get, set
        abstract member src: string option with get, set
        // abstract member ``type``: string with get, set
        // abstract member src: string option with get, set
        // abstract member ``type``: string with get, set
        // abstract member ``type``: string with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type state =
        | loading
        | error
        | loaded
