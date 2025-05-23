#r "nuget: Fantomas.Core"

open FSharp.Core
open Fantomas.Core
open Fantomas.FCS
open Fantomas.FCS.Text
open Fantomas.Core.SyntaxOak


let finaliseTypes (e: TypeDefnRegularNode list) =
    let decls = e |> List.map (TypeDefn.Regular >> ModuleDecl.TypeDefn)
    Oak([], [ ModuleOrNamespaceNode(None, decls, Range.Zero) ], Range.Zero)
    |> CodeFormatter.FormatOakAsync
    |> Async.RunSynchronously
    |> printfn "%s"
let createTextNode text = SingleTextNode(text, Range.Zero)
let createAttributeNode text =
    AttributeNode(
        IdentListNode(
            [ createTextNode text |> IdentifierOrDot.Ident ],
            Range.Zero
        ),
        None,
        None,
        Range.Zero
    )
let createAttributeListNode texts =
    AttributeListNode(
        createTextNode "[<",
        [
            for text in texts do createAttributeNode text
        ],
        createTextNode ">]",
        Range.Zero
    )
let pojoNode () = createAttributeListNode [ "JS.Pojo" ]
let makeTextOptional (ident: SingleTextNode) =
    SingleTextNode(
        $"?{ident.Text}",
        Range.Zero
    )
let createImplicitConstructorFromSlots (slots: SyntaxOak.MemberDefnAbstractSlotNode list) =
    let members =
        [
            for slot in slots do
                slot.Identifier, slot.Type
        ]
    ImplicitConstructorNode(
        None,
        None,
        None,
        Pattern.Paren(
            PatParenNode(
                createTextNode "(",
                Pattern.Tuple(
                    PatTupleNode(
                        [
                            for ident,``type`` in members do
                                yield Pattern.Parameter(
                                    PatParameterNode(
                                        None,
                                        Pattern.Null(makeTextOptional ident),
                                        Some(``type``),
                                        Range.Zero
                                    )
                                ) |> Choice1Of2
                                yield createTextNode "," |> Choice2Of2
                        ] |> List.cutOffLast,
                        Range.Zero
                    )
                ),
                createTextNode ")",
                Range.Zero
            )
        ),
        None,
        Range.Zero
    )
let transformMember (memb: MemberDefn) =
    match memb with
    | SyntaxOak.MemberDefn.ImplicitInherit inheritConstructor -> failwith "todo"
    | SyntaxOak.MemberDefn.Inherit memberDefnInheritNode -> failwith "todo"
    | SyntaxOak.MemberDefn.ValField fieldNode -> failwith "todo"
    | SyntaxOak.MemberDefn.Member bindingNode -> failwith "todo"
    | SyntaxOak.MemberDefn.ExternBinding externBindingNode -> failwith "todo"
    | SyntaxOak.MemberDefn.DoExpr exprSingleNode -> failwith "todo"
    | SyntaxOak.MemberDefn.LetBinding bindingListNode -> failwith "todo"
    | SyntaxOak.MemberDefn.ExplicitCtor memberDefnExplicitCtorNode -> failwith "todo"
    | SyntaxOak.MemberDefn.Interface memberDefnInterfaceNode -> failwith "todo"
    | SyntaxOak.MemberDefn.AutoProperty memberDefnAutoPropertyNode -> failwith "todo"
    | SyntaxOak.MemberDefn.AbstractSlot memb ->
        MemberDefn.ValField(
            FieldNode(
                xmlDoc = memb.XmlDoc,
                attributes = Some(MultipleAttributeListNode([createAttributeListNode ["DefaultValue"]], Range.Zero)),
                leadingKeyword = Some (MultipleTextsNode(
                        [
                            createTextNode "val"
                        ], Range.Zero
                    )),
                accessibility = None,
                name = Some memb.Identifier,
                t = memb.Type,
                mutableKeyword = Some(createTextNode "mutable"),
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

let parse testInput =
    Parse.parseFile false (SourceText.ofString testInput) []
    |> fst
    |> CodeFormatter.TransformAST
    |> transform
    |> List.map (unbox<TypeDefnRegularNode>)
    |> finaliseTypes