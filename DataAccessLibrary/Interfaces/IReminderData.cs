﻿using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IReminderData
    {
        Task<ReminderModel> GetReminder(int reminderId);

        Task<List<ReminderModel>> GetAllReminders();

        Task<List<ReminderModel>> GetCurrentReminders();

        Task InsertReminder(ReminderModel reminder);

        Task UpdateReminder(ReminderModel reminder);

        Task DeleteReminder(int reminderId);
    }
}
