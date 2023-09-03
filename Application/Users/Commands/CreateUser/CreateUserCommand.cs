using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<ResultValue>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
