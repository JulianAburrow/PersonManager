using DataAccessLibrary.Data;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PersonData : IPersonData
    {
        private readonly PersonManagerContext _context;

        public PersonData(PersonManagerContext context) =>
            _context = context;

        public PersonModel GetPerson(int personId)
        {
            return _context.People
                .Include(p => p.Country)
                .Include(p => p.Status)
                .Include(p => p.FavouriteColour)
                .Include(p => p.Address)
                    .ThenInclude(a => a.AddressType)
                .SingleOrDefault(p => p.PersonId == personId);
        }

        public List<PersonModel> GetPeople()
        {
            return _context.People.ToList();
        }

        public async Task InsertPerson(PersonModel person)
        {
            _context.People.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePerson(PersonModel person)
        {
            var oldPerson = _context.People
                .SingleOrDefault(p =>
                    p.PersonId == person.PersonId);
            if (oldPerson == null) return;
            
            oldPerson.FirstName = person.FirstName;
            oldPerson.LastName = person.LastName;
            oldPerson.EmailAddress = person.EmailAddress;
            oldPerson.DateOfBirth = person.DateOfBirth;
            oldPerson.CountryId = person.CountryId;
            oldPerson.StatusId = person.StatusId;
            oldPerson.FavouriteColourId = person.FavouriteColourId;
            oldPerson.Skillset = person.Skillset;
            oldPerson.Picture = person.Picture;

            await _context.SaveChangesAsync();
        }

        public async Task DeletePerson(int personId)
        {
            var person = _context.People
                .SingleOrDefault(p =>
                    p.PersonId == personId);
            if (person == null) return;

            if (person.Address != null)
                _context.Remove(person.Address);

            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }

        public List<string> GetInitials()
        {
            return GetPeople()
                .OrderBy(p => p.FirstName)
                .Select(p => p.FirstName.Substring(0, 1))
                .Distinct()
                .ToList();
        }
    }
}
