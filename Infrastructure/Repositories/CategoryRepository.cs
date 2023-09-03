using Domain.Categories;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class CategoryRepository : Repository, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
