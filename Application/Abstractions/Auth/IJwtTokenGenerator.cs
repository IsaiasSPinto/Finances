using Domain.Users;

namespace Application.Abstractions.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
