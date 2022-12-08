using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Index
    {
        [Inject] ICountryData _countryDb { get; set; }

        private List<CountryModel> countries;

        protected async override Task OnInitializedAsync()
        {
            countries = await _countryDb.GetCountries();
        }
    }
}
