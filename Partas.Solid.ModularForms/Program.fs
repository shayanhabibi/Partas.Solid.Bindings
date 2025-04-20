namespace Partas.Solid.ModularForms

open System.Text.RegularExpressions
open Browser.Types
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS
open System

#nowarn 49

[<AutoOpen; Erase>]
module private Helpers =
    [<Literal>]
    let path = "@modular-forms/solid"

[<StringEnum; RequireQualifiedAccess>]
type FormResponseStatus =
    | Info
    | Error
    | Success
[<Interface>]
type FormResponse<'Response> =
    abstract status: FormResponseStatus option
    abstract message: string option
    abstract data: 'Response option
type SubmitHandler<'T, 'R> = 'T -> SubmitEvent -> U2<Promise<'R>, 'R>
/// Type that defines the errors of a form. It is an object that contains an entry for each field or field array with
/// an error. The key of an entry is the name of a field or a field array, and thhe value is the error message
[<Erase>]
type FormErrors = JS.Object
[<Import("FormError", path)>]
type FormError() =
    [<Erase>] new(message: string) = FormError()
    [<Erase>] new(message: string, errors: FormErrors) = FormError()
    [<Erase>] new(errors: FormErrors) = FormError()
[<Interface; AllowNullLiteral>]
type FormStore<'ValueType, 'Response> =
    abstract element: HTMLFormElement option
    abstract submitCount: int
    abstract submitting: bool
    abstract submitted: bool
    abstract validating: bool
    abstract touched: bool
    abstract dirty: bool
    abstract invalid: bool
    abstract response: FormResponse<'Response>
[<Interface; AllowNullLiteral>]
type FieldStore<'ValueType> =
    abstract name: string
    abstract value: 'ValueType option
    abstract error: string
    abstract active: bool
    abstract touched: bool
    abstract dirty: bool
[<Interface; AllowNullLiteral>]
type FieldElementProps =
    abstract name: string
    abstract autofocus: bool
    abstract ref: (Element -> unit)
    abstract onInput: (InputEvent -> unit)
    abstract onChange: (Event -> unit)
    abstract onBlur: (FocusEvent -> unit)
[<Interface; AllowNullLiteral>]
type FieldArrayStore =
    abstract name: string
    /// Does not contain value of fields, but only a random unique number
    abstract items: int[]
    abstract error: string
    abstract active: bool
    abstract touched: bool
    abstract dirty: bool
type TransformField<'ValueType> = 'ValueType option -> Event -> 'ValueType option 
type CustomValidator<'T> = 'T option  -> Promise<string>
type Validator<'T> = 'T option -> string
type ValidateFieldArray = float[] -> U2<Promise<string>, string>
type ValidateForm<'T> = 'T -> U2<FormErrors, Promise<FormErrors>>

[<StringEnum; RequireQualifiedAccess>]
type ValidateOn =
    | Touched
    | Input
    | Change
    | Blur
    | Submit

[<StringEnum; RequireQualifiedAccess>]
type ModularFormsType =
    | String
    | [<CompiledName("string[]")>] StringArray
    | Number
    | Boolean
    | Submit
    | File
    | [<CompiledName("File[]")>] FileArray
    | Date

type private DV = DefaultValueAttribute

[<JS.Pojo>]
type FormOptions<'T>
    (
        initialValues: 'T
        ,?validate: ValidateForm<'T>
        ,?validateOn: ValidateOn
        ,?revalidateOn: ValidateOn
    ) = class end

