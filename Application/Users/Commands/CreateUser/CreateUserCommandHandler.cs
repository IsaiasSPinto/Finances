using Application.Abstractions;
using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Shared;
using Domain.Users;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, UserDto>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(IUserRepository userRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<UserDto>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {

        var user = await _userRepository.AddAsync(_mapper.Map<User>(request));

        await _unitOfWork.CommitAsync(cancellationToken);

        var result = _mapper.Map<UserDto>(user);

        return Result<UserDto>.Success(result);
    }
}
