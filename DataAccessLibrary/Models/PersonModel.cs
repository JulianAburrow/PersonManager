using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("People")]
    public class PersonModel
    {
        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int CountryId { get; set; }
        public int StatusId { get; set; }
        public int? FavouriteColourId { get; set; }
        public CountryModel Country { get; set; }
        public StatusModel Status { get; set; }
        public ColourModel FavouriteColour { get; set; }
    }
}
