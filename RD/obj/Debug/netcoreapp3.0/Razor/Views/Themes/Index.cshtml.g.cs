#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba961f1cf1c07873fb8053e16066d80c89a1a86c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba961f1cf1c07873fb8053e16066d80c89a1a86c", @"/Views/Themes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.Theme>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Themes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Theme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<style>\r\n.theme_year:hover {\r\n    cursor: default;\r\n}\r\n</style>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <h3>Темы</h3>\r\n        </div>\r\n        <div class=\"col-sm\">\r\n            <h5> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba961f1cf1c07873fb8053e16066d80c89a1a86c5366", async() => {
                WriteLiteral("Добавить тему");
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
            WriteLiteral(@" </h5>        
        </div>
        <div class=""col-sm"">
            
            <h5 style=""padding: 0.5rem 1rem;"">
                <input type=""button"" class=""theme_year btn"" id=""theme_year"" style=""border-color: #0366d6; color: #0366d6;"" value=""2020""/>
            </h5>
        </div>
        <div class=""col-sm"">
            
            <div class=""dropdown"">
                
                    <button class=""btn dropdown-toggle"" style=""font-size: 1.25rem; font-weight: 500;"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Выбор года 
                    </button>
               
                    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                        <a class=""dropdown-item"" style=""color: #343a40;"" type=""button"" href=""#"" onclick=""changeYear(2020)"">2020</a>
                        <a class=""dropdown-item"" style=""color: #343a40;"" href=""#"" onclick=""changeYear(2021)"">2021</a");
            WriteLiteral(@">
                        <a class=""dropdown-item"" style=""color: #343a40;"" href=""#"" onclick=""changeYear(2022)"">2022</a>
                    </div>
            </div>
                
        </div>
    </div>
</div>


<script type=""text/javascript"">
    function changeYear(year) {
        theme_year = document.getElementById(""theme_year"");
        theme_year.value = year;
    }
</script>

<div style=""overflow-x:auto;"">
    <table class=""table table-hover"" style=""text-align: center; "">

        <thead class=""thead-dark"" >
            <tr>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem; padding-left: 1.5rem;vertical-align: middle;""></th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem; padding-left: 1.5rem;vertical-align: middle;""></th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">№ темы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:");
            WriteLiteral(@"0rem;padding-left: 1.5rem;vertical-align: middle;"">Наименование темы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">ФИО руководителя</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Подразделение исполнитель</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Заказчик работы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Срок - начало</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Срок - конец</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Общий объем финансирования</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;paddin");
            WriteLiteral(@"g-left: 1.5rem;vertical-align: middle;"">НДС</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Объем без НДС</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Приказ об открытии темы</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Вид документа</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Реквизиты документа</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Вид исследования</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: middle;"">Область знания</th>
                <th scope=""col"" style=""padding-bottom:0; padding-top:0rem;padding-left: 1.5rem;vertical-align: mid");
            WriteLiteral("dle;\">Статус</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 82 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
             foreach (var theme in @ViewBag.Themes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba961f1cf1c07873fb8053e16066d80c89a1a86c11555", async() => {
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-themeName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
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
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 87 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(Html.ActionLink("Изменить тему", "ChangingTheme", new { id = theme.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 89 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 90 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 91 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.FioManager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.ExecutiveDepartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 94 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.WorkStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.WorkEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Vat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.AmountWithoutVat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 99 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Decree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 110 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.DocType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 111 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Props);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 112 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.ResearchType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 124 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Knowledge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 125 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
               Write(theme.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 128 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
