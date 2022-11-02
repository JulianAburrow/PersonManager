using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

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
