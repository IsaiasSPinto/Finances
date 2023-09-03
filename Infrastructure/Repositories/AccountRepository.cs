using Domain.Accounts;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class AccountRepository : Repository, IAccountRepository
{
    public AccountRepository(ApplicationDbContext context) : base(context)
    {
    }
}
