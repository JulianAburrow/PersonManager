namespace PersonManagerUI.Features.Colour;

public partial class Create
{
    protected override void OnInitialized() =>
        MainLayout.SetHeaderValue("Create Colour");

    private async Task InsertColour()
    {
        var colourModel = new ColourModel
        {
            ColourName = DisplayColour.ColourName,
        };

        await ColourDb.InsertColour(colourModel);

        NavigationManager.NavigateTo("data/colours/index");
    }
}
