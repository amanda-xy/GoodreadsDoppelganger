#pragma checksum "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b9da8428b8740a43fe3930a9c8ab0f43a85dcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b9da8428b8740a43fe3930a9c8ab0f43a85dcb", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d17931d94e75cffb64df8e97d384f9e69791e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>by ");
#nullable restore
#line 7 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
  Write(Model.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                          Write(Model.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div style=\"padding:0px\">\r\n\r\n        <div style=\"float:left\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 220, "", 240, 1);
#nullable restore
#line 11 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
WriteAttributeValue("", 225, Model.ImageUrl, 225, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 240, "", 257, 1);
#nullable restore
#line 11 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
WriteAttributeValue("", 245, Model.Title, 245, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:300px;\" />\r\n        </div>\r\n        <div style=\"float:left; margin-left:10px;\">\r\n            <p><span class=\"font-weight-bold\">Genre: </span>");
#nullable restore
#line 14 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                       Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"font-weight-bold\">Pages: </span>");
#nullable restore
#line 15 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                       Write(Model.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"font-weight-bold\">Rating: </span>");
#nullable restore
#line 16 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                        Write(Model.Rating.ToString("#.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" of 5 stars</p>\r\n            <p><span class=\"font-weight-bold\">Publication date: </span>");
#nullable restore
#line 17 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                                  Write(Model.PublicationDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b9da8428b8740a43fe3930a9c8ab0f43a85dcb9030", async() => {
                WriteLiteral("\r\n                Edit\r\n            ");
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
#line 18 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b9da8428b8740a43fe3930a9c8ab0f43a85dcb11445", async() => {
                WriteLiteral("\r\n                Delete\r\n            ");
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
#line 21 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n</div>\r\n\r\n<div class=\"container row\" style=\"margin-left:0px; padding:0px\">\r\n    <br />\r\n    <p>");
#nullable restore
#line 29 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n<h2>Reviews (");
#nullable restore
#line 33 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
        Write(Model.Reviews.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h2>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b9da8428b8740a43fe3930a9c8ab0f43a85dcb14608", async() => {
                WriteLiteral("\r\n        New Review\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
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
            WriteLiteral("\r\n</div>\r\n\r\n<ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 42 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
     foreach (var review in Model.Reviews.OrderByDescending(r => r.PublicationDate))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li style=\"margin-top:40px;\">\r\n            <div class=\"card border-info\">\r\n                <div class=\"card-header\">\r\n                    <div style=\"float:left\">\r\n");
#nullable restore
#line 48 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                         if (review.HasSpoilers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"h3\">Contains spoilers!!</label>\r\n                            <button class=\"btn btn-outline-info\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse-");
#nullable restore
#line 51 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                                                                                        Write(review.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1986, "\"", 2012, 1);
#nullable restore
#line 51 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
WriteAttributeValue("", 2002, review.Id, 2002, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Show</button>\r\n");
#nullable restore
#line 52 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"h4\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                       Write(review.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of 5 stars\r\n                        </p>\r\n                    </div>\r\n                    <div style=\"float:right\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b9da8428b8740a43fe3930a9c8ab0f43a85dcb19775", async() => {
                WriteLiteral("\r\n                            Delete\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                                          WriteLiteral(review.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                 if (review.HasSpoilers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"panel-collapse collapse\"");
            BeginWriteAttribute("id", " id=\"", 2638, "\"", 2662, 2);
            WriteAttributeValue("", 2643, "collapse-", 2643, 9, true);
#nullable restore
#line 66 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
WriteAttributeValue("", 2652, review.Id, 2652, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 68 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                            Write(review.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer border-info\" style=\"padding-bottom:0px;\">\r\n                            <p>\r\n                                <small class=\"text-muted\">Published: ");
#nullable restore
#line 72 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                                Write(review.PublicationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"panel-collapse collapse show\"");
            BeginWriteAttribute("id", " id=\"", 3257, "\"", 3281, 2);
            WriteAttributeValue("", 3262, "collapse-", 3262, 9, true);
#nullable restore
#line 80 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
WriteAttributeValue("", 3271, review.Id, 3271, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 82 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                            Write(review.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer border-info\" style=\"padding-bottom:0px;\">\r\n                            <p>\r\n                                <small class=\"text-muted\">Published: ");
#nullable restore
#line 86 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                                                                Write(review.PublicationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </li>\r\n");
#nullable restore
#line 93 "C:\Users\eriks\source\repos\Skola\Utveckling av Webbapplikationer\GoodreadsDoppelganger\GoodreadsDoppelganger\Views\Books\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n");
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
