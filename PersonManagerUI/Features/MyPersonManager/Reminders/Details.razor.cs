namespace PersonManagerUI.Features.MyPersonManager.Reminders;

public partial class Details
{
    protected override async Task OnInitializedAsync() =>
        Reminder = await ReminderDb.GetReminder(ReminderId);
}
