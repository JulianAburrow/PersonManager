using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.BasePageClasses
{
    public class BasePageClass : ComponentBase
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
    }
}
