using Application.Abstractions;
using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Accounts;
using Domain.Shared;

namespace Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandler : ICommandHandler<CreateAccountCommand, Guid>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public CreateAccountCommandHandler(IAccountRepository account,IMapper mapper, IUnitOfWork unitOfWork)
    {
        _accountRepository = account;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
      
    public async Task<Result<Guid>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = _mapper.Map<Account>(request);

        await _accountRepository.AddAsync(account);

        await _unitOfWork.CommitAsync(cancellationToken);

        return Result<Guid>.Success(account.Id);
    }
}
