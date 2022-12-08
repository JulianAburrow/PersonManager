using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Details
    {
        [Inject] IReminderData _reminderDb { get; set; }

        [Parameter]
        public int ReminderId { get; set; }

        private ReminderModel reminder = new();

        protected async override Task OnInitializedAsync()
        {
            reminder = await _reminderDb.GetReminder(ReminderId);
        }
    }
}
