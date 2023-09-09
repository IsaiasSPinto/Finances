using Application.Abstractions.Auth;
using Application.Abstractions.Messaging;
using Domain.Shared;
using Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Command.RegisterCommand;

public class RegisterCommandHandler : ICommandHandler<RegisterCommand, LoginResponse>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;
    public RegisterCommandHandler( UserManager<User> userManager, IJwtTokenGenerator jwtTokenGenerator)
    {        
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public async Task<Result<LoginResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var user = new User { UserName = request.Name , Email = request.Email };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return Result<LoginResponse>.Failure(new Error("Register", "User Registration Failed"));
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        var userDto = new LoginResponse { Email = user.Email, Name = user.UserName, Token = token };
        

        return Result<LoginResponse>.Success(userDto);
    }
}
