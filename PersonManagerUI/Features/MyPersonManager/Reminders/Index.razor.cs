namespace PersonManagerUI.Features.MyPersonManager.Reminders;

public partial class Index
{
    private List<ReminderModel> Reminders;

    protected override async Task OnInitializedAsync() =>
        Reminders = await ReminderDb.GetAllReminders();
}
