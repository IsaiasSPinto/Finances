using Application.Abstractions;
using Application.Accounts;
using Application.Accounts.Commands.CreateAccount;
using Application.Accounts.Mappings;
using ApplicationTest.Accounts.Commands.TestUtils;
using ApplicationTest.Accounts.TestUtils.Accounts.Extensions;
using AutoMapper;
using Domain.Accounts;
using FluentAssertions;
using Moq;
using Xunit;

namespace ApplicationTest.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandlerTests
{
    private readonly Mock<IAccountRepository> _accountRepositoryMock;
    private readonly CreateAccountCommandHandler _handler;
    private readonly Mock<IUnitOfWork> _unitOfWorkMock;
    private readonly IMapper _mapper;

    public CreateAccountCommandHandlerTests()
    {
        _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new AccountMappingProfile())));
        _accountRepositoryMock = new Mock<IAccountRepository>();
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _handler = new CreateAccountCommandHandler(_accountRepositoryMock.Object, _mapper, _unitOfWorkMock.Object);
    }

    [Theory]
    [MemberData(nameof(ValidCreateAccountCommands))]
    public async Task HandleCreateAccountCommand_ShouldReturnSuccess(CreateAccountCommand command)
    {
        // Arrange
        var account = _mapper.Map<Account>(command);
        var accountDto = _mapper.Map<AccountDto>(account);
        // Act
        var result = await _handler.Handle(command, default);

        // Assert
        result.IsSuccess.Should().BeTrue();
        account.ValidateCreatedFrom(command);
        result.Value.Should().BeEquivalentTo(accountDto);
        _accountRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Account>()), Times.Once);
    }

    public static IEnumerable<object[]> ValidCreateAccountCommands()
    {
        yield return new object[]
        {
            CreateAccountCommandUtils.CreateAccount()
        };
    }
}