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
