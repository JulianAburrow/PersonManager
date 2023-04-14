using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Edit
    {
        [Inject] private IAddressData AddressDb { get; set;}
        [Inject] private IAddressTypeData AddressTypeDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int AddressId { get; set; }

        private DisplayAddressModel address = new();

        private List<AddressTypeModel> AddressTypes { get; set; }

        private int PersonId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AddressTypes = await AddressTypeDb.GetAddressTypes();

            var a = await AddressDb.GetAddress(AddressId);

            address.AddressLine1 = a.AddressLine1;
            address.AddressLine2 = a.AddressLine2;
            address.Town = a.Town;
            address.Postcode = a.Postcode;
            address.AddressTypeId = a.AddressTypeId;

            PersonId = a.PersonId;
        }

        private async Task UpdateAddress()
        {
            var a = new AddressModel
            {
                AddressId = AddressId,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                Town = address.Town,
                Postcode = address.Postcode,
                AddressTypeId = address.AddressTypeId
            };

            await AddressDb.UpdateAddress(a);

            NavigationManager.NavigateTo($"data/addresses/index/{PersonId}");
        }
    }
}
