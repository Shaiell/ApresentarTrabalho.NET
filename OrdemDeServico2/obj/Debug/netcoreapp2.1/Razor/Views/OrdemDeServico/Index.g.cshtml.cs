#pragma checksum "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a4aa4a576be0632df47dfddb498e4f779458182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdemDeServico_Index), @"mvc.1.0.view", @"/Views/OrdemDeServico/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrdemDeServico/Index.cshtml", typeof(AspNetCore.Views_OrdemDeServico_Index))]
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
#line 1 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\_ViewImports.cshtml"
using OrdemDeServico2;

#line default
#line hidden
#line 2 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4aa4a576be0632df47dfddb498e4f779458182", @"/Views/OrdemDeServico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7214ba3b4f75d1526694bf56c2f85fb0b543aa", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdemDeServico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.OrdemDeServico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
  
    Layout = "~/Views/Shared/Layout1.cshtml";
    List<OrdemDeServico> liberadas = ViewBag.Aprovadas;
    List<OrdemDeServico> reprovadas = ViewBag.Reprovadas;

#line default
#line hidden
            BeginContext(215, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(246, 7237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3402320fa25c4df79d0a332f575be6cc", async() => {
                BeginContext(252, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(271, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa38cc0e46d4d2685a66e556ad3324d", async() => {
                    BeginContext(318, 9, true);
                    WriteLiteral("Cadastrar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(331, 834, true);
                WriteLiteral(@"
    </p>
    <h2>OS para aprovação:</h2>
    <table style=""margin-top:10px;margin-bottom:10px"" class=""table table-hover table-striped"">
        <thead>
            <tr>
                <th>
                    Numero OS
                </th>
                <th>
                    Solicitante
                </th>
                <th>
                    Processador
                </th>
                <th>
                    Memoria
                </th>
                <th>
                    Placa mãe
                </th>
                <th>
                    Placa de video
                </th>
                <th>
                    HD
                </th>
                <th>
                    SSD
                </th>

            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 49 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1222, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1283, 42, false);
#line 53 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrdemId));

#line default
#line hidden
                EndContext();
                BeginContext(1325, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1393, 47, false);
#line 56 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1440, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1508, 59, false);
#line 59 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Processador.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1567, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1635, 55, false);
#line 62 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Memoria.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1690, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1758, 56, false);
#line 65 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlacaMae.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1814, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1882, 58, false);
#line 68 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlacaVideo.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1940, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2008, 50, false);
#line 71 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2058, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2126, 51, false);
#line 74 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ssd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2177, 46, true);
                WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
                EndContext();
#line 78 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2238, 1110, true);
                WriteLiteral(@"        </tbody>
    </table>
    </br>
    </br>
    <h2>OS Aprovadas:</h2>
    <table style=""margin-top:10px;margin-bottom:10px"" class=""table table-hover table-striped"">
        <thead>
            <tr>
                <th>
                    Numero OS
                </th>
                <th>
                    Solicitante
                </th>
                <th>
                    Avaliador
                </th>
                <th>
                    Processador
                </th>
                <th>
                    Memoria
                </th>
                <th>
                    Placa mãe
                </th>
                <th>
                    Placa de video
                </th>
                <th>
                    HD
                </th>
                <th>
                    SSD
                </th>
                <th>
                    Data de inicio
                </th>
                <th>
                    Data de te");
                WriteLiteral("rmino\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 124 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
             foreach (var item in liberadas)
            {

#line default
#line hidden
                BeginContext(3409, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3470, 42, false);
#line 128 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrdemId));

#line default
#line hidden
                EndContext();
                BeginContext(3512, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3580, 47, false);
#line 131 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(3627, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3695, 51, false);
#line 134 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Funcionario.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(3746, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3814, 59, false);
#line 137 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Processador.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(3873, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3941, 55, false);
#line 140 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Memoria.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(3996, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(4064, 56, false);
#line 143 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlacaMae.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4120, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(4188, 58, false);
#line 146 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlacaVideo.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4246, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(4314, 50, false);
#line 149 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4364, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(4432, 51, false);
#line 152 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ssd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4483, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(4551, 49, false);
#line 155 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InicioProducao));

#line default
#line hidden
                EndContext();
                BeginContext(4600, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(4668, 50, false);
#line 158 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TerminoProducao));

#line default
#line hidden
                EndContext();
                BeginContext(4718, 46, true);
                WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
                EndContext();
#line 162 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(4779, 1205, true);
                WriteLiteral(@"        </tbody>
        </table>
    <table>
        </br>
        </br>
        <h2>OS Negada:</h2>
        <table style=""margin-top:10px;margin-bottom:10px"" class=""table table-hover table-striped"">
            <thead>
                <tr>
                    <th>
                        Numero OS
                    </th>
                    <th>
                        Solicitante
                    </th>
                    <th>
                        Avaliador
                    </th>
                    <th>
                        Processador
                    </th>
                    <th>
                        Memoria
                    </th>
                    <th>
                        Placa mãe
                    </th>
                    <th>
                        Placa de video
                    </th>
                    <th>
                        HD
                    </th>
                    <th>
                        SSD
              ");
                WriteLiteral("      </th>\r\n                    <th>\r\n                        Data de impedimento\r\n                    </th>\r\n\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 207 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                 foreach (var item in reprovadas)
                {

#line default
#line hidden
                BeginContext(6054, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6127, 42, false);
#line 211 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrdemId));

#line default
#line hidden
                EndContext();
                BeginContext(6169, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6249, 47, false);
#line 214 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6296, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6376, 51, false);
#line 217 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Funcionario.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6427, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6507, 59, false);
#line 220 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Processador.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6566, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6646, 55, false);
#line 223 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Memoria.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6701, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6781, 56, false);
#line 226 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlacaMae.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6837, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(6917, 58, false);
#line 229 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlacaVideo.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6975, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(7055, 50, false);
#line 232 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Hd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7105, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(7185, 51, false);
#line 235 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ssd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7236, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(7316, 43, false);
#line 238 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rejeicao));

#line default
#line hidden
                EndContext();
                BeginContext(7359, 54, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
                EndContext();
#line 242 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(7432, 44, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7483, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.OrdemDeServico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
