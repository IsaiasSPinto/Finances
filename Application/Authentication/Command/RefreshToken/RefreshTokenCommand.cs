using Application.Abstractions.Messaging;
using System.Windows.Input;

namespace Application.Authentication.Command.RefreshToken;


public class RefreshTokenCommand : ICommand<LoginResponse>
{
    public string Token { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
}
