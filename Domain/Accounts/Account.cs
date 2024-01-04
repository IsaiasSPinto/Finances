using Domain.Common.Models;
using Domain.Transactions;
using Domain.Users;

namespace Domain.Accounts;

public class Account : Entity<Guid>
{
    public Account()
    {
    }
    public Account(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public decimal Budget { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
