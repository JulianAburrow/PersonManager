namespace PersonManagerUI.Features.Colour;

public partial class Create
{
    private async Task InsertColour()
    {
        var colourModel = new ColourModel(DisplayColour.ColourName);

        await ColourDb.InsertColour(colourModel);

        NavigationManager.NavigateTo("data/colours/index");
    }
}
