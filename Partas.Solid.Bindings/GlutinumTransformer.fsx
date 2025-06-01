#r "nuget: Fantomas.Core"

open System.Collections.Generic
open FSharp.Core
open Fantomas.Core
open Fantomas.FCS
open Fantomas.FCS.Text
open Fantomas.Core.SyntaxOak

let mutable flags = 0

type StoredNewInheritance = {
    attribute: string
    inheritanceIdentifier: string
}
type AttributeInterfaces = {
    typeDefn: TypeDefnRegularNode
    attributes: (string * Type) list
}

type StoredTypes = {
    identifierTypeDefnMap: Dictionary<string, ITypeDefn>
    typeNewInheritors: Dictionary<string, Dictionary<string, string>>
    attributeInterfaces: ResizeArray<AttributeInterfaces>
}

let cache = {
    identifierTypeDefnMap = Dictionary()
    typeNewInheritors = Dictionary()
    attributeInterfaces = ResizeArray()   
}

/// <summary>
/// Provides extensions for Oak nodes to create nodes given simple primitive types
/// </summary>
[<AutoOpen>]
module Scaffold =
    type SingleTextNode with
        static member make text = SingleTextNode(text, Range.Zero)
        static member makeOptional (text: string) = SingleTextNode.make $"?{text}"
        member this.MakeOptional with get() =
            this.Text |> SingleTextNode.makeOptional
    type MultipleTextsNode with
        static member make texts = MultipleTextsNode([ for text in texts do SingleTextNode.make text ], Range.Zero)
        static member make text = SyntaxOak.MultipleTextsNode.make [ text ]
    type IdentifierOrDot with
        static member makeIdent text = IdentifierOrDot.Ident <| SingleTextNode.make text
        static member makeDot with get() = IdentifierOrDot.KnownDot <| SingleTextNode.make "."
        static member ListFromString (text: string) =
            text.Split '.'
            |> Array.map IdentifierOrDot.makeIdent
            |> fun arr ->
                let length = arr.Length
                arr
                |> Array.mapi (fun idx ident ->
                        if idx = length then
                            [ ident ]
                        else
                            [ ident; IdentifierOrDot.makeDot ]
                    )
            |> Array.toList
            |> List.collect id
    type IdentListNode with
        static member make (text: string) = IdentListNode([ IdentifierOrDot.makeIdent text ], Range.Zero)
        static member make (text: string list) = IdentListNode(text |> List.map IdentifierOrDot.makeIdent, Range.Zero)
        member this.identList with get() =
            this.Content
            |> List.choose (function
                | IdentifierOrDot.Ident ident ->
                    ident.Text
                    |> Some
                | _ -> None
                )
        member this.firstIdent with get() =
            this.identList |> List.head
        member this.lastIdent with get() =
            this.identList |> List.last
        member this.isStropped = this.firstIdent |> _.StartsWith('`')
        member this.isKebab =
            this.Content
            |> List.exists(function
                | IdentifierOrDot.Ident ident ->
                    ident.Text.Contains('-')
                | IdentifierOrDot.KnownDot ident ->
                    ident.Text.Contains('-')
                | _ -> false
                )
        member this.toCamelCase =
            this.Content
            |> List.map(function
                | IdentifierOrDot.Ident ident
                | IdentifierOrDot.KnownDot ident ->
                    ident.Text
                | _ -> ""
                    )
            |> List.toArray
            |> String.concat ""
            |> _.Trim('`')
            |> _.Split('-')
            |> Array.mapi(
                fun i str ->
                    if i = 0 then str
                    else
                    let chars = str.ToCharArray()
                    chars[0] <- chars[0] |> System.Char.ToUpperInvariant
                    chars |> string
                )
            |> String.concat ""
    type AttributeNode with
        static member make text =
            AttributeNode( IdentListNode.make text, None, None, Range.Zero )
    type AttributeListNode with
        static member makeOpening with get() = SingleTextNode.make "[<"
        static member makeClosing with get() = SingleTextNode.make ">]"
        static member make texts =
            AttributeListNode(
                AttributeListNode.makeOpening,
                [ for text in texts do AttributeNode.make text ],
                AttributeListNode.makeClosing,
                Range.Zero
                )
        static member make text =
            AttributeListNode.make [ text ]
    type MultipleAttributeListNode with
        static member make (texts: string seq seq) =
            MultipleAttributeListNode([ for text in texts do AttributeListNode.make text ], Range.Zero)
        static member make (text: string seq)= MultipleAttributeListNode.make [ text ]
        static member make (text: string)= MultipleAttributeListNode.make [ text ]
    type PatParenNode with
        static member makeOpening with get() = SingleTextNode.make "("
        static member makeClosing with get() = SingleTextNode.make ")"
        static member make pattern = PatParenNode(PatParenNode.makeOpening, pattern, PatParenNode.makeClosing, Range.Zero)
    type PatParameterNode with
        static member make ident typ = PatParameterNode(None, Pattern.Null(ident), typ, Range.Zero)
    type PatTupleNode with
        static member makeItem (node: SingleTextNode): Choice<Pattern, SingleTextNode> = Choice2Of2 node
        static member makeItem (node: Pattern): Choice<Pattern, SingleTextNode> = Choice1Of2 node
        static member makeConstructor (members: (SingleTextNode * Type) list) =
            PatTupleNode(
                [ for ident,typ in members do
                    yield Pattern.Parameter(PatParameterNode.make ident.MakeOptional (Some typ)) |> PatTupleNode.makeItem
                    yield SingleTextNode.make "," |> PatTupleNode.makeItem
                ] |> List.cutOffLast, Range.Zero
                )
    type MemberDefnInheritNode with
        /// Gets the last identifier in a chain which should be the type without accessors
        member this.tryGetIdentifier with get() =
            let rec getIdent: Node -> string option = function
                | :? IdentListNode as ident ->
                    ident.lastIdent
                    |> Some
                | :? TypeAppPrefixNode as node ->
                    getIdent node.Children[0]
                | _ -> None
            this.Children[1] |> getIdent
    type ITypeDefn with
        member this.getInheritMembers with get() =
            this.Members
            |> List.choose (function MemberDefn.Inherit node -> Some node | _ -> None)
        member this.getInterfaceMembers with get() =
            this.Members
            |> List.choose (function MemberDefn.Interface node -> Some node | _ -> None)
        member this.getAbstractMembers with get() =
            this.Members
            |> List.choose(function MemberDefn.AbstractSlot node -> Some node | _ -> None)
        member this.getIdentifier = this.TypeName.Identifier.lastIdent
        member this.getAttributes = this.TypeName.Attributes
        member this.getInheritMembersIdentifiers with get() =
            this.getInheritMembers
            |> List.map _.tryGetIdentifier
            |> List.choose id
    type TypeDefnRegularNode with
        member this.TypeDefn = this :> ITypeDefn
    type XmlDocNode with
        static member make (docs: string seq) =
            XmlDocNode([|
                yield "/// <summary>"
                for line in docs do
                    for subline in
                        line |> Seq.chunkBySize 120
                        |> Seq.map (string >> sprintf "/// %s")
                        do yield subline
                yield "/// </summary>"
            |], Range.Zero)
    type MemberDefnInheritNode with
        static member make identifier =
            MemberDefnInheritNode(
                SingleTextNode.make "inherit",
                Type.LongIdent (IdentListNode.make identifier),
                Range.Zero
                )
    type MemberDefnAbstractSlotNode with
        member this.getIdentifierTypeTuple =
            this.Identifier.Text, this.Type
        static member makeSimple(
            identifier: string,
            typ: Type,
            ?docs: string seq,
            ?attributes: string seq,
            ?withGetSet: bool
            ) =
            let withGetSet = defaultArg withGetSet false
            MemberDefnAbstractSlotNode(
                docs |> Option.map XmlDocNode.make,
                attributes |> Option.map MultipleAttributeListNode.make,
                MultipleTextsNode.make ["abstract"; "member"],
                SingleTextNode.make identifier,
                None,
                typ,
                if withGetSet then
                    MultipleTextsNode.make [ "with"; "get,"; "set" ]
                    |> Some
                else None
                ,Range.Zero
                )
    type MemberDefn with
        static member makeInherit identifier =
            MemberDefnInheritNode.make identifier |> MemberDefn.Inherit
        static member makeAbstract (attrName: string, typ: Type) =
            MemberDefnAbstractSlotNode.makeSimple(attrName, typ)
            |> MemberDefn.AbstractSlot
        static member makeExtensionGetSetWith (name: string, typ: Type, ?inlineOverload: string) =
            MemberDefnPropertyGetSetNode(
                None,Some(MultipleAttributeListNode.make "Erase"),MultipleTextsNode.make "member",None,None,
                IdentListNode.make $"_.{name}", SingleTextNode.make "with",
                PropertyGetSetBindingNode(
                      None, None, None, SingleTextNode.make "set", [
                          Pattern.Parameter(PatParameterNode.make (SingleTextNode.make "_") (Some typ))
                          |> PatParenNode.make
                          |> Pattern.Paren
                      ], None, SingleTextNode.make "=", Expr.Null(SingleTextNode.make "()"), Range.Zero
                    ),
                SingleTextNode.make "and" |> Some,
                PropertyGetSetBindingNode(
                    None,
                    MultipleAttributeListNode.make "Erase" |> Some,
                    None, SingleTextNode.make "get", [
                        Pattern.Unit(UnitNode(PatParenNode.makeOpening, PatParenNode.makeClosing, Range.Zero))
                    ],
                    BindingReturnInfoNode(SingleTextNode.make ":", typ, Range.Zero)
                    |> Some,
                    SingleTextNode.make "=",
                    Expr.Ident(SingleTextNode.make "JS.undefined"),
                    Range.Zero
                    ) |> Some,
                Range.Zero
                ) |> MemberDefn.PropertyGetSet
        static member makeExtensionGetSet (name: string) (typ: Type) =
            MemberDefn.makeExtensionGetSetWith(name, typ)
    type TypeNameNode with
        static member makeSimple (
            identifier: string,
            ?docs: string list,
            ?attributes: string list,
            ?suffix: string
            ) =
            TypeNameNode(
                docs |> Option.map XmlDocNode.make,
                attributes |> Option.map MultipleAttributeListNode.make,
                SingleTextNode.make "type",
                None,
                IdentListNode.make identifier,
                None,
                [],
                None,
                SingleTextNode.make "=" |> Some,
                suffix |> Option.map SingleTextNode.make,
                Range.Zero
                )
        static member makeExtension (identifier: IdentListNode) =
            TypeNameNode(None,None,SingleTextNode.make "type", None,
                         identifier, None, [], None,
                         SingleTextNode.make "with" |> Some, None, Range.Zero)
        static member makeExtension (identifier: string) =
            IdentListNode.make identifier |> TypeNameNode.makeExtension
    type TypeDefnRegularNode with
        static member make members typeNameNode =
            TypeDefnRegularNode(typeNameNode, members, Range.Zero)
    type ModuleDecl with
        static member wrapInNestedModule name (attributes: string seq option) decls =
            NestedModuleNode(
                None, attributes |> Option.map MultipleAttributeListNode.make,
                SingleTextNode.make "module",None,false,IdentListNode.make name,
                SingleTextNode.make "=", decls, Range.Zero
                )
            |> ModuleDecl.NestedModule
