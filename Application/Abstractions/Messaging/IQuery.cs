using Domain.Shared;
using MediatR;

namespace Application.Abstractions.Messaging;

public class IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
