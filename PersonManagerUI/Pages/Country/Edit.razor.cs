using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Edit
    {
        [Inject] ICountryData _countriesDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int CountryId { get; set; }

        private DisplayCountryModel country = new();

        private string CountryDisplayName { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var c = await _countriesDb.GetCountry(CountryId);

            country.CountryName = c.CountryName;

            CountryDisplayName = country.CountryName;
        }

        private async Task UpdateCountry()
        {
            var c = new CountryModel
            {
                CountryId = CountryId,
                CountryName = country.CountryName
            };

            await _countriesDb.UpdateCountry(c);

            _navigationManager.NavigateTo($"/data/country/details/{CountryId}");
        }
    }
}
