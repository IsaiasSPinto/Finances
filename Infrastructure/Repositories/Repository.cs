using Domain.Primitives;
using Domain.Shared;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class Repository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : Entity<TKey>
{
    public readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TEntity entity)
    {
       await _context.Set<TEntity>().AddAsync(entity);
    }

    public void DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(TKey id)
    {
        throw new NotImplementedException();
    }

    public void UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
