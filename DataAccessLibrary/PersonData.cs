using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
                .SingleOrDefault(p => p.PersonId == personId);
        }

        public List<PersonModel> GetPeople()
        {
            return _context.People.ToList();
        }

        public void InsertPerson(PersonModel person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public void UpdatePerson(PersonModel person)
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

            _context.SaveChanges();
        }

        public void DeletePerson(int personId)
        {
            var person = _context.People
                .SingleOrDefault(p =>
                    p.PersonId == personId);
            if (person == null) return;

            _context.People.Remove(person);
            _context.SaveChanges();
        }
    }
}
