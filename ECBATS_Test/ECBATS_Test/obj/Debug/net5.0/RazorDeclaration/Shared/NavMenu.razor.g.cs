// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
