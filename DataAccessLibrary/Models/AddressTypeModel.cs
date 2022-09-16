using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    [Table("AddressTypes")]
    public class AddressTypeModel
    {
        [Key]
        public int AddressTypeId { get; set;}

        public string AddressTypeName { get; set; }

        public ICollection<AddressModel> Addresses { get; set; }
    }
}
