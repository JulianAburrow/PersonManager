using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Components
{
    public partial class SavedUrlDetails
    {
        [Parameter] public SavedUrlModel SavedUrl { get; set; }
    }
}
