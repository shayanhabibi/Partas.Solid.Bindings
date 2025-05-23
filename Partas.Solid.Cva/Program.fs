namespace Partas.Solid.Cva

open Fable.Core
open Fable.Core.DynamicExtensions
open Fable.Core.JsInterop
open Fable.Core.Reflection

[<AutoOpen>]
type ``class-variance-authority`` =
    [<Import("cva", "class-variance-authority")>]
    static member cva (defaults: string) (o: obj): (obj -> string) = jsNative

[<JS.Pojo>]
type CvaBaseObj private (variants: JS.ObjectConstructor, defaultVariants: JS.ObjectConstructor, compoundVariants: JS.ObjectConstructor ResizeArray) =
    member val variants: JS.ObjectConstructor = JS.undefined with get,set
    member val defaultVariants: JS.ObjectConstructor = JS.undefined with get,set
    member val compoundVariants: JS.ObjectConstructor ResizeArray = JS.undefined with get,set
type CvaBase = string * CvaBaseObj

type CvaCompoundBase = JS.ObjectConstructor
type CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'B): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'B list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'C): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'C list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'D): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'D list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'E): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'E> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'E list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'E> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'F): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'F> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'F list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'F> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'G): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'G> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'G list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'G> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox

type CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'B): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'B list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'C): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'C list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'D): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'D list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'E): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'E> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'E list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'E> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'F): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'F> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'F list): CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'F> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
type CvaCompound<'A, 'B, 'C, 'D, 'E> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'B): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'B list): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'C): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'C list): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'D): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'D list): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'E): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'E> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'E list): CvaCompound<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'E> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
type CvaCompound<'A, 'B, 'C, 'D> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'B): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'B list): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'C): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'C list): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'D): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'D list): CvaCompound<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'D> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
type CvaCompound<'A, 'B, 'C> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A, 'B, 'C> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A, 'B, 'C> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'B): CvaCompound<'A, 'B, 'C> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'B list): CvaCompound<'A, 'B, 'C> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'C): CvaCompound<'A, 'B, 'C> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'C list): CvaCompound<'A, 'B, 'C> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'C> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
type CvaCompound<'A, 'B> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A, 'B> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A, 'B> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
    member inline this.compound(variant: 'B): CvaCompound<'A, 'B> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'B list): CvaCompound<'A, 'B> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'B> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox
type CvaCompound<'A> = private Compound of CvaCompoundBase with
    member inline this.compound(variant: 'A): CvaCompound<'A> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- getCaseName variant
        this |> unbox
    member inline this.compound(variant: 'A list): CvaCompound<'A> =
        (this |> unbox<CvaCompoundBase>)[ Experimental.nameof typeof<'A> ] <- [| for variant in variant do getCaseName variant|]
        this |> unbox

[<Erase>]
type CvaFunc<'A> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    [<Erase>]
    member inline this.Invoke(variant: 'A): string = this.Invoke(createObj [Experimental.nameof typeof<'A> ==> getCaseName variant])
[<Erase>]
type CvaFunc<'A, 'B> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    member inline this.Invoke(variant: 'A, variantB: 'B): string = this.Invoke(createObj [
        Experimental.nameof typeof<'A> ==> getCaseName variant
        Experimental.nameof typeof<'B> ==> getCaseName variantB
    ])
[<Erase>]
type CvaFunc<'A, 'B, 'C> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    [<Erase>]
    member inline this.Invoke(variant: 'A, variantB: 'B, variantC: 'C): string = this.Invoke(createObj [
        Experimental.nameof typeof<'A> ==> getCaseName variant
        Experimental.nameof typeof<'B> ==> getCaseName variantB
        Experimental.nameof typeof<'C> ==> getCaseName variantC
    ])
[<Erase>]
type CvaFunc<'A, 'B, 'C, 'D> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    [<Erase>]
    member inline this.Invoke(variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D): string = this.Invoke(createObj [
        Experimental.nameof typeof<'A> ==> getCaseName variant
        Experimental.nameof typeof<'B> ==> getCaseName variantB
        Experimental.nameof typeof<'C> ==> getCaseName variantC
        Experimental.nameof typeof<'D> ==> getCaseName variantD
    ])
[<Erase>]
type CvaFunc<'A, 'B, 'C, 'D, 'E> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    [<Erase>]
    member inline this.Invoke(variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D, variantE: 'E): string = this.Invoke(createObj [
        Experimental.nameof typeof<'A> ==> getCaseName variant
        Experimental.nameof typeof<'B> ==> getCaseName variantB
        Experimental.nameof typeof<'C> ==> getCaseName variantC
        Experimental.nameof typeof<'D> ==> getCaseName variantD
        Experimental.nameof typeof<'E> ==> getCaseName variantE
    ])
