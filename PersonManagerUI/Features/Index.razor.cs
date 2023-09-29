namespace PersonManagerUI.Features;

public partial class Index : ComponentBase
{
    [Inject] IReminderHandler _reminderDb { get; set; }

    private List<ReminderModel> reminders;

    protected override async Task OnInitializedAsync() =>
        reminders = await _reminderDb.GetCurrentReminders();
}
