namespace Partas.Solid.Motion.LibDom

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop


[<AllowNullLiteral>]
[<Interface>]
type CSSStyleDeclaration =
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/accent-color)
    /// </summary>
    abstract member accentColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/align-content)
    /// </summary>
    abstract member alignContent: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/align-items)
    /// </summary>
    abstract member alignItems: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/align-self)
    /// </summary>
    abstract member alignSelf: string with get, set
    abstract member alignmentBaseline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/all)
    /// </summary>
    abstract member all: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation)
    /// </summary>
    abstract member animation: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-composition)
    /// </summary>
    abstract member animationComposition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-delay)
    /// </summary>
    abstract member animationDelay: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-direction)
    /// </summary>
    abstract member animationDirection: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-duration)
    /// </summary>
    abstract member animationDuration: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-fill-mode)
    /// </summary>
    abstract member animationFillMode: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-iteration-count)
    /// </summary>
    abstract member animationIterationCount: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-name)
    /// </summary>
    abstract member animationName: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-play-state)
    /// </summary>
    abstract member animationPlayState: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-timing-function)
    /// </summary>
    abstract member animationTimingFunction: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/appearance)
    /// </summary>
    abstract member appearance: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/aspect-ratio)
    /// </summary>
    abstract member aspectRatio: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/backdrop-filter)
    /// </summary>
    abstract member backdropFilter: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/backface-visibility)
    /// </summary>
    abstract member backfaceVisibility: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background)
    /// </summary>
    abstract member background: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-attachment)
    /// </summary>
    abstract member backgroundAttachment: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-blend-mode)
    /// </summary>
    abstract member backgroundBlendMode: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-clip)
    /// </summary>
    abstract member backgroundClip: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-color)
    /// </summary>
    abstract member backgroundColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-image)
    /// </summary>
    abstract member backgroundImage: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-origin)
    /// </summary>
    abstract member backgroundOrigin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-position)
    /// </summary>
    abstract member backgroundPosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-position-x)
    /// </summary>
    abstract member backgroundPositionX: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-position-y)
    /// </summary>
    abstract member backgroundPositionY: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-repeat)
    /// </summary>
    abstract member backgroundRepeat: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-size)
    /// </summary>
    abstract member backgroundSize: string with get, set
    abstract member baselineShift: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/baseline-source)
    /// </summary>
    abstract member baselineSource: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/block-size)
    /// </summary>
    abstract member blockSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border)
    /// </summary>
    abstract member border: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block)
    /// </summary>
    abstract member borderBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-color)
    /// </summary>
    abstract member borderBlockColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-end)
    /// </summary>
    abstract member borderBlockEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-end-color)
    /// </summary>
    abstract member borderBlockEndColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-end-style)
    /// </summary>
    abstract member borderBlockEndStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-end-width)
    /// </summary>
    abstract member borderBlockEndWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-start)
    /// </summary>
    abstract member borderBlockStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-start-color)
    /// </summary>
    abstract member borderBlockStartColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-start-style)
    /// </summary>
    abstract member borderBlockStartStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-start-width)
    /// </summary>
    abstract member borderBlockStartWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-style)
    /// </summary>
    abstract member borderBlockStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-block-width)
    /// </summary>
    abstract member borderBlockWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom)
    /// </summary>
    abstract member borderBottom: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-color)
    /// </summary>
    abstract member borderBottomColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-left-radius)
    /// </summary>
    abstract member borderBottomLeftRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-right-radius)
    /// </summary>
    abstract member borderBottomRightRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-style)
    /// </summary>
    abstract member borderBottomStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-width)
    /// </summary>
    abstract member borderBottomWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-collapse)
    /// </summary>
    abstract member borderCollapse: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-color)
    /// </summary>
    abstract member borderColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-end-end-radius)
    /// </summary>
    abstract member borderEndEndRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-end-start-radius)
    /// </summary>
    abstract member borderEndStartRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-image)
    /// </summary>
    abstract member borderImage: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-image-outset)
    /// </summary>
    abstract member borderImageOutset: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-image-repeat)
    /// </summary>
    abstract member borderImageRepeat: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-image-slice)
    /// </summary>
    abstract member borderImageSlice: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-image-source)
    /// </summary>
    abstract member borderImageSource: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-image-width)
    /// </summary>
    abstract member borderImageWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline)
    /// </summary>
    abstract member borderInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-color)
    /// </summary>
    abstract member borderInlineColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-end)
    /// </summary>
    abstract member borderInlineEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-end-color)
    /// </summary>
    abstract member borderInlineEndColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-end-style)
    /// </summary>
    abstract member borderInlineEndStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-end-width)
    /// </summary>
    abstract member borderInlineEndWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-start)
    /// </summary>
    abstract member borderInlineStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-start-color)
    /// </summary>
    abstract member borderInlineStartColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-start-style)
    /// </summary>
    abstract member borderInlineStartStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-start-width)
    /// </summary>
    abstract member borderInlineStartWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-style)
    /// </summary>
    abstract member borderInlineStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-inline-width)
    /// </summary>
    abstract member borderInlineWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-left)
    /// </summary>
    abstract member borderLeft: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-left-color)
    /// </summary>
    abstract member borderLeftColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-left-style)
    /// </summary>
    abstract member borderLeftStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-left-width)
    /// </summary>
    abstract member borderLeftWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-radius)
    /// </summary>
    abstract member borderRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-right)
    /// </summary>
    abstract member borderRight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-right-color)
    /// </summary>
    abstract member borderRightColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-right-style)
    /// </summary>
    abstract member borderRightStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-right-width)
    /// </summary>
    abstract member borderRightWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-spacing)
    /// </summary>
    abstract member borderSpacing: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-start-end-radius)
    /// </summary>
    abstract member borderStartEndRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-start-start-radius)
    /// </summary>
    abstract member borderStartStartRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-style)
    /// </summary>
    abstract member borderStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top)
    /// </summary>
    abstract member borderTop: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-color)
    /// </summary>
    abstract member borderTopColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-left-radius)
    /// </summary>
    abstract member borderTopLeftRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-right-radius)
    /// </summary>
    abstract member borderTopRightRadius: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-style)
    /// </summary>
    abstract member borderTopStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-width)
    /// </summary>
    abstract member borderTopWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-width)
    /// </summary>
    abstract member borderWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/bottom)
    /// </summary>
    abstract member bottom: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-shadow)
    /// </summary>
    abstract member boxShadow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-sizing)
    /// </summary>
    abstract member boxSizing: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/break-after)
    /// </summary>
    abstract member breakAfter: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/break-before)
    /// </summary>
    abstract member breakBefore: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/break-inside)
    /// </summary>
    abstract member breakInside: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/caption-side)
    /// </summary>
    abstract member captionSide: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/caret-color)
    /// </summary>
    abstract member caretColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/clear)
    /// </summary>
    abstract member clear: string with get, set
    [<System.Obsolete("[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/clip)")>]
    abstract member clip: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/clip-path)
    /// </summary>
    abstract member clipPath: string with get, set
    abstract member clipRule: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/color)
    /// </summary>
    abstract member color: string with get, set
    abstract member colorInterpolation: string with get, set
    abstract member colorInterpolationFilters: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/color-scheme)
    /// </summary>
    abstract member colorScheme: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-count)
    /// </summary>
    abstract member columnCount: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-fill)
    /// </summary>
    abstract member columnFill: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-gap)
    /// </summary>
    abstract member columnGap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-rule)
    /// </summary>
    abstract member columnRule: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-rule-color)
    /// </summary>
    abstract member columnRuleColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-rule-style)
    /// </summary>
    abstract member columnRuleStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-rule-width)
    /// </summary>
    abstract member columnRuleWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-span)
    /// </summary>
    abstract member columnSpan: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/column-width)
    /// </summary>
    abstract member columnWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/columns)
    /// </summary>
    abstract member columns: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/contain)
    /// </summary>
    abstract member contain: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/contain-intrinsic-contain-intrinsic-block-size)
    /// </summary>
    abstract member containIntrinsicBlockSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/contain-intrinsic-height)
    /// </summary>
    abstract member containIntrinsicHeight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/contain-intrinsic-contain-intrinsic-inline-size)
    /// </summary>
    abstract member containIntrinsicInlineSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/contain-intrinsic-size)
    /// </summary>
    abstract member containIntrinsicSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/contain-intrinsic-width)
    /// </summary>
    abstract member containIntrinsicWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/container)
    /// </summary>
    abstract member container: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/container-name)
    /// </summary>
    abstract member containerName: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/container-type)
    /// </summary>
    abstract member containerType: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/content)
    /// </summary>
    abstract member content: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/counter-increment)
    /// </summary>
    abstract member counterIncrement: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/counter-reset)
    /// </summary>
    abstract member counterReset: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/counter-set)
    /// </summary>
    abstract member counterSet: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/cssFloat)
    /// </summary>
    abstract member cssFloat: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/cssText)
    /// </summary>
    abstract member cssText: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/cursor)
    /// </summary>
    abstract member cursor: string with get, set
    abstract member cx: string with get, set
    abstract member cy: string with get, set
    abstract member d: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/direction)
    /// </summary>
    abstract member direction: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/display)
    /// </summary>
    abstract member display: string with get, set
    abstract member dominantBaseline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/empty-cells)
    /// </summary>
    abstract member emptyCells: string with get, set
    abstract member fill: string with get, set
    abstract member fillOpacity: string with get, set
    abstract member fillRule: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/filter)
    /// </summary>
    abstract member filter: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex)
    /// </summary>
    abstract member flex: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-basis)
    /// </summary>
    abstract member flexBasis: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-direction)
    /// </summary>
    abstract member flexDirection: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-flow)
    /// </summary>
    abstract member flexFlow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-grow)
    /// </summary>
    abstract member flexGrow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-shrink)
    /// </summary>
    abstract member flexShrink: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-wrap)
    /// </summary>
    abstract member flexWrap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/float)
    /// </summary>
    abstract member float: string with get, set
    abstract member floodColor: string with get, set
    abstract member floodOpacity: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font)
    /// </summary>
    abstract member font: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-family)
    /// </summary>
    abstract member fontFamily: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-feature-settings)
    /// </summary>
    abstract member fontFeatureSettings: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-kerning)
    /// </summary>
    abstract member fontKerning: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-optical-sizing)
    /// </summary>
    abstract member fontOpticalSizing: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-palette)
    /// </summary>
    abstract member fontPalette: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-size)
    /// </summary>
    abstract member fontSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-size-adjust)
    /// </summary>
    abstract member fontSizeAdjust: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-stretch)
    /// </summary>
    abstract member fontStretch: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-style)
    /// </summary>
    abstract member fontStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-synthesis)
    /// </summary>
    abstract member fontSynthesis: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-synthesis-small-caps)
    /// </summary>
    abstract member fontSynthesisSmallCaps: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-synthesis-style)
    /// </summary>
    abstract member fontSynthesisStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-synthesis-weight)
    /// </summary>
    abstract member fontSynthesisWeight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant)
    /// </summary>
    abstract member fontVariant: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant-alternates)
    /// </summary>
    abstract member fontVariantAlternates: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant-caps)
    /// </summary>
    abstract member fontVariantCaps: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant-east-asian)
    /// </summary>
    abstract member fontVariantEastAsian: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant-ligatures)
    /// </summary>
    abstract member fontVariantLigatures: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant-numeric)
    /// </summary>
    abstract member fontVariantNumeric: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variant-position)
    /// </summary>
    abstract member fontVariantPosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-variation-settings)
    /// </summary>
    abstract member fontVariationSettings: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/font-weight)
    /// </summary>
    abstract member fontWeight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/forced-color-adjust)
    /// </summary>
    abstract member forcedColorAdjust: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/gap)
    /// </summary>
    abstract member gap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid)
    /// </summary>
    abstract member grid: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-area)
    /// </summary>
    abstract member gridArea: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-auto-columns)
    /// </summary>
    abstract member gridAutoColumns: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-auto-flow)
    /// </summary>
    abstract member gridAutoFlow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-auto-rows)
    /// </summary>
    abstract member gridAutoRows: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-column)
    /// </summary>
    abstract member gridColumn: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-column-end)
    /// </summary>
    abstract member gridColumnEnd: string with get, set
    [<System.Obsolete("This is a legacy alias of `columnGap`.")>]
    abstract member gridColumnGap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-column-start)
    /// </summary>
    abstract member gridColumnStart: string with get, set
    [<System.Obsolete("This is a legacy alias of `gap`.")>]
    abstract member gridGap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-row)
    /// </summary>
    abstract member gridRow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-row-end)
    /// </summary>
    abstract member gridRowEnd: string with get, set
    [<System.Obsolete("This is a legacy alias of `rowGap`.")>]
    abstract member gridRowGap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-row-start)
    /// </summary>
    abstract member gridRowStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-template)
    /// </summary>
    abstract member gridTemplate: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-template-areas)
    /// </summary>
    abstract member gridTemplateAreas: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-template-columns)
    /// </summary>
    abstract member gridTemplateColumns: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/grid-template-rows)
    /// </summary>
    abstract member gridTemplateRows: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/height)
    /// </summary>
    abstract member height: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/hyphenate-character)
    /// </summary>
    abstract member hyphenateCharacter: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/hyphens)
    /// </summary>
    abstract member hyphens: string with get, set
    [<System.Obsolete("[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/image-orientation)")>]
    abstract member imageOrientation: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/image-rendering)
    /// </summary>
    abstract member imageRendering: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inline-size)
    /// </summary>
    abstract member inlineSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset)
    /// </summary>
    abstract member inset: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset-block)
    /// </summary>
    abstract member insetBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset-block-end)
    /// </summary>
    abstract member insetBlockEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset-block-start)
    /// </summary>
    abstract member insetBlockStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset-inline)
    /// </summary>
    abstract member insetInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset-inline-end)
    /// </summary>
    abstract member insetInlineEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/inset-inline-start)
    /// </summary>
    abstract member insetInlineStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/isolation)
    /// </summary>
    abstract member isolation: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/justify-content)
    /// </summary>
    abstract member justifyContent: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/justify-items)
    /// </summary>
    abstract member justifyItems: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/justify-self)
    /// </summary>
    abstract member justifySelf: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/left)
    /// </summary>
    abstract member left: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/length)
    /// </summary>
    abstract member length: float with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/letter-spacing)
    /// </summary>
    abstract member letterSpacing: string with get, set
    abstract member lightingColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/line-break)
    /// </summary>
    abstract member lineBreak: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/line-height)
    /// </summary>
    abstract member lineHeight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/list-style)
    /// </summary>
    abstract member listStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/list-style-image)
    /// </summary>
    abstract member listStyleImage: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/list-style-position)
    /// </summary>
    abstract member listStylePosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/list-style-type)
    /// </summary>
    abstract member listStyleType: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin)
    /// </summary>
    abstract member margin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-block)
    /// </summary>
    abstract member marginBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-block-end)
    /// </summary>
    abstract member marginBlockEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-block-start)
    /// </summary>
    abstract member marginBlockStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-bottom)
    /// </summary>
    abstract member marginBottom: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-inline)
    /// </summary>
    abstract member marginInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-inline-end)
    /// </summary>
    abstract member marginInlineEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-inline-start)
    /// </summary>
    abstract member marginInlineStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-left)
    /// </summary>
    abstract member marginLeft: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-right)
    /// </summary>
    abstract member marginRight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/margin-top)
    /// </summary>
    abstract member marginTop: string with get, set
    abstract member marker: string with get, set
    abstract member markerEnd: string with get, set
    abstract member markerMid: string with get, set
    abstract member markerStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask)
    /// </summary>
    abstract member mask: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-clip)
    /// </summary>
    abstract member maskClip: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-composite)
    /// </summary>
    abstract member maskComposite: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-image)
    /// </summary>
    abstract member maskImage: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-mode)
    /// </summary>
    abstract member maskMode: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-origin)
    /// </summary>
    abstract member maskOrigin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-position)
    /// </summary>
    abstract member maskPosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-repeat)
    /// </summary>
    abstract member maskRepeat: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-size)
    /// </summary>
    abstract member maskSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-type)
    /// </summary>
    abstract member maskType: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/math-depth)
    /// </summary>
    abstract member mathDepth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/math-style)
    /// </summary>
    abstract member mathStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/max-block-size)
    /// </summary>
    abstract member maxBlockSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/max-height)
    /// </summary>
    abstract member maxHeight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/max-inline-size)
    /// </summary>
    abstract member maxInlineSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/max-width)
    /// </summary>
    abstract member maxWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/min-block-size)
    /// </summary>
    abstract member minBlockSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/min-height)
    /// </summary>
    abstract member minHeight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/min-inline-size)
    /// </summary>
    abstract member minInlineSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/min-width)
    /// </summary>
    abstract member minWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mix-blend-mode)
    /// </summary>
    abstract member mixBlendMode: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/object-fit)
    /// </summary>
    abstract member objectFit: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/object-position)
    /// </summary>
    abstract member objectPosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/offset)
    /// </summary>
    abstract member offset: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/offset-anchor)
    /// </summary>
    abstract member offsetAnchor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/offset-distance)
    /// </summary>
    abstract member offsetDistance: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/offset-path)
    /// </summary>
    abstract member offsetPath: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/offset-position)
    /// </summary>
    abstract member offsetPosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/offset-rotate)
    /// </summary>
    abstract member offsetRotate: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/opacity)
    /// </summary>
    abstract member opacity: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/order)
    /// </summary>
    abstract member order: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/orphans)
    /// </summary>
    abstract member orphans: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/outline)
    /// </summary>
    abstract member outline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/outline-color)
    /// </summary>
    abstract member outlineColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/outline-offset)
    /// </summary>
    abstract member outlineOffset: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/outline-style)
    /// </summary>
    abstract member outlineStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/outline-width)
    /// </summary>
    abstract member outlineWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overflow)
    /// </summary>
    abstract member overflow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overflow-anchor)
    /// </summary>
    abstract member overflowAnchor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overflow-clip-margin)
    /// </summary>
    abstract member overflowClipMargin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overflow-wrap)
    /// </summary>
    abstract member overflowWrap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overflow-x)
    /// </summary>
    abstract member overflowX: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overflow-y)
    /// </summary>
    abstract member overflowY: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overscroll-behavior)
    /// </summary>
    abstract member overscrollBehavior: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overscroll-behavior-block)
    /// </summary>
    abstract member overscrollBehaviorBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overscroll-behavior-inline)
    /// </summary>
    abstract member overscrollBehaviorInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overscroll-behavior-x)
    /// </summary>
    abstract member overscrollBehaviorX: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/overscroll-behavior-y)
    /// </summary>
    abstract member overscrollBehaviorY: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding)
    /// </summary>
    abstract member padding: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-block)
    /// </summary>
    abstract member paddingBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-block-end)
    /// </summary>
    abstract member paddingBlockEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-block-start)
    /// </summary>
    abstract member paddingBlockStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-bottom)
    /// </summary>
    abstract member paddingBottom: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-inline)
    /// </summary>
    abstract member paddingInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-inline-end)
    /// </summary>
    abstract member paddingInlineEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-inline-start)
    /// </summary>
    abstract member paddingInlineStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-left)
    /// </summary>
    abstract member paddingLeft: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-right)
    /// </summary>
    abstract member paddingRight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/padding-top)
    /// </summary>
    abstract member paddingTop: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/page)
    /// </summary>
    abstract member page: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/page-break-after)
    /// </summary>
    abstract member pageBreakAfter: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/page-break-before)
    /// </summary>
    abstract member pageBreakBefore: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/page-break-inside)
    /// </summary>
    abstract member pageBreakInside: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/paint-order)
    /// </summary>
    abstract member paintOrder: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/parentRule)
    /// </summary>
    // abstract member parentRule: CSSRule option with get
    abstract member parentRule: obj option with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/perspective)
    /// </summary>
    abstract member perspective: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/perspective-origin)
    /// </summary>
    abstract member perspectiveOrigin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/place-content)
    /// </summary>
    abstract member placeContent: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/place-items)
    /// </summary>
    abstract member placeItems: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/place-self)
    /// </summary>
    abstract member placeSelf: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/pointer-events)
    /// </summary>
    abstract member pointerEvents: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/position)
    /// </summary>
    abstract member position: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/print-color-adjust)
    /// </summary>
    abstract member printColorAdjust: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/quotes)
    /// </summary>
    abstract member quotes: string with get, set
    abstract member r: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/resize)
    /// </summary>
    abstract member resize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/right)
    /// </summary>
    abstract member right: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/rotate)
    /// </summary>
    abstract member rotate: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/row-gap)
    /// </summary>
    abstract member rowGap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/ruby-position)
    /// </summary>
    abstract member rubyPosition: string with get, set
    abstract member rx: string with get, set
    abstract member ry: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scale)
    /// </summary>
    abstract member scale: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-behavior)
    /// </summary>
    abstract member scrollBehavior: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin)
    /// </summary>
    abstract member scrollMargin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-block)
    /// </summary>
    abstract member scrollMarginBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-block-end)
    /// </summary>
    abstract member scrollMarginBlockEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-block-start)
    /// </summary>
    abstract member scrollMarginBlockStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-bottom)
    /// </summary>
    abstract member scrollMarginBottom: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-inline)
    /// </summary>
    abstract member scrollMarginInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-inline-end)
    /// </summary>
    abstract member scrollMarginInlineEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-inline-start)
    /// </summary>
    abstract member scrollMarginInlineStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-left)
    /// </summary>
    abstract member scrollMarginLeft: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-right)
    /// </summary>
    abstract member scrollMarginRight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-margin-top)
    /// </summary>
    abstract member scrollMarginTop: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding)
    /// </summary>
    abstract member scrollPadding: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-block)
    /// </summary>
    abstract member scrollPaddingBlock: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-block-end)
    /// </summary>
    abstract member scrollPaddingBlockEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-block-start)
    /// </summary>
    abstract member scrollPaddingBlockStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-bottom)
    /// </summary>
    abstract member scrollPaddingBottom: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-inline)
    /// </summary>
    abstract member scrollPaddingInline: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-inline-end)
    /// </summary>
    abstract member scrollPaddingInlineEnd: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-inline-start)
    /// </summary>
    abstract member scrollPaddingInlineStart: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-left)
    /// </summary>
    abstract member scrollPaddingLeft: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-right)
    /// </summary>
    abstract member scrollPaddingRight: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-padding-top)
    /// </summary>
    abstract member scrollPaddingTop: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-snap-align)
    /// </summary>
    abstract member scrollSnapAlign: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-snap-stop)
    /// </summary>
    abstract member scrollSnapStop: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scroll-snap-type)
    /// </summary>
    abstract member scrollSnapType: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scrollbar-color)
    /// </summary>
    abstract member scrollbarColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scrollbar-gutter)
    /// </summary>
    abstract member scrollbarGutter: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/scrollbar-width)
    /// </summary>
    abstract member scrollbarWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/shape-image-threshold)
    /// </summary>
    abstract member shapeImageThreshold: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/shape-margin)
    /// </summary>
    abstract member shapeMargin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/shape-outside)
    /// </summary>
    abstract member shapeOutside: string with get, set
    abstract member shapeRendering: string with get, set
    abstract member stopColor: string with get, set
    abstract member stopOpacity: string with get, set
    abstract member stroke: string with get, set
    abstract member strokeDasharray: string with get, set
    abstract member strokeDashoffset: string with get, set
    abstract member strokeLinecap: string with get, set
    abstract member strokeLinejoin: string with get, set
    abstract member strokeMiterlimit: string with get, set
    abstract member strokeOpacity: string with get, set
    abstract member strokeWidth: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/tab-size)
    /// </summary>
    abstract member tabSize: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/table-layout)
    /// </summary>
    abstract member tableLayout: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-align)
    /// </summary>
    abstract member textAlign: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-align-last)
    /// </summary>
    abstract member textAlignLast: string with get, set
    abstract member textAnchor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-combine-upright)
    /// </summary>
    abstract member textCombineUpright: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-decoration)
    /// </summary>
    abstract member textDecoration: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-decoration-color)
    /// </summary>
    abstract member textDecorationColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-decoration-line)
    /// </summary>
    abstract member textDecorationLine: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-decoration-skip-ink)
    /// </summary>
    abstract member textDecorationSkipInk: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-decoration-style)
    /// </summary>
    abstract member textDecorationStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-decoration-thickness)
    /// </summary>
    abstract member textDecorationThickness: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-emphasis)
    /// </summary>
    abstract member textEmphasis: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-emphasis-color)
    /// </summary>
    abstract member textEmphasisColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-emphasis-position)
    /// </summary>
    abstract member textEmphasisPosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-emphasis-style)
    /// </summary>
    abstract member textEmphasisStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-indent)
    /// </summary>
    abstract member textIndent: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-orientation)
    /// </summary>
    abstract member textOrientation: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-overflow)
    /// </summary>
    abstract member textOverflow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-rendering)
    /// </summary>
    abstract member textRendering: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-shadow)
    /// </summary>
    abstract member textShadow: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-transform)
    /// </summary>
    abstract member textTransform: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-underline-offset)
    /// </summary>
    abstract member textUnderlineOffset: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-underline-position)
    /// </summary>
    abstract member textUnderlinePosition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-wrap)
    /// </summary>
    abstract member textWrap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/top)
    /// </summary>
    abstract member top: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/touch-action)
    /// </summary>
    abstract member touchAction: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform)
    /// </summary>
    abstract member transform: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform-box)
    /// </summary>
    abstract member transformBox: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform-origin)
    /// </summary>
    abstract member transformOrigin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform-style)
    /// </summary>
    abstract member transformStyle: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition)
    /// </summary>
    abstract member transition: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-delay)
    /// </summary>
    abstract member transitionDelay: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-duration)
    /// </summary>
    abstract member transitionDuration: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-property)
    /// </summary>
    abstract member transitionProperty: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-timing-function)
    /// </summary>
    abstract member transitionTimingFunction: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/translate)
    /// </summary>
    abstract member translate: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/unicode-bidi)
    /// </summary>
    abstract member unicodeBidi: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/user-select)
    /// </summary>
    abstract member userSelect: string with get, set
    abstract member vectorEffect: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/vertical-align)
    /// </summary>
    abstract member verticalAlign: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/visibility)
    /// </summary>
    abstract member visibility: string with get, set
    [<System.Obsolete("""This is a legacy alias of `alignContent`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/align-content)""")>]
    abstract member webkitAlignContent: string with get, set
    [<System.Obsolete("""This is a legacy alias of `alignItems`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/align-items)""")>]
    abstract member webkitAlignItems: string with get, set
    [<System.Obsolete("""This is a legacy alias of `alignSelf`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/align-self)""")>]
    abstract member webkitAlignSelf: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animation`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation)""")>]
    abstract member webkitAnimation: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationDelay`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-delay)""")>]
    abstract member webkitAnimationDelay: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationDirection`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-direction)""")>]
    abstract member webkitAnimationDirection: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationDuration`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-duration)""")>]
    abstract member webkitAnimationDuration: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationFillMode`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-fill-mode)""")>]
    abstract member webkitAnimationFillMode: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationIterationCount`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-iteration-count)""")>]
    abstract member webkitAnimationIterationCount: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationName`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-name)""")>]
    abstract member webkitAnimationName: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationPlayState`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-play-state)""")>]
    abstract member webkitAnimationPlayState: string with get, set
    [<System.Obsolete("""This is a legacy alias of `animationTimingFunction`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/animation-timing-function)""")>]
    abstract member webkitAnimationTimingFunction: string with get, set
    [<System.Obsolete("""This is a legacy alias of `appearance`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/appearance)""")>]
    abstract member webkitAppearance: string with get, set
    [<System.Obsolete("""This is a legacy alias of `backfaceVisibility`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/backface-visibility)""")>]
    abstract member webkitBackfaceVisibility: string with get, set
    [<System.Obsolete("""This is a legacy alias of `backgroundClip`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-clip)""")>]
    abstract member webkitBackgroundClip: string with get, set
    [<System.Obsolete("""This is a legacy alias of `backgroundOrigin`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-origin)""")>]
    abstract member webkitBackgroundOrigin: string with get, set
    [<System.Obsolete("""This is a legacy alias of `backgroundSize`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/background-size)""")>]
    abstract member webkitBackgroundSize: string with get, set
    [<System.Obsolete("""This is a legacy alias of `borderBottomLeftRadius`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-left-radius)""")>]
    abstract member webkitBorderBottomLeftRadius: string with get, set
    [<System.Obsolete("""This is a legacy alias of `borderBottomRightRadius`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-bottom-right-radius)""")>]
    abstract member webkitBorderBottomRightRadius: string with get, set
    [<System.Obsolete("""This is a legacy alias of `borderRadius`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-radius)""")>]
    abstract member webkitBorderRadius: string with get, set
    [<System.Obsolete("""This is a legacy alias of `borderTopLeftRadius`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-left-radius)""")>]
    abstract member webkitBorderTopLeftRadius: string with get, set
    [<System.Obsolete("""This is a legacy alias of `borderTopRightRadius`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/border-top-right-radius)""")>]
    abstract member webkitBorderTopRightRadius: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxAlign`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-align)""")>]
    abstract member webkitBoxAlign: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxFlex`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-flex)""")>]
    abstract member webkitBoxFlex: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxOrdinalGroup`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-ordinal-group)""")>]
    abstract member webkitBoxOrdinalGroup: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxOrient`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-orient)""")>]
    abstract member webkitBoxOrient: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxPack`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-pack)""")>]
    abstract member webkitBoxPack: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxShadow`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-shadow)""")>]
    abstract member webkitBoxShadow: string with get, set
    [<System.Obsolete("""This is a legacy alias of `boxSizing`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/box-sizing)""")>]
    abstract member webkitBoxSizing: string with get, set
    [<System.Obsolete("""This is a legacy alias of `filter`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/filter)""")>]
    abstract member webkitFilter: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flex`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex)""")>]
    abstract member webkitFlex: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flexBasis`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-basis)""")>]
    abstract member webkitFlexBasis: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flexDirection`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-direction)""")>]
    abstract member webkitFlexDirection: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flexFlow`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-flow)""")>]
    abstract member webkitFlexFlow: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flexGrow`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-grow)""")>]
    abstract member webkitFlexGrow: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flexShrink`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-shrink)""")>]
    abstract member webkitFlexShrink: string with get, set
    [<System.Obsolete("""This is a legacy alias of `flexWrap`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/flex-wrap)""")>]
    abstract member webkitFlexWrap: string with get, set
    [<System.Obsolete("""This is a legacy alias of `justifyContent`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/justify-content)""")>]
    abstract member webkitJustifyContent: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/-webkit-line-clamp)
    /// </summary>
    abstract member webkitLineClamp: string with get, set
    [<System.Obsolete("""This is a legacy alias of `mask`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask)""")>]
    abstract member webkitMask: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskBorder`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-border)""")>]
    abstract member webkitMaskBoxImage: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskBorderOutset`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-border-outset)""")>]
    abstract member webkitMaskBoxImageOutset: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskBorderRepeat`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-border-repeat)""")>]
    abstract member webkitMaskBoxImageRepeat: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskBorderSlice`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-border-slice)""")>]
    abstract member webkitMaskBoxImageSlice: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskBorderSource`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-border-source)""")>]
    abstract member webkitMaskBoxImageSource: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskBorderWidth`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-border-width)""")>]
    abstract member webkitMaskBoxImageWidth: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskClip`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-clip)""")>]
    abstract member webkitMaskClip: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskComposite`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-composite)""")>]
    abstract member webkitMaskComposite: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskImage`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-image)""")>]
    abstract member webkitMaskImage: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskOrigin`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-origin)""")>]
    abstract member webkitMaskOrigin: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskPosition`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-position)""")>]
    abstract member webkitMaskPosition: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskRepeat`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-repeat)""")>]
    abstract member webkitMaskRepeat: string with get, set
    [<System.Obsolete("""This is a legacy alias of `maskSize`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/mask-size)""")>]
    abstract member webkitMaskSize: string with get, set
    [<System.Obsolete("""This is a legacy alias of `order`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/order)""")>]
    abstract member webkitOrder: string with get, set
    [<System.Obsolete("""This is a legacy alias of `perspective`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/perspective)""")>]
    abstract member webkitPerspective: string with get, set
    [<System.Obsolete("""This is a legacy alias of `perspectiveOrigin`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/perspective-origin)""")>]
    abstract member webkitPerspectiveOrigin: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/-webkit-text-fill-color)
    /// </summary>
    abstract member webkitTextFillColor: string with get, set
    [<System.Obsolete("""This is a legacy alias of `textSizeAdjust`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/text-size-adjust)""")>]
    abstract member webkitTextSizeAdjust: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/-webkit-text-stroke)
    /// </summary>
    abstract member webkitTextStroke: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/-webkit-text-stroke-color)
    /// </summary>
    abstract member webkitTextStrokeColor: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/-webkit-text-stroke-width)
    /// </summary>
    abstract member webkitTextStrokeWidth: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transform`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform)""")>]
    abstract member webkitTransform: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transformOrigin`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform-origin)""")>]
    abstract member webkitTransformOrigin: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transformStyle`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transform-style)""")>]
    abstract member webkitTransformStyle: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transition`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition)""")>]
    abstract member webkitTransition: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transitionDelay`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-delay)""")>]
    abstract member webkitTransitionDelay: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transitionDuration`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-duration)""")>]
    abstract member webkitTransitionDuration: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transitionProperty`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-property)""")>]
    abstract member webkitTransitionProperty: string with get, set
    [<System.Obsolete("""This is a legacy alias of `transitionTimingFunction`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/transition-timing-function)""")>]
    abstract member webkitTransitionTimingFunction: string with get, set
    [<System.Obsolete("""This is a legacy alias of `userSelect`.

[MDN Reference](https://developer.mozilla.org/docs/Web/CSS/user-select)""")>]
    abstract member webkitUserSelect: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/white-space)
    /// </summary>
    abstract member whiteSpace: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/widows)
    /// </summary>
    abstract member widows: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/width)
    /// </summary>
    abstract member width: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/will-change)
    /// </summary>
    abstract member willChange: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/word-break)
    /// </summary>
    abstract member wordBreak: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/word-spacing)
    /// </summary>
    abstract member wordSpacing: string with get, set
    [<System.Obsolete>]
    abstract member wordWrap: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/writing-mode)
    /// </summary>
    abstract member writingMode: string with get, set
    abstract member x: string with get, set
    abstract member y: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/CSS/z-index)
    /// </summary>
    abstract member zIndex: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/getPropertyPriority)
    /// </summary>
    abstract member getPropertyPriority: property: string -> string
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/getPropertyValue)
    /// </summary>
    abstract member getPropertyValue: property: string -> string
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/item)
    /// </summary>
    abstract member item: index: float -> string
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/removeProperty)
    /// </summary>
    abstract member removeProperty: property: string -> string
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CSSStyleDeclaration/setProperty)
    /// </summary>
    abstract member setProperty: property: string * value: string option * ?priority: string -> unit
    [<EmitIndexer>]
    abstract member Item: index: float -> string with get, set

