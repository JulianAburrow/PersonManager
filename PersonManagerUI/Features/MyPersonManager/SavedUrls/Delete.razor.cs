namespace PersonManagerUI.Features.MyPersonManager.SavedUrls;

public partial class Delete
{
    protected override async Task OnInitializedAsync() =>
        SavedUrl = await SavedUrlDb.GetSavedUrl(UrlId);

    private async Task DeleteSavedUrl()
    {
        await SavedUrlDb.DeleteSavedUrl(UrlId);

        NavigationManager.NavigateTo("data/mypersonmanager/savedurls/index");
    }
}
