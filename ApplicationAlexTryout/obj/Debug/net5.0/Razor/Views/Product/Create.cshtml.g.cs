#pragma checksum "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb55656e401bf327d730cea22256168af7e6daa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\_ViewImports.cshtml"
using ApplicationAlexTryout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\_ViewImports.cshtml"
using ApplicationAlexTryout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb55656e401bf327d730cea22256168af7e6daa4", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396a8e655d836750e80bc01cc92a708a5761a303", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationAlexTryout.Models.DB.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Product</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 36 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 39 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 41 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 47 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 49 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 50 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\Users\fsuarez\source\repos\ApplicationAlexTryout\ApplicationAlexTryout\Views\Product\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationAlexTryout.Models.DB.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
