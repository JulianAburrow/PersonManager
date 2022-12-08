using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Create
    {
        [Inject] IAddressTypeData _addressTypeDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        private DisplayAddressTypeModel newAddressType = new();

        private bool AddressTypeAlreadyExists { get; set; }

        private async Task InsertAddressType()
        {
            if (_addressTypeDb.AddressTypeExists(
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

            await _addressTypeDb.InsertAddressType(a);

            _navigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}