let finaliseTypes (e: TypeDefnRegularNode list) =
    let decls = e |> List.map (TypeDefn.Regular >> ModuleDecl.TypeDefn)
    Oak([], [ ModuleOrNamespaceNode(None, decls, Range.Zero) ], Range.Zero)
    |> CodeFormatter.FormatOakAsync
    |> Async.RunSynchronously
    |> printfn "%s"
let pojoNode () = AttributeListNode.make "JS.Pojo"
let createImplicitConstructorFromSlots (slots: SyntaxOak.MemberDefnAbstractSlotNode list) =
    let members =
        [
            for slot in slots do
                slot.Identifier, slot.Type
        ]
    ImplicitConstructorNode( None, None, None, Pattern.Paren( Pattern.Tuple(PatTupleNode.makeConstructor members) |> PatParenNode.make), None, Range.Zero )
let transformMember (memb: MemberDefn) =
    match memb with
    | SyntaxOak.MemberDefn.ImplicitInherit inheritConstructor -> failwith "todo"
    | SyntaxOak.MemberDefn.Inherit _ as node -> node
    | SyntaxOak.MemberDefn.ValField fieldNode -> failwith "todo"
    | SyntaxOak.MemberDefn.Member bindingNode -> failwith "todo"
    | SyntaxOak.MemberDefn.ExternBinding externBindingNode -> failwith "todo"
    | SyntaxOak.MemberDefn.DoExpr exprSingleNode -> failwith "todo"
    | SyntaxOak.MemberDefn.LetBinding bindingListNode -> failwith "todo"
    | SyntaxOak.MemberDefn.ExplicitCtor memberDefnExplicitCtorNode -> failwith "todo"
    | SyntaxOak.MemberDefn.Interface memberDefnInterfaceNode -> failwith "todo"
    | SyntaxOak.MemberDefn.AutoProperty memberDefnAutoPropertyNode -> failwith "todo"
    | SyntaxOak.MemberDefn.AbstractSlot memb ->
        match flags with
        | 0 ->
            MemberDefn.ValField(
                FieldNode(
                    xmlDoc = memb.XmlDoc,
                    attributes = Some(MultipleAttributeListNode.make "DefaultValue"),
                    leadingKeyword = Some (MultipleTextsNode(
                            [
                                SingleTextNode.make "val"
                            ], Range.Zero
                        )),
                    accessibility = None,
                    name = Some memb.Identifier,
                    t = memb.Type,
                    mutableKeyword = Some(SingleTextNode.make "mutable"),
                    range = Range.Zero
                )
            )
        | _ ->
            MemberDefn.AutoProperty(
                SyntaxOak.MemberDefnAutoPropertyNode(
                    xmlDoc = memb.XmlDoc,
                    attributes = Some(MultipleAttributeListNode.make "Erase"),
                    leadingKeyword = MultipleTextsNode.make [ "member"; "val" ],
                    accessibility = None,
                    identifier = memb.Identifier,
                    t = Some memb.Type,
                    equals = SingleTextNode.make "=",
                    expr = Expr.Constant(Constant.FromText (SingleTextNode.make "JS.undefined")),
                    withGetSet = Some (MultipleTextsNode.make [ "with"; "get"; ","; "set" ]),
                    range = Range.Zero
                    )
                )
    | SyntaxOak.MemberDefn.PropertyGetSet memberDefnPropertyGetSetNode -> failwith "todo"
    | SyntaxOak.MemberDefn.SigMember memberDefnSigMemberNode -> failwith "todo"
