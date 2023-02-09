using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Index
    {
        [Inject] IColourData _colourDb { get; set; }

        private List<ColourModel> colours;

        protected override async Task OnInitializedAsync()
        {
            colours = await _colourDb.GetColours();
        }
    }
}
