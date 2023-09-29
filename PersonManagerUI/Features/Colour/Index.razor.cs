namespace PersonManagerUI.Features.Colour
{
    public partial class Index
    {
        private List<ColourModel> Colours;

        protected override async Task OnInitializedAsync() =>
            Colours = await ColourDb.GetColours();
    }
}
