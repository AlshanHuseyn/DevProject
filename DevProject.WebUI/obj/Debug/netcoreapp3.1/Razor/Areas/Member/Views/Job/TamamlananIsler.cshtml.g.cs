#pragma checksum "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d63cca90d3c7844df265fcc8d882fc45fea977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Job_TamamlananIsler), @"mvc.1.0.view", @"/Areas/Member/Views/Job/TamamlananIsler.cshtml")]
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
#line 1 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.WebUI.Areas.Admin.Models.HomeModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.WebUI.Areas.Member.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.WebUI.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.DTO.DTOs.JobDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.DTO.DTOs.ReportDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using DevProject.DTO.DTOs.UserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16d63cca90d3c7844df265fcc8d882fc45fea977", @"/Areas/Member/Views/Job/TamamlananIsler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d6581ae456042f04e51bfcd27f57eed8a3a162", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Job_TamamlananIsler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TamamlananIsler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
  
    ViewData["Title"] = "TamamlananIsler";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container\">\n");
#nullable restore
#line 10 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
     foreach (var item in Model)
    {
        index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card my-2\">\n            <div class=\"card-header\">\n                ");
#nullable restore
#line 15 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"card-body\">\n                <h5 class=\"card-title\"><span class=\"text-danger\">Department :</span>");
#nullable restore
#line 18 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                                                                               Write(item.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                <p class=\"text-right\">\n");
#nullable restore
#line 22 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                     if (item.Reports.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"btn btn-outline-dark\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 759, "\"", 789, 2);
            WriteAttributeValue("", 766, "#collapseExample-", 766, 17, true);
#nullable restore
#line 24 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
WriteAttributeValue("", 783, index, 783, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\n                            Hesabata Get<i class=\"fas fa-caret-square-down ml-2\"></i>\n                            <span class=\"badge badge-dark\">");
#nullable restore
#line 26 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                                                      Write(item.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </a>\n");
#nullable restore
#line 28 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </p>\n                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1143, "\"", 1170, 2);
            WriteAttributeValue("", 1148, "collapseExample-", 1148, 16, true);
#nullable restore
#line 32 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
WriteAttributeValue("", 1164, index, 1164, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\n                    <table class=\"table table-hover table-sm table-bordered\">\n                        <tr>\n                            <th>Basliq</th>\n                            <th>Detay</th>\n                        </tr>\n");
#nullable restore
#line 39 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                         foreach (var raport in item.Reports)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 42 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                               Write(raport.Basliq);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 43 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                               Write(raport.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 45 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\n                </div>\n\n\n            </div>\n        </div>\n");
#nullable restore
#line 52 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <nav aria-label=\"Page navigation example\" class=\"float-right mx-2\">\n        <ul class=\"pagination\">\n");
#nullable restore
#line 56 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
             for (int i = 1; i <= ViewBag.UmumiSehife; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 1982, "\"", 2037, 2);
            WriteAttributeValue("", 1990, "page-item", 1990, 9, true);
#nullable restore
#line 58 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
WriteAttributeValue(" ", 1999, ViewBag.AktivSehife==i?"active":"", 2000, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d63cca90d3c7844df265fcc8d882fc45fea97711657", async() => {
                WriteLiteral("\n                        ");
#nullable restore
#line 60 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aktivSehife", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
                                                                                 WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aktivSehife"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aktivSehife", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aktivSehife"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </li>\n");
#nullable restore
#line 63 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\TamamlananIsler.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </ul>\n    </nav>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
