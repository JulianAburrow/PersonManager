using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Components
{
    public partial class PersonDetails
    {

        [Parameter] public PersonModel Person { get; set; }

        [Parameter] public bool ShowPersonName { get; set; }
    }
}
