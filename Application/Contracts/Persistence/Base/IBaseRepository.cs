
namespace Clean.Application.Contracts.Persistence;

public interface IBaseRepository<TEntity>{

    Task<TEntity> GetOneAsync(Guid id);

    Task<IEnumerable<TEntity>> GetAllAsync();

    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);

}