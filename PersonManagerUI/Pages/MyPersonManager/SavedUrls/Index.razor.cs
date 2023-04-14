using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Index
    {
        [Inject] private ISavedUrlData SavedUrlDb {get;set; }

        private List<SavedUrlModel> savedUrls;

        protected override async Task OnInitializedAsync()
        {
            savedUrls = await SavedUrlDb.GetSavedUrlModels();
        }
    }
}
