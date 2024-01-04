using Domain.Common.Models;
using Domain.Transactions;

namespace Domain.Categories;

public class Category : Entity<Guid>
{
    public Category(Guid id) : base(id)
    {
    }

    public Category()
    {
    }

    public string Name { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
