namespace DataAccessLibrary.Interfaces;

public interface IAddressHandler
{
    Task<AddressModel> GetAddress(int addressId);

    Task<List<AddressModel>> GetAddresses(int personId);

    Task InsertAddress(AddressModel address);

    Task UpdateAddress(AddressModel address);

    Task DeleteAddress(int personId);
}
