using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Person>> GetPeople()
        {
            string sql = "SELECT * FROM People";
            return _db.LoadData<Person, dynamic>(sql, new { });
        }

        public Task InsertPerson(Person person)
        {
            string sql = @"INSERT INTO People (FirstName, LastName, EmailAddress)
                VALUES (@FirstName, @LastName, @EmailAddress)";

            return _db.SaveData(sql, person);
        }
    }
}
