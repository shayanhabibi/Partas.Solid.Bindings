namespace Partas.Solid.ZagJs

open System.Collections.Generic
open Browser.Types
open Fable.Core

[<Erase>]
module Spec =
    [<Literal>]
    let internal path = "@zagjs"
    [<Literal>]
    let internal pathExt = "@zagjs/"

[<Erase>]
module Enums =
    [<StringEnum(CaseRules.None)>]
    type MachineStatus =
        | [<CompiledName("Not Started")>] NotStarted
        | Started
        | Stopped
    [<StringEnum>]
    type Direction =
        | Ltr
        | Rtl
    [<StringEnum>]
    type Orientation =
        | Horizontal
        | Vertical
type ValueOrFn<'T> = U2<'T, unit -> 'T>
type Bindable<'T> =
    abstract initial: 'T option with get,set
    abstract ref: obj with get,set
    abstract get: (unit -> 'T) with get,set
    abstract set: ValueOrFn<'T> -> unit with get
    abstract invoke: nextValue: 'T * prevValue: 'T -> unit with get
    abstract hash: value: 'T -> string with get
type MachineBaseProps =
    abstract id: string option
    abstract ids: IDictionary<string, obj> option
    abstract getRootNode: (unit -> U2<Node, Document>) option
type MachineSchema =
    abstract props: MachineBaseProps option
    abstract context: objnull
    abstract refs: objnull
    abstract computed: objnull
    abstract tag: string option
    abstract state: string option
    abstract guard: string option
    abstract action: string option
    abstract effect: string option
    abstract event: objnull
type State<'T when 'T :> MachineSchema> =
    abstract hasTag: string -> bool
    abstract matches: string[] -> bool
    
type Service<'T when 'T :> MachineSchema> =
    abstract getStatus: unit -> Enums.MachineStatus
    abstract state: State<'T>
    abstract context: obj
    abstract send: obj -> unit
    abstract prop: obj
    abstract scope: obj
    abstract computed: obj
    abstract refs: obj
    abstract event: obj

type CommonProperties = interface end
type DirectionProperty = interface end
type OrientationProperty = interface end
type InteractionOutsideHandler = interface end
type DismissableElementHandlers =
    inherit InteractionOutsideHandler
type PersistentElementOptions = interface end

[<Erase; AutoOpen>]
module CommonPropertyExtensions =
    type CommonProperties with
        member _.id
            with [<Erase>] set(value: string): unit = ()
            and [<Erase>] get(): string option = jsNative
        member _.getRootNode
            with [<Erase>] set(value: unit -> U2<Node, Document>) = ()
            and [<Erase>] get(): unit -> U2<Node, Document> option = jsNative
    type DirectionProperty with
        member _.direction
            with [<Erase>] set(value: Enums.Direction) = ()
            and [<Erase>] get(): Enums.Direction option = jsNative
    type OrientationProperty with
        member _.orientation
            with [<Erase>] set(value: Enums.Orientation) = ()
            and [<Erase>] get(): Enums.Orientation option = jsNative
    type InteractionOutsideHandler with
        member _.onPointerDownOutside
            with [<Erase>] set(value: PointerEvent -> unit): unit = ()
            and [<Erase>] get(): PointerEvent -> unit = jsNative
        member _.onFocusOutside
            with [<Erase>] set(value: FocusEvent -> unit): unit = ()
            and [<Erase>] get(): FocusEvent -> unit = jsNative
        member _.onInteractOutside
            with [<Erase>] set(value: Event -> unit): Unit = ()
            and [<Erase>] get(): Event -> unit = jsNative
    type DismissableElementHandlers with
        member _.onEscapeKeyDown
            with [<Erase>] set(value: KeyboardEvent -> unit): unit = ()
            and [<Erase>] get(): KeyboardEvent -> unit = jsNative
        member _.onRequestDismiss
            with [<Erase>] set(value: CustomEvent -> unit): unit = ()
            and [<Erase>] get(): CustomEvent -> unit = jsNative
    type PersistentElementOptions with
        member _.persistentElements
            with [<Erase>] set(value: (unit -> Element option)[]) = ()
            and [<Erase>] get(): (unit -> Element option)[] = jsNative

// type PropFn<'T, 'Result> = delegate of 'T -> 'Result
// type ComputedFn

