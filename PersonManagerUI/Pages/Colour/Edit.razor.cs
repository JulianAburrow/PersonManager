using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
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
            var c = new ColourModel
            {
                ColourId = ColourId,
                ColourName = Colour.ColourName
            };

            await ColourDb.UpdateColour(c);

            NavigationManager.NavigateTo($"/data/colour/details/{ColourId}");
        }
    }
}