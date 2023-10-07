namespace PersonManagerUI.Shared.BasePageClasses;

public class BasePageClass : ComponentBase
{
    [Inject] protected ISnackbar Snackbar { get; set; }
    [Inject] protected NavigationManager NavigationManager { get; set; }
}
