#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142be7c49e6d297d71caf8d0f9e42713a22792c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DocMain), @"mvc.1.0.view", @"/Views/Admin/DocMain.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142be7c49e6d297d71caf8d0f9e42713a22792c2", @"/Views/Admin/DocMain.cshtml")]
    public class Views_Admin_DocMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicManagementProject.Models.Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
  
    ViewData["Title"] = "Admin Manage Doctor";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142be7c49e6d297d71caf8d0f9e42713a22792c23937", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "142be7c49e6d297d71caf8d0f9e42713a22792c24197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142be7c49e6d297d71caf8d0f9e42713a22792c26077", async() => {
                WriteLiteral(@"





    <table class=""table table-sm"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Doctor Name</th>
                <th scope=""col"">Doctor Phone#</th>
                <th scope=""col"">-</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 31 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
                               Write(Html.DisplayFor(model => item.Doctor_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                    <td> ");
#nullable restore
#line 35 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
                    Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                    <td> ");
#nullable restore
#line 36 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
                    Write(Html.DisplayFor(model => item.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                    <td>\n                        <p>");
#nullable restore
#line 38 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
                      Write(Html.ActionLink("View Schedule", "DocViewSchedule", new { docid = item.Doctor_Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
                WriteLiteral("                        <p>");
#nullable restore
#line 40 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
                      Write(Html.ActionLink("Add Timeslots", "DocAddTimeSlot", new { docid = item.Doctor_Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    </td>\n                </tr>\n");
#nullable restore
#line 43 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </tbody>\n    </table>\n    <section>\n");
                WriteLiteral("\n        <p>");
#nullable restore
#line 51 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\DocMain.cshtml"
      Write(Html.ActionLink("Register New Doctor", "DocRegNew"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n\n\n    </section>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicManagementProject.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
