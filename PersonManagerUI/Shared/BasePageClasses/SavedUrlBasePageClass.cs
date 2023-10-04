namespace PersonManagerUI.Shared.BasePageClasses;

public class SavedUrlBasePageClass : BasePageClass
{
    [Inject] protected ISavedUrlHandler SavedUrlDb { get; set; }

    protected DisplaySavedUrlModel DisplaySavedUrl = new();

    [Parameter] public int UrlId { get; set; }

    protected SavedUrlModel SavedUrl;
}
