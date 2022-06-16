#pragma checksum "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9afc15274b47ee3143fe4eecd315c52f360c4b9"
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
#line 3 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
using PersonManagerUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/data/person/edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Edit ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
          FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                  person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                                          UpdatePerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenElement(13, "table");
                __builder2.AddAttribute(14, "class", "table table-striped");
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "tbody");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.AddMarkupContent(20, "<td><strong>First Name:</strong></td>\r\n                ");
                __builder2.OpenElement(21, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "firstName");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                                                           person.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.FirstName = __value, person.FirstName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "tr");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<td><strong>Last Name</strong></td>\r\n                ");
                __builder2.OpenElement(32, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "lastName");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                                                          person.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.LastName = __value, person.LastName))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "tr");
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.AddMarkupContent(42, "<td><strong>Email Address</strong></td>\r\n                ");
                __builder2.OpenElement(43, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "emailAddress");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                                                              person.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.EmailAddress = __value, person.EmailAddress))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.EmailAddress));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "tr");
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.AddMarkupContent(53, "<td><strong>Date of Birth</strong></td>\r\n                ");
                __builder2.OpenElement(54, "td");
                __Blazor.PersonManagerUI.Pages.People.Edit.TypeInference.CreateInputDate_0(__builder2, 55, 56, 
#nullable restore
#line 32 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                                            person.DateOfBirth

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.DateOfBirth = __value, person.DateOfBirth)), 58, () => person.DateOfBirth);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n    ");
                __builder2.OpenElement(63, "button");
                __builder2.AddAttribute(64, "class", "btn btn-primary");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
                                              UpdatePerson

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(66, "Update");
                __builder2.CloseElement();
                __builder2.AddContent(67, " | ");
                __builder2.AddMarkupContent(68, "<a href=\"/data/people/index\">Cancel</a>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\JulianApps\PersonManager\PersonManagerUI\Pages\People\Edit.razor"
       

    [Parameter]
    public int Id { get; set; }

    private PersonModel person = new PersonModel();

    private string FullName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        person = await _db.GetPerson(Id);

        FullName = $"{person.FirstName} {person.LastName}";
    }

    private void UpdatePerson()
    {
        _db.UpdatePerson(person);

        _navigationManager.NavigateTo($"/data/person/details/{Id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
namespace __Blazor.PersonManagerUI.Pages.People.Edit
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
    }
}
#pragma warning restore 1591
