#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a1272a78523d544d26134602c565437d06c88f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RIAs_Index), @"mvc.1.0.view", @"/Views/RIAs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a1272a78523d544d26134602c565437d06c88f", @"/Views/RIAs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_RIAs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RD.Models.RIA>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RIAs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RIA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
  
    ViewBag.Title = "РИД";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h3>РИД ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a1272a78523d544d26134602c565437d06c88f3846", async() => {
                WriteLiteral(" + ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h3> 

<br>

<table class=""table table-hover "" style=""text-align: center;"">

    <thead>
        <tr>
            <th scope=""col""></th>
            <th scope=""col"">Результат</th>
            <th scope=""col"">Реквизиты</th>
            <th scope=""col"">Авторы</th>
            <th scope=""col"">Местоположение</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 25 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
         foreach (var ria in @ViewBag.RIAs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
           Write(ria.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
           Write(ria.Props);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
           Write(ria.Authors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
           Write(ria.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
           Write(Html.ActionLink("изменить", "ChangingRIA", new { id = ria.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 855, "\"", 885, 3);
            WriteAttributeValue("", 865, "deleteRIA(\'", 865, 11, true);
#nullable restore
#line 35 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
WriteAttributeValue("", 876, ria.Id, 876, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 883, "\')", 883, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"> удалить </a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\RIAs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>



<script type=""text/javascript"">
        function deleteRIA(riaId) {
            $.ajax({
                url: '/delete_ria/' + riaId,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RD.Models.RIA> Html { get; private set; }
    }
}
#pragma warning restore 1591
