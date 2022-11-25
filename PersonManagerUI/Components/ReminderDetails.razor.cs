using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Components
{
    public partial class ReminderDetails
    {
        [Parameter]
        public ReminderModel Reminder { get; set; }
    }
}
