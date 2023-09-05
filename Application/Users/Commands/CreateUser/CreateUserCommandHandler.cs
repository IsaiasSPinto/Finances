using Application.Abstractions;
using Application.Abstractions.Command;
using AutoMapper;
using Domain.Shared;
using Domain.Users;
using MediatR;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : Command , IRequestHandler<CreateUserCommand, Result<Guid>>
{
    private readonly IUserRepository _userRepository;
    public CreateUserCommandHandler(IUserRepository userRepository , IMapper mapper,IUnitOfWork unitOfWork) : base(mapper,unitOfWork)
    {
        _userRepository = userRepository;
    }


    public async Task<Result<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.AddAsync(_mapper.Map<User>(request));
        await _unitOfWork.CommitAsync(cancellationToken);
        return new Result<Guid>(true, user.Id);
    }
}
