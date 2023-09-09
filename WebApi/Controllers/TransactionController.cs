using Application.Transactions.Commands.CreateTransaction;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers;


[ApiController]
[Route("[controller]")]
[Authorize]
public class TransactionController : ApiController
{
    public TransactionController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok("Foi");
    }


    [HttpPost]
    public async Task<IActionResult> Create(CreateTransactionCommand command)
    {
        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return CreatedAtAction(nameof(Index), result.Value.Id, result.Value);
    }
}
