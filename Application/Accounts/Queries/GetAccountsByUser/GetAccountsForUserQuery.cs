using Application.Abstractions.Messaging;

namespace Application.Accounts.Queries.GetAccountsByUser;

public class GetAccountsForUserQuery : IQuery<IEnumerable<AccountDto>>
{
    public GetAccountsForUserQuery(Guid id)
    {
        UserId = id;
    }

    public Guid UserId { get; }
}
