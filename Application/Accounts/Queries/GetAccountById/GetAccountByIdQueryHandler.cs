using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Accounts;
using Domain.Shared;

namespace Application.Accounts.Queries.GetAccountById;

public class GetAccountByIdQueryHandler : IQueryHandler<GetAccountByIdQuery, AccountDto>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    public GetAccountByIdQueryHandler(IAccountRepository accountRepository, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<Result<AccountDto>> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(request.Id);

        if (account == null)
        {
            return Result<AccountDto>.Failure(new Error("Not Found", $"Account with id {request.Id} not found"));
        }

        return Result<AccountDto>.Success(_mapper.Map<AccountDto>(account));

    }
}
