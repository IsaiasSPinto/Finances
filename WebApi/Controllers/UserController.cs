using Application.Users.Commands.CreateUser;
using Application.Users.Queries.GetUserById;
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
    public async Task<IActionResult> Get(Guid guid)
    {
        var result = await _mediator.Send(new GetUserByIdQuery(guid));

        if(!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateUserCommand user)
    {
        var result = await _mediator.Send(user);

        if(!result.Success)
        {
            return BadRequest(result);
        }

        return CreatedAtAction(nameof(Get), result.Value);
    }

}
