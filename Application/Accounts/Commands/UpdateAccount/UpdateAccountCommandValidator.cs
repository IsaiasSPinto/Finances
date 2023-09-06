using Application.Accounts.Commands.CreateAccount;
using FluentValidation;

namespace Application.Accounts.Commands.UpdateAccount;

public class UpdateAccountCommandValidator : AbstractValidator<UpdateAccountCommand>
{
    public UpdateAccountCommandValidator()
    {
        RuleFor(p => p.Id).NotNull().NotEmpty();
        Include(new CreateAccountCommandValidator());
    }
}
