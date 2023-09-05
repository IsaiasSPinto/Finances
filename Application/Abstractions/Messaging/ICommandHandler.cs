using Domain.Shared;
using MediatR;

namespace Application.Abstractions.Messaging;

public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, Result<TResponse>> where TRequest : IRequest<Result<TResponse>>
{  
}

public interface ICommandHandler<TRequest> : IRequestHandler<TRequest, Result> where TRequest : IRequest<Result>
{
}

