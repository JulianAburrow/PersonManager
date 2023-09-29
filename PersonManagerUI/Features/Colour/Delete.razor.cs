﻿namespace PersonManagerUI.Features.Colour;

public partial class Delete
{
    protected bool OkToDelete = true;

    protected override async Task OnInitializedAsync()
    {
        Colour = await ColourDb.GetColour(ColourId);

        if (Colour.People.Count > 0)
            OkToDelete = false;               
    }

    private async Task DeleteColour()
    {
        await ColourDb.DeleteColour(ColourId);

        NavigationManager.NavigateTo("data/colours/index");
    }
}
