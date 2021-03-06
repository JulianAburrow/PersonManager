#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1de76f12e966369a2c0282654e877aa0bcf8735"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonManagerUI.Pages.Countries
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
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
using DataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
using PersonManagerUI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/data/country/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create Country</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
                  newCountry

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
                                              InsertCountry

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table table-striped");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "tbody");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<td><strong>Country Name</strong></td>\r\n                ");
                __builder2.OpenElement(18, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "countryName");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
                                                             newCountry.CountryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newCountry.CountryName = __value, newCountry.CountryName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newCountry.CountryName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.AddMarkupContent(28, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> ");
                __builder2.AddMarkupContent(29, "<a href=\"/data/countries/index\">Cancel</a>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\Countries\Create.razor"
       

    private DisplayCountryModel newCountry = new DisplayCountryModel();

    private void InsertCountry()
    {
        var c = new CountryModel
        {
            CountryName = newCountry.CountryName
        };

        _countriesDb.InsertCountry(c);

        _navigationManager.NavigateTo("/data/countries/index");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICountryData _countriesDb { get; set; }
    }
}
#pragma warning restore 1591
