namespace Partas.Solid.Primitives

open System.Runtime.CompilerServices
open Fable.Core
open Browser.Types
open Fable.Core.JS
open Partas.Solid

/// Call this func to remove the listener
[<Erase>]
type DisposeCallback = unit -> unit

/// <summary>
/// Requires <c>npm install @solid-primitives/media</c>
/// </summary>
[<AutoOpen; Erase>]
module Media =
    let [<Literal>] private path = "@solid-primitives/media"
    
    [<Erase>]
    type BreakpointMonitor<'T> =
        member inline this.obj = unbox<'T> this
        member _.key with get(): string = jsNative
    
    [<Erase>]
    type MediaQuery = unit -> bool
    
    [<Erase>]
    type MediaQueryEvent =
        abstract matches: bool
        abstract media: string
    
    [<Erase>]
    type Media =
        [<ImportMember(path)>]
        static member makeMediaQueryListener (query: string) (handler: MediaQueryEvent -> unit): DisposeCallback = jsNative
        
        [<ImportMember(path)>]
        static member createMediaQuery (query: string, ?serverFallback: bool): MediaQuery = jsNative
        
        [<ImportMember(path)>]
        static member createBreakpoints (queryMonitor: 'T): BreakpointMonitor<'T> = jsNative
    
        [<ImportMember(path)>]
        static member sortBreakpoints (breakpoints: 'T): 'T = jsNative
        
        [<ImportMember(path)>]
        static member createPrefersDark (?fallback: bool): MediaQuery = jsNative
        
        [<ImportMember(path)>]
        static member usePrefersDark (): MediaQuery = jsNative

/// <summary>
/// Requires <c>npm install @solid-primitives/keyboard</c>
/// </summary>
[<AutoOpen; Erase>]
module Keyboard =
    let [<Literal>] private path = "@solid-primitives/keyboard"

    [<Erase>]
    type Keyboard =
        [<ImportMember(path)>]
        static member useKeyDownEvent (): Accessor<KeyboardEvent> = jsNative
        
        [<ImportMember(path)>]
        static member useKeyDownList(): Accessor<string[]> = jsNative
        
        [<ImportMember(path)>]
        static member useCurrentlyHeldKey(): Accessor<string | null> = jsNative
        
        [<ImportMember(path)>]
        static member useKeyDownSequence(): Accessor<string[][]> = jsNative
        
        [<ImportMember(path)>]
        static member createKeyHold(key: string, ?options: {| preventDefault: bool |}): Accessor<bool> = jsNative
        
        [<ImportMember(path)>]
        static member createShortcut(keys: string[],
                                     handler: unit -> unit,
                                     ?options: {| preventDefault: bool; requireReset: bool |} ): unit = jsNative

/// <summary>
/// Requires <c>@solid-primitives/autofocus</c>
/// </summary>
[<AutoOpen; Erase>]
module AutoFocus =
    let [<Literal>] private path = "@solid-primitives/autofocus"
    
    [<Erase>]
    type AutoFocus =
        /// <summary>
        /// The <c>autofocus</c> directive uses the native <c>autofocus</c> attribute to determine it should focus
        /// the element or not. Using this directive without <c>autofocus={true}</c> (or the shorthand, <c>autofocus</c>)
        /// will not perform anything.
        /// </summary>
        /// <example>
        /// <code>
        /// // As a directive
        /// button(autofocus = true).use(autofocus)
        /// // As a ref
        /// button(autofocus = true).ref(autofocus)
        /// </code>
        /// </example>
        [<ImportMember(path)>]
        static member autofocus = jsNative
        
        /// <summary>
        /// Reactively autofocuses an element passid in as a signal
        /// </summary>
        /// <example><code>
        /// import { createAutofocus } from "@solid-primitives/autofocus";
        /// // Using ref
        /// let ref!: HTMLButtonElement;
        /// createAutofocus(() => ref);
        /// 
        /// /button ref={ref}>Autofocused /button>;
        /// 
        /// // Using ref signal
        /// const [ref, setRef] = createSignal /HTMLButtonElement>();
        /// createAutofocus(ref);
        /// 
        /// /button ref={setRef}>Autofocused /button>;
        /// </code></example>
        [<ImportMember(path)>]
        static member createAutofocus (ref: unit -> #HtmlElement): unit = jsNative
    
/// <summary>
/// Requires <c>npm install @solid-primitives/active-element</c>
/// </summary>
[<AutoOpen>]
module ActiveElement =
    let [<Literal>] private path = "@solid-primitives/active-element"
    
    
    type ActiveElement =
        /// <summary>
        /// Listen for changes to the <c>document.activeElement</c>
        /// </summary>
        /// <remarks>
        /// non reactive
        /// </remarks>
        [<ImportMember(path)>]
        static member makeActiveElementListener (handler: #HtmlElement -> unit): DisposeCallback = jsNative
        
        /// <summary>
        /// Attaches "blur" and "focus" event listeners to the element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="callBack"></param>
        /// <param name="useCapture"></param>
        [<ImportMember(path)>]
        static member makeFocusListener (target: #HtmlElement, callBack: bool -> unit, ?useCapture: bool): DisposeCallback = jsNative
        
        /// <summary>
        /// Provides a reactive signal of <c>document.activeElement</c>. Check which element is currently focused.
        /// </summary>
        [<ImportMember(path)>]
        static member createActiveElement (): Accessor<#HtmlElement> = jsNative
        
        /// <summary>
        /// Provides a signal representing element's focus state
        /// </summary>
        [<ImportMember(path)>]
        static member createFocusSignal(target: #HtmlElement): Accessor<bool> = jsNative
        
        /// <summary>
        /// Provides a signal representing element's focus state
        /// </summary>
        [<ImportMember(path)>]
        static member createFocusSignal(target: Accessor<HtmlElement>): Accessor<bool> = jsNative
        
        /// <summary>
        /// A directive that notifies you when the element becomes active or inactive
        /// </summary>
        [<ImportMember(path)>]
        static member focus: string = jsNative

/// <summary>
/// Requires <c>npm install @solid-primitives/event-bus</c>
/// </summary>
[<AutoOpen; Erase>]
module EventBus =
    let [<Literal>] private path = "@solid-primitives/event-bus"
    
    [<Erase>]
    type EventBus<'T> =
        abstract listen: ('T -> unit) -> DisposeCallback
        abstract emit: 'T -> unit
        abstract clear: unit -> unit
    
    [<Erase>]
    type Emitter<'T> =
        abstract on: (string * (obj -> unit)) -> DisposeCallback
        abstract emit: (string * obj) -> unit
        abstract clear: unit -> unit
    
    [<Erase>]
    type GlobalEmitter<'T> =
        inherit Emitter<'T>
        abstract listen: (obj -> unit) -> DisposeCallback
    
    [<Erase>]
    type EventHub<'T> =
        inherit GlobalEmitter<'T>
    
    [<Erase>]
    [<RequireQualifiedAccess>]
    module EventBus =
        [<ImportMember(path)>]
        let createEventBus<'T> (): EventBus<'T> = jsNative
        
        [<ImportMember(path)>]
        let createEmitter<'T> (): Emitter<'T> = jsNative
    
        //todo createEventStack & utils
        [<ImportMember(path)>]
        let createEventHub<'T> ([<OptionalArgument>] channels: 'T): EventHub<'T> = jsNative
        
        
/// <summary>
/// Requires <c>npm install @solid-primitives/trigger</c>
/// </summary>
[<AutoOpen; Erase>]
module Trigger =
    let [<Literal>] private path = "@solid-primitives/trigger"
    type [<Erase>] Track<'T> = 'T -> unit
    type [<Erase>] Dirty<'T> = 'T -> unit
    type [<Erase>] DirtyAll = unit -> unit
    type [<Erase>] TriggerSignal<'T> = Track<'T> * Dirty<'T>
    type [<Erase>] TriggerCacheSignal<'T> = Track<'T> * Dirty<'T> * DirtyAll
    
    [<AutoOpen; Erase>]
    type Extensions =
        /// <summary>
        /// Will track the trigger of the given key for the cache
        /// </summary>
        /// <param name="triggerCache"></param>
        /// <param name="key">the key</param>
        [<Erase; Extension>]
        static member track (triggerCache: TriggerCacheSignal<'T>, key: 'T): unit = undefined
        /// <summary>
        /// Will trigger the tracker for the given key of the cache
        /// </summary>
        /// <param name="triggerCache"></param>
        /// <param name="key">the key</param>
        [<Erase; Extension>]
        static member dirty (triggerCache: TriggerCacheSignal<'T>, key: 'T): unit = undefined
    
    [<Erase>]
    type Trigger =
        /// <summary>
        /// Set listeners in reactive computations and then trigger them when you want.
        /// </summary>
        /// <example><code>
        /// let track,dirty = createTrigger()
        /// createEffect(fun() ->
        ///     track() // 'read' track
        ///     // ...
        /// )
        /// // later
        /// dirty()
        /// </code></example>
        [<ImportMember(path)>]
        static member createTrigger (): TriggerSignal<unit> = jsNative
        /// <summary>
        /// Creates a cache of triggers that can be used to mark dirty only specific keys.
        /// <br/><br/>Cache is a Map or WeakMap depending on the mapConstructor argument. (default: Map)
        /// <br/><br/>If mapConstructor is WeakMap then the cache will be weak and the keys will be garbage collected when they are no longer referenced.
        /// <br/><br/>Trigger signals added to the cache only when tracked under a computation, and get deleted from the cache when they are no longer tracked.
        /// </summary>
        /// <example><code>
        /// let map = createTriggerCache[int]()
        /// createEffect(fun() ->
        ///     map.track(1) // 'read' track
        ///     // ...
        /// )
        /// // later
        /// map.dirty(1)
        /// </code></example>
        [<ImportMember(path)>]
        static member createTriggerCache<'T> (): TriggerCacheSignal<'T> = jsNative

/// <summary>
/// Requires <c>npm install @solid-primitives/clipboard</c>
/// </summary>
[<AutoOpen; Erase>]
module Clipboard =
    let [<Literal>] private path = "@solid-primitives/clipboard"
    
    [<Erase>]
    type Clipboard =
        [<ImportMember(path)>]
        static member readClipboard () = jsNative
        
        [<ImportMember(path)>]
        static member writeClipboard () = jsNative
        
        [<ImportMember(path)>]
        static member createClipboard () = jsNative
        
        [<ImportMember(path)>]
        static member copyToClipboard () = jsNative
        
        [<ImportMember(path)>]
        static member newItem () = jsNative

/// <summary>
/// Requires <c>npm install @solid-primitives/broadcast-channel</c>
/// </summary>
/// <value>v0.1.0</value>
[<AutoOpen; Erase>]
module rec BroadcastChannel =
    
    [<AllowNullLiteral; Interface>]
    type MessageEvent<'T> =
        inherit MessageEvent
        abstract member data: 'T with get
        
    
    [<AllowNullLiteral; Interface>]
    type BroadcastChannelResult = interface end
    
    
    [<AllowNullLiteral; Interface>]
    type MakeBroadcastChannelResult<'T> =
        inherit BroadcastChannelResult
        /// A function to subscribe to messages from other tabs on the same channel
        abstract member onMessage: event: MessageEvent<'T> -> unit with get
        /// A function to send messages to other tabs
        abstract member postMessage: 'T -> unit with get
        /// A function to close the channel
        abstract member close: unit -> unit with get
        /// The name of the channel
        abstract member channelName: string with get
        /// The underlying BroadcastChannel instance
        abstract member instance: BroadcastChannel<'T> with get
    [<AllowNullLiteral; Interface>]
    type CreateBroadcastChannelResult<'T> =
        inherit BroadcastChannelResult
        /// An accessor that updates when postMessage is fired from other contexts
        abstract member message: Accessor<'T> -> unit with get
        /// A function to send messages to other tabs
        abstract member postMessage: 'T -> unit with get
        /// A function to close the channel
        abstract member close: unit -> unit with get
        /// The name of the channel
        abstract member channelName: string with get
        /// The underlying BroadcastChannel instance
        abstract member instance: BroadcastChannel<'T> with get
    
    [<Erase>]
    type BroadcastChannel<'T> =
        /// <summary>
        /// Creates a new BroadcastChannel instance for cross-tab communication.<br/>
        /// The channel name is used to identify the channel. If a channel with the same name already exists, it will
        /// be returned instead of creating a new one.<br/>
        /// Channel attempt closing the channel when the on owner cleanup. If there are multiple connected instances, the
        /// channel will not be closed until the last owner is removed.
        /// </summary>
        /// <param name="name">Channel name to listen/broadcast on</param>
        /// <returns>An object with the following properties<br/>
        /// onMessage, postMessage, close, channelName, instance</returns>
        [<ImportMember("@solid-primitives/broadcast-channel")>]
        static member makeBroadcastChannel<'T> (name: string): MakeBroadcastChannelResult<'T> = jsNative
        /// <summary>
        /// Provides the same functionality as <c>makeBroadcastChannel</c> but instead of returning <c>onMessage</c>, it
        /// returns a <c>message</c> signal accessor that updates when postMessage is fired from other contexts.
        /// </summary>
        /// <param name="name">Channel name to listen/broadcast on</param>
        /// <returns>An object with the following properties<br/>
        /// message, postMessage, close, channelName, instance</returns>
        [<ImportMember("@solid-primitives/broadcast-channel")>]
        static member createBroadcastChannel<'T> (name: string): CreateBroadcastChannelResult<'T> = jsNative


/// <summary>
/// Requires <c>npm install @solid-primitives/scroll</c>
/// </summary>
/// <value>v2.1.0</value>
[<AutoOpen; Erase>]
module Scroll =
    let [<Literal>] private path = "@solid-primitives/scroll"
    
    [<AllowNullLiteral; Interface>]
    type ScrollPosition =
        abstract member x: int with get
        abstract member y: int with get
    
    [<Erase>]
    type Scroll =
        /// Default target of window
        [<ImportMember(path)>]
        static member createScrollPosition (): Accessor<ScrollPosition> = jsNative
        /// Element ref target or Accessor<#HtmlElement>
        [<ImportMember(path)>]
        static member createScrollPosition (element: unit -> #HtmlElement): Accessor<ScrollPosition> = jsNative
        /// Returns reactive object with current window scroll position; signals and event-listeners are shared
        /// between dependendents making it more optimised to use in multiple places at once
        [<ImportMember(path)>]
        static member useWindowScrollPosition (): ScrollPosition = jsNative
        /// <summary>
        /// Gets a <c>ScrollPosition</c> element/window scroll position
        /// </summary>
        [<ImportMember(path)>]
        static member getScrollPosition (): ScrollPosition = jsNative
        
/// <summary>
/// Requires <c>npm install @solid-primitives/idle</c>
/// </summary>
/// <value>v0.2.0</value>
[<AutoOpen; Erase>]
module Idle =
    let [<Literal>] private path = "@solid-primitives/idle"
    
    [<AllowNullLiteral; Interface>]
    type IdleTimer =
        /// Report user status.
        abstract member isIdle: bool Accessor with get
        /// Report user status.
        abstract member isPrompted: bool Accessor with get
        /// Start timer
        abstract member start: unit -> unit with get
        /// Stop timer
        abstract member stop: unit -> unit with get
        /// Reset timer
        abstract member reset: unit -> unit with get
        /// Manually sets isIdle to true and triggers onIdle callback (with custom manualidle event).
        abstract member triggerIdle: unit -> unit with get
    
    [<AllowNullLiteral; Pojo>]
    type IdleTimerOptions
        (
            ?idleTimeout: int,
            ?promptTimeout: int,
            ?onIdle: Event -> unit,
            ?onPrompt: Event -> unit,
            ?onActive: Event -> unit,
            ?startManually: bool,
            ?events: Event[],
            ?element: HtmlElement
        ) =
        member val idleTimeout: int = unbox null with get,set
        member val promptTimeout: int = unbox null with get,set 
        member val onIdle: Event -> unit = unbox null with get,set
        member val onPrompt: Event -> unit = unbox null with get,set
        member val onActive: Event -> unit = unbox null with get,set
        member val startManually: bool = unbox null with get,set
        member val events: Event[] = unbox null with get,set
        member val element: HtmlElement = unbox null with get,set
    
    
    [<Erase>]
    type Idle =
        /// Provides different accessors and methods to observe the user's idle status and react to its changing.
        [<ImportMember(path)>]
        static member createIdleTimer (?options: obj): IdleTimer = jsNative

/// <summary>
/// Requires <c>npm install @solid-primitives/timer</c>
/// </summary>
/// <value>v1.4.0</value>
[<AutoOpen; Erase>]
module Timer =
    let [<Literal>] private path = "@solid-primitives/timer"
    
    [<Erase>]
    type IntervalOrTimeout = (unit -> unit) -> int -> int
    
    [<Erase>]
    type Timer =
        /// Makes an automatically cleaned up timer. Takes a callback, the timespan, and then either the
        /// the function `setInterval` or `setTimeout`
        [<ImportMember(path)>]
        static member makeTimer (callback: unit -> unit, timespan: int, policy: IntervalOrTimeout): DisposeCallback = jsNative
        /// makeTimer but with a fully reactive delay. The delay can also be set to 'false' in which case the timer is disabled.
        [<ImportMember(path)>]
        static member createTimer (callback: unit -> unit, timespan: int, policy: IntervalOrTimeout): unit = jsNative
        /// makeTimer but with a fully reactive delay. The delay can also be set to 'false' in which case the timer is disabled.
        [<ImportMember(path)>]
        static member createTimer (callback: unit -> unit, timespan: unit -> U2<bool, int>, policy: IntervalOrTimeout): unit = jsNative
        /// makeTimer but with a fully reactive delay. The delay can also be set to 'false' in which case the timer is disabled.
        [<ImportMember(path)>]
        static member createTimer (callback: unit -> unit, timespan: unit -> int, policy: IntervalOrTimeout): unit = jsNative
        /// makeTimer but with a fully reactive delay. The delay can also be set to 'false' in which case the timer is disabled.
        [<ImportMember(path)>]
        static member createTimer (callback: unit -> unit, timespan: unit -> bool, policy: IntervalOrTimeout): unit = jsNative
        /// <summary>
        /// Similar to an interval created with createTimer, but the delay does not update until the callback is executed
        /// </summary>
        /// <example><code>
        /// let cb = fun () -> ()
        /// let delay,setDelay = createSignal(1000)
        /// createTimeoutLoop(cb, delay)
        /// //...
        /// 500 |> setDelay
        /// </code></example>
        [<ImportMember(path)>]
        static member createTimeoutLoop (callback: unit -> unit, timespan: int): unit = jsNative
        [<ImportMember(path)>]
        static member createTimeoutLoop (callback: unit -> unit, timespan: Accessor<int>): unit = jsNative
        /// <summary>
        /// Periodically polls a function, returning an accessor to its last return value.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="timespan"></param>
        [<ImportMember(path)>]
        static member createPolled(callback: unit -> 'T, timespan: int): Accessor<'T> = jsNative
        /// <summary>
        /// Periodically polls a function, returning an accessor to its last return value.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="timespan"></param>
        [<ImportMember(path)>]
        static member createPolled(callback: unit -> 'T, timespan: Accessor<int>): Accessor<'T> = jsNative
        /// <summary>
        /// A counter which increments periodically on the delay.
        /// </summary>
        /// <param name="timespan"></param>
        [<ImportMember(path)>]
        static member createIntervalCounter(timespan: int): Accessor<int> = jsNative
        /// <summary>
        /// A counter which increments periodically on the delay.
        /// </summary>
        /// <param name="timespan"></param>
        [<ImportMember(path)>]
        static member createIntervalCounter(timespan: Accessor<int>): Accessor<int> = jsNative

/// <summary>
/// Requires <c>npm install @solid-primitives/scheduled</c>
/// </summary>
/// <value>v1.5.0</value>
[<AutoOpen; Erase>]
module Scheduled =
    let [<Literal>] private path = "@solid-primitives/scheduled"
    
    [<AllowNullLiteral; Interface>]
    type Schedule<'T> =
        [<Emit("$0($1)")>]
        abstract member exec: 'T -> unit
        abstract member clear: unit -> unit with get  
    
    type DebounceOrThrottle<'T> = ('T -> unit) * int -> Schedule<'T>
    
    [<Erase>]
    type Scheduled =
        [<ImportMember(path)>]
        static member debounce (callback: 'T -> unit, timespan: int): Schedule<'T> = jsNative
        [<ImportMember(path)>]
        static member throttle (callback: 'T -> unit, timespan: int): Schedule<'T> = jsNative
        [<ImportMember(path)>]
        static member scheduleIdle (callback: 'T -> unit, timespan: int): Schedule<'T> = jsNative
        [<ImportMember(path)>]
        static member leading(debOrThrot: DebounceOrThrottle<'T>, callback: 'T -> unit, timespan: int): Schedule<'T> = jsNative
        [<ImportMember(path)>]
        static member leadingAndTrailing (debOrThrot: DebounceOrThrottle<'T>, callback: 'T -> unit, timespan: int): Schedule<'T> = jsNative
        // [<ImportMember(path)>]
        // static member createScheduled (schedule: ('T -> unit) -> ()
        

// /// <summary> // TODO - need to implement a type provider for this
// /// Requires <c>npm install @solid-primitives/state-machine</c>
// /// </summary>
// /// <value>v0.1.0</value>
// [<AutoOpen; Erase>]
// module StateMachine =
//     let [<Literal>] private path = "@solid-primitives/state-machine"
//     
//     [<Pojo>]
//     type StateMachineConfig
//         (
//             initial: string,
//             states: string[]
//         ) =
//         member val initial: string = initial with get,set
//         member val states: string = initial with get,set

/// <summary>
/// Requires <c>npm install @solid-primitives/bounds</c>
/// </summary>
/// <value>v0.1.0</value>
[<AutoOpen; Erase>]
module Bounds =
    let [<Literal>] private path = "@solid-primitives/bounds"
    [<Interface; AllowNullLiteral>]
    type ElementBounds =
        abstract width: int with get
        abstract height: int with get
        abstract top: int with get
        abstract left: int with get
        abstract right: int with get
        abstract bottom: int with get
    [<Erase>]
    type Bounds =
        /// <summary>
        /// Creates a reactive store-like object of current element bounds — position on the screen, and size dimensions. Bounds will be automatically updated on scroll, resize events and updates to the DOM.
        /// </summary>
        /// <param name="target">Ref or reactive ref element</param>
        /// <param name="trackScroll">Listen to window scroll events</param>
        /// <param name="trackMutation">Listen to changes to the dom structure/styles</param>
        /// <param name="trackResize">Listen to changes to the element's resize events</param>
        /// <remarks>All options are 'truthy' by default</remarks>
        [<ImportMember(path); ParamObject(1)>]
        static member createElementBounds(target: #HTMLElement,
                                          ?trackScroll: bool,
                                          ?trackMutation: bool,
                                          ?trackResize: bool): ElementBounds = jsNative
        /// <summary>
        /// Creates a reactive store-like object of current element bounds — position on the screen, and size dimensions. Bounds will be automatically updated on scroll, resize events and updates to the DOM.
        /// </summary>
        /// <param name="target">Ref or reactive ref element</param>
        [<ImportMember(path)>]
        static member createElementBounds(target: #HTMLElement): ElementBounds = jsNative
        /// <summary>
        /// Creates a reactive store-like object of current element bounds — position on the screen, and size dimensions. Bounds will be automatically updated on scroll, resize events and updates to the DOM.
        /// </summary>
        /// <param name="target">Ref or reactive ref element</param>
        /// <param name="trackScroll">Listen to window scroll events</param>
        /// <param name="trackMutation">Listen to changes to the dom structure/styles</param>
        /// <param name="trackResize">Listen to changes to the element's resize events</param>
        /// <remarks>All options are 'truthy' by default</remarks>
        [<ImportMember(path); ParamObject(1)>]
        static member createElementBounds(target: Accessor<#HTMLElement>,
                                          ?trackScroll: bool,
                                          ?trackMutation: bool,
                                          ?trackResize: bool): ElementBounds = jsNative
        /// <summary>
        /// Creates a reactive store-like object of current element bounds — position on the screen, and size dimensions. Bounds will be automatically updated on scroll, resize events and updates to the DOM.
        /// </summary>
        /// <param name="target">Ref or reactive ref element</param>
        [<ImportMember(path)>]
        static member createElementBounds(target: Accessor<#HTMLElement>): ElementBounds = jsNative
        
