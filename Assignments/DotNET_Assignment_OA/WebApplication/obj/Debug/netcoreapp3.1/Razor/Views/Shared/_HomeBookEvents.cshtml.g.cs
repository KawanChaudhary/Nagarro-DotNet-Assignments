#pragma checksum "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f93c07226f31646b4c02fcf8340f204aa41d2a5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HomeBookEvents), @"mvc.1.0.view", @"/Views/Shared/_HomeBookEvents.cshtml")]
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
#line 1 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\_ViewImports.cshtml"
using DomainLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\_ViewImports.cshtml"
using DomainLayer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\_ViewImports.cshtml"
using DomainLayer.OtherFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\_ViewImports.cshtml"
using BusinessLayer.AbstarctFactory.BookEventsFacade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\_ViewImports.cshtml"
using ServiceLayer.Service.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f93c07226f31646b4c02fcf8340f204aa41d2a5c", @"/Views/Shared/_HomeBookEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b107cb91e1ac5e0caaf3ade22f8371794984c95", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HomeBookEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_showBookEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
  
    var getDetails = _bookEventFacade.GetDetails();

    var bookEvents = new List<BookEventModel>();
    string extraClass2 = "";
    if (ViewData["heading"] is "Upcoming")
    {

        bookEvents = await getDetails.GetUpcomingBookEvent();
    }
    else
    {
        bookEvents = await getDetails.GetPastBookEvent();
        extraClass2 = ViewData["extraClass"].ToString();
    }
    string extraClass = "";
    if (bookEvents.Count < 4) extraClass = "disabled";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section");
            BeginWriteAttribute("class", " class=\"", 546, "\"", 571, 2);
            WriteAttributeValue("", 554, "pt-5", 554, 4, true);
#nullable restore
#line 22 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
WriteAttributeValue(" ", 558, extraClass2, 559, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <h3 class=\"d-block text-muted text-monospace font-weight-bold\">");
#nullable restore
#line 26 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                                                                          Write(ViewData["heading"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Book Events</h3>\r\n            </div>\r\n            <div class=\"col-6 text-right \">\r\n                <a");
            BeginWriteAttribute("class", " class=\"", 865, "\"", 910, 5);
            WriteAttributeValue("", 873, "btn", 873, 3, true);
            WriteAttributeValue(" ", 876, "btn-primary", 877, 12, true);
            WriteAttributeValue(" ", 888, "mb-3", 889, 5, true);
            WriteAttributeValue(" ", 893, "mr-1", 894, 5, true);
#nullable restore
#line 29 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
WriteAttributeValue(" ", 898, extraClass, 899, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 911, "\"", 939, 2);
            WriteAttributeValue("", 918, "#", 918, 1, true);
#nullable restore
#line 29 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
WriteAttributeValue("", 919, ViewData["heading"], 919, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\r\n                    ❮\r\n                </a>\r\n                <a");
            BeginWriteAttribute("class", " class=\"", 1038, "\"", 1079, 5);
            WriteAttributeValue("", 1046, "btn", 1046, 3, true);
            WriteAttributeValue(" ", 1049, "btn-primary", 1050, 12, true);
            WriteAttributeValue(" ", 1061, "mb-3", 1062, 5, true);
#nullable restore
#line 32 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
WriteAttributeValue(" ", 1066, extraClass, 1067, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1078, "", 1079, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1108, 2);
            WriteAttributeValue("", 1087, "#", 1087, 1, true);
#nullable restore
#line 32 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
WriteAttributeValue("", 1088, ViewData["heading"], 1088, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"next\">\r\n                    ❯\r\n                </a>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1263, "\"", 1288, 1);
#nullable restore
#line 37 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
WriteAttributeValue("", 1268, ViewData["heading"], 1268, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\r\n\r\n                    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 40 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                           var i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"carousel-item active\">\r\n                                <div class=\"row d-flex justify-content-center\">\r\n\r\n");
#nullable restore
#line 44 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                                       int j = 0;
                                        for (; i < bookEvents.Count; i++)
                                        {
                                            j++;
                                            var bookEvent = bookEvents[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f93c07226f31646b4c02fcf8340f204aa41d2a5c10492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bookEvent;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                                            if (j == 3) break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 57 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                             for (i = i + 1; i < bookEvents.Count; i++)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    <div class=\"row d-flex justify-content-center\">\r\n\r\n");
#nullable restore
#line 63 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                                           j = 0;
                                            for (; i < bookEvents.Count; i++)
                                            {
                                                j++;
                                                var bookEvent = bookEvents[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f93c07226f31646b4c02fcf8340f204aa41d2a5c13700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 68 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bookEvent;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                                                if (j == 3) break;
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 75 "C:\Users\kawansingh\Documents\kawan-kumar-singh\Assignments\DotNET_Assignment_OA\WebApplication\Views\Shared\_HomeBookEvents.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IBookEventFacade _bookEventFacade { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591