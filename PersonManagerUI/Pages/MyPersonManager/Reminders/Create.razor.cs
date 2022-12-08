using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Create
    {
        [Inject] IReminderData _reminderDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        private DisplayReminderModel newReminder = new();

        protected override void OnInitialized()
        {
            newReminder.ReminderDate = DateTime.Today;
            newReminder.IsCurrent = true;
        }

        private async Task InsertReminder()
        {
            var r = new ReminderModel
            {
                Title = newReminder.Title,
                ReminderDate = newReminder.ReminderDate,
                Notes = newReminder.Notes,
                IsCurrent = newReminder.IsCurrent
            };

            await _reminderDb.InsertReminder(r);

            _navigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
