#pragma checksum "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a28650bf93149c62c7d1489d1deb9161d11d1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Preguntas_Index), @"mvc.1.0.view", @"/Views/Preguntas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Preguntas/Index.cshtml", typeof(AspNetCore.Views_Preguntas_Index))]
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
#line 1 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\_ViewImports.cshtml"
using LuckyWeb;

#line default
#line hidden
#line 2 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\_ViewImports.cshtml"
using LuckyWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a28650bf93149c62c7d1489d1deb9161d11d1e", @"/Views/Preguntas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2009cf40c66a5807a5378bee2b64f387c429b38d", @"/Views/_ViewImports.cshtml")]
    public class Views_Preguntas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LuckyWeb.Models.Pregunta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-rounded btn-sm my-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#6B7A8F"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 5978, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a28650bf93149c62c7d1489d1deb9161d11d1e5143", async() => {
                BeginContext(175, 108, true);
                WriteLiteral("\r\n    <div class=\"card\">\r\n        <div id=\"table\" class=\"table-editable\">\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(283, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a28650bf93149c62c7d1489d1deb9161d11d1e5644", async() => {
                    BeginContext(353, 22, true);
                    WriteLiteral("Ingrese sus respuestas");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                BeginContext(379, 283, true);
                WriteLiteral(@"
            </p>
            <div>
                <table class=""table table-bordered table-responsive-md table-striped text-center"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>
                                ");
                EndContext();
                BeginContext(663, 51, false);
#line 18 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.EstadoPreguntas));

#line default
#line hidden
                EndContext();
                BeginContext(714, 103, true);
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
                EndContext();
                BeginContext(818, 57, false);
#line 21 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FK_Respuesta1Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(875, 103, true);
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
                EndContext();
                BeginContext(979, 57, false);
#line 24 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FK_Respuesta2Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(1036, 103, true);
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
                EndContext();
                BeginContext(1140, 57, false);
#line 27 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FK_Respuesta3Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(1197, 103, true);
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
                EndContext();
                BeginContext(1301, 57, false);
#line 30 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FK_Respuesta4Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(1358, 127, true);
                WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
                EndContext();
#line 35 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
                BeginContext(1566, 108, true);
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(1675, 50, false);
#line 39 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EstadoPreguntas));

#line default
#line hidden
                EndContext();
                BeginContext(1725, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(1841, 66, false);
#line 42 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FK_Respuesta1Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(1907, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2023, 66, false);
#line 45 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FK_Respuesta2Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(2089, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2205, 66, false);
#line 48 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FK_Respuesta3Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(2271, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2387, 66, false);
#line 51 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FK_Respuesta4Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(2453, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2569, 66, false);
#line 54 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FK_Respuesta5Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(2635, 76, true);
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 57 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2738, 300, true);
                WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <table class=""table table-bordered table-responsive-md table-striped text-center"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>
                            ");
                EndContext();
                BeginContext(3039, 51, false);
#line 65 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.EstadoPreguntas));

#line default
#line hidden
                EndContext();
                BeginContext(3090, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3182, 57, false);
#line 68 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FK_Respuesta6Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(3239, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3331, 57, false);
#line 71 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FK_Respuesta7Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(3388, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3480, 57, false);
#line 74 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FK_Respuesta8Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(3537, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3629, 57, false);
#line 77 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FK_Respuesta9Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(3686, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3778, 58, false);
#line 80 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FK_Respuesta10Pregunta));

#line default
#line hidden
                EndContext();
                BeginContext(3836, 146, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 86 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(4055, 64, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n");
                EndContext();
#line 90 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                                   if (item.EstadoPreguntas == true)
                                    {

#line default
#line hidden
                BeginContext(4228, 61, true);
                WriteLiteral("                                        <span>Aprobo</span>\r\n");
                EndContext();
#line 93 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(4409, 64, true);
                WriteLiteral("                                        <span>No aprobo</span>\r\n");
                EndContext();
#line 97 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                                    }

                                

#line default
#line hidden
                BeginContext(4549, 101, true);
                WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4651, 66, false);
#line 102 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FK_Respuesta6Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(4717, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4821, 66, false);
#line 105 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FK_Respuesta7Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(4887, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4991, 66, false);
#line 108 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FK_Respuesta8Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(5057, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5161, 66, false);
#line 111 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FK_Respuesta9Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(5227, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5331, 67, false);
#line 114 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FK_Respuesta10Pregunta.Respuesta));

#line default
#line hidden
                EndContext();
                BeginContext(5398, 311, true);
                WriteLiteral(@"
                            </td>
                        </tr>
                        <table class=""table table-bordered table-responsive-md table-striped text-center"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>");
                EndContext();
                BeginContext(5709, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a28650bf93149c62c7d1489d1deb9161d11d1e21381", async() => {
                    BeginContext(5763, 6, true);
                    WriteLiteral("Editar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 120 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                                                               WriteLiteral(item.IDpreguntas);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5773, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
                BeginContext(5820, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a28650bf93149c62c7d1489d1deb9161d11d1e23893", async() => {
                    BeginContext(5876, 8, true);
                    WriteLiteral("Eliminar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 121 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                                                                 WriteLiteral(item.IDpreguntas);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5888, 118, true);
                WriteLiteral("</th>\r\n                                </tr>\r\n                            </thead>\r\n                        </table>\r\n");
                EndContext();
#line 125 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Preguntas\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(6029, 78, true);
                WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LuckyWeb.Models.Pregunta>> Html { get; private set; }
    }
}
#pragma warning restore 1591