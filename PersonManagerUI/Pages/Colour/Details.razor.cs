using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Colour
{
    public partial class Details
    {
        protected override async Task OnInitializedAsync()
        {
            Colour = await ColourDb.GetColour(ColourId);
        }
    }
}
