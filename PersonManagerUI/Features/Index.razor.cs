using Microsoft.AspNetCore.Components;
using DataAccessLibrary.Models;
using DataAccessLibrary.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] IReminderHandler _reminderDb { get; set; }

        private List<ReminderModel> reminders;

        protected override async Task OnInitializedAsync()
        {
            reminders = await _reminderDb.GetCurrentReminders();
        }
    }
}
