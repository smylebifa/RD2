#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e63626c7a8038d250735ae9f82b473bf4d7b287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stages_ChangingStage), @"mvc.1.0.view", @"/Views/Stages/ChangingStage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e63626c7a8038d250735ae9f82b473bf4d7b287", @"/Views/Stages/ChangingStage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Stages_ChangingStage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.Stage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Завершен", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Не звершен", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Не завершен", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
  
    ViewBag.Title = "Редактирование этапа";
    Layout = "_Layout";

    string WorkStart = "";
    string WorkEnd = "";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
     if (ViewBag.CurrentStage.WorkStart != null)
    {
        WorkStart = @ViewBag.CurrentStage.WorkStart.ToString("yyyy-MM-dd");
    }
    else
    {
        WorkStart = @ViewBag.CurrentStage.WorkStart;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
     if (ViewBag.CurrentStage.WorkEnd != null)
    {
        WorkEnd = @ViewBag.CurrentStage.WorkEnd.ToString("yyyy-MM-dd");
    }
    else
    {
        WorkEnd = @ViewBag.CurrentStage.WorkEnd;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Изменение этапа</h3>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
 using (Html.BeginForm("Edit", "Stages", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n\r\n    ");
#nullable restore
#line 39 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">№ этапа:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"StageNumber\"");
            BeginWriteAttribute("value", " value=\"", 885, "\"", 926, 1);
#nullable restore
#line 44 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 893, ViewBag.CurrentStage.StageNumber, 893, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Наименование этапа:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"StageName\"");
            BeginWriteAttribute("value", " value=\"", 1113, "\"", 1152, 1);
#nullable restore
#line 51 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 1121, ViewBag.CurrentStage.StageName, 1121, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Срок - начало:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"date\" id=\"WorkStart\" name=\"WorkStart\"");
            BeginWriteAttribute("value", " value=\"", 1349, "\"", 1367, 1);
#nullable restore
#line 58 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 1357, WorkStart, 1357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1950-01-01\" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Срок - конец:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"date\" id=\"WorkEnd\" name=\"WorkEnd\" min=\"1950-01-01\"");
            BeginWriteAttribute("value", " value=\"", 1593, "\"", 1609, 1);
#nullable restore
#line 65 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 1601, WorkEnd, 1601, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Сумма этапа:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"Amount\"");
            BeginWriteAttribute("value", " value=\"", 1786, "\"", 1822, 1);
#nullable restore
#line 72 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 1794, ViewBag.CurrentStage.Amount, 1794, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Акт о завершении:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"CompletionAct\"");
            BeginWriteAttribute("value", " value=\"", 2013, "\"", 2056, 1);
#nullable restore
#line 80 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 2021, ViewBag.CurrentStage.CompletionAct, 2021, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Статус:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <select name=\"Status\" size=\"1\">\r\n\r\n");
#nullable restore
#line 90 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
                 if (@ViewBag.CurrentStage.Status == "Завершен")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b2879800", async() => {
                WriteLiteral("Завершен");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28711292", async() => {
                WriteLiteral("Не завершен");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28712477", async() => {
                WriteLiteral(" ");
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
#line 95 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
                }

                else if (@ViewBag.CurrentStage.Status == "Не завершен")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28713948", async() => {
                WriteLiteral("Завершен");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28715130", async() => {
                WriteLiteral("Не завершен");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28716626", async() => {
                WriteLiteral(" ");
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
#line 102 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28718047", async() => {
                WriteLiteral("Завершен");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28719229", async() => {
                WriteLiteral("Не завершен");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e63626c7a8038d250735ae9f82b473bf4d7b28720414", async() => {
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </select>\r\n        </td>\r\n    </tr>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n    <tr><br></tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">\r\n            <a class=\"btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 4112, "\"", 4180, 4);
            WriteAttributeValue("", 4119, "/Stages?themeId=", 4119, 16, true);
#nullable restore
#line 145 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 4135, ViewBag.ThemeId, 4135, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4151, "&themeName=", 4151, 11, true);
#nullable restore
#line 145 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"
WriteAttributeValue("", 4162, ViewBag.ThemeName, 4162, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Отмена</a>\r\n            <input type=\"submit\" class=\"btn btn-outline-primary submitBtn\" value=\"Изменить этап\" />\r\n        </td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n");
#nullable restore
#line 152 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Stages\ChangingStage.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
