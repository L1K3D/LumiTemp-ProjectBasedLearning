#pragma checksum "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Form), @"mvc.1.0.view", @"/Views/Funcionario/Form.cshtml")]
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
#line 1 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\_ViewImports.cshtml"
using LumiTempMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e973", @"/Views/Funcionario/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FuncionarioViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
  
    var titulo = ViewBag.Operacao == "A" ? "Alteração de Funcionário" : "Inclusão de Funcionário";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n    <h1 class=\"text-center mb-4\">");
#nullable restore
#line 8 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
                            Write(titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e9737606", async() => {
                WriteLiteral("\r\n        <!-- Campo oculto para a operação -->\r\n        <input type=\"hidden\" name=\"Operacao\"");
                BeginWriteAttribute("value", " value=\"", 407, "\"", 432, 1);
#nullable restore
#line 12 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
WriteAttributeValue("", 415, ViewBag.Operacao, 415, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <!-- Código do Funcionário (somente para Alteração) -->\r\n");
#nullable restore
#line 15 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
         if (ViewBag.Operacao == "A")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <fieldset class=\"border p-3 mb-4\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"id\" class=\"control-label\">Código</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e9738943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 20 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97310994", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 21 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </fieldset>\r\n");
#nullable restore
#line 24 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- Código da Empresa -->
        <fieldset class=""border p-3 mb-4"">
            <div class=""form-group"">
                <label for=""codigoEmpresa"" class=""control-label"">Código da Empresa</label>
                <input type=""number"" id=""codigoEmpresa"" name=""Id""");
                BeginWriteAttribute("value", " value=\"", 1217, "\"", 1234, 1);
#nullable restore
#line 30 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
WriteAttributeValue("", 1225, Model.id, 1225, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       class=\"form-control\" ");
#nullable restore
#line 31 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
                                        Write(ViewBag.Operacao == "A" ? "readonly" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97314064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 32 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <!-- Login do Funcionário -->\r\n            <div class=\"form-group\">\r\n                <label for=\"login_func\" class=\"control-label\">Login</label>\r\n                <input type=\"text\" id=\"login_func\" name=\"login_func\"");
                BeginWriteAttribute("value", " value=\"", 1653, "\"", 1678, 1);
#nullable restore
#line 38 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
WriteAttributeValue("", 1661, Model.login_func, 1661, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       class=\"form-control\" placeholder=\"Digite o login\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97316546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 40 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.login_func);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <!-- Senha do Funcionário -->\r\n            <div class=\"form-group\">\r\n                <label for=\"senha_func\" class=\"control-label\">Senha</label>\r\n                <input type=\"password\" id=\"senha_func\" name=\"senha_func\"");
                BeginWriteAttribute("value", " value=\"", 2093, "\"", 2118, 1);
#nullable restore
#line 46 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
WriteAttributeValue("", 2101, Model.senha_func, 2101, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       class=\"form-control\" placeholder=\"Digite a senha\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97319040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 48 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.senha_func);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <!-- Data de Cadastro -->\r\n            <div class=\"form-group\">\r\n                <label for=\"dt_cadr\" class=\"control-label\">Data de Cadastro</label>\r\n                <input type=\"date\" id=\"dt_cadr\" name=\"dt_cadr\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 2527, "\"", 2596, 1);
#nullable restore
#line 55 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
WriteAttributeValue("", 2559, Model.dt_cadr.ToString("yyyy-MM-dd"), 2559, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97321517", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 56 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.dt_cadr);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>

            <!-- Imagem do Funcionário -->
            <div class=""form-group"">
                <label for=""Imagem"" class=""control-label"">Imagem do Funcionário</label>
                <input type=""file"" id=""Imagem"" name=""Imagem"" class=""form-control-file"" onchange=""exibirImagem()"" />
                <div class=""mt-3"">
");
#nullable restore
#line 64 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
                     if (!string.IsNullOrEmpty(Model.ImagemEmBase64))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img id=\"imgPreview\"");
                BeginWriteAttribute("src", " src=\"", 3187, "\"", 3237, 2);
                WriteAttributeValue("", 3193, "data:image/jpeg;base64,", 3193, 23, true);
#nullable restore
#line 66 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
WriteAttributeValue("", 3216, Model.ImagemEmBase64, 3216, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                             class=\"img-preview\" alt=\"Pré-visualização da imagem\" />\r\n");
#nullable restore
#line 68 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img id=\"imgPreview\"");
                BeginWriteAttribute("src", " src=\"", 3442, "\"", 3448, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-preview\" alt=\"Pré-visualização da imagem\" />\r\n");
#nullable restore
#line 72 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97325393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 74 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Imagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </fieldset>

        <!-- Botões -->
        <div class=""d-flex justify-content-between mt-4"">
            <button type=""submit"" class=""btn btn-primary btn-lg"">Salvar Dados</button>
            <a href=""/Funcionario"" class=""btn btn-secondary btn-lg"">Voltar para a listagem</a>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div class=\"mt-4 text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969dd9544fcfb37fa7316b03467a0b7ebf6c1f28dc0743450b4d51864d17e97329026", async() => {
                WriteLiteral("Página Inicial");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!-- Scripts -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\Form.cshtml"
          
            await Html.RenderPartialAsync("_ValidationScriptsPartial");
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            WriteLiteral(@"
<script>
    function exibirImagem() {
        var fileInput = document.getElementById(""Imagem"");
        if (fileInput.files && fileInput.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                document.getElementById(""imgPreview"").src = e.target.result;
            };
            reader.readAsDataURL(fileInput.files[0]);
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FuncionarioViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
