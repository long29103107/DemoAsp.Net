#pragma checksum "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2db95f16caaa56dcb35533d0770af9bed2f10fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/_HeaderPartial.cshtml")]
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
#line 1 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\_ViewImports.cshtml"
using DoanRapphim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\_ViewImports.cshtml"
using DoanRapphim.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2db95f16caaa56dcb35533d0770af9bed2f10fb5", @"/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9065de80342ddc3c632bc3e9a56ebd6711f19b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<header id=""header"" class=""hoc clear"">
    <!-- ################################################################################################ -->
    <div id=""logo"" class=""fl_left"">
        <h1><a href=""index.html"">My Theatre</a></h1>
    </div>
    <nav id=""mainav"" class=""fl_right"">
        <ul class=""clear"">
            <li class=""active""><a href=""index.html"">Trang chủ</a></li>
            <li>
                <a class=""drop"" href=""#"">Pages</a>
                <ul>
                    <li><a href=""pages/gallery.html"">Gallery</a></li>
                    <li><a href=""pages/full-width.html"">Full Width</a></li>
                    <li><a href=""pages/sidebar-left.html"">Sidebar Left</a></li>
                    <li><a href=""pages/sidebar-right.html"">Sidebar Right</a></li>
                    <li><a href=""pages/basic-grid.html"">Basic Grid</a></li>
                </ul>
            </li>
            <!-- <li><a class=""drop"" href=""#"">Dropdown</a>
      <ul>
        <li><a href=""#"">Level 2</a>");
            WriteLiteral(@"</li>
        <li><a class=""drop"" href=""#"">Level 2 + Drop</a>
          <ul>
            <li><a href=""#"">Level 3</a></li>
            <li><a href=""#"">Level 3</a></li>
            <li><a href=""#"">Level 3</a></li>
          </ul>
        </li>
        <li><a href=""#"">Level 2</a></li>
      </ul>
    </li> -->
            <li><a href=""#"">Phim</a></li>
            <li><a href=""#"">Mua vé</a></li>

");
#nullable restore
#line 35 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
              
                if (TempData.Peek("user") != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a class=\"drop\" href=\"#\">");
#nullable restore
#line 39 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
                                            Write(TempData.Peek("user"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <ul>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2db95f16caaa56dcb35533d0770af9bed2f10fb56891", async() => {
                WriteLiteral("Đăng xuất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <input type=\"hidden\" name=\"name\" id=\"tendangnhap\"");
            BeginWriteAttribute("value", " value=\"", 1829, "\"", 1857, 1);
#nullable restore
#line 42 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
WriteAttributeValue("", 1837, TempData.Peek("id"), 1837, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 45 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
                }
                if (TempData.Peek("admin") != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a class=\"drop\" href=\"#\">");
#nullable restore
#line 49 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
                                            Write(TempData.Peek("admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <ul>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2db95f16caaa56dcb35533d0770af9bed2f10fb59525", async() => {
                WriteLiteral("Quản Lý");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2db95f16caaa56dcb35533d0770af9bed2f10fb511124", async() => {
                WriteLiteral("Đăng xuất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <input type=\"hidden\" name=\"name\" id=\"tendangnhap\"");
            BeginWriteAttribute("value", " value=\"", 2432, "\"", 2460, 1);
#nullable restore
#line 53 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
WriteAttributeValue("", 2440, TempData.Peek("id"), 2440, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 56 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
                }
                if (TempData.Peek("admin") == null && (TempData.Peek("user") == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2db95f16caaa56dcb35533d0770af9bed2f10fb513385", async() => {
                WriteLiteral("Đăng nhập");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 60 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\Shared\_HeaderPartial.cshtml"
                }
                TempData.Keep("user");
                TempData.Keep("admin");
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n    <!-- ################################################################################################ -->\r\n</header>\r\n");
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
