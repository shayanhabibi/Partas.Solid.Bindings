namespace Partas.Solid.Sonner

open Partas.Solid
open Fable.Core
open Fable.Core.JS

#nowarn 1182

[<Pojo; Global>]
type ToastIcons
    (
        ?success : HtmlElement,
        ?info : HtmlElement,
        ?warning : HtmlElement,
        ?error : HtmlElement,
        ?loading : HtmlElement,
        ?close : HtmlElement
    ) =
    member val success : HtmlElement option = jsNative with get,set
    member val info : HtmlElement option = jsNative with get,set
    member val warning : HtmlElement option = jsNative with get,set
    member val error : HtmlElement option = jsNative with get,set
    member val loading : HtmlElement option = jsNative with get,set
    member val close : HtmlElement option = jsNative with get,set

[<Pojo; Global>]
type ToastClassnames
    (
        ?toast : string,
        ?title : string,
        ?description : string,
        ?loader : string,
        ?closeButton : string,
        ?cancelButton : string,
        ?actionButton : string,
        ?success : string,
        ?error : string,
        ?info : string,
        ?warning : string,
        ?loading : string,
        ?``default`` : string,
        ?content : string,
        ?icon : string
    ) =
    member val close : string option = jsNative with get,set
    member val toast : string option = jsNative with get,set
    member val title : string option = jsNative with get,set
    member val description : string option = jsNative with get,set
    member val loader : string option = jsNative with get,set
    member val closeButton : string option = jsNative with get,set
    member val cancelButton : string option = jsNative with get,set
    member val actionButton : string option = jsNative with get,set
    member val success : string option = jsNative with get,set
    member val error : string option = jsNative with get,set
    member val info : string option = jsNative with get,set
    member val warning : string option = jsNative with get,set
    member val loading : string option = jsNative with get,set
    member val ``default`` : string option = jsNative with get,set
    member val content : string option = jsNative with get,set
    member val icon : string option = jsNative with get,set

[<Pojo; Global>]
type Action
    (
        label : HtmlElement,
        onClick : Browser.Types.MouseEvent -> unit,
        ?actionButtonStyle : obj
    ) =
    member val label : HtmlElement = jsNative with get,set
    member val onClick : Browser.Types.MouseEvent -> unit = jsNative with get,set
    member val actionButtonStyle : obj option = jsNative with get,set
[<Pojo; Global>]
type Toast
    (
        ?id : string,
        ?title : string,
        ?``type`` : Toast.Type,
        ?icon : HtmlElement,
        ?jsx : HtmlElement,
        ?richColors : bool,
        ?invert : bool,
        ?closeButton : bool,
        ?dismissible : bool,
        ?description : HtmlElement,
        ?duration : int,
        ?delete : bool,
        ?action : Action,
        ?cancel : Action,
        ?onDismiss : Toast -> unit,
        ?onAutoClose : Toast -> unit,
        // ?promise : PromiseT,
        ?cancelButtonStyle : obj,
        ?actionButtonStyle : obj,
        ?style : obj,
        ?unstyled : bool,
        ?``class`` : string,
        ?classes : ToastClassnames,
        ?descriptionClassName : string,
        ?position : Toast.Position
    ) =
    member val id : string option = jsNative with get, set
    member val action : Action option = jsNative with get, set
    member val cancel : Action option = jsNative with get, set
    member val title : string option = jsNative with get, set
    member val ``type`` : Toast.Type option = jsNative with get, set
    member this.type'
        with inline set(value: Toast.Type option) = this.``type`` <- value
        and inline get(): Toast.Type option = this.``type``
    member val icon : HtmlElement option = jsNative with get, set
    member val jsx : HtmlElement option = jsNative with get, set
    member val description : HtmlElement option = jsNative with get, set
    member val richColors : bool option = jsNative with get, set
    member val invert : bool option = jsNative with get, set
    member val closeButton : bool option = jsNative with get, set
    member val dismissible : bool option = jsNative with get, set
    member val delete : bool option = jsNative with get, set
    member val unstyled : bool option = jsNative with get, set
    member val duration : int option = jsNative with get, set
    member val onDismiss : Option<Toast -> unit> = jsNative with get, set
    member val onAutoClose : Option<Toast -> unit> = jsNative with get, set
    member val cancelButtonStyle : obj option = jsNative with get, set
    member val actionButtonStyle : obj option = jsNative with get, set
    member val style : obj option = jsNative with get, set
    member val ``class`` : string option = jsNative with get, set
    member this.class'
        with inline set(value: string option) = this.``class`` <- value
        and inline get(): string option = this.``class``
    member val descriptionClassName : string option = jsNative with get, set
    member val position : Toast.Position option = jsNative with get, set
    member val classes : ToastClassnames option = jsNative with get, set

