using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Create
    {
        [Inject] private ICountryData CountryDb { get; set; }
        [Inject] private NavigationManager NavigationManager {get;set;}

        private DisplayCountryModel newCountry = new();

        private async Task InsertCountry()
        {
            var c = new CountryModel
            {
                CountryName = newCountry.CountryName
            };

            await CountryDb.InsertCountry(c);

            NavigationManager.NavigateTo("/data/countries/index");
        }
    }
}
