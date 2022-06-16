using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagerUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First name is too long")]
        [MinLength(5, ErrorMessage = "First name is too short.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Last name is too long")]
        [MinLength(5, ErrorMessage = "Last name is too short.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
