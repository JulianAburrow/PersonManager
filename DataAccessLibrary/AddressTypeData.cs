using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLibrary
{
    public class AddressTypeData : IAddressTypeData
    {
        private readonly PersonManagerContext _context;

        public AddressTypeData(PersonManagerContext context) =>
            _context = context;

        public AddressTypeModel GetAddressType(int addressTypeId)
        {
            return _context.AddressTypes
                .Include(a => a.Addresses)
                .SingleOrDefault(a => a.AddressTypeId == addressTypeId);
        }

        public List<AddressTypeModel> GetAddressTypes()
        {
            return _context.AddressTypes
                .Include(a => a.Addresses)
                .ToList();
        }

        public void InsertAddressType(AddressTypeModel addressType)
        {
            _context.AddressTypes.Add(addressType);
            _context.SaveChanges();
        }

        public void UpdateAddressType(AddressTypeModel addressType)
        {
            var oldAddressType = _context.AddressTypes
                .SingleOrDefault(a => a.AddressTypeId == addressType.AddressTypeId);
            if (oldAddressType == null) return;

            oldAddressType.AddressTypeName = addressType.AddressTypeName;

            _context.SaveChanges();
        }

        public void DeleteAddressType(int addressTypeId)
        {
            var addressType = _context.AddressTypes
                .SingleOrDefault(a => a.AddressTypeId == addressTypeId);
            if (addressType == null) return;

            _context.AddressTypes.Remove(addressType);
            _context.SaveChanges();
        }

        public bool AddressTypeExists(string addressTypeName)
        {
            return _context.AddressTypes.Any(a => a.AddressTypeName.ToLower() == addressTypeName);
        }
    }
}
