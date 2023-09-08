using Application.Accounts.Commands.CreateAccount;
using Application.Accounts.Commands.DeleteAccount;
using Application.Accounts.Commands.UpdateAccount;
using Application.Accounts.Queries.GetAccountById;
using Application.Accounts.Queries.GetAccountsByUser;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class AccountController : ApiController
{
    public AccountController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAccountsByUser()
    {
        var userId = Guid.Parse(User.Identity.Name);
        var query = new GetAccountsForUserQuery(userId);

        var result = await _mediator.Send(query);

        return Ok(result.Value);
    }


    [HttpGet]
    [Route("/GetById")]
    public async Task<IActionResult> Get(Guid accountId)
    {
        var query = new GetAccountByIdQuery(accountId);

        var result = await _mediator.Send(query);

        if (!result.IsSuccess)
        {
            return NotFound(result);
        }

        return Ok(result.Value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAccount(CreateAccountCommand command)
    {
        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return CreatedAtAction(nameof(Get), "", result.Value);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAccount(UpdateAccountCommand command)
    {
        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return Ok(result.Value);
    }



    [HttpDelete]
    public async Task<IActionResult> DeleteAccount(Guid id)
    {
        var command = new DeleteAccountCommand(id);

        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return NoContent();
    }



}