let transformMembers (members: MemberDefn list) =
    members |> List.map transformMember
let transformTypeDefNode (node: TypeDefnRegularNode) =
    let typeName =
        node :> ITypeDefn
        |> _.TypeName
        |> fun nameNode ->
            TypeNameNode(
                xmlDoc = nameNode.XmlDoc,
                attributes = Some(MultipleAttributeListNode([pojoNode()], Range.Zero)),
                leadingKeyword = nameNode.LeadingKeyword,
                ao = None,
                identifier = nameNode.Identifier,
                typeParams = nameNode.TypeParameters,
                constraints = nameNode.Constraints,
                implicitConstructor = Some(createImplicitConstructorFromSlots (node :> ITypeDefn |> _.Members |> List.choose(function | MemberDefn.AbstractSlot memb -> Some memb | _ -> None))),
                equalsToken = nameNode.EqualsToken,
                withKeyword = nameNode.WithKeyword,
                range = Range.Zero
            )
    TypeDefnRegularNode(typeName, node :> ITypeDefn |> _.Members |> transformMembers, Range.Zero)

let rec transform: Node -> Node list = function
    | :? TypeDefnRegularNode as node ->
        [ transformTypeDefNode node ]
    | node ->
        node.Children
        |> Array.map transform
        |> Array.toList
        |> List.collect (id)

