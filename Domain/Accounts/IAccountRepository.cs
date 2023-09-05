using Domain.Shared;

namespace Domain.Accounts;

public interface IAccountRepository : IRepository<Account, Guid>
{
    Task<IEnumerable<Account>> GetAccountsByUserId(Guid userId);
}
