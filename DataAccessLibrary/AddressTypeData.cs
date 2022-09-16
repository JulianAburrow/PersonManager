using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;

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
                .SingleOrDefault();
        }

        public void DeleteAddressType(int addressTypeId)
        {
            throw new NotImplementedException();
        }

        public List<AddressTypeModel> GetAddressTypes()
        {
            throw new NotImplementedException();
        }

        public void InsertAddressType(AddressTypeModel addressType)
        {
            throw new NotImplementedException();
        }

        public void UpdateAddressType(AddressTypeModel addressType)
        {
            throw new NotImplementedException();
        }
    }
}
