#pragma checksum "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c58722a22b79ee7bce5ce38622f10a89d3ed6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_Index), @"mvc.1.0.view", @"/Views/Authentication/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c58722a22b79ee7bce5ce38622f10a89d3ed6d5", @"/Views/Authentication/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2e13a349facaf499aa626ec8dfc435eb92f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Authentication_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("loginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml"
  
    ViewData["Title"] = "Вход";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"modDialog\" class=\"modal fade\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c58722a22b79ee7bce5ce38622f10a89d3ed6d54453", async() => {
                WriteLiteral(@"

    <div class=""mb-3 row"">
        <div class=""col-sm-4 col-form-label""></div>

        <div class=""col-sm-3"">
            <label class=""form-label h3"">Вход</label>
        </div>

        <div class=""col-sm-5 col-form-label""></div>
    </div>

    <div class=""mb-3 row"">
        <div class=""col-sm-4 col-form-label""></div>

        <div class=""col-sm-3"">
            <label class=""form-label"">Логин</label>
            <input type=""text"" name=""login""");
                BeginWriteAttribute("value", " value=\"", 678, "\"", 700, 1);
#nullable restore
#line 27 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml"
WriteAttributeValue("", 686, ViewBag.Login, 686, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
        </div>

        <div class=""col-sm-5 col-form-label""></div>
    </div>

    <div class=""mb-3 row"">
        <div class=""col-sm-4 col-form-label""></div>

        <div class=""col-sm-3"">
            <label class=""form-label"">Пароль</label>
            <input type=""password"" name=""password""");
                BeginWriteAttribute("value", " value=\"", 1029, "\"", 1054, 1);
#nullable restore
#line 38 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml"
WriteAttributeValue("", 1037, ViewBag.Password, 1037, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"">
        </div>

        <div class=""col-sm-5 col-form-label""></div>
    </div>

    <br>

    <div class=""mb-3 row"">
        <div class=""col-sm-4 col-form-label""></div>

        <div class=""col-sm-3"">
            <button type=""submit"" class=""btn btn-primary"">Войти</button>
        </div>

        <div class=""col-sm-5 col-form-label""></div>
    </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(function () {
            $.ajaxSetup({ cache: false });
            $("".submitBtn"").click(function (e) {

                let loginForm = document.forms.loginForm;

                let login = loginForm.elements.login.value;
                let password = loginForm.elements.password.value;

                if (login == """") {
                    e.preventDefault();
                    $.get(this.href, function (data) {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Для регистрации нужно ввести логин</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });

                }
                
                else if (password == """") {
                    e.preventDefault();");
                WriteLiteral(@"
                    $.get(this.href, function (data) {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Для регистрации нужно ввести пароль</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });

                }

            });
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml"
  
    if (@ViewBag.Status == "errorWithLogin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function (data) {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Пользователь с таким логином не найден в системе</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 104 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml"
    }

    else if (@ViewBag.Status == "errorWithPassword")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function (data) {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Пароль введен неверно</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 114 "C:\Users\Oleg\source\repos\RD\RD2\RD\Views\Authentication\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
