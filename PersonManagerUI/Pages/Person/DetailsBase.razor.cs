using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.Person
{
    public class DetailsBase : ComponentBase
    {
        [Inject] private IPersonData _personDb { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        protected PersonModel person = new();

        protected override void OnInitialized()
        {
            person = _personDb.GetPerson(PersonId);
        }
    }
}