using Domain.Common.Models;

namespace Domain.Shared;

public interface IRepository<TEntity, TKey> where TEntity : Entity<TKey>
{
    public Task<TEntity> AddAsync(TEntity entity);
    public Task<TEntity> GetByIdAsync(TKey id);
    public void Update(TEntity entity);
    public Task DeleteAsync(TKey entity);
}