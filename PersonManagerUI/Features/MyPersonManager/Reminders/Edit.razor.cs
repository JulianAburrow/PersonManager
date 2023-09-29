namespace PersonManagerUI.Features.MyPersonManager.Reminders;

public partial class Edit
{
    protected override async Task OnInitializedAsync()
    {
        var reminderModel = await ReminderDb.GetReminder(ReminderId);

        DisplayReminder.Title = reminderModel.Title;
        DisplayReminder.ReminderDate = reminderModel.ReminderDate;
        DisplayReminder.Notes = reminderModel.Notes;
        DisplayReminder.IsCurrent = reminderModel.IsCurrent;
    }

    private async Task UpdateReminder()
    {
        var reminderModel = new ReminderModel
        {
            ReminderId = ReminderId,
            Title = DisplayReminder.Title,
            ReminderDate = DisplayReminder.ReminderDate,
            Notes = DisplayReminder.Notes,
            IsCurrent = DisplayReminder.IsCurrent
        };

        await ReminderDb.UpdateReminder(reminderModel);

        NavigationManager.NavigateTo("data/mypersonmanager/reminders/index");
    }
}