[<JS.Pojo>]
type CssStyleDeclaration(
        ?accentColor: string,
        ?alignContent: string,
        ?alignItems: string,
        ?alignSelf: string,
        ?alignmentBaseline: string,
        ?all: string,
        ?animation: string,
        ?animationComposition: string,
        ?animationDelay: string,
        ?animationDirection: string,
        ?animationDuration: string,
        ?animationFillMode: string,
        ?animationIterationCount: string,
        ?animationName: string,
        ?animationPlayState: string,
        ?animationTimingFunction: string,
        ?appearance: string,
        ?aspectRatio: string,
        ?backdropFilter: string,
        ?backfaceVisibility: string,
        ?background: string,
        ?backgroundAttachment: string,
        ?backgroundBlendMode: string,
        ?backgroundClip: string,
        ?backgroundColor: string,
        ?backgroundImage: string,
        ?backgroundOrigin: string,
        ?backgroundPosition: string,
        ?backgroundPositionX: string,
        ?backgroundPositionY: string,
        ?backgroundRepeat: string,
        ?backgroundSize: string,
        ?baselineShift: string,
        ?baselineSource: string,
        ?blockSize: string,
        ?border: string,
        ?borderBlock: string,
        ?borderBlockColor: string,
        ?borderBlockEnd: string,
        ?borderBlockEndColor: string,
        ?borderBlockEndStyle: string,
        ?borderBlockEndWidth: string,
        ?borderBlockStart: string,
        ?borderBlockStartColor: string,
        ?borderBlockStartStyle: string,
        ?borderBlockStartWidth: string,
        ?borderBlockStyle: string,
        ?borderBlockWidth: string,
        ?borderBottom: string,
        ?borderBottomColor: string,
        ?borderBottomLeftRadius: string,
        ?borderBottomRightRadius: string,
        ?borderBottomStyle: string,
        ?borderBottomWidth: string,
        ?borderCollapse: string,
        ?borderColor: string,
        ?borderEndEndRadius: string,
        ?borderEndStartRadius: string,
        ?borderImage: string,
        ?borderImageOutset: string,
        ?borderImageRepeat: string,
        ?borderImageSlice: string,
        ?borderImageSource: string,
        ?borderImageWidth: string,
        ?borderInline: string,
        ?borderInlineColor: string,
        ?borderInlineEnd: string,
        ?borderInlineEndColor: string,
        ?borderInlineEndStyle: string,
        ?borderInlineEndWidth: string,
        ?borderInlineStart: string,
        ?borderInlineStartColor: string,
        ?borderInlineStartStyle: string,
        ?borderInlineStartWidth: string,
        ?borderInlineStyle: string,
        ?borderInlineWidth: string,
        ?borderLeft: string,
        ?borderLeftColor: string,
        ?borderLeftStyle: string,
        ?borderLeftWidth: string,
        ?borderRadius: string,
        ?borderRight: string,
        ?borderRightColor: string,
        ?borderRightStyle: string,
        ?borderRightWidth: string,
        ?borderSpacing: string,
        ?borderStartEndRadius: string,
        ?borderStartStartRadius: string,
        ?borderStyle: string,
        ?borderTop: string,
        ?borderTopColor: string,
        ?borderTopLeftRadius: string,
        ?borderTopRightRadius: string,
        ?borderTopStyle: string,
        ?borderTopWidth: string,
        ?borderWidth: string,
        ?bottom: string,
        ?boxShadow: string,
        ?boxSizing: string,
        ?breakAfter: string,
        ?breakBefore: string,
        ?breakInside: string,
        ?captionSide: string,
        ?caretColor: string,
        ?clear: string,
        ?clip: string,
        ?clipPath: string,
        ?clipRule: string,
        ?color: string,
        ?colorInterpolation: string,
        ?colorInterpolationFilters: string,
        ?colorScheme: string,
        ?columnCount: string,
        ?columnFill: string,
        ?columnGap: string,
        ?columnRule: string,
        ?columnRuleColor: string,
        ?columnRuleStyle: string,
        ?columnRuleWidth: string,
        ?columnSpan: string,
        ?columnWidth: string,
        ?columns: string,
        ?contain: string,
        ?containIntrinsicBlockSize: string,
        ?containIntrinsicHeight: string,
        ?containIntrinsicInlineSize: string,
        ?containIntrinsicSize: string,
        ?containIntrinsicWidth: string,
        ?container: string,
        ?containerName: string,
        ?containerType: string,
        ?content: string,
        ?counterIncrement: string,
        ?counterReset: string,
        ?counterSet: string,
        ?cssFloat: string,
        ?cssText: string,
        ?cursor: string,
        ?cx: string,
        ?cy: string,
        ?d: string,
        ?direction: string,
        ?display: string,
        ?dominantBaseline: string,
        ?emptyCells: string,
        ?fill: string,
        ?fillOpacity: string,
        ?fillRule: string,
        ?filter: string,
        ?flex: string,
        ?flexBasis: string,
        ?flexDirection: string,
        ?flexFlow: string,
        ?flexGrow: string,
        ?flexShrink: string,
        ?flexWrap: string,
        ?float: string,
        ?floodColor: string,
        ?floodOpacity: string,
        ?font: string,
        ?fontFamily: string,
        ?fontFeatureSettings: string,
        ?fontKerning: string,
        ?fontOpticalSizing: string,
        ?fontPalette: string,
        ?fontSize: string,
        ?fontSizeAdjust: string,
        ?fontStretch: string,
        ?fontStyle: string,
        ?fontSynthesis: string,
        ?fontSynthesisSmallCaps: string,
        ?fontSynthesisStyle: string,
        ?fontSynthesisWeight: string,
        ?fontVariant: string,
        ?fontVariantAlternates: string,
        ?fontVariantCaps: string,
        ?fontVariantEastAsian: string,
        ?fontVariantLigatures: string,
        ?fontVariantNumeric: string,
        ?fontVariantPosition: string,
        ?fontVariationSettings: string,
        ?fontWeight: string,
        ?forcedColorAdjust: string,
        ?gap: string,
        ?grid: string,
        ?gridArea: string,
        ?gridAutoColumns: string,
        ?gridAutoFlow: string,
        ?gridAutoRows: string,
        ?gridColumn: string,
        ?gridColumnEnd: string,
        ?gridColumnGap: string,
        ?gridColumnStart: string,
        ?gridGap: string,
        ?gridRow: string,
        ?gridRowEnd: string,
        ?gridRowGap: string,
        ?gridRowStart: string,
        ?gridTemplate: string,
        ?gridTemplateAreas: string,
        ?gridTemplateColumns: string,
        ?gridTemplateRows: string,
        ?height: string,
        ?hyphenateCharacter: string,
        ?hyphens: string,
        ?imageOrientation: string,
        ?imageRendering: string,
        ?inlineSize: string,
        ?inset: string,
        ?insetBlock: string,
        ?insetBlockEnd: string,
        ?insetBlockStart: string,
        ?insetInline: string,
        ?insetInlineEnd: string,
        ?insetInlineStart: string,
        ?isolation: string,
        ?justifyContent: string,
        ?justifyItems: string,
        ?justifySelf: string,
        ?left: string,
        ?length: float,
        ?letterSpacing: string,
        ?lightingColor: string,
        ?lineBreak: string,
        ?lineHeight: string,
        ?listStyle: string,
        ?listStyleImage: string,
        ?listStylePosition: string,
        ?listStyleType: string,
        ?margin: string,
        ?marginBlock: string,
        ?marginBlockEnd: string,
        ?marginBlockStart: string,
        ?marginBottom: string,
        ?marginInline: string,
        ?marginInlineEnd: string,
        ?marginInlineStart: string,
        ?marginLeft: string,
        ?marginRight: string,
        ?marginTop: string,
        ?marker: string,
        ?markerEnd: string,
        ?markerMid: string,
        ?markerStart: string,
        ?mask: string,
        ?maskClip: string,
        ?maskComposite: string,
        ?maskImage: string,
        ?maskMode: string,
        ?maskOrigin: string,
        ?maskPosition: string,
        ?maskRepeat: string,
        ?maskSize: string,
        ?maskType: string,
        ?mathDepth: string,
        ?mathStyle: string,
        ?maxBlockSize: string,
        ?maxHeight: string,
        ?maxInlineSize: string,
        ?maxWidth: string,
        ?minBlockSize: string,
        ?minHeight: string,
        ?minInlineSize: string,
        ?minWidth: string,
        ?mixBlendMode: string,
        ?objectFit: string,
        ?objectPosition: string,
        ?offset: string,
        ?offsetAnchor: string,
        ?offsetDistance: string,
        ?offsetPath: string,
        ?offsetPosition: string,
        ?offsetRotate: string,
        ?opacity: string,
        ?order: string,
        ?orphans: string,
        ?outline: string,
        ?outlineColor: string,
        ?outlineOffset: string,
        ?outlineStyle: string,
        ?outlineWidth: string,
        ?overflow: string,
        ?overflowAnchor: string,
        ?overflowClipMargin: string,
        ?overflowWrap: string,
        ?overflowX: string,
        ?overflowY: string,
        ?overscrollBehavior: string,
        ?overscrollBehaviorBlock: string,
        ?overscrollBehaviorInline: string,
        ?overscrollBehaviorX: string,
        ?overscrollBehaviorY: string,
        ?padding: string,
        ?paddingBlock: string,
        ?paddingBlockEnd: string,
        ?paddingBlockStart: string,
        ?paddingBottom: string,
        ?paddingInline: string,
        ?paddingInlineEnd: string,
        ?paddingInlineStart: string,
        ?paddingLeft: string,
        ?paddingRight: string,
        ?paddingTop: string,
        ?page: string,
        ?pageBreakAfter: string,
        ?pageBreakBefore: string,
        ?pageBreakInside: string,
        ?paintOrder: string,
        ?perspective: string,
        ?perspectiveOrigin: string,
        ?placeContent: string,
        ?placeItems: string,
        ?placeSelf: string,
        ?pointerEvents: string,
        ?position: string,
        ?printColorAdjust: string,
        ?quotes: string,
        ?r: string,
        ?resize: string,
        ?right: string,
        ?rotate: string,
        ?rowGap: string,
        ?rubyPosition: string,
        ?rx: string,
        ?ry: string,
        ?scale: string,
        ?scrollBehavior: string,
        ?scrollMargin: string,
        ?scrollMarginBlock: string,
        ?scrollMarginBlockEnd: string,
        ?scrollMarginBlockStart: string,
        ?scrollMarginBottom: string,
        ?scrollMarginInline: string,
        ?scrollMarginInlineEnd: string,
        ?scrollMarginInlineStart: string,
        ?scrollMarginLeft: string,
        ?scrollMarginRight: string,
        ?scrollMarginTop: string,
        ?scrollPadding: string,
        ?scrollPaddingBlock: string,
        ?scrollPaddingBlockEnd: string,
        ?scrollPaddingBlockStart: string,
        ?scrollPaddingBottom: string,
        ?scrollPaddingInline: string,
        ?scrollPaddingInlineEnd: string,
        ?scrollPaddingInlineStart: string,
        ?scrollPaddingLeft: string,
        ?scrollPaddingRight: string,
        ?scrollPaddingTop: string,
        ?scrollSnapAlign: string,
        ?scrollSnapStop: string,
        ?scrollSnapType: string,
        ?scrollbarColor: string,
        ?scrollbarGutter: string,
        ?scrollbarWidth: string,
        ?shapeImageThreshold: string,
        ?shapeMargin: string,
        ?shapeOutside: string,
        ?shapeRendering: string,
        ?stopColor: string,
        ?stopOpacity: string,
        ?stroke: string,
        ?strokeDasharray: string,
        ?strokeDashoffset: string,
        ?strokeLinecap: string,
        ?strokeLinejoin: string,
        ?strokeMiterlimit: string,
        ?strokeOpacity: string,
        ?strokeWidth: string,
        ?tabSize: string,
        ?tableLayout: string,
        ?textAlign: string,
        ?textAlignLast: string,
        ?textAnchor: string,
        ?textCombineUpright: string,
        ?textDecoration: string,
        ?textDecorationColor: string,
        ?textDecorationLine: string,
        ?textDecorationSkipInk: string,
        ?textDecorationStyle: string,
        ?textDecorationThickness: string,
        ?textEmphasis: string,
        ?textEmphasisColor: string,
        ?textEmphasisPosition: string,
        ?textEmphasisStyle: string,
        ?textIndent: string,
        ?textOrientation: string,
        ?textOverflow: string,
        ?textRendering: string,
        ?textShadow: string,
        ?textTransform: string,
        ?textUnderlineOffset: string,
        ?textUnderlinePosition: string,
        ?textWrap: string,
        ?top: string,
        ?touchAction: string,
        ?transform: string,
        ?transformBox: string,
        ?transformOrigin: string,
        ?transformStyle: string,
        ?transition: string,
        ?transitionDelay: string,
        ?transitionDuration: string,
        ?transitionProperty: string,
        ?transitionTimingFunction: string,
        ?translate: string,
        ?unicodeBidi: string,
        ?userSelect: string,
        ?vectorEffect: string,
        ?verticalAlign: string,
        ?visibility: string,
        ?webkitAlignContent: string,
        ?webkitAlignItems: string,
        ?webkitAlignSelf: string,
        ?webkitAnimation: string,
        ?webkitAnimationDelay: string,
        ?webkitAnimationDirection: string,
        ?webkitAnimationDuration: string,
        ?webkitAnimationFillMode: string,
        ?webkitAnimationIterationCount: string,
        ?webkitAnimationName: string,
        ?webkitAnimationPlayState: string,
        ?webkitAnimationTimingFunction: string,
        ?webkitAppearance: string,
        ?webkitBackfaceVisibility: string,
        ?webkitBackgroundClip: string,
        ?webkitBackgroundOrigin: string,
        ?webkitBackgroundSize: string,
        ?webkitBorderBottomLeftRadius: string,
        ?webkitBorderBottomRightRadius: string,
        ?webkitBorderRadius: string,
        ?webkitBorderTopLeftRadius: string,
        ?webkitBorderTopRightRadius: string,
        ?webkitBoxAlign: string,
        ?webkitBoxFlex: string,
        ?webkitBoxOrdinalGroup: string,
        ?webkitBoxOrient: string,
        ?webkitBoxPack: string,
        ?webkitBoxShadow: string,
        ?webkitBoxSizing: string,
        ?webkitFilter: string,
        ?webkitFlex: string,
        ?webkitFlexBasis: string,
        ?webkitFlexDirection: string,
        ?webkitFlexFlow: string,
        ?webkitFlexGrow: string,
        ?webkitFlexShrink: string,
        ?webkitFlexWrap: string,
        ?webkitJustifyContent: string,
        ?webkitLineClamp: string,
        ?webkitMask: string,
        ?webkitMaskBoxImage: string,
        ?webkitMaskBoxImageOutset: string,
        ?webkitMaskBoxImageRepeat: string,
        ?webkitMaskBoxImageSlice: string,
        ?webkitMaskBoxImageSource: string,
        ?webkitMaskBoxImageWidth: string,
        ?webkitMaskClip: string,
        ?webkitMaskComposite: string,
        ?webkitMaskImage: string,
        ?webkitMaskOrigin: string,
        ?webkitMaskPosition: string,
        ?webkitMaskRepeat: string,
        ?webkitMaskSize: string,
        ?webkitOrder: string,
        ?webkitPerspective: string,
        ?webkitPerspectiveOrigin: string,
        ?webkitTextFillColor: string,
        ?webkitTextSizeAdjust: string,
        ?webkitTextStroke: string,
        ?webkitTextStrokeColor: string,
        ?webkitTextStrokeWidth: string,
        ?webkitTransform: string,
        ?webkitTransformOrigin: string,
        ?webkitTransformStyle: string,
        ?webkitTransition: string,
        ?webkitTransitionDelay: string,
        ?webkitTransitionDuration: string,
        ?webkitTransitionProperty: string,
        ?webkitTransitionTimingFunction: string,
        ?webkitUserSelect: string,
        ?whiteSpace: string,
        ?widows: string,
        ?width: string,
        ?willChange: string,
        ?wordBreak: string,
        ?wordSpacing: string,
        ?wordWrap: string,
        ?writingMode: string,
        ?x: string,
        ?y: string,
        ?zIndex: string
    ) = class end

