#pragma checksum "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d259a716c8fe702d217f6c0282253ea296b7443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Delete), @"mvc.1.0.view", @"/Views/Restaurants/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d259a716c8fe702d217f6c0282253ea296b7443", @"/Views/Restaurants/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4221c565102d6b4904ec52217f6417507a218be", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWeb.Models.Restaurant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>

        h1 {
            text-shadow: 1px 1px 2px white;
            color: cornflowerblue;
        }

        label {
            color: antiquewhite;
        }

        .imgg {
            width: 600px;
        }
        .hh3 {
            color:ghostwhite;
            text-shadow:1px 1px 1px red;
        }
        .h44{
            color:antiquewhite;
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
    </style>

");
            }
            );
            WriteLiteral(@"<h3 class=""hh3"">Are you sure you want to delete this?</h3>
<div>
    <h4 class=""h44"">Restaurant</h4>
    <hr />

    <div class=""row"">
        <div class=""col-6"">
            <dl class=""row"">
                <dt class=""col-sm-4"">
                    ");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.R_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayFor(model => model.R_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.R_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayFor(model => model.R_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 70 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.R_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 73 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayFor(model => model.R_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 76 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.R_C_Cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
               Write(Html.DisplayFor(model => model.R_C_Cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
            WriteLiteral("            </dl>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2571, "\"", 2643, 2);
            WriteAttributeValue("", 2577, "../../images/Restaurant/", 2577, 24, true);
#nullable restore
#line 90 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
WriteAttributeValue("", 2601, Html.DisplayFor(model => model.R_ImgFile), 2601, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\"  class=\"imgg\"/>\r\n        </div>\r\n    </div>\r\n    \r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d259a716c8fe702d217f6c0282253ea296b744310010", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d259a716c8fe702d217f6c0282253ea296b744310277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 96 "C:\Users\Admin\Desktop\程式\9029_期末專題\1_Mvc\MyWeb_23\MyWeb\Views\Restaurants\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RID);

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
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d259a716c8fe702d217f6c0282253ea296b744312074", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWeb.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
