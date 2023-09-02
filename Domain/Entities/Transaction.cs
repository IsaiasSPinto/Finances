using Domain.Enuns;

namespace Domain.Entities;
public class Transaction : Entity<Guid>
{
    public string Description { get; set; } = null!;
    public decimal Amount { get; set; }
    public Guid AccountId { get; set; }
    public Account Account { get; set; } = null!;
    public Guid? CategoryId { get; set; } = null;
    public Category? Category { get; set; } = null;
    public TrasactionType Type { get; set; }

}
