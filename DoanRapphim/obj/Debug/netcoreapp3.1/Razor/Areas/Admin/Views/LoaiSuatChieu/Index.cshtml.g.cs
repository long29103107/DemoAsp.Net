#pragma checksum "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cefc4263fce1d8601edc81f3efdbd37951ade4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_LoaiSuatChieu_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/LoaiSuatChieu/Index.cshtml")]
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
#line 1 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\_ViewImports.cshtml"
using DoanRapphim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\_ViewImports.cshtml"
using DoanRapphim.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cefc4263fce1d8601edc81f3efdbd37951ade4d", @"/Areas/Admin/Views/LoaiSuatChieu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1363a90749a6a5707a7a1c4e84ef79491e1872f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_LoaiSuatChieu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoanRapphim.Areas.Admin.Models.LoaiSuatChieuModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
  
    ViewData["Title"] = "Quản lý loại suất chiếu";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
    Tạo loại suất chiếu
</button>


<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 19 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenSuatChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiaSuatChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 706, "\"", 719, 1);
#nullable restore
#line 30 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
WriteAttributeValue("", 711, item.Id, 711, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenSuatChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GiaSuatChieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-primary btn-active\"");
            BeginWriteAttribute("id", " id=\"", 1051, "\"", 1064, 1);
#nullable restore
#line 38 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
WriteAttributeValue("", 1056, item.Id, 1056, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#Edit\">Edit</button>|\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cefc4263fce1d8601edc81f3efdbd37951ade4d7095", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cefc4263fce1d8601edc81f3efdbd37951ade4d9296", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<!-- Modal Create-->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Tạo suất chiếu mới</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

                ");
#nullable restore
#line 60 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
           Write(await Html.PartialAsync("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal Edit-->
<div class=""modal fade"" id=""Edit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""Editlabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Sửa loại suất chiếu</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

                ");
#nullable restore
#line 82 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
           Write(await Html.PartialAsync("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Đóng</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Areas\Admin\Views\LoaiSuatChieu\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<script>
    $('.btn-active').on('click', function (e) {
        e.preventDefault();
        var id = ($(this).attr('id'));
        $.ajax({
            url: '../../api/LoaiSuatChieuAPI/'+id,
            type: 'GET',
            dataType: 'json'
        }).done(function (data) {
            var lsc = data;
            console.log(lsc);
            $(""#Id"").val(lsc[0].Id);
            $(""#editname"").val(lsc[0].TenSuatChieu);
            $(""#editgia"").val(lsc[0].GiaSuatChieu);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoanRapphim.Areas.Admin.Models.LoaiSuatChieuModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
