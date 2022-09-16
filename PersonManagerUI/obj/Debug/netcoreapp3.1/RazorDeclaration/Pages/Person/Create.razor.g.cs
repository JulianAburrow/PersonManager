// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonManagerUI.Pages.Person
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
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Person\Create.razor"
using DataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Person\Create.razor"
using PersonManagerUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Person\Create.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Person\Create.razor"
using PersonManagerUI.CustomControls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/data/person/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Person\Create.razor"
       

    private DisplayPersonModel newPerson = new DisplayPersonModel();

    private List<CountryModel> Countries { get; set; }

    private List<StatusModel> Statuses { get; set; }

    private List<ColourModel> Colours { get; set; }

    protected override void OnInitialized()
    {
        newPerson.CountryId = -1;
        newPerson.StatusId = -1;
        newPerson.FavouriteColourId = -1;

        const string pleaseSelect = "Please select";

        Countries = _countriesDb.GetCountries()
            .OrderBy(c => c.CountryName)
            .ToList();
        Countries.Insert(0, new CountryModel
        {
            CountryId = -1,
            CountryName = pleaseSelect
        });
        Statuses = _statusesDb.GetStatuses()
            .ToList();
        Statuses.Insert(0, new StatusModel
        {
            StatusId = -1,
            StatusName = pleaseSelect
        });
        Colours = _colourDb.GetColours()
            .OrderBy(c => c.ColourName)
            .ToList();
        Colours.Insert(0, new ColourModel
        {
            ColourId = -1,
            ColourName = "None"
        });
    }

    private void InsertPerson()
    {
        var p = new PersonModel
        {
            FirstName = newPerson.FirstName,
            LastName = newPerson.LastName,
            EmailAddress = newPerson.EmailAddress,
            DateOfBirth = newPerson.DateOfBirth,
            CountryId = newPerson.CountryId,
            StatusId = newPerson.StatusId,
            FavouriteColourId = newPerson.FavouriteColourId != -1
                ? newPerson.FavouriteColourId
                : null
        };

        _peopleDb.InsertPerson(p);

        _navigationManager.NavigateTo("/data/people/index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IColourData _colourDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStatusData _statusesDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonData _peopleDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICountryData _countriesDb { get; set; }
    }
}
#pragma warning restore 1591