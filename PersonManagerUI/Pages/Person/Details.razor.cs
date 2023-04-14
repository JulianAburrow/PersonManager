using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.Person
{
    public partial class Details : ComponentBase
    {
        [Inject] private IPersonData PersonDb { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        protected PersonModel person = new();

        protected override void OnInitialized()
        {
            person = PersonDb.GetPerson(PersonId);
        }
    }
}