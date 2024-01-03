using Domain.Common.Models;
using MediatR;

namespace Application.Abstractions.Messaging;

public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, Result<TResponse>> where TRequest : IRequest<Result<TResponse>>
{
}
