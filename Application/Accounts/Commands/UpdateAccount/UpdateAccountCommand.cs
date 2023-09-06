using Application.Accounts.Commands.CreateAccount;

namespace Application.Accounts.Commands.UpdateAccount;

public class UpdateAccountCommand : CreateAccountCommand
{
    public Guid Id { get; set; }
}
