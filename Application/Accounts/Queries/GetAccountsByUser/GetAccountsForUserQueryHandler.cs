using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Accounts;
using Domain.Common.Models;

namespace Application.Accounts.Queries.GetAccountsByUser;

public class GetAccountsForUserQueryHandler : IQueryHandler<GetAccountsForUserQuery, IEnumerable<AccountDto>>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public GetAccountsForUserQueryHandler(IMapper mapper, IAccountRepository accountRepository)
    {
        _mapper = mapper;
        _accountRepository = accountRepository;
    }

    public async Task<Result<IEnumerable<AccountDto>>> Handle(GetAccountsForUserQuery request, CancellationToken cancellationToken)
    {
        var result = await _accountRepository.GetAccountsByUserId(request.UserId);

        return Result<IEnumerable<AccountDto>>.Success(_mapper.Map<IEnumerable<AccountDto>>(result));
    }
}
