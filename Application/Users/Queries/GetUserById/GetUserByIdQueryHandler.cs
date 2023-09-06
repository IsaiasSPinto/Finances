using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Shared;
using Domain.Users;

namespace Application.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDto>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }


    public async Task<Result<UserDto>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.Id);

        if (user == null)
        {
            return new Result<UserDto>(false, new Error("Not Found", "User not Found"));
        }

        var result = _mapper.Map<UserDto>(user);

        return Result<UserDto>.Success(result);
    }
}
