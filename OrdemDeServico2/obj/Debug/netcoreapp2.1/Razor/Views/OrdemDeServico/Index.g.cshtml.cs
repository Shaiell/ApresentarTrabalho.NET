#pragma checksum "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce99a70c48aa711f7d970d7b3d0ce3441752db22"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce99a70c48aa711f7d970d7b3d0ce3441752db22", @"/Views/OrdemDeServico/Index.cshtml")]
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
            BeginContext(246, 7627, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05586a6dc915435e8311027d18b79434", async() => {
                BeginContext(252, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(271, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a58b8917a4f14c06b91b33eb68113f20", async() => {
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
                BeginContext(331, 856, true);
                WriteLiteral(@"
    </p>
    </br>
    </br>
    <h4>OS para aprovação:</h4>
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
#line 51 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1244, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1317, 42, false);
#line 55 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrdemId));

#line default
#line hidden
                EndContext();
                BeginContext(1359, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1439, 47, false);
#line 58 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1486, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1566, 59, false);
#line 61 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Processador.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1625, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1705, 55, false);
#line 64 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Memoria.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1760, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1840, 56, false);
#line 67 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlacaMae.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1896, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1976, 58, false);
#line 70 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlacaVideo.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2034, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2114, 50, false);
#line 73 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Hd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2164, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2244, 51, false);
#line 76 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ssd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2295, 54, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
                EndContext();
#line 80 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2364, 1110, true);
                WriteLiteral(@"        </tbody>
    </table>
    </br>
    </br>
    <h4>OS Aprovadas:</h4>
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
#line 126 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
             foreach (var item in liberadas)
            {

#line default
#line hidden
                BeginContext(3535, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3608, 42, false);
#line 130 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrdemId));

#line default
#line hidden
                EndContext();
                BeginContext(3650, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3730, 47, false);
#line 133 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(3777, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3857, 51, false);
#line 136 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Funcionario.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(3908, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3988, 59, false);
#line 139 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Processador.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4047, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4127, 55, false);
#line 142 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Memoria.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4182, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4262, 56, false);
#line 145 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlacaMae.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4318, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4398, 58, false);
#line 148 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlacaVideo.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4456, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4536, 50, false);
#line 151 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Hd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4586, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4666, 51, false);
#line 154 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ssd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4717, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4797, 49, false);
#line 157 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.InicioProducao));

#line default
#line hidden
                EndContext();
                BeginContext(4846, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4926, 50, false);
#line 160 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TerminoProducao));

#line default
#line hidden
                EndContext();
                BeginContext(4976, 54, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
                EndContext();
#line 164 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(5045, 1201, true);
                WriteLiteral(@"        </tbody>
    </table>
    <table>
        </br>
        </br>
        <h4>OS Negada:</h4>
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
                WriteLiteral("  </th>\r\n                    <th>\r\n                        Data de impedimento\r\n                    </th>\r\n\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 209 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                 foreach (var item in reprovadas)
                {

#line default
#line hidden
                BeginContext(6316, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6401, 42, false);
#line 213 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrdemId));

#line default
#line hidden
                EndContext();
                BeginContext(6443, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6535, 47, false);
#line 216 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6582, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6674, 51, false);
#line 219 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Funcionario.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6725, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6817, 59, false);
#line 222 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Processador.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(6876, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6968, 55, false);
#line 225 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Memoria.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7023, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7115, 56, false);
#line 228 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PlacaMae.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7171, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7263, 58, false);
#line 231 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PlacaVideo.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7321, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7413, 50, false);
#line 234 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Hd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7463, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7555, 51, false);
#line 237 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Ssd.Produto.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(7606, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7698, 43, false);
#line 240 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Rejeicao));

#line default
#line hidden
                EndContext();
                BeginContext(7741, 62, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
                EndContext();
#line 244 "C:\Users\jclri\Desktop\C#\OrdemDeServico2\OrdemDeServico2\Views\OrdemDeServico\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(7822, 44, true);
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
            BeginContext(7873, 11, true);
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
