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
