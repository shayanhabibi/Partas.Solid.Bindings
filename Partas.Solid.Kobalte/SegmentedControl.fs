namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid


[<Erase; RequireQualifiedAccess>]
module SegmentedControl =
    /// <summary>
    /// <param name="data-valid">Present when the segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the segmented control is invalid according to the validation rules.</param>
    /// <param name="data-required">Present when the user must check a segmented control item before the owning form can be submitted.</param>
    /// <param name="data-disabled">Present when the segmented control is disabled.</param>
    /// <param name="data-readonly">Present when the segmented control is read only.</param>
    /// </summary>
    [<Import("Label", Spec.segmentedControl)>]
    type Label() =
        inherit span()
        interface Polymorph
    /// <summary>
    /// <param name="data-valid">Present when the segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the segmented control is invalid according to the validation rules.</param>
    /// <param name="data-required">Present when the user must check a segmented control item before the owning form can be submitted.</param>
    /// <param name="data-disabled">Present when the segmented control is disabled.</param>
    /// <param name="data-readonly">Present when the segmented control is read only.</param>
    /// </summary>
    [<Import("Description", Spec.segmentedControl)>]
    type Description() =
        inherit div()
        interface Polymorph
    /// <summary>
    /// <param name="data-valid">Present when the segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the segmented control is invalid according to the validation rules.</param>
    /// <param name="data-required">Present when the user must check a segmented control item before the owning form can be submitted.</param>
    /// <param name="data-disabled">Present when the segmented control is disabled.</param>
    /// <param name="data-readonly">Present when the segmented control is read only.</param>
    /// </summary>
    [<Import("ErrorMessage", Spec.segmentedControl)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        /// Used to force mounting when more control is needed. Useful when controlling animation with SolidJS animation libraries.
        [<Erase>] member val forceMount: bool = JS.undefined with get,set
    [<Import("Indicator", Spec.segmentedControl)>]
    type Indicator() =
        inherit div()
        interface Polymorph
    /// <summary>
    /// <param name="data-valid">Present when the parent segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the parent segmented control is invalid according to the validation rules.</param>
    /// <param name="data-checked">Present when the segmented control checked.</param>
    /// <param name="data-disabled">Present when the segmented control disabled.</param>
    /// </summary>
    [<Import("Item", Spec.segmentedControl)>]
    type Item() =
        inherit div()
        interface Polymorph
        /// The value of the item's radio button, used when submitting an HTML form.
        [<Erase>] member val value: string = JS.undefined with get,set
        /// Whether the item's radio button is disabled or not.
        [<Erase>] member val disabled: bool = JS.undefined with get,set
    /// <summary>
    /// <param name="data-valid">Present when the parent segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the parent segmented control is invalid according to the validation rules.</param>
    /// <param name="data-checked">Present when the segmented control checked.</param>
    /// <param name="data-disabled">Present when the segmented control disabled.</param>
    /// </summary>
    [<Import("ItemInput", Spec.segmentedControl)>]
    type ItemInput() =
        inherit input()
        interface Polymorph
    /// <summary>
    /// <param name="data-valid">Present when the parent segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the parent segmented control is invalid according to the validation rules.</param>
    /// <param name="data-checked">Present when the segmented control checked.</param>
    /// <param name="data-disabled">Present when the segmented control disabled.</param>
    /// </summary>
    [<Import("ItemControl", Spec.segmentedControl)>]
    type ItemControl() =
        inherit div()
        interface Polymorph
    /// <summary>
    /// <param name="data-valid">Present when the parent segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the parent segmented control is invalid according to the validation rules.</param>
    /// <param name="data-checked">Present when the segmented control checked.</param>
    /// <param name="data-disabled">Present when the segmented control disabled.</param>
    /// </summary>
    [<Import("ItemIndicator", Spec.segmentedControl)>]
    type ItemIndicator() =
        inherit div()
        interface Polymorph
        /// Used to force mounting when more control is needed. Useful when controlling animation with SolidJS animation libraries.
        [<Erase>] member val forceMount: bool = JS.undefined with get,set
    /// <summary>
    /// <param name="data-valid">Present when the parent segmented control is valid according to the validation rules.</param>
    /// <param name="data-invalid">Present when the parent segmented control is invalid according to the validation rules.</param>
    /// <param name="data-checked">Present when the segmented control checked.</param>
    /// <param name="data-disabled">Present when the segmented control disabled.</param>
    /// </summary>
    [<Import("ItemLabel", Spec.segmentedControl)>]
    type ItemLabel() =
        inherit label()
        interface Polymorph
    [<Import("ItemDescription", Spec.segmentedControl)>]
    type ItemDescription() =
        inherit div()
        interface Polymorph

/// <summary>
/// <param name="data-valid">Present when the segmented control is valid according to the validation rules.</param>
/// <param name="data-invalid">Present when the segmented control is invalid according to the validation rules.</param>
/// <param name="data-required">Present when the user must check a segmented control item before the owning form can be submitted.</param>
/// <param name="data-disabled">Present when the segmented control is disabled.</param>
/// <param name="data-readonly">Present when the segmented control is read only.</param>
/// </summary>
/// <remarks>
/// The <c>role="presentation"</c> is required for all non content elements between the SegmentedControl and
/// SegmentedControl.Item due to a bug in Chromium based browsers that incorrectly parse semantics and break screen readers.
/// </remarks>
[<Import("Root", Spec.segmentedControl)>] // v0.13.10
type SegmentedControl() =
    inherit div()
    interface Polymorph
    /// The controlled value of the item's radio button to check.
    [<Erase>] member val value: string = JS.undefined with get,set
    /// The value of the item's radio button that should be checked when initially rendered. Useful when you do not need to control the state of the radio buttons.
    [<Erase>]
    member val defaultValue: string = JS.undefined with get,set
    /// Event handler called when the value changes.
    [<Erase>]
    member val onChange: (string -> unit) = JS.undefined with get,set
    /// The axis the segmented control items should align with.
    [<Erase>]
    member val orientation: Orientation = JS.undefined with get,set
    /// The name of the segmented control. Submitted with its owning form as part of a name/value pair.
    [<Erase>]
    member val name: string = JS.undefined with get,set
    /// Whether the segmented control should display its "valid" or "invalid" visual styling.
    [<Erase>]
    member val validationState: ValidationState = JS.undefined with get,set
    /// Whether the user must check a segmented control item before the owning form can be submitted.
    [<Erase>]
    member val required: bool = JS.undefined with get,set
    /// Whether the segmented control is disabled.
    [<Erase>]
    member val disabled: bool = JS.undefined with get,set
    /// Whether the segmented control items can be selected but not changed by the user.
    [<Erase>]
    member val readOnly: bool = JS.undefined with get,set
    
[<AutoOpen; Erase>]
module SegmentedControlContext =
    [<AllowNullLiteral; Interface>]
    type SegmentedControlContext =
        abstract member value: Accessor<string option> with get
        abstract member defaultValue: Accessor<string option> with get
        abstract member orientation: Accessor<Orientation option> with get
        abstract member root: Accessor<Browser.Types.HTMLElement> with get
        abstract member selectedItem: Accessor<Browser.Types.HTMLElement> with get
        abstract member setSelectedItem: Setter<Browser.Types.HTMLElement> with get
    
    [<Import("useSegmentedControlContext", Spec.segmentedControl)>]
    let useSegmentedControlContext (): SegmentedControlContext = jsNative
