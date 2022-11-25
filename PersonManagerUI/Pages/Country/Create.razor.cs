using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.Country
{
    public partial class Create
    {
        [Inject] ICountryData _countriesDb { get; set; }
        [Inject] NavigationManager _navigationManager {get;set;}

        private DisplayCountryModel newCountry = new();

        private void InsertCountry()
        {
            var c = new CountryModel
            {
                CountryName = newCountry.CountryName
            };

            _countriesDb.InsertCountry(c);

            _navigationManager.NavigateTo("/data/countries/index");
        }
    }
}
