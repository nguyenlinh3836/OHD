#pragma checksum "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19bf4b4115a024cfede0b823c2bf0d4bb387da34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_ViewImports.cshtml"
using OHD.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_ViewImports.cshtml"
using OHD.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_ViewImports.cshtml"
using OHD.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19bf4b4115a024cfede0b823c2bf0d4bb387da34", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fdba179080744a216b963adadff2d7895ef4e52", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-login h-100"" >
    <div class=""col-md-6 offset-md-3  mx-auto justify-content-center"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'>Sign In</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'>Sign Up</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class=""col-md-12"">
                    ");
#nullable restore
#line 20 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_AuthLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "D:\LEARN_PROJECT\OHD\OHD\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script>
        $(function () {
            var current = location.pathname;
            $('.nav-tabs li a').each(function () {
                var $this = $(this);
                if (current.indexOf($this.attr('href')) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
