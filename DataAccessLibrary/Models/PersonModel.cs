using System;

namespace DataAccessLibrary.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int CountryId { get; set; }
        //public CountryModel Country { get; set; }
    }
}
