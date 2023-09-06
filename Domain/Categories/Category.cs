using Domain.Primitives;
using Domain.Transactions;

namespace Domain.Categories;

public class Category : Entity<Guid>
{
    public string Name { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
