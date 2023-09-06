using Application.Abstractions;
using Application.Abstractions.Messaging;
using Application.Users.Queries;
using AutoMapper;
using Domain.Shared;
using Domain.Users;
using MediatR;

namespace Application.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, UserDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateUserCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<Result<UserDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var updatedUser = _mapper.Map<User>(request);

        _userRepository.Update(updatedUser);

        await _unitOfWork.CommitAsync(cancellationToken);

        var result = _mapper.Map<UserDto>(updatedUser);

        return Result<UserDto>.Success(result);
    }
}
