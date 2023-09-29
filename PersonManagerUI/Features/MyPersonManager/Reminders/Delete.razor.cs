namespace PersonManagerUI.Features.MyPersonManager.Reminders;

public partial class Delete
{
    protected override async Task OnInitializedAsync() =>
        Reminder = await ReminderDb.GetReminder(ReminderId);

    private async Task DeleteReminder()
    {
        await ReminderDb.DeleteReminder(ReminderId);

        NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
    }
}
