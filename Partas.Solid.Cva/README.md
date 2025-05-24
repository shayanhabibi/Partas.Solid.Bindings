# Partas.Solid.Cva

> F# wrapper for the js library 'class-variance-authority', widely used with
> utility styling libraries like tailwind

This provides a more idiomatic and typesafe method for the general creation and usage of cva from the npm module `class-variance-authority`.

```fsharp
// All of your variants are derived from unions

type Variant =
    | Default
    | Destructive
    | Outline

type Size =
    | Default
    | Small
    | Large

// You then initialise a CVA builder with the default classes
// and start adding your variant definitions
let buttonVariants =                                        // TYPES:
    Cva.init "hover:translate-y-1"                          // : CvaBase
    |> _.variant(Variant.Default, "bg-primary")             // : Cva<Variant>
    |> _.variant(Destructive, "bg-destructive")             // 
    |> _.variant(Outline, "bg-transparent border-border")   // 
    |> _.variant(Size.Default, "h-10")                      // : Cva<Variant, Size>
    |> _.variant(Small, "h-9")                              //
    |> _.variant(Large, "h-11")                             //
    |> _.defaultVariant(Variant.Default)                    //
    |> _.defaultVariant(Size.Default)                       //
    |> _.build                                              // : CvaFunc<Variant, Size>

// ... usage
class' = buttonVariants.Invoke(Variant.Destructive, Size.Small)
```

### defaultVariant vs defaultVariants

the `.defaultVariants` method is better for typesafety since it will force an explicit default to be given for each variant union.

### CompoundVariants

```fsharp
let buttonVariantsBuilder =
    Cva.init "hover:translate-y-1"                          // : CvaBase
    |> _.variant(Variant.Default, "bg-primary")             // : Cva<Variant>
    |> _.variant(Size.Default, "h-10")                      // : Cva<Variant, Size>

buttonVariantsBuilder.compound(                             
    buttonVariantsBuilder.makeCompound                      // : CvaCompound<Variant, Size>
    |> _.compound Variant.Destructive
    |> _.compound [ Size.Small; Size.Large ]
    ,"border-ring"
)                                                           // : Cva<Variant, Size>
```

### Recommendations

I would suggest against using this (despite my work on it). Why bring another dependency into your toolchain?

F# provides fantastic primitives to manage this type of conditional construction via our powerful pattern matching constructs.