#pragma checksum "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd6379b7b98801b6674defa9fb357d6da56dd33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_Index), @"mvc.1.0.view", @"/Views/Properties/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Properties/Index.cshtml", typeof(AspNetCore.Views_Properties_Index))]
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
#line 1 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\_ViewImports.cshtml"
using LiveStreamSample;

#line default
#line hidden
#line 2 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\_ViewImports.cshtml"
using LiveStreamSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd6379b7b98801b6674defa9fb357d6da56dd33", @"/Views/Properties/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65aad4bd3cf55326c4e71ee272b9ddad39e84a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Properties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LiveStreamSample.Models.PropertyViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 200, true);
            WriteLiteral("<script src=\"https://code.jquery.com/jquery-1.10.2.min.js\" type=\"text/javascript\"></script>\r\n<h1>Properties</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(307, 40, false);
#line 13 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(347, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(403, 41, false);
#line 16 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(444, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(500, 44, false);
#line 19 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UrlImage));

#line default
#line hidden
            EndContext();
            BeginContext(544, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(600, 41, false);
#line 22 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
            EndContext();
            BeginContext(641, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(697, 43, false);
#line 25 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LiveUrl));

#line default
#line hidden
            EndContext();
            BeginContext(740, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(875, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(936, 39, false);
#line 35 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(975, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1043, 40, false);
#line 38 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1154, "\"", 1174, 1);
#line 41 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
WriteAttributeValue("", 1160, item.UrlImage, 1160, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1175, 95, true);
            WriteLiteral(" height=\"100\" width=\"100\" />\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1271, 40, false);
#line 44 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Owner));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 105, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div id=\"vid\" style=\"display: none\">\r\n");
            EndContext();
#line 48 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                         if (string.IsNullOrEmpty(item.LiveUrl))
                        {

#line default
#line hidden
            BeginContext(1509, 50, true);
            WriteLiteral("                            <p>Not available</p>\r\n");
            EndContext();
#line 51 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(1672, 22, false);
#line 54 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                       Write(Html.Raw(item.LiveUrl));

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                                                   
                        }

#line default
#line hidden
            BeginContext(1723, 112, true);
            WriteLiteral("                    </div>\r\n                    <input type=\"button\" id=\"btnLiveStream\" value=\"Live stream\" />\r\n");
            EndContext();
#line 58 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                     if (!string.IsNullOrEmpty(item.LiveUrl))
                    {

#line default
#line hidden
            BeginContext(1921, 63, true);
            WriteLiteral("                        <div>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1984, "\"", 2010, 1);
#line 61 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
WriteAttributeValue("", 1990, item.LiveStreamIcon, 1990, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2011, 60, true);
            WriteLiteral(" width=\"10\" height=\"10\" />\r\n                        </div>\r\n");
            EndContext();
#line 63 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2094, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2159, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cd6379b7b98801b6674defa9fb357d6da56dd3311057", async() => {
                BeginContext(2207, 7, true);
                WriteLiteral("Details");
                EndContext();
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
#line 66 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            BeginContext(2218, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 69 "C:\Users\KyleDo\source\repos\LiveStreamSample\LiveStreamSample\Views\Properties\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2273, 624, true);
            WriteLiteral(@"    </tbody>
</table>

<script type=""text/javascript"">
    $(document).ready(function () {
        $('#btnLiveStream').click(function (e) {
            e.preventDefault();
            var x = document.getElementById('vid');
            var b = document.getElementById('btnLiveStream');
            if (x.style.display === ""none"") {
                x.style.display = ""block"";
                $('#btnLiveStream').prop('value', 'Close')
            } else {
                x.style.display = ""none"";
                $('#btnLiveStream').prop('value', 'Live stream')
            }
        });
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LiveStreamSample.Models.PropertyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
