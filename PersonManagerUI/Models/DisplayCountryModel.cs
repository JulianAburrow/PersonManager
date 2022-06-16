using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayCountryModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}
