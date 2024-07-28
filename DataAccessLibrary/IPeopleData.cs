using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task<List<Person>> GetPeople();
        Task InsertPerson(Person person);
    }
}