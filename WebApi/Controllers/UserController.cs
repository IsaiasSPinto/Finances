using Application.Users.Commands.CreateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Commands.UpdateUser;
using Application.Users.Queries.GetUserById;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ApiController
{
    public UserController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetUserById(Guid guid)
    {
        var result = await _mediator.Send(new GetUserByIdQuery(guid));

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand user)
    {
        var result = await _mediator.Send(user);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return CreatedAtAction(nameof(GetUserById), result.Value);
    }

    [HttpPut]
    public async Task<IActionResult> Create(UpdateUserCommand updateUser)
    {
        var result = await _mediator.Send(updateUser);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }


    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _mediator.Send(new DeleteUserCommand(id));

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return NoContent();
    }

}
