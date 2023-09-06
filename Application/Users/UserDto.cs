using Application.Accounts;

namespace Application.Users;

public class UserDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<AccountDto> Accounts { get; set; } = new List<AccountDto>();

}
