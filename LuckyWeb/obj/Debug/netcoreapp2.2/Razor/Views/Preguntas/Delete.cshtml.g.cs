#pragma checksum "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57dcfdc759220e15033baa35c8c2428a34f299b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Preguntas_Delete), @"mvc.1.0.view", @"/Views/Preguntas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Preguntas/Delete.cshtml", typeof(AspNetCore.Views_Preguntas_Delete))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\_ViewImports.cshtml"
using LuckyWeb;

#line default
#line hidden
#line 2 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\_ViewImports.cshtml"
using LuckyWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57dcfdc759220e15033baa35c8c2428a34f299b", @"/Views/Preguntas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2009cf40c66a5807a5378bee2b64f387c429b38d", @"/Views/_ViewImports.cshtml")]
    public class Views_Preguntas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LuckyWeb.Models.Pregunta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 178, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Pregunta</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(256, 45, false);
#line 15 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta1));

#line default
#line hidden
            EndContext();
            BeginContext(301, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(365, 41, false);
#line 18 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta1));

#line default
#line hidden
            EndContext();
            BeginContext(406, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(469, 45, false);
#line 21 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta2));

#line default
#line hidden
            EndContext();
            BeginContext(514, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(578, 41, false);
#line 24 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta2));

#line default
#line hidden
            EndContext();
            BeginContext(619, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(682, 45, false);
#line 27 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta3));

#line default
#line hidden
            EndContext();
            BeginContext(727, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(791, 41, false);
#line 30 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta3));

#line default
#line hidden
            EndContext();
            BeginContext(832, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(895, 45, false);
#line 33 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta4));

#line default
#line hidden
            EndContext();
            BeginContext(940, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1004, 41, false);
#line 36 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta4));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1108, 45, false);
#line 39 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta5));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1217, 41, false);
#line 42 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta5));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1321, 45, false);
#line 45 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta6));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1430, 41, false);
#line 48 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta6));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1534, 45, false);
#line 51 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta7));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1643, 41, false);
#line 54 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta7));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1747, 45, false);
#line 57 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta8));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1856, 41, false);
#line 60 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta8));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1960, 45, false);
#line 63 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta9));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2069, 41, false);
#line 66 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta9));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2173, 46, false);
#line 69 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pregunta10));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2283, 42, false);
#line 72 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pregunta10));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2363, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57dcfdc759220e15033baa35c8c2428a34f299b13095", async() => {
                BeginContext(2389, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2399, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c57dcfdc759220e15033baa35c8c2428a34f299b13488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "E:\Proyectos 2.0\LuckyWeb\LuckyWeb\Views\Preguntas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IDpreguntas);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2444, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2527, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57dcfdc759220e15033baa35c8c2428a34f299b15388", async() => {
                    BeginContext(2549, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2565, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2578, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LuckyWeb.Models.Pregunta> Html { get; private set; }
    }
}
#pragma warning restore 1591
