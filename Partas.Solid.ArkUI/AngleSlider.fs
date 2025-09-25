namespace Partas.Solid.ArkUI
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Partas.Solid
open Partas.Solid.ZagJs

[<Erase>]
module AngleSlider =
    let [<Literal>] private angleSlider = "@ark-ui/solid/angle-slider"
    [<Import("AngleSlider.Root", angleSlider)>]
    type Root
        /// <summary>
        /// <code>
        /// --value : the current value
        /// --angle : the angle in degrees
        ///
        /// [data-scope] : angle-slider
        /// [data-part] : root
        /// [data-disabled] : present when disabled
        /// [data-invalid] : present when invalid
        /// [data-readonly] : present when read-only
        /// </code>
        /// </summary>
        ( ) =
        interface RegularNode
        interface DirectionProperty
        interface CommonProperties
        interface Polymorph
        [<Erase>]
        member val asChild: div -> HtmlElement = undefined with get,set
        /// <summary>
        /// The ids of the elements in the machine. Useful for composition.
        /// </summary>
        [<Erase>]
        member val ids: AngleSlider.ElementIds = JS.undefined with get , set
        /// <summary>
        /// The step value of the slider.
        /// </summary>
        /// <defaultValue>1</defaultValue>
        [<Erase>]
        member val step: float = JS.undefined with get , set
        /// <summary>
        /// The value of the slider
        /// </summary>
        [<Erase>]
        member val value: float = JS.undefined with get , set
        /// <summary>
        /// The initial value of the slider. Use when you don't need to
        /// control the value of the slider otherwise.
        /// </summary>
        /// <defaultValue>0</defaultValue>
        [<Erase>]
        member val defaultValue: float = JS.undefined with get , set
        /// <summary>
        /// The callback function for when the value changes.
        /// </summary>
        [<Erase>]
        member val onValueChange: AngleSlider.ValueChangeDetails -> unit = JS.undefined with get , set
        /// <summary>
        /// The callback function for when the value changes ends (ie the slider is released).
        /// </summary>
        [<Erase>]
        member val onValueChangeEnd: AngleSlider.ValueChangeDetails -> unit = JS.undefined with get , set
        /// <summary>
        /// Whether the slider is disabled
        /// </summary>
        [<Erase>]
        member val disabled: bool = JS.undefined with get , set
        /// <summary>
        /// Whether the slider is read-only.
        /// </summary>
        [<Erase>]
        member val readOnly: bool = JS.undefined with get , set
        /// <summary>
        /// Whether the slider is invalid.
        /// </summary>
        [<Erase>]
        member val invalid: bool = JS.undefined with get , set
        /// <summary>
        /// The name of the slider, used in form submission.
        /// </summary>
        [<Erase>]
        member val name: string = JS.undefined with get , set
    
    [<Import("AngleSlider.Control", angleSlider)>]
    type Control
        /// <summary>
        /// <code>
        /// [data-scope] : angle-slider
        /// [data-part] : control
        /// [data-disabled]
        /// [data-invalid]
        /// [data-readonly]
        /// </code>
        /// </summary>
        () =
        interface RegularNode
        interface Polymorph
        [<Erase>]
        member val asChild: input -> HtmlElement = undefined with get,set
    [<Import("AngleSlider.HiddenInput",angleSlider)>]
    type HiddenInput
        () =
        inherit input()
        interface Polymorph
        [<Erase>]
        member val asChild: input -> HtmlElement = undefined with get,set
    [<Import("AngleSlider.Label", angleSlider)>]
    type Label
        /// <summary>
        /// <code>
        /// [data-scope] : angle-slider
        /// [data-part] : label
        /// [data-disabled]
        /// [data-invalid]
        /// [data-readonly]
        /// </code>
        /// </summary>
        () =
        inherit label()
        interface Polymorph
        [<Erase>]
        member val asChild: label -> HtmlElement = undefined with get,set
    [<Import("AngleSlider.MarkerGroup", angleSlider)>]
    type MarkerGroup() =
        inherit div()
        interface Polymorph
    [<Import("AngleSlider.Marker", angleSlider)>]
    type Marker
        /// <summary>
        /// <code>
        /// --marker-value : the marker value value for the marker
        /// [data-scope] : angle-slider
        /// [data-part] : marker
        /// [data-value] : the value of the item
        /// [data-state]
        /// [data-disabled]
        /// </code>
        /// </summary>
        () =
        inherit div()
        interface Polymorph
        [<Erase>]
        member val value: float = undefined with get,set
    [<Import("AngleSlider.RootProvider", angleSlider)>]
    type RootProvider() =
        inherit div()
        interface Polymorph
        [<Erase>]
        member val value: Accessor<AngleSliderApi> = undefined with get,set
        [<Erase>]
        member val asChild: div -> HtmlElement = undefined with get,set
    [<Import("AngleSlider.Thumb", angleSlider)>]
    type Thumb
        /// <summary>
        /// <code>
        /// [data-scope] : angle-slider
        /// [data-part] : thumb
        /// [data-disabled]
        /// [data-invalid]
        /// [data-readonly]
        /// </code>
        /// </summary>
        () =
        inherit div()
        interface Polymorph
        [<Erase>]
        member val asChild: div -> HtmlElement = undefined with get,set
    [<Import("AngleSlider.ValueText", angleSlider)>]
    type ValueText () =
        inherit div()
        interface Polymorph
        [<Erase>]
        member val asChild: div -> HtmlElement = undefined with get,set
