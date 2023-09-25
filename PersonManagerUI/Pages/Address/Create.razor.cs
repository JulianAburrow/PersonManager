using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Create
    {
        protected override async Task OnInitializedAsync()
        {
            DisplayAddress.AddressTypeId = -1;

            AddressTypes = await AddressTypeDb.GetAddressTypes();
            AddressTypes.Insert(0, new AddressTypeModel
            {
                AddressTypeId = -1,
                AddressTypeName = "Please select"
            });
        }

        private async Task InsertAddress()
        {
            var a = new AddressModel
            {
                AddressLine1 = DisplayAddress.AddressLine1,
                AddressLine2 = DisplayAddress.AddressLine2,
                Town = DisplayAddress.Town,
                Postcode = DisplayAddress.Postcode,
                AddressTypeId = DisplayAddress.AddressTypeId,
                PersonId = PersonId
            };

            await AddressDb.InsertAddress(a);

            NavigationManager.NavigateTo($"/data/person/details/{PersonId}");
        }
    }
}
