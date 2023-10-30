using Application.Accounts;
using Application.Accounts.Commands.CreateAccount;
using Domain.Accounts;
using FluentAssertions;

namespace ApplicationTest.Accounts.TestUtils.Accounts.Extensions;

public static class AccountExtensions
{
    public static void ValidateCreatedFrom(this Account account, CreateAccountCommand command)
    {
        account.Should().NotBeNull();
        account.Name.Should().Be(command.Name);
        account.Budget.Should().Be(command.Budget);
        account.UserId.Should().Be(command.UserId);
    }
}