#pragma checksum "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c548989f25d363c91dd15475471571522d35b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Province_Details), @"mvc.1.0.view", @"/Views/Province/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Province/Details.cshtml", typeof(AspNetCore.Views_Province_Details))]
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
#line 1 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\_ViewImports.cshtml"
using SailUI;

#line default
#line hidden
#line 2 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\_ViewImports.cshtml"
using SailUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c548989f25d363c91dd15475471571522d35b6", @"/Views/Province/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1e9916cd59e1578650c4c42fc471f260d477b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Province_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SailUI.Models.Province>
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Province</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(199, 40, false);
#line 14 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(239, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 36, false);
#line 17 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(363, 43, false);
#line 20 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(406, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(450, 39, false);
#line 23 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaxCode));

#line default
#line hidden
            EndContext();
            BeginContext(489, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(533, 43, false);
#line 26 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxRate));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(620, 39, false);
#line 29 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaxRate));

#line default
#line hidden
            EndContext();
            BeginContext(659, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(703, 43, false);
#line 32 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capital));

#line default
#line hidden
            EndContext();
            BeginContext(746, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(790, 39, false);
#line 35 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayFor(model => model.Capital));

#line default
#line hidden
            EndContext();
            BeginContext(829, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(873, 55, false);
#line 38 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IncludesFerderalTax));

#line default
#line hidden
            EndContext();
            BeginContext(928, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(972, 51, false);
#line 41 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayFor(model => model.IncludesFerderalTax));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1067, 57, false);
#line 44 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CountryCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1168, 65, false);
#line 47 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
       Write(Html.DisplayFor(model => model.CountryCodeNavigation.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1280, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5209838ebeb407c8df3aeff30b0c12e", async() => {
                BeginContext(1336, 4, true);
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
#line 52 "D:\FinalExamFatima\SailMVCFinalExamWinter2019\SailContainer\SailUI\Views\Province\Details.cshtml"
                           WriteLiteral(Model.ProvinceCode);

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
            BeginContext(1344, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1352, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78a1eeecabdb45a1bc3bc48a244c68c9", async() => {
                BeginContext(1374, 12, true);
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
            BeginContext(1390, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SailUI.Models.Province> Html { get; private set; }
    }
}
#pragma warning restore 1591
