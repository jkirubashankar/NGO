#pragma checksum "C:\Users\Lenovo\source\repos\NGO\NGO\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3792002a4850f9df542f16bbb205f9ad479162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\NGO\NGO\Views\_ViewImports.cshtml"
using NGO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\NGO\NGO\Views\_ViewImports.cshtml"
using NGO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3792002a4850f9df542f16bbb205f9ad479162", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31363b82102af789cfabdcc4279d00c354dfe815", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\NGO\NGO\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#btnSubmit').click(function () {
            if ($('#txtUsername').val() == 'admin' && $('#txtPassword').val() == 'admin') {
                window.location.href = '../Home/Admin';
            } else {
                alert(""Username and password is incorrect"");
            }
        });
    });
</script>

<div class=""row mt-5"">
    <div class=""col-md-4""""></div>
    <div class=""col-md-3"">
        <div class=""card"">
            <div class=""card-header"">
                Login
            </div>
            <div class=""card-body"">
                <div class=""form-group"">
                    <input type=""text"" id=""txtUsername"" placeholder=""User name"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <input type=""password"" id=""txtPassword"" placeholder=""password"" class=""form-control"" />
                </div>
                <div class=""form-group text-md-center"">
          ");
            WriteLiteral("          <button class=\"btn-primary\" id=\"btnSubmit\">Submit</button>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-5\"></div>\r\n</div>");
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
