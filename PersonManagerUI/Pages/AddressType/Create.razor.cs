using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Create
    {
        private bool AddressTypeAlreadyExists { get; set; }

        private async Task InsertAddressType()
        {
            if (AddressTypeDb.AddressTypeExists(
                DisplayAddressType.AddressTypeName
                    .Replace(" ", "")
                    .ToLower()))
            {
                AddressTypeAlreadyExists = true;
                return;
            }

            var a = new AddressTypeModel
            {
                AddressTypeName = DisplayAddressType.AddressTypeName
            };

            await AddressTypeDb.InsertAddressType(a);

            NavigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}