using Application.Abstractions.Messaging;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommand : ICommand<UserDto>
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}
