using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ApiController : ControllerBase
{
    protected readonly IMediator _mediator;
    public ApiController(IMediator mediator)
    {
        _mediator = mediator;
    }
}
