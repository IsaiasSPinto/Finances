using Application.Transactions;

namespace Application.Accounts;

public class AccountDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public Guid UserId { get; set; }

    public IEnumerable<TransactionDto> Transactions { get; set; } = new List<TransactionDto>();
}
