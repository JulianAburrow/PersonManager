using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Edit
    {
        private string CountryDisplayName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var c = await CountryDb.GetCountry(CountryId);

            DisplayCountry.CountryName = c.CountryName;

            CountryDisplayName = DisplayCountry.CountryName;
        }

        private async Task UpdateCountry()
        {
            var c = new CountryModel
            {
                CountryId = CountryId,
                CountryName = DisplayCountry.CountryName
            };

            await CountryDb.UpdateCountry(c);

            NavigationManager.NavigateTo($"/data/country/details/{CountryId}");
        }
    }
}
