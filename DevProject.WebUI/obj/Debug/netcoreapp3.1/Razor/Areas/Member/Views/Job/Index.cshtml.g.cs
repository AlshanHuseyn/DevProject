#pragma checksum "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6797d800717513b970464effdc4296003e6df40a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Job_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Job/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6797d800717513b970464effdc4296003e6df40a", @"/Areas/Member/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d6581ae456042f04e51bfcd27f57eed8a3a162", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
 foreach (var item in Model)
{
    index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-2\">\n        <div class=\"card-header\">\n            ");
#nullable restore
#line 13 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"card-body\">\n            <h5 class=\"card-title\"><span class=\"text-danger\">Department :</span>");
#nullable restore
#line 16 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                           Write(item.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n            <p class=\"text-right\">\n");
#nullable restore
#line 20 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                 if (item.Reports.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-outline-dark\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 668, "\"", 698, 2);
            WriteAttributeValue("", 675, "#collapseExample-", 675, 17, true);
#nullable restore
#line 22 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
WriteAttributeValue("", 692, index, 692, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\n                        Hesabata Get<i class=\"fas fa-caret-square-down ml-2\"></i>\n                        <span class=\"badge badge-dark\">");
#nullable restore
#line 24 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                  Write(item.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </a>\n");
#nullable restore
#line 26 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"lead font-weight-bold font-italic d-block text-center mb-1\">\n                        Raport yazmayibsiniz,Is raportlarini yazin!\n                    </span>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6797d800717513b970464effdc4296003e6df40a9459", async() => {
                WriteLiteral("\n                        <i class=\"fas fa-feather mr-2\"></i>Raport Yaz\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                             WriteLiteral(item.Id);

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
            WriteLiteral("\n");
#nullable restore
#line 35 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" class=\"btn btn-outline-success\" data-toggle=\"modal\"\n                   data-target=\"#exampleModal\" data-id=\"");
#nullable restore
#line 37 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                    Tamamlandi olaraq isrele\n                </a>\n            </p>\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1681, "\"", 1708, 2);
            WriteAttributeValue("", 1686, "collapseExample-", 1686, 16, true);
#nullable restore
#line 41 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
WriteAttributeValue("", 1702, index, 1702, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6797d800717513b970464effdc4296003e6df40a13057", async() => {
                WriteLiteral("\n                    <i class=\"fas fa-feather mr-2\"></i>Raport Yaz\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                              WriteLiteral(item.Id);

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
            WriteLiteral(@"
                <table class=""table table-hover table-sm table-bordered"">
                    <tr>
                        <th>Basliq</th>
                        <th>Detay</th>
                        <th></th>
                        <th></th>
                    </tr>
");
#nullable restore
#line 52 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                     foreach (var raport in item.Reports)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 55 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                           Write(raport.Basliq);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 56 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                           Write(raport.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6797d800717513b970464effdc4296003e6df40a16659", async() => {
                WriteLiteral("<i class=\"far fa-edit mr-2\"></i>Guncelle");
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
#line 58 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                               WriteLiteral(raport.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 61 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\n            </div>\n\n\n        </div>\n    </div>\n");
#nullable restore
#line 68 "C:\Users\talib\source\repos\DevProject\DevProject.WebUI\Areas\Member\Views\Job\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Bildiris!</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-center font-weight-bold lead"">
                Tamamlandi olaraq isarelensinmi?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""fas fa-times mr-2""></i>Imtina</button>
                <button id=""btnSave"" type=""button"" class=""btn btn-primary""><i class=""fas fa-check mr-2""></i> Beli</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#exampleModal"").on(""show.bs.modal"",
                function (event) {
                    let tetikleyenElement = $(event.relatedTarget);
                    let data = tetikleyenElement.data(""id"");
                    $(""#btnSave"").click(function () {
                        $.ajax({
                            type: ""GET"",
                            contentType: ""application/json; charset=utf-8;"",
                            url: ""./TamamlaJob"",
                            data: { jobId: data },
                            success: function () {
                                window.location.reload();
                            },
                            error: function (error) {
                                alert(error.responseText);
                            }
                        });
                    });
                });
        });
    </script>
");
            }
            );
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
