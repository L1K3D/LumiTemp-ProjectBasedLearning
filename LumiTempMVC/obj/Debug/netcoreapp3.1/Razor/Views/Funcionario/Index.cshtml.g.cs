#pragma checksum "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b86b004af0b391d4590d29d56c6badd8fae4c5b93ab6b29e8dd956cd35bf8ef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Index), @"mvc.1.0.view", @"/Views/Funcionario/Index.cshtml")]
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
#line 1 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b86b004af0b391d4590d29d56c6badd8fae4c5b93ab6b29e8dd956cd35bf8ef1", @"/Views/Funcionario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FuncionarioViewModel>>
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
#line 2 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86b004af0b391d4590d29d56c6badd8fae4c5b93ab6b29e8dd956cd35bf8ef13558", async() => {
                WriteLiteral(@"
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

        <table class=""table table-responsive"">
            <!-- Tabela para exibir os funcionários -->
            <thead>
                <tr>
                    <th>Ação</th>
                    <th>Número do Usuário</th>
                    <th>Login do Usuário</th>
                    <th>Data de Cadastro do Usuário</th>
                    <th>Imagem Funcionário</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                 if (Model != null && Model.Count > 0) // Verifica se existem funcionários cadastrados
                {
                    foreach (var funcionario in Model) // Itera sobre a lista de funcionários
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1421, "\"", 1464, 2);
                WriteAttributeValue("", 1428, "/Funcionario/Edit?id=", 1428, 21, true);
                WriteAttributeValue("", 1449, 
#nullable restore
#line 36 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                                               funcionario.id

#line default
#line hidden
#nullable disable
                , 1449, 15, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning\">Editar</a> <!-- Botão para editar o funcionário -->\r\n                                <a href=\"javascript:void(0);\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1604, "\"", 1648, 3);
                WriteAttributeValue("", 1614, "apagarFuncionario(", 1614, 18, true);
                WriteAttributeValue("", 1632, 
#nullable restore
#line 37 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                                                                          funcionario.id

#line default
#line hidden
#nullable disable
                , 1632, 15, false);
                WriteAttributeValue("", 1647, ")", 1647, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a> <!-- Botão para apagar o funcionário -->\r\n                            </td>\r\n                            <td>");
                Write(
#nullable restore
#line 39 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                 funcionario.id

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Número do usuário -->\r\n                            <td>");
                Write(
#nullable restore
#line 40 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                 funcionario.login_func

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Login do usuário -->\r\n                            <td>");
                Write(
#nullable restore
#line 41 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                 funcionario.dt_cadr

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td> <!-- Data de cadastro do usuário -->\r\n                            <td>\r\n                                <img id=\"imgPreview\"");
                BeginWriteAttribute("src", " src=\"", 2112, "\"", 2168, 2);
                WriteAttributeValue("", 2118, "data:image/jpeg;base64,", 2118, 23, true);
                WriteAttributeValue("", 2141, 
#nullable restore
#line 43 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                                                                  funcionario.ImagemEmBase64

#line default
#line hidden
#nullable disable
                , 2141, 27, false);
                EndWriteAttribute();
                WriteLiteral("class=\"img-responsive\" width=\"50\">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                    }
                }
                else // Se não houver funcionários cadastrados
                {

#line default
#line hidden
#nullable disable

                WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"text-center\">Nenhum Funcionário Cadastrado.</td> <!-- Mensagem informativa -->\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
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
                Write(
#nullable restore
#line 63 "C:\Users\enzob\Desktop\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Index.cshtml"
                                         Url.Action("ExtrairDados", "Funcionario")

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
            WriteLiteral("\r\n");
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
