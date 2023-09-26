using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.BasePageClasses
{
    public class ColourBasePageClass : BasePageClass
    {
        [Inject] protected IColourData ColourDb { get; set; }

        protected DisplayColourModel DisplayColour = new();

        [Parameter] public int ColourId { get; set; }

        protected ColourModel Colour;
    }
}
