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
        [Inject] IAddressData _addressDb { get; set;}
        [Inject] IAddressTypeData _addressTypeDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int AddressId { get; set; }

        private DisplayAddressModel address = new();

        private List<AddressTypeModel> AddressTypes { get; set; }

        private int PersonId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AddressTypes = await _addressTypeDb.GetAddressTypes();

            var a = await _addressDb.GetAddress(AddressId);

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

            await _addressDb.UpdateAddress(a);

            _navigationManager.NavigateTo($"data/addresses/index/{PersonId}");
        }
    }
}
