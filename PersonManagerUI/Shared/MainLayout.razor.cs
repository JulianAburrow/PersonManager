using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] ISavedUrlData SavedUrlDb { get; set; }

        private async Task SaveUrl()
        {
            var savedUrl = new SavedUrlModel
            {
                Title = "Saved Page",
                Url = NavigationManager.Uri,
                Notes = "Saved from application",
                IsExternal = false
            };

            await SavedUrlDb.InsertSavedUrl(savedUrl);
        }
    }
}
