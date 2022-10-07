using System.Collections.Generic;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Interfaces
{
    public interface IAddressTypeData
    {
        AddressTypeModel GetAddressType(int addressTypeId);

        List<AddressTypeModel> GetAddressTypes();

        void InsertAddressType(AddressTypeModel addressType);

        void UpdateAddressType(AddressTypeModel addressType);

        void DeleteAddressType(int addressTypeId);

        bool AddressTypeExists(string addressTypeName);
    }
}
