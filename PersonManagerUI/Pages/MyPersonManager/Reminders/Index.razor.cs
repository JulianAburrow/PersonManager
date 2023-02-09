using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Index
    {
        [Inject] IReminderData _reminderDb { get; set; }

        private List<ReminderModel> reminders;

        protected override async Task OnInitializedAsync()
        {
            reminders = await _reminderDb.GetAllReminders();
        }
    }
}
