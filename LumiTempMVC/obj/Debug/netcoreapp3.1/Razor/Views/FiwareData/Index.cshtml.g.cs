#pragma checksum "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c67187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FiwareData_Index), @"mvc.1.0.view", @"/Views/FiwareData/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c67187", @"/Views/FiwareData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bddbbfa23a714e6dc1db3f7391ce5e59feaccc5a3b58251d0b29119ee2b3b31a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_FiwareData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SensorViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
  
    ViewData["Title"] = "LumiTemp Data Viewer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-BR\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c671875063", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 11 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c671875741", async() => {
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
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/plotly.js-dist@2.3.0\"></script>\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c671877807", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1>");
#nullable restore
#line 18 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>

        <!-- Alerta -->
        <div id=""alert"" style=""display: none; color: red; font-weight: bold;"">Valor acima da média!</div>
        <div id=""offline-alert"" style=""display: none; color: gray; font-weight: bold;"">Servidor Offline</div>

        <!-- Dropdown para selecionar tipo de sensor -->
        <label for=""sensor-type"">Selecione o Tipo de Sensor:</label>
        <select id=""sensor-type"" onchange=""fetchSensorCodes()"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c671878864", async() => {
                    WriteLiteral("Selecione");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
             foreach (var sensor in Model.Select(s => s.ds_tipo_sens).Distinct())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c6718710450", async() => {
#nullable restore
#line 30 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
                                   Write(sensor);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
                   WriteLiteral(sensor);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n\r\n        <!-- Dropdown para selecionar o código do sensor -->\r\n        <label for=\"sensor-code\">Selecione o Código do Sensor:</label>\r\n        <select id=\"sensor-code\" onchange=\"fetchData()\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f00a81fed615869aacf65aab46a40f0947e4b59898e0f0587c9c8fa4c6718712847", async() => {
                    WriteLiteral("Selecione");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </select>

        <!-- Input para definir o valor de lastN -->
        <label for=""lastN"">Número de Requisições:</label>
        <input type=""number"" id=""lastN"" value=""15"" min=""1"" onchange=""fetchData()"" />

        <div id=""lumitemp-graph""></div>
    </div>

    <script type=""text/javascript"">
        var sensors = ");
#nullable restore
#line 48 "C:\Users\Heitor\Documents\Program\LumiTemp-ProjectBasedLearning\LumiTempMVC\Views\FiwareData\Index.cshtml"
                 Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        function fetchSensorCodes() {
            var sensorType = document.getElementById('sensor-type').value;
            var sensorCodeDropdown = document.getElementById('sensor-code');
            sensorCodeDropdown.innerHTML = '<option value="""">Selecione</option>';

            var filteredSensors = sensors.filter(sensor => sensor.ds_tipo_sens === sensorType);
            filteredSensors.forEach(sensor => {
                var option = document.createElement('option');
                option.value = sensor.id;
                option.text = sensor.id;
                sensorCodeDropdown.appendChild(option);
            });
        }

        function fetchData() {
            var sensorCode = document.getElementById('sensor-code').value;
            var lastN = document.getElementById('lastN').value;
            console.log(""Fetching data..."");

            var selectedSensor = sensorCode ? sensors.find(sensor => sensor.id == sensorCode) : null;

            $.get(`/api/Api/tempe");
                WriteLiteral(@"rature?lastN=${lastN}`, function (data) {
                console.log(""Data received:"", data);
                drawGraph(data, selectedSensor);
                document.getElementById('offline-alert').style.display = 'none';
            }).fail(function (jqXHR, textStatus, errorThrown) {
                console.error(""Error fetching data:"", textStatus, errorThrown);
                drawGraph(null, selectedSensor);
                document.getElementById('offline-alert').style.display = 'block';
            });
        }

        function drawGraph(data, selectedSensor) {
            var traces = [];
            var times = [];
            var values = [];
            var alertTriggered = false;

            if (data && data.length) {
                times = data.map(item => new Date(item.recvTime));
                values = data.map(item => item.attrValue);

                var trace = {
                    x: times,
                    y: values,
                    mode: 'lines+marke");
                WriteLiteral(@"rs',
                    name: 'Temperatura',
                    line: { color: 'orange' }
                };

                traces.push(trace);

                var averageValue = values.reduce((a, b) => a + b, 0) / values.length;
                var traceAverage = {
                    x: times.length > 0 ? [times[0], times[times.length - 1]] : [new Date(), new Date()],
                    y: [averageValue, averageValue],
                    mode: 'lines',
                    name: 'Média',
                    line: { color: 'blue', dash: 'dot' }
                };
                traces.push(traceAverage);

                // Verifica se algum valor é maior que a média
                if (values.some(value => value > averageValue)) {
                    alertTriggered = true;
                }
            } else {
                var offlineTrace = {
                    x: [new Date(), new Date()],
                    y: [0, 0],
                    type: 'scatter',
            ");
                WriteLiteral(@"        mode: 'lines+markers',
                    text: 'Servidor Offline',
                    hoverinfo: 'text',
                    line: { color: 'gray' }
                };
                traces.push(offlineTrace);
            }

            if (selectedSensor) {
                var traceTarget = {
                    x: times.length > 0 ? [times[0], times[times.length - 1]] : [new Date(), new Date()],
                    y: [selectedSensor.vl_temp_alvo, selectedSensor.vl_temp_alvo],
                    mode: 'lines',
                    name: 'Valor Alvo',
                    line: { color: 'red', dash: 'dash' }
                };
                traces.push(traceTarget);
            }

            var layout = {
                title: 'Temperatura ao Longo do Tempo',
                xaxis: { title: 'Timestamp' },
                yaxis: { title: 'Temperatura' }
            };

            Plotly.newPlot('lumitemp-graph', traces, layout);

            // Mostra ou esconde o a");
                WriteLiteral(@"lerta
            document.getElementById('alert').style.display = alertTriggered ? 'block' : 'none';
        }

        $(document).ready(function () {
            fetchSensorCodes();
            fetchData();
            setInterval(fetchData, 1500); // Atualiza a cada 1,5 segundos
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SensorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
