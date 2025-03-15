namespace Partas.Solid.Primitives

open Fable.Core
open Browser.Types
open Fable.Core.JS
open Partas.Solid

/// Call this func to remove the listener
[<Erase>]
type ListenerDestructor = unit -> unit

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
        static member makeMediaQueryListener (query: string) (handler: MediaQueryEvent -> unit): ListenerDestructor = jsNative
        
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
        static member makeActiveElementListener (handler: #HtmlElement -> unit): ListenerDestructor = jsNative
        
        /// <summary>
        /// Attaches "blur" and "focus" event listeners to the element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="callBack"></param>
        /// <param name="useCapture"></param>
        [<ImportMember(path)>]
        static member makeFocusListener (target: #HtmlElement, callBack: bool -> unit, ?useCapture: bool): ListenerDestructor = jsNative
        
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
        abstract listen: ('T -> unit) -> ListenerDestructor
        abstract emit: 'T -> unit
        abstract clear: unit -> unit
    
    [<Erase>]
    type Emitter<'T> =
        abstract on: (string * (obj -> unit)) -> ListenerDestructor
        abstract emit: (string * obj) -> unit
        abstract clear: unit -> unit
    
    [<Erase>]
    type GlobalEmitter<'T> =
        inherit Emitter<'T>
        abstract listen: (obj -> unit) -> ListenerDestructor
    
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
    
    [<Erase>]
    type Trigger =
        [<ImportMember(path)>]
        static member createTrigger ()= jsNative
        
        [<ImportMember(path)>]
        static member createTriggerCache () = jsNative

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
        abstract member onMessage: event: MessageEvent<'T> -> unit with get
        abstract member postMessage: 'T -> unit with get
        abstract member close: unit -> unit with get
        abstract member channelName: string with get
        abstract member instance: BroadcastChannel<'T> with get
    [<AllowNullLiteral; Interface>]
    type CreateBroadcastChannelResult<'T> =
        inherit BroadcastChannelResult
        abstract member message: Accessor<'T> -> unit with get
        abstract member postMessage: 'T -> unit with get
        abstract member close: unit -> unit with get
        abstract member channelName: string with get
        abstract member instance: BroadcastChannel<'T> with get
    
    [<Erase>]
    type BroadcastChannel<'T> =
        [<ImportMember("@solid-primitives/broadcast-channel")>]
        static member makeBroadcastChannel<'T> (name: string): MakeBroadcastChannelResult<'T> = jsNative
        [<ImportMember("@solid-primitives/broadcast-channel")>]
        static member createBroadcastChannel<'T> (name: string): CreateBroadcastChannelResult<'T> = jsNative