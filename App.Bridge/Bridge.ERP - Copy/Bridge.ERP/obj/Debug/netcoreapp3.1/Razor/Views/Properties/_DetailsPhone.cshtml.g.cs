#pragma checksum "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d5e44efec28e2033801d11693b9909f1fed686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties__DetailsPhone), @"mvc.1.0.view", @"/Views/Properties/_DetailsPhone.cshtml")]
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
#line 1 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\_ViewImports.cshtml"
using Bridge.ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\_ViewImports.cshtml"
using Bridge.ERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d5e44efec28e2033801d11693b9909f1fed686", @"/Views/Properties/_DetailsPhone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91fcb07300348ed35c1a2c412214c1631435f3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Properties__DetailsPhone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bridge.ERP.Models.Property>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
  
    ViewData["Title"] = "Phones";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 12 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 15 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
           Write(Html.DisplayFor(model => model.PropertyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
                                                              Write(Html.DisplayFor(model => model.PropertyCity));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
    <h3>Phones</h3>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Phone
                </th>
                <th>
                    Type
                </th>
                <th>
                    Score
                </th>
                <th>
                    Status
                </th>
                <th>
                    SkipTraceSource
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
             foreach (var item in Model.Phones)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                       <a");
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1162, 2);
            WriteAttributeValue("", 1141, "tel:", 1141, 4, true);
#nullable restore
#line 46 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
WriteAttributeValue("", 1145, item.PhoneNumber, 1145, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
                                                  Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SkipTraceSource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Properties\_DetailsPhone.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bridge.ERP.Models.Property> Html { get; private set; }
    }
}
#pragma warning restore 1591
