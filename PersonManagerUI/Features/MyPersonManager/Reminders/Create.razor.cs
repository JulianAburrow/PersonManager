namespace PersonManagerUI.Features.MyPersonManager.Reminders;

public partial class Create
{
    protected override void OnInitialized()
    {
        DisplayReminder.ReminderDate = DateTime.Today;
        DisplayReminder.IsCurrent = true;
    }

    private async Task InsertReminder()
    {
        var reminderModel = new ReminderModel
        {
            Title = DisplayReminder.Title,
            ReminderDate = DisplayReminder.ReminderDate,
            Notes = DisplayReminder.Notes,
            IsCurrent = DisplayReminder.IsCurrent
        };

        await ReminderDb.InsertReminder(reminderModel);

        NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
    }
}
