namespace PersonManagerUI.Features.MyPersonManager.SavedUrls;

public partial class Index
{
    private List<SavedUrlModel> SavedUrls;

    protected override async Task OnInitializedAsync() =>
        SavedUrls = await SavedUrlDb.GetSavedUrlModels();
}
