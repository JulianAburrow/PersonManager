using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Edit
    {
        [Inject] private ISavedUrlData SavedUrlDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int UrlId { get; set; }

        private DisplaySavedUrlModel savedUrl = new();

        protected override async Task OnInitializedAsync()
        {
            var s = await SavedUrlDb.GetSavedUrl(UrlId);

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

            await SavedUrlDb.UpdateSavedUrl(s);

            NavigationManager.NavigateTo($"data/mypersonmanager/savedurl/details/{UrlId}");
        }
    }
}
