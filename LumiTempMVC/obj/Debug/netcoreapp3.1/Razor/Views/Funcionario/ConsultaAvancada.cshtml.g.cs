#pragma checksum "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\ConsultaAvancada.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "505d75b2bc51055be205bfba06c740cbd1c38fcfbea785bd4f2d9c174dae15f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_ConsultaAvancada), @"mvc.1.0.view", @"/Views/Funcionario/ConsultaAvancada.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"505d75b2bc51055be205bfba06c740cbd1c38fcfbea785bd4f2d9c174dae15f3", @"/Views/Funcionario/ConsultaAvancada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_ConsultaAvancada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\ConsultaAvancada.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<fieldset id=""areaFiltro"" class=""form-group"">
    <legend>Consulta avançada de Funcionários</legend>
    <div class=""row"">
        <div class=""col-lg-4"">
            Descrição<br />
            <input type=""text"" id=""descricao"" class=""form-control"" />
        </div>
        <div class=""col-lg-2"">
            Período <br />
            <input type=""date"" id=""dataInicial"" class=""form-control"" />
        </div>
        <div class=""col-lg-2"">
            <br />
            <input type=""date"" id=""dataFinal"" class=""form-control"" />
        </div>
        <div class=""col-lg-1"">
            <br />
            <input type=""button"" id=""btnFiltro"" class=""btn btn-success"" value=""Aplicar""
                   onclick=""aplicaFiltroConsultaAvancada()"" />
        </div>
    </div>
</fieldset>
<div id=""resultadoConsulta"" class=""table-responsive"">
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
