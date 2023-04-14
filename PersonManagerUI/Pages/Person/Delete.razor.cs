using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.Person
{
    public partial class Delete : ComponentBase
    {
        [Inject] private IAddressData AddressDb { get; set; }
        [Inject] private IPersonData PersonDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        protected PersonModel person = new();

        protected override void OnInitialized()
        {
            person = PersonDb.GetPerson(PersonId);
        }

        protected void DeletePerson()
        {
            AddressDb.DeleteAddress(PersonId);
            PersonDb.DeletePerson(PersonId);

            NavigationManager.NavigateTo("data/people/index");
        }
    }
}