[<Erase>]
type CvaFunc<'A, 'B, 'C, 'D, 'E, 'F> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    [<Erase>]
    member inline this.Invoke(variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D, variantE: 'E, variantF: 'F): string = this.Invoke(createObj [
        Experimental.nameof typeof<'A> ==> getCaseName variant
        Experimental.nameof typeof<'B> ==> getCaseName variantB
        Experimental.nameof typeof<'C> ==> getCaseName variantC
        Experimental.nameof typeof<'D> ==> getCaseName variantD
        Experimental.nameof typeof<'E> ==> getCaseName variantE
        Experimental.nameof typeof<'F> ==> getCaseName variantF
    ])
[<Erase>]
type CvaFunc<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
    [<Emit("$0($1)")>]
    member inline private this.Invoke(o: obj) = jsNative
    [<Erase>]
    member inline this.Invoke(variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D, variantE: 'E, variantF: 'F, variantG: 'G): string = this.Invoke(createObj [
        Experimental.nameof typeof<'A> ==> getCaseName variant
        Experimental.nameof typeof<'B> ==> getCaseName variantB
        Experimental.nameof typeof<'C> ==> getCaseName variantC
        Experimental.nameof typeof<'D> ==> getCaseName variantD
        Experimental.nameof typeof<'E> ==> getCaseName variantE
        Experimental.nameof typeof<'F> ==> getCaseName variantF
        Experimental.nameof typeof<'G> ==> getCaseName variantG
    ])
[<Erase>]
type Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A, 'B, 'C, 'D, 'E, 'F, 'G>, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    member inline this.variant (variant: 'A, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'C, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'C>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'D, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'D>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'E, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'E>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'F, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'F>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'G, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'G>][getCaseName variant] <- value
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'B): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'C): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'D): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'E): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'E>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'F): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'F>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'G): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'G>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D, variantE: 'E, variantF: 'F, variantG: 'G): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variantB
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variantC
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variantD
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'E>] <- getCaseName variantE
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'F>] <- getCaseName variantF
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'G>] <- getCaseName variantG
        this |> unbox
        
    member inline this.build: CvaFunc<'A, 'B, 'C, 'D, 'E, 'F, 'G> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
[<Erase>]
type Cva<'A, 'B, 'C, 'D, 'E, 'F> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A, 'B, 'C, 'D, 'E, 'F> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A, 'B, 'C, 'D, 'E, 'F>, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    member inline this.build: CvaFunc<'A, 'B, 'C, 'D, 'E, 'F> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
    member inline this.variant (variant: 'A, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'C, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'C>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'D, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'D>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'E, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'E>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'F, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'F>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'G, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F, 'G> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'G>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'B): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'C): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'D): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'E): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'E>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'F): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'F>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D, variantE: 'E, variantF: 'F): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variantB
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variantC
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variantD
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'E>] <- getCaseName variantE
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'F>] <- getCaseName variantF
        this |> unbox
