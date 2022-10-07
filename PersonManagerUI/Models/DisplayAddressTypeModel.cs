using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayAddressTypeModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Address Type")]
        public string AddressTypeName { get; set; }

        public ICollection<DisplayAddressModel> Addresses { get; set; }
    }
}
