namespace PersonManagerUI.Features.Colour;

public partial class Edit
{
    protected override async Task OnInitializedAsync()
    {
        var c = await ColourDb.GetColour(ColourId);
        Colour.ColourName = c.ColourName;
        MainLayout.SetHeaderValue("Edit Colour");
    }

    private async Task UpdateColour()
    {
        var colourModel = new ColourModel
        {
            ColourId = ColourId,
            ColourName = Colour.ColourName
        };

        await ColourDb.UpdateColour(colourModel);

        NavigationManager.NavigateTo($"/data/colour/details/{ColourId}");
    }
}