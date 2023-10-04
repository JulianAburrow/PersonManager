namespace PersonManagerUI.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] ISavedUrlHandler SavedUrlDb { get; set; }

        private bool @_drawerOpen = true;

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

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
