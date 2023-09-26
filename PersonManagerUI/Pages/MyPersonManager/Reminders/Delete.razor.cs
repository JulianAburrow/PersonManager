using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Delete
    {
        protected override async Task OnInitializedAsync()
        {
            Reminder = await ReminderDb.GetReminder(ReminderId);
        }

        private async Task DeleteReminder()
        {
            await ReminderDb.DeleteReminder(ReminderId);

            NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
        }
    }
}
