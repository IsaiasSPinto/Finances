using Application.Abstractions.Messaging;

namespace Application.Accounts.Queries.GetAccountById;

public class GetAccountByIdQuery : IQuery<AccountDto>
{
    public GetAccountByIdQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}
