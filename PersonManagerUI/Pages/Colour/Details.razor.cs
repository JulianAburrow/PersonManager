using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Details
    {
        [Inject] IColourData _colourDb { get; set; }

        [Parameter]
        public int ColourId { get; set; }

        private ColourModel colour;

        protected override async Task OnInitializedAsync()
        {
            colour = await _colourDb.GetColour(ColourId);
        }
    }
}
