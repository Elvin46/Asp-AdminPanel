#pragma checksum "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc5212f1de8087a15d3dc889204f57197f7dc4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Blog_Details), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Blog/Details.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Fiorella.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Fiorella.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc5212f1de8087a15d3dc889204f57197f7dc4f", @"/Areas/AdminPanel/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2992bee574759c4e6cb3b966b813101f2ee56298", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 d-flex align-items-stretch"">
        <div class=""row"">
            <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">");
#nullable restore
#line 12 "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\Blog\Details.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>\r\n                        ");
#nullable restore
#line 14 "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\Blog\Details.cshtml"
                   Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <h5>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\GitHub\ASP.NET-Tasks\Fiorella\Fiorella\Areas\AdminPanel\Views\Blog\Details.cshtml"
                       Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
