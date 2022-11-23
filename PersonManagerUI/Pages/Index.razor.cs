using Microsoft.AspNetCore.Components;
using DataAccessLibrary.Models;
using DataAccessLibrary.Interfaces;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Linq;
using System;

namespace PersonManagerUI.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] IReminderData _reminderDb { get; set; }

        private List<ReminderModel> reminders;

        protected override void OnInitialized()
        {
            reminders = _reminderDb.GetReminders()
                .Where(r =>
                    r.ReminderDate <= DateTime.Now &&
                    r.IsCurrent)
                .ToList();
        }
    }
}
