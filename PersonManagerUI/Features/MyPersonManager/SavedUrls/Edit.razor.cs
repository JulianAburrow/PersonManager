using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Edit
    {
        protected override async Task OnInitializedAsync()
        {
            var s = await SavedUrlDb.GetSavedUrl(UrlId);

            DisplaySavedUrl.Title = s.Title;
            DisplaySavedUrl.Url = s.Url;
            DisplaySavedUrl.Notes = s.Notes;
            DisplaySavedUrl.IsExternal = s.IsExternal;
        }

        private async Task UpdateSavedUrl()
        {
            var s = new SavedUrlModel
            {
                UrlId = UrlId,
                Title = DisplaySavedUrl.Title,
                Url = DisplaySavedUrl.Url,
                Notes = DisplaySavedUrl.Notes,
                IsExternal = DisplaySavedUrl.IsExternal
            };

            await SavedUrlDb.UpdateSavedUrl(s);

            NavigationManager.NavigateTo($"data/mypersonmanager/savedurl/details/{UrlId}");
        }
    }
}
