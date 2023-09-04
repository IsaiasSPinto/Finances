using Domain.Users;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class UserRepository : Repository<User,Guid>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}
