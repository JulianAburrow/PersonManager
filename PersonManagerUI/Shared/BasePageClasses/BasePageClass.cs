using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Shared.BasePageClasses
{
    public class BasePageClass : ComponentBase
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
    }
}
