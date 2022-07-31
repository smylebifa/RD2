#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f837118f934d2505a6da7897615b97034508245"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f837118f934d2505a6da7897615b97034508245", @"/Views/TRLs/Index.cshtml")]
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
            WriteLiteral(@"

        <tbody class=""labels"">
            <tr>
                <td></td>
                <td>1</td>
                <td class='expandFRED'>Сформулирована фундаментальная концепция технологии и обоснование ее полезности. ▼</td>
                <td><input type=""checkbox"" id=""trl1"" ");
#nullable restore
#line 111 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                 Write(ViewBag.Trls.Trl1 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" /></td>
            </tr>

        </tbody>

        <tbody class=""hide"">
            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>1</td>
                <td class='expandSUB1' align='right'>
                    Начальный уровень зрелости технологии. Научные исследования начинают переходить в прикладные исследования. Сформулирована идея, основные принципы наблюдались и были документированы. Проведен анализ существующих на рынке решений, определена потребность в новом продукте, сформулировано перспективное технологическое/алгоритмическое/архитектурное решение. Проведен экспертный анализ предлагаемого решения: ценность, удобство, реализуемость, прибыльность, востребованность, защищенность бизнеса, полезность для развития технологической базы исполнителя.
                </td>
                <td class='expandSUB1'></td>
            </tr>
        </tbody>


        <tbody class=""labels"">

            <tr>
                <td></td>
     ");
            WriteLiteral("           <td>2</td>\r\n                <td class=\'expandFRED2\'>Определены целевые области применения технологии и ее критические элементы. ▼</td>\r\n                <td><input type=\"checkbox\" id=\"trl2\" ");
#nullable restore
#line 134 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\TRLs\Index.cshtml"
                                                 Write(ViewBag.Trls.Trl2 ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" /></td>
                
            </tr>

        </tbody>

        <tbody class=""hide"">
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>2</td>
                <td class='expandSUB2' align='right'>
                    Концепция технологии/продукта и/или ее применения сформулированы. Сформулировано техническое предложение, может быть предложено практическое использование. Аналитический обзор, проведенный в рамках патентного исследования, показал реализуемость и отсутствие аналогичных решений. Сформулировано предварительное техническое задание, определена архитектура (описание основных компонентов и их связей) продукта: платформа для решения, компоненты, связь и взаимодействие между ними, проведено моделирование продукта, разработан предварительный дизайн. Проведен предварительный патентный анализ, анализ промышленных и технологических рисков.
                </td>
                <td class='expandSUB2'></td>
            </tr>

");
            WriteLiteral(@"
        </tbody>


    </table>
</div>

<a onclick=""save()"" href=""#""> Сохранить </a>

<script type=""text/javascript"">
    function save() {

        var trl1 = document.getElementById('trl1').checked;
        var trl2 = document.getElementById('trl2').checked;

        //alert(trl1);
        //alert(trl2);

        $.ajax({
            url: '/save/' + trl1 + '/' + trl2,
            type: 'POST',
            contentType: ""application/json; charset=utf-8"",
            success: function () {
                location.reload()
            },
            error: function () {
                alert(""Всё сломалось!!!"")
            }
        })
    }
</script>");
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
