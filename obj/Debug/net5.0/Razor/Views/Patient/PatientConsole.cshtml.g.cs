#pragma checksum "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb295f0a14149e43b5eb033eaf85026a5bb171cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientConsole), @"mvc.1.0.view", @"/Views/Patient/PatientConsole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb295f0a14149e43b5eb033eaf85026a5bb171cd", @"/Views/Patient/PatientConsole.cshtml")]
    public class Views_Patient_PatientConsole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Patient/_PatientLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb295f0a14149e43b5eb033eaf85026a5bb171cd3962", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb295f0a14149e43b5eb033eaf85026a5bb171cd4224", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb295f0a14149e43b5eb033eaf85026a5bb171cd6106", async() => {
                WriteLiteral("\r\n    <section class=\"alert alert-danger\">\r\n        ");
#nullable restore
#line 14 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <section>\r\n        ");
#nullable restore
#line 17 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(Html.ActionLink("Book Appointment", "BookAppointment", new { str = Model.Username }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <br />\r\n    <section>\r\n        ");
#nullable restore
#line 21 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(Html.ActionLink("View Upcoming Appointments", "ViewBookedAppointments"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <br />\r\n    <section>\r\n        ");
#nullable restore
#line 25 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(Html.ActionLink("View Past Reports", "ViewPastReport"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <br />\r\n    <section>\r\n        ");
#nullable restore
#line 29 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(Html.ActionLink("Pay Outstanding Bills", "PendingPaymentList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <br />\r\n    <section>\r\n        ");
#nullable restore
#line 33 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(Html.ActionLink("Update Particulars", "UpdateParticulars"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <br />\r\n    <section>\r\n        ");
#nullable restore
#line 37 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(Html.ActionLink("Change Password", "ChangePassword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n    <section class=\"alert alert-danger\">\r\n        ");
#nullable restore
#line 40 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(ViewData["BookingMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 41 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(ViewData["DeleteBookingMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 42 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(ViewData["PaidBillMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 43 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(ViewData["ParticularsUpdateMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\Users\ngtik\Dropbox\dotnet Work\ClinicManagementProject\Views\Patient\PatientConsole.cshtml"
   Write(ViewData["ChangePasswordMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n");
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
            WriteLiteral("\r\n\r\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
