using Application.Abstractions.Messaging;

namespace Application.Accounts.Commands.DeleteAccount;

public class DeleteAccountCommand : ICommand
{
    public DeleteAccountCommand(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}
