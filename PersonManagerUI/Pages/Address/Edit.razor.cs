using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Address
{
    public partial class Edit
    {
        [Parameter] public int AddressId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AddressTypes = await AddressTypeDb.GetAddressTypes();

            var a = await AddressDb.GetAddress(AddressId);

            DisplayAddress.AddressLine1 = a.AddressLine1;
            DisplayAddress.AddressLine2 = a.AddressLine2;
            DisplayAddress.Town = a.Town;
            DisplayAddress.Postcode = a.Postcode;
            DisplayAddress.AddressTypeId = a.AddressTypeId;

            PersonId = a.PersonId;
        }

        private async Task UpdateAddress()
        {
            var a = new AddressModel
            {
                AddressId = AddressId,
                AddressLine1 = DisplayAddress.AddressLine1,
                AddressLine2 = DisplayAddress.AddressLine2,
                Town = DisplayAddress.Town,
                Postcode = DisplayAddress.Postcode,
                AddressTypeId = DisplayAddress.AddressTypeId
            };

            await AddressDb.UpdateAddress(a);

            NavigationManager.NavigateTo($"data/addresses/index/{PersonId}");
        }
    }
}