let rec pruneOptions = function
    | Type.AppPostfix node ->
        let first = node.First |> pruneOptions
        let second = node.Last |> pruneOptions
        match first,second with
        | Some _, Some _ ->
            Type.AppPostfix node
            |> Some
        | Some _, _ ->
            first
        | _, Some _ ->
            second
        | _ -> None
    | Type.Anon node ->
        if node.Text = "option"
        then None
        else Type.Anon node |> Some
    | Type.AppPrefix node ->
        node.Identifier
        |> function
            | Type.LongIdent ident ->
                if ident.Content[0]
                    |> function IdentifierOrDot.Ident textNode -> textNode.Text | _ -> failwith "unreachable"
                    |> fun str ->
                        str.Length = 2
                        && str.StartsWith 'U'
                        && (str[1] |> System.Char.IsDigit)
                then Type.AppPrefix node |> Some
                else node.Identifier |> Some
            | _ -> node.Identifier |> Some
    | Type.Var textNode -> if textNode.Text = "option" then None else Type.Var textNode |> Some
    | Type.LongIdent node ->
        if node.Content.Head |> function IdentifierOrDot.Ident textNode -> textNode.Text = "option" | _ -> false
        then None
        else Type.LongIdent node |> Some
    | node -> Some node
let unionOrStringType = function
    | Type.AppPrefix node ->
        node.Identifier
        |> function
            | Type.LongIdent ident ->
                if ident.Content[0]
                    |> function IdentifierOrDot.Ident textNode -> textNode.Text | _ -> failwith "unreachable"
                    |> fun str ->
                        str.Length = 2
                        && str.StartsWith 'U'
                        && (str[1] |> System.Char.IsDigit)
                then Type.AppPrefix node
                else Type.StaticConstant(Constant.FromText(SingleTextNode.make "string"))
            | _ -> Type.StaticConstant(Constant.FromText(SingleTextNode.make "string"))
    | _ -> Type.StaticConstant(Constant.FromText(SingleTextNode.make "string"))
        
