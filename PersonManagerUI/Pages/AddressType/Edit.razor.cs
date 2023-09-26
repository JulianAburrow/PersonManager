using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Edit
    {
        private string AddressTypeDisplayName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var a = await AddressTypeDb.GetAddressType(AddressTypeId);

            DisplayAddressType.AddressTypeName = a.AddressTypeName;

            AddressTypeDisplayName = DisplayAddressType.AddressTypeName;
        }

        private async Task UpdateAddressType()
        {
            var a = new AddressTypeModel
            {
                AddressTypeId = AddressTypeId,
                AddressTypeName = DisplayAddressType.AddressTypeName
            };

            await AddressTypeDb.UpdateAddressType(a);

            NavigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}
