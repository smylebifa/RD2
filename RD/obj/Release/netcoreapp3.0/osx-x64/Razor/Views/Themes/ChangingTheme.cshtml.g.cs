#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c7938ba8894989487d3672663b531cfe0d053a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Themes_ChangingTheme), @"mvc.1.0.view", @"/Views/Themes/ChangingTheme.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c7938ba8894989487d3672663b531cfe0d053a", @"/Views/Themes/ChangingTheme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_ChangingTheme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.Theme>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Гос. Контракт", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Договор", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Контракт", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Хоз. договора", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Прикладное", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Фундаментальное", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Разработка", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Поисковое", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ОКР", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
  
    ViewBag.Title = "Редактирование темы";
    Layout = "_Layout";

    var CurTheme = ViewBag.CurrentTheme;

    var el = 0;

    if (CurTheme.DocType == "Гос.Контракт")

        el = 0;
    else if (CurTheme.DocType == "Договор")
        el = 1;
    else if (CurTheme.DocType == "Контракт")
        el = 2;
    else if (CurTheme.DocType == "Хоз.договора")
        el = 3;

    string WorkStart = "";
    string WorkEnd = "";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
     if (ViewBag.CurrentTheme.WorkStart != null)
    {
        WorkStart = @ViewBag.CurrentTheme.WorkStart.ToString("yyyy-MM-dd");
    }
    else
    {
        WorkStart = @ViewBag.CurrentTheme.WorkStart;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
     if (ViewBag.CurrentTheme.WorkEnd != null)
    {
        WorkEnd = @ViewBag.CurrentTheme.WorkEnd.ToString("yyyy-MM-dd");
    }
    else
    {
        WorkEnd = @ViewBag.CurrentTheme.WorkEnd;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Изменение темы</h3>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
 using (Html.BeginForm("Edit", "Themes", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n\r\n    ");
#nullable restore
#line 53 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Номер темы:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"number\" name=\"Number\"");
            BeginWriteAttribute("value", " value=\"", 1204, "\"", 1240, 1);
#nullable restore
#line 58 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 1212, ViewBag.CurrentTheme.Number, 1212, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Наименование темы:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"Name\"");
            BeginWriteAttribute("value", " value=\"", 1423, "\"", 1457, 1);
#nullable restore
#line 66 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 1431, ViewBag.CurrentTheme.Name, 1431, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">ФИО руководителя:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"FioManager\"");
            BeginWriteAttribute("value", " value=\"", 1643, "\"", 1683, 1);
#nullable restore
#line 73 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 1651, ViewBag.CurrentTheme.FioManager, 1651, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Подразделение исполнитель:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"ExecutiveDepartment\"");
            BeginWriteAttribute("value", " value=\"", 1887, "\"", 1936, 1);
#nullable restore
#line 80 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 1895, ViewBag.CurrentTheme.ExecutiveDepartment, 1895, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Заказчик работы:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"CustomerName\"");
            BeginWriteAttribute("value", " value=\"", 2123, "\"", 2165, 1);
#nullable restore
#line 87 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 2131, ViewBag.CurrentTheme.CustomerName, 2131, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Срок - начало:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"date\" id=\"WorkStart\" name=\"WorkStart\"");
            BeginWriteAttribute("value", " value=\"", 2362, "\"", 2380, 1);
#nullable restore
#line 94 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 2370, WorkStart, 2370, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1950-01-01\" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Срок - конец:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"date\" id=\"WorkEnd\" name=\"WorkEnd\" min=\"1950-01-01\"");
            BeginWriteAttribute("value", " value=\"", 2606, "\"", 2622, 1);
#nullable restore
#line 101 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 2614, WorkEnd, 2614, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Приказ об открытии темы:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"Decree\"");
            BeginWriteAttribute("value", " value=\"", 2811, "\"", 2847, 1);
#nullable restore
#line 108 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 2819, ViewBag.CurrentTheme.Decree, 2819, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Вид документа:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <select name=\"DocType\" size=\"1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a12548", async() => {
                WriteLiteral("Гос. Контракт");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a13731", async() => {
                WriteLiteral("Договор");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a14908", async() => {
                WriteLiteral("Контракт");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a16086", async() => {
                WriteLiteral("Хоз. договора");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Общий объем финансирования:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"number\" name=\"Amount\"");
            BeginWriteAttribute("value", " value=\"", 3497, "\"", 3533, 1);
#nullable restore
#line 127 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 3505, ViewBag.CurrentTheme.Amount, 3505, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">НДС:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"number\" name=\"Vat\"");
            BeginWriteAttribute("value", " value=\"", 3701, "\"", 3734, 1);
#nullable restore
#line 134 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 3709, ViewBag.CurrentTheme.Vat, 3709, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Объем без НДС:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"number\" name=\"AmountWithoutVat\"");
            BeginWriteAttribute("value", " value=\"", 3925, "\"", 3971, 1);
#nullable restore
#line 141 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 3933, ViewBag.CurrentTheme.AmountWithoutVat, 3933, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Реквизиты документа:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"Props\"");
            BeginWriteAttribute("value", " value=\"", 4155, "\"", 4190, 1);
#nullable restore
#line 148 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 4163, ViewBag.CurrentTheme.Props, 4163, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Тип исследования:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <select name=\"ResearchType\" size=\"1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a19908", async() => {
                WriteLiteral("Прикладное");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a21088", async() => {
                WriteLiteral("Фундаментальное");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a22273", async() => {
                WriteLiteral("Разработка");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a23453", async() => {
                WriteLiteral("Поисковое");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c7938ba8894989487d3672663b531cfe0d053a24632", async() => {
                WriteLiteral("ОКР");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Область знания:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"Knowledge\"");
            BeginWriteAttribute("value", " value=\"", 5485, "\"", 5524, 1);
#nullable restore
#line 185 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 5493, ViewBag.CurrentTheme.Knowledge, 5493, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Статус:</td>\r\n        <td style=\"padding: 4px;\">\r\n            <input type=\"text\" name=\"Status\"");
            BeginWriteAttribute("value", " value=\"", 5696, "\"", 5732, 1);
#nullable restore
#line 192 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
WriteAttributeValue("", 5704, ViewBag.CurrentTheme.Status, 5704, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </td>\r\n    </tr>\r\n\r\n\r\n");
            WriteLiteral(@"
    <tr><br></tr>

    <tr>
        <td style=""padding: 4px;"">
        </td>

        <td style=""padding: 4px;"">
            <a class=""btn btn-outline-dark"" href=""/Themes"" style=""text-align:center"">Отмена</a>
            <input type=""submit"" class=""btn btn-outline-primary submitBtn"" value=""Изменить тему"" />
        </td>

        <td style=""padding: 4px;"">
        </td>
    </tr>


</table>
");
#nullable restore
#line 220 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.Theme> Html { get; private set; }
    }
}
#pragma warning restore 1591
