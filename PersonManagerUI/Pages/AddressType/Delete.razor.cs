using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Delete
    {
        [Inject] IAddressTypeData _addressTypeDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int AddressTypeId { get; set; }

        private AddressTypeModel addressType = new();

        private bool OkToDelete = true;

        protected override async Task OnInitializedAsync()
        {
            addressType = await _addressTypeDb.GetAddressType(AddressTypeId);

            if (addressType.Addresses.Count > 0)
            {
                OkToDelete = false;
            }
        }

        private async Task DeleteAddressType()
        {
            await _addressTypeDb.DeleteAddressType(AddressTypeId);

            _navigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}
