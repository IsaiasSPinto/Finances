using Application.Abstractions;
using Application.Abstractions.Messaging;
using Domain.Accounts;
using Domain.Common.Models;

namespace Application.Accounts.Commands.DeleteAccount;

public class DeleteAccountCommandHandler : ICommandHandler<DeleteAccountCommand>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteAccountCommandHandler(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
    {
        _accountRepository = accountRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        await _accountRepository.DeleteAsync(request.Id);
        await _unitOfWork.CommitAsync(cancellationToken);

        return Result.Success();
    }
}
