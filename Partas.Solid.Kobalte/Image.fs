namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid

[<Erase; Import("Root", Spec.image)>]
type Image() =
    interface RegularNode
    interface Polymorph
    member val fallbackDelay : int = jsNative with get,set
    member val onLoadingStatusChange : LoadingStatus -> unit = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module Image =
    [<Erase; Import("Fallback", Spec.image)>]
    type Fallback() =
        inherit span()
        interface Polymorph
    [<Erase; Import("Img", Spec.image)>]
    type Img() =
        inherit img()
        interface Polymorph
