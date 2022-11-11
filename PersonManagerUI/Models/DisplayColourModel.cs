using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonManagerUI.Models
{
    public class DisplayColourModel
    {
        [Display(Name = "Colour")]
        public string ColourName { get; set; }

        public IList<DisplayPersonModel> People { get; set; }
    }
}
