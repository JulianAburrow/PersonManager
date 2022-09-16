#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4770cbb3e561b288023509b688ad37eac61a6a"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonManagerUI.Components
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
#line 1 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
    public partial class CountryDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
  
    if (ShowCountryName)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
             Country.CountryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 7 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<th><strong>Country Name</strong></th>\r\n        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
             Country.CountryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
#nullable restore
#line 19 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
  
    if (Country.People.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.AddMarkupContent(20, "<h3>No people assigned to this country</h3>\r\n");
#nullable restore
#line 23 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 28 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
                 foreach (var person in Country.People)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n\r\n                            ");
            __builder.AddContent(32, 
#nullable restore
#line 33 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
                              $"{person.FirstName} {person.LastName}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "href", "/data/person/details/" + (
#nullable restore
#line 37 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
                                                                                   person.PersonId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 40 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 43 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\JulianApps\PersonManager\PersonManagerUI\Components\CountryDetails.razor"
       

    [Parameter]
    public CountryModel Country { get; set; }

    [Parameter]
    public bool ShowCountryName { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
