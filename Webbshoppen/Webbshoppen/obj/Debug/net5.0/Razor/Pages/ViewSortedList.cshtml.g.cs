#pragma checksum "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89aab02b3f6c64317dc1578d9ce29a697cd15651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Webbshoppen.Pages.Pages_ViewSortedList), @"mvc.1.0.razor-page", @"/Pages/ViewSortedList.cshtml")]
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
#line 1 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\_ViewImports.cshtml"
using Webbshoppen;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89aab02b3f6c64317dc1578d9ce29a697cd15651", @"/Pages/ViewSortedList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c047c68f49c60afed0d1da5c53223bc572066238", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewSortedList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
 foreach (Models.Product prod in Model.SortedList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 173, "\"", 194, 1);
#nullable restore
#line 8 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
WriteAttributeValue("", 179, prod.ImageLink, 179, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                              Write(prod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                            Write(prod.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 12 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                           Write(prod.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
             if (prod is Models.Jackets)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text\">Item in stock: ");
#nullable restore
#line 14 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                             Write((Models.Jackets)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Size</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 15 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Jackets)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Color</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 16 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Jackets)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Gender</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 17 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Jackets)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".JacketLenght</p>");
#nullable restore
#line 17 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
             if (prod is Models.Pants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text\">Item in stock: ");
#nullable restore
#line 19 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                             Write((Models.Pants)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Size</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 20 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Pants)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Color</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 21 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Pants)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Gender</p>");
#nullable restore
#line 21 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
             if (prod is Models.Shirts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text\">Item in stock: ");
#nullable restore
#line 23 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                             Write((Models.Shirts)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Size</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 24 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Shirts)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Color</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 25 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Shirts)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Gender</p>");
#nullable restore
#line 25 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
             if (prod is Models.Shoes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text\">Item in stock: ");
#nullable restore
#line 27 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                             Write((Models.Shoes)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Size</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 28 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Shoes)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Color</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 29 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Shoes)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Gender</p>");
#nullable restore
#line 29 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
             if (prod is Models.Underwear)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text\">Item in stock: ");
#nullable restore
#line 31 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                             Write((Models.Underwear)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Size</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 32 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Underwear)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Color</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 33 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Underwear)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Gender</p>\r\n                <p class=\"card-text\">Item in stock: ");
#nullable restore
#line 34 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                Write((Models.Underwear)prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(".UnderwearSexyness</p>");
#nullable restore
#line 34 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"card-text\">");
#nullable restore
#line 35 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
                            Write(prod.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\sette\Desktop\Setterborn\Webbshoppen\Webbshoppen\Webbshoppen\Pages\ViewSortedList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("{\r\n\r\n}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webbshoppen.Pages.ViewSortedListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Webbshoppen.Pages.ViewSortedListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Webbshoppen.Pages.ViewSortedListModel>)PageContext?.ViewData;
        public Webbshoppen.Pages.ViewSortedListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591