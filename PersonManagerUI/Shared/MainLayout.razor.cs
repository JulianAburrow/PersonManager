namespace PersonManagerUI.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] ISavedUrlHandler SavedUrlDb { get; set; }

        [Inject] ISnackbar Snackbar { get; set; }

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

            try
            {
                await SavedUrlDb.InsertSavedUrl(savedUrl);
                Snackbar.Add("URL saved successfully", Severity.Success);
            }
            catch
            {
                Snackbar.Add("There was an error saving this URL. Please try again.", Severity.Error);
            }            
        }

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        private string HeaderValue { get; set; } = null!;

        public void SetHeaderValue(string headerValue)
        {
            HeaderValue = headerValue;
            StateHasChanged();
        }
    }
}
