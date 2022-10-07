using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayAddressModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Town { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(15, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "{0} is required")]
        [Display(Name = "Address Type")]
        public int AddressTypeId { get; set; }

        public DisplayAddressTypeModel AddressType { get; set; }
    }
}
