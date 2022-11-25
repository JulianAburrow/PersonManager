using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Edit
    {
        [Inject] IReminderData _reminderDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private DisplayReminderModel reminder = new();

        protected override void OnInitialized()
        {
            var r = _reminderDb.GetReminder(ReminderId);

            reminder.Title = r.Title;
            reminder.ReminderDate = r.ReminderDate;
            reminder.Notes = r.Notes;
            reminder.IsCurrent = r.IsCurrent;
        }

        private void UpdateReminder()
        {
            var r = new ReminderModel
            {
                ReminderId = ReminderId,
                Title = reminder.Title,
                ReminderDate = reminder.ReminderDate,
                Notes = reminder.Notes,
                IsCurrent = reminder.IsCurrent
            };

            _reminderDb.UpdateReminder(r);

            _navigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
