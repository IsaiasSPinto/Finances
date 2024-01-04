using Application.Abstractions.Messaging;

namespace Application.Accounts.Commands.CreateAccount;

public record CreateAccountCommand(
    string Name,
    decimal Budget,
    Guid UserId
) : ICommand<AccountDto>;
