using Application.Abstractions.Messaging;

namespace Application.Authentication.Command.RegisterCommand;

public class RegisterCommand : ICommand<LoginResponse>
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}

