using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResultValue>
{
    public async Task<ResultValue> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
