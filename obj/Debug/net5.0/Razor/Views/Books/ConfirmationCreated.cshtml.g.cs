#pragma checksum "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a7e55bb3a89f469119cef24b2d44f541659f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_ConfirmationCreated), @"mvc.1.0.view", @"/Views/Books/ConfirmationCreated.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a7e55bb3a89f469119cef24b2d44f541659f48", @"/Views/Books/ConfirmationCreated.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d17931d94e75cffb64df8e97d384f9e69791e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_ConfirmationCreated : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-fluid\" style=\"padding:0px\">\r\n    <h1>Book successfully created!</h1>\r\n    <hr />\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h3>by ");
#nullable restore
#line 7 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
      Write(Model.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
                              Write(Model.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div>\r\n        <div style=\"float:left\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 271, "", 291, 1);
#nullable restore
#line 10 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
WriteAttributeValue("", 276, Model.ImageUrl, 276, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 291, "", 308, 1);
#nullable restore
#line 10 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
WriteAttributeValue("", 296, Model.Title, 296, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:300px;\" />\r\n        </div>\r\n        <div style=\"float:left; margin-left:10px;\">\r\n            <p><span class=\"font-weight-bold\">Genre: </span>");
#nullable restore
#line 13 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
                                                       Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"font-weight-bold\">Pages: </span>");
#nullable restore
#line 14 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
                                                       Write(Model.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"font-weight-bold\">Publication date: </span>");
#nullable restore
#line 15 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
                                                                  Write(Model.PublicationDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container row\" style=\"margin-left:0px; padding:0px\">\r\n    <br />\r\n    <p>");
#nullable restore
#line 23 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6a7e55bb3a89f469119cef24b2d44f541659f488420", async() => {
                WriteLiteral("\r\n    Edit\r\n");
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
#nullable restore
#line 26 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6a7e55bb3a89f469119cef24b2d44f541659f4810799", async() => {
                WriteLiteral("\r\n    Delete\r\n");
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
#nullable restore
#line 29 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\ConfirmationCreated.cshtml"
                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
