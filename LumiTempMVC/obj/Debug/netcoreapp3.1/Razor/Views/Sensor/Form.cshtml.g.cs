#pragma checksum "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c9858e0f5b31d2c521cb4fa9c26c50d76b28738aecb0e204292f790d871eed92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sensor_Form), @"mvc.1.0.view", @"/Views/Sensor/Form.cshtml")]
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
#line 1 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c9858e0f5b31d2c521cb4fa9c26c50d76b28738aecb0e204292f790d871eed92", @"/Views/Sensor/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sensor_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SensorViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/estilos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Salvar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml"; // Define o layout padrão da página

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9858e0f5b31d2c521cb4fa9c26c50d76b28738aecb0e204292f790d871eed925891", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" /> <!-- Configura a codificação de caracteres para UTF-8 -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9858e0f5b31d2c521cb4fa9c26c50d76b28738aecb0e204292f790d871eed926269", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <!-- Referencia o arquivo de estilos CSS -->\r\n    <title>Cadastro de Sensores</title> <!-- Define o título da página -->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9858e0f5b31d2c521cb4fa9c26c50d76b28738aecb0e204292f790d871eed928389", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9858e0f5b31d2c521cb4fa9c26c50d76b28738aecb0e204292f790d871eed928675", async() => {
                    WriteLiteral(@"
        <!-- Define o método POST e a ação de envio do formulário -->
        <h2>Cadastro de Sensores</h2> <!-- Cabeçalho do formulário -->

        <div>
            <label for=""id"" class=""control-label"">Código do Sensor</label>
            <input type=""number"" id=""id"" name=""id""");
                    BeginWriteAttribute("value", " value=\"", 794, "\"", 811, 1);
#nullable restore
#line 21 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 802, Model.id, 802, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required /> <!-- Campo para o código do sensor -->\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"ds_tipo_sens\" class=\"control-label\">Descrição do Tipo de Sensor</label>\r\n            <input type=\"text\" id=\"ds_tipo_sens\" name=\"ds_tipo_sens\"");
                    BeginWriteAttribute("value", " value=\"", 1063, "\"", 1090, 1);
#nullable restore
#line 26 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 1071, Model.ds_tipo_sens, 1071, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required /> <!-- Campo para a descrição do tipo de sensor -->\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"dt_vend\" class=\"control-label\">Data de Venda do Sensor</label>\r\n            <input type=\"date\" id=\"dt_vend\" name=\"dt_vend\"");
                    BeginWriteAttribute("value", " value=\"", 1334, "\"", 1379, 1);
#nullable restore
#line 31 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 1342, Model.dt_vend.ToString("yyyy-MM-dd"), 1342, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" required /> <!-- Campo para a data de venda do sensor -->
        </div>

        <div>
            <label for=""vl_temp_alvo"" class=""control-label"">Temperatura Alvo Configurada</label>
            <input type=""text"" id=""vl_temp_alvo"" name=""vl_temp_alvo""");
                    BeginWriteAttribute("value", " value=\"", 1639, "\"", 1666, 1);
#nullable restore
#line 36 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 1647, Model.vl_temp_alvo, 1647, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required /> <!-- Campo para a temperatura alvo configurada -->\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"cd_motor\" class=\"control-label\">Código do Motor Vinculado</label>\r\n            <input type=\"number\" id=\"cd_motor\" name=\"cd_motor\"");
                    BeginWriteAttribute("value", " value=\"", 1918, "\"", 1941, 1);
#nullable restore
#line 41 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 1926, Model.cd_motor, 1926, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" required /> <!-- Campo para o código do motor associado ao sensor -->
        </div>

        <div>
            <label for=""id_func"" class=""control-label"">Código do Usuário Responsável</label>
            <input type=""number"" id=""id_func"" name=""id_func""");
                    BeginWriteAttribute("value", " value=\"", 2201, "\"", 2223, 1);
#nullable restore
#line 46 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 2209, Model.id_func, 2209, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required /> <!-- Campo para o código do usuário responsável -->\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"id_empr\" class=\"control-label\">Código da Empresa</label>\r\n            <input type=\"number\" id=\"id_empr\" name=\"id_empr\"");
                    BeginWriteAttribute("value", " value=\"", 2465, "\"", 2487, 1);
#nullable restore
#line 51 "C:\Users\082220040\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\Form.cshtml"
WriteAttributeValue("", 2473, Model.id_empr, 2473, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" required /> <!-- Campo para o código da empresa associada -->
        </div>

        <div>
            <input type=""submit"" value=""Salvar Dados"" /> <!-- Botão para enviar os dados do formulário -->
        </div>

        <div>
            <h2><a href=""/Sensor"">Página Inicial</a></h2> <!-- Link de navegação para a página inicial dos sensores -->
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SensorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
