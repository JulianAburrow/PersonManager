using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Delete
    {
        private AddressTypeModel AddressType = new();

        private bool OkToDelete = true;

        protected override async Task OnInitializedAsync()
        {
            AddressType = await AddressTypeDb.GetAddressType(AddressTypeId);

            if (AddressType.Addresses.Count > 0)
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
