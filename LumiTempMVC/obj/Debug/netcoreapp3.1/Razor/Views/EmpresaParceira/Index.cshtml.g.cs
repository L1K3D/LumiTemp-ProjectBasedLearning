#pragma checksum "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74bcba4d5243c3e75804fb00cb4c33cd9f2dc3013584e0d29d0ab0debccc7a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpresaParceira_Index), @"mvc.1.0.view", @"/Views/EmpresaParceira/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"74bcba4d5243c3e75804fb00cb4c33cd9f2dc3013584e0d29d0ab0debccc7a75", @"/Views/EmpresaParceira/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmpresaParceira_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmpresaParceiraViewModel>>
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
#line 2 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
  
    ViewData["Title"] = "Empresa Parceira"; // Define o título da página

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74bcba4d5243c3e75804fb00cb4c33cd9f2dc3013584e0d29d0ab0debccc7a754708", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" /> <!-- Define a codificação de caracteres -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" /> <!-- Responsividade para dispositivos móveis -->
    <title>Tela de Empresa Parceira</title> <!-- Título da página -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74bcba4d5243c3e75804fb00cb4c33cd9f2dc3013584e0d29d0ab0debccc7a755271", async() => {
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
                WriteLiteral(@" <!-- Link para o CSS -->
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script> <!-- Importa a biblioteca jQuery -->
    <script>
        // Função para extrair dados
        function extrairDados() {
            window.location.href = '");
#nullable restore
#line 17 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                               Write(Url.Action("ExtrairDados", "EmpresaParceira"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'; // Redireciona para a ação de extração de dados
        }

        // Função para apagar uma empresa parceira
        function apagarEmpresaParceira(id) {
            if (confirm('Confirma a exclusão do registro?')) { // Confirmação da exclusão
                window.location.href = '");
#nullable restore
#line 23 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                   Write(Url.Action("Delete", "EmpresaParceira"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?id=\' + id; // Redireciona para a ação de deletar\r\n            }\r\n        }\r\n    </script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74bcba4d5243c3e75804fb00cb4c33cd9f2dc3013584e0d29d0ab0debccc7a758460", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""menu-opcoes"">
            <ul>
                <li><a href=""Home"">Home</a></li>
                <li><a href=""Sensor"">Cadastro de Sensores</a></li>
                <li><a href=""Funcionario"">Cadastro de Funcionários</a></li>
                <li><a href=""Dashboard"">Dashboard</a></li>
                <li><a href=""Sobre"">Sobre</a></li>
            </ul>
        </nav>
    </header>

    <main>
        <div>
            <h1>Empresas Parceiras</h1> <!-- Título principal da página -->
        </div>

        <div>
            <a href=""/EmpresaParceira/create"" class=""btn btn-primary"">Novo Registro</a> <!-- Botão para criar um novo registro -->
            <a href=""/home"" class=""btn btn-light"">Página Inicial</a> <!-- Botão para voltar à página inicial -->
            <button class=""btn btn-success"" onclick=""extrairDados()"">Extrair Dados</button> <!-- Botão para extrair dados -->
        </div>
        <br />

        <table class=""table table-responsive""> <!-- ");
                WriteLiteral(@"Tabela para exibir as empresas parceiras -->
            <thead>
                <tr>
                    <th>Ação</th>
                    <th>Código da Empresa</th>
                    <th>Nome da Empresa</th>
                    <th>CEP da Empresa</th>
                    <th>CNPJ da Empresa</th>
                    <th>Telefone para Contato</th>
                    <th>ID do Usuário Relacionado à Empresa</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 67 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                 if (Model != null && Model.Count > 0) // Verifica se existem empresas cadastradas
                {
                    foreach (var empresa in Model) // Itera sobre a lista de empresas
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3087, "\"", 3135, 2);
                WriteAttributeValue("", 3094, "/EmpresaParceira/Edit?id=", 3094, 25, true);
#nullable restore
#line 73 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
WriteAttributeValue("", 3119, empresa.cd_empr, 3119, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning\">Editar</a> <!-- Botão para editar a empresa -->\r\n                                <a href=\"javascript:void(0);\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3271, "\"", 3320, 3);
                WriteAttributeValue("", 3281, "apagarEmpresaParceira(", 3281, 22, true);
#nullable restore
#line 74 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
WriteAttributeValue("", 3303, empresa.cd_empr, 3303, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3319, ")", 3319, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a> <!-- Botão para apagar a empresa -->\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                           Write(empresa.cd_empr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Código da empresa -->\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                           Write(empresa.nm_empr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Nome da empresa -->\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                           Write(empresa.cep_empr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- CEP da empresa -->\r\n                            <td>");
#nullable restore
#line 79 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                           Write(empresa.cnpj_empr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- CNPJ da empresa -->\r\n                            <td>");
#nullable restore
#line 80 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                           Write(empresa.telf_cont_empr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Telefone para contato -->\r\n                            <td>");
#nullable restore
#line 81 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                           Write(empresa.fk_cd_func);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- ID do usuário associado -->\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                    }
                }
                else // Se não houver empresas cadastradas
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"7\" class=\"text-center\">Nenhuma Empresa Cadastrada.</td> <!-- Mensagem informativa -->\r\n                    </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </main>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmpresaParceiraViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
