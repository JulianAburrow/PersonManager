namespace PersonManagerUI.Features.MyPersonManager.SavedUrls;

public partial class Create
{
    private async Task InsertSavedUrl()
    {
        var savedUrl = new SavedUrlModel
        {
            Title = DisplaySavedUrl.Title,
            Url = DisplaySavedUrl.Url,
            Notes = DisplaySavedUrl.Notes
        };

        await SavedUrlDb.InsertSavedUrl(savedUrl);

        NavigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
    }
}
