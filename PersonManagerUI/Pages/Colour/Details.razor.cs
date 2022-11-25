using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Details
    {
        [Inject] IColourData _colourDb { get; set; }

        [Parameter]
        public int ColourId { get; set; }

        private ColourModel colour = new();

        protected override void OnInitialized()
        {
            colour = _colourDb.GetColour(ColourId);
        }
    }
}
