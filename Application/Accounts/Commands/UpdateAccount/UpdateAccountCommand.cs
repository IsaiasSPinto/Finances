using Application.Accounts.Commands.CreateAccount;

namespace Application.Accounts.Commands.UpdateAccount;

public record UpdateAccountCommand(Guid Id, string Name, decimal Budget, Guid UserId) 
: CreateAccountCommand(Name, Budget, UserId);