[<Erase>]
type Cva<'A, 'B, 'C, 'D, 'E> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A, 'B, 'C, 'D, 'E> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A, 'B, 'C, 'D, 'E>, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    member inline this.build: CvaFunc<'A, 'B, 'C, 'D, 'E> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
    member inline this.variant (variant: 'A, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'C, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'C>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'D, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'D>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'E, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'E>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'F, value: string): Cva<'A, 'B, 'C, 'D, 'E, 'F> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'F>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'B): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'C): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'D): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'E): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'E>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D, variantE: 'E): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variantB
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variantC
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variantD
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'E>] <- getCaseName variantE
        this |> unbox
[<Erase>]
type Cva<'A, 'B, 'C, 'D> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A, 'B, 'C, 'D> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A, 'B, 'C, 'D>, value: string): Cva<'A, 'B, 'C, 'D> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    member inline this.build: CvaFunc<'A, 'B, 'C, 'D> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
    member inline this.variant (variant: 'A, value: string): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'C, value: string): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'C>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'D, value: string): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'D>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'E, value: string): Cva<'A, 'B, 'C, 'D, 'E> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'E>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'B): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'C): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'D): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A, variantB: 'B, variantC: 'C, variantD: 'D): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variantB
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variantC
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'D>] <- getCaseName variantD
        this |> unbox
[<Erase>]
type Cva<'A, 'B, 'C> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A, 'B, 'C> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A, 'B, 'C>, value: string): Cva<'A, 'B, 'C> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    member inline this.build: CvaFunc<'A, 'B, 'C> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
    member inline this.variant (variant: 'A, value: string): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'C, value: string): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'C>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'D, value: string): Cva<'A, 'B, 'C, 'D> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'D>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'B): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'C): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A, variantB: 'B, variantC: 'C): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variantB
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'C>] <- getCaseName variantC
        this |> unbox
[<Erase>]
type Cva<'A, 'B> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A, 'B> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A, 'B>, value: string): Cva<'A, 'B> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    
    member inline this.build: CvaFunc<'A, 'B> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
    member inline this.variant (variant: 'A, value: string): Cva<'A, 'B> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>][getCaseName variant] <- value
        this |> unbox
    member inline this.variant (variant: 'C, value: string): Cva<'A, 'B, 'C> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'C>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A, 'B> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariant (variant: 'B): Cva<'A, 'B> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A, variantB: 'B): Cva<'A, 'B> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'B>] <- getCaseName variantB
        this |> unbox
[<Erase>]
type Cva<'A> = private Cva of CvaBase with
    member inline _.makeCompound: CvaCompound<'A> = createObj [] |> unbox
    member inline this.compound (compound: CvaCompound<'A>, value: string): Cva<'A> =
        (unbox<CvaCompoundBase> compound)[ "class" ] <- value
        (this |> unbox<CvaBase> |> snd).compoundVariants.Add(!!compound)
        this
    member inline this.build: CvaFunc<'A> = emitJsExpr ((import "cva" "class-variance-authority"), fst !!this, snd !!this) "$0($1, $2)" 
    member inline this.variant (variant: 'A, value: string): Cva<'A> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>][getCaseName variant] <- value
        this
    member inline this.variant (variant: 'B, value: string): Cva<'A, 'B> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'B>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
    member inline this.defaultVariant (variant: 'A): Cva<'A> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox
    member inline this.defaultVariants (variant: 'A): Cva<'A> =
        (this |> unbox<CvaBase> |> snd).defaultVariants[Experimental.nameof typeof<'A>] <- getCaseName variant
        this |> unbox

[<Erase>]
type Cva = private Cva of CvaBase with
    static member inline init (def: string): Cva = (def ,createObj [ "variants" ==> createEmpty; "defaultVariants" ==> createEmpty; "compoundVariants" ==> [||] ]) |> unbox
    member inline this.variant (variant: 'A, value: string): Cva<'A> =
        (this |> unbox<CvaBase> |> snd).variants[Experimental.nameof typeof<'A>] <- createObj [ getCaseName variant ==> value ]
        this |> unbox
