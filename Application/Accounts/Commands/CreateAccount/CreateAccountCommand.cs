using Application.Abstractions.Messaging;

namespace Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommand : ICommand<AccountDto>
{
    public string Name { get; set; } = null!;
    public decimal Budget { get; set; }
    public Guid UserId { get; set; }
}