type Collision = Collision of parentName: string * attributeName: string * typeNode: Type
    with
    member this.parent = let (Collision (parent,_,_)) = this in parent
    member this.attribute = let (Collision (_,attribute,_)) = this in attribute
    member this.typ = let (Collision (_,_,typ)) = this in typ
    static member sameAttribute(x: Collision,y: Collision) = x.attribute = y.attribute
    static member sameParent(x: Collision,y: Collision) = x.parent = y.parent
type ParentCollisions = Collision list
type ChildCollisionMap = ChildCollisionMap of childName: string * parentCollisionList: ParentCollisions
    with
    member this.parentCollisions = let (ChildCollisionMap(_,value)) = this in value
    member this.child = let (ChildCollisionMap(value,_)) = this in value
let getTypeDefnNodeIdentifier: ITypeDefn -> string =
    _.TypeName
    >> _.Identifier
    >> fun identListNode ->
        [
            for node in identListNode.Content do
                match node with
                | IdentifierOrDot.Ident textNode -> yield textNode.Text
                | _ -> ()
        ] |> List.head
let expandCache () =
    let memo = cache.identifierTypeDefnMap.AsReadOnly()
    let inheritanceMap: Dictionary<string, ITypeDefn ResizeArray> = Dictionary()
    let mapInheritance (typeDefn: ITypeDefn) =
        typeDefn.Members
        |> List.iter (
            function
                | MemberDefn.Inherit node ->
                    let rec getIdent: Node -> string = function
                        | :? IdentListNode as ident ->
                            ident.Content
                            |> List.last
                            |> function IdentifierOrDot.Ident textNode -> textNode.Text | _ -> failwith "unreachable"
                        | :? TypeAppPrefixNode as node ->
                            getIdent node.Children[0]
                        | _ ->
                            failwith "unreachable"
                    let key = node.Children[1] |> getIdent
                    if inheritanceMap.ContainsKey key then
                        inheritanceMap[key].Add typeDefn
                    else
                        inheritanceMap.Add(key, ResizeArray [typeDefn])
                | _ -> ()
            )
    let getChildrenCollisions = fun () ->
        let valueCollectionToList: ResizeArray<ITypeDefn> -> ITypeDefn list = _.ToArray() >> Array.toList
        let getIdentifierTypeTupleForAbstractSlot: MemberDefnAbstractSlotNode -> string * Type =
            fun node -> node.Identifier.Text, node.Type
        let getAbstractSlotsForTypeDefn: ITypeDefn -> _ list =
            _.Members >> List.choose (function MemberDefn.AbstractSlot node -> Some node | _ -> None)
            >> List.map getIdentifierTypeTupleForAbstractSlot
        let rec getAllAbstracts (typeDefn: ITypeDefn list) =
            seq {
                for typ in typeDefn do
                    let name = getTypeDefnNodeIdentifier typ
                    let slots =
                        typ|> getAbstractSlotsForTypeDefn |> List.map (fun (x,y) -> name,x,y)
                    yield slots
                    if inheritanceMap.ContainsKey(name) then
                        for x in 
                            inheritanceMap[name]
                            |> valueCollectionToList
                            |> getAllAbstracts do
                            yield x
            }
        inheritanceMap.Values
        |> Seq.map valueCollectionToList
        |> Seq.map (
            getAllAbstracts
            >> Seq.collect id
            >> Seq.toList
        )
        |> Seq.zip inheritanceMap.Keys
        |> Seq.map ( fun (parent, childrenAttrs) ->
            let duplicateAttrs =
                childrenAttrs
                |> List.countBy (
                    fun (_,key,_) -> key)
                |> List.filter (snd >> (<) 1)
            let collidingAttrs =
                childrenAttrs
                |> List.filter (
                    fun (_,key,_) ->
                        duplicateAttrs
                        |> List.map fst
                        |> List.contains key
                    )
                |> List.map Collision
            ChildCollisionMap (parent,collidingAttrs)
            )
        |> fun collisions ->
            let makeTypeNode (attributeName: string, collisions: Collision list) =
                let parentNames = collisions |> List.map _.parent
                let typ = collisions[0].typ
                let identifierName = $"{attributeName}AttributeInterfaceProvider"
                let typeDefn =
                    TypeNameNode.makeSimple(
                            identifierName,
                            [$"Providing the attribute <c>{attributeName} to interfaces to prevent collisions"],
                            [ "AllowNullLiteral"
                              "System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)" ],
                            "interface end"
                        )
                    |> TypeDefnRegularNode.make []
                let registerTypeDefn (name: string) =
                    if cache.typeNewInheritors.ContainsKey name then
                        cache.typeNewInheritors[name]
                        |> _.TryAdd(attributeName, identifierName)
                        |> ignore
                    else
                        cache.typeNewInheritors.Add(name, Dictionary([ KeyValuePair(attributeName,identifierName) ]))
                
                parentNames |> List.iter registerTypeDefn
                let interfaceRegisterItem: AttributeInterfaces = {
                    typeDefn = typeDefn
                    attributes = [ attributeName, typ ]
                }
                cache.attributeInterfaces.Add interfaceRegisterItem
                
            collisions
            |> Seq.iter (
                _.parentCollisions
                >> List.groupBy _.attribute
                >> List.iter makeTypeNode
                )
    memo.Values |> Seq.iter mapInheritance
    getChildrenCollisions()
