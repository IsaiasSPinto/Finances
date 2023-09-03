using MediatR;

namespace Application.Users.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResultValue>
{
    public Task<ResultValue> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}   

