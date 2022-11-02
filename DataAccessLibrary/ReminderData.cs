using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLibrary
{
    public class ReminderData : IReminderData
    {

        private readonly PersonManagerContext _context;

        public ReminderData(PersonManagerContext context) =>
            _context = context;

        public ReminderModel GetReminder(int reminderId)
        {
            return _context.Reminders
                .SingleOrDefault(r => r.ReminderId == reminderId);
        }

        public List<ReminderModel> GetReminders()
        {
            return _context.Reminders
                .ToList();
        }

        public void InsertReminder(ReminderModel reminder)
        {
            _context.Reminders.Add(reminder);
            _context.SaveChanges();
        }

        public void UpdateReminder(ReminderModel reminder)
        {
            var oldReminder = _context.Reminders
                .SingleOrDefault(
                    r => r.ReminderId == reminder.ReminderId);
            if (oldReminder == null) return;

            oldReminder.Title = reminder.Title;
            oldReminder.ReminderDate = reminder.ReminderDate;
            oldReminder.Notes = reminder.Notes;
            oldReminder.IsCurrent = reminder.IsCurrent;

            _context.SaveChanges();
        }

        public void DeleteReminder(int reminderId)
        {
            var reminder = _context.Reminders
                .SingleOrDefault(
                    r => r.ReminderId == reminderId);
            if (reminder == null) return;

            _context.Reminders.Remove(reminder);
            _context.SaveChanges();
        }
    }
}
