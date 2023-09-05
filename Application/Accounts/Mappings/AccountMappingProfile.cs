using Application.Accounts.Commands.CreateAccount;
using Application.Accounts.Commands.UpdateAccount;
using AutoMapper;
using Domain.Accounts;

namespace Application.Accounts.Mappings;

public class AccountMappingProfile : Profile
{
    public AccountMappingProfile()
    {
        CreateMap<Account, AccountDto>();
        CreateMap<CreateAccountCommand, Account>();
        CreateMap<UpdateAccountCommand, Account>();
    }
}
