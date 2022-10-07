using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("Addresses")]
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public int AddressTypeId { get; set; }

        public int PersonId { get; set; }

        public AddressTypeModel AddressType { get; set; }

        public PersonModel Person { get; set; }
    }
}
