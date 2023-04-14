using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Edit
    {
        [Inject] private IAddressTypeData AddressTypeDb { get;set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int AddressTypeId { get; set; }

        private string AddressTypeDisplayName { get; set; }

        private DisplayAddressTypeModel addressType = new();

        protected override async Task OnInitializedAsync()
        {
            var a = await AddressTypeDb.GetAddressType(AddressTypeId);

            addressType.AddressTypeName = a.AddressTypeName;

            AddressTypeDisplayName = addressType.AddressTypeName;
        }

        private async Task UpdateAddressType()
        {
            var a = new AddressTypeModel
            {
                AddressTypeId = AddressTypeId,
                AddressTypeName = addressType.AddressTypeName
            };

            await AddressTypeDb.UpdateAddressType(a);

            NavigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}
