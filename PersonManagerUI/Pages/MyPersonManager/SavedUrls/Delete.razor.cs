using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Delete
    {
        [Inject] ISavedUrlData _savedUrlDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private SavedUrlModel savedUrl = new();

        protected async override Task OnInitializedAsync()
        {
            savedUrl = await _savedUrlDb.GetSavedUrl(UrlId);
        }

        private async Task DeleteSavedUrl()
        {
            await _savedUrlDb.DeleteSavedUrl(UrlId);

            _navigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
        }
    }
}
