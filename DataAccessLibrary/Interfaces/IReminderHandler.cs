namespace DataAccessLibrary.Interfaces;

public interface IReminderHandler
{
    Task<ReminderModel> GetReminder(int reminderId);

    Task<List<ReminderModel>> GetAllReminders();

    Task<List<ReminderModel>> GetCurrentReminders();

    Task InsertReminder(ReminderModel reminder);

    Task UpdateReminder(ReminderModel reminder);

    Task DeleteReminder(int reminderId);
}
