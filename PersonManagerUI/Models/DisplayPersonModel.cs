using System;
using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayPersonModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(15, ErrorMessage = "{0} cannot be more than {1} characters")]
        [MinLength(5, ErrorMessage = "{0} must be at least {1} characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(15, ErrorMessage = "{0} cannot be more than {1} characters")]
        [MinLength(5, ErrorMessage = "{0} must be at least {1} characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "{0} is required")]
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public DisplayCountryModel Country { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "{0} is required")]
        [Display(Name = "Status")]
        public int StatusId { get; set; }
        public DisplayStatusesModel Status { get; set; }
    }
}
