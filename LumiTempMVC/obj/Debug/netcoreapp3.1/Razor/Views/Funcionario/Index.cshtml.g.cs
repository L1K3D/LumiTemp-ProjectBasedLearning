#pragma checksum "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "acce19cc2862ff3bd00309cc4083e994f5f1357e44afc3c7f5d0d3ab6ff2a5c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Index), @"mvc.1.0.view", @"/Views/Funcionario/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"acce19cc2862ff3bd00309cc4083e994f5f1357e44afc3c7f5d0d3ab6ff2a5c9", @"/Views/Funcionario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FuncionarioViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/estilos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acce19cc2862ff3bd00309cc4083e994f5f1357e44afc3c7f5d0d3ab6ff2a5c94653", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" /> <!-- Define a codificação de caracteres -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" /> <!-- Responsividade para dispositivos móveis -->
    <title>Tela Funcionário</title> <!-- Título da página -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "acce19cc2862ff3bd00309cc4083e994f5f1357e44afc3c7f5d0d3ab6ff2a5c95208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <!-- Link para o CSS -->\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script> <!-- Importa a biblioteca jQuery -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acce19cc2862ff3bd00309cc4083e994f5f1357e44afc3c7f5d0d3ab6ff2a5c97257", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""menu-opcoes""> <!-- Cabeçalho com barra de opções -->
            <ul>
                <li><a href=""Home"">Home</a></li>
                <li><a href=""Sensor"">Cadastro de Sensores</a></li>
                <li><a href=""EmpresaParceira"">Cadastro de Empresas</a></li>
                <li><a href=""Dashboard"">Dashboard</a></li>
                <li><a href=""Sobre"">Sobre</a></li>
            </ul>
        </nav>
    </header>

    <main>
        <div>
            <h1>Funcionários</h1> <!-- Título principal da página -->
        </div>

        <div>
            <a href=""/funcionario/create"" class=""btn btn-primary"">Novo Registro</a> <!-- Botão para criar um novo registro -->
            <a href=""/home"" class=""btn btn-light"">Página Inicial</a> <!-- Botão para voltar à página inicial -->
            <button class=""btn btn-success"" onclick=""extrairDados()"">Extrair Dados</button> <!-- Botão para extrair dados -->
        </div>
        <br />

        <table class=""t");
                WriteLiteral(@"able table-responsive""> <!-- Tabela para exibir os funcionários -->
            <thead>
                <tr>
                    <th>Ação</th>
                    <th>Número do Usuário</th>
                    <th>Login do Usuário</th>
                    <th>Data de Cadastro do Usuário</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 51 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                 if (Model != null && Model.Count > 0) // Verifica se existem funcionários cadastrados
                {
                    foreach (var funcionario in Model) // Itera sobre a lista de funcionários
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2338, "\"", 2381, 2);
                WriteAttributeValue("", 2345, "/Funcionario/Edit?id=", 2345, 21, true);
#nullable restore
#line 57 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
WriteAttributeValue("", 2366, funcionario.id, 2366, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning\">Editar</a> <!-- Botão para editar o funcionário -->\r\n                                <a href=\"javascript:void(0);\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2521, "\"", 2565, 3);
                WriteAttributeValue("", 2531, "apagarFuncionario(", 2531, 18, true);
#nullable restore
#line 58 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
WriteAttributeValue("", 2549, funcionario.id, 2549, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2564, ")", 2564, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a> <!-- Botão para apagar o funcionário -->\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                           Write(funcionario.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Número do usuário -->\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                           Write(funcionario.login_func);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Login do usuário -->\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                           Write(funcionario.dt_cadr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Data de cadastro do usuário -->\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                    }
                }
                else // Se não houver funcionários cadastrados
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"text-center\">Nenhum Funcionário Cadastrado.</td> <!-- Mensagem informativa -->\r\n                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
        <script>
            function apagarFuncionario(id) {
                if (confirm('Confirma a exclusão do registro?'))
                    location.href = 'Funcionario/Delete?id=' + id;
            }

            function extrairDados() {
                window.location.href = '");
#nullable restore
#line 81 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                   Write(Url.Action("ExtrairDados", "Funcionario"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'; // Redireciona para a ação de extração de dados\r\n            }\r\n        </script>\r\n    </main>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FuncionarioViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
