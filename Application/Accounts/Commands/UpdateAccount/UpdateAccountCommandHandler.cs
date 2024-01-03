using Application.Abstractions;
using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Accounts;
using Domain.Common.Models;

namespace Application.Accounts.Commands.UpdateAccount;

public class UpdateAccountCommandHandler : ICommandHandler<UpdateAccountCommand, AccountDto>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UpdateAccountCommandHandler(IUnitOfWork unitOfWork, IAccountRepository accountRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<Result<AccountDto>> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = _mapper.Map<Account>(request);

        _accountRepository.Update(account);

        await _unitOfWork.CommitAsync(cancellationToken);

        return Result<AccountDto>.Success(_mapper.Map<AccountDto>(account));
    }
}
