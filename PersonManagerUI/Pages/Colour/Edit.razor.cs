using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour;

public partial class Edit
{
    [Inject] IColourData _coloursDb { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }

    [Parameter]
    public int ColourId { get; set; }

    private DisplayColourModel colour = new();

    private string ColourDisplayName { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var c = await _coloursDb.GetColour(ColourId);

        colour.ColourName = c.ColourName;

        ColourDisplayName = colour.ColourName;
    }

    private async Task UpdateColour()
    {
        var c = new ColourModel
        {
            ColourId = ColourId,
            ColourName = colour.ColourName
        };

        await _coloursDb.UpdateColour(c);

        _navigationManager.NavigateTo($"/data/colour/details/{ColourId}");
    }
}
