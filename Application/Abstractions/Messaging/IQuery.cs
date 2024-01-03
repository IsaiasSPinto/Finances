using Domain.Common.Models;
using MediatR;

namespace Application.Abstractions.Messaging;

public class IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
