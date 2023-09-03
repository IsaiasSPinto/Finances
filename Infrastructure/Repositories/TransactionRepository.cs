using Domain.Transactions;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class TransactionRepository : Repository, ITransactionRepository
{
    public TransactionRepository(ApplicationDbContext context) : base(context)
    {
    }
}
