using Application.Abstractions.Messaging;

namespace Application.Users.Queries.GetUserById;

public class GetUserByIdQuery : IQuery<UserDto>
{
    public GetUserByIdQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}


