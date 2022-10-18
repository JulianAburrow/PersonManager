using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Interfaces
{
    public interface IPersonData
    {
        PersonModel GetPerson(int personId);

        List<PersonModel> GetPeople();

        void InsertPerson(PersonModel person);

        void UpdatePerson(PersonModel person);

        void DeletePerson(int personId);

        List<string> GetInitials();
    }
}