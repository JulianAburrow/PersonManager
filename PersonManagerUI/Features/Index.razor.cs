namespace PersonManagerUI.Features;

public partial class Index
{
    [Inject] IReminderHandler _reminderDb { get; set; }

    private List<ReminderModel> reminders;

    protected override async Task OnInitializedAsync()
    {
        reminders = await _reminderDb.GetCurrentReminders();
        Snackbar.Add($"{reminders.Count} reminder(s) found", Severity.Info);
        MainLayout.SetHeaderValue("Person Manager");
    }        
}
