using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
namespace PersonManagerUI.Pages.Colour;

public partial class Edit
{
    [Inject] IColourData _coloursDb { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }

    [Parameter]
    public int ColourId { get; set; }

    private DisplayColourModel colour = new();

    private string ColourDisplayName { get; set; }

    protected override void OnInitialized()
    {
        var c = _coloursDb.GetColour(ColourId);

        colour.ColourName = c.ColourName;

        ColourDisplayName = colour.ColourName;
    }

    private void UpdateColour()
    {
        var c = new ColourModel
        {
            ColourId = ColourId,
            ColourName = colour.ColourName
        };

        _coloursDb.UpdateColour(c);

        _navigationManager.NavigateTo($"/data/colour/details/{ColourId}");
    }
}
