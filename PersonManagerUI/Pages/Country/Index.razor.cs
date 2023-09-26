using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Index
    {
        private List<CountryModel> Countries;

        protected override async Task OnInitializedAsync()
        {
            Countries = await CountryDb.GetCountries();
        }
    }
}
