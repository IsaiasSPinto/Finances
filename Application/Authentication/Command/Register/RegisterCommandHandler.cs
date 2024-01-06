using Application.Abstractions.Auth;
using Application.Abstractions.Messaging;
using Domain.Common.Models;
using Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Command.RegisterCommand;

public class RegisterCommandHandler : ICommandHandler<RegisterCommand, LoginResponse>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;
    public RegisterCommandHandler(UserManager<User> userManager, IJwtTokenGenerator jwtTokenGenerator)
    {
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public async Task<Result<LoginResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var user = new User { UserName = request.Name, Email = request.Email };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return Result.Failure<LoginResponse>(new Error("Register", "User Registration Failed"));
        }

        var token = _jwtTokenGenerator.GenerateToken(user);
        var refreshToken = _jwtTokenGenerator.GenerateRefreshToken();
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(30);

        var userDto = new LoginResponse { Email = user.Email, Name = user.UserName, Token = token, RefreshToken = refreshToken };

        user.RefreshToken = refreshToken;
        await _userManager.UpdateAsync(user);

        return Result.Success(userDto);
    }
}
