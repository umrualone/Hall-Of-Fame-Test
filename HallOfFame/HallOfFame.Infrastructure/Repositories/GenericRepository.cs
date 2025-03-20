using HallOfFame.Domain.Interfaces.Repositories;
using HallOfFame.Domain.Models;
using HallOfFame.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HallOfFame.Infrastructure.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : BaseModel
    {
        private readonly AppDbContext _context;
        protected readonly DbSet<TModel> _dataBase;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dataBase = context.Set<TModel>();
        }

        public virtual async Task<List<TModel>> GetAllAsync()
        {
            return await _dataBase.ToListAsync();
        }

        public virtual async Task<TModel> GetByIdAsync(long id)
        {
            return await _dataBase.FindAsync(id);
        }

        public virtual async Task AddAsync(TModel model)
        {
            await _dataBase.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(TModel model)
        {
            _dataBase.Update(model);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Remove(TModel model)
        {
            _dataBase.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
