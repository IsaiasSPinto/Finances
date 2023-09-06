using Domain.Primitives;
using Domain.Shared;

namespace Infrastructure.Repositories;

public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Entity<TKey>
{
    public readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task DeleteAsync(TKey id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity == null)
            throw new Exception("Entity Not Found");

        _context.Set<TEntity>().Remove(entity);
    }


    public async Task<TEntity> GetByIdAsync(TKey id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }
}
