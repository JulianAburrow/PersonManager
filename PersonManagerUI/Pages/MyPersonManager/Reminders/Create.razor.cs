using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Create
    {
        protected override void OnInitialized()
        {
            DisplayReminder.ReminderDate = DateTime.Today;
            DisplayReminder.IsCurrent = true;
        }

        private async Task InsertReminder()
        {
            var r = new ReminderModel
            {
                Title = DisplayReminder.Title,
                ReminderDate = DisplayReminder.ReminderDate,
                Notes = DisplayReminder.Notes,
                IsCurrent = DisplayReminder.IsCurrent
            };

            await ReminderDb.InsertReminder(r);

            NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
