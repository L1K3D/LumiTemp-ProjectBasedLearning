#pragma checksum "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ecafce39deba0e260cba45c6b9948daed7c8b1aa8043535b4a4b506000f92db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sensor_pvGridSensores), @"mvc.1.0.view", @"/Views/Sensor/pvGridSensores.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9ecafce39deba0e260cba45c6b9948daed7c8b1aa8043535b4a4b506000f92db", @"/Views/Sensor/pvGridSensores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sensor_pvGridSensores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SensorViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Código</th>\r\n        <th>Descrição Tipo Sensor</th>\r\n        <th>Data de Venda</th>\r\n        <th>Temperatura Alvo</th>\r\n        <th>Empresa</th>\r\n    </tr>\r\n");
#nullable restore
#line 10 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
     foreach (var sensor in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
           Write(sensor.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
           Write(sensor.ds_tipo_sens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
           Write(sensor.dt_vend.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
           Write(sensor.vl_temp_alvo.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
           Write(sensor.id_empr);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
                             Write(sensor.DescricaoEmpresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Heitor\Downloads\Nova pasta\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\Sensor\pvGridSensores.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SensorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
