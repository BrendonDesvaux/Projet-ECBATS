// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ECBATS_Test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using ECBATS_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using ECBATS_Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/_Imports.razor"
using ECBATS_Test.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "/Users/fernandezaurelien/Projects/ECBATS_Test/ECBATS_Test/Pages/Index.razor"
       

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
