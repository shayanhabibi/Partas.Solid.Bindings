namespace Partas.Solid.ModularForms

open System.Runtime.CompilerServices
open System.Text.RegularExpressions
open Browser.Types
open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS
open System.Collections.Generic
open System

#nowarn 49

[<AutoOpen; Erase>]
module private Helpers =
    [<Literal>]
    let path = "@modular-forms/solid"
    let inline lambdaPath map = Experimental.namesofLambda map |> String.concat "."

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
type FormStore<'Form, 'Response> =
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
type FieldStore<'Form, 'ValueType> =
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

[<JS.Pojo>]
type FormOptions<'Form>
    (
        initialValues: 'Form
        ,?validate: ValidateForm<'Form>
        ,?validateOn: ValidateOn
        ,?revalidateOn: ValidateOn
    ) =
    member val initialValues = initialValues
    member val validate = validate
    member val validateOn = validateOn
    member val revalidateOn = revalidateOn
    
[<Import("Form", path)>]
type Form<'Form, 'Response>() =    
    inherit RegularNode()
    [<DV>] val mutable of': FormStore<'Form, 'Response>
    [<DV>] val mutable onSubmit: SubmitHandler<'Form, 'Response>
    [<DV>] val mutable keepResponse: bool
    [<DV>] val mutable shouldActive: bool
    [<DV>] val mutable shouldTouched: bool
    [<DV>] val mutable shouldDirty: bool
    [<DV>] val mutable shouldFocus: bool
