using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Create
    {
        private async Task InsertColour()
        {
            var c = new ColourModel
            {
                ColourName = DisplayColour.ColourName
            };

            await ColourDb.InsertColour(c);

            NavigationManager.NavigateTo("data/colours/index");
        }
    }
}
