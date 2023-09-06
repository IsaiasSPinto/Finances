using Domain.Accounts;
using Domain.Primitives;

namespace Domain.Users;

public class User : Entity<Guid>
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public ICollection<Account> Accounts { get; set; } = new List<Account>();
}
