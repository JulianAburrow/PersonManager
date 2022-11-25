using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
namespace PersonManagerUI.Pages.Colour
{
    public partial class Delete
    {
        [Inject] IColourData _colourDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int ColourId { get; set; }

        public ColourModel colour = new();

        public bool OkToDelete = true;

        protected override void OnInitialized()
        {
            colour = _colourDb.GetColour(ColourId);

            if (colour.People.Count > 0)
                OkToDelete = false;
        }

        private void DeleteColour()
        {
            _colourDb.DeleteColour(ColourId);

            _navigationManager.NavigateTo("data/colours/index");
        }
    }
}
