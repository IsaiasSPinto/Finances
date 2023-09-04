using Application.Users.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
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

    [HttpPost]
    public async Task<IActionResult> Post(CreateUserCommand user)
    {
        var result = await _mediator.Send(user);

        if(!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

}
