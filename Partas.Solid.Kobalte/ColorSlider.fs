namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid

[<Import("Root", Spec.colorSlider)>]
type ColorSlider() =
    inherit div()
    interface Polymorph
    /// <summary>
    /// The controlled values of the slider.
    /// </summary>
    [<Erase>] member val value: Color = JS.undefined with get,set
    /// <summary>
    /// The value of the slider when initially rendered.
    /// </summary>
    [<Erase>] member val defaultValue: Color = JS.undefined with get,set
    /// <summary>
    /// Called when the value changes.
    /// </summary>
    [<Erase>] member val onChange: (Color -> unit) = JS.undefined with get,set
    /// <summary>
    /// Called when the value changes at the end of an interaction.
    /// </summary>
    [<Erase>] member val onChangeEnd: (Color -> unit) = JS.undefined with get,set
    /// <summary>
    /// The color channel that the slider manipulates.
    /// </summary>
    [<Erase>] member val channel: ColorChannel = JS.undefined with get,set
    /// <summary>
    /// The color space that the slider operates in. The <c>channel</c> must be in this color space.
    /// </summary>
    [<Erase>] member val colorSpace: ColorSpace = JS.undefined with get,set
    /// <summary>
    /// The orientation of the slider.
    /// </summary>
    [<Erase>] member val orientation: Enums.Orientation = JS.undefined with get,set
    /// <summary>
    /// A function to get the accessible label text representing the current value in a human-readable format.
    /// </summary>
    [<Erase>] member val getValueLabel: (Color -> string) = JS.undefined with get,set
    /// <summary>
    /// A unique identifier for the component.
    /// The id is used to generate id attributes for nested components.
    /// If no id prop is provided, a generated id will be used.
    /// </summary>
    [<Erase>] member val id: string = JS.undefined with get,set
    /// <summary>
    /// The name of the slider, used when submitting an HTML form.
    /// See <a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefname">MDN</a>.
    /// </summary>
    [<Erase>] member val name: string = JS.undefined with get,set
    /// <summary>
    /// Whether the slider should display its "valid" or "invalid" visual styling.
    /// </summary>
    [<Erase>] member val validationState: ValidationState = JS.undefined with get,set
    /// <summary>
    /// Whether the user must fill the slider before the owning form can be submitted.
    /// </summary>
    [<Erase>] member val required: bool = JS.undefined with get,set
    /// <summary>
    /// Whether the slider is disabled.
    /// </summary>
    [<Erase>] member val disabled: bool = JS.undefined with get,set
    /// <summary>
    /// Whether the slider is read only.
    /// </summary>
    [<Erase>] member val readOnly: bool = JS.undefined with get,set
    /// <summary>
    /// The localized strings of the component.
    /// </summary>
    [<Erase>] member val translations: obj = JS.undefined with get,set

[<Erase; RequireQualifiedAccess>]
module ColorSlider =
    [<Import("Description", Spec.colorSlider)>]
    type Description() =
        inherit ColorArea.Description()
        interface Polymorph
    [<Import("ErrorMessage", Spec.colorSlider)>]
    type ErrorMessage() =
        inherit ColorArea.ErrorMessage()
        interface Polymorph
    [<Import("Input", Spec.colorSlider)>]
    type Input() =
        inherit Slider.Input()
        interface Polymorph
    [<Import("Label", Spec.colorSlider)>]
    type Label() =
        inherit ColorArea.Label()
        interface Polymorph
    ///<inheritdoc cref="Partas.Solid.Kobalte.ColorAreaModule.Thumb"/>
    [<Import("Thumb", Spec.colorSlider)>]
    type Thumb() =
        inherit ColorArea.Thumb()
        interface Polymorph
    [<Import("Track", Spec.colorSlider)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Import("ValueLabel", Spec.colorSlider)>]
    type ValueLabel() =
        inherit Slider.ValueLabel()
        interface Polymorph
        
