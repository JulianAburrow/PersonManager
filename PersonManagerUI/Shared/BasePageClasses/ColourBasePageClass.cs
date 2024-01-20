namespace PersonManagerUI.Shared.BasePageClasses;

public class ColourBasePageClass : BasePageClass
{
    [Inject] protected IColourHandler ColourDb { get; set; }

    protected DisplayColourModel DisplayColour = new();

    [Parameter] public int ColourId { get; set; }

    protected ColourModel Colour = new();
}
