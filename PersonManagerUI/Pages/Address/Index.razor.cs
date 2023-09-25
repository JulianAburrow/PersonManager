using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Index
    {
        [Inject] private IPersonData PersonDb { get; set; }

        private PersonModel person = new();

        private List<AddressModel> Addresses = new();

        protected override async Task OnInitializedAsync()
        {
            Addresses = await AddressDb.GetAddresses(PersonId);
            person = PersonDb.GetPerson(PersonId);
        }
    }
}
