namespace Partas.Solid.Kobalte

open Partas.Solid
open Fable.Core


[<Erase; Import("Root", Spec.fileField)>]
type FileField() =
    inherit div()
    interface Polymorph
    member val multiple : bool = jsNative with get,set
    member val maxFiles : int = jsNative with get,set
    member val disabled : bool = jsNative with get,set
    member val accept : U2<string, string[]> = jsNative with get,set
    member val allowDragAndDrop : bool = jsNative with get,set
    member val maxFileSize : int = jsNative with get,set
    member val minFileSize : int = jsNative with get,set
    member val onFileAccept : obj[] -> unit = jsNative with get,set
    member val onFileReject : obj[] -> unit = jsNative with get,set
    member val onFileChange : obj -> unit = jsNative with get,set
    member val validateFile : obj -> obj[] = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module FileField =
    [<Erase; Import("Item", Spec.fileField)>]
    type Item() =
        inherit div()
        interface Polymorph
        member val file : obj = jsNative with get,set
    [<Erase; Import("ItemSize", Spec.fileField)>]
    type ItemSize() =
        interface VoidNode
        interface Polymorph
        member val precision : int = jsNative with get,set
    [<Erase; Import("ItemPreview", Spec.fileField)>]
    type ItemPreview() =
        interface VoidNode
        interface Polymorph
        member val type' : string = jsNative with get,set
    [<Erase; Import("Dropzone", Spec.fileField)>]
    type Dropzone() =
        inherit div()
        interface Polymorph
    [<Erase; Import("Trigger", Spec.fileField)>]
    type Trigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Label", Spec.fileField)>]
    type Label() =
        inherit label()
        interface Polymorph
    [<Erase; Import("HiddenInput", Spec.fileField)>]
    type HiddenInput() =
        inherit input()
        interface Polymorph
    [<Erase; Import("ItemList", Spec.fileField)>]
    type ItemList() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ItemPreviewImage", Spec.fileField)>]
    type ItemPreviewImage() =
        inherit img()
        interface Polymorph
    [<Erase; Import("ItemName", Spec.fileField)>]
    type ItemName() =
        inherit span()
        interface Polymorph
    [<Erase; Import("ItemDeleteTrigger", Spec.fileField)>]
    type ItemDeleteTrigger() =
        inherit Button()
        interface Polymorph
    [<Erase; Import("Description", Spec.fileField)>]
    type Description() =
        inherit div()
        interface Polymorph
    [<Erase; Import("ErrorMessage", Spec.fileField)>]
    type ErrorMessage() =
        inherit div()
        interface Polymorph
        member val forceMount : bool = jsNative with get,set

