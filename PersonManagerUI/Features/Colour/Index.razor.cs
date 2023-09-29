using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Index
    {
        private List<ColourModel> Colours;

        protected override async Task OnInitializedAsync()
        {
            Colours = await ColourDb.GetColours();
        }
    }
}
