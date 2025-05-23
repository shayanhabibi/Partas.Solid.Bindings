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
    
    /// <summary>
    /// Provides all the base functions of an event-emitter, plus additional functions for managing listeners, it's behavior could be customized with an config object. Good for advanced usage.
    /// </summary>
    /// <code>
    /// import { createEventBus } from "@solid-primitives/event-bus";
    /// 
    /// const bus = createEventBus:string:();
    /// 
    /// // can be used without payload type, if you don't want to send any
    /// createEventBus();
    /// 
    /// // bus can be destructured:
    /// const { listen, emit, clear } = bus;
    /// 
    /// const unsub = bus.listen(a => console.log(a));
    /// 
    /// bus.emit("foo");
    /// 
    /// // unsub gets called automatically on cleanup
    /// unsub();
    /// </code>
    [<Erase>]
    type EventBus<'T> =
        abstract listen: ('T -> unit) -> DisposeCallback
        abstract emit: 'T -> unit
        abstract clear: unit -> unit
    /// <summary>
    /// An emitter which you can listen to and emit various events.
    /// </summary>
    /// <code>
    /// import { createEmitter } from "@solid-primitives/event-bus";
    /// 
    /// const emitter = createEmitter:{
    ///   foo: number;
    ///   bar: string;
    /// }:();
    /// // can be destructured
    /// const { on, emit, clear } = emitter;
    /// 
    /// emitter.on("foo", e => {});
    /// emitter.on("bar", e => {});
    /// 
    /// emitter.emit("foo", 0);
    /// emitter.emit("bar", "hello");
    /// 
    /// // unsub gets called automatically on cleanup
    /// unsub();
    /// </code>
    [<Erase>]
    type Emitter<'MessageTyper> =
        abstract on: (string * (obj -> unit)) -> DisposeCallback
        abstract emit: (string * obj) -> unit
        abstract clear: unit -> unit
    
    /// <summary>
    /// Typesafe version of the Emitter made for F#/Fable.
    /// It uses the path from the type to its member as the key of the emission. Because we provide a typed path, we
    /// get the benefit of having the member being typed as the message type.
    /// That is to say, there is nothing stopping you (on the js side) from sending the wrong type through.
    /// </summary>
    [<Erase>]
    type MappedEmitter<'MessageMapper> =
        [<Erase; Emit("$0.on($1, $2)")>]
        member this.zzz_onImplementation (key: string, callback: obj): DisposeCallback = jsNative
        member inline this.on (mapping: 'MessageMapper -> 'MessageType) (callback: 'MessageType -> unit): DisposeCallback =
            this.zzz_onImplementation(JsInterop.emitJsExpr (Experimental.namesofLambda(mapping)) "$0.join('.')", unbox callback)
        [<Erase; Emit("$0.emit($1, $2)")>]
        member this.zzz_emitImplementation(key: string,value: obj): unit = jsNative
        member inline this.emit (mapping: 'MessageMapper -> 'MessageType) (message: 'MessageType): unit =
            this.zzz_emitImplementation(JsInterop.emitJsExpr (Experimental.namesofLambda(mapping)) "$0.join('.')", unbox message)
        [<Erase>]
        member this.clear(): unit = ()
        
    /// <summary>
    /// Wrapper around createEmitter.<br/><br/>
    /// Creates an emitter with which you can listen to and emit various events. With this emitter you can also listen to all events.
    /// </summary>
    /// <code>
    /// import { createGlobalEmitter } from "@solid-primitives/event-bus";
    /// 
    /// const emitter = createGlobalEmitter:{
    ///   foo: number;
    ///   bar: string;
    /// }:();
    /// // can be destructured
    /// const { on, emit, clear, listen } = emitter;
    /// 
    /// emitter.on("foo", e => {});
    /// emitter.on("bar", e => {});
    /// 
    /// emitter.emit("foo", 0);
    /// emitter.emit("bar", "hello");
    /// 
    /// // global listener - listens to all channels
    /// emitter.listen(e => {
    ///   switch (e.name) {
    ///     case "foo": {
    ///       e.details;
    ///       break;
    ///     }
    ///     case "bar": {
    ///       e.details;
    ///       break;
    ///     }
    ///   }
    /// });
    /// </code>
    [<Erase>]
    type GlobalEmitter<'T> =
        inherit Emitter<'T>
        abstract listen: (obj -> unit) -> DisposeCallback
    /// <summary>
    /// Provides helpers for using a group of event buses.<br/><br/>
    /// Can be used with createEventBus, createEventStack or any emitter that has the same api.
    /// </summary>
    /// <code>
    /// How to use it
    /// /// Creating EventHub
    /// import { createEventHub } from "@solid-primitives/event-bus";
    /// 
    /// // by passing an record of Channels
    /// const hub = createEventHub({
    ///   busA: createEventBus(),
    ///   busB: createEventBus:string:(),
    ///   busC: createEventStack:{ text: string }:(),
    /// });
    /// 
    /// // by passing a function
    /// const hub = createEventHub(bus =@ ({
    ///   busA: bus:number:(),
    ///   busB: bus:string:(),
    ///   busC: createEventStack:{ text: string }:(),
    /// }));
    /// 
    /// // hub can be destructured
    /// const { busA, busB, on, emit, listen, value } = hub;
    /// /// Listening  Emitting
    /// const hub = createEventHub({
    ///   busA: createEventBus:void:(),
    ///   busB: createEventBus:string:(),
    ///   busC: createEventStack:{ text: string }:(),
    /// });
    /// // can be destructured
    /// const { busA, busB, on, listen, emit } = hub;
    /// 
    /// hub.on("busA", e =@ {});
    /// hub.on("busB", e =@ {});
    /// 
    /// hub.emit("busA", 0);
    /// hub.emit("busB", "foo");
    /// 
    /// // global listener - listens to all channels
    /// hub.listen(e =@ {
    ///   switch (e.name) {
    ///     case "busA": {
    ///       e.details;
    ///       break;
    ///     }
    ///     case "busB": {
    ///       e.details;
    ///       break;
    ///     }
    ///   }
    /// });
    /// /// Accessing values
    /// // If a emitter returns an accessor value, it will be available in a .value store.
    /// 
    /// hub.value.myBus;
    /// // same as
    /// hub.myBus.value();
    /// </code>
    [<Erase>]
    type EventHub<'T> =
        inherit GlobalEmitter<'T>
    //
    // [<Erase>]
    // type EventStackParameters<'Message> =
    //     abstract event: Event
    // [<Erase>]
    // type EventStackListener<'Message> = EventStackParameters<'Message> -> unit
    // [<Erase>]
    // type EventStack<'Event, 'PackagedEvent> =
    //     inherit GlobalEmitter<'Event>
    //
    // type EventStackSimple<'Event> = EventStack<'Event, 'Event>
    
    [<Erase>]
    [<RequireQualifiedAccess>]
    module EventBus =
        [<ImportMember(path)>]
        let createEventBus<'T> (): EventBus<'T> = jsNative
        
        [<ImportMember(path)>]
        let createEmitter<'T> (): Emitter<'T> = jsNative
        let inline createMappedEmitter<'MessageSchema> (): MappedEmitter<'MessageSchema> = createEmitter<'MessageSchema>() |> unbox 
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
        static member writeClipboard (input: string): unit = jsNative
        
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
        

/// <summary>
/// Requires <c>npm install @solid-primitives/tween</c>
/// </summary>
/// <value>v1.4.0</value>
[<AutoOpen; Erase>]
module Tween =
    let [<Literal>] private path = "@solid-primitives/tween"
    type Easing = (float -> float)
    /// <summary>
    /// Suggested to use easing functions that are already prepared:
    /// <code lang="fsharp">
    /// let tweenedValue = createTween(value, CreateTweenOptions(500, Easing.easeInSine))
    /// </code>
    /// </summary>
    [<Pojo>]
    type CreateTweenOptions(?duration: int, ?easing: Easing) =
        member val duration = duration |> Option.defaultValue 0
        member val easing = easing |> Option.defaultValue id
    /// Contains typical easing functions
    [<Erase>]
    module Easing =
        let easeInSine: Easing = fun x -> 1. - Math.cos((x * Math.PI) / 2.)
        let easeOutSine: Easing = fun x  -> Math.sin((x * Math.PI) / 2.)
        let easeInOutSine: Easing = fun x -> -(Math.cos(Math.PI  * x) - 1.) / 2.
        let easeInQuad: Easing = fun x -> x * x
        let easeOutQuad: Easing = fun x -> 1. - (1. - x) * (1. - x)
        let easeInOutQuad: Easing = fun x -> if x < 0.5 then 2. * x * x else 1. - (-2. * x + 2.) * (-2. * x + 2.) / 2.
        let easeInCubic: Easing = fun x -> x * x * x
        let easeOutCubic: Easing = fun x -> 1. - (1. - x) * (1. - x) * (1. - x)
        let easeInOutCubic: Easing = fun x -> if x < 0.5 then 4. * x * x * x else 1. - (-2. * x + 2.) ** 3. / 2.
        let easeInQuart: Easing = fun x -> x * x * x * x
        let easeOutQuart: Easing = fun x -> 1. - (1. - x) ** 4.
        let easeInOutQuart: Easing = fun x -> if x < 0.5 then 8. * x * x * x * x else 1. - (-2. * x + 2.) ** 4. / 2.
        let easeInQuint: Easing = fun x -> x * x * x * x * x
        let easeOutQuint: Easing = fun x -> 1. - (1. - x) ** 5.
        let easeInOutQuint: Easing = fun x -> if x < 0.5 then 16. * x * x * x * x * x else 1. - (-2. * x + 2.) ** 5. / 2.
        let easeInExpo: Easing = fun x -> if x = 0. then 0. else 2. ** (10. * x - 10.)
        let easeOutExpo: Easing = fun x -> if x = 1. then 1. else 1. - 2. ** (-10. * x)
        let easeInOutExpo: Easing = fun x -> 
            if x = 0. then 0.
            elif x = 1. then 1.
            else if x < 0.5 then 2. ** (20. * x - 10.) / 2. else (2. - 2. ** (-20. * x + 10.)) / 2.

        let easeInCirc: Easing = fun x -> 1. - Math.sqrt(1. - x * x)
        let easeOutCirc: Easing = fun x -> Math.sqrt(1. - (x - 1.) * (x - 1.))
        let easeInOutCirc: Easing = fun x -> 
            if x < 0.5 then (1. - Math.sqrt(1. - (2. * x) ** 2.)) / 2. else (Math.sqrt(1. - (-2. * x + 2.) ** 2.) + 1.) / 2.

        let easeInBack: Easing = fun x -> let c1 = 1.70158 in c1 * x * x * x - c1 * x * x
        let easeOutBack: Easing = fun x -> let c1 = 1.70158 in 1. + c1 * (x - 1.) * (x - 1.) * (x - 1.) + c1 * (x - 1.) * (x - 1.)
        let easeInOutBack: Easing = fun x -> 
            let c2 = 2.5949095
            if x < 0.5 then (c2 * (2. * x) * (2. * x) * (2. * x) - c2 * (2. * x) * (2. * x)) / 2. 
            else (c2 * (-2. * x + 2.) * (-2. * x + 2.) * (-2. * x + 2.) + c2 * (-2. * x + 2.) * (-2. * x + 2.) + 2.) / 2.

        let easeInElastic: Easing = fun x -> 
            if x = 0. then 0.
            elif x = 1. then 1.
            else -2. ** (10. * x - 10.) * Math.sin((x * 10. - 10.75) * (2. * Math.PI) / 3.)

        let easeOutElastic: Easing = fun x -> 
            if x = 0. then 0.
            elif x = 1. then 1.
            else 2. ** (-10. * x) * Math.sin((x * 10. - 0.75) * (2. * Math.PI) / 3.) + 1.

        let easeInOutElastic: Easing = fun x -> 
            if x = 0. then 0.
            elif x = 1. then 1.
            else if x < 0.5 then (-2. ** (20. * x - 10.) * Math.sin((20. * x - 11.125) * (2. * Math.PI) / 4.5)) / 2.
            else (2. ** (-20. * x + 10.) * Math.sin((20. * x - 11.125) * (2. * Math.PI) / 4.5)) / 2. + 1.

        let easeOutBounce: Easing = fun x -> 
            if x < 1. / 2.75 then 7.5625 * x * x
            elif x < 2. / 2.75 then 7.5625 * (x - 1.5 / 2.75) * (x - 1.5 / 2.75) + 0.75
            elif x < 2.5 / 2.75 then 7.5625 * (x - 2.25 / 2.75) * (x - 2.25 / 2.75) + 0.9375
            else 7.5625 * (x - 2.625 / 2.75) * (x - 2.625 / 2.75) + 0.984375
        let easeInBounce: Easing = fun x -> 1. - easeOutBounce(1. - x)

        let easeInOutBounce: Easing = fun x -> 
            if x < 0.5 then (1. - easeOutBounce(1. - 2. * x)) / 2.
            else (1. + easeOutBounce(2. * x - 1.)) / 2.
        let easeLinear:  Easing = id
    [<Erase>]
    type Tween =
        /// <summary>
        /// Creates an efficient tweening derived signal that smoothly transitions a given signal from its previous value to its next value whenever it changes.
        /// <br/>
        /// target can be any reactive value (signal, memo, or function that calls such). For example, to use a component prop, specify <c>fun () -> props.value</c>.<br/><br/>
        /// You can provide two options:
        /// <br/>
        /// - duration is the number of milliseconds to perform the transition from the previous value to the next value. Defaults to 100.
        /// <br/>- easing is a function that maps a number between 0 and 1 to a number between 0 and 1, to speed up or slow down different parts of the transition. The default easing function (t) => t is linear (no easing). A common choice is (t) => 0.5 - Math.cos(Math.PI * t) / 2.
        /// <br/><br/>Internally, createTween uses requestAnimationFrame to smoothly update the tweened value at the display refresh rate. After the tweened value reaches the underlying signal value, it will stop updating via requestAnimationFrame for efficiency.
        /// </summary>
        [<ImportMember(path)>]
        static member createTween(target: Accessor<float>, ?options: CreateTweenOptions): Accessor<float> = jsNative
        /// <summary>
        /// Creates an efficient tweening derived signal that smoothly transitions a given signal from its previous value to its next value whenever it changes.
        /// <br/>
        /// target can be any reactive value (signal, memo, or function that calls such). For example, to use a component prop, specify <c>fun () -> props.value</c>.<br/><br/>
        /// You can provide two options:
        /// <br/>
        /// - duration is the number of milliseconds to perform the transition from the previous value to the next value. Defaults to 100.
        /// <br/>- easing is a function that maps a number between 0 and 1 to a number between 0 and 1, to speed up or slow down different parts of the transition. The default easing function (t) => t is linear (no easing). A common choice is (t) => 0.5 - Math.cos(Math.PI * t) / 2.
        /// <br/><br/>Internally, createTween uses requestAnimationFrame to smoothly update the tweened value at the display refresh rate. After the tweened value reaches the underlying signal value, it will stop updating via requestAnimationFrame for efficiency.
        /// </summary>
        [<ImportMember(path)>]
        static member createTween(target: Accessor<int>, ?options: CreateTweenOptions): Accessor<int> = jsNative
        static member inline createTween(target: Accessor<int>, duration: int, easing: Easing): Accessor<int> =
            Tween.createTween(target, options = CreateTweenOptions(duration = duration, easing = easing))
        static member inline createTween(target: Accessor<float>, duration: int, easing: Easing): Accessor<float> =
            Tween.createTween(target, options = CreateTweenOptions(duration = duration, easing = easing))

// /// <summary>
// /// Requires <c>npm install @solid-primitives/event-listener</c>
// /// </summary>
// /// <value>v2.4.0</value>
// [<AutoOpen; Erase>]
// module EventListener =
//     let [<Literal>] private path = "@solid-primitives/event-listener"
//     type EventListenerDirectiveProps(
//             ``type``: string,
//             handler: _ -> unit,
//             options
//         )
//     type EventListener =
//         /// <summary>
//         /// Non-reactive primitive for adding event listeners that gets removed onCleanup. Returns a <c>dispose</c>
//         /// function for early cleanup.
//         /// </summary>
//         /// 
//         [<ImportMember(path)>]
//         static member makeEventListener()