#pragma checksum "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b07030019d35ce3b4002d8a48b0625eb082b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Cover_Index), @"mvc.1.0.view", @"/Areas/User/Views/Cover/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Cover/Index.cshtml", typeof(AspNetCore.Areas_User_Views_Cover_Index))]
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
#line 1 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\_ViewImports.cshtml"
using Holara;

#line default
#line hidden
#line 2 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\_ViewImports.cshtml"
using Holara.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b07030019d35ce3b4002d8a48b0625eb082b3a", @"/Areas/User/Views/Cover/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58bfb62c7c94ac592d8b9fe4606e3e173262560", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Cover_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Holara.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
 if (Model.Count() > 0)
{
    foreach (var post in Model)
    {
        if (post.IsPublicOrNot)
        {
            if (post.Image != null)
            {

#line default
#line hidden
            BeginContext(298, 142, true);
            WriteLiteral("                <div class=\"container hide\">\r\n                    <div class=\"panel-header\">\r\n                        <img class=\"profile-pic\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 440, "\"", 462, 1);
#line 17 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
WriteAttributeValue("", 446, post.User.Image, 446, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(463, 66, true);
            WriteLiteral(">\r\n                        <label class=\"user-name\">&commat;&nbsp;");
            EndContext();
            BeginContext(530, 36, false);
#line 18 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                                                          Write(Html.DisplayFor(m => post.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(566, 35, true);
            WriteLiteral("<br><span class=\"date\">&nbsp;&nbsp;");
            EndContext();
            BeginContext(602, 39, false);
#line 18 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                                                                                                                                  Write(post.PostDateAndTime.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(641, 12, true);
            WriteLiteral("&nbsp;&nbsp;");
            EndContext();
            BeginContext(654, 39, false);
#line 18 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                                                                                                                                                                                      Write(post.PostDateAndTime.ToLongTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(693, 233, true);
            WriteLiteral("</span></label>\r\n                    </div>\r\n                    <div style=\"border-bottom-left-radius:15px !important;border-bottom-right-radius:15px !important;\" class=\"panel-body2\">\r\n                        <img class=\"post-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 926, "\"", 943, 1);
#line 21 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
WriteAttributeValue("", 932, post.Image, 932, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(944, 83, true);
            WriteLiteral(">\r\n                        <div class=\"post-desc\">\r\n                            <p>");
            EndContext();
            BeginContext(1028, 20, false);
#line 23 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                          Write(post.PostDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 114, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <br />\r\n");
            EndContext();
#line 28 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1210, 142, true);
            WriteLiteral("                <div class=\"container hide\">\r\n                    <div class=\"panel-header\">\r\n                        <img class=\"profile-pic\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1352, "\"", 1374, 1);
#line 33 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
WriteAttributeValue("", 1358, post.User.Image, 1358, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1375, 66, true);
            WriteLiteral(">\r\n                        <label class=\"user-name\">&commat;&nbsp;");
            EndContext();
            BeginContext(1442, 36, false);
#line 34 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                                                          Write(Html.DisplayFor(m => post.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 35, true);
            WriteLiteral("<br><span class=\"date\">&nbsp;&nbsp;");
            EndContext();
            BeginContext(1514, 39, false);
#line 34 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                                                                                                                                  Write(post.PostDateAndTime.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1553, 12, true);
            WriteLiteral("&nbsp;&nbsp;");
            EndContext();
            BeginContext(1566, 39, false);
#line 34 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                                                                                                                                                                                      Write(post.PostDateAndTime.ToLongTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1605, 266, true);
            WriteLiteral(@"</span></label>
                    </div>
                    <div style=""border-bottom-left-radius:15px !important;border-bottom-right-radius:15px !important;"" class=""panel-body2"">
                        <div class=""post-desc"">
                            <p>");
            EndContext();
            BeginContext(1872, 20, false);
#line 38 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
                          Write(post.PostDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1892, 114, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <br />\r\n");
            EndContext();
#line 43 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
            }
        }
    }
}
else
{

#line default
#line hidden
            BeginContext(2051, 150, true);
            WriteLiteral("    <div class=\"container hide\">\r\n        <div class=\"panel-header\">\r\n            <h5>No Post Added Yet............</h5>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 54 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\Cover\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Holara.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
