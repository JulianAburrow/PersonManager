using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IPersonData
    {
        PersonModel GetPerson(int personId);

        List<PersonModel> GetPeople();

        Task InsertPerson(PersonModel person);

        Task UpdatePerson(PersonModel person);

        Task DeletePerson(int personId);

        List<string> GetInitials();
    }
}