[<Erase>]
type Field<'ValueType, 'Response>() =
    interface HtmlElement
    [<DV>] val mutable of': FormStore<'ValueType, 'Response>
    [<DV>] val mutable name: string
    [<DV>] val mutable type': ModularFormsType
    [<DV>] val mutable validate: U2<Validator<'ValueType>, Validator<'ValueType>[]>
    [<DV>] val mutable validateOn: ValidateOn
    [<DV>] val mutable revalidateOn: ValidateOn
    [<DV>] val mutable transform: TransformField<'ValueType>
    [<DV>] val mutable keepActive: bool
    [<DV>] val mutable keepState: bool
    [<Erase>]
    member this.children with get(): HtmlElement = JS.undefined
    [<Erase>]
    member inline _.Combine
        ([<InlineIfLambda>] PARTAS_FIRST: HtmlContainerFun, [<InlineIfLambda>] PARTAS_SECOND: HtmlContainerFun)
        : HtmlContainerFun =
        fun PARTAS_BUILDER ->
            PARTAS_FIRST PARTAS_BUILDER
            PARTAS_SECOND PARTAS_BUILDER
    [<Erase>]
    member inline _.Delay([<InlineIfLambda>] PARTAS_DELAY: unit -> HtmlContainerFun) : HtmlContainerFun = PARTAS_DELAY()
    [<Erase>]
    member inline _.Zero() : HtmlContainerFun = ignore
    [<Erase>]
    member inline _.Yield(PARTAS_ELEMENT: FieldStore<'ValueType> -> FieldElementProps -> HtmlContainerFun) : HtmlContainerFun = fun PARTAS_CONT -> ignore PARTAS_ELEMENT
[<Erase>]
type Form<'T, 'R>() =
    inherit RegularNode()
    [<DV>] val mutable of': FormStore<'T, 'R>
    [<DV>] val mutable onSubmit: SubmitHandler<'T, 'R>
    [<DV>] val mutable keepResponse: bool
    [<DV>] val mutable shouldActive: bool
    [<DV>] val mutable shouldTouched: bool
    [<DV>] val mutable shouldDirty: bool
    [<DV>] val mutable shouldFocus: bool
[<Erase>]
type FieldArray<'ValueType, 'Response>() =
    interface HtmlElement
    [<DV>] val mutable of': FormStore<'ValueType, 'Response>
    [<DV>] val mutable name: string
    [<DV>] val mutable type': ModularFormsType
    [<DV>] val mutable validate: U2<ValidateFieldArray, ValidateFieldArray[]>
    [<DV>] val mutable validateOn: ValidateOn
    [<DV>] val mutable revalidateOn: ValidateOn
    [<DV>] val mutable keepActive: bool
    [<DV>] val mutable keepState: bool
    [<Erase>]
    member this.children with get(): HtmlElement = JS.undefined
    [<Erase>]
    member inline _.Combine
        ([<InlineIfLambda>] PARTAS_FIRST: HtmlContainerFun, [<InlineIfLambda>] PARTAS_SECOND: HtmlContainerFun)
        : HtmlContainerFun =
        fun PARTAS_BUILDER ->
            PARTAS_FIRST PARTAS_BUILDER
            PARTAS_SECOND PARTAS_BUILDER
    [<Erase>]
    member inline _.Delay([<InlineIfLambda>] PARTAS_DELAY: unit -> HtmlContainerFun) : HtmlContainerFun = PARTAS_DELAY()
    [<Erase>]
    member inline _.Zero() : HtmlContainerFun = ignore
    [<Erase>]
    member inline _.Yield(PARTAS_ELEMENT: FieldArrayStore -> HtmlContainerFun) : HtmlContainerFun = fun PARTAS_CONT -> ignore PARTAS_ELEMENT

[<Erase>]
module FormErrors =
    let toArray (formErrors: FormErrors) =
        Constructors.Object.entries formErrors
        |> _.ToArray()
        |> unbox<(string * string) array>
    let inline toList formErrors =
        formErrors
        |> toArray
        |> Array.toList
[<StringEnum>]
type OnCustomAction =
    | Input
    | Change
    | Blur

[<Interface; AllowNullLiteral>]
type ModularFormComponents<'Data, 'Response> =
    abstract Form: Form<'Data, 'Response> with get
    abstract Field: Field<'Data, 'Response> with get
    abstract FieldArray: FieldArray<'Data, 'Response> with get

type SolidModularForm<'Data, 'Response> = FormStore<'Data, 'Response> * ModularFormComponents<'Data, 'Response> 

[<AutoOpen; Erase>]
type ModularFormsBindings =
    [<ImportMember(path)>]
    static member createForm<'Data, 'Response>(): SolidModularForm<'Data, 'Response> = jsNative
    [<ImportMember(path)>]
    static member clearError(form: FormStore<'ValueType, 'Response>, name: string): unit = jsNative
    [<ImportMember(path)>]
    static member clearResponse(form: FormStore<'ValueType, 'Response>): unit = jsNative
    [<ImportMember(path)>]
    static member focus(form: FormStore<'ValueType, 'Response>, name: string): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member getError(form: FormStore<'ValueType, 'Response>, name: string,
                           ?shouldActive: bool (*true*),
                           ?shouldTouched: bool (*false*),
                           ?shouldDirty: bool (*false*)): string option = jsNative
    [<ImportMember(path)>]
    static member getError(form: FormStore<'ValueType, 'Response>, name: string): string option = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member getErrors(form: FormStore<'ValueType, 'Response>, names: string,
                            ?shouldActive: bool,
                            ?shouldTouched: bool,
                            ?shouldDirty: bool): FormErrors = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member getErrors(form: FormStore<'ValueType, 'Response>, names: string[],
                            ?shouldActive: bool,
                            ?shouldTouched: bool,
                            ?shouldDirty: bool): FormErrors = jsNative
    [<ImportMember(path)>]
    static member getErrors(form: FormStore<'ValueType, 'Response>, names: string): FormErrors = jsNative
    [<ImportMember(path)>]
    static member getErrors(form: FormStore<'ValueType, 'Response>, names: string[]): FormErrors = jsNative
    // TODO - return types
    [<ImportMember(path); ParamObject(2)>]
    static member getValue(form: FormStore<'ValueType, 'Response>, name: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): obj option = jsNative
    [<ImportMember(path)>]
    static member getValue(form: FormStore<'ValueType, 'Response>, name: string): obj option = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member getValues(form: FormStore<'ValueType, 'Response>, names: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): obj option = jsNative
    [<ImportMember(path)>]
    static member getValues(form: FormStore<'ValueType, 'Response>, names: string): obj option = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member getValues(form: FormStore<'ValueType, 'Response>, names: string[],
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): obj option = jsNative
    [<ImportMember(path)>]
    static member getValues(form: FormStore<'ValueType, 'Response>, names: string[]): obj option = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member hasField(form: FormStore<'ValueType, 'Response>, name: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): bool = jsNative
    [<ImportMember(path)>]
    static member hasField(form: FormStore<'ValueType, 'Response>, name: string): bool = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member hasFieldArray(form: FormStore<'ValueType, 'Response>, name: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): bool = jsNative
    [<ImportMember(path)>]
    static member hasFieldArray(form: FormStore<'ValueType, 'Response>, name: string): bool = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member insert(form: FormStore<'ValueType, 'Response>, name:string,
                         ?at: int, //TODO value
                         ?value: obj): unit = jsNative
    [<ImportMember(path)>]
    static member insert(form: FormStore<'ValueType, 'Response>, name:string): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member move(form: FormStore<'ValueType, 'Response>, name:string,
                         ?from': int,
                         ?to': int): unit = jsNative
    [<ImportMember(path)>]
    static member move(form: FormStore<'ValueType, 'Response>, name:string): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member remove(form: FormStore<'ValueType, 'Response>, name:string,
                         ?at: int): unit = jsNative
    [<ImportMember(path)>]
    static member remove(form: FormStore<'ValueType, 'Response>, name:string): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member replace(form: FormStore<'ValueType, 'Response>, name:string,
                         ?at: int, // TODO value type
                         ?value: obj): unit = jsNative
    [<ImportMember(path)>]
    static member replace(form: FormStore<'ValueType, 'Response>, name:string): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member reset(form: FormStore<'ValueType, 'Response>, name:string,
                         ?initialValues: obj[],
                         ?initialValue: obj,
                         ?keepResponse: bool,
                         ?keepSubmitCount: bool,
                         ?keepSubmitted: bool,
                         ?keepValues: bool,
                         ?keepDirtyValues: bool,
                         ?keepItems: bool,
                         ?keepDirtyItems: bool,
                         ?keepErrors: bool,
                         ?keepTouched: bool,
                         ?keepDirty: bool): unit = jsNative
    [<ImportMember(path)>]
    static member reset(form: FormStore<'ValueType, 'Response>, name:string): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member reset(form: FormStore<'ValueType, 'Response>,
                         ?initialValues: obj[],
                         ?initialValue: obj,
                         ?keepResponse: bool,
                         ?keepSubmitCount: bool,
                         ?keepSubmitted: bool,
                         ?keepValues: bool,
                         ?keepDirtyValues: bool,
                         ?keepItems: bool,
                         ?keepDirtyItems: bool,
                         ?keepErrors: bool,
                         ?keepTouched: bool,
                         ?keepDirty: bool): unit = jsNative
    [<ImportMember(path)>]
    static member reset(form: FormStore<'ValueType, 'Response>): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member reset(form: FormStore<'ValueType, 'Response>, names: string[],
                         ?initialValues: obj[],
                         ?initialValue: obj,
                         ?keepResponse: bool,
                         ?keepSubmitCount: bool,
                         ?keepSubmitted: bool,
                         ?keepValues: bool,
                         ?keepDirtyValues: bool,
                         ?keepItems: bool,
                         ?keepDirtyItems: bool,
                         ?keepErrors: bool,
                         ?keepTouched: bool,
                         ?keepDirty: bool): unit = jsNative
    [<ImportMember(path)>]
    static member reset(form: FormStore<'ValueType, 'Response>, names: string[]): unit = jsNative
    [<ImportMember(path)>]
    static member setError(form: FormStore<'ValueType, 'Response>, name: string, error: string): unit = jsNative
    [<ImportMember(path); ParamObject(3)>]
    static member setError(form: FormStore<'ValueType, 'Response>, name: string, error: string, ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member setResponse(form: FormStore<'ValueType, 'Response>, response: obj (*TODO type*), ?duration: int): unit = jsNative
    [<ImportMember(path)>]
    static member setResponse(form: FormStore<'ValueType, 'Response>, response: obj (*TODO type*)): unit = jsNative
    [<ImportMember(path); ParamObject(3)>]
    static member setValue(form: FormStore<'ValueType, 'Response>, name: string, value: obj (*TODO type*),
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValidate: bool,
                           ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path)>]
    static member setValue(form: FormStore<'ValueType, 'Response>, name: string, value: obj (*TODO type*)): unit = jsNative
    [<ImportMember(path); ParamObject(3)>]
    static member setValues(form: FormStore<'ValueType, 'Response>, name: string, values: obj[] (*TODO type*),
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValidate: bool,
                           ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path)>]
    static member setValues(form: FormStore<'ValueType, 'Response>, name: string, values: obj[] (*TODO type*)): unit = jsNative
    [<ImportMember(path)>]
    static member submit(form: FormStore<'ValueType, 'Response>): unit = jsNative
    [<ImportMember(path)>]
    static member swap(form: FormStore<'ValueType, 'Response>, name: string,
                       ?at: int,
                       ?and': int): unit = jsNative
    [<ImportMember(path)>]
    static member swap(form: FormStore<'ValueType, 'Response>, name: string): unit = jsNative
    [<ImportMember(path)>]
    static member validate(form: FormStore<'ValueType, 'Response>): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member validate(form: FormStore<'ValueType, 'Response>, ?shouldActive: bool, ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path)>]
    static member validate(form: FormStore<'ValueType, 'Response>, name: string): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member validate(form: FormStore<'ValueType, 'Response>, name: string, ?shouldActive: bool, ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path)>]
    static member validate(form: FormStore<'ValueType, 'Response>, names: string[]): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member validate(form: FormStore<'ValueType, 'Response>, names: string[], ?shouldActive: bool, ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path)>] // todo type
    static member custom(requirement: (obj option -> bool), error: string): CustomValidator<obj> = jsNative
    [<ImportMember(path)>]
    static member email(error: string): Validator<string> = jsNative
    /// Can be used when 'T = string | string[] | int[]
    [<ImportMember(path)>]
    static member maxLength(requirement: int, error: string): Validator<'T> = jsNative
    [<ImportMember(path)>]
    static member maxRange(requirement: string, error: string): Validator<string> = jsNative
    [<ImportMember(path)>]
    static member maxRange(requirement: int, error: string): Validator<int> = jsNative
    [<ImportMember(path)>]
    static member maxRange(requirement: Date, error: string): Validator<Date> = jsNative
    [<ImportMember(path)>]
    static member maxSize(requirement: int, error: string): Validator<U2<File, File[]>> = jsNative
    [<ImportMember(path)>]
    static member maxTotalSize(requirement: int, error: string): Validator<File[]> = jsNative
    [<ImportMember(path)>]
    static member mimeType(requirement: string, error: string): Validator<U2<File, File[]>> = jsNative
    [<ImportMember(path)>]
    static member mimeType(requirement: string[], error: string): Validator<U2<File, File[]>> = jsNative
    [<ImportMember(path)>]
    static member minLength(requirement: int, error: string): Validator<'T> = jsNative
    [<ImportMember(path)>]
    static member minRange(requirement: string, error: string): Validator<string> = jsNative
    [<ImportMember(path)>]
    static member minRange(requirement: int, error: string): Validator<int> = jsNative
    [<ImportMember(path)>]
    static member minRange(requirement: Date, error: string): Validator<Date> = jsNative
    [<ImportMember(path)>]
    static member minSize(requirement: int, error: string): Validator<U2<File, File[]>> = jsNative
    [<ImportMember(path)>]
    static member minTotalSize(requirement: int, error: string): Validator<File[]> = jsNative
    [<ImportMember(path)>]
    static member pattern(requirement: Regex, error: string): Validator<string> = jsNative
    [<ImportMember(path)>]
    static member required(error: string): Validator<U2<obj, int[]>> = jsNative
    [<ImportMember(path)>]
    static member url(error: string): Validator<string> = jsNative
    [<ImportMember(path)>]
    static member value(requirement: string, error: string): Validator<string> = jsNative
    [<ImportMember(path)>]
    static member value(requirement: int, error: string): Validator<int> = jsNative
    [<ImportMember(path)>]
    static member value(requirement: float, error: string): Validator<float> = jsNative
    [<ImportMember(path); ParamObject(1)>] // TODO type
    static member toCustom(action: obj, ?on: OnCustomAction ): obj = jsNative
    [<ImportMember(path)>] // TODO type
    static member toCustom(action: obj): obj = jsNative
    [<ImportMember(path); ParamObject(0)>] // TODO type
    static member toLowerCase(on: OnCustomAction): obj = jsNative
    [<ImportMember(path)>] // TODO type
    static member toLowerCase(): obj = jsNative
    [<ImportMember(path); ParamObject(0)>] // TODO type
    static member toTrimmed(on: OnCustomAction): obj = jsNative
    [<ImportMember(path)>] // TODO type
    static member toTrimmed(): obj = jsNative
    [<ImportMember(path); ParamObject(0)>] // TODO type
    static member toUpperCase(on: OnCustomAction): obj = jsNative
    [<ImportMember(path)>] // TODO type
    static member toUpperCase(): obj = jsNative
    
    

    