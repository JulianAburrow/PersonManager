using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Create
    {
        [Inject] private IAddressData AddressDb { get; set; }
        [Inject] private IAddressTypeData AddressTypeDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int PersonId { get; set; }
        private List<AddressTypeModel> AddressTypes { get; set; }

        private DisplayAddressModel newAddress = new();

        protected override async Task OnInitializedAsync()
        {
            newAddress.AddressTypeId = -1;

            AddressTypes = await AddressTypeDb.GetAddressTypes();
            AddressTypes.Insert(0, new AddressTypeModel
            {
                AddressTypeId = -1,
                AddressTypeName = "Please select"
            });
        }

        private async Task InsertAddress()
        {
            var a = new AddressModel
            {
                AddressLine1 = newAddress.AddressLine1,
                AddressLine2 = newAddress.AddressLine2,
                Town = newAddress.Town,
                Postcode = newAddress.Postcode,
                AddressTypeId = newAddress.AddressTypeId,
                PersonId = PersonId
            };

            await AddressDb.InsertAddress(a);

            NavigationManager.NavigateTo($"/data/person/details/{PersonId}");
        }
    }
}
