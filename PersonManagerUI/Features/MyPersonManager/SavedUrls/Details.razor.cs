namespace PersonManagerUI.Features.MyPersonManager.SavedUrls;

public partial class Details
{
    protected override async Task OnInitializedAsync() =>
        SavedUrl = await SavedUrlDb.GetSavedUrl(UrlId);
}
