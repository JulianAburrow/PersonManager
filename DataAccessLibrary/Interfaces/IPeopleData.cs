using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IPeopleData
    {
        PersonModel GetPerson(int personId);

        List<PersonModel> GetPeople();

        void InsertPerson(PersonModel person);

        void UpdatePerson(PersonModel person);

        void DeletePerson(int personId);
    }
}