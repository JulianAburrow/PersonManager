using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager _navigationManager { get; set; }
        [Inject] ISavedUrlData _savedUrlDb { get; set; }

        private async Task SaveUrl()
        {
            var savedUrl = new SavedUrlModel
            {
                Title = "Saved Page",
                Url = _navigationManager.Uri,
                Notes = "Saved from application",
                IsExternal = false
            };

            await _savedUrlDb.InsertSavedUrl(savedUrl);
        }
    }
}
