#pragma checksum "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e0ce2de382da2dae7b8f67a92df1693712dc76a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListRoles), @"mvc.1.0.view", @"/Views/Administration/ListRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListRoles.cshtml", typeof(AspNetCore.Views_Administration_ListRoles))]
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
#line 1 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#line 2 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#line 3 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e0ce2de382da2dae7b8f67a92df1693712dc76a", @"/Views/Administration/ListRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be09d06ec40853b9afe4c88b5c8a7f66421e5976", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary w-auto mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary w-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/customscript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
  
    ViewBag.Title = "All Roles";

#line default
#line hidden
            BeginContext(176, 24, true);
            WriteLiteral("\r\n<h1>All Roles</h1>\r\n\r\n");
            EndContext();
#line 13 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(222, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(226, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e0ce2de382da2dae7b8f67a92df1693712dc76a8069", async() => {
                BeginContext(289, 12, true);
                WriteLiteral("Add new role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(305, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
    foreach (IdentityRole role in Model)
    {

#line default
#line hidden
            BeginContext(356, 98, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                Role Id : ");
            EndContext();
            BeginContext(455, 7, false);
#line 20 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                     Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(462, 98, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(561, 9, false);
#line 23 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                                  Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(570, 82, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(652, 1112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e0ce2de382da2dae7b8f67a92df1693712dc76a10925", async() => {
                BeginContext(720, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                     if ((await authorizationService.AuthorizeAsync(User, "EditRolePolicy")).Succeeded)
                    {

#line default
#line hidden
                BeginContext(850, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(874, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e0ce2de382da2dae7b8f67a92df1693712dc76a11742", async() => {
                    BeginContext(947, 4, true);
                    WriteLiteral("Edit");
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
#line 29 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                                                   WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(955, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                    }

                    

#line default
#line hidden
                BeginContext(1116, 44, true);
                WriteLiteral("                        <span class=\"d-none\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1160, "\"", 1191, 2);
                WriteAttributeValue("", 1165, "confirmDeleteSpan_", 1165, 18, true);
#line 34 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1183, role.Id, 1183, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1192, 228, true);
                WriteLiteral(">\r\n                            <span>Are you sure you want to delete?</span>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Yes</button>\r\n                            <a href=\"#\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1420, "\"", 1463, 4);
                WriteAttributeValue("", 1430, "confirmDelete(\'", 1430, 15, true);
#line 37 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1445, role.Id, 1445, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1453, "\',", 1453, 2, true);
                WriteAttributeValue(" ", 1455, "false);", 1456, 8, true);
                EndWriteAttribute();
                BeginContext(1464, 71, true);
                WriteLiteral(">No</a>\r\n                        </span>\r\n                        <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1535, "\"", 1559, 2);
                WriteAttributeValue("", 1540, "deleteSpan_", 1540, 11, true);
#line 39 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1551, role.Id, 1551, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1560, 65, true);
                WriteLiteral(">\r\n                            <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1625, "\"", 1667, 4);
                WriteAttributeValue("", 1635, "confirmDelete(\'", 1635, 15, true);
#line 40 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1650, role.Id, 1650, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1658, "\',", 1658, 2, true);
                WriteAttributeValue(" ", 1660, "true);", 1661, 7, true);
                EndWriteAttribute();
                BeginContext(1668, 46, true);
                WriteLiteral(">Delete</a>\r\n                        </span>\r\n");
                EndContext();
                BeginContext(1741, 16, true);
                WriteLiteral("                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                                                              WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1764, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 46 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1821, 265, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            No roles created yet
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">
                Use the button below to create a role
            </h5>
            ");
            EndContext();
            BeginContext(2086, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e0ce2de382da2dae7b8f67a92df1693712dc76a20829", async() => {
                BeginContext(2176, 43, true);
                WriteLiteral("\r\n                Create Role\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2223, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 63 "F:\Programming\ASP.NET Tutorial Practice\DotnetCore\EmployeeManagement\EmployeeManagement\Views\Administration\ListRoles.cshtml"
}

#line default
#line hidden
            BeginContext(2256, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2276, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2282, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e0ce2de382da2dae7b8f67a92df1693712dc76a23023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2326, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
