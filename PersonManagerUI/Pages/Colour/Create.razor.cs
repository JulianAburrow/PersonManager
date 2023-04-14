using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Create
    {
        [Inject] private IColourData ColourDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get;set; }

        private DisplayColourModel newColour = new();

        private async Task InsertColour()
        {
            var c = new ColourModel
            {
                ColourName = newColour.ColourName
            };

            await ColourDb.InsertColour(c);

            NavigationManager.NavigateTo("data/colours/index");
        }
    }
}
