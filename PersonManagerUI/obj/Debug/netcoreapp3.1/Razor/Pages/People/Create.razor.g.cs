#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8d76c652253dd6d5f4e55288eac70ca5138a779"
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
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
using DataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
using PersonManagerUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
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
            __builder.AddMarkupContent(0, "<h1>Create Person</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                  newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                             InsertPerson

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
                __builder2.AddMarkupContent(17, "<td><strong>First Name</strong></td>\r\n                ");
                __builder2.OpenElement(18, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "firstName");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                           newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.FirstName = __value, newPerson.FirstName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenElement(26, "tr");
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.AddMarkupContent(28, "<td><strong>Last Name</strong></td>\r\n                ");
                __builder2.OpenElement(29, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "lastName");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                          newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.LastName = __value, newPerson.LastName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "tr");
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.AddMarkupContent(39, "<td><strong>Email Address</strong></td>\r\n                ");
                __builder2.OpenElement(40, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "id", "emailAddress");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                              newPerson.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.EmailAddress = __value, newPerson.EmailAddress))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.EmailAddress));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenElement(48, "tr");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.AddMarkupContent(50, "<td><strong>Date of Birth</strong></td>\r\n            ");
                __builder2.OpenElement(51, "td");
                __Blazor.PersonManagerUI.Pages.People.Create.TypeInference.CreateInputDate_0(__builder2, 52, 53, 
#nullable restore
#line 35 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                        newPerson.DateOfBirth

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.DateOfBirth = __value, newPerson.DateOfBirth)), 55, () => newPerson.DateOfBirth);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenElement(58, "tr");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.AddMarkupContent(60, "<td><strong>Country</strong></td>\r\n            ");
                __builder2.OpenElement(61, "td");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __Blazor.PersonManagerUI.Pages.People.Create.TypeInference.CreateInputSelectNumber_1(__builder2, 63, 64, "country", 65, 
#nullable restore
#line 40 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                             newPerson.CountryId

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.CountryId = __value, newPerson.CountryId)), 67, () => newPerson.CountryId, 68, (__builder3) => {
                    __builder3.AddMarkupContent(69, "\r\n");
#nullable restore
#line 41 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                     foreach (var country in Countries)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(70, "                        ");
                    __builder3.OpenElement(71, "option");
                    __builder3.AddAttribute(72, "value", 
#nullable restore
#line 43 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                        country.CountryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(73, 
#nullable restore
#line 43 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                            country.CountryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n");
#nullable restore
#line 44 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(75, "                ");
                }
                );
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "tr");
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.AddMarkupContent(81, "<td><strong>Status</strong></td>\r\n            ");
                __builder2.OpenElement(82, "td");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __Blazor.PersonManagerUI.Pages.People.Create.TypeInference.CreateInputSelectNumber_2(__builder2, 84, 85, "status", 86, 
#nullable restore
#line 51 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                            newPerson.StatusId

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.StatusId = __value, newPerson.StatusId)), 88, () => newPerson.StatusId, 89, (__builder3) => {
                    __builder3.AddMarkupContent(90, "\r\n");
#nullable restore
#line 52 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                     foreach (var status in Statuses)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(91, "                        ");
                    __builder3.OpenElement(92, "option");
                    __builder3.AddAttribute(93, "value", 
#nullable restore
#line 54 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                        status.StatusId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(94, 
#nullable restore
#line 54 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                                                          status.StatusName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\r\n");
#nullable restore
#line 55 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(96, "                ");
                }
                );
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n\r\n    ");
                __builder2.AddMarkupContent(102, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> ");
                __builder2.AddMarkupContent(103, "<a href=\"/data/people/index\">Cancel</a>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Create.razor"
       

    private DisplayPersonModel newPerson = new DisplayPersonModel();

    private List<CountryModel> Countries { get; set; }

    private List<StatusModel> Statuses { get; set; }

    protected override async Task OnInitializedAsync()
    {
        newPerson.CountryId = -1;
        newPerson.StatusId = -1;

        Countries = _countriesDb.GetCountries()
            .OrderBy(c => c.CountryName)
            .ToList();
        Countries.Insert(0, new CountryModel
        {
            CountryId = -1,
            CountryName = "Please select"
        });
        Statuses = _statusesDb.GetStatuses()
            .ToList();
        Statuses.Insert(0, new StatusModel
        {
            StatusId = -1,
            StatusName = "Please select"
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
            StatusId = newPerson.StatusId
        };

        _peopleDb.InsertPerson(p);

        _navigationManager.NavigateTo("/data/people/index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStatusesData _statusesDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _peopleDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICountryData _countriesDb { get; set; }
    }
}
namespace __Blazor.PersonManagerUI.Pages.People.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::PersonManagerUI.CustomControls.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::PersonManagerUI.CustomControls.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
