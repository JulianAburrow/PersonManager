namespace DataAccessLibrary.Handlers;

public class AddressHandler : IAddressHandler
{
    private readonly PersonManagerContext _context;

    public AddressHandler(PersonManagerContext context) =>
        _context = context;

    public async Task<AddressModel> GetAddress(int addressId)
    {
        return await _context.Addresses
            .SingleOrDefaultAsync(a => a.AddressId == addressId);
    }

    public async Task<List<AddressModel>> GetAddresses(int personId)
    {
        return await _context.Addresses
            .Include(a => a.AddressType)
            .Include(a => a.Person)
            .Where(a => a.PersonId == personId)
            .ToListAsync();
    }

    public async Task InsertAddress(AddressModel address)
    {
        _context.Addresses.Add(address);
        _context.SaveChanges();
        // Also need to insert the addressId into person
        var person = _context.People.Single(p => p.PersonId == address.PersonId);
        person.AddressId = address.AddressId;
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAddress(AddressModel address)
    {
        var oldAddress = _context.Addresses
            .SingleOrDefault(a => a.AddressId == address.AddressId);
        if (oldAddress == null) return;

        oldAddress.AddressLine1 = address.AddressLine1;
        oldAddress.AddressLine2 = address.AddressLine2;
        oldAddress.Town = address.Town;
        oldAddress.Postcode = address.Postcode;
        oldAddress.AddressTypeId = address.AddressTypeId;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAddress(int personId)
    {
        var address = _context.Addresses
            .SingleOrDefault(a => a.PersonId == personId);
        if (address == null) return;

        _context.Addresses.Remove(address);
        await _context.SaveChangesAsync();
    }
}
