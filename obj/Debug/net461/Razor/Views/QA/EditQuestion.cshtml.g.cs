#pragma checksum "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47b4e97ee4a3a50fa6a8a5e6a0c8653682f9731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_EditQuestion), @"mvc.1.0.view", @"/Views/QA/EditQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QA/EditQuestion.cshtml", typeof(AspNetCore.Views_QA_EditQuestion))]
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
#line 1 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\_ViewImports.cshtml"
using Dapper_Project;

#line default
#line hidden
#line 2 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\_ViewImports.cshtml"
using Dapper_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47b4e97ee4a3a50fa6a8a5e6a0c8653682f9731", @"/Views/QA/EditQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e5a985084eba6a87f5f5a7756ec7c1601d37e2", @"/Views/_ViewImports.cshtml")]
    public class Views_QA_EditQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Questions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Help", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Errors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Discussion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Fun", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/QA/UpdateQuestion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
  
    ViewData["Title"] = "EditQuestion";

#line default
#line hidden
            BeginContext(66, 53, true);
            WriteLiteral("\r\n\r\n<h1>Edit Question</h1>\r\n\r\n<b style=\"color:green\">");
            EndContext();
            BeginContext(120, 15, false);
#line 9 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(135, 49, true);
            WriteLiteral("</b>\r\n<hr style=\"border:2px solid yellow;\" />\r\n\r\n");
            EndContext();
            BeginContext(184, 877, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47b4e97ee4a3a50fa6a8a5e6a0c8653682f97315967", async() => {
                BeginContext(232, 59, true);
                WriteLiteral("\r\n    <label>Title:</label> <input type=\"text\" name=\"Title\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 291, "\"", 311, 1);
#line 13 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 299, Model.Title, 299, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(312, 93, true);
                WriteLiteral(" />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <label>Details:</label> <textarea name=\"Detail\">");
                EndContext();
                BeginContext(406, 12, false);
#line 17 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
                                               Write(Model.Detail);

#line default
#line hidden
                EndContext();
                BeginContext(418, 91, true);
                WriteLiteral("</textarea>\r\n    <br />\r\n    <label>Category:</label> <select name=\"Category\" id=\"Category\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 509, "\"", 532, 1);
#line 19 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 517, Model.Category, 517, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 11, true);
                WriteLiteral(">\r\n        ");
                EndContext();
                BeginContext(544, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47b4e97ee4a3a50fa6a8a5e6a0c8653682f97317849", async() => {
                    BeginContext(565, 11, true);
                    WriteLiteral("Coding Help");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(585, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(595, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47b4e97ee4a3a50fa6a8a5e6a0c8653682f97319325", async() => {
                    BeginContext(618, 6, true);
                    WriteLiteral("Errors");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(633, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(643, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47b4e97ee4a3a50fa6a8a5e6a0c8653682f973110795", async() => {
                    BeginContext(670, 10, true);
                    WriteLiteral("Discussion");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(689, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(699, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47b4e97ee4a3a50fa6a8a5e6a0c8653682f973112271", async() => {
                    BeginContext(719, 9, true);
                    WriteLiteral("Fun stuff");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(737, 96, true);
                WriteLiteral("\r\n    </select>\r\n    <br />\r\n    <br />\r\n    <label>Tags:</label> <input type=\"text\" name=\"Tags\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 833, "\"", 852, 1);
#line 27 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 841, Model.Tags, 841, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(853, 47, true);
                WriteLiteral(" />\r\n\r\n    <input type=\"hidden\" name=\"Username\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 900, "\"", 923, 1);
#line 29 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 908, Model.Username, 908, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(924, 39, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 963, "\"", 980, 1);
#line 30 "C:\DevBuild4\WebApps\Blog\Dapper-Project\Dapper-Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 971, Model.ID, 971, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(981, 73, true);
                WriteLiteral(" />\r\n    <br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1061, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591
