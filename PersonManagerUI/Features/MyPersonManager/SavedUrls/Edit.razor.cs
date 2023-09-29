﻿namespace PersonManagerUI.Features.MyPersonManager.SavedUrls;

public partial class Edit
{
    protected override async Task OnInitializedAsync()
    {
        var savedUrl = await SavedUrlDb.GetSavedUrl(UrlId);

        DisplaySavedUrl.Title = savedUrl.Title;
        DisplaySavedUrl.Url = savedUrl.Url;
        DisplaySavedUrl.Notes = savedUrl.Notes;
        DisplaySavedUrl.IsExternal = savedUrl.IsExternal;
    }

    private async Task UpdateSavedUrl()
    {
        var savedUrlModel = new SavedUrlModel
        {
            UrlId = UrlId,
            Title = DisplaySavedUrl.Title,
            Url = DisplaySavedUrl.Url,
            Notes = DisplaySavedUrl.Notes,
            IsExternal = DisplaySavedUrl.IsExternal
        };

        await SavedUrlDb.UpdateSavedUrl(savedUrlModel);

        NavigationManager.NavigateTo($"data/mypersonmanager/savedurl/details/{UrlId}");
    }
}
