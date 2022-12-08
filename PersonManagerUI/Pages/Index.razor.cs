using Microsoft.AspNetCore.Components;
using DataAccessLibrary.Models;
using DataAccessLibrary.Interfaces;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] IReminderData _reminderDb { get; set; }

        private List<ReminderModel> reminders;

        protected async override Task OnInitializedAsync()
        {
            reminders = await _reminderDb.GetCurrentReminders();
        }
    }
}
