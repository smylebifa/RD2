#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e695dd4cc8adf8efbfce625da4b0c13aa2c218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stages_Index), @"mvc.1.0.view", @"/Views/Stages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e695dd4cc8adf8efbfce625da4b0c13aa2c218", @"/Views/Stages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Stages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.Stage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TRLs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\Index.cshtml"
  
    ViewBag.Title = "Этапы";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <h2>Этапы</h2>\r\n        </div>\r\n        <div class=\"col-sm\">\r\n");
            WriteLiteral("            <h4> ");
#nullable restore
#line 15 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\Index.cshtml"
            Write(Html.ActionLink("Добавить этап", "Stage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n        </div>\r\n        <div class=\"col-sm\">\r\n            <h4> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e695dd4cc8adf8efbfce625da4b0c13aa2c2185043", async() => {
                WriteLiteral("TRL");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h4>
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
</style>


<div style=""overflow-x:auto;"">
    <table class=""table table-hover table-bordered"" ");
            WriteLiteral(@"style=""text-align: center; "">

        <thead class=""thead-dark"">
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">№ этапа</th>
                <th scope=""col"">Этап</th>
                <th scope=""col"">Срок выполнения - начало</th>
                <th scope=""col"">Срок выполнения - конец</th>
                <th scope=""col"">Сумма этапа</th>
                <th scope=""col"">Акт о завершении</th>
                <th scope=""col"">Статус</th>
            </tr>
        </thead>

        <tbody>
");
            WriteLiteral(@"
            <tr>
                <td></td>
                <td>1</td>
                <td>Разработка ТЗ НИР</td>
                <td>x</td>
                <td>x</td>
                <td>x</td>
                <td>x</td>
                <td><input type=""checkbox"" name=""active"" /></td>
            </tr>
        </tbody>

        <tbody class=""labels"">
            <tr>
                <td></td>
                <td>2</td>
                <td class='expandFRED'>Выбор направления исследования ▼</td>
                <td>y</td>
                <td>y</td>
                <td>y</td>
                <td>y</td>
                <td><input type=""checkbox"" name=""active"" /></td>
            </tr>

        </tbody>

        <tbody class=""hide"">
            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>2.1</td>
                <td class='expandSUB1' align='right'>
                    Сбор и изучение научно-технической литературы, нормативно");
            WriteLiteral(@"-технической документации,  эксплуатационной информации об аналоговых и других материалах, относящихся к разрабатываемой теме.
                </td>
                <td class='expandSUB1'></td>
                <td class='expandSUB1' align='right'></td>
                <td class='expandSUB1' align='right'></td>
                <td class='expandSUB1' align='right'></td>
                <td class='expandSUB1' align='right'></td>
            </tr>

            <tr>
                <td class='expandSUB1 expandVALS'></td>
                <td class='expandSUB1'>2.2</td>
                <td class='expandSUB1' align='right'>
                    Проведение патентных исследований. Составление отчета по патентным исследованиям в соответствии с ГОСТ 15.011
                </td>
                <td class='expandSUB1'></td>
                <td class='expandSUB1' align='right'></td>
                <td class='expandSUB1' align='right'></td>
                <td class='expandSUB1' align='right'></td>
       ");
            WriteLiteral(@"         <td class='expandSUB1' align='right'></td>
            </tr>

        </tbody>


        <tbody class=""labels"">

            <tr>
                <td></td>
                <td>3</td>
                <td class='expandFRED2'>Теоретические и экспериментальные исследования ▼</td>
                <td>y</td>
                <td>y</td>
                <td>y</td>
                <td>y</td>
                <td><input type=""checkbox"" name=""active"" /></td>
            </tr>

        </tbody>

        <tbody class=""hide"">
            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>3.1</td>
                <td class='expandSUB2' align='right'>
                    Разработка рабочих гипотез, построение моделей объекта исследований, обоснование допущений.
                </td>
                <td class='expandSUB2'></td>
                <td class='expandSUB2' align='right'></td>
                <td class='expandSUB2' align='right'></t");
            WriteLiteral(@"d>
                <td class='expandSUB2' align='right'></td>
                <td class='expandSUB2' align='right'></td>
            </tr>

            <tr>
                <td class='expandSUB2 expandVALS'></td>
                <td class='expandSUB2'>3.2</td>
                <td class='expandSUB2' align='right'>
                    Выявление необходимости проведения экспериментов для подтверждения отдельных положений теоретических исследований для получения конкретных значений параметров (коэффициентов, необходимых для проведения расчѐтов).
                </td>
                <td class='expandSUB2'></td>
                <td class='expandSUB2' align='right'></td>
                <td class='expandSUB2' align='right'></td>
                <td class='expandSUB2' align='right'></td>
                <td class='expandSUB2' align='right'></td>
            </tr>


        </tbody>


    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.Stage> Html { get; private set; }
    }
}
#pragma warning restore 1591
