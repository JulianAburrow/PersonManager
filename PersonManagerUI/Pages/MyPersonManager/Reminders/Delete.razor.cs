using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Delete
    {
        [Inject] IReminderData _reminderDb {get;set;}
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private ReminderModel reminder = new();

        protected async override Task OnInitializedAsync()
        {
            reminder = await _reminderDb.GetReminder(ReminderId);
        }

        private async Task DeleteReminder()
        {
            await _reminderDb.DeleteReminder(ReminderId);

            _navigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
