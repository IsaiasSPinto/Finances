using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class UserController : ApiController
{
    public UserController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet] 
    public async Task<IActionResult> Get()
    {

        return Ok();
    }

}
