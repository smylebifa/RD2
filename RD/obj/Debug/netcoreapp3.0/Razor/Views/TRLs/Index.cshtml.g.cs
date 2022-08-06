#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348de1fba470e286ed3d39709cf33e5b3953cbc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TRLs_Index), @"mvc.1.0.view", @"/Views/TRLs/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\_ViewImports.cshtml"
using RD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\_ViewImports.cshtml"
using RD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348de1fba470e286ed3d39709cf33e5b3953cbc1", @"/Views/TRLs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_TRLs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.TRL>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
  
    ViewBag.Title = "TRL";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm"">
            <h2>TRL</h2>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('[data-toggle=""toggle""]').change(function () {
            $(this).parents().next('.hide').toggle();
        });
    });

    $(document).ready(function () {
        $("".expandFRED"").click(function () {
            $("".expandSUB1"").toggle();
        });
        $("".expandFRED2"").click(function () {
            $("".expandSUB2"").toggle();
        });
        $("".expandVALS"").click(function () {
            $("".expandCAT1"").toggle();
        });
    })
</script>

<style>
    .label tr td label {
        display: block;
    }

    [data-toggle='toggle'] {
        display: none;
    }

    .expandSUB1 {
        display: none;
    }

    .expandSUB2 {
        display: none;
    }

    . {
        display: none;
    }

        .expandCAT1 {
            display: none;
        }
");
            WriteLiteral(@"
        .expandFRED, .expandFRED2 {
            cursor: pointer;
        }
</style>


<div style=""overflow-x:auto;"">
    <table class=""table table-hover table-bordered"" style=""text-align: center; "">

        <thead class=""thead-dark"">
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">Уровень TRL</th>
                <th scope=""col"">Наименование уровня TRL</th>
                <th scope=""col"">Статус</th>
            </tr>
        </thead>

");
            WriteLiteral("\r\n\r\n        <tbody class=\"labels\">\r\n            <tr>\r\n                <td></td>\r\n                <td>1</td>\r\n                <td class=\'expandFRED\'>Сформулирована фундаментальная концепция технологии и обоснование ее полезности. ▼</td>\r\n");
            WriteLiteral("                <td>\r\n                    <input type=\"checkbox\" id=\"trl1\"\r\n                           ");
#nullable restore
#line 114 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl1_1 && ViewBag.Trls.Trl1_2 && ViewBag.Trls.Trl1_3 && ViewBag.Trls.Trl1_4 && ViewBag.Trls.Trl1_5 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" />
                </td>
            </tr>

        </tbody>

        <tbody class=""hide"">
            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>1.1</td>
                <td class='expandSUB1' align='right'>
                    Начальный уровень зрелости технологии.
                </td>
                <td class='expandSUB1'>
                    <input type=""checkbox"" id=""trl1_1""
                           ");
#nullable restore
#line 129 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl1_1 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                           ) />
                </td>
            </tr>

            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>1.2</td>
                <td class='expandSUB1' align='right'>
                    Научные исследования начинают переходить в прикладные исследования.
                </td>
                <td class='expandSUB1'>
                    <input type=""checkbox"" id=""trl1_2""
                           ");
#nullable restore
#line 142 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl1_2 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                           ) />
                </td>
            </tr>
            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>1.3</td>
                <td class='expandSUB1' align='right'>
                    Сформулирована идея, основные принципы наблюдались и были документированы.
                </td>
                <td class='expandSUB1'>
                    <input type=""checkbox"" id=""trl1_3""
                           ");
#nullable restore
#line 154 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl1_3 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) />
                </td>
            </tr>
            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>1.4</td>
                <td class='expandSUB1' align='right'>
                    Проведен анализ существующих на рынке решений, определена потребность в новом продукте, сформулировано перспективное технологическое/алгоритмическое/архитектурное решение.
                </td>
                <td class='expandSUB1'>
                    <input type=""checkbox"" id=""trl1_4""
                           ");
#nullable restore
#line 165 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl1_4 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) />
                </td>
            </tr>
            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>1.5</td>
                <td class='expandSUB1' align='right'>
                    Проведен экспертный анализ предлагаемого решения: ценность, удобство, реализуемость, прибыльность, востребованность, защищенность бизнеса, полезность для развития технологической базы исполнителя.
                </td>
                <td class='expandSUB1'>
                    <input type=""checkbox"" id=""trl1_5""
                           ");
#nullable restore
#line 176 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl1_5 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) />
                </td>
            </tr>
        </tbody>


        <tbody class=""labels"">

            <tr>
                <td></td>
                <td>2</td>
                <td class='expandFRED2'>Определены целевые области применения технологии и ее критические элементы. ▼</td>
");
            WriteLiteral("                <td>\r\n                    <input type=\"checkbox\" id=\"trl2\"\r\n                           ");
#nullable restore
#line 191 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                       Write(ViewBag.Trls.Trl2_1 && ViewBag.Trls.Trl2_2 && ViewBag.Trls.Trl2_3 && ViewBag.Trls.Trl2_4 && ViewBag.Trls.Trl2_5 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" />
                </td>

            </tr>

        </tbody>

        <tbody class=""hide"">
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>2.1</td>
                <td class='expandSUB2' align='right'>
                    Концепция технологии/продукта и/или ее применения сформулированы.
                </td>
                <td class='expandSUB2'><input type=""checkbox"" id=""trl2_1"" ");
#nullable restore
#line 205 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                                      Write(ViewBag.Trls.Trl2_1 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) /></td>
            </tr>
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>2.2</td>
                <td class='expandSUB2' align='right'>
                    Сформулировано техническое предложение, может быть предложено практическое использование.
                </td>
                <td class='expandSUB2'><input type=""checkbox"" id=""trl2_2"" ");
#nullable restore
#line 213 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                                      Write(ViewBag.Trls.Trl2_2 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) /></td>
            </tr>
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>2.3</td>
                <td class='expandSUB2' align='right'>
                    Аналитический обзор, проведенный в рамках патентного исследования, показал реализуемость и отсутствие аналогичных решений.
                </td>
                <td class='expandSUB2'><input type=""checkbox"" id=""trl2_3"" ");
#nullable restore
#line 221 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                                      Write(ViewBag.Trls.Trl2_3 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) /></td>
            </tr>
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>2.4</td>
                <td class='expandSUB2' align='right'>
                    Сформулировано предварительное техническое задание, определена архитектура (описание основных компонентов и их связей) продукта: платформа для решения, компоненты, связь и взаимодействие между ними, проведено моделирование продукта, разработан предварительный дизайн.
                </td>
                <td class='expandSUB2'><input type=""checkbox"" id=""trl2_4"" ");
#nullable restore
#line 229 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                                      Write(ViewBag.Trls.Trl2_4 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ) /></td>
            </tr>
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>2.5</td>
                <td class='expandSUB2' align='right'>
                    Проведен предварительный патентный анализ, анализ промышленных и технологических рисков.
                </td>
                <td class='expandSUB2'><input type=""checkbox"" id=""trl2_5"" ");
#nullable restore
#line 237 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                                      Write(ViewBag.Trls.Trl2_5 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ) /></td>\r\n            </tr>\r\n        </tbody>\r\n\r\n\r\n    </table>\r\n</div>\r\n\r\n<br>\r\n\r\n<h5 style=\"color: green\">Выполненные уровни - ");
#nullable restore
#line 247 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                         Write(ViewBag.Trls.TotalReady);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<br>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<script type=""text/javascript"">
    // Load google charts
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);

    // Draw the chart and set the chart values
    function drawChart() {

        Total = 10;

        var ready = ");
#nullable restore
#line 289 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
               Write(ViewBag.Trls.TotalReady);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        var notReady = Total - ready;

        var data = google.visualization.arrayToDataTable([
            ['Уровни', 'Количество'],
            ['Выполненные уровни', ready],
            ['Не выполненные уровни', notReady],
        ]);

        // Optional; add a title and set the width and height of the chart
        var options = { 'title': 'Готовность проекта', 'width': 600, 'height': 450, 'colors': ['green', 'red'] };

        // Display the chart inside the <div> element with id=""piechart""
        var chart = new google.visualization.PieChart(document.getElementById('trl_diagram'));
        chart.draw(data, options);
    }
