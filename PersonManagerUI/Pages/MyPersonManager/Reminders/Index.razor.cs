using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Index
    {
        [Inject] IReminderData _reminderDb { get; set; }

        private List<ReminderModel> reminders;

        protected override void OnInitialized()
        {
            reminders = _reminderDb.GetReminders()
                .OrderBy(r => r.ReminderDate)
                .ToList();
        }
    }
}
