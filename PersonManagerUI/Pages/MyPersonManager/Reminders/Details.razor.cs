using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Details
    {
        [Inject] IReminderData _reminderDb { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private ReminderModel reminder = new();

        protected override void OnInitialized()
        {
            reminder = _reminderDb.GetReminder(ReminderId);
        }
    }
}
