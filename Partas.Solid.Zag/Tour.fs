namespace Partas.Solid.ZagJs
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Partas.Solid
open Browser.Types
[<Erase>]
module Tour =
    [<Erase>]
    module Spec =
        [<StringEnum>]
        type AnatomyParts =
            | Content
            | Title
            | ActionTrigger
            | CloseTrigger
            | ProgressText
            | Description
            | Positioner
            | Arrow
            | ArrowTip
            | Backdrop
            | Spotlight
    [<StringEnum>]
    type StepType =
        | Tooltip
        | Dialog
        | Wait
        | Floating
    [<StringEnum>]
    type StepActionType =
        | Next
        | Prev
        | Dismiss
    [<StringEnum(CaseRules.KebabCase)>]
    type StepPlacement =
        | Center
        | TopStart
        | TopEnd
        | RightStart
        | RightEnd
        | BottomStart
        | BottomEnd
        | LeftStart
        | LeftEnd
        | Top
        | Bottom
        | Right
        | Left
    type StepActionMap =
        abstract next: (unit -> unit) with get,set
        abstract prev: (unit -> unit) with get,set
        abstract dismiss: (unit -> unit) with get,set
        abstract goto: (string -> unit) with get,set
    type StepActionFn = StepActionMap -> unit
    [<Erase>]
    module StepBaseDetails =
        type Offset =
            abstract mainAxis: int with get,set
            abstract crossAxis: int with get,set
    type StepAction =
        abstract label: string with get,set
        abstract action: U2<StepActionType, StepActionFn> with get,set
        abstract attrs: obj with get,set
    type StepBaseDetails =
        abstract ``type``: StepType with get,set
        abstract target: (unit -> HTMLElement) option with get,set
        abstract title: obj with get,set
        abstract description: obj with get,set
        abstract placement: StepPlacement option with get,set
        abstract offset: StepBaseDetails.Offset with get,set
        abstract meta: obj with get,set
        abstract backdrop: bool with get,set
        abstract arrow: bool with get,set
        abstract actions: StepAction[] with get,set
    type StepEffectArgs =
        abstract next: (unit -> unit) with get,set
        abstract goto: (string -> unit) with get,set
        abstract dismiss: (unit -> unit) with get,set
        abstract show: (unit -> unit) with get,set
        abstract update: (StepBaseDetails -> unit) with get,set
        abstract target: (unit -> HTMLElement option) option
    type StepDetails =
        inherit StepBaseDetails
        abstract id: string with get,set
        abstract effect: (StepEffectArgs -> unit -> unit) with get,set
    type StepChangeDetails =
        abstract stepId: string option
        abstract stepIndex: int
        abstract totalSteps: int
        abstract complete: bool
        abstract progress: int
    type StepsChangeDetails =
        abstract steps: StepDetails[]
    [<StringEnum(CaseRules.KebabCase)>]
    type StepStatus =
        | Idle
        | Started
        | Skipped
        | Completed
        | Dismissed
        | NotFound
    type StatusChangeDetails =
        abstract status: StepStatus
        abstract stepId: string option
        abstract stepIndex: int
    
    type ProgressTextDetails =
        abstract current: int
        abstract total: int
    type IntlTranslations =
        abstract progressText: details: ProgressTextDetails -> string
        abstract nextStep: string
        abstract prevStep: string
        abstract close: string
        abstract skip: string
    type ElementIds =
        abstract content: string
        abstract title: string
        abstract description: string
        abstract positioner: string
        abstract backdrop: string
        abstract arrow: string
    [<Pojo>]
    type StepActionTriggerProps(
        action: StepAction
        ) =
        member val action = action with get,set
