#pragma checksum "D:\WorkSpace\BITM9_ASPNETCore\Projects\App07_ModelValidation\App07_ModelValidation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be6ab53dfa7e7091a805a3617cc7705e9336a817"
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
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App07_ModelValidation\App07_ModelValidation\Views\_ViewImports.cshtml"
using App07_ModelValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App07_ModelValidation\App07_ModelValidation\Views\_ViewImports.cshtml"
using App07_ModelValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6ab53dfa7e7091a805a3617cc7705e9336a817", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6e9da5306b1e4bc5ee450959a59b7966c15fa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App07_ModelValidation\App07_ModelValidation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Model Validation</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <button class=""btn btn-primary abc"">Primary</button>
        <button class=""btn btn-success abc"">Success</button>
        <button class=""btn btn-warning abc"">Warning</button>
        <button class=""btn btn-danger abc"">Danger</button>
        <button class=""btn btn-secondary abc"">Secondary</button>
        <button class=""btn btn-info abc"">Info</button>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

    $(document).ready(function () {

        $('.abc').mousemove(function () {
            let bg = $(this).css('background-color');
            $('body').css('background-color', bg);            
        });
    });
    </script>

");
            }
            );
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
