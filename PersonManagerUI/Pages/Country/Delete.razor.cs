using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Delete
    {
        [Inject] ICountryData _countryDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

                [Parameter]
        public int CountryId { get; set; }

        private CountryModel country;

        private bool OkToDelete = true;

        protected async override Task OnInitializedAsync()
        {
            country = await _countryDb.GetCountry(CountryId);

            if (country.People.Count > 0)
            {
                OkToDelete = false;
            }
        }

        private async Task DeleteCountry()
        {
            await _countryDb.DeleteCountry(CountryId);

            _navigationManager.NavigateTo("data/countries/index");
        }
    }
}
