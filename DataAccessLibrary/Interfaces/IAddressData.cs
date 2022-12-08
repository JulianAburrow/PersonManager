using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IAddressData
    {
        Task<AddressModel> GetAddress(int addressId);

        Task<List<AddressModel>> GetAddresses(int personId);

        Task InsertAddress(AddressModel address);

        Task UpdateAddress(AddressModel address);

        Task DeleteAddress(int personId);
    }
}
