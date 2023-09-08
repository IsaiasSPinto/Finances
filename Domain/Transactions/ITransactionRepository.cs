using Domain.Shared;

namespace Domain.Transactions;

public interface ITransactionRepository : IRepository<Transaction, Guid>
{

}
