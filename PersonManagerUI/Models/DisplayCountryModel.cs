using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayCountryModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        public IList<DisplayPersonModel> People { get; set; }
    }
}
