#pragma checksum "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2221210d409a73d2d7d16a17276de2f395cdfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f2221210d409a73d2d7d16a17276de2f395cdfa", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c17c26a0cf4c903ad8b8f2b1531088e5948c7add", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CrmLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br/>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad</th>
        <th>Soyad</th>
        <th>Mail</th>
        <th>Cinsiyet</th>
        <th>Doğum Tarihi</th>
        <th>Sil</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
           Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
           Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
           Write(item.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
           Write(item.EmployeeMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
           Write(item.EmployeeGender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
           Write(item.EmployeeBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Sahil Rzayev\source\repos\Crm_UILayer\UILayer\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"#\" class=\"btn btn-outline-primary\">Yeni Çalışan Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
