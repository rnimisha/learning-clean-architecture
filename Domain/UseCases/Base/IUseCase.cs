
namespace Clean.Domain.Usecases;

public interface IUseCase<TEntity>{

    Task<TEntity> GetOneAsync(Guid id);

    Task<IEnumerable<TEntity>> GetAllAsync();

    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);

}