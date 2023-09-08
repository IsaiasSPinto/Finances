namespace WebApi.Controllers;

public class ApiController : ControllerBase
{
    protected readonly IMediator _mediator;
    public ApiController(IMediator mediator)
    {
        _mediator = mediator;
    }
}
