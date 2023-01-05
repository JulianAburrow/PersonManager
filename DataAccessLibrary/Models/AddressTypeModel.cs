using System.Collections.Generic;

namespace DataAccessLibrary.Models
{
    public class AddressTypeModel
    {
        public int AddressTypeId { get; set;}

        public string AddressTypeName { get; set; }

        public ICollection<AddressModel> Addresses { get; set; }
    }
}
