#pragma checksum "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa3f65baca8f3a04492bce95292cb5a01603fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Delete), @"mvc.1.0.view", @"/Views/Authors/Delete.cshtml")]
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
#nullable restore
#line 1 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\_ViewImports.cshtml"
using GoodreadsDoppelganger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\_ViewImports.cshtml"
using GoodreadsDoppelganger.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa3f65baca8f3a04492bce95292cb5a01603fd2", @"/Views/Authors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d17931d94e75cffb64df8e97d384f9e69791e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoodreadsDoppelganger.Models.Author>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <hr />\r\n    <h1>");
#nullable restore
#line 12 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div style=\"padding:0px\">\r\n\r\n        <div style=\"float:left\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 289, "", 309, 1);
#nullable restore
#line 16 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
WriteAttributeValue("", 294, Model.ImageUrl, 294, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 309, "", 329, 1);
#nullable restore
#line 16 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
WriteAttributeValue("", 314, Model.FullName, 314, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:300px;\" />\r\n        </div>\r\n        <div style=\"float:left; margin-left:10px;\">\r\n            <p><span class=\"font-weight-bold\">Birth date: </span>");
#nullable restore
#line 19 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
                                                            Write(Model.BirthDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"font-weight-bold\">Average rating: </span>");
#nullable restore
#line 20 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
                                                                Write(Model.AverageRating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" of 5 stars</p>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container row\" style=\"margin-left:0px; padding:0px\">\r\n        <br />\r\n        <p>");
#nullable restore
#line 26 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
      Write(Model.Biography);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <h3>Books</h3>\r\n\r\n    <div style=\"padding:0px; height:150px; overflow:hidden;\">\r\n");
#nullable restore
#line 32 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
         foreach (var book in @Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"width:10%; max-height:10%; float:left; padding-right:10px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa3f65baca8f3a04492bce95292cb5a01603fd28430", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1164, "\"", 1184, 1);
#nullable restore
#line 36 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
WriteAttributeValue("", 1170, book.ImageUrl, 1170, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1185, "\"", 1202, 1);
#nullable restore
#line 36 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
WriteAttributeValue("", 1191, book.Title, 1191, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:100%\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
                                                                 WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa3f65baca8f3a04492bce95292cb5a01603fd212068", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1aa3f65baca8f3a04492bce95292cb5a01603fd212335", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 44 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Authors\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoodreadsDoppelganger.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
