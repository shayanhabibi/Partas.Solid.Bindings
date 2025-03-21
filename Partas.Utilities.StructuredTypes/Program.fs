namespace Partas.Utilities.StructuredTypes

open System.Runtime.InteropServices
open Fable.Core
open Fable.Core.JS
open System

[<Erase; AutoOpen>]
module Paths =
    let [<Literal>] api = "@structured-types/api"

[<Erase>]
type U10<'a, 'b, 'c, 'd, 'e, 'f, 'g, 'h, 'i, 'j> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    | Case6 of 'f
    | Case7 of 'g
    | Case8 of 'h
    | Case9 of 'i
    | Case10 of 'j
    static member op_ErasedCast(a:'a) = Case1 a
    static member op_ErasedCast(b:'b) = Case2 b
    static member op_ErasedCast(c:'c) = Case3 c
    static member op_ErasedCast(d:'d) = Case4 d
    static member op_ErasedCast(e:'e) = Case5 e
    static member op_ErasedCast(f:'f) = Case6 f
    static member op_ErasedCast(g:'g) = Case7 g
    static member op_ErasedCast(h:'h) = Case8 h
    static member op_ErasedCast(i:'i) = Case9 i
    static member op_ErasedCast(j:'j) = Case10 j
[<Erase>]
type U11<'a, 'b, 'c, 'd, 'e, 'f, 'g, 'h, 'i, 'j, 'k> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    | Case6 of 'f
    | Case7 of 'g
    | Case8 of 'h
    | Case9 of 'i
    | Case10 of 'j
    | Case11 of 'k
    static member op_ErasedCast(a:'a) = Case1 a
    static member op_ErasedCast(b:'b) = Case2 b
    static member op_ErasedCast(c:'c) = Case3 c
    static member op_ErasedCast(d:'d) = Case4 d
    static member op_ErasedCast(e:'e) = Case5 e
    static member op_ErasedCast(f:'f) = Case6 f
    static member op_ErasedCast(g:'g) = Case7 g
    static member op_ErasedCast(h:'h) = Case8 h
    static member op_ErasedCast(i:'i) = Case9 i
    static member op_ErasedCast(j:'j) = Case10 j
    static member op_ErasedCast(k:'k) = Case11 k

[<Erase>]
type U23<'a, 'b, 'c, 'd, 'e, 'f, 'g, 'h, 'i, 'j, 'k, 'l, 'm, 'n, 'o, 'p, 'q, 'r, 's, 't, 'u, 'v, 'w> =
    | Case1 of 'a
    | Case2 of 'b
    | Case3 of 'c
    | Case4 of 'd
    | Case5 of 'e
    | Case6 of 'f
    | Case7 of 'g
    | Case8 of 'h
    | Case9 of 'i
    | Case10 of 'j
    | Case11 of 'k
    | Case12 of 'l
    | Case13 of 'm
    | Case14 of 'n
    | Case15 of 'o
    | Case16 of 'p
    | Case17 of 'q
    | Case18 of 'r
    | Case19 of 's
    | Case20 of 't
    | Case21 of 'u
    | Case22 of 'v
    | Case23 of 'w
    static member op_ErasedCast(a:'a) = Case1 a
    static member op_ErasedCast(b:'b) = Case2 b
    static member op_ErasedCast(c:'c) = Case3 c
    static member op_ErasedCast(d:'d) = Case4 d
    static member op_ErasedCast(e:'e) = Case5 e
    static member op_ErasedCast(f:'f) = Case6 f
    static member op_ErasedCast(g:'g) = Case7 g
    static member op_ErasedCast(h:'h) = Case8 h
    static member op_ErasedCast(i:'i) = Case9 i
    static member op_ErasedCast(j:'j) = Case10 j
    static member op_ErasedCast(k:'k) = Case11 k
    static member op_ErasedCast(l:'l) = Case12 l
    static member op_ErasedCast(m:'m) = Case13 m
    static member op_ErasedCast(n:'n) = Case14 n
    static member op_ErasedCast(o:'o) = Case15 o
    static member op_ErasedCast(p:'p) = Case16 p
    static member op_ErasedCast(q:'q) = Case17 q
    static member op_ErasedCast(r:'r) = Case18 r
    static member op_ErasedCast(s:'s) = Case19 s
    static member op_ErasedCast(t:'t) = Case20 t
    static member op_ErasedCast(u:'u) = Case21 u
    static member op_ErasedCast(v:'v) = Case22 v
    static member op_ErasedCast(w:'w) = Case23 w

[<Erase; AutoOpen>]
module rec Types =
    type private Bindings =
        [<ImportMember(api)>]
        static member parseFiles(files: string[],
                                 ?options: DocsOptions,
                                 ?programOptions: ProgramOptions
                                 ): JS.Object = jsNative
        [<ImportMember(api)>]
        static member analyzeFiles(files: string[],
                                    ?programOptions: ProgramOptions
                                    ): JS.Object = jsNative
    let inline private organisePropTypes (value: JS.Object): PropTypes =
        value    
        |> JS.Object.entries
        |> _.ToArray()
        |> unbox<(string * PropType) array>
        |> Array.partition(function | "__helpers", _ | "__diagnostics", _ -> true | _ -> false)
        |> function
            | helpers, values when helpers.Length = 0 ->
                PropTypes(values |> Array.map snd)
            | [| ("__helpers", _) as helper |], values ->
                PropTypes(values |> Array.map snd, unbox (snd helper))
            | [| diagnostics |], values ->
                PropTypes(values |> Array.map snd, diagnostics = unbox (snd diagnostics) )
            | helpers, values ->
                PropTypes(
                        values |> Array.map snd,
                        helpers |> Array.find (fst >> (=) "__helpers") |> snd |> unbox,
                        helpers |> Array.find (fst >> (=) "__diagnostics") |> snd |> unbox
                    )
    [<AutoOpen; Erase>]
    type Export =
        static member inline parseFiles(
                files: string[],
                ?options: DocsOptions,
                ?programOptions: ProgramOptions
            ): PropTypes =
            match files,options,programOptions with
            | _, None, None -> Bindings.parseFiles(files)
            | _, _, None -> Bindings.parseFiles(files, options.Value)
            | _, None, _ -> Bindings.parseFiles(files, programOptions = programOptions.Value)
            | _ -> Bindings.parseFiles(files, options.Value, programOptions.Value)
            |> organisePropTypes
        
        static member inline analyzeFiles(
                files: string[],
                ?programOptions: ProgramOptions
            ): PropTypes =
            match files,programOptions with
            | _, None -> Bindings.analyzeFiles(files)
            | _ -> Bindings.analyzeFiles(files, programOptions.Value)
            |> organisePropTypes
    
    [<StringEnum>]
    type Scope =
        | Exports
        | All
    
    [<StringEnum>]
    type CollectSourceInfo =
        | Body
    
    [<AllowNullLiteral; Interface>]
    type ParseOptions = interface end
    
    [<AutoOpen; Erase>]
    module Extensions =
        type ParseOptions with
            [<Erase>]
            member this.tsOptions
                with set(value: CompilerOptions) = ()
                and get() = unbox null
            [<Erase>]
            member this.internalTypes
                with set(value: JS.Object) = ()
                and get() = unbox null
            [<Erase>]
            member this.extract
                with set(value: string[]) = ()
                and get() = unbox null
            [<Erase>]
            member this.filter
                with set(value: IPropType -> bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.isInternal
                with set(value: string * obj -> bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.maxDepth
                with set(value: int) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectHelpers
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectGenerics
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectParameters
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectParametersUsage
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectProperties
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectInheritance
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectExtension
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectDiagnostics
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectAliasName
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectInternals
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.plugins
                with set(value: ParsePlugin[]) = ()
                and get() = unbox null
            [<Erase>]
            member this.scope
                with set(value: Scope) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectSourceInfo
                with set(value: U2<CollectSourceInfo, bool>) = ()
                and get() = unbox null
            [<Erase>]
            member this.collectInnerLocations
                with set(value: bool) = ()
                and get() = unbox null
            [<Erase>]
            member this.moduleCallback
                with set(value: obj * obj -> unit) = ()
                and get() = unbox null
    
    [<Erase; JS.Pojo>]
    type DocsOptions() =
        interface ParseOptions
        
    [<Erase; JS.Pojo>]
    type ProgramOptions() = class end
    [<Erase; JS.Pojo>]
    type CompilerOptions() = class end
    [<AllowNullLiteral; Interface>]
    type PropParent =
        abstract member name: string with get
        abstract member loc: string with get
    [<AllowNullLiteral; Interface>]
    type JSDocExample =
        abstract member caption: string
        abstract member content: string
    [<AllowNullLiteral; Interface>]
    type JSDocPropTag =
        abstract member tag: string with get
        abstract member content: string option
    [<AllowNullLiteral; Interface>]
    type PropDiagnostic =
        abstract member category: obj with get
        abstract member message: string with get
        abstract member row: int with get
        abstract member column: int with get
        abstract member fileName: string with get
    
    [<StringEnum>]
    type Visibility =
        | Private
        | Protected
        | Public
    
    [<AllowNullLiteral; Interface>]
    type IPropType =
        // abstract member kind: PropKind option with get
        abstract member name: string option with get
        abstract member alias: string option with get
        abstract member parent: PropParent option with get
        abstract member loc: obj option with get
        abstract member optional: bool option with get
        abstract member readonly: bool option with get
        abstract member async: bool option with get
        abstract member visibility: Visibility option with get
        abstract member ``static``: bool option with get
        abstract member ``type``: string option with get
        abstract member extension: string option with get
        abstract member description: string option with get
        abstract member fires: string[] option with get
        abstract member see: string[] option with get
        abstract member examples: JSDocExample[] option with get
        abstract member tags: JSDocPropTag[] option with get
        abstract member summary: string option with get
        abstract member deprecated: U2<string, bool> option with get
        abstract member ignore: bool option with get
        abstract member usage: System.Type[] option with get    
        
    [<Erase; Pojo>]
    type PropTypes(
            props: PropType[],
            ?helpers: obj,
            ?diagnostics: PropDiagnostic[]
        ) =
        member val props: PropType[] = props with get,set
        member val helpers: obj = helpers |> Option.defaultValue undefined with get,set
        member val diagnostics: PropDiagnostic[] = diagnostics |> Option.defaultValue [||] with get,set
        
    [<Pojo>]
    type ParsePlugin() =
        interface ParseOptions
    
    [<Pojo>]
    type ResolverReturnType() =
        interface ParseOptions
        [<Erase>]
        member val ``type``: obj = unbox null with get,set
        [<Erase>]
        member val initializer: obj = unbox null with get,set
        [<Erase>]
        member val declaration: obj = unbox null with get,set
        [<Erase>]
        member val prop: IPropType = unbox null with get,set
        [<Erase>]
        member val pluginName: string = unbox null with get,set


    [<AbstractClass>]
    [<Erase; AutoOpen>]
    type Exports =
        /// <summary>
        /// ObjectProp type guard predicate
        /// </summary>
        [<Import("isObjectProp", "@structured-types/api")>]
        static member inline isObjectProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// StringProp type guard predicate
        /// </summary>
        [<Import("isStringProp", "@structured-types/api")>]
        static member inline isStringProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// NumberProp type guard predicate
        /// </summary>
        [<Import("isNumberProp", "@structured-types/api")>]
        static member inline isNumberProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// BooleanProp type guard predicate
        /// </summary>
        [<Import("isBooleanProp", "@structured-types/api")>]
        static member inline isBooleanProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// UnionProp type guard predicate
        /// </summary>
        [<Import("isUnionProp", "@structured-types/api")>]
        static member inline isUnionProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// type guard predicate to determine if the prop has a value field
        /// </summary>
        [<Import("hasValue", "@structured-types/api")>]
        static member inline hasValue: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// EnumProp type guard predicate
        /// </summary>
        [<Import("isEnumProp", "@structured-types/api")>]
        static member inline isEnumProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// RestProp type guard predicate
        /// </summary>
        [<Import("isRestProp", "@structured-types/api")>]
        static member inline isRestProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// TupleProp type guard predicate
        /// </summary>
        [<Import("isTupleProp", "@structured-types/api")>]
        static member inline isTupleProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// UndefinedProp type guard predicate
        /// </summary>
        [<Import("isUndefinedProp", "@structured-types/api")>]
        static member inline isUndefinedProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// UnknownProp type guard predicate
        /// </summary>
        [<Import("isUnknownProp", "@structured-types/api")>]
        static member inline isUnknownProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// NullProp type guard predicate
        /// </summary>
        [<Import("isNullProp", "@structured-types/api")>]
        static member inline isNullProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// FunctionProp type guard predicate
        /// </summary>
        [<Import("isFunctionProp", "@structured-types/api")>]
        static member inline isFunctionProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// BaseFunctionProp type guard predicate
        /// </summary>
        [<Import("isFunctionBaseType", "@structured-types/api")>]
        static member inline isFunctionBaseType: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// VoidProp type guard predicate
        /// </summary>
        [<Import("isVoidProp", "@structured-types/api")>]
        static member inline isVoidProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// ClassProp type guard predicate
        /// </summary>
        [<Import("isClassProp", "@structured-types/api")>]
        static member inline isClassProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// InterfaceProp type guard predicate
        /// </summary>
        [<Import("isInterfaceProp", "@structured-types/api")>]
        static member inline isInterfaceProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// TypeProp type guard predicate
        /// </summary>
        [<Import("isTypeProp", "@structured-types/api")>]
        static member inline isTypeProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// HasGenericsProp predicate to determine if a prop has a generics field
        /// </summary>
        [<Import("hasGenerics", "@structured-types/api")>]
        static member inline hasGenerics: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// HasPropertiesProp predicate to determine if a prop has a properties field
        /// </summary>
        [<Import("hasProperties", "@structured-types/api")>]
        static member inline hasProperties: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// ArrayProp type guard predicate
        /// </summary>
        [<Import("isArrayProp", "@structured-types/api")>]
        static member inline isArrayProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// AnyProp type guard predicate
        /// </summary>
        [<Import("isAnyProp", "@structured-types/api")>]
        static member inline isAnyProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// IndexProp type guard predicate
        /// </summary>
        [<Import("isIndexProp", "@structured-types/api")>]
        static member inline isIndexProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// ClassLikeProp predicate to determine if a prop is class-like
        /// </summary>
        [<Import("isClassLikeProp", "@structured-types/api")>]
        static member inline isClassLikeProp: (IPropType -> bool) = nativeOnly
        /// <summary>
        /// ObjectLikeProp predicate to determine if a prop is object-like
        /// </summary>
        [<Import("isObjectLikeProp", "@structured-types/api")>]
        static member inline isObjectLikeProp: (IPropType -> bool) = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ObjectProp =
        inherit IPropType
        /// <summary>
        /// object properties list
        /// </summary>
        abstract member properties: List<IPropType> option with get, set
        /// <summary>
        /// value, if the object is initialized
        /// </summary>
        abstract member value: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type NumberProp =
        inherit IPropType
        abstract member value: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BooleanProp =
        inherit IPropType
        abstract member value: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type UnionProp =
        inherit IPropType
        abstract member properties: List<IPropType> option with get, set
        abstract member value: obj option with get, set

    type HasValueProp =
        U5<StringProp, NumberProp, BooleanProp, UnionProp, TypeProp>

    [<AllowNullLiteral>]
    [<Interface>]
    type EnumProp =
        inherit IPropType
        abstract member properties: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type RestProp =
        inherit IPropType
        abstract member prop: IPropType option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type TupleProp =
        inherit IPropType
        abstract member properties: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type UndefinedProp =
        inherit IPropType
        abstract member value: obj option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type UnknownProp =
        inherit IPropType
        abstract member value: obj option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type NullProp =
        inherit IPropType
        abstract member value: obj option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type BaseFunctionProp =
        inherit IPropType
        abstract member parameters: List<IPropType> option with get, set
        abstract member returns: IPropType option with get, set
        abstract member types: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type FunctionProp =
        inherit BaseFunctionProp
        abstract member properties: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ConstructorProp =
        inherit BaseFunctionProp

    [<AllowNullLiteral>]
    [<Interface>]
    type GetterProp =
        inherit BaseFunctionProp

    [<AllowNullLiteral>]
    [<Interface>]
    type SetterProp =
        inherit BaseFunctionProp

    [<AllowNullLiteral>]
    [<Interface>]
    type VoidProp =
        inherit IPropType
        abstract member value: unit option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ClassProp =
        inherit IPropType
        abstract member implements: List<InterfaceProp> option with get, set
        abstract member extends: List<PropParent> option with get, set
        abstract member generics: List<IPropType> option with get, set
        abstract member properties: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ComponentProp =
        inherit ClassProp

    [<AllowNullLiteral>]
    [<Interface>]
    type InterfaceProp =
        inherit IPropType
        abstract member extends: List<PropParent> option
        abstract member properties: List<IPropType> option
        abstract member generics: List<IPropType> option

    [<AllowNullLiteral>]
    [<Interface>]
    type TypeProp =
        inherit IPropType
        abstract member extends: List<PropParent> option with get, set
        abstract member properties: List<IPropType> option with get, set
        abstract member generics: List<IPropType> option with get, set
        abstract member value: IPropType option with get, set

    type HasGenericsProp =
        U3<TypeProp, InterfaceProp, ClassProp>

    type HasPropertiesProp =
        U10<ArrayProp, UnionProp, ObjectProp, EnumProp, TupleProp, FunctionProp, TypeProp, InterfaceProp, ComponentProp, ClassProp>

    [<AllowNullLiteral>]
    [<Interface>]
    type ArrayProp =
        inherit IPropType
        abstract member properties: List<IPropType> option with get, set
        abstract member value: List<IPropType> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type AnyProp =
        inherit IPropType
        abstract member value: obj option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type IndexProp =
        inherit IPropType
        abstract member index: IPropType with get, set
        abstract member prop: IPropType option with get, set
        abstract member properties: List<IPropType> option with get, set
    
    type ValueProp =
        U11<AnyProp, ArrayProp, VoidProp, UnionProp, NullProp, UnknownProp, UndefinedProp, BooleanProp, NumberProp, StringProp, ObjectProp>

    type ClassLikeProp =
        U4<ClassProp, InterfaceProp, TypeProp, ComponentProp>

    type ObjectLikeProp =
        U4<ClassLikeProp, EnumProp, ObjectProp, IndexProp>

    [<AllowNullLiteral>]
    [<Interface>]
    type StringProp =
        inherit IPropType
        abstract member value: string option with get, set
    
    [<Erase>]
    type Prop = U23<
                    StringProp,
                    NumberProp,
                    BooleanProp,
                    UnionProp,
                    EnumProp,
                    TupleProp,
                    RestProp,
                    UndefinedProp,
                    UnknownProp,
                    NullProp,
                    FunctionProp,
                    VoidProp,
                    ClassProp,
                    InterfaceProp,
                    TypeProp,
                    ArrayProp,
                    AnyProp,
                    IndexProp,
                    ConstructorProp,
                    GetterProp,
                    SetterProp,
                    ComponentProp,
                    ObjectProp
                    >
    
    [<TypeScriptTaggedUnion("kind")>]
    type PropType =
        | [<CompiledValue(1)>] String of StringProp
        | [<CompiledValue(2)>] Number of NumberProp
        | [<CompiledValue(3)>] Boolean of BooleanProp
        | [<CompiledValue(4)>] Union of UnionProp
        | [<CompiledValue(5)>] Enum of EnumProp
        | [<CompiledValue(6)>] Tuple of TupleProp
        | [<CompiledValue(7)>] Rest of RestProp
        | [<CompiledValue(8)>] Undefined of UndefinedProp
        | [<CompiledValue(9)>] Unknown of UnknownProp
        | [<CompiledValue(10)>] Null of NullProp
        | [<CompiledValue(11)>] Function of FunctionProp
        | [<CompiledValue(12)>] Void of VoidProp
        | [<CompiledValue(13)>] Class of ClassProp
        | [<CompiledValue(14)>] Interface of InterfaceProp
        | [<CompiledValue(15)>] Type of TypeProp
        | [<CompiledValue(16)>] Array of ArrayProp
        | [<CompiledValue(17)>] Any of AnyProp
        | [<CompiledValue(20)>] Index of IndexProp
        | [<CompiledValue(21)>] Constructor of ConstructorProp
        | [<CompiledValue(22)>] Getter of GetterProp
        | [<CompiledValue(23)>] Setter of SetterProp
        | [<CompiledValue(24)>] BigInt of NumberProp
        | [<CompiledValue(25)>] Component of ComponentProp
        | [<CompiledValue(26)>] Object of ObjectProp
        | [<CompiledValue(27)>] Namespace of UnknownProp
        | [<CompiledValue(28)>] RegEx of UnknownProp
        [<Erase>]
        member inline this.Value<'T>(): 'T = unbox<'T> this 
    
    let (|IsString|_|): PropType ->  StringProp option = function
        | String _ as this -> unbox<StringProp> this |> Some
        | _ -> None
    let (|IsNumber|_|): PropType ->  NumberProp option = function
        | Number _ as this -> unbox<NumberProp> this |> Some
        | _ -> None
    let (|IsBoolean|_|): PropType ->  BooleanProp option = function
        | Boolean _ as this -> unbox<BooleanProp> this |> Some
        | _ -> None
    let (|IsUnion|_|): PropType ->  UnionProp option = function
        | Union _ as this -> unbox<UnionProp> this |> Some
        | _ -> None
    let (|IsEnum|_|): PropType ->  EnumProp option = function
        | Enum _ as this -> unbox<EnumProp> this |> Some
        | _ -> None
    let (|IsTuple|_|): PropType ->  TupleProp option = function
        | Tuple _ as this -> unbox<TupleProp> this |> Some
        | _ -> None
    let (|IsRest|_|): PropType ->  RestProp option = function
        | Rest _ as this -> unbox<RestProp> this |> Some
        | _ -> None
    let (|IsUndefined|_|): PropType ->  UndefinedProp option = function
        | Undefined _ as this -> unbox<UndefinedProp> this |> Some
        | _ -> None
    let (|IsUnknown|_|): PropType ->  UnknownProp option = function
        | Unknown _ as this -> unbox<UnknownProp> this |> Some
        | _ -> None
    let (|IsNull|_|): PropType ->  NullProp option = function
        | Null _ as this -> unbox<NullProp> this |> Some
        | _ -> None
    let (|IsFunction|_|): PropType ->  FunctionProp option = function
        | Function _ as this -> unbox<FunctionProp> this |> Some
        | _ -> None
    let (|IsVoid|_|): PropType ->  VoidProp option = function
        | Void _ as this -> unbox<VoidProp> this |> Some
        | _ -> None
    let (|IsClass|_|): PropType ->  ClassProp option = function
        | Class _ as this -> unbox<ClassProp> this |> Some
        | _ -> None
    let (|IsInterface|_|): PropType ->  InterfaceProp option = function
        | Interface _ as this -> unbox<InterfaceProp> this |> Some
        | _ -> None
    let (|IsType|_|): PropType ->  TypeProp option = function
        | Type _ as this -> unbox<TypeProp> this |> Some
        | _ -> None
    let (|IsArray|_|): PropType ->  ArrayProp option = function
        | Array _ as this -> unbox<ArrayProp> this |> Some
        | _ -> None
    let (|IsAny|_|): PropType ->  AnyProp option = function
        | Any _ as this -> unbox<AnyProp> this |> Some
        | _ -> None
    let (|IsIndex|_|): PropType ->  IndexProp option = function
        | Index _ as this -> unbox<IndexProp> this |> Some
        | _ -> None
    let (|IsConstructor|_|): PropType ->  ConstructorProp option = function
        | Constructor _ as this -> unbox<ConstructorProp> this |> Some
        | _ -> None
    let (|IsGetter|_|): PropType ->  GetterProp option = function
        | Getter _ as this -> unbox<GetterProp> this |> Some
        | _ -> None
    let (|IsSetter|_|): PropType ->  SetterProp option = function
        | Setter _ as this -> unbox<SetterProp> this |> Some
        | _ -> None
    let (|IsBigInt|_|): PropType ->  NumberProp option = function
        | BigInt _ as this -> unbox<NumberProp> this |> Some
        | _ -> None
    let (|IsComponent|_|): PropType ->  ComponentProp option = function
        | Component _ as this -> unbox<ComponentProp> this |> Some
        | _ -> None
    let (|IsObject|_|): PropType ->  ObjectProp option = function
        | Object _ as this -> unbox<ObjectProp> this |> Some
        | _ -> None
    let (|IsNamespace|_|): PropType ->  UnknownProp option = function
        | Namespace _ as this -> unbox<UnknownProp> this |> Some
        | _ -> None
    let (|IsRegEx|_|): PropType ->  UnknownProp option = function
        | RegEx _ as this -> unbox<UnknownProp> this |> Some
        | _ -> None