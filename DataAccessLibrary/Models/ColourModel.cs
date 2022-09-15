using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLibrary.Models
{
    [Table("Colours")]
    public class ColourModel
    {
        [Key]
        public int ColourId { get; set; }

        public string ColourName { get; set; }

        public ICollection<PersonModel> People { get; set; } 
    }
}
