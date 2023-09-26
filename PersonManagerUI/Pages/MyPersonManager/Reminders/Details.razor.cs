using System.Threading.Tasks;

namespace PersonManagerUI.Pages.MyPersonManager.Reminders
{
    public partial class Details
    {
        protected override async Task OnInitializedAsync()
        {
            Reminder = await ReminderDb.GetReminder(ReminderId);
        }
    }
}
