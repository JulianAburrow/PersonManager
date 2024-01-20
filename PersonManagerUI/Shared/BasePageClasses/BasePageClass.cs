namespace PersonManagerUI.Shared.BasePageClasses;

public class BasePageClass : ComponentBase
{
    [Inject] protected ISnackbar Snackbar { get; set; }
    [Inject] protected NavigationManager NavigationManager { get; set; }

    [CascadingParameter] public MainLayout MainLayout { get; set; }

    protected override void OnInitialized()
    {
        MainLayout.SetHeaderValue(string.Empty);
    }
}
