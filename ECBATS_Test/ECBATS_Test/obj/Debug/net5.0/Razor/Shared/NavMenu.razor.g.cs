#pragma checksum "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a13f4ab7498e6049457dce16601b20c43c35f8b"
// <auto-generated/>
#pragma warning disable 1591
namespace ECBATS_Test.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-ekuundbyyd");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-ekuundbyyd>ECBATS</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-ekuundbyyd");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-ekuundbyyd></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-ekuundbyyd");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-ekuundbyyd");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-ekuundbyyd");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-ekuundbyyd></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-ekuundbyyd");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "counter");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-ekuundbyyd></span> Charts\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/brendondesvaux/Desktop/ECBATS_Test/ECBATS_Test/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
