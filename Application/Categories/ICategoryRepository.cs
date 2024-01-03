using Domain.Shared;

namespace Domain.Categories;

public interface ICategoryRepository : IRepository<Category, Guid>
{
}
