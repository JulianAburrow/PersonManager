using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Delete
    {
        [Inject] private ICountryData CountryDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

                [Parameter]
        public int CountryId { get; set; }

        private CountryModel country;

        private bool OkToDelete = true;

        protected override async Task OnInitializedAsync()
        {
            country = await CountryDb.GetCountry(CountryId);

            if (country.People.Count > 0)
            {
                OkToDelete = false;
            }
        }

        private async Task DeleteCountry()
        {
            await CountryDb.DeleteCountry(CountryId);

            NavigationManager.NavigateTo("data/countries/index");
        }
    }
}
