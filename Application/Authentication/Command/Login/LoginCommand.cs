using Application.Abstractions.Messaging;

namespace Application.Authentication.Command.Login;

public class LoginCommand : ICommand<LoginResponse>
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}
