#pragma checksum "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b795a22dd517184de7ae8e866b4e58f13d9ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RMAListPartial), @"mvc.1.0.view", @"/Views/Shared/_RMAListPartial.cshtml")]
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
#line 1 "D:\Mvc\AjaxPaging\AjaxPaging\Views\_ViewImports.cshtml"
using AjaxPaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mvc\AjaxPaging\AjaxPaging\Views\_ViewImports.cshtml"
using AjaxPaging.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b795a22dd517184de7ae8e866b4e58f13d9ff1", @"/Views/Shared/_RMAListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a978d066f5048a03a661d5c68d468250d5e05d09", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RMAListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AjaxPaging.Helper.PagedData<AjaxPaging.Models.BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Title</th>\r\n            <th>Title</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
         foreach (var person in Model.Data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 15 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
               Write(person.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 18 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
               Write(person.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 22 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">\r\n");
#nullable restore
#line 27 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
                 for (int i = 1; i <= Model.NumberOfPages; i++)
                {
                    if (i == Model.CurrentPage)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
                          
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"page-number\" href=\"#\">");
#nullable restore
#line 35 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 36 "D:\Mvc\AjaxPaging\AjaxPaging\Views\Shared\_RMAListPartial.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AjaxPaging.Helper.PagedData<AjaxPaging.Models.BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
