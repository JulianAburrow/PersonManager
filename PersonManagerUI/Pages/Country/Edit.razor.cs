using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Edit
    {
        [Inject] private ICountryData CountryDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int CountryId { get; set; }

        private DisplayCountryModel country = new();

        private string CountryDisplayName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var c = await CountryDb.GetCountry(CountryId);

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

            await CountryDb.UpdateCountry(c);

            NavigationManager.NavigateTo($"/data/country/details/{CountryId}");
        }
    }
}
