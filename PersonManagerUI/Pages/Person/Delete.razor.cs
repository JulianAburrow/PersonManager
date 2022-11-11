using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.Person
{
    public partial class Delete : ComponentBase
    {
        [Inject] private IAddressData _addressDb { get; set; }
        [Inject] IPersonData _personDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        protected PersonModel person = new();

        protected override void OnInitialized()
        {
            person = _personDb.GetPerson(PersonId);
        }

        protected void DeletePerson()
        {
            _addressDb.DeleteAddress(PersonId);
            _personDb.DeletePerson(PersonId);

            _navigationManager.NavigateTo("data/people/index");
        }
    }
}
