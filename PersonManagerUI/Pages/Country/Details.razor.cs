using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Details
    {
        [Inject] private ICountryData CountryDb { get; set; }

        [Parameter]
        public int CountryId { get; set; }

        private CountryModel country;

        protected override async Task OnInitializedAsync()
        {
            country = await CountryDb.GetCountry(CountryId);
        }
    }
}
