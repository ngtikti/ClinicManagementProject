#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84f9a0d9beb180df0ac763b471805d39abd36d86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PatSearch), @"mvc.1.0.view", @"/Views/Admin/PatSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84f9a0d9beb180df0ac763b471805d39abd36d86", @"/Views/Admin/PatSearch.cshtml")]
    public class Views_Admin_PatSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicManagementProject.Models.Patient>>
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
#line 4 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
  
    ViewData["Title"] = "Patient Search";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84f9a0d9beb180df0ac763b471805d39abd36d863964", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84f9a0d9beb180df0ac763b471805d39abd36d864287", async() => {
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
                WriteLiteral(@"

    <title>Patient Registration</title>
    <style>
        form {
            width: 300px;
        }
    </style>
    <script>//function passwordCheck() {
                //    var pass = document.getElementById(""Password"").value;
                //    var repass = document.getElementById(""txtReType"").value;
                //    if (pass != repass)
                //        alert(""Password Mismatch"");
                //}</script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84f9a0d9beb180df0ac763b471805d39abd36d866609", async() => {
                WriteLiteral("\n\n    <h1 id=\"main\" class=\"alert alert-success\">Patient Directory</h1>\n    <hr />\n    <div>");
#nullable restore
#line 33 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
    Write(Html.ActionLink("View All Patient", "PatViewAll", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
#nullable restore
#line 34 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
     if (Model.Count() != 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table class=""table table-sm"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Patient Name</th>
                    <th scope=""col"">Age</th>
                    <th scope=""col"">Phone</th>
                    <th scope=""col"">-</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 48 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line 51 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
                                   Write(Html.DisplayFor(model => item.Patient_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                        <td> ");
#nullable restore
#line 52 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
                        Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                        <td> ");
#nullable restore
#line 53 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
                        Write(Html.DisplayFor(model => item.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                        <td> ");
#nullable restore
#line 54 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
                        Write(Html.DisplayFor(model => item.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                        <td>\n                            <p>");
#nullable restore
#line 56 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
                          Write(Html.ActionLink("View All Consultations", "PatAllCon", new { patid = item.Patient_Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 59 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                \n            </tbody>\n        </table>\n");
#nullable restore
#line 64 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 66 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <section class=\"alert alert-danger\">\n\n                ");
#nullable restore
#line 70 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 71 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
           Write(Html.ActionLink("Try Again", "PatSearchAll", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </section>\n");
#nullable restore
#line 73 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n        <section>\n            ");
#nullable restore
#line 78 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
       Write(Html.ActionLink("Back to Login", "Login", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </section>\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 81 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Admin\PatSearch.cshtml"
              await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                    WriteLiteral("        ");
                }
                );
                WriteLiteral("    ");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicManagementProject.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
