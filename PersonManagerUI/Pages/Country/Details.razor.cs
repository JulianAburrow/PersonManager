using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.Country
{
    public partial class Details
    {
        [Inject] ICountryData _countryDb { get; set; }

        [Parameter]
        public int CountryId { get; set; }

        private CountryModel country = new();

        protected override void OnInitialized()
        {
            country = _countryDb.GetCountry(CountryId);
        }
    }
}
