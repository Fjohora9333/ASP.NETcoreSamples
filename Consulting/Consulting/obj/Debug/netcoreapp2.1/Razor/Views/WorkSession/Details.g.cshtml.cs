#pragma checksum "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eae20d1aa68b2876056fcdceabb982f77e33dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkSession_Details), @"mvc.1.0.view", @"/Views/WorkSession/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkSession/Details.cshtml", typeof(AspNetCore.Views_WorkSession_Details))]
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
#line 1 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\_ViewImports.cshtml"
using Consulting;

#line default
#line hidden
#line 2 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\_ViewImports.cshtml"
using Consulting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eae20d1aa68b2876056fcdceabb982f77e33dcd", @"/Views/WorkSession/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3c487bc16d3646c319e259c5b539202ded5e4b", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkSession_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Consulting.Models.WorkSession>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>WorkSession</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(209, 46, false);
#line 14 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateWorked));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 42, false);
#line 17 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateWorked));

#line default
#line hidden
            EndContext();
            BeginContext(341, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(385, 47, false);
#line 20 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoursWorked));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 43, false);
#line 23 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoursWorked));

#line default
#line hidden
            EndContext();
            BeginContext(519, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(563, 51, false);
#line 26 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkDescription));

#line default
#line hidden
            EndContext();
            BeginContext(614, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(658, 47, false);
#line 29 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorkDescription));

#line default
#line hidden
            EndContext();
            BeginContext(705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(749, 46, false);
#line 32 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
            EndContext();
            BeginContext(795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(839, 42, false);
#line 35 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
            EndContext();
            BeginContext(881, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(925, 49, false);
#line 38 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvincialTax));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 45, false);
#line 41 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProvincialTax));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1107, 56, false);
#line 44 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalChargeBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1207, 52, false);
#line 47 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalChargeBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1303, 46, false);
#line 50 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consultant));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1393, 52, false);
#line 53 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consultant.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1489, 44, false);
#line 56 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contract));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1577, 45, false);
#line 59 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contract.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1669, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a781ed61f9224bdb903cba9193d9155a", async() => {
                BeginContext(1726, 4, true);
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
#line 64 "D:\ASP.NetFinalPrac\FinalReview2018_Consultant\Consulting\Consulting\Views\WorkSession\Details.cshtml"
                           WriteLiteral(Model.WorkSessionId);

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
            BeginContext(1734, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1742, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ce77bc68f6a49dfad5e83c10f5b1186", async() => {
                BeginContext(1764, 12, true);
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
            BeginContext(1780, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Consulting.Models.WorkSession> Html { get; private set; }
    }
}
#pragma warning restore 1591