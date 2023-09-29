using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace PersonManagerUI.Components
{
    public partial class ReminderGrid
    {
        [Parameter] public bool ShowAllReminders { get; set; }

        [Parameter] public List<ReminderModel> Reminders { get; set; }
    }
}
