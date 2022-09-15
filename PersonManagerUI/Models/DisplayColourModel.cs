using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagerUI.Models
{
    public class DisplayColourModel
    {
        [Display(Name = "Colour")]
        public string ColourName { get; set; }

        public IList<DisplayPersonModel> People { get; set; }
    }
}
