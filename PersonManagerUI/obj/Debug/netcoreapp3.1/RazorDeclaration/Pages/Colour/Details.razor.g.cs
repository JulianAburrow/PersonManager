// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonManagerUI.Pages.Colour
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using PersonManagerUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\JulianApps\PersonManager\PersonManagerUI\_Imports.razor"
using PersonManagerUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Details.razor"
using DataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Details.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Details.razor"
using PersonManagerUI.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/data/colour/details/{ColourId:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Details.razor"
       

    [Parameter]
    public int ColourId { get; set; }

    private ColourModel colour = new ColourModel();

    protected override void OnInitialized()
    {
        colour = _db.GetColour(ColourId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IColourData _db { get; set; }
    }
}
#pragma warning restore 1591