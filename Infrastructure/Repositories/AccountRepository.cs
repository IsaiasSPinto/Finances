using Domain.Accounts;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AccountRepository : Repository<Account, Guid>, IAccountRepository
{
    public AccountRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Account>> GetAccountsByUserId(Guid userId)
    {
        return await _context.Accounts.Where(x => x.UserId == userId).ToListAsync();
    }
}
