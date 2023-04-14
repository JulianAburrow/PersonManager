using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Delete
    {
        [Inject] private IAddressTypeData AddressTypeDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int AddressTypeId { get; set; }

        private AddressTypeModel addressType = new();

        private bool OkToDelete = true;

        protected override async Task OnInitializedAsync()
        {
            addressType = await AddressTypeDb.GetAddressType(AddressTypeId);

            if (addressType.Addresses.Count > 0)
            {
                OkToDelete = false;
            }
        }

        private async Task DeleteAddressType()
        {
            await AddressTypeDb.DeleteAddressType(AddressTypeId);

            NavigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}
