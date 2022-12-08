using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Create
    {
        [Inject] IAddressData _addressDb { get; set; }
        [Inject] IAddressTypeData _addressTypeDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int PersonId { get; set; }
        private List<AddressTypeModel> AddressTypes { get; set; }

        private DisplayAddressModel newAddress = new();

        protected override void OnInitialized()
        {
            newAddress.AddressTypeId = -1;

            AddressTypes = _addressTypeDb.GetAddressTypes()
                .ToList();
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

            await _addressDb.InsertAddress(a);

            _navigationManager.NavigateTo($"/data/person/details/{PersonId}");
        }
    }
}
