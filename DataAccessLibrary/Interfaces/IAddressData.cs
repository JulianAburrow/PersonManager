using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IAddressData
    {
        AddressModel GetAddress(int addressId);

        List<AddressModel> GetAddresses(int personId);

        void InsertAddress(AddressModel address);

        void UpdateAddress(AddressModel address);

        void DeleteAddress(int personId);
    }
}
