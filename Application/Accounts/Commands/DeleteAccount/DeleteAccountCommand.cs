using Application.Abstractions.Messaging;

namespace Application.Accounts.Commands.DeleteAccount;

public class DeleteAccountCommand : ICommand
{
    public Guid Id { get; set; }
}
