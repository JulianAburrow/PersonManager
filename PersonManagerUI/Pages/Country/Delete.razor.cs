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

        private CountryModel country = new();

        private bool OkToDelete = true;

        protected override void OnInitialized()
        {
            //country = await _countryDb.GetCountry(CountryId);
            country = _countryDb.GetCountries()
                .SingleOrDefault(c => country.CountryId == CountryId);

            if (country.People.Count > 0)
            {
                OkToDelete = false;
            }
        }

        private void DeleteCountry()
        {
            _countryDb.DeleteCountry(CountryId);

            _navigationManager.NavigateTo("data/countries/index");
        }
    }
}
