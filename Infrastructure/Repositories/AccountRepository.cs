namespace Infrastructure.Repositories;

public class AccountRepository : Repository<Account, Guid>, IAccountRepository
{
    public AccountRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Account>> GetAccountsByUserId(Guid userId)
    {
        return await _context.Accounts.Include(x => x.Transactions).ThenInclude(x => x.Category).Where(x => x.UserId == userId.ToString()).ToListAsync();
    }
}
