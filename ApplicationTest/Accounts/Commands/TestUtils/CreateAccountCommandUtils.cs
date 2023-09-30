using Application.Accounts.Commands.CreateAccount;
using ApplicationTest.Accounts.TestUtils.Constants;

namespace ApplicationTest.Accounts.Commands.TestUtils;

public class CreateAccountCommandUtils
{
    public static CreateAccountCommand CreateAccount()
    {
        return new CreateAccountCommand
        (
            Constants.Account.Name,
            Constants.Account.Budget,
            Constants.User.UserId
        );
    }
}
