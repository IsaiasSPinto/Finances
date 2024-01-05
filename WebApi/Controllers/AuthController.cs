using Application.Authentication.Command.Login;
using Application.Authentication.Command.RegisterCommand;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers;

[Route("[controller]")]
[ApiController]
[AllowAnonymous]
public class AuthController : ApiController
{
    public AuthController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register(RegisterCommand request)
    {
        var result = await _mediator.Send(request);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginCommand request)
    {
        var result = await _mediator.Send(request);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }

    [HttpPost("refreshToken")]
    public async Task<ActionResult> RefreshToken(LoginCommand request)
    {
        var result = await _mediator.Send(request);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }

}
