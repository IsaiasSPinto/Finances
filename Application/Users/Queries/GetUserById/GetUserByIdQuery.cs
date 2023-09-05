using Application.Abstractions.Messaging;
using Domain.Shared;

namespace Application.Users.Queries.GetUserById;

public class GetUserByIdQuery : IQuery<UserQueryResult>
{
    public GetUserByIdQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}


