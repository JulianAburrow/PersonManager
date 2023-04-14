using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Delete
    {
        [Inject] private IReminderData ReminderDb {get;set;}
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private ReminderModel reminder = new();

        protected override async Task OnInitializedAsync()
        {
            reminder = await ReminderDb.GetReminder(ReminderId);
        }

        private async Task DeleteReminder()
        {
            await ReminderDb.DeleteReminder(ReminderId);

            NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
