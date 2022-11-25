using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager _navigationManager { get; set; }
        [Inject] ISavedUrlData _savedUrlDb { get; set; }

        private void SaveUrl()
        {
            var savedUrl = new SavedUrlModel
            {
                Title = "Saved Page",
                Url = _navigationManager.Uri,
                Notes = "Saved from application",
                IsExternal = false
            };

            _savedUrlDb.InsertSavedUrl(savedUrl);
        }
    }
}
