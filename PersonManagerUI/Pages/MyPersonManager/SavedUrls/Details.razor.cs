using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Details
    {
        protected override async Task OnInitializedAsync()
        {
            SavedUrl = await SavedUrlDb.GetSavedUrl(UrlId);
        }
    }
}
