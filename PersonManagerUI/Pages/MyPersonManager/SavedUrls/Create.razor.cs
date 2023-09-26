using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Create
    {
        private async Task InsertSavedUrl()
        {
            var s = new SavedUrlModel
            {
                Title = DisplaySavedUrl.Title,
                Url = DisplaySavedUrl.Url,
                Notes = DisplaySavedUrl.Notes
            };

            await SavedUrlDb.InsertSavedUrl(s);

            NavigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
        }
    }
}
