namespace Infrastructure.Repositories;

public class TransactionRepository : Repository<Transaction, Guid>, ITransactionRepository
{
    public TransactionRepository(ApplicationDbContext context) : base(context)
    {
    }

}