[<Interface>]
type TourProps =
    inherit DirectionProperty
    inherit CommonProperties
    inherit InteractionOutsideHandler
    /// <summary>
    /// The ids of the elements in the tour. Useful for composition.
    /// </summary>
    abstract member ids: obj option with get, set
    /// <summary>
    /// The steps of the tour
    /// </summary>
    abstract member steps: Tour.StepDetails[] with get, set
    /// <summary>
    /// The id of the currently highlighted step
    /// </summary>
    abstract member stepId: string with get, set
    /// <summary>
    /// Callback when the highlighted step changes
    /// </summary>
    abstract member onStepChange: (Tour.StepChangeDetails -> unit) with get, set
    /// <summary>
    /// Callback when the steps change
    /// </summary>
    abstract member onStepsChange: (Tour.StepsChangeDetails -> unit) with get, set
    /// <summary>
    /// Callback when the tour is opened or closed
    /// </summary>
    abstract member onStatusChange: (Tour.StatusChangeDetails -> unit) with get, set
    /// <summary>
    /// Whether to close the tour when the user clicks outside the tour
    /// </summary>
    abstract member closeOnInteractOutside: bool with get, set
    /// <summary>
    /// Whether to close the tour when the user presses the escape key
    /// </summary>
    abstract member closeOnEscape: bool with get, set
    /// <summary>
    /// Whether to allow keyboard navigation (right/left arrow keys to navigate between steps)
    /// </summary>
    abstract member keyboardNavigation: bool with get, set
    /// <summary>
    /// Prevents interaction with the rest of the page while the tour is open
    /// </summary>
    abstract member preventInteraction: bool with get, set
    /// <summary>
    /// The offsets to apply to the spotlight
    /// </summary>
    abstract member spotlightOffset: Point with get, set
    /// <summary>
    /// The radius of the spotlight clip path
    /// </summary>
    abstract member spotlightRadius: float with get, set
    /// <summary>
    /// The translations for the tour
    /// </summary>
    abstract member translations: Tour.IntlTranslations with get, set

[<Interface>]
type TourApi =
    /// <summary>
    /// Whether the tour is open
    /// </summary>
    abstract member ``open``: bool with get, set
    /// <summary>
    /// The total number of steps
    /// </summary>
    abstract member totalSteps: float with get, set
    /// <summary>
    /// The index of the current step
    /// </summary>
    abstract member stepIndex: float with get, set
    /// <summary>
    /// The current step details
    /// </summary>
    abstract member step: obj option with get, set
    /// <summary>
    /// Whether there is a next step
    /// </summary>
    abstract member hasNextStep: bool with get, set
    /// <summary>
    /// Whether there is a previous step
    /// </summary>
    abstract member hasPrevStep: bool with get, set
    /// <summary>
    /// Whether the current step is the first step
    /// </summary>
    abstract member firstStep: bool with get, set
    /// <summary>
    /// Whether the current step is the last step
    /// </summary>
    abstract member lastStep: bool with get, set
    /// <summary>
    /// Add a new step to the tour
    /// </summary>
    abstract member addStep: (Tour.StepDetails -> unit) with get, set
    /// <summary>
    /// Remove a step from the tour
    /// </summary>
    abstract member removeStep: (string -> unit) with get, set
    /// <summary>
    /// Update a step in the tour with partial details
    /// </summary>
    abstract member updateStep: id: string * stepOverrides: Tour.StepDetails -> unit
    /// <summary>
    /// Set the steps of the tour
    /// </summary>
    abstract member setSteps: (Tour.StepDetails[] -> unit) with get, set
    /// <summary>
    /// Set the current step of the tour
    /// </summary>
    abstract member setStep: (string -> unit) with get, set
    /// <summary>
    /// Start the tour at a specific step (or the first step if not provided)
    /// </summary>
    abstract member start: (string option -> unit) with get, set
    /// <summary>
    /// Check if a step is valid
    /// </summary>
    abstract member isValidStep: (string -> bool) with get, set
    /// <summary>
    /// Check if a step is visible
    /// </summary>
    abstract member isCurrentStep: (string -> bool) with get, set
    /// <summary>
    /// Move to the next step
    /// </summary>
    abstract member next: (unit -> unit) with get, set
    /// <summary>
    /// Move to the previous step
    /// </summary>
    abstract member prev: (unit -> unit) with get, set
    /// <summary>
    /// Returns the progress text
    /// </summary>
    abstract member getProgressText: (unit -> string) with get, set
    /// <summary>
    /// Returns the progress percent
    /// </summary>
    abstract member getProgressPercent: (unit -> float) with get, set
    abstract member getBackdropProps: (unit -> HtmlTag) with get, set
    abstract member getSpotlightProps: (unit -> HtmlTag) with get, set
    abstract member getProgressTextProps: (unit -> HtmlTag) with get, set
    abstract member getPositionerProps: (unit -> HtmlTag) with get, set
    abstract member getArrowProps: (unit -> HtmlTag) with get, set
    abstract member getArrowTipProps: (unit -> HtmlTag) with get, set
    abstract member getContentProps: (unit -> HtmlTag) with get, set
    abstract member getTitleProps: (unit -> HtmlTag) with get, set
    abstract member getDescriptionProps: (unit -> HtmlTag) with get, set
    abstract member getCloseTriggerProps: (unit -> button) with get, set
    abstract member getActionTriggerProps: (Tour.StepActionTriggerProps -> button) with get, set
