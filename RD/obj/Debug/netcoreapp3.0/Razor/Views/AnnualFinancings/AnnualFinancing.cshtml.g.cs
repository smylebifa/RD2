#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc9983ae81d2d459894ef1fe6affad819570eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnnualFinancings_AnnualFinancing), @"mvc.1.0.view", @"/Views/AnnualFinancings/AnnualFinancing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc9983ae81d2d459894ef1fe6affad819570eb4", @"/Views/AnnualFinancings/AnnualFinancing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_AnnualFinancings_AnnualFinancing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.AnnualFinancing>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
  
    ViewBag.Title = "Редактирование финансирования";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
 using (Html.BeginForm("Edit", "AnnualFinancings", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        ");
#nullable restore
#line 11 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
   Write(Html.HiddenFor(m => m.ThemeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Год:</td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 16 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
           Write(Html.TextBoxFor(m => m.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Сумма:</td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
           Write(Html.TextBoxFor(m => m.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">\r\n            </td>\r\n\r\n            <td style=\"padding: 4px;\">\r\n                <a class=\"nav-link btn btn-outline-dark\"");
            BeginWriteAttribute("href", " href=\"", 835, "\"", 901, 4);
            WriteAttributeValue("", 842, "/Stages/Index/", 842, 14, true);
#nullable restore
#line 32 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
WriteAttributeValue("", 856, ViewBag.ThemeId, 856, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 872, "?themeName=", 872, 11, true);
#nullable restore
#line 32 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
WriteAttributeValue("", 883, ViewBag.ThemeName, 883, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Отмена</a>\r\n\r\n                <input class=\"btn btn-primary\" style=\"margin-left: 6px;\" type=\"submit\" value=\"Изменить финансирование\" />\r\n            </td>\r\n\r\n            <td style=\"padding: 4px;\">\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n");
#nullable restore
#line 42 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\AnnualFinancings\AnnualFinancing.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.AnnualFinancing> Html { get; private set; }
    }
}
#pragma warning restore 1591
