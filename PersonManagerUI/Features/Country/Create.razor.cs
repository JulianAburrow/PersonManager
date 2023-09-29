using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Create
    {
        private async Task InsertCountry()
        {
            var c = new CountryModel
            {
                CountryName = DisplayCountry.CountryName
            };

            await CountryDb.InsertCountry(c);

            NavigationManager.NavigateTo("/data/countries/index");
        }
    }
}
