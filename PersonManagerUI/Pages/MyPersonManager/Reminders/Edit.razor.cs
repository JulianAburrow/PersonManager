using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Edit
    {
        [Inject] private IReminderData ReminderDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private DisplayReminderModel reminder = new();

        protected override async Task OnInitializedAsync()
        {
            var r = await ReminderDb.GetReminder(ReminderId);

            reminder.Title = r.Title;
            reminder.ReminderDate = r.ReminderDate;
            reminder.Notes = r.Notes;
            reminder.IsCurrent = r.IsCurrent;
        }

        private async Task UpdateReminder()
        {
            var r = new ReminderModel
            {
                ReminderId = ReminderId,
                Title = reminder.Title,
                ReminderDate = reminder.ReminderDate,
                Notes = reminder.Notes,
                IsCurrent = reminder.IsCurrent
            };

            await ReminderDb.UpdateReminder(r);

            NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
