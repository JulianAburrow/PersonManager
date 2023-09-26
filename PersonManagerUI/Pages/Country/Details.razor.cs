using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Details
    {
        protected override async Task OnInitializedAsync()
        {
            Country = await CountryDb.GetCountry(CountryId);
        }
    }
}
