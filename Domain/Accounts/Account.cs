using Domain.Primitives;
using Domain.Transactions;

namespace Domain.Accounts;

public class Account : Entity<Guid>
{
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public Guid UserId { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
