#pragma checksum "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "768fbe1cc0c31a9a6b2265ff385b7415483d56bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/List.cshtml", typeof(AspNetCore.Views_Blog_List))]
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
#line 1 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768fbe1cc0c31a9a6b2265ff385b7415483d56bf", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4c4ed5ac3e278df4824cedd041440483ff138b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 76, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container mt-3\">\r\n    <h2>Blog List</h2>\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(194, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b652327d110a4edfa5ed10e23cf576df", async() => {
                BeginContext(268, 19, true);
                WriteLiteral("\r\n        Add\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(291, 76, true);
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
            EndContext();
#line 19 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
            BeginContext(419, 621, true);
            WriteLiteral(@"                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Image</th>
                            <th>Title</th>
                            <th>Date</th>
                            <th>is Approved</th>
                            <th>is Home</th>
                            <th>is Slider</th>
                            <th>Edit</th>
                            <th>Delete</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 36 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1121, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1184, 7, false);
#line 39 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1191, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1264, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83566a3f9ce5408090cb919f648e72ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1274, "~/img/", 1274, 6, true);
#line 41 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
AddHtmlAttributeValue("", 1280, item.Image, 1280, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1307, 69, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(1377, 10, false);
#line 43 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1387, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1427, 9, false);
#line 44 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 46 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (@item.isApproved)
                                {

#line default
#line hidden
            BeginContext(1568, 84, true);
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 49 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1760, 84, true);
            WriteLiteral("                                    <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 53 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(1879, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 57 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (@item.isHome)
                                {

#line default
#line hidden
            BeginContext(2037, 84, true);
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 60 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2229, 84, true);
            WriteLiteral("                                    <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 64 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2348, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 68 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (@item.isSlider)
                                {

#line default
#line hidden
            BeginContext(2508, 84, true);
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 71 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2700, 84, true);
            WriteLiteral("                                    <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 75 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2819, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2922, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3c452b35244b57b4a24cc3c453520f", async() => {
                BeginContext(3027, 76, true);
                WriteLiteral("\r\n                                    Edit\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3107, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3210, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30409740a6de46378e0ce5f29364a6c1", async() => {
                BeginContext(3309, 78, true);
                WriteLiteral("\r\n                                    Delete\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3391, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 89 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(3486, 56, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 92 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3590, 112, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    Blog Eklenmemis.\r\n                </div>\r\n");
            EndContext();
#line 98 "D:\backp\UDEMY_LESSON\ASP_NET_CORE\BlogApp\BlogApp\BlogApp.WebUI\Views\Blog\List.cshtml"
            }

#line default
#line hidden
            BeginContext(3717, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591