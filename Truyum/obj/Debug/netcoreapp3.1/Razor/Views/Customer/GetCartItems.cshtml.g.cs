#pragma checksum "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87e2b2117b08cb35dbef3e3228715cb0a4afd5ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetCartItems), @"mvc.1.0.view", @"/Views/Customer/GetCartItems.cshtml")]
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
#line 1 "E:\TruYum\Truyum\Views\_ViewImports.cshtml"
using Truyum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TruYum\Truyum\Views\_ViewImports.cshtml"
using Truyum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e2b2117b08cb35dbef3e3228715cb0a4afd5ca", @"/Views/Customer/GetCartItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4105c2c3e7f755cf4a0a318e1ed2a2f97831e61a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetCartItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Truyum.Models.Cart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
  
    ViewData["Title"] = "GetCartItems";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetCartItems</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 15 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.FreeDelivery));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           int Total = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
         foreach (var item in Model)
        {
            Total += 100+Convert.ToInt32(item.Price);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 48 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.FreeDelivery));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n\r\n                ");
#nullable restore
#line 68 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
           Write(Html.ActionLink("Delete", "DeleteCartItem", new { id = item.CartId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p class=\"total\">Total:");
#nullable restore
#line 74 "E:\TruYum\Truyum\Views\Customer\GetCartItems.cshtml"
                  Write(Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Truyum.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
