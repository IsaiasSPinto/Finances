using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Shared;
using Domain.Users;

namespace Application.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserQueryResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public GetUserByIdQueryHandler(IUserRepository userRepository,IMapper mapper)
    {
        _userRepository = userRepository;   
        _mapper = mapper;
    }


    public async Task<Result<UserQueryResult>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _userRepository.GetByIdAsync(request.Id);

        if(result is null)
        {
            return new Result<UserQueryResult>(false, new Error("Not Found","User not Found"));
        }

        return new Result<UserQueryResult>(true, _mapper.Map<UserQueryResult>(result));
    }
}
