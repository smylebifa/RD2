#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a72924e1f5b13f71abd14980927d21f8ab0ecf8b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72924e1f5b13f71abd14980927d21f8ab0ecf8b", @"/Views/Themes/ChangingTheme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_ChangingTheme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.Theme>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
  
    ViewBag.Title = "Редактирование темы";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
 using (Html.BeginForm("Edit", "Themes", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        ");
#nullable restore
#line 11 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.FioManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.ExecutiveDepartment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\" placeholder=\"Заказчик работы\"");
            BeginWriteAttribute("name", "  name=\"", 815, "\"", 823, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 33 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.WorkStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 39 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.WorkEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 42 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\" placeholder=\"НДС\"");
            BeginWriteAttribute("name", "  name=\"", 1299, "\"", 1307, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 48 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.AmountWithoutVat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\" placeholder=\"Приказ об открытии темы\"");
            BeginWriteAttribute("name", " name=\"", 1593, "\"", 1600, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 57 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.DocType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\" placeholder=\"Реквизиты документа\"");
            BeginWriteAttribute("name", " name=\"", 1842, "\"", 1849, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 66 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.ResearchType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                <input type=\"text\" placeholder=\"Область знания\"");
            BeginWriteAttribute("name", " name=\"", 2122, "\"", 2129, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 72 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
           Write(Html.TextBoxFor(m => m.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>

        <tr>
            <td style=""padding: 2px;"">
                <input type=""button"" value=""Отмена"" onClick='location.href=""/Themes""' />
            </td>
            <td style=""padding: 2px;"">
                <input type=""submit"" value=""Изменить тему"" />
            </td>
        </tr>

    </table>
");
#nullable restore
#line 86 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Themes\ChangingTheme.cshtml"
}

#line default
#line hidden
#nullable disable
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
