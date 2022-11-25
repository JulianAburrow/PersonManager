using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace PersonManagerUI.Pages.MyPersonManager.SavedUrls
{
    public partial class Index
    {
        [Inject] ISavedUrlData _myPersonManagerDb {get;set; }

        private List<SavedUrlModel> savedUrls;

        protected override void OnInitialized()
        {
            savedUrls = _myPersonManagerDb.GetSavedUrlModels();
        }
    }
}
