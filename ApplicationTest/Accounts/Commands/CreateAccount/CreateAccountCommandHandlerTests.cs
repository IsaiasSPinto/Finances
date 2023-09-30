using ApplicationTest.Accounts.Commands.TestUtils;

namespace ApplicationTest.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandlerTests
{
    private readonly Mock<IAccountRepository> _accountRepositoryMock;

    public void HandleCreateAccountCommand_ShouldReturnSuccess()
    {
        // Arrange
        var command = CreateAccountCommandUtils.CreateAccount();

        var accountRepositoryMock = new Mock<IAccountRepository>();
    }
}
