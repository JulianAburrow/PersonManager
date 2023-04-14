using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Details
    {
        [Inject] private ISavedUrlData SavedUrlDb { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private SavedUrlModel savedUrl = new();

        protected override async Task OnInitializedAsync()
        {
            savedUrl = await SavedUrlDb.GetSavedUrl(UrlId);
        }
    }
}
