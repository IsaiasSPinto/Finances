using Domain.Accounts;
using Domain.Categories;
using Domain.Common.Models;
using Domain.Transactions.Enums;

namespace Domain.Transactions;
public class Transaction : Entity<Guid>
{
    public Transaction(Guid id) : base(id)
    {
    }

    public Transaction()
    {
    }

    public string Description { get; set; }
    public decimal Amount { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; }

    public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }

    public TrasactionType Type { get; set; }

}
