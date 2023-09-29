namespace DataAccessLibrary.Interfaces;

public interface IAddressTypeHandler
{
    Task<AddressTypeModel> GetAddressType(int addressTypeId);

    Task<List<AddressTypeModel>> GetAddressTypes();

    Task InsertAddressType(AddressTypeModel addressType);

    Task UpdateAddressType(AddressTypeModel addressType);

    Task DeleteAddressType(int addressTypeId);

    bool AddressTypeExists(string addressTypeName);
}
