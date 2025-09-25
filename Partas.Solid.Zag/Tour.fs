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
    [<JS.Pojo>]
    type StepActionMap(?next: (unit -> unit), ?prev: (unit -> unit), ?dismiss: (unit -> unit), ?goto: (string -> unit)) =
        [<DefaultValue>]
        val mutable next: (unit -> unit)

        [<DefaultValue>]
        val mutable prev: (unit -> unit)

        [<DefaultValue>]
        val mutable dismiss: (unit -> unit)

        [<DefaultValue>]
        val mutable goto: (string -> unit)

    type StepActionFn = StepActionMap -> unit
    [<Erase>]
    module StepBaseDetails =
        [<JS.Pojo>]
        type Offset(?mainAxis: int, ?crossAxis: int) =
            [<DefaultValue>]
            val mutable mainAxis: int

            [<DefaultValue>]
            val mutable crossAxis: int

    [<JS.Pojo>]
    type StepAction(?label: string, ?action: U2<StepActionType, StepActionFn>, ?attrs: obj) =
        [<DefaultValue>]
        val mutable label: string

        [<DefaultValue>]
        val mutable action: U2<StepActionType, StepActionFn>

        [<DefaultValue>]
        val mutable attrs: obj

    [<JS.Pojo>]
    type StepBaseDetails
        (
            ?``type``: StepType,
            ?target: (unit -> HTMLElement) option,
            ?title: obj,
            ?description: obj,
            ?placement: StepPlacement option,
            ?offset: StepBaseDetails.Offset,
            ?meta: obj,
            ?backdrop: bool,
            ?arrow: bool,
            ?actions: StepAction[]
        ) =
        [<DefaultValue>]
        val mutable ``type``: StepType

        [<DefaultValue>]
        val mutable target: (unit -> HTMLElement) option

        [<DefaultValue>]
        val mutable title: obj

        [<DefaultValue>]
        val mutable description: obj

        [<DefaultValue>]
        val mutable placement: StepPlacement option

        [<DefaultValue>]
        val mutable offset: StepBaseDetails.Offset

        [<DefaultValue>]
        val mutable meta: obj

        [<DefaultValue>]
        val mutable backdrop: bool

        [<DefaultValue>]
        val mutable arrow: bool

        [<DefaultValue>]
        val mutable actions: StepAction[]

    [<JS.Pojo>]
    type StepEffectArgs
        (
            ?next: unit -> unit,
            ?goto: string -> unit,
            ?dismiss: unit -> unit,
            ?show: unit -> unit,
            ?update: StepBaseDetails -> unit,
            ?target: unit -> HTMLElement option
        ) =
        [<DefaultValue>]
        val mutable next: (unit -> unit)

        [<DefaultValue>]
        val mutable goto: (string -> unit)

        [<DefaultValue>]
        val mutable dismiss: (unit -> unit)

        [<DefaultValue>]
        val mutable show: (unit -> unit)

        [<DefaultValue>]
        val mutable update: (StepBaseDetails -> unit)

        [<DefaultValue>]
        val mutable target: (unit -> HTMLElement option)

    [<JS.Pojo>]
    type StepDetails(
        ?id: string,
        ?effect: (StepEffectArgs -> unit -> unit),
        ?``type``: StepType,
        ?target: (unit -> HTMLElement) option,
        ?title: obj,
        ?description: obj,
        ?placement: StepPlacement option,
        ?offset: StepBaseDetails.Offset,
        ?meta: obj,
        ?backdrop: bool,
        ?arrow: bool,
        ?actions: StepAction[]
        ) =
        [<DefaultValue>]
        val mutable id: string

        [<DefaultValue>]
        val mutable effect: (StepEffectArgs -> unit -> unit)
        
        [<DefaultValue>]
        val mutable ``type``: StepType

        [<DefaultValue>]
        val mutable target: (unit -> HTMLElement) option

        [<DefaultValue>]
        val mutable title: obj

        [<DefaultValue>]
        val mutable description: obj

        [<DefaultValue>]
        val mutable placement: StepPlacement option

        [<DefaultValue>]
        val mutable offset: StepBaseDetails.Offset

        [<DefaultValue>]
        val mutable meta: obj

        [<DefaultValue>]
        val mutable backdrop: bool

        [<DefaultValue>]
        val mutable arrow: bool

        [<DefaultValue>]
        val mutable actions: StepAction[]
    [<JS.Pojo>]
    type StepChangeDetails(?stepId: string option, ?stepIndex: int, ?totalSteps: int, ?complete: bool, ?progress: int) =
        [<DefaultValue>]
        val mutable stepId: string option

        [<DefaultValue>]
        val mutable stepIndex: int

        [<DefaultValue>]
        val mutable totalSteps: int

        [<DefaultValue>]
        val mutable complete: bool

        [<DefaultValue>]
        val mutable progress: int

    [<JS.Pojo>]
    type StepsChangeDetails(?steps: StepDetails[]) =
        [<DefaultValue>]
        val mutable steps: StepDetails[]

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
