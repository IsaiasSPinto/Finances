using Domain.Users;

namespace Domain.Categories;

public class UserCategory : Category
{
    public User User { get; set; }
    public Guid UserId { get; set; }
}
