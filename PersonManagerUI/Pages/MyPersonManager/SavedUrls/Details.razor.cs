using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Details
    {
        [Inject] ISavedUrlData _savedUrlDb { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private SavedUrlModel savedUrl = new();

        protected override void OnInitialized()
        {
            savedUrl = _savedUrlDb.GetSavedUrl(UrlId);
        }
    }
}
