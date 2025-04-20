module rec Partas.Solid.Primitives.Mouse
//
// open Partas.Solid
// open Fable.Core
//
// open Fable.Core
// open Fable.Core.JsInterop
// open System
//
// [<AbstractClass>]
// [<Erase>]
// type Exports =
//     /// <summary>
//     /// Attaches event listeners to <see href="target">target</see> element to provide a reactive object of current mouse position on the page.
//     /// </summary>
//     /// <example>
//     /// const [el, setEl] = createSignal(ref)
//     /// const pos = createMousePosition(el, { touch: false })
//     /// createEffect(() => {
//     ///   console.log(pos.x, pos.y)
//     /// })
//     /// </example>
//     /// <param name="target">
//     /// (Defaults to <c>window</c>) element to attach the listeners to – can be a reactive function
//     /// </param>
//     /// <param name="options">
//     /// <see href="MousePositionOptions">MousePositionOptions</see>
//     /// </param>
//     /// <returns>
//     /// reactive object of current mouse position on the page
//     /// <code lang="ts">
//     /// { x: number, y: number, sourceType: MouseSourceType, isInside: boolean }
//     /// </code>
//     /// </returns>
//     [<Import("createMousePosition", "@solid-primitives/mouse")>]
//     static member createMousePosition (?target: U2<obj, Accessor<obj>>, ?options: MousePositionOptions) : MousePositionInside = nativeOnly
//     /// <summary>
//     /// Attaches event listeners to <c>window</c> to provide a reactive object of current mouse position on the page.
//     ///
//     /// This is a [singleton root primitive](https://github.com/solidjs-community/solid-primitives/tree/main/packages/rootless#createSingletonRoot).
//     /// </summary>
//     /// <example>
//     /// const pos = useMousePosition()
//     /// createEffect(() => {
//     ///   console.log(pos.x, pos.y)
//     /// })
//     /// </example>
//     /// <returns>
//     /// reactive object of current mouse position on the page
//     /// <code lang="ts">
//     /// { x: number, y: number, sourceType: MouseSourceType, isInside: boolean }
//     /// </code>
//     /// </returns>
//     [<Import("useMousePosition", "@solid-primitives/mouse")>]
//     static member inline useMousePosition: (unit -> MousePositionInside) = nativeOnly
//     /// <summary>
//     /// Provides an autoupdating position relative to an element based on provided page position.
//     /// </summary>
//     /// <example>
//     /// const [el, setEl] = createSignal(ref)
//     /// const pos = useMousePosition()
//     /// const relative = createPositionToElement(el, () => pos)
//     /// createEffect(() => {
//     ///   console.log(relative.x, relative.y)
//     /// })
//     /// </example>
//     /// <param name="element">
//     /// target <c>Element</c> used in calculations
//     /// </param>
//     /// <param name="pos">
//     /// reactive function returning page position *(relative to the page not window)*
//     /// </param>
//     /// <param name="options">
//     /// <see href="PositionToElementOptions">PositionToElementOptions</see>
//     /// </param>
//     /// <returns>
//     /// Autoupdating position relative to top-left of the target + current bounds of the element.
//     /// </returns>
//     [<Import("createPositionToElement", "@solid-primitives/mouse")>]
//     static member createPositionToElement (element: U2<Element, obj>, pos: Accessor<Position>, ?options: PositionToElementOptions) : PositionRelativeToElement = nativeOnly
//     [<Import("DEFAULT_MOUSE_POSITION", "@solid-primitives/mouse")>]
//     static member inline DEFAULT_MOUSE_POSITION: MousePositionInside = nativeOnly
//     [<Import("DEFAULT_RELATIVE_ELEMENT_POSITION", "@solid-primitives/mouse")>]
//     static member inline DEFAULT_RELATIVE_ELEMENT_POSITION: PositionRelativeToElement = nativeOnly
//     /// <summary>
//     /// Attaches event listeners to provided targat, listeneing for changes to the mouse/touch position.
//     /// </summary>
//     /// <param name="target">
//     /// <code lang="ts">
//     /// SVGSVGElement | HTMLElement | Window | Document
//     /// </code>
//     /// </param>
//     /// <param name="callback">
//     /// function fired on every position change
//     /// </param>
//     /// <param name="options">
//     /// <see href="UseTouchOptions">UseTouchOptions</see> & <see href="FollowTouchOptions">FollowTouchOptions</see>
//     /// </param>
//     /// <returns>
//     /// function removing all event listeners
//     /// </returns>
//     [<Import("makeMousePositionListener", "@solid-primitives/mouse")>]
//     static member makeMousePositionListener (target: U4<SVGSVGElement, HTMLElement, Window, Document> option, callback: (MousePosition -> unit), ?options: Exports.makeMousePositionListener.options) : VoidFunction = nativeOnly
//     /// <summary>
//     /// Attaches event listeners to provided targat, listening for mouse/touch entering/leaving the element.
//     /// </summary>
//     /// <param name="target">
//     /// <code lang="ts">
//     /// SVGSVGElement | HTMLElement | Window | Document
//     /// </code>
//     /// </param>
//     /// <param name="callback">
//     /// function fired on mouse leaving or entering the element
//     /// </param>
//     /// <param name="options">
//     /// <see href="UseTouchOptions">UseTouchOptions</see>
//     /// </param>
//     /// <returns>
//     /// function removing all event listeners
//     /// </returns>
//     [<Import("makeMouseInsideListener", "@solid-primitives/mouse")>]
//     static member makeMouseInsideListener (target: #HtmlElement, callback: (bool -> unit), ?options: UseTouchOptions) : VoidFunction = nativeOnly
//     /// <summary>
//     /// Turn position relative to the page, into position relative to an element.
//     /// </summary>
//     [<Import("getPositionToElement", "@solid-primitives/mouse")>]
//     static member inline getPositionToElement: Exports.getPositionToElement = nativeOnly
//     /// <summary>
//     /// Turn position relative to the page, into position relative to an element. Clamped to the element bounds.
//     /// </summary>
//     [<Import("getPositionInElement", "@solid-primitives/mouse")>]
//     static member inline getPositionInElement: Exports.getPositionInElement = nativeOnly
//     /// <summary>
//     /// Turn position relative to the page, into position relative to the screen.
//     /// </summary>
//     [<Import("getPositionToScreen", "@solid-primitives/mouse")>]
//     static member inline getPositionToScreen: Exports.getPositionToScreen = nativeOnly
//
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type MouseSourceType =
//     | mouse
//     | touch
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MousePosition =
//     interface end
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MousePositionInside =
//     interface end
//
// [<AllowNullLiteral>]
// [<Interface>]
// type PositionRelativeToElement =
//     inherit Position
//     abstract member top: float with get, set
//     abstract member left: float with get, set
//     abstract member width: float with get, set
//     abstract member height: float with get, set
//     abstract member isInside: bool with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type UseTouchOptions =
//     /// <summary>
//     /// Listen to touch events. If enabled, position will be updated on <c>touchstart</c> event.
//     /// </summary>
//     abstract member touch: bool option with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type FollowTouchOptions =
//     /// <summary>
//     /// If enabled, position will be updated on <c>touchmove</c> event.
//     /// </summary>
//     abstract member followTouch: bool option with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type MousePositionOptions =
//     inherit UseTouchOptions
//     inherit FollowTouchOptions
//     /// <summary>
//     /// Initial values
//     /// </summary>
//     abstract member initialValue: MousePositionOptions.initialValue option with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type PositionToElementOptions =
//     inherit UseTouchOptions
//     inherit FollowTouchOptions
//     /// <summary>
//     /// Initial value
//     /// </summary>
//     abstract member initialValue: PositionToElementOptions.initialValue option with get, set
//
// type MaybeAccessor<'T> =
//     U2<'T, obj>
//
// [<AllowNullLiteral>]
// [<Interface>]
// type Position =
//     abstract member x: float with get, set
//     abstract member y: float with get, set
//
// module MousePositionOptions =
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type initialValue =
//         interface end
//
// module PositionToElementOptions =
//
//     [<AllowNullLiteral>]
//     [<Interface>]
//     type initialValue =
//         abstract member top: float option with get, set
//         abstract member left: float option with get, set
//         abstract member width: float option with get, set
//         abstract member height: float option with get, set
//         abstract member isInside: bool option with get, set
//
// module Exports =
//
//     type getPositionToElement =
//         delegate of pageX: float * pageY: float * el: Element -> PositionRelativeToElement
//
//     type getPositionInElement =
//         delegate of pageX: float * pageY: float * el: Element -> PositionRelativeToElement
//
//     type getPositionToScreen =
//         delegate of pageX: float * pageY: float -> Position
//
//     module makeMousePositionListener =
//
//         [<AllowNullLiteral>]
//         [<Interface>]
//         type options =
//             /// <summary>
//             /// Listen to touch events. If enabled, position will be updated on <c>touchstart</c> event.
//             /// </summary>
//             abstract member touch: bool option with get, set
//             /// <summary>
//             /// If enabled, position will be updated on <c>touchmove</c> event.
//             /// </summary>
//             abstract member followTouch: bool option with get, set
