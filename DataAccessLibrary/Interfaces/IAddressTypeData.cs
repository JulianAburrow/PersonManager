using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Interfaces
{
    public interface IAddressTypeData
    {
        Task<AddressTypeModel> GetAddressType(int addressTypeId);

        Task<List<AddressTypeModel>> GetAddressTypes();

        Task InsertAddressType(AddressTypeModel addressType);

        Task UpdateAddressType(AddressTypeModel addressType);

        Task DeleteAddressType(int addressTypeId);

        bool AddressTypeExists(string addressTypeName);
    }
}
