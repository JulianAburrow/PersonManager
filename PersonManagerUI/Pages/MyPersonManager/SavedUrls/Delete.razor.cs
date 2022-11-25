using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Delete
    {
        [Inject] ISavedUrlData _savedUrlDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private SavedUrlModel savedUrl = new();

        protected override void OnInitialized()
        {
            savedUrl = _savedUrlDb.GetSavedUrl(UrlId);
        }

        private void DeleteSavedUrl()
        {
            _savedUrlDb.DeleteSavedUrl(UrlId);

            _navigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
        }
    }
}
