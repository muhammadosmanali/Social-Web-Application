#pragma checksum "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb8549a1a21cb661c7f7b2c4880f581db50c031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_FriendRequest_Index), @"mvc.1.0.view", @"/Areas/User/Views/FriendRequest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/FriendRequest/Index.cshtml", typeof(AspNetCore.Areas_User_Views_FriendRequest_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb8549a1a21cb661c7f7b2c4880f581db50c031", @"/Areas/User/Views/FriendRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58bfb62c7c94ac592d8b9fe4606e3e173262560", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_FriendRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Holara.Models.Friends>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer !important; text-decoration:none !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#262424 !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
 if (ViewBag.messege != null)
{

#line default
#line hidden
            BeginContext(171, 114, true);
            WriteLiteral("    <div class=\"container\" id=\"notification\">\r\n        <div class=\"panel-footer\">\r\n            <h5 class=\"notify\">");
            EndContext();
            BeginContext(286, 15, false);
#line 11 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                          Write(ViewBag.messege);

#line default
#line hidden
            EndContext();
            BeginContext(301, 35, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 14 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
}

#line default
#line hidden
            BeginContext(339, 56, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <h4>Friend Requests (");
            EndContext();
            BeginContext(396, 13, false);
#line 19 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                    Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(409, 356, true);
            WriteLiteral(@")</h4>
    <div class=""panel-footer"">
        <table id=""table_id"">
            <thead>
                <tr>
                    <th></th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 32 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
            BeginContext(830, 58, true);
            WriteLiteral("                    <tr>\r\n                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 888, "\"", 922, 1);
#line 35 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
WriteAttributeValue("", 894, user.ApplicationUser1.Image, 894, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(923, 168, true);
            WriteLiteral(" class=\"profile-pic zoom\" style=\"width:35px !important;height:35px !important;margin-top:5px !important\" /></td>\r\n                        <td><span title=\"See Profile\">");
            EndContext();
            BeginContext(1091, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fc3a6e273664b748e4c0d9730d92b38", async() => {
                BeginContext(1228, 48, false);
#line 36 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                                                                                                                                                                                         Write(Html.DisplayFor(m => user.ApplicationUser1.Name));

#line default
#line hidden
                EndContext();
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
#line 36 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                                                                                   WriteLiteral(user.ApplicationUser1.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1280, 42, true);
            WriteLiteral("</span></td>\r\n                        <td>");
            EndContext();
            BeginContext(1323, 49, false);
#line 37 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                       Write(Html.DisplayFor(m => user.ApplicationUser1.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                         if (user.ApplicationUser1.PhoneNumber == null)
                        {

#line default
#line hidden
            BeginContext(1479, 66, true);
            WriteLiteral("                            <td>No Phone Number Added yet..</td>\r\n");
            EndContext();
#line 41 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1629, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1662, 55, false);
#line 44 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                           Write(Html.DisplayFor(m => user.ApplicationUser1.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 45 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1751, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 46 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                         if (user.IsConfirmed)
                        {

#line default
#line hidden
            BeginContext(1826, 68, true);
            WriteLiteral("                            <td><p class=\"button\">Friends</p></td>\r\n");
            EndContext();
#line 49 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1978, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2010, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25b32474dae460b96f4b912f6acb2b7", async() => {
                BeginContext(2128, 14, true);
                WriteLiteral("Accept Request");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                                                                WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2146, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 53 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2180, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 55 "F:\Visual Studio Repositories\Holara\Holara\Areas\User\Views\FriendRequest\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2226, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2308, 233, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#table_id\').DataTable();\r\n        });\r\n        $(\"#notification\").show();\r\n        setTimeout(function () { $(\"#notification\").hide(); }, 3000);\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Holara.Models.Friends>> Html { get; private set; }
    }
}
#pragma warning restore 1591
