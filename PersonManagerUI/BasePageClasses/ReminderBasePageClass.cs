using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.BasePageClasses
{
    public class ReminderBasePageClass : BasePageClass
    {
        [Inject] protected IReminderData ReminderDb { get; set; }

        protected DisplayReminderModel DisplayReminder = new();

        [Parameter] public int ReminderId { get; set; }

        protected ReminderModel Reminder = new();
    }
}
