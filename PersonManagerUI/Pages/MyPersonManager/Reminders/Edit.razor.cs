using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Edit
    {
        protected override async Task OnInitializedAsync()
        {
            var r = await ReminderDb.GetReminder(ReminderId);

            DisplayReminder.Title = r.Title;
            DisplayReminder.ReminderDate = r.ReminderDate;
            DisplayReminder.Notes = r.Notes;
            DisplayReminder.IsCurrent = r.IsCurrent;
        }

        private async Task UpdateReminder()
        {
            var r = new ReminderModel
            {
                ReminderId = ReminderId,
                Title = DisplayReminder.Title,
                ReminderDate = DisplayReminder.ReminderDate,
                Notes = DisplayReminder.Notes,
                IsCurrent = DisplayReminder.IsCurrent
            };

            await ReminderDb.UpdateReminder(r);

            NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
