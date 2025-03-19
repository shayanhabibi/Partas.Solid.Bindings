module rec Partas.Solid.Bindings

open Fable.Core.JS
open Partas.Utilities.StructuredTypes
open Fable.Core
open Fable.Core.JsInterop
open System

#nowarn 44

type IFileSystem =
    abstract readFileSync: string -> byte[]
    abstract readFileSync: string * string -> string
    abstract writeFileSync: string * string -> unit

// let fs: IFileSystem = importAll "fs"
// let writeAllText (filePath: string) (text: string) = fs.writeFileSync(filePath, text) 



// grab all nodes
let nodes = parseFiles([| "./node_modules/@tanstack/solid-table/build/lib/index.d.ts" |])

// define arrays
let constants = new ResizeArray<IPropType>()
let unknowns = new ResizeArray<IPropType>()
let types = new ResizeArray<IPropType>()
// define helpers
let addConstant = constants.Add
let addUnknown = unknowns.Add
let addType = types.Add
// utils
let getNameOrType (value: IPropType) =
    value.name
    |> Option.orElse value.alias
    |> Option.orElse value.``type``
let getNameOrTypeElse (def: string) (value: IPropType) =
    value |> getNameOrType |> Option.defaultValue def
let (|PropertyCollector|): PropType -> string = function
    | IsUndefined propType -> propType |> getNameOrTypeElse "obj"
    | IsUnknown propType -> propType |> getNameOrTypeElse "obj"
    
    | IsNull propType -> propType |> getNameOrTypeElse "unit"
    | IsVoid propType -> propType |> getNameOrTypeElse "unit"
    
    | IsNamespace _
    | IsRegEx _
    | IsRest _ -> ""
    | IsBoolean propType -> propType |> getNameOrTypeElse "obj"
    | IsNumber propType ->
        propType
        |> getNameOrTypeElse "obj"
    | IsString propType ->
        propType |> getNameOrType |> Option.orElse propType.value |> Option.defaultValue "obj"
    | IsBigInt propType -> propType |> getNameOrTypeElse "obj"
    
    | IsArray propType -> propType |> getNameOrTypeElse "obj"
    | IsTuple propType -> propType |> getNameOrTypeElse "obj"
    | IsUnion propType -> propType |> getNameOrTypeElse "obj"
    | IsEnum propType -> propType |> getNameOrTypeElse "obj"
    | IsFunction propType -> propType |> getNameOrTypeElse "obj"
    | IsClass propType -> propType |> getNameOrTypeElse "obj"
    | IsInterface propType -> propType |> getNameOrTypeElse "obj"
    | IsType propType -> propType |> getNameOrTypeElse "obj"
    | IsAny propType -> propType |> getNameOrTypeElse "obj"
    | IsIndex propType -> propType |> getNameOrTypeElse "obj"
    | IsConstructor propType -> propType |> getNameOrTypeElse "obj"
    | IsGetter propType -> propType |> getNameOrTypeElse "obj"
    | IsSetter propType -> propType |> getNameOrTypeElse "obj"
    | IsComponent propType -> propType |> getNameOrTypeElse "obj"
    | IsObject propType -> propType |> getNameOrTypeElse "obj"
    // others
    | unknown -> ""
let (|PropertyFeeder|): PropType list -> string list = function
    | [] -> []
    | [ PropertyCollector prop ] -> [ prop ]
    | PropertyCollector prop :: PropertyFeeder rest -> prop :: rest

let printBasicInfo (value: IPropType) =
    let print func = value |> func |> Option.defaultValue "" |> Console.WriteLine
    print _.name
    print _.``type``
    
let (|Transformer|): PropType -> unit = function
    | IsUndefined propType -> addUnknown propType
    | IsUnknown propType -> addUnknown propType
    | IsVoid propType -> addUnknown propType
    | IsNamespace propType -> addUnknown propType
    | IsRegEx propType -> addUnknown propType
    | IsRest propType -> addUnknown propType
    | IsBoolean propType -> addConstant propType
    | IsNumber propType -> addConstant propType
    | IsString propType -> addConstant propType
    | IsBigInt propType -> addConstant propType
    | IsNull propType -> addConstant propType
    // Types
    | IsArray propType ->
        Console.WriteLine "==ArrayProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsTuple propType ->
        Console.WriteLine "==TupleProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsUnion propType ->
        Console.WriteLine "==UnionProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsEnum propType ->
        Console.WriteLine "==EnumProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsFunction propType ->
        Console.WriteLine "==FunctionProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Parameters=="
        for prop in propType.parameters |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Returns=="        
        propType |> _.returns |> Option.map printBasicInfo |> ignore
        Console.WriteLine "==Types=="        
        for prop in propType.types |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
        addType propType
    | IsClass propType ->
        Console.WriteLine "==ClassProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Extends=="
        for prop in propType.extends |> Option.defaultValue [] do
            Console.WriteLine prop
        Console.WriteLine "==Generics=="        
        for prop in propType.generics |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Implements=="        
        for prop in propType.implements |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Properties=="        
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType

    | IsInterface propType ->
        Console.WriteLine "==InterfaceProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Extends=="
        for prop in propType.extends |> Option.defaultValue [] do
            Console.WriteLine prop
        Console.WriteLine "==Generics=="        
        for prop in propType.generics |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsType propType ->
        Console.WriteLine "==ArrayProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Extends=="
        for prop in propType.extends |> Option.defaultValue [] do
            Console.WriteLine prop
        Console.WriteLine "==Generics=="        
        for prop in propType.generics |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsAny propType ->
        Console.WriteLine "==AnyProp=="
        propType |> printBasicInfo
        addType propType
    | IsIndex propType ->
        Console.WriteLine "==IndexProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Index=="
        propType |> _.index |> printBasicInfo
        Console.WriteLine "==Prop=="
        propType |> _.prop |> Option.map printBasicInfo |> ignore
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsConstructor propType ->
        Console.WriteLine "==ConstructorProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Parameters=="
        for prop in propType.parameters |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Returns=="        
        propType |> _.returns |> Option.map printBasicInfo |> ignore
        Console.WriteLine "==Types=="        
        for prop in propType.types |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsGetter propType ->
        Console.WriteLine "==GetterProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Parameters=="
        for prop in propType.parameters |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Returns=="        
        propType |> _.returns |> Option.map printBasicInfo |> ignore
        Console.WriteLine "==Types=="        
        for prop in propType.types |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType

    | IsSetter propType ->
        Console.WriteLine "==SetterProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Parameters=="
        for prop in propType.parameters |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Returns=="        
        propType |> _.returns |> Option.map printBasicInfo |> ignore
        Console.WriteLine "==Types=="        
        for prop in propType.types |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType

    | IsComponent propType ->
        Console.WriteLine "==ComponentProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Extends=="
        for prop in propType.extends |> Option.defaultValue [] do
            Console.WriteLine prop
        Console.WriteLine "==Generics=="        
        for prop in propType.generics |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Implements=="        
        for prop in propType.implements |> Option.defaultValue [] do
            prop |> printBasicInfo
        Console.WriteLine "==Properties=="        
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    | IsObject propType ->
        Console.WriteLine "==ObjectProp=="
        propType |> printBasicInfo
        Console.WriteLine "==Props=="
        for prop in propType.properties |> Option.defaultValue [] do
            prop |> printBasicInfo
        addType propType
    // others
    | unknown -> addUnknown !!unknown 

let nextLine = (+) "\n"
let commentOut = fun str -> "// " + str

nodes.props |> Array.map (function | Transformer -> () ) |> ignore

// |> String.concat "\n"
// |> writeAllText "./Test.txt" 
