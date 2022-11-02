﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("Reminders")]
    public class ReminderModel
    {
        [Key]
        public int ReminderId { get; set; }

        public string Title { get; set; }

        public DateTime ReminderDate { get; set; }

        public string Notes { get; set; }

        public bool IsCurrent { get; set; }
    }
}
