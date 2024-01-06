using Domain.Users;
using System.Security.Claims;

namespace Application.Abstractions.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
    string GenerateRefreshToken();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}