let cacheTypeDefNode (node: TypeDefnRegularNode) =
    node :> ITypeDefn
    |> fun defn -> cache.identifierTypeDefnMap.Add(getTypeDefnNodeIdentifier defn, defn)
let cachedTransform (node: Node) =
    let root = node
    let rec findTypeDefns: Node -> unit = function
        | :? TypeDefnRegularNode as node ->
            cacheTypeDefNode node
        | node ->
            node.Children
            |> Array.iter findTypeDefns
    do findTypeDefns root
    expandCache()

let renderCache () =
    let cachedTypes = [
        for typeDefnName in cache.identifierTypeDefnMap.Keys do
            if cache.typeNewInheritors.ContainsKey typeDefnName then
                let typeDefn = cache.identifierTypeDefnMap[typeDefnName]
                let inheritors,attributes =
                    typeDefn.Members
                    |> List.choose(function
                        // | MemberDefn.Interface _
                        | MemberDefn.Inherit _
                        | MemberDefn.AbstractSlot _ as node -> Some node
                        | _ -> None
                        )
                    |> List.partition (function
                        // | MemberDefn.Interface _
                        | MemberDefn.Inherit _ -> true
                        | _ -> false
                        )
                let registeredAttributeInterfaces = cache.typeNewInheritors[typeDefnName]
                let interfaceNames = registeredAttributeInterfaces.Values
                let filteredAttributes =
                    attributes
                    |> List.choose(function MemberDefn.AbstractSlot node -> Some node | _ -> None)
                    |> List.filter (fun node ->
                        not <| registeredAttributeInterfaces.ContainsKey node.Identifier.Text
                        )
                    |> List.map MemberDefn.AbstractSlot
                let newInheritors =
                    interfaceNames
                    |> Seq.map MemberDefn.makeInherit
                    |> Seq.toList
                    |> List.append inheritors
                typeDefn.TypeName
                |> TypeDefnRegularNode.make (newInheritors @ filteredAttributes)
            else
                cache.identifierTypeDefnMap[typeDefnName] :?> TypeDefnRegularNode
    ]
    let newTypes = [
        for attributeInterface in
            cache.attributeInterfaces.ToArray()
            |> Array.distinctBy(fun attrInter ->
                    attrInter.typeDefn :> ITypeDefn
                    |> getTypeDefnNodeIdentifier
                ) do
            
            let abstractAttributes =
                attributeInterface.attributes
                |> List.map MemberDefn.makeAbstract
            TypeDefnRegularNode(
                attributeInterface.typeDefn.TypeDefn.TypeName,
                abstractAttributes,
                Range.Zero
                )
    ]
    newTypes @ cachedTypes

