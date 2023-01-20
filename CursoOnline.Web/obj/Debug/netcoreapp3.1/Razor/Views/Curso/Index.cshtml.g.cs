#pragma checksum "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81abdee4a3fb8899b3e24ac642dd455cb2cf4f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\_ViewImports.cshtml"
using CursoOnline.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\_ViewImports.cshtml"
using CursoOnline.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
using CursoOnline.Dominio.Cursos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
using CursoOnline.Web.Util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81abdee4a3fb8899b3e24ac642dd455cb2cf4f6", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0d8200179469d3ff6fec63422201671018f588", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CursoOnline.Web.Util.PaginatedList<CursoParaListagemDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
  
    ViewData["Title"] = "Listagem de cursos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""pad-wrapper"">

    <div class=""row"">
        <div class=""col-md-12"">
            <a href=""/"" class=""btn"">Voltar</a>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <a href=""/Curso/Novo"" class=""btn btn-primary"">Novo</a>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Carga Horária</th>
                        <th>Publico Alvo</th>
                        <th>Valor</th>
                    </tr>
                </thead>
");
#nullable restore
#line 32 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                 if ((Model?.Count ?? 0) > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                    ");
#nullable restore
#line 42 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                               Write(item.CargaHoraria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                    ");
#nullable restore
#line 45 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                               Write(item.PublicoAlvo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                    ");
#nullable restore
#line 48 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                               Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1816, "\"", 1845, 2);
            WriteAttributeValue("", 1823, "/Curso/Editar/", 1823, 14, true);
#nullable restore
#line 51 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1837, item.Id, 1837, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n");
#nullable restore
#line 56 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
              
                var prevDisabled = !(Model?.HasPreviousPage ?? false) ? "disabled" : "";
                var nextDisabled = !(Model?.HasNextPage ?? false) ? "disabled" : "";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b81abdee4a3fb8899b3e24ac642dd455cb2cf4f69336", async() => {
                WriteLiteral("\r\n                Anterior\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                    WriteLiteral((Model?.PageIndex ?? 1) - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2381, "btn", 2381, 3, true);
            AddHtmlAttributeValue(" ", 2384, "btn-default", 2385, 12, true);
#nullable restore
#line 66 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
AddHtmlAttributeValue(" ", 2396, prevDisabled, 2397, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b81abdee4a3fb8899b3e24ac642dd455cb2cf4f612253", async() => {
                WriteLiteral("\r\n                Próximo\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
                    WriteLiteral((Model?.PageIndex ?? 0) + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2561, "btn", 2561, 3, true);
            AddHtmlAttributeValue(" ", 2564, "btn-default", 2565, 12, true);
#nullable restore
#line 71 "C:\Users\Daniel\Documents\Estudos\CSharp\TestesUnitarios\TDD com xUnit para C# .NET Core\CursoOnline.Web\Views\Curso\Index.cshtml"
AddHtmlAttributeValue(" ", 2576, nextDisabled, 2577, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CursoOnline.Web.Util.PaginatedList<CursoParaListagemDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
