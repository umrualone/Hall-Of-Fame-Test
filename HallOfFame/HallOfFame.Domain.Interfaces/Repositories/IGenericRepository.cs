using HallOfFame.Domain.Models;

namespace HallOfFame.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<TModel> where TModel : BaseModel
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(long id);
        Task AddAsync(TModel model);
        Task Update(TModel model);
        Task Remove(TModel model);
    }
}
