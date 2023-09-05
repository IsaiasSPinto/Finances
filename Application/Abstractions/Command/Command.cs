using AutoMapper;

namespace Application.Abstractions.Command;

public abstract class Command 
{
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IMapper _mapper;
    public Command(IMapper mapper , IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
}
