using Application.Abstractions.Auth;
using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Shared;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Command.Login;

public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginResponse>
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IJwtTokenGenerator _jwtGenerator;

    public LoginCommandHandler(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IJwtTokenGenerator jwtGenerator)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtGenerator = jwtGenerator;
    }

    public async Task<Result<LoginResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user == null)
        {
            return Result<LoginResponse>.Failure(new Error("Authenticate", "Invalid Credentials"));
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        if (!result.Succeeded)
        {
            return Result<LoginResponse>.Failure(new Error("Authenticate", "Invalid Credentials"));
        }

        var token = _jwtGenerator.GenerateToken(user);

        var userDto = new LoginResponse { Email = user.Email, Name = user.UserName, Token = token };

        return Result<LoginResponse>.Success(userDto);
    }
}


