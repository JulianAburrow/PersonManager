using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace PersonManagerUI.Models
{
    public class DisplaySavedUrlModel
    {
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Url]
        public string Url { get; set; }

        [StringLength(250, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Notes { get; set; }

        public bool IsExternal { get; set; }
    }
}
