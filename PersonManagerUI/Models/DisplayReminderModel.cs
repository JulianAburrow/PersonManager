using System;
using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayReminderModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Reminder Date")]
        public DateTime ReminderDate { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(500, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Notes { get; set; }

        [Display(Name = "Is Current")]
        public bool IsCurrent { get; set; }
    }
}
