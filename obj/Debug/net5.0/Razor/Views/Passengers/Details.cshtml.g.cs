#pragma checksum "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d016968ef45c31fcc8c578646769c851939fc03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passengers_Details), @"mvc.1.0.view", @"/Views/Passengers/Details.cshtml")]
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
#line 1 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\_ViewImports.cshtml"
using Project1.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\_ViewImports.cshtml"
using Project1.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d016968ef45c31fcc8c578646769c851939fc03", @"/Views/Passengers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed382bc46f6d4f8d4dfe000c9f65ea0726ede71", @"/Views/_ViewImports.cshtml")]
    public class Views_Passengers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project1.Data.Passenger>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Passenger</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flights[0].DepartureAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        </dd>
    </dl>
    <table>
        <tr>
            <th style=""border-top: solid; padding: 10px;"">Flight Number</th>
            <th style=""border-top: solid; padding: 10px;"">Departure Date</th>
            <th style=""border-top: solid; padding: 10px;"">Arrival Date</th>
            <th style=""border-top: solid; padding: 10px;"">Departure Time</th>
            <th style=""border-top: solid; padding: 10px;"">Arrival Time</th>
            <th style=""border-top: solid; padding: 10px;"">Departure Airport</th>
            <th style=""border-top: solid; padding: 10px;"">Arrival Airport</th>
            <th style=""border-top: solid; padding: 10px;"">Booking Number</th>
        </tr>
");
#nullable restore
#line 49 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
         foreach (var flight in Model.Flights)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 52 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 53 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.DepartureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 54 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.ArrivalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 55 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.DepartureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 56 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.ArrivalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 57 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.DepartureAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 58 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.ArrivalAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"border-top: solid; padding: 10px;\">");
#nullable restore
#line 59 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
                                                 Write(Html.DisplayFor(modelItem => flight.BookingNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 65 "C:\Users\Ahmed\Source\Repos\project1\Project1.Web\Views\Passengers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {  id = Model.PassengerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d016968ef45c31fcc8c578646769c851939fc0310745", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project1.Data.Passenger> Html { get; private set; }
    }
}
#pragma warning restore 1591
