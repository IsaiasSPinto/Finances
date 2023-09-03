using Infrastructure.Context;

namespace Infrastructure.Repositories;

public abstract class Repository
{
    protected readonly ApplicationDbContext _context;

    protected Repository(ApplicationDbContext context)
    {
        _context = context;
    }
}
