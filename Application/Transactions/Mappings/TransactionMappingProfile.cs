using Application.Transactions.Commands.CreateTransaction;
using AutoMapper;
using Domain.Transactions;

namespace Application.Transactions.Mappings;

public class TransactionMappingProfile : Profile
{
    public TransactionMappingProfile()
    {
        CreateMap<CreateTransactionCommand, Transaction>();
        CreateMap<Transaction, TransactionDto>();
    }
}
