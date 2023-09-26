using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Components
{
    public partial class ColourDetails
    {

        [Parameter] public ColourModel Colour { get; set; }

        [Parameter] public bool ShowColourName { get; set; }
    }
}
