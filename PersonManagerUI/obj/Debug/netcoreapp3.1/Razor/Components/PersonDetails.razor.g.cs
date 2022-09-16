#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aef4f1a73185f362d057b3bef15be7c7e2151d2b"
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
#line 1 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
    public partial class PersonDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
  
    if (ShowPersonName)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
             Person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 6 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                               Person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 7 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-striped");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<td><strong>First Name</strong></td>\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                 Person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.AddMarkupContent(21, "<td><strong>Last Name</strong></td>\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 18 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                 Person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.AddMarkupContent(28, "<td><strong>Email Address</strong></td>\r\n            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 22 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                 Person.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<td><strong>Date of Birth</strong></td>\r\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.AddContent(38, 
#nullable restore
#line 27 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                  Person.DateOfBirth != null ? Person.DateOfBirth.Value.ToShortDateString(): "Not Stated"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.AddMarkupContent(44, "<td><strong>Country</strong></td>\r\n            ");
            __builder.OpenElement(45, "td");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", "/data/country/details/" + (
#nullable restore
#line 33 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                                                Person.CountryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.AddContent(50, 
#nullable restore
#line 34 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
                     Person.Country.CountryName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "tr");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, "<td><strong>Status</strong></td>\r\n        ");
            __builder.OpenElement(58, "td");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.AddContent(60, 
#nullable restore
#line 41 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
             Person.Status.StatusName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "tr");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.AddMarkupContent(66, "<td><strong>Favourite Colour</strong></td>\r\n        ");
            __builder.OpenElement(67, "td");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.AddContent(69, 
#nullable restore
#line 47 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
              Person.FavouriteColour != null ? Person.FavouriteColour.ColourName : "None"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\JulianApps\PersonManager\PersonManagerUI\Components\PersonDetails.razor"
       

    [Parameter]
    public PersonModel Person { get; set; }

    [Parameter]
    public bool ShowPersonName { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591