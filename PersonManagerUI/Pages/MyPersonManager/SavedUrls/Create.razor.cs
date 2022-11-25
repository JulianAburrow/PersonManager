using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Create
    {
        [Inject] ISavedUrlData _savedUrlDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        private DisplaySavedUrlModel newSavedUrl = new();

        private void InsertSavedUrl()
        {
            var s = new SavedUrlModel
            {
                Title = newSavedUrl.Title,
                Url = newSavedUrl.Url,
                Notes = newSavedUrl.Notes
            };

            _savedUrlDb.InsertSavedUrl(s);

            _navigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
        }
    }
}
