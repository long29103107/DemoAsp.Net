#pragma checksum "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\DanhSachPhim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d882ad0507551b9477c9713badbfae56e24ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhSachPhim_Index), @"mvc.1.0.view", @"/Views/DanhSachPhim/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d882ad0507551b9477c9713badbfae56e24ece", @"/Views/DanhSachPhim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9065de80342ddc3c632bc3e9a56ebd6711f19b2", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhSachPhim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\DanhSachPhim\Index.cshtml"
  
    ViewData["Title"] = "DanhSach";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper row3"">
    <main class=""hoc container clear"">
        <!-- main body -->
        <!-- ################################################################################################ -->
        <div class=""content"">
            <!-- ################################################################################################ -->
            <div id=""gallery"">
                <figure>
                    <header class=""heading"">Danh sách phim</header>
                    <ul class=""nospace clear"" id=""ds"">
                       
                        
                    </ul>
                </figure>
            </div>
        </div>
    </main>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"<script>
        $(document).ready(function () {
            $.ajax({
                method: ""GET"",
                url: ""../api/phimapi"",
                data: {  }
            })
                .done(function (rs) {
                    ds = JSON.parse(rs);
                    console.log(ds);
                    ctphim = """";
                    $.each(ds, function (value, item) {
                        ctphim += '<li class=""one_quarter""><a href=""");
#nullable restore
#line 37 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\DanhSachPhim\Index.cshtml"
                                                                 Write(Url.Action("Details", "DanhSachPhim"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + item.Id + \'\"><img src=\"\'+ item.AnhPhim + \'\"/></a></li>\';\r\n                    })\r\n                    $(\"#ds\").html(ctphim);\r\n                });\r\n        });\r\n\r\n</script>\r\n");
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
