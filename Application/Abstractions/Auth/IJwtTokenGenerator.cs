using Microsoft.AspNetCore.Identity;

namespace Application.Abstractions.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(IdentityUser user);
}
