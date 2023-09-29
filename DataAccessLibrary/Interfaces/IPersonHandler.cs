namespace DataAccessLibrary.Interfaces;

public interface IPersonHandler
{
    PersonModel GetPerson(int personId);

    List<PersonModel> GetPeople();

    Task InsertPerson(PersonModel person);

    Task UpdatePerson(PersonModel person);

    Task DeletePerson(int personId);

    List<string> GetInitials();
}