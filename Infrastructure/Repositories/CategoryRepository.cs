namespace Infrastructure.Repositories;

public class CategoryRepository : Repository<Category, Guid>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
