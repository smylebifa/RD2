#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e97acf3b5f01156d4dfa191325e8770bb57f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Themes_Index), @"mvc.1.0.view", @"/Views/Themes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e97acf3b5f01156d4dfa191325e8770bb57f7a", @"/Views/Themes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.Theme>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Themes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Theme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangingTheme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
  
    ViewBag.Title = "Темы";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .theme_year:hover {\r\n        cursor: default;\r\n    }\r\n</style>\r\n\r\n\r\n<div class=\"row\" style=\"align-items:center\">\r\n    <div class=\"col-sm-1\">\r\n        <h3>Темы</h3>\r\n    </div>\r\n    <div class=\"col-sm-1\">\r\n        <h3> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e97acf3b5f01156d4dfa191325e8770bb57f7a5670", async() => {
                WriteLiteral("+");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </h3>\r\n    </div>\r\n    <div class=\"col-sm-10\">\r\n\r\n");
            WriteLiteral("    </div>\r\n   \r\n\r\n");
            WriteLiteral(@"
</div>



<script type=""text/javascript"">
    function changeYear(year) {
        theme_year = document.getElementById(""theme_year"");

        if (year != null && typeof year !== ""undefined"")
            theme_year.value = year;
        else
            theme_year.value = ""год не выбран"";
    }
</script>

<div style=""overflow-x:auto;"">
    <table class=""table table-hover"" style=""text-align: center; "">

        <thead>
            <tr>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem; padding-left: 1.5rem;vertical-align: middle;""></th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem; padding-left: 1.5rem;vertical-align: middle;""></th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem; padding-left: 1.5rem;vertical-align: middle;""></th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">№ темы</th>
                <th scope=""col"" style=""padding");
            WriteLiteral(@"-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Наименование темы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">ФИО руководителя</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Подразделение исполнитель</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Заказчик работы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Срок - начало</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Срок - конец</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Общий объем финансирования</th>
                <th scope=""col"" style=""padding-bottom:0; ");
            WriteLiteral(@"padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">НДС</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Объем без НДС</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Приказ об открытии темы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Вид документа</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Реквизиты документа</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Вид исследования</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Область знания</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5");
            WriteLiteral("rem;vertical-align: middle;\">Статус</th>\r\n                <th scope=\"col\" style=\"padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;\">Документы</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 88 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
             foreach (var theme in @ViewBag.Themes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e97acf3b5f01156d4dfa191325e8770bb57f7a11044", async() => {
                WriteLiteral("Этапы");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                                                      WriteLiteral(theme.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                                                                                      WriteLiteral(theme.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["themeName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-themeName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["themeName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n                <td style=\"vertical-align:middle\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e97acf3b5f01156d4dfa191325e8770bb57f7a14528", async() => {
                WriteLiteral(" <i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                                                                                                          WriteLiteral(theme.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                <td style=\"vertical-align:middle\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 5460, "\"", 5494, 3);
            WriteAttributeValue("", 5470, "deleteTheme(\'", 5470, 13, true);
#nullable restore
#line 97 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
WriteAttributeValue("", 5483, theme.Id, 5483, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5492, "\')", 5492, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"> <i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a></td>\r\n");
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 100 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 101 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 102 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.FioManager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 103 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.ExecutiveDepartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 104 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n");
#nullable restore
#line 108 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                 if (@theme.WorkStart != null)
                {
                    if (@theme.WorkEnd != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 112 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                       Write(theme.WorkStart.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 113 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                       Write(theme.WorkEnd.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 114 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 117 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                       Write(theme.WorkStart.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 118 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                       Write(theme.WorkEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 119 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                    }
                }
                else if (@theme.WorkEnd != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 123 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                   Write(theme.WorkStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 124 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                   Write(theme.WorkEnd.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 125 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 128 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                   Write(theme.WorkStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 129 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                   Write(theme.WorkEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 130 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <td>");
#nullable restore
#line 133 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 134 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Vat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 135 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.AmountWithoutVat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 136 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Decree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 138 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.DocType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 139 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Props);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 140 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.ResearchType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 162 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Knowledge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 163 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n\r\n");
#nullable restore
#line 167 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                     foreach (var file in ViewBag.Docs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 8027, "\"", 8066, 4);
            WriteAttributeValue("", 8034, "docs/", 8034, 5, true);
#nullable restore
#line 169 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
WriteAttributeValue("", 8039, file.NameDoc, 8039, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8052, ".", 8052, 1, true);
#nullable restore
#line 169 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
WriteAttributeValue("", 8053, file.DocType, 8053, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("download", " download=\"", 8067, "\"", 8105, 3);
#nullable restore
#line 169 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
WriteAttributeValue("", 8078, file.NameDoc, 8078, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8091, ".", 8091, 1, true);
#nullable restore
#line 169 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
WriteAttributeValue("", 8092, file.DocType, 8092, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 170 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                   Write(file.NameDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 172 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 179 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

        </tbody>
    </table>
</div>


<script type=""text/javascript"">
    function deleteTheme(themeId) {
        $.ajax({
            url: '/delete_theme/' + themeId,
            type: 'DELETE',
            contentType: ""application/json; charset=utf-8"",
            success: function () {
                location.reload()
            },
            error: function () {
                alert(""Ошибка выполнения!"")
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.Theme> Html { get; private set; }
    }
}
#pragma warning restore 1591
