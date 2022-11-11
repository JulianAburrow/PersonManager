using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IReminderData
    {
        ReminderModel GetReminder(int reminderId);

        List<ReminderModel> GetReminders();

        void InsertReminder(ReminderModel reminder);

        void UpdateReminder(ReminderModel reminder);

        void DeleteReminder(int reminderId);
    }
}
