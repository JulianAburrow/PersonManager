namespace PersonManagerUI.Features.Colour;

public partial class Edit
{
    private string ColourDisplayName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var c = await ColourDb.GetColour(ColourId);

        Colour.ColourName = c.ColourName;

        ColourDisplayName = Colour.ColourName;
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