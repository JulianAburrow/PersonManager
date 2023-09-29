using DataAccessLibrary.Data;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class AddressTypeData : IAddressTypeData
    {
        private readonly PersonManagerContext _context;

        public AddressTypeData(PersonManagerContext context) =>
            _context = context;

        public async Task<AddressTypeModel> GetAddressType(int addressTypeId)
        {
            return await _context.AddressTypes
                .Include(a => a.Addresses)
                .SingleOrDefaultAsync(a => a.AddressTypeId == addressTypeId);
        }

        public async Task<List<AddressTypeModel>> GetAddressTypes()
        {
            return await _context.AddressTypes
                .Include(a => a.Addresses)
                .OrderBy(a => a.AddressTypeName)
                .ToListAsync();
        }

        public async Task InsertAddressType(AddressTypeModel addressType)
        {
            _context.AddressTypes.Add(addressType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAddressType(AddressTypeModel addressType)
        {
            var oldAddressType = _context.AddressTypes
                .SingleOrDefault(a => a.AddressTypeId == addressType.AddressTypeId);
            if (oldAddressType == null) return;

            oldAddressType.AddressTypeName = addressType.AddressTypeName;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAddressType(int addressTypeId)
        {
            var addressType = _context.AddressTypes
                .SingleOrDefault(a => a.AddressTypeId == addressTypeId);
            if (addressType == null) return;

            _context.AddressTypes.Remove(addressType);
            await _context.SaveChangesAsync();
        }

        public bool AddressTypeExists(string addressTypeName)
        {
            return _context.AddressTypes
                .Any(a =>
                        a.AddressTypeName
                        .ToLower() == addressTypeName);
        }
    }
}
