using System.Collections.Generic;

namespace DataAccessLibrary.Models
{
    public class ColourModel
    {
        public int ColourId { get; set; }

        public string ColourName { get; set; }

        public ICollection<PersonModel> People { get; set; } 
    }
}
