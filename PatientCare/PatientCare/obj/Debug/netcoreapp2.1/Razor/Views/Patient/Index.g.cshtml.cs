#pragma checksum "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a45a5455e416dfb465662093614669382f49f932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Index), @"mvc.1.0.view", @"/Views/Patient/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/Index.cshtml", typeof(AspNetCore.Views_Patient_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a45a5455e416dfb465662093614669382f49f932", @"/Views/Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a333f1a4216e22e4c78c54054ac186467129245c", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PatientCare.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca3feee12d44c168071c895c98616c6", async() => {
                BeginContext(143, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 45, false);
#line 16 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 44, false);
#line 19 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 43, false);
#line 22 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(550, 40, false);
#line 25 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(590, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(646, 46, false);
#line 28 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(692, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(748, 40, false);
#line 31 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ohip));

#line default
#line hidden
            EndContext();
            BeginContext(788, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(844, 47, false);
#line 34 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(891, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(947, 44, false);
#line 37 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Deceased));

#line default
#line hidden
            EndContext();
            BeginContext(991, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1047, 47, false);
#line 40 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1150, 45, false);
#line 43 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1251, 42, false);
#line 46 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1349, 58, false);
#line 49 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProvinceCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1525, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1574, 44, false);
#line 58 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1674, 43, false);
#line 61 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1773, 42, false);
#line 64 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1871, 39, false);
#line 67 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1966, 45, false);
#line 70 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2067, 39, false);
#line 73 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ohip));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2162, 46, false);
#line 76 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(2208, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2264, 43, false);
#line 79 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Deceased));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2363, 46, false);
#line 82 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2465, 44, false);
#line 85 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2509, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2565, 41, false);
#line 88 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2606, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2662, 70, false);
#line 91 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProvinceCodeNavigation.ProvinceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2732, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2787, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8476e4eeac054e3fbad6ba124f14aa27", async() => {
                BeginContext(2839, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
                                       WriteLiteral(item.PatientId);

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
            BeginContext(2847, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2867, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b3b364635344834961a4ea0dce212a2", async() => {
                BeginContext(2922, 7, true);
                WriteLiteral("Details");
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
#line 95 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
                                          WriteLiteral(item.PatientId);

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
            BeginContext(2933, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2953, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa80040ea3ec49a298ac571b65b967df", async() => {
                BeginContext(3007, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
                                         WriteLiteral(item.PatientId);

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
            BeginContext(3017, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 99 "D:\Conestoga\Conestoga_2ndTerm_W19\PROG2230-MS_Web_Tech\FinalReview2018_Patient\PatientCare\PatientCare\Views\Patient\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3056, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PatientCare.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
