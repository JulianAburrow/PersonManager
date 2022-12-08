using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Delete
    {
        [Inject] IColourData _colourDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int ColourId { get; set; }

        public ColourModel colour;

        public bool OkToDelete = true;

        protected async override Task OnInitializedAsync()
        {
            colour = await _colourDb.GetColour(ColourId);

            if (colour.People.Count > 0)
                OkToDelete = false;
        }

        private async Task DeleteColour()
        {
            await _colourDb.DeleteColour(ColourId);

            _navigationManager.NavigateTo("data/colours/index");
        }
    }
}
