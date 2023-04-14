using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Delete
    {
        [Inject] private ISavedUrlData SavedUrlDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private SavedUrlModel savedUrl = new();

        protected override async Task OnInitializedAsync()
        {
            savedUrl = await SavedUrlDb.GetSavedUrl(UrlId);
        }

        private async Task DeleteSavedUrl()
        {
            await SavedUrlDb.DeleteSavedUrl(UrlId);

            NavigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
        }
    }
}
