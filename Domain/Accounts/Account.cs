using Domain.Primitives;
using Domain.Transactions;
using Domain.Users;

namespace Domain.Accounts;

public class Account : Entity<Guid>
{
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
