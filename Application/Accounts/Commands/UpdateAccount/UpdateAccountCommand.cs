using Application.Abstractions.Messaging;

namespace Application.Accounts.Commands.UpdateAccount;

public class UpdateAccountCommand : ICommand<AccountDto>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Budget { get; set; }
}