type [<Erase>] Sonner =
    [<ImportMember(Spec.path); ParamObject(1)>]
    static member toast (
        text : string ,
        ?id : string,
        ?title : string,
        ?``type`` : Toast.Type,
        ?icon : #HtmlElement,
        ?jsx : #HtmlElement,
        ?richColors : bool,
        ?invert : bool,
        ?closeButton : bool,
        ?dismissible : bool,
        ?description : #HtmlElement,
        ?duration : int,
        ?delete : bool,
        ?action : Action,
        ?cancel : Action,
        ?onDismiss : Toast -> unit,
        ?onAutoClose : Toast -> unit,
        // ?promise : PromiseT,
        ?cancelButtonStyle : obj,
        ?actionButtonStyle : obj,
        ?style : obj,
        ?unstyled : bool,
        ?``class`` : string,
        ?classes : ToastClassnames,
        ?descriptionClassName : string,
        ?position : Toast.Position
        ) : string = unbox null
    [<Import("toast","solid-sonner"); ParamObject(1)>]
    static member toast (
        ele : #HtmlElement ,
        ?id : string,
        ?title : string,
        ?``type`` : Toast.Type,
        ?icon : #HtmlElement,
        ?jsx : #HtmlElement,
        ?richColors : bool,
        ?invert : bool,
        ?closeButton : bool,
        ?dismissible : bool,
        ?description : #HtmlElement,
        ?duration : int,
        ?delete : bool,
        ?action : Action,
        ?cancel : Action,
        ?onDismiss : Toast -> unit,
        ?onAutoClose : Toast -> unit,
        // ?promise : PromiseT,
        ?cancelButtonStyle : obj,
        ?actionButtonStyle : obj,
        ?style : obj,
        ?unstyled : bool,
        ?``class`` : string,
        ?classes : ToastClassnames,
        ?descriptionClassName : string,
        ?position : Toast.Position
        ) : string = unbox null
    [<ImportMember(Spec.path)>]
    static member toast(text: string, data: Toast): string = jsNative
    [<ImportMember(Spec.path)>]
    static member toast(element: #HtmlElement, data: Toast): string = jsNative
    [<ImportMember(Spec.path)>]
    static member toast(text: string): string = jsNative
    [<ImportMember(Spec.path)>]
    static member toast(element: #HtmlElement): string = jsNative

[<RequireQualifiedAccess>]
module [<Erase>] Sonner =
    [<Import("toast","solid-sonner")>]
    type [<Erase>] toast =
        [<Import("toast.success",Spec.path); ParamObject(1)>]
        static member success (
            text : string ,
            ?id : string,
            ?title : string,
            ?icon : #HtmlElement,
            ?jsx : #HtmlElement,
            ?richColors : bool,
            ?invert : bool,
            ?closeButton : bool,
            ?dismissible : bool,
            ?description : #HtmlElement,
            ?duration : int,
            ?delete : bool,
            ?action : Action,
            ?cancel : Action,
            ?onDismiss : Toast -> unit,
            ?onAutoClose : Toast -> unit,
            // ?promise : PromiseT,
            ?cancelButtonStyle : obj,
            ?actionButtonStyle : obj,
            ?style : obj,
            ?unstyled : bool,
            ?``class`` : string,
            ?classes : ToastClassnames,
            ?descriptionClassName : string,
            ?position : Toast.Position
             ) : string = unbox null
        static member success (text: string, data: Toast): string = unbox null
        static member success (text: string): string = unbox null
        [<Import("toast.info",Spec.path); ParamObject(1)>]
        static member info (
            text : string ,
            ?id : string,
            ?title : string,
            ?icon : #HtmlElement,
            ?jsx : #HtmlElement,
            ?richColors : bool,
            ?invert : bool,
            ?closeButton : bool,
            ?dismissible : bool,
            ?description : #HtmlElement,
            ?duration : int,
            ?delete : bool,
            ?action : Action,
            ?cancel : Action,
            ?onDismiss : Toast -> unit,
            ?onAutoClose : Toast -> unit,
            // ?promise : PromiseT,
            ?cancelButtonStyle : obj,
            ?actionButtonStyle : obj,
            ?style : obj,
            ?unstyled : bool,
            ?``class`` : string,
            ?classes : ToastClassnames,
            ?descriptionClassName : string,
            ?position : Toast.Position
             ) : string = unbox null
        static member info ( text : string , data : Toast ) : string = unbox null
        static member info ( text : string ) : string = unbox null
        [<Import("toast.warning",Spec.path); ParamObject(1)>]
        static member warning (
            text : string ,
            ?id : string,
            ?title : string,
            ?icon : #HtmlElement,
            ?jsx : #HtmlElement,
            ?richColors : bool,
            ?invert : bool,
            ?closeButton : bool,
            ?dismissible : bool,
            ?description : #HtmlElement,
            ?duration : int,
            ?delete : bool,
            ?action : Action,
            ?cancel : Action,
            ?onDismiss : Toast -> unit,
            ?onAutoClose : Toast -> unit,
            // ?promise : PromiseT,
            ?cancelButtonStyle : obj,
            ?actionButtonStyle : obj,
            ?style : obj,
            ?unstyled : bool,
            ?``class`` : string,
            ?classes : ToastClassnames,
            ?descriptionClassName : string,
            ?position : Toast.Position
             ) : string = unbox null
        static member warning ( text : string , data : Toast ) : string = unbox null
        static member warning ( text : string ) : string = unbox null
        [<Import("toast.error",Spec.path); ParamObject(1)>]
        static member error (
            text : string ,
            ?id : string,
            ?title : string,
            ?icon : #HtmlElement,
            ?jsx : #HtmlElement,
            ?richColors : bool,
            ?invert : bool,
            ?closeButton : bool,
            ?dismissible : bool,
            ?description : #HtmlElement,
            ?duration : int,
            ?delete : bool,
            ?action : Action,
            ?cancel : Action,
            ?onDismiss : Toast -> unit,
            ?onAutoClose : Toast -> unit,
            // ?promise : PromiseT,
            ?cancelButtonStyle : obj,
            ?actionButtonStyle : obj,
            ?style : obj,
            ?unstyled : bool,
            ?``class`` : string,
            ?classes : ToastClassnames,
            ?descriptionClassName : string,
            ?position : Toast.Position
            ) : string = unbox null
        static member error ( text : string , data : Toast ) : string = unbox null
        static member error ( text : string ) : string = unbox null
        [<Import("toast.message",Spec.path); ParamObject(1)>]
        static member message (
            text : string ,
            ?id : string,
            ?title : string,
            ?icon : #HtmlElement,
            ?jsx : #HtmlElement,
            ?richColors : bool,
            ?invert : bool,
            ?closeButton : bool,
            ?dismissible : bool,
            ?description : #HtmlElement,
            ?duration : int,
            ?delete : bool,
            ?action : Action,
            ?cancel : Action,
            ?onDismiss : Toast -> unit,
            ?onAutoClose : Toast -> unit,
            // ?promise : PromiseT,
            ?cancelButtonStyle : obj,
            ?actionButtonStyle : obj,
            ?style : obj,
            ?unstyled : bool,
            ?``class`` : string,
            ?classes : ToastClassnames,
            ?descriptionClassName : string,
            ?position : Toast.Position
             ) : string = unbox null
        static member message ( text : string , data : Toast ) : string = unbox null
        static member message ( text : string ) : string = unbox null
        [<Import("toast.loading",Spec.path); ParamObject(1)>]
        static member loading (
            text : string ,
            ?id : string,
            ?title : string,
            ?icon : #HtmlElement,
            ?jsx : #HtmlElement,
            ?richColors : bool,
            ?invert : bool,
            ?closeButton : bool,
            ?dismissible : bool,
            ?description : #HtmlElement,
            ?duration : int,
            ?delete : bool,
            ?action : Action,
            ?cancel : Action,
            ?onDismiss : Toast -> unit,
            ?onAutoClose : Toast -> unit,
            // ?promise : PromiseT,
            ?cancelButtonStyle : obj,
            ?actionButtonStyle : obj,
            ?style : obj,
            ?unstyled : bool,
            ?``class`` : string,
            ?classes : ToastClassnames,
            ?descriptionClassName : string,
            ?position : Toast.Position
             ) : string = unbox null
        static member loading ( text : string , data : Toast ) : string = unbox null
        static member loading ( text : string ) : string = unbox null
        static member dismiss ( id : string ) : unit = unbox null
        static member dismiss ( id : int ) : unit = unbox null
        static member dismiss () : unit = unbox null

[<Import("Toaster",Spec.path)>]
type Toaster() =
    inherit div()
    member val invert: bool = unbox null with get,set
    member val hotkey: string[] = unbox null with get,set
    member val richColors: bool = unbox null with get,set
    member val expand: bool = unbox null with get,set
    member val duration: int = unbox null with get,set
    member val gap: int = unbox null with get,set
    member val visibleToasts: int = unbox null with get,set
    member val closeButton: bool = unbox null with get,set
    member val toastOptions: Toast = unbox null with get,set
    member val offset: int = unbox null with get,set
    member val icons: ToastIcons = unbox null with get,set
    member val containerAriaLabel: string = unbox null with get,set
    member val pauseWhenPageIsHidden: bool = unbox null with get,set
    member val cn: string list -> string = unbox null with get,set
    
