using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Index
    {
        [Inject] IAddressData _addressDb { get; set; }
        [Inject] IPersonData _personDb { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        private PersonModel person = new();

        private List<AddressModel> addresses = new();

        protected override async Task OnInitializedAsync()
        {
            addresses = await _addressDb.GetAddresses(PersonId);
            person = _personDb.GetPerson(PersonId);
        }
    }
}
