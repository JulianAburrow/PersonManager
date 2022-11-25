using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace PersonManagerUI.Pages.Country
{
    public partial class Index
    {
        [Inject] ICountryData _countryDb { get; set; }

        private List<CountryModel> countries;

        protected override void OnInitialized()
        {
            countries = _countryDb.GetCountries()
                .OrderBy(c => c.CountryName)
                .ToList();
        }
    }
}
