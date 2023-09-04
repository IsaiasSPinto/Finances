using AutoMapper;
using Domain.Shared;
using Domain.Users;
using MediatR;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public CreateUserCommandHandler(IUserRepository userRepository , IMapper mapper)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {

        await _userRepository.AddAsync(_mapper.Map<User>(request));

        return new Result(true);
    }
}
