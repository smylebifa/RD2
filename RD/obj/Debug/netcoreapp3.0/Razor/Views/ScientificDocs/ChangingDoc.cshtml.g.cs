#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "476f9b4fd27c532b55b1da370317b687e3870ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScientificDocs_ChangingDoc), @"mvc.1.0.view", @"/Views/ScientificDocs/ChangingDoc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"476f9b4fd27c532b55b1da370317b687e3870ca4", @"/Views/ScientificDocs/ChangingDoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_ScientificDocs_ChangingDoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.ScientificDoc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
  
    ViewBag.Title = "Редактирование документации";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
 using (Html.BeginForm("Edit", "ScientificDocs", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        ");
#nullable restore
#line 11 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Наименование:</td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Результат:</td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
           Write(Html.TextBoxFor(m => m.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Расположение:</td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 29 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
           Write(Html.TextBoxFor(m => m.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 4px;\">Записи:</td>\r\n            <td style=\"padding: 4px;\">\r\n                ");
#nullable restore
#line 36 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
           Write(Html.TextBoxFor(m => m.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td style=\"padding: 2px;\">\r\n                <input type=\"submit\" value=\"Изменить пользователя\" />\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n\r\n    </table>\r\n");
#nullable restore
#line 48 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\ScientificDocs\ChangingDoc.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.ScientificDoc> Html { get; private set; }
    }
}
#pragma warning restore 1591
