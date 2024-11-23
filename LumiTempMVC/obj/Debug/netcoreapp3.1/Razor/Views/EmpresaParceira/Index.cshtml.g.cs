#pragma checksum "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "211f8446818687d43c2c018645991b69ea73c134de45c526ce187c8ff049c751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpresaParceira_Index), @"mvc.1.0.view", @"/Views/EmpresaParceira/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"211f8446818687d43c2c018645991b69ea73c134de45c526ce187c8ff049c751", @"/Views/EmpresaParceira/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmpresaParceira_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmpresaParceiraViewModel>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
  
    ViewData["Title"] = "Empresa Parceira"; // Define o título da página

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "211f8446818687d43c2c018645991b69ea73c134de45c526ce187c8ff049c7513624", async() => {
                WriteLiteral(@"


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

        <table class=""table table-responsive""> <!-- Tabela para exibir as empresas parceiras -->
            <thead>
                <tr>
                    <th>Ação</th>
                    <th>Código da Empresa</th>
                    <th>Nome da Empresa</th>
                    <th>CEP da Empresa</th>
                    <th>Logradouro da Empresa</th>
                    <th>Número da Empresa</th>
                    <th>Complemento da Empresa</th>
      ");
                WriteLiteral(@"              <th>Bairro da Empresa</th>
                    <th>Cidade da Empresa</th>
                    <th>Estado da Empresa</th>
                    <th>CNPJ da Empresa</th>
                    <th>Telefone para Contato</th>
                    <th>ID do Usuário Relacionado à Empresa</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 41 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                 if (Model != null && Model.Count > 0) // Verifica se existem empresas cadastradas
                {
                    foreach (var empresa in Model) // Itera sobre a lista de empresas
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1849, "\"", 1892, 2);
                WriteAttributeValue("", 1856, "/EmpresaParceira/Edit?id=", 1856, 25, true);
                WriteAttributeValue("", 1881, 
#nullable restore
#line 47 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                                                   empresa.id

#line default
#line hidden
#nullable disable
                , 1881, 11, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning\">Editar</a> <!-- Botão para editar a empresa -->\r\n                                <a href=\"javascript:void(0);\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2028, "\"", 2072, 3);
                WriteAttributeValue("", 2038, "apagarEmpresaParceira(", 2038, 22, true);
                WriteAttributeValue("", 2060, 
#nullable restore
#line 48 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                                                                              empresa.id

#line default
#line hidden
#nullable disable
                , 2060, 11, false);
                WriteAttributeValue("", 2071, ")", 2071, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a> <!-- Botão para apagar a empresa -->\r\n                            </td>\r\n                            <td>");
                Write(
#nullable restore
#line 50 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.id

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Código da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 51 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.nm_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Nome da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 52 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.cep_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- CEP da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 53 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.log_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Logradouro da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 54 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.num_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Numero da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 55 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.compl_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Complemento da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 56 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.bairro_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Bairro da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 57 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.cidade_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Cidade da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 58 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.estado_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Estado da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 59 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.cnpj_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- CNPJ da empresa -->\r\n                            <td>");
                Write(
#nullable restore
#line 60 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.telf_cont_empr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Telefone para contato -->\r\n                            <td>");
                Write(
#nullable restore
#line 61 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                 empresa.id_func

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- ID do usuário associado -->\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                    }
                }
                else // Se não houver empresas cadastradas
                {

#line default
#line hidden
#nullable disable

                WriteLiteral("                    <tr>\r\n                        <td colspan=\"7\" class=\"text-center\">Nenhuma Empresa Cadastrada.</td> <!-- Mensagem informativa -->\r\n                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

                WriteLiteral(@"            </tbody>
        </table>
        <script>
            function apagarEmpresaParceira(id) {
                if (confirm('Confirma a exclusão do registro?'))
                    location.href = 'EmpresaParceira/Delete?id=' + id;
            }

            function extrairDados() {
                window.location.href = '");
                Write(
#nullable restore
#line 80 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\EmpresaParceira\Index.cshtml"
                                         Url.Action("ExtrairDados", "EmpresaParceira")

#line default
#line hidden
#nullable disable
                );
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
