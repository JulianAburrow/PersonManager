using Microsoft.AspNetCore.Components;
using System.Net.NetworkInformation;

using DataAccessLibrary.Models;
using DataAccessLibrary.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Index
    {
        [Inject] IColourData _colourDb { get; set; }

        private List<ColourModel> colours;

        protected override void OnInitialized()
        {
            colours = _colourDb.GetColours()
                .OrderBy(c => c.ColourName)
                .ToList();
        }
    }
}
