#pragma checksum "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\DanhSachPhim\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c85f5d699124e4a61ebccf08914217c29e9002ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhSachPhim_Details), @"mvc.1.0.view", @"/Views/DanhSachPhim/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c85f5d699124e4a61ebccf08914217c29e9002ed", @"/Views/DanhSachPhim/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9065de80342ddc3c632bc3e9a56ebd6711f19b2", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhSachPhim_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoanRapphim.Areas.Admin.Models.PhimModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\DanhSachPhim\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"hidden\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 126, "\"", 143, 1);
#nullable restore
#line 6 "C:\Users\long2\OneDrive\Máy tính\DoAnAsp.Net\DoanRapphim\Views\DanhSachPhim\Details.cshtml"
WriteAttributeValue("", 134, Model.Id, 134, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""idphim"" />
<div class=""wrapper row3"">
    <main class=""hoc container clear"">
        <div class=""content"">
            <div id=""gallery"">
                <div class=""row"">
                    <div class=""col-8 offset-2"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <h1>Nội dung phim</h1>
                            </div>
                        </div>
                        <hr />
                        <div class=""row"" id=""phim"">
");
            WriteLiteral(@"                        </div>
                        <hr />
                        <div class=""row"">
                            <div class=""col-4"">
                                <label for=""thanhpho"">Thành phố</label>
                                <select class=""form-control"" id=""thanhpho"" name=""sellist1"">
                                </select>
                            </div>
                            <div class=""col-4"">
                                <label for=""quanhuyen"">Quận huyện</label>
                                <select class=""form-control"" id=""quanhuyen"" name=""sellist1"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85f5d699124e4a61ebccf08914217c29e9002ed5079", async() => {
                WriteLiteral("Chọn Quận/Huyện");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col-4"">
                                <label for=""rap"">Rạp  chiếu phim</label>
                                <select class=""form-control"" id=""rap"" name=""sellist1"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85f5d699124e4a61ebccf08914217c29e9002ed6381", async() => {
                WriteLiteral("Chọn Rạp");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col-4"">
                                <label for=""ngaychieu"">Chọn Ngày Chiếu</label>
                                <select class=""form-control"" id=""ngaychieu"" name=""sellist1"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85f5d699124e4a61ebccf08914217c29e9002ed7688", async() => {
                WriteLiteral("Chọn Ngày Chiếu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col-4"">
                                <label for=""giochieu"">Chọn Giờ Chiếu</label>
                                <select class=""form-control"" id=""giochieu"" name=""sellist1"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85f5d699124e4a61ebccf08914217c29e9002ed8999", async() => {
                WriteLiteral("Chọn Giờ Chiếu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col-4"">
                                <label for=""phong"">Chọn Phòng</label>
                                <select class=""form-control"" id=""phong"" name=""sellist1"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85f5d699124e4a61ebccf08914217c29e9002ed10299", async() => {
                WriteLiteral("Chọn Phòng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <br />
                        <div class=""row"">
                            <div class=""col-12"" id=""ghe"">

                            </div>
                        </div>
                        <br />
                        <center><button class=""btn btn-success"" id=""datve"">Đặt vé</button></center>
                    </div>
                </div>
            </div>
        </div>
    </main>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
//import { data } from ""jquery"";



        $(document).ready(function () {
            var id = $('#idphim').val();
            $.ajax({
                method: ""GET"",
                url: ""../../../api/phimapi/"" + id,
                data: {}
            })
                .done(function (rs) {
                    ds = JSON.parse(rs);
                    ctphim = """";
                    $.each(ds, function (value, item) {
                        date = new Date(item.NgayChieu);
                        ctphim += '<div class=""col-4""><img src=""' + item.AnhPhim + '"" alt=""Alternate Text"" /></div><div class=""col-8""><h2>' + item.TenPhim + '</h2><hr /><p>Thể loại: ' + item.TenLoai + '</p><p>Ngày chiếu: ' + date.getDate() + '/' + date.getMonth() + '/' + date.getFullYear() + '</p><p>Thời lượng: ' + item.ThoiLuong + '</p><p>Mô tả: ' + item.MoTa + '</p></div>';
                    })
                    $(""#phim"").html(ctphim);
                });
        });

        $(document).rea");
                WriteLiteral(@"dy(function () {
            var id = $('#idphim').val();
            $.ajax({
                method: ""GET"",
                url: ""../../../api/thanhphoapi/"" + id,
                data: {}
            })
                .done(function (rs) {
                    dstp = JSON.parse(rs);
                    dsthanhpho = "" <option>Chọn Thành Phố</option>"";
                    $.each(dstp, function (value, item) {
                        dsthanhpho += ' <option>' + item.ThanhPho + '</option>';
                    })
                    $(""#thanhpho"").html(dsthanhpho);
                });
        });

        $(""#thanhpho"").change(function () {
            var id = $('#idphim').val();
            var idtp = $(""#thanhpho"").val();
            if (idtp != 'Chọn Thành Phố') {
                $.ajax({
                    method: ""GET"",
                    url: ""../../../api/quanhuyenapi/"" + id,
                    data: {
                        'tp': idtp,
                    }
              ");
                WriteLiteral(@"  })
                    .done(function (rs) {
                        dsqh = JSON.parse(rs);
                        dsquanhhuyen = ""<option>Chọn Quận/Huyện</option>"";
                        $.each(dsqh, function (value, item) {
                            dsquanhhuyen += ' <option>' + item.QuanHuyen + '</option>';
                        })
                        $(""#quanhuyen"").html(dsquanhhuyen);
                    });
            }
            else {
                dsquanhhuyen = '<option>Chọn Quận/Huyện</option>';
                $(""#quanhuyen"").html(dsquanhhuyen);
                dsrap = '<option value=""' + 0 + '"">Chọn Rạp</option>';
                $(""#rap"").html(dsrap);
            }
        });

        $(""#quanhuyen"").change(function () {
            var id = $('#idphim').val();
            var idtp = $(""#thanhpho"").val();
            var idqh = $(""#quanhuyen"").val();
            if (idqh != 'Chọn Quận/Huyện' && idtp != 'Chọn Thành Phố') {
                $.ajax({
      ");
                WriteLiteral(@"              method: ""GET"",
                    url: ""../../../api/rapchieuphimapi/"" + id,
                    data: {
                        'tp': idtp,
                        'qh': idqh,
                    }
                })
                    .done(function (rs) {
                        dsr = JSON.parse(rs);
                        dsrap = '<option value=""' + 0 + '"">Chọn Rạp</option>';
                        $.each(dsr, function (value, item) {
                            dsrap += ' <option value=""' + item.Id + '"">' + item.TenRap + '</option>';
                        })
                        $(""#rap"").html(dsrap);
                    });
            }
            else {
                dsrap = '<option value=""' + 0 + '"">Chọn Rạp</option>';
                $(""#rap"").html(dsrap);
            }
        });

        $(""#rap"").change(function () {
            var id = $('#idphim').val();
            var idtp = $(""#thanhpho"").val();
            var idqh = $(""#quanhuyen"").val(");
                WriteLiteral(@");
            var idrap = $(""#rap"").val();
            if (idqh != 'Chọn Quận/Huyện' && idtp != 'Chọn Thành Phố ' && idrap != 'Chọn Rạp') {
                $.ajax({
                    method: ""GET"",
                    url: ""../../../api/lichchieuapi/"" + id,
                    data: {
                        'tp': idtp,
                        'qh': idqh,
                        'rp': idrap,
                    }
                })
                    .done(function (rs) {
                        dsn = JSON.parse(rs);
                        dsngay = '<option value="""">Chọn Ngày Chiếu</option>';
                        $.each(dsn, function (value, item) {
                            date = new Date(item.NgayChieu)
                            dsngay += ' <option value=""' + item.NgayChieu + '"">' + date.getDate() + '/' + date.getMonth() + '/' + date.getFullYear() + '</option>';
                        })
                        $(""#ngaychieu"").html(dsngay);
                    });
        ");
                WriteLiteral(@"    }
            else {
                dsrap = '<option value="""">Chọn Ngày Chiếu</option>';
                $(""#ngaychieu"").html(dsngay);
            }
        });

        $(""#ngaychieu"").change(function () {
                var id = $('#idphim').val();
                var idtp = $(""#thanhpho"").val();
                var idqh = $(""#quanhuyen"").val();
                var idrap = $(""#rap"").val();
                var idnc = $(""#ngaychieu"").val();
                if (idqh != 'Chọn Quận/Huyện' && idtp != 'Chọn Thành Phố ' && idrap != 'Chọn Rạp' && idnc != 'Chọn Ngày Chiếu') {
                    $.ajax({
                        method: ""GET"",
                        url: ""../../../api/suatchieuapi/"" + id,
                        data: {
                            'tp': idtp,
                            'qh': idqh,
                            'rp': idrap,
                            'nc': idnc,
                        }
                    })
                        .done(function (rs) {");
                WriteLiteral(@"
                            dsgc = JSON.parse(rs);
                            dsgio = '<option value="""">Chọn Giờ Chiếu</option>';
                            $.each(dsgc, function (value, item) {
                                date = new Date(item.GioChieu)
                                dsgio += ' <option value=""' + item.GioChieu + '"">' + date.getHours() + "":"";
                                if (date.getMinutes() < 10)
                                    dsgio += '0' + date.getMinutes() + ':';
                                else
                                    dsgio += date.getMinutes() + ':';
                                if (date.getSeconds() < 10)
                                    dsgio += '0' + date.getSeconds();
                                else
                                    dsgio += date.getSeconds();
                                dsgio += '</option>';
                            })
                            $(""#giochieu"").html(dsgio);
                       ");
                WriteLiteral(@" });
                }
                else {
                    dsgio = '<option value="""">Chọn Giờ Chiếu</option>';
                    $(""#giochieu"").html(dsgio);
                }
            });

        $(""#giochieu"").change(function () {
                var id = $('#idphim').val();
                var idtp = $(""#thanhpho"").val();
                var idqh = $(""#quanhuyen"").val();
                var idrap = $(""#rap"").val();
                var idnc = $(""#ngaychieu"").val();
                var idgc = $(""#giochieu"").val();
                if (idqh != 'Chọn Quận/Huyện' && idtp != 'Chọn Thành Phố ' && idrap != 'Chọn Rạp' && idnc != 'Chọn Ngày Chiếu' && idgc != 'Chọn Giờ Chiếu') {
                    $.ajax({
                        method: ""GET"",
                        url: ""../../../api/phongapi/"" + id,
                        data: {
                            'tp': idtp,
                            'qh': idqh,
                            'rp': idrap,
                            '");
                WriteLiteral(@"nc': idnc,
                            'gc': idgc,
                        }
                    })
                        .done(function (rs) {
                            dsp = JSON.parse(rs);
                            dsphong = '<option value="""">Chọn Phòng</option>';
                            $.each(dsp, function (value, item) {
                                dsphong += '<option value=""' + item.Id + '"">' + item.TenPhong + '</option>';
                            })
                            $(""#phong"").html(dsphong);
                        });
                }
                else {
                    dsphong = '<option value="""">Chọn Phòng</option>';
                    $(""#phong"").html(dsphong);
                }
            });

        $(""#phong"").change(function () {
            var id = $('#idphim').val();
            var idtp = $(""#thanhpho"").val();
            var idqh = $(""#quanhuyen"").val();
            var idrap = $(""#rap"").val();
            var idnc = $(""#ngay");
                WriteLiteral(@"chieu"").val();
            var idgc = $(""#giochieu"").val();
            var idp = $(""#phong"").val();
            
            if (idqh != 'Chọn Quận/Huyện' && idtp != 'Chọn Thành Phố ' && idrap != 'Chọn Rạp' && idnc != 'Chọn Ngày Chiếu' && idgc != 'Chọn Giờ Chiếu' && idp != 'Chọn Phòng') {
                $.ajax({
                    method: ""GET"",
                    url: ""../../../Api/PhongAPI/Hang"",
                    data: {
                        'id': id,
                        'tp': idtp,
                        'qh': idqh,
                        'rp': idrap,
                        'nc': idnc,
                        'gc': idgc,
                        'p': idp,
                            }
                        })
                            .done(function (rs) {
                                dsghe = JSON.parse(rs)
                                dsg = '<div class=""row""><div class=""col-12""><ul class=""ghichu"" ><li><div id=""chuadat""></div><small>Chưa đặt</small></li><li><di");
                WriteLiteral(@"v id=""datroi""></div><small>Đang được chọn</small></li><li><div class=""seat occupied""></div><small>Đã được chọn</small></li></ul ></div ></div>';

                                $.each(dsghe, function (value, item) {
                                    var dsghe = [];
                                    for (var x = 0; x < item.soluonghang; x++) {
                                        for (var i = 0; i < item.soluongcot; i++) {
                                            var tenghe = String.fromCharCode(x + 65) + i;
                                            dsghe.push(tenghe);
                                        }
                                    }
                                            $.ajax({
                                                method: ""GET"",
                                                url: ""../../../api/Veapi/DSGhe"",
                                                data: {
                                                    'id': id,
                          ");
                WriteLiteral(@"                          'tp': idtp,
                                                    'qh': idqh,
                                                    'rp': idrap,
                                                    'nc': idnc,
                                                    'gc': idgc,
                                                    'p': idp,
                                                    'dsghe': JSON.stringify(dsghe),
                                                }
                                            })
                                                .done(function (response) {
                                                    var dsgdc = JSON.parse(response);                                  
                                                        for (var x = 0; x < item.soluonghang; x++) {
                                                            dsg += '<center><div class=""row""><div class=""col-12"">';
                                                            ");
                WriteLiteral(@"for (var i = 0; i < item.soluongcot; i++) {
                                                                var tg = String.fromCharCode(x + 65) + i;
                                                                var flag = false;
                                                                $.each(dsgdc, function (value, item) {
                                                                    if (tg === item) {
                                                                        flag = true;
                                                                    }
                                                                });
                                                                if (flag == true) {
                                                                    dsg += '<div class=""seat "" style=""display:inline-block;"">' + tg + '</div>';
                                                                }
                                                                else {
  ");
                WriteLiteral(@"                                                                  dsg += '<div class=""seat occupied "" style=""display:inline-block;"">' + tg + '</div>';
                                                                }
                                                            }
                                                            dsg += '</div></div></center>';
                                                        }
                                                    $(""#ghe"").html(dsg);
                                                }); 
                                });                        
                            });
                }
                else {
                    dsg = '';
                    $(""#ghe"").html(dsg);
                }
        });

        $(""#datve"").click(function () {
            date = new Date();
            $.ajax({
                type: ""GET"",
                url: '../../../api/loaigheapi/' + 1 ,
                data: {
             ");
                WriteLiteral(@"   }
            }).done(function (rs) {
                var lghe = JSON.parse(rs);
                $.ajax({
                    type: ""GET"",
                    url: '../../../api/veapi/addve',
                    data: {
                        'id': $('#idphim').val(),
                        'tp': $(""#thanhpho"").val(),
                        'qh': $(""#quanhuyen"").val(),
                        'rp': $(""#rap"").val(),
                        'nc': $(""#ngaychieu"").val(),
                        'gc': $(""#giochieu"").val(),
                        'p': $(""#phong"").val(),
                        'idnd': $(""#tendangnhap"").val(),
                        'lg': lghe[0].Id,
                        'ghe': JSON.stringify(Danhsachghe),
                        'nd': date.toISOString(),
                        'gv': lghe[0].GiaVe,
                    }
                }).done(function (rs) {
                    alert(""Thành Công"");
                })
                    .fail(function (rs) {
    ");
                WriteLiteral("                    alert(\"Thất Bại\");\r\n                    });\r\n\r\n            });\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoanRapphim.Areas.Admin.Models.PhimModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
