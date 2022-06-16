using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        public ISqlDataAccess _db { get; }

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            var sql = "select * from dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            var sql = $@"insert into dbo.People (FirstName, LastName, EmailAddress, DateOfBirth)
                        values (@FirstName, @LastName, @EmailAddress, @DateOfBirth);";

            return _db.SaveData(sql, person);
        }

        public Task<PersonModel> GetPerson(int personId)
        {
            var sql = $"select * from dbo.People where PersonId = {personId}";

            return _db.LoadSingle<PersonModel, dynamic>(sql, new { });
        }

        public Task DeletePerson(int personId)
        {
            var sql = $"delete from dbo.people where PersonId = {personId}";

            return _db.DeleteData(sql);
        }

        public Task UpdatePerson(PersonModel person)
        {
            var dob = person.DateOfBirth;
            var dobString = "NULL";

            if (dob != null)
            {
                dobString = $"'{dob.Value.Year}-{dob.Value.Month}-{dob.Value.Day}' ";
            }

            var sql = $@"update dbo.people set FirstName = '{person.FirstName}',
                    LastName = '{person.LastName}', 
                    EmailAddress = '{person.EmailAddress}', 
                    DateOfBirth = {dobString} 
                    where PersonId = {person.PersonId}";

            return _db.SaveData(sql, person);
        }
    }
}
