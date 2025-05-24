namespace Partas.Solid.Motion

open Partas.Solid
open Fable.Core

[<Import("Motion", "solid-motionone")>]
type Motion() =
    inherit RegularNode()
    interface OptionKeys
    interface AttrKey
    // Enable polymorphism with the tag attribute name
    interface Polymorph
    [<Erase>] member val ``__PARTAS_POLYMORPHIC__tag``: string = unbox null with get,set
    [<Erase>]
    member this.tag
        with inline set(value: string) = this.``__PARTAS_POLYMORPHIC__tag`` <- value
        and inline get(): string = this.``__PARTAS_POLYMORPHIC__tag``
        
[<RequireQualifiedAccess; Erase>]
module Motion =
    [<PartasProxyImport("a", "Motion", "solid-motionone")>]
    type a() =
        inherit Tags.a()
        interface OptionKeys        
    [<PartasProxyImport("abbr", "Motion", "solid-motionone")>]
    type abbr() =
        inherit Tags.abbr()
        interface OptionKeys        
    [<PartasProxyImport("address", "Motion", "solid-motionone")>]
    type address() =
        inherit Tags.address()
        interface OptionKeys        
    [<PartasProxyImport("area", "Motion", "solid-motionone")>]
    type area() =
        inherit Tags.area()
        interface OptionKeys        
    [<PartasProxyImport("article", "Motion", "solid-motionone")>]
    type article() =
        inherit Tags.article()
        interface OptionKeys        
    [<PartasProxyImport("aside", "Motion", "solid-motionone")>]
    type aside() =
        inherit Tags.aside()
        interface OptionKeys        
    [<PartasProxyImport("audio", "Motion", "solid-motionone")>]
    type audio() =
        inherit Tags.audio()
        interface OptionKeys        
    [<PartasProxyImport("b", "Motion", "solid-motionone")>]
    type b() =
        inherit Tags.b()
        interface OptionKeys        
    [<PartasProxyImport("base", "Motion", "solid-motionone")>]
    type base'() =
        inherit Tags.base'()
        interface OptionKeys        
    [<PartasProxyImport("bdi", "Motion", "solid-motionone")>]
    type bdi() =
        inherit Tags.bdi()
        interface OptionKeys        
    [<PartasProxyImport("bdo", "Motion", "solid-motionone")>]
    type bdo() =
        inherit Tags.bdo()
        interface OptionKeys        
    [<PartasProxyImport("blockquote", "Motion", "solid-motionone")>]
    type blockquote() =
        inherit Tags.blockquote()
        interface OptionKeys        
    [<PartasProxyImport("body", "Motion", "solid-motionone")>]
    type body() =
        inherit Tags.body()
        interface OptionKeys        
    [<PartasProxyImport("br", "Motion", "solid-motionone")>]
    type br() =
        inherit Tags.br()
        interface OptionKeys        
    [<PartasProxyImport("button", "Motion", "solid-motionone")>]
    type button() =
        inherit Tags.button()
        interface OptionKeys        
    [<PartasProxyImport("canvas", "Motion", "solid-motionone")>]
    type canvas() =
        inherit Tags.canvas()
        interface OptionKeys        
    [<PartasProxyImport("caption", "Motion", "solid-motionone")>]
    type caption() =
        inherit Tags.caption()
        interface OptionKeys        
    [<PartasProxyImport("cite", "Motion", "solid-motionone")>]
    type cite() =
        inherit Tags.cite()
        interface OptionKeys        
    [<PartasProxyImport("code", "Motion", "solid-motionone")>]
    type code() =
        inherit Tags.code()
        interface OptionKeys        
    [<PartasProxyImport("col", "Motion", "solid-motionone")>]
    type col() =
        inherit Tags.col()
        interface OptionKeys        
    [<PartasProxyImport("colgroup", "Motion", "solid-motionone")>]
    type colgroup() =
        inherit Tags.colgroup()
        interface OptionKeys        
    [<PartasProxyImport("data", "Motion", "solid-motionone")>]
    type data() =
        inherit Tags.data()
        interface OptionKeys        
    [<PartasProxyImport("datalist", "Motion", "solid-motionone")>]
    type datalist() =
        inherit Tags.datalist()
        interface OptionKeys        
    [<PartasProxyImport("dd", "Motion", "solid-motionone")>]
    type dd() =
        inherit Tags.dd()
        interface OptionKeys        
    [<PartasProxyImport("del", "Motion", "solid-motionone")>]
    type del() =
        inherit Tags.del()
        interface OptionKeys        
    [<PartasProxyImport("details", "Motion", "solid-motionone")>]
    type details() =
        inherit Tags.details()
        interface OptionKeys        
    [<PartasProxyImport("dfn", "Motion", "solid-motionone")>]
    type dfn() =
        inherit Tags.dfn()
        interface OptionKeys        
    [<PartasProxyImport("dialog", "Motion", "solid-motionone")>]
    type dialog() =
        inherit Tags.dialog()
        interface OptionKeys        
    [<PartasProxyImport("div", "Motion", "solid-motionone")>]
    type div() =
        inherit Tags.div()
        interface OptionKeys        
    [<PartasProxyImport("dl", "Motion", "solid-motionone")>]
    type dl() =
        inherit Tags.dl()
        interface OptionKeys        
    [<PartasProxyImport("dt", "Motion", "solid-motionone")>]
    type dt() =
        inherit Tags.dt()
        interface OptionKeys        
    [<PartasProxyImport("em", "Motion", "solid-motionone")>]
    type em() =
        inherit Tags.em()
        interface OptionKeys        
    [<PartasProxyImport("embed", "Motion", "solid-motionone")>]
    type embed() =
        inherit Tags.embed()
        interface OptionKeys        
    [<PartasProxyImport("fieldset", "Motion", "solid-motionone")>]
    type fieldset() =
        inherit Tags.fieldset()
        interface OptionKeys        
    [<PartasProxyImport("figcaption", "Motion", "solid-motionone")>]
    type figcaption() =
        inherit Tags.figcaption()
        interface OptionKeys        
    [<PartasProxyImport("figure", "Motion", "solid-motionone")>]
    type figure() =
        inherit Tags.figure()
        interface OptionKeys        
    [<PartasProxyImport("footer", "Motion", "solid-motionone")>]
    type footer() =
        inherit Tags.footer()
        interface OptionKeys        
    [<PartasProxyImport("form", "Motion", "solid-motionone")>]
    type form() =
        inherit Tags.form()
        interface OptionKeys        
    [<PartasProxyImport("h1", "Motion", "solid-motionone")>]
    type h1() =
        inherit Tags.h1()
        interface OptionKeys        
    [<PartasProxyImport("h2", "Motion", "solid-motionone")>]
    type h2() =
        inherit Tags.h2()
        interface OptionKeys        
    [<PartasProxyImport("h3", "Motion", "solid-motionone")>]
    type h3() =
        inherit Tags.h3()
        interface OptionKeys        
    [<PartasProxyImport("h4", "Motion", "solid-motionone")>]
    type h4() =
        inherit Tags.h4()
        interface OptionKeys        
    [<PartasProxyImport("h5", "Motion", "solid-motionone")>]
    type h5() =
        inherit Tags.h5()
        interface OptionKeys        
    [<PartasProxyImport("h6", "Motion", "solid-motionone")>]
    type h6() =
        inherit Tags.h6()
        interface OptionKeys        
    [<PartasProxyImport("head", "Motion", "solid-motionone")>]
    type head() =
        inherit Tags.head()
        interface OptionKeys        
    [<PartasProxyImport("header", "Motion", "solid-motionone")>]
    type header() =
        inherit Tags.header()
        interface OptionKeys        
    // [<PartasProxyImport("hgroup", "Motion", "solid-motionone")>]
    // type hgroup() =
    //     inherit Tags.hgroup()
    //     interface OptionKeys    
    [<PartasProxyImport("hr", "Motion", "solid-motionone")>]
    type hr() =
        inherit Tags.hr()
        interface OptionKeys        
    [<PartasProxyImport("html", "Motion", "solid-motionone")>]
    type html() =
        inherit Tags.html()
        interface OptionKeys        
    [<PartasProxyImport("i", "Motion", "solid-motionone")>]
    type i() =
        inherit Tags.i()
        interface OptionKeys        
    [<PartasProxyImport("iframe", "Motion", "solid-motionone")>]
    type iframe() =
        inherit Tags.iframe()
        interface OptionKeys        
    [<PartasProxyImport("img", "Motion", "solid-motionone")>]
    type img() =
        inherit Tags.img()
        interface OptionKeys        
    [<PartasProxyImport("input", "Motion", "solid-motionone")>]
    type input() =
        inherit Tags.input()
        interface OptionKeys        
    [<PartasProxyImport("ins", "Motion", "solid-motionone")>]
    type ins() =
        inherit Tags.ins()
        interface OptionKeys        
    [<PartasProxyImport("kbd", "Motion", "solid-motionone")>]
    type kbd() =
        inherit Tags.kbd()
        interface OptionKeys        
    [<PartasProxyImport("label", "Motion", "solid-motionone")>]
    type label() =
        inherit Tags.label()
        interface OptionKeys        
    [<PartasProxyImport("legend", "Motion", "solid-motionone")>]
    type legend() =
        inherit Tags.legend()
        interface OptionKeys        
    [<PartasProxyImport("li", "Motion", "solid-motionone")>]
    type li() =
        inherit Tags.li()
        interface OptionKeys        
    [<PartasProxyImport("link", "Motion", "solid-motionone")>]
    type link() =
        inherit Tags.link()
        interface OptionKeys        
    [<PartasProxyImport("main", "Motion", "solid-motionone")>]
    type main() =
        inherit Tags.main()
        interface OptionKeys        
    [<PartasProxyImport("map", "Motion", "solid-motionone")>]
    type map() =
        inherit Tags.map()
        interface OptionKeys        
    [<PartasProxyImport("mark", "Motion", "solid-motionone")>]
    type mark() =
        inherit Tags.mark()
        interface OptionKeys        
    [<PartasProxyImport("menu", "Motion", "solid-motionone")>]
    type menu() =
        inherit Tags.menu()
        interface OptionKeys        
    [<PartasProxyImport("meta", "Motion", "solid-motionone")>]
    type meta() =
        inherit Tags.meta()
        interface OptionKeys        
    [<PartasProxyImport("meter", "Motion", "solid-motionone")>]
    type meter() =
        inherit Tags.meter()
        interface OptionKeys        
    [<PartasProxyImport("nav", "Motion", "solid-motionone")>]
    type nav() =
        inherit Tags.nav()
        interface OptionKeys        
    [<PartasProxyImport("noscript", "Motion", "solid-motionone")>]
    type noscript() =
        inherit Tags.noscript()
        interface OptionKeys        
    [<PartasProxyImport("object", "Motion", "solid-motionone")>]
    type object'() =
        inherit Tags.object'()
        interface OptionKeys        
    [<PartasProxyImport("ol", "Motion", "solid-motionone")>]
    type ol() =
        inherit Tags.ol()
        interface OptionKeys        
    [<PartasProxyImport("optgroup", "Motion", "solid-motionone")>]
    type optgroup() =
        inherit Tags.optgroup()
        interface OptionKeys        
    [<PartasProxyImport("option", "Motion", "solid-motionone")>]
    type option() =
        inherit Tags.option()
        interface OptionKeys        
    [<PartasProxyImport("output", "Motion", "solid-motionone")>]
    type output() =
        inherit Tags.output()
        interface OptionKeys        
    [<PartasProxyImport("p", "Motion", "solid-motionone")>]
    type p() =
        inherit Tags.p()
        interface OptionKeys        
    [<PartasProxyImport("picture", "Motion", "solid-motionone")>]
    type picture() =
        inherit Tags.picture()
        interface OptionKeys        
    [<PartasProxyImport("pre", "Motion", "solid-motionone")>]
    type pre() =
        inherit Tags.pre()
        interface OptionKeys        
    [<PartasProxyImport("progress", "Motion", "solid-motionone")>]
    type progress() =
        inherit Tags.progress()
        interface OptionKeys        
    [<PartasProxyImport("q", "Motion", "solid-motionone")>]
    type q() =
        inherit Tags.q()
        interface OptionKeys        
    [<PartasProxyImport("s", "Motion", "solid-motionone")>]
    type s() =
        inherit Tags.s()
        interface OptionKeys        
    [<PartasProxyImport("samp", "Motion", "solid-motionone")>]
    type samp() =
        inherit Tags.samp()
        interface OptionKeys        
    [<PartasProxyImport("script", "Motion", "solid-motionone")>]
    type script() =
        inherit Tags.script()
        interface OptionKeys        
    [<PartasProxyImport("search", "Motion", "solid-motionone")>]
    type search() =
        inherit Tags.search()
        interface OptionKeys        
    [<PartasProxyImport("section", "Motion", "solid-motionone")>]
    type section() =
        inherit Tags.section()
        interface OptionKeys        
    [<PartasProxyImport("select", "Motion", "solid-motionone")>]
    type select() =
        inherit Tags.select()
        interface OptionKeys        
    // [<PartasProxyImport("slot", "Motion", "solid-motionone")>]
    // type slot() =
    //     inherit Tags.slot()
    //     interface OptionKeys    
    [<PartasProxyImport("small", "Motion", "solid-motionone")>]
    type small() =
        inherit Tags.small()
        interface OptionKeys        
    [<PartasProxyImport("source", "Motion", "solid-motionone")>]
    type source() =
        inherit Tags.source()
        interface OptionKeys        
    [<PartasProxyImport("span", "Motion", "solid-motionone")>]
    type span() =
        inherit Tags.span()
        interface OptionKeys        
    [<PartasProxyImport("strong", "Motion", "solid-motionone")>]
    type strong() =
        inherit Tags.strong()
        interface OptionKeys        
    [<PartasProxyImport("style", "Motion", "solid-motionone")>]
    type style() =
        inherit Tags.style()
        interface OptionKeys        
    [<PartasProxyImport("sub", "Motion", "solid-motionone")>]
    type sub() =
        inherit Tags.sub()
        interface OptionKeys        
    [<PartasProxyImport("summary", "Motion", "solid-motionone")>]
    type summary() =
        inherit Tags.summary()
        interface OptionKeys        
    [<PartasProxyImport("sup", "Motion", "solid-motionone")>]
    type sup() =
        inherit Tags.sup()
        interface OptionKeys        
    [<PartasProxyImport("table", "Motion", "solid-motionone")>]
    type table() =
        inherit Tags.table()
        interface OptionKeys        
    [<PartasProxyImport("tbody", "Motion", "solid-motionone")>]
    type tbody() =
        inherit Tags.tbody()
        interface OptionKeys        
    [<PartasProxyImport("td", "Motion", "solid-motionone")>]
    type td() =
        inherit Tags.td()
        interface OptionKeys        
    [<PartasProxyImport("template", "Motion", "solid-motionone")>]
    type template() =
        inherit Tags.template()
        interface OptionKeys        
    [<PartasProxyImport("textarea", "Motion", "solid-motionone")>]
    type textarea() =
        inherit Tags.textarea()
        interface OptionKeys        
    [<PartasProxyImport("tfoot", "Motion", "solid-motionone")>]
    type tfoot() =
        inherit Tags.tfoot()
        interface OptionKeys        
    [<PartasProxyImport("th", "Motion", "solid-motionone")>]
    type th() =
        inherit Tags.th()
        interface OptionKeys        
    [<PartasProxyImport("thead", "Motion", "solid-motionone")>]
    type thead() =
        inherit Tags.thead()
        interface OptionKeys        
    [<PartasProxyImport("time", "Motion", "solid-motionone")>]
    type time() =
        inherit Tags.time()
        interface OptionKeys        
    [<PartasProxyImport("title", "Motion", "solid-motionone")>]
    type title() =
        inherit Tags.title()
        interface OptionKeys        
    [<PartasProxyImport("tr", "Motion", "solid-motionone")>]
    type tr() =
        inherit Tags.tr()
        interface OptionKeys        
    // [<PartasProxyImport("track", "Motion", "solid-motionone")>]
    // type track() =
    //     inherit Tags.track()
    //     interface OptionKeys    
    [<PartasProxyImport("u", "Motion", "solid-motionone")>]
    type u() =
        inherit Tags.u()
        interface OptionKeys        
    [<PartasProxyImport("ul", "Motion", "solid-motionone")>]
    type ul() =
        inherit Tags.ul()
        interface OptionKeys        
    [<PartasProxyImport("var", "Motion", "solid-motionone")>]
    type var() =
        inherit Tags.var()
        interface OptionKeys        
    [<PartasProxyImport("video", "Motion", "solid-motionone")>]
    type video() =
        inherit Tags.video()
        interface OptionKeys        
    [<PartasProxyImport("wbr", "Motion", "solid-motionone")>]
    type wbr() =
        inherit Tags.wbr()
        interface OptionKeys        
    // [<PartasProxyImport("a", "Motion", "solid-motionone")>]
    // type a() =
    //     inherit Tags.a()
    //     interface OptionKeys    
    // [<PartasProxyImport("animate", "Motion", "solid-motionone")>]
    // type animate() =
    //     inherit Tags.animate()
    //     interface OptionKeys    
    // [<PartasProxyImport("animateMotion", "Motion", "solid-motionone")>]
    // type animateMotion() =
    //     inherit Tags.animateMotion()
    //     interface OptionKeys    
    // [<PartasProxyImport("animateTransform", "Motion", "solid-motionone")>]
    // type animateTransform() =
    //     inherit Tags.animateTransform()
    //     interface OptionKeys    
    // [<PartasProxyImport("circle", "Motion", "solid-motionone")>]
    // type circle() =
    //     inherit Tags.circle()
    //     interface OptionKeys    
    // [<PartasProxyImport("clipPath", "Motion", "solid-motionone")>]
    // type clipPath() =
    //     inherit Tags.clipPath()
    //     interface OptionKeys    
    // [<PartasProxyImport("defs", "Motion", "solid-motionone")>]
    // type defs() =
    //     inherit Tags.defs()
    //     interface OptionKeys    
    // [<PartasProxyImport("desc", "Motion", "solid-motionone")>]
    // type desc() =
    //     inherit Tags.desc()
    //     interface OptionKeys    
    // [<PartasProxyImport("ellipse", "Motion", "solid-motionone")>]
    // type ellipse() =
    //     inherit Tags.ellipse()
    //     interface OptionKeys    
    // [<PartasProxyImport("feBlend", "Motion", "solid-motionone")>]
    // type feBlend() =
    //     inherit Tags.feBlend()
    //     interface OptionKeys    
    // [<PartasProxyImport("feColorMatrix", "Motion", "solid-motionone")>]
    // type feColorMatrix() =
    //     inherit Tags.feColorMatrix()
    //     interface OptionKeys    
    // [<PartasProxyImport("feComponentTransfer", "Motion", "solid-motionone")>]
    // type feComponentTransfer() =
    //     inherit Tags.feComponentTransfer()
    //     interface OptionKeys    
    // [<PartasProxyImport("feComposite", "Motion", "solid-motionone")>]
    // type feComposite() =
    //     inherit Tags.feComposite()
    //     interface OptionKeys    
    // [<PartasProxyImport("feConvolveMatrix", "Motion", "solid-motionone")>]
    // type feConvolveMatrix() =
    //     inherit Tags.feConvolveMatrix()
    //     interface OptionKeys    
    // [<PartasProxyImport("feDiffuseLighting", "Motion", "solid-motionone")>]
    // type feDiffuseLighting() =
    //     inherit Tags.feDiffuseLighting()
    //     interface OptionKeys    
    // [<PartasProxyImport("feDisplacementMap", "Motion", "solid-motionone")>]
    // type feDisplacementMap() =
    //     inherit Tags.feDisplacementMap()
    //     interface OptionKeys    
    // [<PartasProxyImport("feDistantLight", "Motion", "solid-motionone")>]
    // type feDistantLight() =
    //     inherit Tags.feDistantLight()
    //     interface OptionKeys    
    // [<PartasProxyImport("feDropShadow", "Motion", "solid-motionone")>]
    // type feDropShadow() =
    //     inherit Tags.feDropShadow()
    //     interface OptionKeys    
    // [<PartasProxyImport("feFlood", "Motion", "solid-motionone")>]
    // type feFlood() =
    //     inherit Tags.feFlood()
    //     interface OptionKeys    
    // [<PartasProxyImport("feFuncA", "Motion", "solid-motionone")>]
    // type feFuncA() =
    //     inherit Tags.feFuncA()
    //     interface OptionKeys    
    // [<PartasProxyImport("feFuncB", "Motion", "solid-motionone")>]
    // type feFuncB() =
    //     inherit Tags.feFuncB()
    //     interface OptionKeys    
    // [<PartasProxyImport("feFuncG", "Motion", "solid-motionone")>]
    // type feFuncG() =
    //     inherit Tags.feFuncG()
    //     interface OptionKeys    
    // [<PartasProxyImport("feFuncR", "Motion", "solid-motionone")>]
    // type feFuncR() =
    //     inherit Tags.feFuncR()
    //     interface OptionKeys    
    // [<PartasProxyImport("feGaussianBlur", "Motion", "solid-motionone")>]
    // type feGaussianBlur() =
    //     inherit Tags.feGaussianBlur()
    //     interface OptionKeys    
    // [<PartasProxyImport("feImage", "Motion", "solid-motionone")>]
    // type feImage() =
    //     inherit Tags.feImage()
    //     interface OptionKeys    
    // [<PartasProxyImport("feMerge", "Motion", "solid-motionone")>]
    // type feMerge() =
    //     inherit Tags.feMerge()
    //     interface OptionKeys    
    // [<PartasProxyImport("feMergeNode", "Motion", "solid-motionone")>]
    // type feMergeNode() =
    //     inherit Tags.feMergeNode()
    //     interface OptionKeys    
    // [<PartasProxyImport("feMorphology", "Motion", "solid-motionone")>]
    // type feMorphology() =
    //     inherit Tags.feMorphology()
    //     interface OptionKeys    
    // [<PartasProxyImport("feOffset", "Motion", "solid-motionone")>]
    // type feOffset() =
    //     inherit Tags.feOffset()
    //     interface OptionKeys    
    // [<PartasProxyImport("fePointLight", "Motion", "solid-motionone")>]
    // type fePointLight() =
    //     inherit Tags.fePointLight()
    //     interface OptionKeys    
    // [<PartasProxyImport("feSpecularLighting", "Motion", "solid-motionone")>]
    // type feSpecularLighting() =
    //     inherit Tags.feSpecularLighting()
    //     interface OptionKeys    
    // [<PartasProxyImport("feSpotLight", "Motion", "solid-motionone")>]
    // type feSpotLight() =
    //     inherit Tags.feSpotLight()
    //     interface OptionKeys    
    // [<PartasProxyImport("feTile", "Motion", "solid-motionone")>]
    // type feTile() =
    //     inherit Tags.feTile()
    //     interface OptionKeys    
    // [<PartasProxyImport("feTurbulence", "Motion", "solid-motionone")>]
    // type feTurbulence() =
    //     inherit Tags.feTurbulence()
    //     interface OptionKeys    
    // [<PartasProxyImport("filter", "Motion", "solid-motionone")>]
    // type filter() =
    //     inherit Tags.filter()
    //     interface OptionKeys    
    // [<PartasProxyImport("foreignObject", "Motion", "solid-motionone")>]
    // type foreignObject() =
    //     inherit Tags.foreignObject()
    //     interface OptionKeys    
    // [<PartasProxyImport("g", "Motion", "solid-motionone")>]
    // type g() =
    //     inherit Tags.g()
    //     interface OptionKeys    
    // [<PartasProxyImport("image", "Motion", "solid-motionone")>]
    // type image() =
    //     inherit Tags.image()
    //     interface OptionKeys    
    // [<PartasProxyImport("line", "Motion", "solid-motionone")>]
    // type line() =
    //     inherit Tags.line()
    //     interface OptionKeys    
    // [<PartasProxyImport("linearGradient", "Motion", "solid-motionone")>]
    // type linearGradient() =
    //     inherit Tags.linearGradient()
    //     interface OptionKeys    
    // [<PartasProxyImport("marker", "Motion", "solid-motionone")>]
    // type marker() =
    //     inherit Tags.marker()
    //     interface OptionKeys    
    // [<PartasProxyImport("mask", "Motion", "solid-motionone")>]
    // type mask() =
    //     inherit Tags.mask()
    //     interface OptionKeys    
    // [<PartasProxyImport("metadata", "Motion", "solid-motionone")>]
    // type metadata() =
    //     inherit Tags.metadata()
    //     interface OptionKeys    
    // [<PartasProxyImport("mpath", "Motion", "solid-motionone")>]
    // type mpath() =
    //     inherit Tags.mpath()
    //     interface OptionKeys    
    // [<PartasProxyImport("path", "Motion", "solid-motionone")>]
    // type path() =
    //     inherit Tags.path()
    //     interface OptionKeys    
    // [<PartasProxyImport("pattern", "Motion", "solid-motionone")>]
    // type pattern() =
    //     inherit Tags.pattern()
    //     interface OptionKeys    
    // [<PartasProxyImport("polygon", "Motion", "solid-motionone")>]
    // type polygon() =
    //     inherit Tags.polygon()
    //     interface OptionKeys    
    // [<PartasProxyImport("polyline", "Motion", "solid-motionone")>]
    // type polyline() =
    //     inherit Tags.polyline()
    //     interface OptionKeys    
    // [<PartasProxyImport("radialGradient", "Motion", "solid-motionone")>]
    // type radialGradient() =
    //     inherit Tags.radialGradient()
    //     interface OptionKeys    
    // [<PartasProxyImport("rect", "Motion", "solid-motionone")>]
    // type rect() =
    //     inherit Tags.rect()
    //     interface OptionKeys    
    // [<PartasProxyImport("script", "Motion", "solid-motionone")>]
    // type script() =
    //     inherit Tags.script()
    //     interface OptionKeys    
    // [<PartasProxyImport("set", "Motion", "solid-motionone")>]
    // type set() =
    //     inherit Tags.set()
    //     interface OptionKeys    
    // [<PartasProxyImport("stop", "Motion", "solid-motionone")>]
    // type stop() =
    //     inherit Tags.stop()
    //     interface OptionKeys    
    // [<PartasProxyImport("style", "Motion", "solid-motionone")>]
    // type style() =
    //     inherit Tags.style()
    //     interface OptionKeys    
    // [<PartasProxyImport("svg", "Motion", "solid-motionone")>]
    // type svg() =
    //     inherit Tags.svg()
    //     interface OptionKeys    
    // [<PartasProxyImport("switch", "Motion", "solid-motionone")>]
    // type switch() =
    //     inherit Tags.switch()
    //     interface OptionKeys    
    // [<PartasProxyImport("symbol", "Motion", "solid-motionone")>]
    // type symbol() =
    //     inherit Tags.symbol()
    //     interface OptionKeys    
    // [<PartasProxyImport("text", "Motion", "solid-motionone")>]
    // type text() =
    //     inherit Tags.text()
    //     interface OptionKeys    
    // [<PartasProxyImport("textPath", "Motion", "solid-motionone")>]
    // type textPath() =
    //     inherit Tags.textPath()
    //     interface OptionKeys    
    // [<PartasProxyImport("title", "Motion", "solid-motionone")>]
    // type title() =
    //     inherit Tags.title()
    //     interface OptionKeys    
    // [<PartasProxyImport("tspan", "Motion", "solid-motionone")>]
    // type tspan() =
    //     inherit Tags.tspan()
    //     interface OptionKeys    
    // [<PartasProxyImport("use", "Motion", "solid-motionone")>]
    // type use() =
    //     inherit Tags.use()
    //     interface OptionKeys    
    // [<PartasProxyImport("view", "Motion", "solid-motionone")>]
    // type view() =
    //     inherit Tags.view()
    //     interface OptionKeys    