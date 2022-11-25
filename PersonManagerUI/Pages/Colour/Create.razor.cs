using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Create
    {
        [Inject] IColourData _coloursDb { get; set; }
        [Inject] NavigationManager _navigationManager { get;set; }

        private DisplayColourModel newColour = new();

        private void InsertColour()
        {
            var c = new ColourModel
            {
                ColourName = newColour.ColourName
            };

            _coloursDb.InsertColour(c);

            _navigationManager.NavigateTo("data/colours/index");
        }
    }
}
