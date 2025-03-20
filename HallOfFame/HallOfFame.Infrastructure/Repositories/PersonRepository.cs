using HallOfFame.Domain.Interfaces.Repositories;
using HallOfFame.Domain.Models;
using HallOfFame.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HallOfFame.Infrastructure.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Person>> GetAllAsync()
        {
            return await _dataBase.Include(p => p.Skills).ToListAsync();
        }

        public override async Task<Person> GetByIdAsync(long id)
        {
            return await _dataBase.Include(p => p.Skills).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
