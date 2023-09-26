using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Index
    {
        private List<ReminderModel> Reminders;

        protected override async Task OnInitializedAsync()
        {
            Reminders = await ReminderDb.GetAllReminders();
        }
    }
}
