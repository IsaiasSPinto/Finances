namespace Application.Users.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<UserDto>
{
    public int Id { get; set; }
}