[<PartasImport("Field", path)>]
type Field<'Form, 'ValueType, 'Response>() =
    inherit RegularNode()
    [<DV>] val mutable of': FormStore<'ValueType, 'Response>
    [<DV>] val mutable name: string
    [<DV>] val mutable type': ModularFormsType
    [<DV>] val mutable validate: U2<Validator<'ValueType>, Validator<'ValueType>[]>
    [<DV>] val mutable validateOn: ValidateOn
    [<DV>] val mutable revalidateOn: ValidateOn
    [<DV>] val mutable transform: TransformField<'ValueType>
    [<DV>] val mutable keepActive: bool
    [<DV>] val mutable keepState: bool
    member inline this.map(path: 'Form -> 'ValueType) = this.attr("name", lambdaPath path)
    member inline this.map(
        path: 'Form -> 'ValueType[],
        index: int) = this.attr("name", $"{lambdaPath path}.{index}")
    member inline this.map<'U>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'ValueType) = this.attr("name", $"{lambdaPath path}.{index}.{secondPath}")
    member inline this.map<'U>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'ValueType,
        secondIndex: int) = this.attr("name", $"{lambdaPath path}.{index}.{lambdaPath secondPath}.{secondIndex}")
    member inline this.map<'U, 'G>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'G[],
        secondIndex: int,
        thirdPath: 'G -> 'ValueType) = this.attr("name", $"{lambdaPath path}.{index}.{lambdaPath secondPath}.{secondIndex}.{lambdaPath thirdPath}")
    member inline this.map<'U, 'G>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'G[],
        secondIndex: int,
        thirdPath: 'G -> 'ValueType[],
        thirdIndex: int) = this.attr("name", $"{lambdaPath path}.{index}.{lambdaPath secondPath}.{secondIndex}.{lambdaPath thirdPath}.{thirdIndex}")
    [<Erase>]
    member inline _.Yield(PARTAS_ELEMENT: FieldStore<'Form, 'ValueType> -> FieldElementProps -> #HtmlElement) : HtmlContainerFun = fun PARTAS_CONT -> ignore PARTAS_ELEMENT
[<PartasImport("FieldArray", path)>]
type FieldArray<'Form, 'ValueType, 'Response>() =
    inherit RegularNode()
    [<DV>] val mutable of': FormStore<'Form, 'Response>
    [<DV>] val mutable name: string
    [<DV>] val mutable type': ModularFormsType
    [<DV>] val mutable validate: U2<ValidateFieldArray, ValidateFieldArray[]>
    [<DV>] val mutable validateOn: ValidateOn
    [<DV>] val mutable revalidateOn: ValidateOn
    [<DV>] val mutable keepActive: bool
    [<DV>] val mutable keepState: bool
    member inline this.map(path: 'Form -> 'ValueType) = this.attr("name", lambdaPath path)
    member inline this.map(
        path: 'Form -> 'ValueType[],
        index: int) = this.attr("name", $"{lambdaPath path}.{index}")
    member inline this.map<'U>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'ValueType) = this.attr("name", $"{lambdaPath path}.{index}.{secondPath}")
    member inline this.map<'U>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'ValueType,
        secondIndex: int) = this.attr("name", $"{lambdaPath path}.{index}.{lambdaPath secondPath}.{secondIndex}")
    member inline this.map<'U, 'G>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'G[],
        secondIndex: int,
        thirdPath: 'G -> 'ValueType) = this.attr("name", $"{lambdaPath path}.{index}.{lambdaPath secondPath}.{secondIndex}.{lambdaPath thirdPath}")
    member inline this.map<'U, 'G>(
        path: 'Form -> 'U[],
        index: int,
        secondPath: 'U -> 'G[],
        secondIndex: int,
        thirdPath: 'G -> 'ValueType[],
        thirdIndex: int) = this.attr("name", $"{lambdaPath path}.{index}.{lambdaPath secondPath}.{secondIndex}.{lambdaPath thirdPath}.{thirdIndex}")
    [<Erase>]
    member inline _.Yield(PARTAS_ELEMENT: FieldArrayStore -> #HtmlElement) : HtmlContainerFun = fun PARTAS_CONT -> ignore PARTAS_ELEMENT


[<AutoOpen; Erase>]
type ModularFormsBindings =
    /// <summary>
    /// Cannot support createForm easily. Simply pass form to the of' parameter
    /// </summary>
    [<ImportMember(path)>]
    static member createFormStore<'Form, 'Response>(): FormStore<'Form, 'Response> = jsNative
    [<ImportMember(path)>]
    static member clearError<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string): unit = jsNative
    static member inline clearError<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType) = clearError(form, lambdaPath path)
    [<ImportMember(path)>]
    static member clearResponse<'Form, 'Response>(form: FormStore<'Form, 'Response>): unit = jsNative
    [<ImportMember(path)>]
    static member focus<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string): unit = jsNative
    static member inline focus<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType): unit = focus(form, lambdaPath path)
    [<ImportMember(path); ParamObject(2)>]
    static member getError<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string,
                           ?shouldActive: bool (*true*),
                           ?shouldTouched: bool (*false*),
                           ?shouldDirty: bool (*false*)): string option = jsNative
    [<ParamObject(2)>]
    static member inline getError<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType,
                           ?shouldActive: bool (*true*),
                           ?shouldTouched: bool (*false*),
                           ?shouldDirty: bool (*false*)): string option = getError(form, lambdaPath path, ?shouldActive = shouldActive, ?shouldTouched = shouldTouched, ?shouldDirty = shouldDirty)
    [<ImportMember(path)>]
    static member getError<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string): string option = jsNative
    static member inline getError<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType): string option = getError(form, lambdaPath path)
    [<ImportMember(path); ParamObject(2)>]
    static member getErrors<'Form, 'Response>(form: FormStore<'Form, 'Response>, names: string,
                            ?shouldActive: bool,
                            ?shouldTouched: bool,
                            ?shouldDirty: bool): FormErrors = jsNative
    [<ParamObject(2)>]
    static member inline getErrors<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType,
                            ?shouldActive: bool,
                            ?shouldTouched: bool,
                            ?shouldDirty: bool): FormErrors = getErrors(form, lambdaPath path, ?shouldActive = shouldActive, ?shouldTouched = shouldTouched, ?shouldDirty = shouldDirty)
    [<ImportMember(path); ParamObject(2)>]
    static member getErrors<'Form, 'Response>(form: FormStore<'Form, 'Response>, names: string[],
                            ?shouldActive: bool,
                            ?shouldTouched: bool,
                            ?shouldDirty: bool): FormErrors = jsNative
    [<ImportMember(path)>]
    static member getErrors<'Form, 'Response>(form: FormStore<'Form, 'Response>, names: string): FormErrors = jsNative
    [<ImportMember(path)>]
    static member getErrors<'Form, 'Response>(form: FormStore<'Form, 'Response>, names: string[]): FormErrors = jsNative
    static member inline getErrors<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType): FormErrors = getErrors(form, lambdaPath path)
    [<ImportMember(path); ParamObject(2)>]
    static member getValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): 'ValueType option = jsNative
    [<ParamObject(2)>]
    static member inline getValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): 'ValueType option = getValue(form, lambdaPath path, ?shouldActive=shouldActive, ?shouldTouched = shouldTouched, ?shouldDirty = shouldDirty, ?shouldValid = shouldValid)
    [<ImportMember(path)>]
    static member getValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string): 'ValueType option = jsNative
    static member inline getValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType): 'ValueType option = getValue(form, lambdaPath path)
    [<ImportMember(path); ParamObject(2)>]
    static member getValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, names: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): 'ValueType option = jsNative
    [<ParamObject(2)>]
    static member inline getValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, path: 'Form -> 'ValueType,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): 'ValueType option = getValues(form, lambdaPath path, ?shouldActive=shouldActive,?shouldTouched=shouldTouched,?shouldDirty=shouldDirty,?shouldValid=shouldValid)
    [<ImportMember(path)>]
    static member getValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, names: string): 'ValueType option = jsNative
    static member inline getValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, names: 'Form -> 'ValueType): 'ValueType[] option = getValues(form, lambdaPath names)
    [<ImportMember(path); ParamObject(2)>]
    static member getValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, names: string[],
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): 'ValueType option = jsNative
    [<ImportMember(path)>]
    static member getValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, names: string[]): 'ValueType[] option = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member hasField<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): bool = jsNative
    [<ParamObject(2)>]
    static member inline hasField<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): bool = hasField(form, lambdaPath name, ?shouldActive=shouldActive,?shouldTouched=shouldTouched,?shouldDirty=shouldDirty,?shouldValid=shouldValid)
    [<ImportMember(path)>]
    static member hasField<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string): bool = jsNative
    static member inline hasField<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType): bool = hasField(form, lambdaPath name)
    [<ImportMember(path); ParamObject(2)>]
    static member hasFieldArray<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): bool = jsNative
    [<ParamObject(2)>]
    static member inline hasFieldArray<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType,
                           ?shouldActive: bool,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValid: bool): bool = hasFieldArray(form, lambdaPath name, ?shouldActive=shouldActive,?shouldTouched=shouldTouched,?shouldDirty=shouldDirty,?shouldValid=shouldValid)
    [<ImportMember(path)>]
    static member hasFieldArray<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string): bool = jsNative
    static member inline hasFieldArray<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType): bool = hasFieldArray(form, lambdaPath name)
    [<ImportMember(path); ParamObject(2)>]
    static member insert<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:string,
                         ?at: int,
                         ?value: 'ValueType): unit = jsNative
    [<ParamObject(2)>]
    static member inline insert<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType,
                         ?at: int,
                         ?value: 'ValueType): unit = insert(form, lambdaPath name, ?at=at, ?value=value)
    [<ImportMember(path)>]
    static member insert<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:string): unit = jsNative
    static member inline insert<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType): unit = insert(form, lambdaPath name)
    [<ImportMember(path); ParamObject(2)>]
    static member move<'Form, 'Response>(form: FormStore<'Form, 'Response>, name:string,
                         ?from': int,
                         ?to': int): unit = jsNative
    [<ParamObject(2)>]
    static member inline move<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType,
                         ?from': int,
                         ?to': int): unit = move(form, lambdaPath name, ?from'=from', ?to'=to')
    [<ImportMember(path)>]
    static member move<'Form, 'Response>(form: FormStore<'Form, 'Response>, name:string): unit = jsNative
    static member inline move<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType): unit = move(form, lambdaPath name)
    [<ImportMember(path); ParamObject(2)>]
    static member remove<'Form, 'Response>(form: FormStore<'Form, 'Response>, name:string,
                         ?at: int): unit = jsNative
    [<ParamObject(2)>]
    static member inline remove<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType,
                         ?at: int): unit = remove(form, lambdaPath name, ?at=at)
    [<ImportMember(path)>]
    static member remove<'Form, 'Response>(form: FormStore<'Form, 'Response>, name:string): unit = jsNative
    static member inline remove<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType): unit = remove(form, lambdaPath name)
    [<ImportMember(path); ParamObject(2)>]
    static member replace<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:string,
                         ?at: int,
                         ?value: 'ValueType): unit = jsNative
    [<ParamObject(2)>]
    static member inline replace<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType,
                         ?at: int,
                         ?value: 'ValueType): unit = replace(form, lambdaPath name, ?at=at, ?value=value)
    [<ImportMember(path); ParamObject(2)>]
    static member reset<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:string,
                         ?initialValues: 'ValueType[],
                         ?initialValue: 'ValueType,
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
    [<ParamObject(2)>]
    static member inline reset<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType,
                         ?initialValues: 'ValueType[],
                         ?initialValue: 'ValueType,
                         ?keepResponse: bool,
                         ?keepSubmitCount: bool,
                         ?keepSubmitted: bool,
                         ?keepValues: bool,
                         ?keepDirtyValues: bool,
                         ?keepItems: bool,
                         ?keepDirtyItems: bool,
                         ?keepErrors: bool,
                         ?keepTouched: bool,
                         ?keepDirty: bool): unit = reset(form, lambdaPath name, ?initialValues=initialValues, ?initialValue=initialValue, ?keepResponse=keepResponse,?keepSubmitCount=keepSubmitCount
                                                         ,?keepSubmitted=keepSubmitted,?keepValues=keepValues,?keepDirtyValues=keepDirtyValues,?keepItems=keepItems,?keepDirtyItems=keepDirtyItems,?keepErrors=keepErrors
                                                         ,?keepTouched=keepTouched,?keepDirty=keepDirty)
    [<ImportMember(path)>]
    static member reset<'Form, 'Response>(form: FormStore<'Form, 'Response>, name:string): unit = jsNative
    static member inline reset<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name:'Form -> 'ValueType): unit = reset(form, lambdaPath name)
    [<ImportMember(path); ParamObject(1)>]
    static member reset<'Form, 'Response>(form: FormStore<'Form, 'Response>,
                         ?initialValues: 'Form[],
                         ?initialValue: 'Form,
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
    static member reset<'Form, 'Response>(form: FormStore<'Form, 'Response>): unit = jsNative
    [<ImportMember(path); ParamObject(2)>]
    static member reset(form: FormStore<'Form, 'Response>, names: string[],
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
    static member reset(form: FormStore<'Form, 'Response>, names: string[]): unit = jsNative
    [<ImportMember(path)>]
    static member setError<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string, error: string): unit = jsNative
    static member inline setError<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType, error: string): unit = setError(form, lambdaPath name, error)
    [<ImportMember(path); ParamObject(3)>]
    static member setError<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string, error: string, ?shouldFocus: bool): unit = jsNative
    static member inline setError<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType, error: string, ?shouldFocus: bool): unit = setError(form, lambdaPath name, error, ?shouldFocus=shouldFocus)
    [<ImportMember(path); ParamObject(2)>]
    static member setResponse<'Form, 'Response>(form: FormStore<'Form, 'Response>, response: 'Response, ?duration: int): unit = jsNative
    [<ImportMember(path)>]
    static member setResponse<'Form, 'Response>(form: FormStore<'Form, 'Response>, response: 'Response): unit = jsNative
    [<ImportMember(path); ParamObject(3)>]
    static member setValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string, value: 'ValueType,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValidate: bool,
                           ?shouldFocus: bool): unit = jsNative
    static member inline setValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType, value: 'ValueType,
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValidate: bool,
                           ?shouldFocus: bool): unit = setValue(form, lambdaPath name, value, ?shouldTouched=shouldTouched, ?shouldDirty=shouldDirty, ?shouldValidate=shouldValidate,?shouldFocus=shouldFocus)
    [<ImportMember(path)>]
    static member setValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string, value: 'ValueType): unit = jsNative
    static member inline setValue<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType, value: 'ValueType): unit = setValue(form, lambdaPath name, value)
    [<ImportMember(path); ParamObject(3)>]
    static member setValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string, values: 'ValueType[],
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValidate: bool,
                           ?shouldFocus: bool): unit = jsNative
    static member inline setValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType[], values: 'ValueType[],
                           ?shouldTouched: bool,
                           ?shouldDirty: bool,
                           ?shouldValidate: bool,
                           ?shouldFocus: bool): unit = setValues(form,lambdaPath name,values,?shouldTouched=shouldTouched,?shouldDirty=shouldDirty,?shouldValidate=shouldValidate,?shouldFocus=shouldFocus)
    [<ImportMember(path)>]
    static member setValues<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: string, values: 'ValueType[]): unit = jsNative
    [<ImportMember(path)>]
    static member submit<'Form, 'Response>(form: FormStore<'Form, 'Response>): unit = jsNative
    [<ImportMember(path)>]
    static member swap<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string,
                       ?at: int,
                       ?and': int): unit = jsNative
    static member inline swap<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType,
                       ?at: int,
                       ?and': int): unit = swap(form, lambdaPath name, ?at=at, ?and'=and')
    [<ImportMember(path)>]
    static member swap<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string): unit = jsNative
    [<ImportMember(path)>]
    static member validate<'Form, 'Response>(form: FormStore<'Form, 'Response>): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member validate<'Form, 'Response>(form: FormStore<'Form, 'Response>, ?shouldActive: bool, ?shouldFocus: bool): unit = jsNative
    [<ImportMember(path)>]
    static member validate<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member validate<'Form, 'Response>(form: FormStore<'Form, 'Response>, name: string, ?shouldActive: bool, ?shouldFocus: bool): unit = jsNative
    static member inline validate<'Form, 'ValueType, 'Response>(form: FormStore<'Form, 'Response>, name: 'Form -> 'ValueType, ?shouldActive: bool, ?shouldFocus: bool): unit = validate(form,lambdaPath name, ?shouldActive=shouldActive,?shouldFocus=shouldFocus)
    [<ImportMember(path)>]
    static member validate<'Form, 'Response>(form: FormStore<'Form, 'Response>, names: string[]): unit = jsNative
    [<ImportMember(path); ParamObject(1)>]
    static member validate<'Form, 'Response>(form: FormStore<'Form, 'Response>, names: string[], ?shouldActive: bool, ?shouldFocus: bool): unit = jsNative
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
    
    

    