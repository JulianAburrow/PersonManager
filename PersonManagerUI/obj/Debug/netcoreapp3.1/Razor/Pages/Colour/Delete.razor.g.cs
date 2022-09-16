#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74327ca897699b4f038ca1347dc5fdf81ddc94aa"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
using DataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
using PersonManagerUI.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/data/colour/delete/{ColourId:int}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Delete</h1>\r\n\r\n");
#nullable restore
#line 12 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
 if (OkToDelete)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h4 style=\"color: red\">Are you sure you want to delete this colour?</h4>\r\n");
#nullable restore
#line 15 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<h4 style=\"color: red\">Cannot delete colour when people have it as their favourite</h4>\r\n");
#nullable restore
#line 19 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<PersonManagerUI.Components.ColourDetails>(6);
            __builder.AddAttribute(7, "Colour", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Models.ColourModel>(
#nullable restore
#line 21 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
                       colour

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 23 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
 if (OkToDelete)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-danger");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
                                             DeleteColour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 26 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<a href=\"data/colours/index/\">Cancel</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Colour\Delete.razor"
       

    [Parameter]
    public int ColourId { get; set; }

    public ColourModel colour = new ColourModel();

    public bool OkToDelete = true;

    protected override void OnInitialized()
    {
        colour = _db.GetColour(ColourId);

        if (colour.People.Count > 0)
        {
            OkToDelete = false;
        }
    }

    private void DeleteColour()
    {
        _db.DeleteColour(ColourId);

        _navigationManager.NavigateTo("data/colours/index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IColourData _db { get; set; }
    }
}
#pragma warning restore 1591