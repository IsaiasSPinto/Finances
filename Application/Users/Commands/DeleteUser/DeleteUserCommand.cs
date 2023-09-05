using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.DeleteUser;

public class DeleteUserCommand : IRequest<Result>
{
    public DeleteUserCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
