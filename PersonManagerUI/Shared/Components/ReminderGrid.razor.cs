namespace PersonManagerUI.Shared.Components
{
    public partial class ReminderGrid
    {
        [Parameter] public bool ShowAllReminders { get; set; }

        [Parameter] public List<ReminderModel> Reminders { get; set; }
    }
}
