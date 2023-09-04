using Domain.Shared;

namespace Domain.Users;

public interface IUserRepository : IRepository<User, Guid>
{
}
