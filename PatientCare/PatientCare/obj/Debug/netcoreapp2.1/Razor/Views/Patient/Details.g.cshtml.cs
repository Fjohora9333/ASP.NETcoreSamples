#pragma checksum "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52508d1a7994496e83933f30faa4a5e3dc077c92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Details), @"mvc.1.0.view", @"/Views/Patient/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/Details.cshtml", typeof(AspNetCore.Views_Patient_Details))]
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
#line 1 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\_ViewImports.cshtml"
using PatientCare;

#line default
#line hidden
#line 2 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\_ViewImports.cshtml"
using PatientCare.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52508d1a7994496e83933f30faa4a5e3dc077c92", @"/Views/Patient/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a333f1a4216e22e4c78c54054ac186467129245c", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientCare.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Patient</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 45, false);
#line 14 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 41, false);
#line 17 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(332, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(376, 44, false);
#line 20 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 40, false);
#line 23 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(548, 43, false);
#line 26 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(635, 39, false);
#line 29 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(674, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(718, 40, false);
#line 32 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(758, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(802, 36, false);
#line 35 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(838, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(882, 46, false);
#line 38 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(928, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(972, 42, false);
#line 41 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1058, 40, false);
#line 44 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ohip));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1142, 36, false);
#line 47 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ohip));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1222, 47, false);
#line 50 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1313, 43, false);
#line 53 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1400, 44, false);
#line 56 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deceased));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1488, 40, false);
#line 59 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deceased));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1572, 47, false);
#line 62 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1663, 43, false);
#line 65 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1750, 45, false);
#line 68 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1839, 41, false);
#line 71 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1924, 42, false);
#line 74 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2010, 38, false);
#line 77 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2092, 58, false);
#line 80 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2150, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2194, 67, false);
#line 83 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceCodeNavigation.ProvinceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2308, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902b57bfde734a128d4aa90b85dc6fe8", async() => {
                BeginContext(2361, 4, true);
                WriteLiteral("Edit");
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
#line 88 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Details.cshtml"
                           WriteLiteral(Model.PatientId);

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
            BeginContext(2369, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2377, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ec3fec9face41de8bafa1cd6b0577dd", async() => {
                BeginContext(2399, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2415, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientCare.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
