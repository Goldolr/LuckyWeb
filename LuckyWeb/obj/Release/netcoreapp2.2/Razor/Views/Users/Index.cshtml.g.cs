#pragma checksum "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0ff4a78b6760a57d45fae51c04ed55fd62b610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0ff4a78b6760a57d45fae51c04ed55fd62b610", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2009cf40c66a5807a5378bee2b64f387c429b38d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LuckyWeb.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn purple-gradient font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn aqua-gradient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn blue-gradient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn peach-gradient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteConfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:wheat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(137, 6668, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b6108778", async() => {
                BeginContext(174, 447, true);
                WriteLiteral(@"
    <div class=""table-responsive-lg text-nowrap"">
        <table class=""table table-striped table-dark"">
            <thead class=""white-text"">
                <tr>
                    <td colspan=""6"">
                        <h1 class=""text-center"">
                            <strong>Usuarios</strong>
                        </h1>
                    </td>
                </tr>
            </thead>
        </table>
    </div>
");
                EndContext();
#line 22 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
     if (User.IsInRole("Administrador") || User.IsInRole("Supervisor"))
    {

#line default
#line hidden
                BeginContext(701, 25, true);
                WriteLiteral("        <p>\r\n            ");
                EndContext();
                BeginContext(726, 144, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b6109937", async() => {
                    BeginContext(794, 72, true);
                    WriteLiteral("<i class=\"fas fa-paw ml-2\" aria-hidden=\"true\"></i> Agregar nuevo usuario");
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
                BeginContext(870, 16, true);
                WriteLiteral("\r\n        </p>\r\n");
                EndContext();
#line 27 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(893, 235, true);
                WriteLiteral("    <div class=\"table-responsive-lg text-nowrap\">\r\n        <table class=\"table table-striped table-hover table-dark\">\r\n            <thead class=\"text-uppercase\">\r\n                <tr>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1129, 42, false);
#line 33 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(1171, 29, true);
                WriteLiteral("\r\n                    </th>\r\n");
                EndContext();
                BeginContext(1336, 50, true);
                WriteLiteral("                    <th>\r\n                        ");
                EndContext();
                BeginContext(1387, 42, false);
#line 39 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
                EndContext();
                BeginContext(1429, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1509, 42, false);
#line 42 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
                EndContext();
                BeginContext(1551, 29, true);
                WriteLiteral("\r\n                    </th>\r\n");
                EndContext();
                BeginContext(1719, 50, true);
                WriteLiteral("                    <th>\r\n                        ");
                EndContext();
                BeginContext(1770, 51, false);
#line 48 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
                EndContext();
                BeginContext(1821, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1900, 421, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b61014079", async() => {
                    BeginContext(1961, 353, true);
                    WriteLiteral(@"
                            <div class=""row"">
                                <input type=""text"" name=""Cedula"" placeholder=""Buscar por número de cédula"" style=""width:200px;margin-left:15px"">
                                <input type=""submit"" style=""margin-left:25px;"" value=""Buscar"" />
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2321, 118, true);
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"text-monospace\">\r\n");
                EndContext();
#line 61 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                  int cont = 0; var modal = "modal"; var modal1 = "";
                    

#line default
#line hidden
#line 62 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                     foreach (var item in Model)
                    {
                        cont++;
                        modal1 = modal + cont;

#line default
#line hidden
                BeginContext(2664, 96, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2761, 41, false);
#line 68 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(2802, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2804, 43, false);
#line 68 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
                EndContext();
                BeginContext(2847, 37, true);
                WriteLiteral("\r\n                            </td>\r\n");
                EndContext();
                BeginContext(3043, 66, true);
                WriteLiteral("                            <td>\r\n                                ");
                EndContext();
                BeginContext(3110, 41, false);
#line 74 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
                EndContext();
                BeginContext(3151, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(3255, 41, false);
#line 77 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
                EndContext();
                BeginContext(3296, 37, true);
                WriteLiteral("\r\n                            </td>\r\n");
                EndContext();
                BeginContext(3495, 66, true);
                WriteLiteral("                            <td>\r\n                                ");
                EndContext();
                BeginContext(3562, 50, false);
#line 83 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
                EndContext();
                BeginContext(3612, 71, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
                EndContext();
#line 86 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                 if (User.IsInRole("Administrador") || User.IsInRole("Supervisor"))
                                {

#line default
#line hidden
                BeginContext(3819, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(3855, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b61020337", async() => {
                    BeginContext(3930, 58, true);
                    WriteLiteral("<i class=\"fas fa-edit ml-2\" aria-hidden=\"true\"></i> Editar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 88 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                                     WriteLiteral(item.IdUser);

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
                BeginContext(3992, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4030, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b61022997", async() => {
                    BeginContext(4108, 64, true);
                    WriteLiteral("<i class=\"fas fa-file-alt ml-2\" aria-hidden=\"true\"></i> Detalles");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 89 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                                        WriteLiteral(item.IdUser);

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
                BeginContext(4176, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(4214, 156, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b61025666", async() => {
                    BeginContext(4301, 65, true);
                    WriteLiteral("<i class=\"fas fa-trash-alt ml-2\" aria-hidden=\"true\"></i> Eliminar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                BeginWriteTagHelperAttribute();
                WriteLiteral("#");
#line 90 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                                                             Write(modal1);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-target", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4370, 61, true);
                WriteLiteral("\r\n                                    <div class=\"modal fade\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4431, "\"", 4443, 1);
#line 91 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
WriteAttributeValue("", 4436, modal1, 4436, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4444, 1086, true);
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header text-center"">
                                                    <h4 class=""modal-title w-100 font-weight-bold black-text"">Eliminar</h4>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    <h5 style=""color:black"">Seguro que desea eliminar el usuartio con</h5>
                        ");
                WriteLiteral("                            <h5 style=\"color:black\">cédula Nº ");
                EndContext();
                BeginContext(5531, 11, false);
#line 102 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                                 Write(item.Cedula);

#line default
#line hidden
                EndContext();
                BeginContext(5542, 358, true);
                WriteLiteral(@"</h5>
                                                </div>
                                                <div class=""modal-footer d-flex justify-content-center"">
                                                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cancelar</button>
                                                    ");
                EndContext();
                BeginContext(5900, 267, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b61030330", async() => {
                    BeginContext(5986, 174, true);
                    WriteLiteral("\r\n                                                        <button type=\"submit\" class=\"btn btn-success\">Aceptar</button>\r\n                                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 106 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                                                                WriteLiteral(item.IdUser);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6167, 202, true);
                WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
                EndContext();
#line 113 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(6477, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(6513, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0ff4a78b6760a57d45fae51c04ed55fd62b61034076", async() => {
                    BeginContext(6589, 8, true);
                    WriteLiteral("Detalles");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 116 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                                                                      WriteLiteral(item.IdUser);

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
                BeginContext(6601, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 117 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(6638, 66, true);
                WriteLiteral("                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 120 "D:\Repositorios\LuckyWeb\LuckyWeb\Views\Users\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(6746, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6805, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LuckyWeb.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
