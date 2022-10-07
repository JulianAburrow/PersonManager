using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class AddressData : IAddressData
    {
        private readonly PersonManagerContext _context;

        public AddressData(PersonManagerContext context) =>
            _context = context;

        public AddressModel GetAddress(int addressId)
        {
            return _context.Addresses
                .SingleOrDefault(a => a.AddressId == addressId);
        }

        public List<AddressModel> GetAddresses(int personId)
        {
            return _context.Addresses
                .Include(a => a.AddressType)
                .Include(a => a.Person)
                .Where(a => a.PersonId == personId)
                .ToList();
        }

        public void InsertAddress(AddressModel address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            // Also need to insert the addressId into person
            var person = _context.People.Single(p => p.PersonId == address.PersonId);
            person.AddressId = address.AddressId;
            _context.SaveChanges();
        }

        public void UpdateAddress(AddressModel address)
        {
            var oldAddress = _context.Addresses
                .SingleOrDefault(a => a.AddressId == address.AddressId);
            if (oldAddress == null) return;

            oldAddress.AddressLine1 = address.AddressLine1;
            oldAddress.AddressLine2 = address.AddressLine2;
            oldAddress.Town = address.Town;
            oldAddress.Postcode = address.Postcode;
            oldAddress.AddressTypeId = address.AddressTypeId;

            _context.SaveChanges();
        }

        public void DeleteAddress(int personId)
        {
            var address = _context.Addresses
                .SingleOrDefault(a => a.PersonId == personId);
            if (address == null) return;

            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }
    }
}
