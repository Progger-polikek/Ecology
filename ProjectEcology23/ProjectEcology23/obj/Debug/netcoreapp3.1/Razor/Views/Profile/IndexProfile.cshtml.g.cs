#pragma checksum "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296037ed4acb42544d0d7dbb03d421f8290e46a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_IndexProfile), @"mvc.1.0.view", @"/Views/Profile/IndexProfile.cshtml")]
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
#line 1 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\_ViewImports.cshtml"
using ProjectEcology23;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\_ViewImports.cshtml"
using ProjectEcology23.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296037ed4acb42544d0d7dbb03d421f8290e46a9", @"/Views/Profile/IndexProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72dc7df0d9055cdc29c09468d55eed3744e0000c", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_IndexProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user-female.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
  
    ViewData["Title"] = "IndexProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"user-info\">\r\n    <div class=\"profile-image\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "296037ed4acb42544d0d7dbb03d421f8290e46a94249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span><a href=\"#\"><img src=\"../static/img/camera.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 219, "\"", 225, 0);
            EndWriteAttribute();
            WriteLiteral("></a></span>\r\n    </div>\r\n    <div class=\"name\">\r\n        <p class=\"user-name\">");
#nullable restore
#line 11 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                        Write(Model.fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"user-static\">Паспорт</p>\r\n        <p class=\"user-documents\">");
#nullable restore
#line 13 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                             Write(Model.pasport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"surname\">\r\n        <p class=\"user-name\">");
#nullable restore
#line 17 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                        Write(Model.sname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"user-static\">СНИЛС</p>\r\n        <p class=\"user-documents\">");
#nullable restore
#line 19 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                             Write(Model.snils);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"lastname\">\r\n        <p class=\"user-name\">");
#nullable restore
#line 23 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                        Write(Model.pname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"user-static\">ИНН</p>\r\n        <p class=\"user-documents\">");
#nullable restore
#line 25 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                             Write(Model.inn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"contacts-grid\">\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 843, "\"", 851, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div class=\"user-contacts\">\r\n        <p class=\"static-contacts contacts-label\">Мои данные и контакты: <br></p>\r\n        <p class=\"static-contacts\">Телефон: <span class=\"dynamic-contacts\">");
#nullable restore
#line 34 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                                                                      Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        <p class=\"static-contacts\">Почта: <span class=\"dynamic-contacts\">");
#nullable restore
#line 35 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                                                                    Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></span></p>\r\n        <p class=\"static-contacts\">Адрес: <span class=\"dynamic-contacts\">");
#nullable restore
#line 36 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Profile\IndexProfile.cshtml"
                                                                    Write(Model.homeplace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1301, "\"", 1309, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1327, "\"", 1335, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1353, "\"", 1361, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div class=\"user-edit-profile\">\r\n        <a href=\"#\">Редактировать учётную запись</a>\r\n        <hr class=\"hr-line1\">\r\n        <a href=\"#\">Удалить учётную запись</a>\r\n        <hr class=\"hr-line2\">\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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