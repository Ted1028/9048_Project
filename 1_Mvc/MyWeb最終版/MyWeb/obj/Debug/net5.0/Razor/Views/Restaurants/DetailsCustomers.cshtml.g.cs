#pragma checksum "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e526dd1c67a6d842285fd84e6640d06c5467539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_DetailsCustomers), @"mvc.1.0.view", @"/Views/Restaurants/DetailsCustomers.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\_ViewImports.cshtml"
using MyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\_ViewImports.cshtml"
using MyWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e526dd1c67a6d842285fd84e6640d06c5467539", @"/Views/Restaurants/DetailsCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4221c565102d6b4904ec52217f6417507a218be", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_DetailsCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWeb.Models.Restaurant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexCustomers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Restaurant</h1>


<div>
    <h4>Details</h4>
    <hr />
    <div class=""row"">
        <div class=""col-7"">
            <dl class=""row"">
                <dt></dt>
                <dd></dd>
                <dt></dt>
                <dd></dd>
                <dt></dt>
                <dd></dd>
                <dt></dt>
                <dd></dd>
                <dt></dt>
                <dd></dd>
                <dt class=""col-sm-3 "">
                    ");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayNameFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9 \">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayNameFor(model => model.R_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayFor(model => model.R_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayNameFor(model => model.R_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayFor(model => model.R_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayNameFor(model => model.R_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayFor(model => model.R_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayNameFor(model => model.R_C_Cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
               Write(Html.DisplayFor(model => model.R_C_Cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
            WriteLiteral("            </dl>\r\n        </div>\r\n\r\n        <div class=\"col-5\">\r\n            <dl >\r\n                <dt>\r\n                    <img class=\"imgbig\"");
            BeginWriteAttribute("src", " src=\"", 2158, "\"", 2204, 2);
            WriteAttributeValue("", 2164, "../../images/Restaurant/", 2164, 24, true);
#nullable restore
#line 67 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\DetailsCustomers.cshtml"
WriteAttributeValue("", 2188, Model.R_ImgFile, 2188, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\"  />\r\n                </dt>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e526dd1c67a6d842285fd84e6640d06c54675398971", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n</div>\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        h1 {
            text-shadow: 1px 1px 2px white;
            color: cornflowerblue;
        }

        dt {
            font-size: 2em;
            text-shadow: 1px 1px 2px blue;
            /*color: aquamarine;*/
        }

        dd {
            font-size: 2em;
            color: antiquewhite;
        }

            dd:hover {
                color: white;
            }

        dt:hover {
            color: aqua;
        }

        .imgbig {
            border-radius: 10px;
            width: 500px;
        }

            .imgbig:hover {
                width: 600px;
                transition: transform 0.25s ease;
            }
    </style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWeb.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
