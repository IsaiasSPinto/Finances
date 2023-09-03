using Domain.Users;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class UserRepository : Repository, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}
