using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Delete
    {
        [Inject] private IColourData ColourDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int ColourId { get; set; }

        public ColourModel colour;

        public bool OkToDelete = true;

        protected override async Task OnInitializedAsync()
        {
            colour = await ColourDb.GetColour(ColourId);

            if (colour.People.Count > 0)
                OkToDelete = false;
        }

        private async Task DeleteColour()
        {
            await ColourDb.DeleteColour(ColourId);

            NavigationManager.NavigateTo("data/colours/index");
        }
    }
}
