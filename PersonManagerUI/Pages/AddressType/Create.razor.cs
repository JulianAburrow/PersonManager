using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Create
    {
        [Inject] private IAddressTypeData AddressTypeDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        private DisplayAddressTypeModel newAddressType = new();

        private bool AddressTypeAlreadyExists { get; set; }

        private async Task InsertAddressType()
        {
            if (AddressTypeDb.AddressTypeExists(
                newAddressType.AddressTypeName
                    .Replace(" ", "")
                    .ToLower()))
            {
                AddressTypeAlreadyExists = true;
                return;
            }

            var a = new AddressTypeModel
            {
                AddressTypeName = newAddressType.AddressTypeName
            };

            await AddressTypeDb.InsertAddressType(a);

            NavigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}