using Application.Abstractions.Messaging;
using Application.Users.Queries;

namespace Application.Users.Commands.UpdateUser;

public class UpdateUserCommand : ICommand<UserQueryResult>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
