using Application.Abstractions.Messaging;

namespace Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommand : ICommand<Guid>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Budget { get; set; }
    public Guid UserId { get; set; }
}
