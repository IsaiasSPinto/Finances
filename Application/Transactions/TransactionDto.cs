using Application.Categories;
using Domain.Transactions;

namespace Application.Transactions;

public class TransactionDto
{
    public Guid Id { get; set; }
    public string Description { get; set; } = null!;
    public decimal Amount { get; set; }
    public TrasactionType Type { get; set; }

    public Guid AccountId { get; set; }

    public CategoryDto Category { get; set; }
}