let renderExtensions (typeDefns: TypeDefnRegularNode list) =
    let getTypeName: ITypeDefn -> SyntaxOak.TypeNameNode = _.TypeName
    let getMembers: ITypeDefn -> MemberDefn list = _.Members
    let typeNames = typeDefns |> List.map getTypeName
    let members = typeDefns |> List.map getMembers
    let typeMembers = List.zip typeNames members
    let renderedTypeNames = [
        for typeName,members in typeMembers do
            TypeDefnRegularNode(
                typeName,
                (let inherits = members |> List.choose (function MemberDefn.Inherit node -> Some node | _ -> None)
                if inherits |> List.isEmpty then
                    [
                        MemberDefn.Interface(
                            MemberDefnInterfaceNode(
                                SingleTextNode.make "interface"
                                ,Type.Var(SingleTextNode.make "end")
                                ,None,[],Range.Zero
                                )
                            )
                    ]
                else inherits |> List.map MemberDefn.Inherit) 
                , Range.Zero
                )
    ]
    let renderedExtensions = [
        for typeName,members in typeMembers |> List.filter (snd >> List.filter (function MemberDefn.AbstractSlot _ -> true | _ -> false) >> List.isNotEmpty) do
            TypeDefnRegularNode(
                TypeNameNode.makeExtension typeName.Identifier,
                seq {
                    for memberDefn in members do
                        match memberDefn with
                        | MemberDefn.AbstractSlot memberNode ->
                          yield
                              memberNode.Type
                              |> fun typ ->
                                pruneOptions typ
                                |> function
                                    | Some typ ->
                                        unionOrStringType typ
                                    | None -> unionOrStringType typ
                              |> MemberDefn.makeExtensionGetSet memberNode.Identifier.Text
                        | _ -> ()
                } |> Seq.toList
                ,Range.Zero
                )
    ]
    let extensionModule =
        renderedExtensions
        |> List.map (TypeDefn.Regular >> ModuleDecl.TypeDefn)
        |> ModuleDecl.wrapInNestedModule "AttributeExtensions" (Some [ "Erase"; "AutoOpen" ])
    Oak([],[
        ModuleOrNamespaceNode(None, (renderedTypeNames |> List.map (TypeDefn.Regular >> ModuleDecl.TypeDefn)) @ [ extensionModule ], Range.Zero)
    ], Range.Zero)
    
let parse testInput =
    flags <- 0
    Parse.parseFile false (SourceText.ofString testInput) []
    |> fst
    |> CodeFormatter.TransformAST
    |> transform
    |> List.map (unbox<TypeDefnRegularNode>)
    |> finaliseTypes

let parseMemberVals testInput =
    flags <- 1
    Parse.parseFile false (SourceText.ofString testInput) []
    |> fst
    |> CodeFormatter.TransformAST
    |> transform
    |> List.map (unbox<TypeDefnRegularNode>)
    |> finaliseTypes

let parseTagExtensions testInput =
    Parse.parseFile false (SourceText.ofString testInput) []
    |> fst
    |> CodeFormatter.TransformAST
    |> cachedTransform
    |> renderCache
    |> renderExtensions
    |> CodeFormatter.FormatOakAsync
    |> Async.RunSynchronously
    |> printfn "%s"

let refreshCache () = cache.identifierTypeDefnMap.Clear()