</script>

<div id=""trl_diagram""></div>

<button class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 11559, "\"", 11595, 3);
            WriteAttributeValue("", 11569, "save(\'", 11569, 6, true);
#nullable restore
#line 309 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
WriteAttributeValue("", 11575, ViewBag.ThemeName, 11575, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11593, "\')", 11593, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" style=""text-align:center""> Сохранить </button>

<script type=""text/javascript"">
    function save(themeName) {

        var trl1_1 = document.getElementById('trl1_1').checked;
        var trl1_2 = document.getElementById('trl1_2').checked;
        var trl1_3 = document.getElementById('trl1_3').checked;
        var trl1_4 = document.getElementById('trl1_4').checked;
        var trl1_5 = document.getElementById('trl1_5').checked;
        var trl2_1 = document.getElementById('trl2_1').checked;
        var trl2_2 = document.getElementById('trl2_2').checked;
        var trl2_3 = document.getElementById('trl2_3').checked;
        var trl2_4 = document.getElementById('trl2_4').checked;
        var trl2_5 = document.getElementById('trl2_5').checked;

        //alert(trl1);
        //alert(trl2);

        $.ajax({
            url: '/save/' + themeName + '/' + trl1_1 + '/' + trl1_2 + '/' + trl1_3 + '/' + trl1_4 + '/' + trl1_5
                + '/' + trl2_1 + '/' + trl2_2 + '/' + trl2_3 + ");
            WriteLiteral(@"'/' + trl2_4 + '/' + trl2_5,
            type: 'POST',
            contentType: ""application/json; charset=utf-8"",
            success: function () {
                location.reload()
            },
            error: function () {
                alert(""Ошибка выполнения!"")
            }
        })
    }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.TRL> Html { get; private set; }
    }
}
#pragma warning restore 1591
