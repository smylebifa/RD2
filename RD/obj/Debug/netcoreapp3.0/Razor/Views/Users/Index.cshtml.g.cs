#pragma checksum "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55010f73ca962683e8e62a8fedd0f198a0ab56fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\_ViewImports.cshtml"
using RD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\_ViewImports.cshtml"
using RD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55010f73ca962683e8e62a8fedd0f198a0ab56fe", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-5 col-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-style: dashed; border-width:thin; border-color: #343a40; padding: 8px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
  
    ViewBag.Title = "Пользователи";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-hover"" style=""text-align: center;"">

    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Логин</th>
            <th scope=""col"">Пароль</th>
            <th scope=""col"">ФИО</th>
            <th scope=""col"">Активен</th>
            <th scope=""col"">Администратор</th>
            <th scope=""col""></th>
            <th scope=""col""></th>

        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 24 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
         foreach (var user in @ViewBag.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
           Write(user.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
           Write(user.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
           Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><input type=\"checkbox\" checked name=\"Активен\" disabled /></td>\r\n            <td><input type=\"checkbox\" checked");
            BeginWriteAttribute("name", " name=\"", 839, "\"", 846, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled /> </td>\r\n            \r\n            <td>");
#nullable restore
#line 33 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
           Write(Html.ActionLink("изменить", "User", new { id = user.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 980, "\"", 1012, 3);
            WriteAttributeValue("", 990, "deleteUser(\'", 990, 12, true);
#nullable restore
#line 34 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
WriteAttributeValue("", 1002, user.Id, 1002, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1010, "\')", 1010, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"> удалить </a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "D:\Институт\Магистратура\ВКР\Система RD\RD2\RD\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55010f73ca962683e8e62a8fedd0f198a0ab56fe7626", async() => {
                WriteLiteral(@"
    <table>
        <h4>Добавление пользователей</h4>

        <tr>
            <td style=""padding: 4px;"">Логин:</td>
            <td style=""padding: 4px;"">
                <input name=""Login"" />
            </td>
        </tr>
        <tr>
            <td style=""padding: 4px;"">Пароль:</td>
            <td style=""padding: 4px;"">
                <input type=""password"" name=""Password"" />
            </td>
        </tr>
        
        <tr>
            <td style=""padding: 2px;"">
                <input type=""submit"" value=""Добавить"" />
            </td>
            <td></td>
        </tr>

    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script type=""text/javascript"">
        function deleteUser(userId) {
            $.ajax({
                url: '/delete/' + userId,
                type: 'DELETE',
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
