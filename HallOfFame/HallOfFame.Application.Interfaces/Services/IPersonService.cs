using HallOfFame.Domain.Models;

namespace HallOfFame.Application.Interfaces.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetAll();
        Task<Person> GetById(long id);
        Task<Person> Create(Person person);
        Task<Person> Update(long id, Person person);
        Task Delete(long id);
    }
}
