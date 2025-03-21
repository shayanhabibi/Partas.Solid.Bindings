namespace Partas.Solid.Motion

open Partas.Solid.Motion.LibDom
open Fable.Core

[<AllowNullLiteral; Interface>]
type CSSStyleDeclarationWithTransform =
    inherit CSSStyleDeclaration
    abstract member x: U2<int, string> with get,set
    abstract member y: U2<int, string> with get,set
    abstract member z: U2<int, string> with get,set
    abstract member rotateX: U2<int, string> with get,set
    abstract member rotateY: U2<int, string> with get,set
    abstract member rotateZ: U2<int, string> with get,set
    abstract member scaleX: float with get,set
    abstract member scaleY: float with get,set
    abstract member scaleZ: float with get,set
    abstract member skewX: U2<string, int> with get,set
    abstract member skewY: U2<string, int> with get,set

[<Erase>]
type MotionStyle = CSSStyleDeclarationWithTransform