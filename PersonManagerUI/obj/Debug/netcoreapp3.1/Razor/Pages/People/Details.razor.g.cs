#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f0786ee370762e542c4ec28bc0b22cc5fafed1"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonManagerUI.Pages.People
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
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
using PersonManagerUI.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/data/person/details/{PersonId:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PersonManagerUI.Components.PersonDetails>(0);
            __builder.AddAttribute(1, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Models.PersonModel>(
#nullable restore
#line 9 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
                       person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ShowPersonName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "href", "data/person/edit/" + (
#nullable restore
#line 11 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
                                                   person.PersonId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, " |\r\n");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "class", "btn btn-danger");
            __builder.AddAttribute(11, "href", "data/person/delete/" + (
#nullable restore
#line 12 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
                                                    person.PersonId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " |\r\n");
            __builder.AddMarkupContent(14, "<a href=\"data/people/index\">Index</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Details.razor"
       

    [Parameter]
    public int PersonId { get; set; }

    private PersonModel person = new PersonModel();

    protected override async Task OnInitializedAsync()
    {
        person = await _db.GetPerson(PersonId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
