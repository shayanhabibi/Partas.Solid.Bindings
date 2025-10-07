namespace Partas.Solid.Kobalte

open Fable.Core.JS
open Partas.Solid
open Fable.Core

[<Import("Root", Spec.colorSwatch)>]
type ColorSwatch() =
    inherit div()
    interface Polymorph
    /// <summary>
    /// The color value to display in the swatch.
    /// </summary>
    [<Erase>] member val value: Color = undefined with get,set
    /// <summary>
    /// A localized accessible name for the color.
    /// By default, a description is generated from the color value,
    /// but this can be overridden if you have a more specific color
    /// name (e.g. Pantone colors).
    /// </summary>
    [<Erase>] member val colorName: string = undefined with get,set
    /// <summary>
    /// The localized strings of the component.
    /// </summary>
    [<Erase>] member val translations: obj = undefined with get,set
