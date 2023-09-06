using Application.Users.Commands.CreateUser;

namespace Application.Users.Commands.UpdateUser;

public class UpdateUserCommand : CreateUserCommand
{
    public Guid Id { get; set; }
}
