using Domain.Accounts;
using Microsoft.AspNetCore.Identity;

namespace Domain.Users;

public class User : IdentityUser
{    
    public ICollection<Account> Accounts  { get; set; }
}
