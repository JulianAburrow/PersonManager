using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Create
    {
        [Inject] private ISavedUrlData SavedUrlDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        private DisplaySavedUrlModel newSavedUrl = new();

        private async Task InsertSavedUrl()
        {
            var s = new SavedUrlModel
            {
                Title = newSavedUrl.Title,
                Url = newSavedUrl.Url,
                Notes = newSavedUrl.Notes
            };

            await SavedUrlDb.InsertSavedUrl(s);

            NavigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
        }
    }
}
