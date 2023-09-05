namespace Application.Users.Queries;

public class UserQueryResult
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
}
