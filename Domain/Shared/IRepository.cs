using Domain.Primitives;

namespace Domain.Shared;

public interface IRepository<TEntity, TKey> where  TEntity : Entity<TKey>
{
    public Task AddAsync(TEntity entity);
    public Task<TEntity> GetByIdAsync(TKey id);
    public Task<List<TEntity>> GetAllAsync();
    public void UpdateAsync(TEntity entity);
    public void DeleteAsync(TEntity entity);
}