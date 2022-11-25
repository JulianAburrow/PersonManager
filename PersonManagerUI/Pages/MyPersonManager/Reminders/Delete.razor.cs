using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Delete
    {
        [Inject] IReminderData _reminderDb {get;set;}
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private ReminderModel reminder = new();

        protected override void OnInitialized()
        {
            reminder = _reminderDb.GetReminder(ReminderId);
        }

        private void DeleteReminder()
        {
            _reminderDb.DeleteReminder(ReminderId);

            _navigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
