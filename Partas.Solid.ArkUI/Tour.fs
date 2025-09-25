module Partas.Solid.ArkUI.Tour
open Partas.Solid
open Partas.Solid.ZagJs
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types

[<Literal>]
let private import = "@ark-ui/solid/tour"
[<Literal>]
let private prefix = "Tour."

[<Import(prefix + "Context", import)>]
type Context() =
    interface HtmlElement
    interface ChildLambdaProvider<TourApi>

[<Import(prefix + "Root", import)>]
type Root() =
    interface HtmlElement
    interface HtmlContainer
    [<Erase>]
    member val tour: Accessor<TourApi> = undefined with get,set
    [<Erase>]
    member val immediate: bool = undefined with get,set
    [<Erase>]
    member val lazyMount: bool = undefined with get,set
    [<Erase>]
    member val onExitComplete: unit -> unit = undefined with get,set
    [<Erase>]
    member val present: bool = undefined with get,set
    [<Erase>]
    member val skipAnimationOnMount: bool = undefined with get,set
    [<Erase>]
    member val unmountOnExit: bool = undefined with get,set
[<Import(prefix + "ActionTrigger",import)>]
type ActionTrigger
    /// <summary>
    /// <code>
    /// [data-scope] tour
    /// [data-part] action-trigger
    /// [data-type]
    /// [data-disabled]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val action: Tour.StepAction = undefined with get,set
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set
[<Import(prefix + "Arrow", import)>]
type Arrow
    /// <summary>
    /// <code>
    /// --arrow-size
    /// --arrow-size-half
    /// --arrow-background
    /// --arrow-offset
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "ArrowTip", import)>]
type ArrowTip() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "Backdrop", import)>]
type Backdrop
    /// <summary>
    /// <code>
    /// --tour-layer
    /// --layer-index
    /// [data-scope] tour
    /// [data-part] backdrop
    /// [data-state] open | closed
    /// [data-type]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "CloseTrigger", import)>]
type CloseTrigger
    /// <summary>
    /// <code>
    /// [data-scope] tour
    /// [data-part] close-trigger
    /// [data-type]
    /// </code>
    /// </summary>
    () =
    inherit button()
    interface Polymorph
    [<Erase>]
    member val asChild: button -> HtmlElement = undefined with get,set

[<Import(prefix + "Content", import)>]
type Content
    /// <summary>
    /// <code>
    /// --layer-index
    /// --nested-layer-count
    /// [data-scope] tour
    /// [data-part] content
    /// [data-state] open | closed
    /// [data-nested]
    /// [data-has-nested]
    /// [data-type]
    /// [data-placement]
    /// [data-step]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "Control", import)>]
type Control() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "Description", import)>]
type Description
    /// <summary>
    /// <code>
    /// [data-scope] tour
    /// [data-part] description
    /// [data-placement]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "Positioner", import)>]
type Positioner
    /// <summary>
    /// <code>
    /// --tour-layer
    /// --transform-origin
    /// --reference-width
    /// --available-width
    /// --available-height
    /// --x
    /// --y
    /// --z-index
    /// --reference-height
    /// [data-scope] tour
    /// [data-part] positioner
    /// [data-type]
    /// [data-placement]
    /// </code>
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set

[<Import(prefix + "ProgressText", import)>]
type ProgressText() =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "Spotlight", import)>]
type Spotlight
    /// <summary>
    /// --tour-layer
    /// </summary>
    () =
    inherit div()
    interface Polymorph
    [<Erase>]
    member val asChild: div -> HtmlElement = undefined with get,set
[<Import(prefix + "Title", import)>]
type Title
    /// <summary>
    /// <code>
    /// [data-scope] tour
    /// [data-part] title
    /// [data-placement]
    /// </code>
    /// </summary>
    () =
    inherit h2()
    interface Polymorph
    [<Erase>]
    member val asChild: h2 -> HtmlElement = undefined with get,set

[<JS.Pojo>]
type TourProps
    (
        ?ids: obj option,
        ?steps: Tour.StepDetails[],
        ?stepId: string,
        ?onStepChange: (Tour.StepChangeDetails -> unit),
        ?onStepsChange: (Tour.StepsChangeDetails -> unit),
        ?onStatusChange: (Tour.StatusChangeDetails -> unit),
        ?closeOnInteractOutside: bool,
        ?closeOnEscape: bool,
        ?keyboardNavigation: bool,
        ?preventInteraction: bool,
        ?spotlightOffset: Point,
        ?spotlightRadius: float,
        ?translations: Tour.IntlTranslations
    ) =
    interface DirectionProperty
    interface CommonProperties
    interface InteractionOutsideHandler

    /// <summary>
    /// The ids of the elements in the tour. Useful for composition.
    /// </summary>
    [<DefaultValue>]
    val mutable ids: obj option

    /// <summary>
    /// The steps of the tour
    /// </summary>
    [<DefaultValue>]
    val mutable steps: Tour.StepDetails[]

    /// <summary>
    /// The id of the currently highlighted step
    /// </summary>
    [<DefaultValue>]
    val mutable stepId: string

    /// <summary>
    /// Callback when the highlighted step changes
    /// </summary>
    [<DefaultValue>]
    val mutable onStepChange: (Tour.StepChangeDetails -> unit)

    /// <summary>
    /// Callback when the steps change
    /// </summary>
    [<DefaultValue>]
    val mutable onStepsChange: (Tour.StepsChangeDetails -> unit)

    /// <summary>
    /// Callback when the tour is opened or closed
    /// </summary>
    [<DefaultValue>]
    val mutable onStatusChange: (Tour.StatusChangeDetails -> unit)

    /// <summary>
    /// Whether to close the tour when the user clicks outside the tour
    /// </summary>
    [<DefaultValue>]
    val mutable closeOnInteractOutside: bool

    /// <summary>
    /// Whether to close the tour when the user presses the escape key
    /// </summary>
    [<DefaultValue>]
    val mutable closeOnEscape: bool

    /// <summary>
    /// Whether to allow keyboard navigation (right/left arrow keys to navigate between steps)
    /// </summary>
    [<DefaultValue>]
    val mutable keyboardNavigation: bool

    /// <summary>
    /// Prevents interaction with the rest of the page while the tour is open
    /// </summary>
    [<DefaultValue>]
    val mutable preventInteraction: bool

    /// <summary>
    /// The offsets to apply to the spotlight
    /// </summary>
    [<DefaultValue>]
    val mutable spotlightOffset: Point

    /// <summary>
    /// The radius of the spotlight clip path
    /// </summary>
    [<DefaultValue>]
    val mutable spotlightRadius: float

    /// <summary>
    /// The translations for the tour
    /// </summary>
    [<DefaultValue>]
    val mutable translations: Tour.IntlTranslations

[<AutoOpen; Erase>]
type Exports =
    [<ImportMember(import)>]
    static member useTour(props: TourProps): Accessor<TourApi> = jsNative
    [<ImportMember(import)>]
    static member useTour(props: Accessor<TourProps>): Accessor<TourApi> = jsNative
    [<ImportMember(import)>]
    static member useTour(): Accessor<TourApi> = jsNative
