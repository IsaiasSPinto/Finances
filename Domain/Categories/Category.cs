using Domain.Primitives;
using Domain.Transactions;
using Domain.Users;

namespace Domain.Categories;

public class Category : Entity<Guid>
{
    public string Name { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
