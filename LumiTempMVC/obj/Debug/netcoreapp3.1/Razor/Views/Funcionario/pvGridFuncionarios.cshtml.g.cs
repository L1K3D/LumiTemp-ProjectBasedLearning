#pragma checksum "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\pvGridFuncionarios.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6ad59683e2d2ff7eeab4d3144354affb32d9f1111bbcaee6c3c1c524c1bded9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_pvGridFuncionarios), @"mvc.1.0.view", @"/Views/Funcionario/pvGridFuncionarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ad59683e2d2ff7eeab4d3144354affb32d9f1111bbcaee6c3c1c524c1bded9f", @"/Views/Funcionario/pvGridFuncionarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_pvGridFuncionarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FuncionarioViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Código</th>\r\n        <th>Login</th>\r\n        <th>Data de Cadastro</th>\r\n    </tr>\r\n");
#nullable restore
#line 8 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\pvGridFuncionarios.cshtml"
     foreach (var funcionario in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 11 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\pvGridFuncionarios.cshtml"
                 funcionario.id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 12 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\pvGridFuncionarios.cshtml"
                 funcionario.login_func

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 13 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\pvGridFuncionarios.cshtml"
                 funcionario.dt_cadr.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Users\paula\Desktop\PBL\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Funcionario\pvGridFuncionarios.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>");
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
