#pragma checksum "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d62d87aab8f2e42b0e637fe1b22becc4f948d447bafd8adeff5cdd13579d74bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sensor_Index), @"mvc.1.0.view", @"/Views/Sensor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d62d87aab8f2e42b0e637fe1b22becc4f948d447bafd8adeff5cdd13579d74bb", @"/Views/Sensor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sensor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SensorViewModel>>
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
#line 2 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
  
    ViewData["Title"] = "Sensor"; // Define o título da página

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62d87aab8f2e42b0e637fe1b22becc4f948d447bafd8adeff5cdd13579d74bb4635", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" /> <!-- Define a codificação de caracteres -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" /> <!-- Configura a visualização em dispositivos móveis -->
    <title>Tela de Sensores</title> <!-- Título da aba do navegador -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d62d87aab8f2e42b0e637fe1b22becc4f948d447bafd8adeff5cdd13579d74bb5208", async() => {
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
                WriteLiteral(" <!-- Link para o arquivo CSS -->\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script> <!-- Inclui a biblioteca jQuery -->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62d87aab8f2e42b0e637fe1b22becc4f948d447bafd8adeff5cdd13579d74bb7264", async() => {
                WriteLiteral(@"
    <header>
        <!-- Cabeçalho com a barra de navegação -->
        <nav class=""menu-opcoes"">
            <ul>
                <li><a href=""Home"">Home</a></li>
                <li><a href=""EmpresaParceira"">Cadastro de Empresas</a></li>
                <li><a href=""Funcionario"">Cadastro de Funcionários</a></li>
                <li><a href=""Dashboard"">Dashboard</a></li>
                <li><a href=""Sobre"">Sobre</a></li>
            </ul>
        </nav>
    </header>

    <div>
        <h1>Sensores</h1> <!-- Título principal da seção -->
    </div>

    <div>
        <!-- Botões de ação para criar novo registro e extrair dados -->
        <a href=""/Sensor/create"" class=""btn btn-primary"">Novo Registro</a>
        <a href=""/home"" class=""btn btn-light"">Página Inicial</a>
        <button class=""btn btn-success"" onclick=""extrairDados()"">Extrair Dados</button> <!-- Botão para extrair dados -->
    </div>
    <br />
    
    <!-- Tabela para exibir os sensores cadastrados -->
    <table");
                WriteLiteral(@" class=""table table-responsive"">
        <thead>
            <tr>
                <th>Ação</th> <!-- Coluna para ações como editar e apagar -->
                <th>Código do Sensor</th>
                <th>Descrição do Tipo de Sensor</th>
                <th>Data da Venda</th>
                <th>Valor da Temperatura Alvo Configurada</th>
                <th>Código do Motor Associado ao Sensor</th>
                <th>Código do Funcionário Associado ao Motor</th>
                <th>Código da Empresa Associada ao Sensor</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 57 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
             if (Model != null && Model.Count > 0) // Verifica se há sensores cadastrados
            {
                foreach (var sensor in Model) // Itera sobre a lista de sensores
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <!-- Botões para editar e apagar o registro do sensor -->\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2699, "\"", 2732, 2);
                WriteAttributeValue("", 2706, "/Sensor/Edit?id=", 2706, 16, true);
#nullable restore
#line 64 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
WriteAttributeValue("", 2722, sensor.id, 2722, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning\">Editar</a>\r\n                            <a href=\"javascript:void(0);\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2827, "\"", 2861, 3);
                WriteAttributeValue("", 2837, "apagarSensor(", 2837, 13, true);
#nullable restore
#line 65 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
WriteAttributeValue("", 2850, sensor.id, 2850, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2860, ")", 2860, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Código do sensor -->\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.ds_tipo_sens);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Descrição do tipo de sensor -->\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.dt_vend);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Data da venda -->\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.vl_temp_alvo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Valor da temperatura alvo -->\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.cd_motor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Código do motor associado -->\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.id_func);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Código do funcionário associado -->\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                       Write(sensor.id_empr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <!-- Código da empresa associada -->\r\n                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                }
            }
            else // Se não houver sensores cadastrados
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"8\" class=\"text-center\">Nenhum Sensor Cadastrado.</td> <!-- Mensagem de aviso -->\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>
    <script>
        function apagarSensor(id) {
            if (confirm('Confirma a exclusão do registro?'))
                location.href = 'Sensor/Delete?id=' + id;
        }

        function extrairDados() {
            window.location.href = '");
#nullable restore
#line 92 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Index.cshtml"
                               Write(Url.Action("ExtrairDados", "Sensor"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'; // Redireciona para a ação de extração de dados\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SensorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
