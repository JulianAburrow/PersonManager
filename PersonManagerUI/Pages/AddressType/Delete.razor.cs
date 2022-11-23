using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Delete : ComponentBase
    {
        [Inject] IAddressTypeData _addressTypeDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int AddressTypeId { get; set; }

        private AddressTypeModel addressType = new();

        private bool OkToDelete = true;

        protected override void OnInitialized()
        {
            addressType = _addressTypeDb.GetAddressType(AddressTypeId);

            if (addressType.Addresses.Count > 0)
            {
                OkToDelete = false;
            }
        }

        private void DeleteAddressType()
        {
            _addressTypeDb.DeleteAddressType(AddressTypeId);

            _navigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}
