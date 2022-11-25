using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Edit
    {
        [Inject] IAddressTypeData _addressTypeDb { get;set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int AddressTypeId { get; set; }

        private string AddressTypeDisplayName { get; set; }

        private DisplayAddressTypeModel addressType = new();

        protected override void OnInitialized()
        {
            var a = _addressTypeDb.GetAddressType(AddressTypeId);

            addressType.AddressTypeName = a.AddressTypeName;

            AddressTypeDisplayName = addressType.AddressTypeName;
        }

        private void UpdateAddressType()
        {
            var a = new AddressTypeModel
            {
                AddressTypeId = AddressTypeId,
                AddressTypeName = addressType.AddressTypeName
            };

            _addressTypeDb.UpdateAddressType(a);

            _navigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}
