#pragma checksum "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "228dd0d447ac9b2466526d7f4c8a23d07ae08a9f"
// <auto-generated/>
#pragma warning disable 1591
namespace ECBATS_Test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using ECBATS_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using ECBATS_Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using ECBATS_Test.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<input type=\"checkbox\" id=\"switcher_checkbox\" class=\"switcher_checkbox\">\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper");
            __builder.AddMarkupContent(3, "<button class=\"switcher\"><div class=\"switcher_circle\"></div>\n        <label for=\"switcher_checkbox\" class=\"switcher_checkbox_label\"></label></button>\n\n    ");
            __builder.AddMarkupContent(4, "<ul class=\"nav nav-tabs\"><li class=\"nav-item\"><a class=\"nav-link night active\" href=\" \">Crytocurrencies</a></li>\n        <li class=\"nav-item\"><a class=\"nav-link night active\" href=\"Charts\">Charts</a></li></ul>\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container simple shadow p-3 mb-4 bg-white rounded");
            __builder.AddMarkupContent(7, "<h3>Favorites</h3>\n        ");
            __builder.OpenElement(8, "div");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, @"<thead><tr><th scope=""col"">Logo</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Symbol</th>
                        <th scope=""col"">Price</th>
                        <th scope=""col"">24h%</th>
                        <th scope=""col"">7j%</th></tr></thead>
                ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 37 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                     if (Products.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                         foreach (var product in Products)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                          (() => SetProductForUpdate(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 42 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                               product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "id", "CryptoImage");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 43 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 44 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.CryptoName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 45 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 46 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Percent24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 47 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Percent7j

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<tr><td colspan=\"6\"><strong>No products available</strong></td></tr>");
#nullable restore
#line 54 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "container simple shadow p-3 mb-4 bg-white rounded");
            __builder.AddMarkupContent(40, @"<div class=""col-md-12 allCur""><div class=""col-md-9""><h3>All currencies</h3></div>
            <div class=""col-md-3"" style=""padding: 1%;""><div class=""form-outline""><input type=""search"" id=""form1"" class=""form-control"" placeholder=""Type query"" aria-label=""Search""></div></div></div>
        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-md-12");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table");
            __builder.AddMarkupContent(45, @"<thead><tr><th scope=""col"">Fav</th>
                        <th scope=""col"">Logo</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Symbol</th>
                        <th scope=""col"">Price</th>
                        <th scope=""col"">24h%</th>
                        <th scope=""col"">7j%</th></tr></thead>
                ");
            __builder.OpenElement(46, "tbody");
            __builder.AddAttribute(47, "class", "allcurtable");
#nullable restore
#line 86 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                     if (Products.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                         foreach (var product in Products)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "tr");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                          (() => SetProductForUpdate(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "<td><input type=\"checkbox\" class=\"option-input checkbox\"></td>\n                                ");
            __builder.OpenElement(51, "td");
            __builder.OpenElement(52, "img");
            __builder.AddAttribute(53, "src", 
#nullable restore
#line 92 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                               product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "id", "CryptoImage");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 93 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 94 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.CryptoName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 95 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n                                ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 96 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Percent24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n                                ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 97 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                                     product.Percent7j

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<tr><td colspan=\"6\"><strong>No products available</strong></td></tr>");
#nullable restore
#line 104 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
       
    List<CryptoSaving> Products = new List<CryptoSaving>();
    protected override async Task OnInitializedAsync()
    {
        await RefreshProducts();
    }

    private async Task RefreshProducts()
    {
        Products = await service.GetProductAsync();
    }

    public CryptoSaving NewProduct { get; set; } = new CryptoSaving();
    private async Task AddNewProduct()
    {
        await service.AddProductAsync(NewProduct);
        NewProduct = new CryptoSaving();
        await RefreshProducts();
    }

    CryptoSaving UpdateProduct = new CryptoSaving();
    private void SetProductForUpdate(CryptoSaving product)
    {
        UpdateProduct = product;
    }

    private async Task UpdateProductData()
    {
        await service.UpdateProductAsync(UpdateProduct);
        await RefreshProducts();
    }

    private async Task DeleteProduct(CryptoSaving product)
    {
        await service.DeleteProductAsync(product);
        await RefreshProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices service { get; set; }
    }
}
#pragma warning restore 1591
