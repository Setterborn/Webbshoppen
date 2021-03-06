#pragma checksum "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdf8681fa8e98b7249f416ec87f79e391696e308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Webbshoppen.Pages.Pages_ViewCart), @"mvc.1.0.razor-page", @"/Pages/ViewCart.cshtml")]
namespace Webbshoppen.Pages
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
#line 1 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\_ViewImports.cshtml"
using Webbshoppen;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdf8681fa8e98b7249f416ec87f79e391696e308", @"/Pages/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c047c68f49c60afed0d1da5c53223bc572066238", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewCart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
  
    ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Shopping Cart</h1>\r\n<div>\r\n");
#nullable restore
#line 9 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
     if (Data.ProductManager.Cart.Count < 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <h1>The cart is empty</h1>");
#nullable restore
#line 9 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
     foreach (IGrouping<int, Models.Product> prod in Model.CartList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-3\" style=\"width: 70rem;\">\r\n        <div class=\"row g-0\">\r\n            <div class=\"col-md-4\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 542, "\"", 580, 1);
#nullable restore
#line 15 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
WriteAttributeValue("", 548, prod.FirstOrDefault().ImageLink, 548, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\" style=\"height:200px; width:150px\">\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                <div class=\"card-body\">\r\n                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdf8681fa8e98b7249f416ec87f79e391696e3086352", async() => {
#nullable restore
#line 19 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                                                                            Write(prod.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                                            WriteLiteral(prod.First().ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                    <h5 class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                     Write(Math.Round(prod.FirstOrDefault().Price * 1.25));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :- </h5>\r\n                    <h5 class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                     Write(prod.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" x </h5>\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                         if (prod.FirstOrDefault().Stock > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdf8681fa8e98b7249f416ec87f79e391696e3089887", async() => {
                WriteLiteral("+");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-input", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                                                                                          WriteLiteral(prod.FirstOrDefault().ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["input"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-input", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["input"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 26 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdf8681fa8e98b7249f416ec87f79e391696e30812576", async() => {
                WriteLiteral("-");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-input", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
                                                                                                         WriteLiteral(prod.FirstOrDefault().ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["input"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-input", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["input"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\sette\Desktop\webbshoppen\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewCart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<a class=\"btn btn-primary\" href=\"/ViewCheckout\" role=\"button\">To checkout</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webbshoppen.Pages.ViewCartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Webbshoppen.Pages.ViewCartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Webbshoppen.Pages.ViewCartModel>)PageContext?.ViewData;
        public Webbshoppen.Pages.ViewCartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
