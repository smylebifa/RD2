#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149c361176de3be86651a7fc8e0a7e2defd1e981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ChangingUser), @"mvc.1.0.view", @"/Views/Users/ChangingUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149c361176de3be86651a7fc8e0a7e2defd1e981", @"/Views/Users/ChangingUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ChangingUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
  
    ViewBag.Title = "Редактирование пользователя";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"modDialog\" class=\"modal fade\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n\r\n<h3>Добавление пользователя</h3>\r\n<br>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
 using (Html.BeginForm("Edit", "Users", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    ");
#nullable restore
#line 18 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Логин:</td>\r\n        <td style=\"padding: 4px;\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
       Write(Html.TextBoxFor(m => m.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Пароль:</td>\r\n        <td style=\"padding: 4px;\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
       Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">ФИО:</td>\r\n        <td style=\"padding: 4px;\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
       Write(Html.TextBoxFor(m => m.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Email:</td>\r\n        <td style=\"padding: 4px;\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Активен:</td>\r\n        <td style=\"padding: 4px;\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
       Write(Html.CheckBox("IsActive", @Html.TextBoxFor(m => m.IsActive)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td style=\"padding: 4px;\">Администратор:</td>\r\n        <td style=\"padding: 4px;\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
       Write(Html.CheckBox("IsAdmin", @Html.TextBoxFor(m => m.IsAdmin)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
        </td>
    </tr>

   
    <tr>
        <td style=""padding: 4px;"">
        </td>

        <td style=""padding: 4px;"">
            <a class=""btn btn-outline-dark"" href=""/Users"" style=""text-align:center"">Отмена</a>
            <input type=""submit"" class=""btn btn-outline-primary submitBtn"" value=""Изменить пользователя"" />
        </td>

        <td style=""padding: 4px;"">
        </td>
    </tr>


</table>
");
#nullable restore
#line 80 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Users\ChangingUser.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591