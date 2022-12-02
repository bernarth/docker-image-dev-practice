using Domain;

namespace Repository
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPeople();
        Task<bool> InsertPerson(Person person);
    }
}
