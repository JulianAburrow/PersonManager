using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Index
    {
        private List<SavedUrlModel> SavedUrls;

        protected override async Task OnInitializedAsync()
        {
            SavedUrls = await SavedUrlDb.GetSavedUrlModels();
        }
    }
}
