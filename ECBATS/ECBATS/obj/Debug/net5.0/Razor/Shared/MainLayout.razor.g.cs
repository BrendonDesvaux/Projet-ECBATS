#pragma checksum "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "608a6fbddf14680bba7e2c7bd5ef65cbee96651a"
// <auto-generated/>
#pragma warning disable 1591
namespace ECBATS.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using ECBATS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using ECBATS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/_Imports.razor"
using ECBATS.Data;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-u6lw1glsij");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-u6lw1glsij");
            __builder.OpenComponent<ECBATS.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-u6lw1glsij");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-u6lw1glsij");
            __builder.AddContent(14, 
#nullable restore
#line 10 "/Users/brendondesvaux/Desktop/ECBATS/ECBATS/ECBATS/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591