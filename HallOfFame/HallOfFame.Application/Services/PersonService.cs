using HallOfFame.Application.Interfaces.Services;
using HallOfFame.Domain.Exceptions;
using HallOfFame.Domain.Interfaces.Repositories;
using HallOfFame.Domain.Models;

namespace HallOfFame.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<List<Person>> GetAll()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<Person> Create(Person person)
        {
            await _personRepository.AddAsync(person);

            return person;
        }

        public async Task<Person> GetById(long id)
        {
            var person = await _personRepository.GetByIdAsync(id);

            return person ?? throw new NotFoundException("Сотрудник не найден");
        }

        public async Task<Person> Update(long id, Person person)
        {
            var basePerson = await _personRepository.GetByIdAsync(id);

            if (basePerson == null)
                throw new NotFoundException("Сотрудник не найден");

            basePerson.Name = person.Name ?? basePerson.Name;
            basePerson.DisplayName = person.DisplayName ?? basePerson.DisplayName;

            if (person.Skills.Count != 0)
            {
                basePerson.Skills.Clear();
                foreach (var skill in person.Skills)
                {
                    basePerson.Skills.Add(skill);
                }
            }

            await _personRepository.Update(basePerson);

            return basePerson;
        }

        public async Task Delete(long id)
        {
            var person = await _personRepository.GetByIdAsync(id);

            if (person == null)
                throw new NotFoundException("Сотрудник не найден");

            await _personRepository.Remove(person);
        }
    }
}
