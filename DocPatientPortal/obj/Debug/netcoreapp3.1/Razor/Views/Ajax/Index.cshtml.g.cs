#pragma checksum "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Ajax\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0fc1c262ae0dd5c0a61075f9c8df69fda8a247a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_Index), @"mvc.1.0.razor-page", @"/Views/Ajax/Index.cshtml")]
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
#line 1 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\_ViewImports.cshtml"
using DocPatientPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\_ViewImports.cshtml"
using DocPatientPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fc1c262ae0dd5c0a61075f9c8df69fda8a247a", @"/Views/Ajax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9966a5f75c439dee45931d539b07351b3cdd91", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Ajax\Index.cshtml"
  
    Layout = "_LayoutPatient";
    //html code for ajaxcontroller.

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"submit\" class=\"btn btn-primary\" role=\"button\" onclick=\"Btnclick()\" />\r\n<input type =\"text\" id=\"setText\"/>\r\n<input type =\"text\" id=\"setTextB\"/>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n<script>\r\n\r\n    function Btnclick() {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 16 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Ajax\Index.cshtml"
             Write(Url.Action("newFunction", "Ajax"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            type: ""GET"",
            dataType:""text"",
            success: function (data) {
                parsedata = JSON.parse(data);
                console.log(parsedata);

                $('#setText').val(parsedata[0]);
                $('#setTextB').val(parsedata[1]);



            },
            error: function (err) {
                console.error(err);
            }
        });
    }

</script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocPatientPortal.Views.Ajax.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.Ajax.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.Ajax.IndexModel>)PageContext?.ViewData;
        public DocPatientPortal.Views.Ajax.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591