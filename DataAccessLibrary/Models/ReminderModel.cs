using System;

namespace DataAccessLibrary.Models
{
    public class ReminderModel
    {
        public int ReminderId { get; set; }

        public string Title { get; set; }

        public DateTime ReminderDate { get; set; }

        public string Notes { get; set; }

        public bool IsCurrent { get; set; }
    }
}
