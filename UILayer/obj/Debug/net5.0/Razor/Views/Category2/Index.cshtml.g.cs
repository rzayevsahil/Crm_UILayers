#pragma checksum "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Category2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287237afa1b344bba60df93a48fbc58121d4e329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category2_Index), @"mvc.1.0.view", @"/Views/Category2/Index.cshtml")]
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
#line 1 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\_ViewImports.cshtml"
using UILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\_ViewImports.cshtml"
using UILayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287237afa1b344bba60df93a48fbc58121d4e329", @"/Views/Category2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c17c26a0cf4c903ad8b8f2b1531088e5948c7add", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Category2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h1>Ajax Kategori işlemleri</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287237afa1b344bba60df93a48fbc58121d4e3293827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>


<button class=""btn btn-outline-primary"" id=""btngetlist"">Kategori Listesi</button>
<button class=""btn btn-outline-warning"" id=""btncategoryadd"">Kategori Ekle</button>
<button class=""btn btn-outline-dark"" id=""btncategoryget"">Kategori Getir</button>
<button class=""btn btn-outline-danger"" id=""btncategorydelete"">Kategori Sil</button>
<button class=""btn btn-outline-info"" id=""btncategoryupdate"">Kategori Güncelle</button>

<div id=""listcategory""></div>
<br />
<br />
<div>
    <h5>Yeni Kategori Ekleme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""txtcategoryname"" placeholder=""Kategori Adını Giriniz..."" />
</div>
<br />
<br />
<div>
    <h5>ID'ye Göre Kategori Getirme</h5>
    <input type=""text"" class=""form-control"" id=""txtcategoryid"" placeholder=""Kategori ID Giriniz..."" />
</div>
<br />
<br />
<div id=""categorylistbyid""></div>
<br />
<br />
<div>
    <h5>Kategori Silme</h5>
    <input type=""text"" c");
            WriteLiteral(@"lass=""form-control"" id=""txtid"" placeholder=""Silinecek Kategori ID Değerini Giriniz..."" />
</div>
<br />
<br />
<div>
    <h5>Kategori Güncelleme</h5>
    <input type=""text"" class=""form-control"" id=""txteditid"" placeholder=""Güncellenecek Kategori ID Giriniz..."" />
    <br/>
    <input type=""text"" class=""form-control"" id=""txteditname"" placeholder=""Güncellenecek Kategori İsmi Giriniz..."" />
</div>

<script>
    $(""#btngetlist"").click(function () {
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""get"",
            url: ""/Category2/ListCategory"",
            success: function (funk) {
                let values = jQuery.parseJSON(funk);
                console.log(values);

                let htmls = `<table class=""table table-bordered"">
                                                <tr>
                                                    <th>Kategor ID</th>
                                                    <th>Kategor Adı</");
            WriteLiteral(@"th>
                                                </tr>`;
                $.each(values, (Index, value) => {
                    htmls += `<tr>
                                            <td>${value.CategoryID}</td>
                                            <td>${value.CategoryName}</td>
                                        </tr>`;
                });

                htmls += ""</table>"";
                $(""#listcategory"").html(htmls);
            }
        });
    });

    $(""#btncategoryadd"").click(function () {
        let values = {
            CategoryName: $(""#txtcategoryname"").val()
        };
        $.ajax({
            type: ""post"",
            url: ""/Category2/AddCategory/"",
            data: values,
            success: function (func) {
                let result = jQuery.parseJSON(func);
                //alert(""Kateggori Ekleme İşlemi Başarılıdır"");
                sweetAlert(""Kategori Ekleme İşlemi Başarılıdır"");
            }
        });
    });

    $(""");
            WriteLiteral(@"#btncategoryget"").click(x => {
        let id = $(""#txtcategoryid"").val();

        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""get"",
            url: ""/Category2/GetByID/"",
            data: { categoryId: id },
            success: function(funk3) {
                let result = jQuery.parseJSON(funk3);
                console.log(result);

                let htmls = `<table class=""table table-bordered"">
                                <tr>
                                    <th>Kategor ID</th>
                                    <th>Kategor Adı</th>
                                 </tr>
                                 <tr>
                                    <td>${result.CategoryID}</td>
                                    <td>${result.CategoryName}</td>
                                </tr>
                             </table>`;
                $(""#categorylistbyid"").html(htmls);
            }
        });
    });

  ");
            WriteLiteral(@"  $(""#btncategorydelete"").click(x => {
        let id = $(""#txtid"").val();

        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""get"",
            url: ""/Category2/DeleteCategory/""+id,
            data: { categoryId: id },
            success: function (funk4) {
                sweetAlert(""Kategori Başarılı Bir Şekilde Silindi"");
            }
        });
    });

    $(""#btncategoryupdate"").click(x => {
        let values = {
            CategoryID:$(""#txteditid"").val(),
            CategoryName:$(""#txteditname"").val()
        }

        $.ajax({
            type: ""post"",
            url: ""/Category2/UpdateCategory/"",
            data: values,
            success: function (funk4) {
                sweetAlert(""Güncelleme İşlemi Yapıldı"");
            }
        });
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
