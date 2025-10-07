namespace Partas.Solid.Kobalte

open Browser.Types
open Fable.Core
open Partas.Solid




[<Erase; Import("Root", Spec.slider)>]
type Slider() =
    inherit div()
    interface Polymorph
    [<Erase>] member val value : int[] = JS.undefined with get,set
    [<Erase>] member val defaultValue : int[] = JS.undefined with get,set
    [<Erase>] member val onChange : int[] -> unit = JS.undefined with get,set
    [<Erase>] member val onChangeEnd : int[] -> unit = JS.undefined with get,set
    [<Erase>] member val inverted : bool = JS.undefined with get,set
    [<Erase>] member val minValue : int = JS.undefined with get,set
    [<Erase>] member val maxValue : int = JS.undefined with get,set
    [<Erase>] member val step : int = JS.undefined with get,set
    [<Erase>] member val minStepsBetweenThumbs : int = JS.undefined with get,set
    [<Erase>] member val getValueLabel : {| values: int[] ; min : int ; max : int |} -> string = JS.undefined with get,set
    [<Erase>] member val orientation : Orientation = JS.undefined with get,set
    [<Erase>] member val name : string = JS.undefined with get,set
    [<Erase>] member val validationState : ValidationState = JS.undefined with get,set
    [<Erase>] member val required : bool = JS.undefined with get,set
    [<Erase>] member val disabled : bool = JS.undefined with get,set
    [<Erase>] member val readOnly : bool = JS.undefined with get,set

[<Erase; RequireQualifiedAccess>]
module Slider =
    [<Erase; Import("Track", Spec.slider)>]
    type Track() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Fill", Spec.slider)>]
    type Fill() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Thumb", Spec.slider)>]
    type Thumb() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Input", Spec.slider)>]
    type Input() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ValueLabel", Spec.slider)>]
    type ValueLabel() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Label", Spec.slider)>]
    type Label() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Description", Spec.slider)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.slider)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph


[<Erase; AutoOpen>]
module SliderContext =
    [<StringEnum>]
    type Side =
        | Left
        | Top
        | Bottom
        | Right
    [<AllowNullLiteral; Interface>]
    type SliderState =
        abstract values: float[] Accessor
        abstract getThumbValue: index: float -> float
        abstract setThumbValue: index: float * value: float -> unit
        abstract getThumbPercent: index: float -> float
        abstract setThumbPercent: index: float * percent: float -> unit
        abstract isThumbDragging: index: float -> bool
        abstract setThumbDragging: index: float * dragging: bool -> unit
        abstract focusedThumb: Accessor<float option>
        abstract setFocusedThumb: index: float option -> unit
        abstract getValuePercent: value: float -> float
        abstract getThumbValueLabel: index: float -> string
        abstract getFormattedValue: value: float -> string
        abstract getThumbMinValue: index: float -> float
        abstract getThumbMaxValue: index: float -> float
        abstract getPercentValue: percent: float -> float
        abstract isThumbEditable: index: float -> bool
        abstract setThumbEditable: index: float * editable: bool -> unit
        abstract incrementThumb: index: float * ?stepSize: float -> unit
        abstract decrementThumb: index: float * ?stepSize: float -> unit
        abstract step: Accessor<float>
        abstract pageSize: Accessor<float>
        abstract orientation: Accessor<Orientation>
        abstract isDisabled: Accessor<bool>
        abstract setValues: U2<float[],(float[] -> float[])> -> unit
        abstract resetValues: unit -> unit
    [<AllowNullLiteral; Interface>]
    type SliderDataSet =
        inherit FormControlDataSet
        abstract ``data-orientation``: Orientation option
    
    [<JS.Pojo>]
    type GetValueLabelParams(values: float[], min: float, max: float) =
        [<Erase>] member val values: float[] = JS.undefined with get,set
        [<Erase>] member val min: float = JS.undefined with get,set
        [<Erase>] member val max: float = JS.undefined with get,set
        
    [<AllowNullLiteral; Interface>]
    type SliderContext =
        abstract dataset: SliderDataSet Accessor
        abstract state: SliderState
        abstract thumbs: Accessor<CollectionItem[]>
        abstract setThumbs: Setter<CollectionItem[]>
        abstract onSlideStart: (float * float -> unit) option
        abstract onSlideMove: ({|deltaX: float; deltaY: float|} -> unit) option
        abstract onSlideEnd: (unit -> unit) option
        abstract onStepkeyDown: event: KeyboardEvent * index: float -> unit
        abstract isSlidingFromleft: unit -> bool
        abstract isSlidingFromBottom: unit -> bool
        abstract trackRef: Accessor<HTMLElement option>
        abstract startEdge: Accessor<Side>
        abstract endEdge: Accessor<Side>
        abstract minValue: Accessor<float>
        abstract maxValue: Accessor<float>
        abstract inverted: Accessor<bool>
        abstract registerTrack: ref: HTMLElement -> unit
        abstract generateId: part: string -> string
        abstract getValueLabel: (GetValueLabelParams -> string) option

    [<ImportMember(Spec.slider)>]
    let useSliderContext(): SliderContext = jsNative
