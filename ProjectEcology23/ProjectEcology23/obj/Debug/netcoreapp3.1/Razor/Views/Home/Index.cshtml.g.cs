#pragma checksum "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c86667ac88a7d68d86ff18cf0e986929c17979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c86667ac88a7d68d86ff18cf0e986929c17979", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72dc7df0d9055cdc29c09468d55eed3744e0000c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"requests\">\r\n    <div class=\"filter-box\">\r\n        <div class=\"filter-left\">\r\n            <p class=\"filter-label\">Фильтр списка заявок</p>\r\n            <div class=\"filter-content\">\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 262, "\"", 270, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <span class=\"filter-input-label\">Номер заявки</span>\r\n                    <input style=\"background: #74BEB5; color: #F5F5F5;\" type=\"text\">\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 482, "\"", 490, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <span class=\"filter-input-label\">Фамилия</span>\r\n                    <input style=\"background: #74BEB5; color: #F5F5F5;\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 636, "\"", 650, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
        <div class=""filter-right"">
            <div class=""request-buttons"">
                <a href=""#"" class=""filter-button"">Очистить</a>
                <a href=""#"" class=""filter-button"">Поиск</a>
            </div>

            <div class=""filter-content"">
                <div");
            BeginWriteAttribute("class", " class=\"", 1002, "\"", 1010, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"filter-input-label\">Статус</span>\r\n\r\n                    <input style=\"background: #74BEB5; color: #F5F5F5;\" type=\"text\">\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1216, "\"", 1224, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""filter-input-label"">Дата</span>

                    <input style=""background: #74BEB5; color: #F5F5F5;"" type=""text"">

                </div>

            </div>
        </div>
    </div>

    <div class=""table-box"">

        <table class=""iksweb"">
            <tbody>
                <tr class=""table-head"">
                    <td>ID</td>
                    <td>Статус</td>
                    <td>Дата</td>
                    <td>Заявление</td>
                    <td>ФИО</td>
                    <td>Адрес</td>
                    <td>Номер</td>
                    <td>Решение</td>
                </tr>
");
#nullable restore
#line 62 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                 foreach (var petition in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 65 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 66 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.Petition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.FIO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.AddressPetition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                       Write(petition.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Max\Desktop\учеба 3 курс 2 сем\Мираббас\ProjectEcology23\ProjectEcology23\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<hr />");
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
