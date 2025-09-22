namespace Partas.Solid.ArkUI
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Glutinum.ZagJs.SignaturePad
open Partas.Solid


[<Erase>]
module SignaturePad =
    let [<Literal>] private sigPad = "@ark-ui/solid/signature-pad"
    [<Erase>]
    module Root =
        [<Pojo>]
        type Ids(
            ?root: string
            ,?control: string
            ,?hiddenInput: string
            ,?label: string
            ) =
            [<DefaultValue>] val mutable root: string option
            [<DefaultValue>] val mutable control: string option
            [<DefaultValue>] val mutable hiddenInput: string option
            [<DefaultValue>] val mutable label: string option
        
    [<Import("SignaturePad.Root", sigPad)>]
    type Root
        /// <summary>
        /// Data attributes:<br/>
        /// <code>
        /// [data-scope] - signature-pad
        /// [data-part] - root
        /// [data-disabled]
        /// </code>
        /// </summary>
        () =
        interface RegularNode
        interface Polymorph
        /// <summary>
        /// Use the provided child element as the default rendered element, combining
        /// their props and behaviour.
        /// </summary>
        [<Erase>]
        member val asChild: div -> HtmlTag = undefined with get,set
        /// <summary>
        /// The default paths of the signature pad. Use when you don't need to control
        /// the paths of the signature pad.
        /// </summary>
        [<Erase>]
        member val defaultPaths: string[] = undefined with get,set
        /// <summary>
        /// Whether the signature pad is disabled.
        /// </summary>
        [<Erase>]
        member val disabled: bool = undefined with get,set
        /// <summary>
        /// The drawing options.
        /// </summary>
        /// <defaultValue>{| size = 2; simulatePressure = true |}</defaultValue>
        [<Erase>]
        member val drawing: DrawingOptions = undefined with get,set
        /// <summary>
        /// The ids of the signature pad elements. Useful for composition
        /// </summary>
        [<Erase>]
        member val ids: Root.Ids = undefined with get,set
        /// <summary>
        /// The name of the signature pad. Useful for form submission.
        /// </summary>
        [<Erase>]
        member val name: string = undefined with get,set
        /// <summary>
        /// Callback when the signature pad is drawing.
        /// </summary>
        [<Erase>]
        member val onDraw: DrawDetails -> unit = undefined with get,set
        /// <summary>
        /// Callback when the signature pad is done drawing.
        /// </summary>
        [<Erase>]
        member val onDrawEnd: DrawEndDetails -> unit = undefined with get,set
        /// <summary>
        /// The controlled paths of the signature pad.
        /// </summary>
        [<Erase>]
        member val paths: string[] = undefined with get,set
        /// <summary>
        /// Whether the signature pad is read-only
        /// </summary>
        [<Erase>]
        member val readOnly: bool = undefined with get,set
        /// <summary>
        /// Whether the signature pad is required.
        /// </summary>
        [<Erase>]
        member val required: bool = undefined with get,set
        /// <summary>
        /// The translations of the signature pad. Useful for internationalization.
        /// </summary>
        [<Erase>]
        member val translations: IntlTranslations = undefined with get,set
        
    [<Import("SignaturePad.ClearTrigger", sigPad)>]
    type ClearTrigger() =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: button -> HtmlTag = undefined with get,set
        
    [<Import("SignaturePad.Control", sigPad)>]
    type Control
        /// <summary>
        /// <code>
        /// [data-scope] - signature-pad
        /// [data-part] - control
        /// [data-disabled]
        /// </code>
        /// </summary>
        () =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: div -> HtmlTag = undefined with get,set
        
    [<Import("SignaturePad.Guide", sigPad)>]
    type Guide
        /// <summary>
        /// <code>
        /// [data-scope] - signature-pad
        /// [data-part] - guide
        /// [data-disabled]
        /// </code>
        /// </summary>
        () =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: div -> HtmlTag = undefined with get,set
        
    [<Import("SignaturePad.HiddenInput", sigPad)>]
    type HiddenInput () =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: input -> HtmlTag = undefined with get,set
        [<Erase>]
        member val value: string = undefined with get,set
        
    [<Import("SignaturePad.Label", sigPad)>]
    type Label
        /// <summary>
        /// <code>
        /// [data-scope] - signature-pad
        /// [data-part] - label
        /// [data-disabled]
        /// </code>
        /// </summary>
        () =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: label -> HtmlTag = undefined with get,set
        
    [<Erase>]
    module RootProvider =
        type UseSignaturePadReturn = Accessor<SignaturePadApi<obj>>
    [<Import("SignaturePad.RootProvider", sigPad)>]
    type RootProvider() =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: div -> HtmlTag = undefined with get,set
        [<Erase>]
        member val value: Accessor<SignaturePadApi<HtmlTag>> = undefined with get,set
    
    [<Import("SignaturePad.Segment", sigPad)>]
    type Segment() =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: Svg.svg -> HtmlTag = undefined with get,set
        
        
