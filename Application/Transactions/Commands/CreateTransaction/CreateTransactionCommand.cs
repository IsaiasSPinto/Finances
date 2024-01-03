using Application.Abstractions.Messaging;
using Domain.Transactions.Enums;

namespace Application.Transactions.Commands.CreateTransaction;

public class CreateTransactionCommand : ICommand<TransactionDto>
{
    public string Description { get; set; } = null!;
    public decimal Amount { get; set; }
    public TrasactionType Type { get; set; }

    public Guid AccountId { get; set; }
    public Guid CategoryId { get; set; }
}


