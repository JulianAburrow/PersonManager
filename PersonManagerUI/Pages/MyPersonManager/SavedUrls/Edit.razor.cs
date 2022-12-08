using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Edit
    {
        [Inject] ISavedUrlData _savedUrlDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private DisplaySavedUrlModel savedUrl = new();

        protected async override Task OnInitializedAsync()
        {
            var s = await _savedUrlDb.GetSavedUrl(UrlId);

            savedUrl.Title = s.Title;
            savedUrl.Url = s.Url;
            savedUrl.Notes = s.Notes;
            savedUrl.IsExternal = s.IsExternal;
        }

        private async Task UpdateSavedUrl()
        {
            var s = new SavedUrlModel
            {
                UrlId = UrlId,
                Title = savedUrl.Title,
                Url = savedUrl.Url,
                Notes = savedUrl.Notes,
                IsExternal = savedUrl.IsExternal
            };

            await _savedUrlDb.UpdateSavedUrl(s);

            _navigationManager.NavigateTo($"data/mypersonmanager/savedurl/details/{UrlId}");
        }
    }
}
