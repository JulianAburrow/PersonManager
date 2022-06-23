using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("Countries")]
    public class CountryModel
    {
        [Key]
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public ICollection<PersonModel> People { get; set; }
    }
}
