using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Edit
    {
        [Inject] private IColourData ColourDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int ColourId { get; set; }

        private DisplayColourModel colour = new();

        private string ColourDisplayName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var c = await ColourDb.GetColour(ColourId);

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

            await ColourDb.UpdateColour(c);

            NavigationManager.NavigateTo($"/data/colour/details/{ColourId}");
        }
    }
}