using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ReminderData : IReminderData
    {

        private readonly PersonManagerContext _context;

        public ReminderData(PersonManagerContext context) =>
            _context = context;

        public async Task<ReminderModel> GetReminder(int reminderId)
        {
            return await _context.Reminders
                .SingleOrDefaultAsync(r => r.ReminderId == reminderId);
        }

        public async Task<List<ReminderModel>> GetAllReminders()
        {
            return await _context.Reminders
                .OrderBy(r => r.ReminderDate)
                .ToListAsync();
        }

        public async Task<List<ReminderModel>> GetCurrentReminders()
        {
            return await _context.Reminders
            .Where(r =>
                    r.ReminderDate <= DateTime.Now &&
                    r.IsCurrent)
            .ToListAsync();
        }

        public async Task InsertReminder(ReminderModel reminder)
        {
            _context.Reminders.Add(reminder);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReminder(ReminderModel reminder)
        {
            var oldReminder = _context.Reminders
                .SingleOrDefault(
                    r => r.ReminderId == reminder.ReminderId);
            if (oldReminder == null) return;

            oldReminder.Title = reminder.Title;
            oldReminder.ReminderDate = reminder.ReminderDate;
            oldReminder.Notes = reminder.Notes;
            oldReminder.IsCurrent = reminder.IsCurrent;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteReminder(int reminderId)
        {
            var reminder = _context.Reminders
                .SingleOrDefault(
                    r => r.ReminderId == reminderId);
            if (reminder == null) return;

            _context.Reminders.Remove(reminder);
            await _context.SaveChangesAsync();
        }
    }
}
