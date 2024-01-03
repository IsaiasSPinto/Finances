using Application.Abstractions;
using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Common.Models;
using Domain.Transactions;

namespace Application.Transactions.Commands.CreateTransaction;

public class CreateTransactionCommandHandler : ICommandHandler<CreateTransactionCommand, TransactionDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITransactionRepository _transactionRepository;
    private readonly IMapper _mapper;
    public CreateTransactionCommandHandler(IUnitOfWork unitOfWork, ITransactionRepository transactionRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _transactionRepository = transactionRepository;
        _mapper = mapper;
    }

    public async Task<Result<TransactionDto>> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
    {
        var transaction = _mapper.Map<Transaction>(request);

        await _transactionRepository.AddAsync(transaction);
        await _unitOfWork.CommitAsync(cancellationToken);

        var transactionDto = _mapper.Map<TransactionDto>(transaction);

        return Result<TransactionDto>.Success(transactionDto);
    }
}
