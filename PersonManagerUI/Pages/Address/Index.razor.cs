using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Index
    {
        [Inject] private IAddressData AddressDb { get; set; }
        [Inject] private IPersonData PersonDb { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        private PersonModel person = new();

        private List<AddressModel> addresses = new();

        protected override async Task OnInitializedAsync()
        {
            addresses = await AddressDb.GetAddresses(PersonId);
            person = PersonDb.GetPerson(PersonId);
        }
    }
}
