using Application.Abstractions.Auth;
using Application.Abstractions.Messaging;
using Domain.Common.Models;
using Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Command.RefreshToken;

public class RefreshTokenCommandHandler : ICommandHandler<RefreshTokenCommand, LoginResponse>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;

    public RefreshTokenCommandHandler(IJwtTokenGenerator jwtTokenGenerator, UserManager<User> userManager)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
    }

    public async Task<Result<LoginResponse>> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
    {
        var principal = _jwtTokenGenerator.GetPrincipalFromExpiredToken(request.Token);
        var username = principal.Identity?.Name;
        var user = await _userManager.FindByNameAsync(username);
        if (user is null || user.RefreshToken != request.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
        {
            return Result.Failure<LoginResponse>(new Error("RefreshToken", "Invalid Refresh Token"));
        }

        var newJwtToken = _jwtTokenGenerator.GenerateToken(user);
        var newRefreshToken = _jwtTokenGenerator.GenerateRefreshToken();
        user.RefreshToken = newRefreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(30);
        await _userManager.UpdateAsync(user);
        return Result<LoginResponse>.Success(new LoginResponse
        {
            Email = user.Email,
            Name = user.UserName,
            Token = newJwtToken,
            RefreshToken = newRefreshToken
        });
    }
}