[<RequireQualifiedAccess; Global>]
type Style =
    | accentColor of string
    | alignContent of string
    | alignItems of string
    | alignSelf of string
    | alignmentBaseline of string
    | all of string
    | animation of string
    | animationComposition of string
    | animationDelay of string
    | animationDirection of string
    | animationDuration of string
    | animationFillMode of string
    | animationIterationCount of string
    | animationName of string
    | animationPlayState of string
    | animationTimingFunction of string
    | appearance of string
    | aspectRatio of string
    | backdropFilter of string
    | backfaceVisibility of string
    | background of string
    | backgroundAttachment of string
    | backgroundBlendMode of string
    | backgroundClip of string
    | backgroundColor of string
    | backgroundImage of string
    | backgroundOrigin of string
    | backgroundPosition of string
    | backgroundPositionX of string
    | backgroundPositionY of string
    | backgroundRepeat of string
    | backgroundSize of string
    | baselineShift of string
    | baselineSource of string
    | blockSize of string
    | border of string
    | borderBlock of string
    | borderBlockColor of string
    | borderBlockEnd of string
    | borderBlockEndColor of string
    | borderBlockEndStyle of string
    | borderBlockEndWidth of string
    | borderBlockStart of string
    | borderBlockStartColor of string
    | borderBlockStartStyle of string
    | borderBlockStartWidth of string
    | borderBlockStyle of string
    | borderBlockWidth of string
    | borderBottom of string
    | borderBottomColor of string
    | borderBottomLeftRadius of string
    | borderBottomRightRadius of string
    | borderBottomStyle of string
    | borderBottomWidth of string
    | borderCollapse of string
    | borderColor of string
    | borderEndEndRadius of string
    | borderEndStartRadius of string
    | borderImage of string
    | borderImageOutset of string
    | borderImageRepeat of string
    | borderImageSlice of string
    | borderImageSource of string
    | borderImageWidth of string
    | borderInline of string
    | borderInlineColor of string
    | borderInlineEnd of string
    | borderInlineEndColor of string
    | borderInlineEndStyle of string
    | borderInlineEndWidth of string
    | borderInlineStart of string
    | borderInlineStartColor of string
    | borderInlineStartStyle of string
    | borderInlineStartWidth of string
    | borderInlineStyle of string
    | borderInlineWidth of string
    | borderLeft of string
    | borderLeftColor of string
    | borderLeftStyle of string
    | borderLeftWidth of string
    | borderRadius of string
    | borderRight of string
    | borderRightColor of string
    | borderRightStyle of string
    | borderRightWidth of string
    | borderSpacing of string
    | borderStartEndRadius of string
    | borderStartStartRadius of string
    | borderStyle of string
    | borderTop of string
    | borderTopColor of string
    | borderTopLeftRadius of string
    | borderTopRightRadius of string
    | borderTopStyle of string
    | borderTopWidth of string
    | borderWidth of string
    | bottom of string
    | boxShadow of string
    | boxSizing of string
    | breakAfter of string
    | breakBefore of string
    | breakInside of string
    | captionSide of string
    | caretColor of string
    | clear of string
    | clip of string
    | clipPath of string
    | clipRule of string
    | color of string
    | colorInterpolation of string
    | colorInterpolationFilters of string
    | colorScheme of string
    | columnCount of string
    | columnFill of string
    | columnGap of string
    | columnRule of string
    | columnRuleColor of string
    | columnRuleStyle of string
    | columnRuleWidth of string
    | columnSpan of string
    | columnWidth of string
    | columns of string
    | contain of string
    | containIntrinsicBlockSize of string
    | containIntrinsicHeight of string
    | containIntrinsicInlineSize of string
    | containIntrinsicSize of string
    | containIntrinsicWidth of string
    | container of string
    | containerName of string
    | containerType of string
    | content of string
    | counterIncrement of string
    | counterReset of string
    | counterSet of string
    | cssFloat of string
    | cssText of string
    | cursor of string
    | cx of string
    | cy of string
    | d of string
    | direction of string
    | display of string
    | dominantBaseline of string
    | emptyCells of string
    | fill of string
    | fillOpacity of string
    | fillRule of string
    | filter of string
    | flex of string
    | flexBasis of string
    | flexDirection of string
    | flexFlow of string
    | flexGrow of string
    | flexShrink of string
    | flexWrap of string
    | float of string
    | floodColor of string
    | floodOpacity of string
    | font of string
    | fontFamily of string
    | fontFeatureSettings of string
    | fontKerning of string
    | fontOpticalSizing of string
    | fontPalette of string
    | fontSize of string
    | fontSizeAdjust of string
    | fontStretch of string
    | fontStyle of string
    | fontSynthesis of string
    | fontSynthesisSmallCaps of string
    | fontSynthesisStyle of string
    | fontSynthesisWeight of string
    | fontVariant of string
    | fontVariantAlternates of string
    | fontVariantCaps of string
    | fontVariantEastAsian of string
    | fontVariantLigatures of string
    | fontVariantNumeric of string
    | fontVariantPosition of string
    | fontVariationSettings of string
    | fontWeight of string
    | forcedColorAdjust of string
    | gap of string
    | grid of string
    | gridArea of string
    | gridAutoColumns of string
    | gridAutoFlow of string
    | gridAutoRows of string
    | gridColumn of string
    | gridColumnEnd of string
    | gridColumnGap of string
    | gridColumnStart of string
    | gridGap of string
    | gridRow of string
    | gridRowEnd of string
    | gridRowGap of string
    | gridRowStart of string
    | gridTemplate of string
    | gridTemplateAreas of string
    | gridTemplateColumns of string
    | gridTemplateRows of string
    | height of string
    | hyphenateCharacter of string
    | hyphens of string
    | imageOrientation of string
    | imageRendering of string
    | inlineSize of string
    | inset of string
    | insetBlock of string
    | insetBlockEnd of string
    | insetBlockStart of string
    | insetInline of string
    | insetInlineEnd of string
    | insetInlineStart of string
    | isolation of string
    | justifyContent of string
    | justifyItems of string
    | justifySelf of string
    | left of string
    | length of float
    | letterSpacing of string
    | lightingColor of string
    | lineBreak of string
    | lineHeight of string
    | listStyle of string
    | listStyleImage of string
    | listStylePosition of string
    | listStyleType of string
    | margin of string
    | marginBlock of string
    | marginBlockEnd of string
    | marginBlockStart of string
    | marginBottom of string
    | marginInline of string
    | marginInlineEnd of string
    | marginInlineStart of string
    | marginLeft of string
    | marginRight of string
    | marginTop of string
    | marker of string
    | markerEnd of string
    | markerMid of string
    | markerStart of string
    | mask of string
    | maskClip of string
    | maskComposite of string
    | maskImage of string
    | maskMode of string
    | maskOrigin of string
    | maskPosition of string
    | maskRepeat of string
    | maskSize of string
    | maskType of string
    | mathDepth of string
    | mathStyle of string
    | maxBlockSize of string
    | maxHeight of string
    | maxInlineSize of string
    | maxWidth of string
    | minBlockSize of string
    | minHeight of string
    | minInlineSize of string
    | minWidth of string
    | mixBlendMode of string
    | objectFit of string
    | objectPosition of string
    | offset of string
    | offsetAnchor of string
    | offsetDistance of string
    | offsetPath of string
    | offsetPosition of string
    | offsetRotate of string
    | opacity of string
    | order of string
    | orphans of string
    | outline of string
    | outlineColor of string
    | outlineOffset of string
    | outlineStyle of string
    | outlineWidth of string
    | overflow of string
    | overflowAnchor of string
    | overflowClipMargin of string
    | overflowWrap of string
    | overflowX of string
    | overflowY of string
    | overscrollBehavior of string
    | overscrollBehaviorBlock of string
    | overscrollBehaviorInline of string
    | overscrollBehaviorX of string
    | overscrollBehaviorY of string
    | padding of string
    | paddingBlock of string
    | paddingBlockEnd of string
    | paddingBlockStart of string
    | paddingBottom of string
    | paddingInline of string
    | paddingInlineEnd of string
    | paddingInlineStart of string
    | paddingLeft of string
    | paddingRight of string
    | paddingTop of string
    | page of string
    | pageBreakAfter of string
    | pageBreakBefore of string
    | pageBreakInside of string
    | paintOrder of string
    | perspective of string
    | perspectiveOrigin of string
    | placeContent of string
    | placeItems of string
    | placeSelf of string
    | pointerEvents of string
    | position of string
    | printColorAdjust of string
    | quotes of string
    | r of string
    | resize of string
    | right of string
    | rotate of string
    | rowGap of string
    | rubyPosition of string
    | rx of string
    | ry of string
    | scale of string
    | scrollBehavior of string
    | scrollMargin of string
    | scrollMarginBlock of string
    | scrollMarginBlockEnd of string
    | scrollMarginBlockStart of string
    | scrollMarginBottom of string
    | scrollMarginInline of string
    | scrollMarginInlineEnd of string
    | scrollMarginInlineStart of string
    | scrollMarginLeft of string
    | scrollMarginRight of string
    | scrollMarginTop of string
    | scrollPadding of string
    | scrollPaddingBlock of string
    | scrollPaddingBlockEnd of string
    | scrollPaddingBlockStart of string
    | scrollPaddingBottom of string
    | scrollPaddingInline of string
    | scrollPaddingInlineEnd of string
    | scrollPaddingInlineStart of string
    | scrollPaddingLeft of string
    | scrollPaddingRight of string
    | scrollPaddingTop of string
    | scrollSnapAlign of string
    | scrollSnapStop of string
    | scrollSnapType of string
    | scrollbarColor of string
    | scrollbarGutter of string
    | scrollbarWidth of string
    | shapeImageThreshold of string
    | shapeMargin of string
    | shapeOutside of string
    | shapeRendering of string
    | stopColor of string
    | stopOpacity of string
    | stroke of string
    | strokeDasharray of string
    | strokeDashoffset of string
    | strokeLinecap of string
    | strokeLinejoin of string
    | strokeMiterlimit of string
    | strokeOpacity of string
    | strokeWidth of string
    | tabSize of string
    | tableLayout of string
    | textAlign of string
    | textAlignLast of string
    | textAnchor of string
    | textCombineUpright of string
    | textDecoration of string
    | textDecorationColor of string
    | textDecorationLine of string
    | textDecorationSkipInk of string
    | textDecorationStyle of string
    | textDecorationThickness of string
    | textEmphasis of string
    | textEmphasisColor of string
    | textEmphasisPosition of string
    | textEmphasisStyle of string
    | textIndent of string
    | textOrientation of string
    | textOverflow of string
    | textRendering of string
    | textShadow of string
    | textTransform of string
    | textUnderlineOffset of string
    | textUnderlinePosition of string
    | textWrap of string
    | top of string
    | touchAction of string
    | transform of string
    | transformBox of string
    | transformOrigin of string
    | transformStyle of string
    | transition of string
    | transitionDelay of string
    | transitionDuration of string
    | transitionProperty of string
    | transitionTimingFunction of string
    | translate of string
    | unicodeBidi of string
    | userSelect of string
    | vectorEffect of string
    | verticalAlign of string
    | visibility of string
    | webkitAlignContent of string
    | webkitAlignItems of string
    | webkitAlignSelf of string
    | webkitAnimation of string
    | webkitAnimationDelay of string
    | webkitAnimationDirection of string
    | webkitAnimationDuration of string
    | webkitAnimationFillMode of string
    | webkitAnimationIterationCount of string
    | webkitAnimationName of string
    | webkitAnimationPlayState of string
    | webkitAnimationTimingFunction of string
    | webkitAppearance of string
    | webkitBackfaceVisibility of string
    | webkitBackgroundClip of string
    | webkitBackgroundOrigin of string
    | webkitBackgroundSize of string
    | webkitBorderBottomLeftRadius of string
    | webkitBorderBottomRightRadius of string
    | webkitBorderRadius of string
    | webkitBorderTopLeftRadius of string
    | webkitBorderTopRightRadius of string
    | webkitBoxAlign of string
    | webkitBoxFlex of string
    | webkitBoxOrdinalGroup of string
    | webkitBoxOrient of string
    | webkitBoxPack of string
    | webkitBoxShadow of string
    | webkitBoxSizing of string
    | webkitFilter of string
    | webkitFlex of string
    | webkitFlexBasis of string
    | webkitFlexDirection of string
    | webkitFlexFlow of string
    | webkitFlexGrow of string
    | webkitFlexShrink of string
    | webkitFlexWrap of string
    | webkitJustifyContent of string
    | webkitLineClamp of string
    | webkitMask of string
    | webkitMaskBoxImage of string
    | webkitMaskBoxImageOutset of string
    | webkitMaskBoxImageRepeat of string
    | webkitMaskBoxImageSlice of string
    | webkitMaskBoxImageSource of string
    | webkitMaskBoxImageWidth of string
    | webkitMaskClip of string
    | webkitMaskComposite of string
    | webkitMaskImage of string
    | webkitMaskOrigin of string
    | webkitMaskPosition of string
    | webkitMaskRepeat of string
    | webkitMaskSize of string
    | webkitOrder of string
    | webkitPerspective of string
    | webkitPerspectiveOrigin of string
    | webkitTextFillColor of string
    | webkitTextSizeAdjust of string
    | webkitTextStroke of string
    | webkitTextStrokeColor of string
    | webkitTextStrokeWidth of string
    | webkitTransform of string
    | webkitTransformOrigin of string
    | webkitTransformStyle of string
    | webkitTransition of string
    | webkitTransitionDelay of string
    | webkitTransitionDuration of string
    | webkitTransitionProperty of string
    | webkitTransitionTimingFunction of string
    | webkitUserSelect of string
    | whiteSpace of string
    | widows of string
    | width of string
    | willChange of string
    | wordBreak of string
    | wordSpacing of string
    | wordWrap of string
    | writingMode of string
    | x of string
    | y of string
    | zIndex of string