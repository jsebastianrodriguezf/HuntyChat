#pragma checksum "I:\GIT\Hunty\HuntyChat\Hunty.Chat.Front.WebSite\Hunty.Chat.Front.WebSite\Views\ExternalChat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db24e4e7073de82f0b6b201991424d1c3f51d927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExternalChat_Index), @"mvc.1.0.view", @"/Views/ExternalChat/Index.cshtml")]
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
#line 1 "I:\GIT\Hunty\HuntyChat\Hunty.Chat.Front.WebSite\Hunty.Chat.Front.WebSite\Views\_ViewImports.cshtml"
using Hunty.Chat.Front.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\GIT\Hunty\HuntyChat\Hunty.Chat.Front.WebSite\Hunty.Chat.Front.WebSite\Views\_ViewImports.cshtml"
using Hunty.Chat.Front.WebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db24e4e7073de82f0b6b201991424d1c3f51d927", @"/Views/ExternalChat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df59ab2c064691e2de932f552931aa36433b78a3", @"/Views/_ViewImports.cshtml")]
    public class Views_ExternalChat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n  Weavy.url = \"https://1ca4a5e812a34d64a17560d00f8b6181.weavy.io\",\r\n  Weavy.tokenFactory = async () => \"");
#nullable restore
#line 8 "I:\GIT\Hunty\HuntyChat\Hunty.Chat.Front.WebSite\Hunty.Chat.Front.WebSite\Views\ExternalChat\Index.cshtml"
                               Write(ViewBag.token);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n</script>\r\n\r\n<h1>External Chat </h1>\r\n\r\n<div id=\"chat-container\" style=\"height:600px;\"></div>");
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